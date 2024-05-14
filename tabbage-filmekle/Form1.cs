using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace tabbage_filmekle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baglanti = "Server=localhost;Database=sinema_veritabani;Uid=root;Pwd=''";
        string hedefDosya="";

        private void VeriGetir()
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "SELECT *FROM filmler";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvListe.DataSource = dt;
                dgvListe.Invalidate();
                dgvListe.Refresh();

            }
        }



        void ResimSec()
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "resim dosyası |*.jpg;*.nef;*.png|video|*.avi|Tüm dosyalar|*.*";
            dosya.Title = "Dosya Seçin";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string kaynakDosya = dosya.FileName;
                hedefDosya = Path.Combine("resimler", Guid.NewGuid() + ".jpg");


                if (!Directory.Exists("resimler"))
                {
                    Directory.CreateDirectory("resimler");
                }

                File.Copy(kaynakDosya, hedefDosya);
                

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblFilmAd.Text ="Film Adı :"+dgvListe.CurrentRow.Cells[1].Value.ToString();
            lblTur.Text = "Türü :"+dgvListe.CurrentRow.Cells[2].Value.ToString();
            lblYil.Text ="Yılı :"+ dgvListe.CurrentRow.Cells[3].Value.ToString();
            lblImdb.Text = "IMDB Puanı :"+dgvListe.CurrentRow.Cells[4].Value.ToString();
            txtOzet.Text = dgvListe.CurrentRow.Cells[6].Value.ToString();
            pbPoster.ImageLocation = dgvListe.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "DELETE FROM filmler WHERE id=@id";
                int secilenId = Convert.ToInt32(dgvListe.CurrentRow.Cells["id"].Value);

                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", secilenId);

                DialogResult result = MessageBox.Show("Film silinsin mi?", "Film Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    VeriGetir();
                }
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btneEklePoster_Click(object sender, EventArgs e)
        {
            ResimSec();
            pbEklePoster.ImageLocation = hedefDosya;
            pbEklePoster.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "INSERT INTO filmler (filmad,tur,yil,imdb_puan,film_posteri,ozet) VALUES (@filmad,@tur,@yil,@imdb,@poster,@ozet);";

                con.Open();



                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@filmad", txtEkleFilm.Text);
                cmd.Parameters.AddWithValue("@tur", cmbEkleTur.Text);
                cmd.Parameters.AddWithValue("@yil", txtEkleYil.Text);
                cmd.Parameters.AddWithValue("@imdb", txtEklePuan.Text);
                cmd.Parameters.AddWithValue("@poster", hedefDosya);
                cmd.Parameters.AddWithValue("@ozet", txtEkleOzet.Text);



                DialogResult result = MessageBox.Show("Film eklensin mi?", "Film Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();

                    txtEkleFilm.Clear();
                    txtEkleOzet.Clear();
                    txtEklePuan.Clear();
                    txtEkleYil.Clear();
                    cmbEkleTur.SelectedIndex = -1;
                }

                VeriGetir();


            }
        }
    }
}
