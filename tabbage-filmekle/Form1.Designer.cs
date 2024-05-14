namespace tabbage_filmekle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.lblImdb = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblFilmAd = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdb_puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.film_posteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbEkleTur = new System.Windows.Forms.ComboBox();
            this.btneEklePoster = new System.Windows.Forms.Button();
            this.lblEkleOzet = new System.Windows.Forms.Label();
            this.txtEkleOzet = new System.Windows.Forms.TextBox();
            this.pbEklePoster = new System.Windows.Forms.PictureBox();
            this.txtEkleYil = new System.Windows.Forms.TextBox();
            this.txtEklePuan = new System.Windows.Forms.TextBox();
            this.txtEkleFilm = new System.Windows.Forms.TextBox();
            this.lblEkleImdb = new System.Windows.Forms.Label();
            this.lblEkleYil = new System.Windows.Forms.Label();
            this.lblEkleTur = new System.Windows.Forms.Label();
            this.lblEkleFilmAd = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbGTur = new System.Windows.Forms.ComboBox();
            this.btnGPoster = new System.Windows.Forms.Button();
            this.lblGOzet = new System.Windows.Forms.Label();
            this.txtGOzet = new System.Windows.Forms.TextBox();
            this.pbGuncellePoster = new System.Windows.Forms.PictureBox();
            this.txtGYİL = new System.Windows.Forms.TextBox();
            this.txtGImdb = new System.Windows.Forms.TextBox();
            this.txtGFilmAd = new System.Windows.Forms.TextBox();
            this.lblGImdb = new System.Windows.Forms.Label();
            this.lblGYil = new System.Windows.Forms.Label();
            this.lblGTur = new System.Windows.Forms.Label();
            this.lblGFilmAd = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEklePoster)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuncellePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 15);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 645);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.txtOzet);
            this.tabPage1.Controls.Add(this.lblImdb);
            this.tabPage1.Controls.Add(this.lblYil);
            this.tabPage1.Controls.Add(this.lblTur);
            this.tabPage1.Controls.Add(this.lblFilmAd);
            this.tabPage1.Controls.Add(this.pbPoster);
            this.tabPage1.Controls.Add(this.dgvListe);
            this.tabPage1.Location = new System.Drawing.Point(4, 57);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Film Listesi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Lime;
            this.btnGuncelle.Location = new System.Drawing.Point(576, 482);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(145, 56);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(392, 482);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(145, 56);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(321, 337);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOzet.Size = new System.Drawing.Size(477, 101);
            this.txtOzet.TabIndex = 6;
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Location = new System.Drawing.Point(635, 263);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(55, 24);
            this.lblImdb.TabIndex = 5;
            this.lblImdb.Text = "IMDB";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Location = new System.Drawing.Point(350, 301);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(30, 24);
            this.lblYil.TabIndex = 4;
            this.lblYil.Text = "Yıl";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(350, 263);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(39, 24);
            this.lblTur.TabIndex = 3;
            this.lblTur.Text = "Tür";
            // 
            // lblFilmAd
            // 
            this.lblFilmAd.AutoSize = true;
            this.lblFilmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAd.Location = new System.Drawing.Point(349, 224);
            this.lblFilmAd.Name = "lblFilmAd";
            this.lblFilmAd.Size = new System.Drawing.Size(101, 29);
            this.lblFilmAd.TabIndex = 2;
            this.lblFilmAd.Text = "Film Adı";
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(470, 6);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(164, 186);
            this.pbPoster.TabIndex = 1;
            this.pbPoster.TabStop = false;
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.filmad,
            this.tur,
            this.yil,
            this.imdb_puan,
            this.film_posteri,
            this.ozet});
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvListe.Location = new System.Drawing.Point(3, 3);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(312, 578);
            this.dgvListe.TabIndex = 0;
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // filmad
            // 
            this.filmad.DataPropertyName = "filmad";
            this.filmad.HeaderText = "Filmin Adı";
            this.filmad.Name = "filmad";
            this.filmad.ReadOnly = true;
            // 
            // tur
            // 
            this.tur.DataPropertyName = "tur";
            this.tur.HeaderText = "Türü";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            // 
            // yil
            // 
            this.yil.DataPropertyName = "yil";
            this.yil.HeaderText = "Yıl";
            this.yil.Name = "yil";
            this.yil.ReadOnly = true;
            this.yil.Visible = false;
            // 
            // imdb_puan
            // 
            this.imdb_puan.DataPropertyName = "imdb_puan";
            this.imdb_puan.HeaderText = "IMDB Puanı";
            this.imdb_puan.Name = "imdb_puan";
            this.imdb_puan.ReadOnly = true;
            // 
            // film_posteri
            // 
            this.film_posteri.DataPropertyName = "film_posteri";
            this.film_posteri.HeaderText = "Film Posteri";
            this.film_posteri.Name = "film_posteri";
            this.film_posteri.ReadOnly = true;
            this.film_posteri.Visible = false;
            // 
            // ozet
            // 
            this.ozet.DataPropertyName = "ozet";
            this.ozet.HeaderText = "Özet";
            this.ozet.Name = "ozet";
            this.ozet.ReadOnly = true;
            this.ozet.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.cmbEkleTur);
            this.tabPage2.Controls.Add(this.btneEklePoster);
            this.tabPage2.Controls.Add(this.lblEkleOzet);
            this.tabPage2.Controls.Add(this.txtEkleOzet);
            this.tabPage2.Controls.Add(this.pbEklePoster);
            this.tabPage2.Controls.Add(this.txtEkleYil);
            this.tabPage2.Controls.Add(this.txtEklePuan);
            this.tabPage2.Controls.Add(this.txtEkleFilm);
            this.tabPage2.Controls.Add(this.lblEkleImdb);
            this.tabPage2.Controls.Add(this.lblEkleYil);
            this.tabPage2.Controls.Add(this.lblEkleTur);
            this.tabPage2.Controls.Add(this.lblEkleFilmAd);
            this.tabPage2.Location = new System.Drawing.Point(4, 57);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Film Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(142, 389);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(582, 70);
            this.btnKaydet.TabIndex = 74;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbEkleTur
            // 
            this.cmbEkleTur.FormattingEnabled = true;
            this.cmbEkleTur.Items.AddRange(new object[] {
            "Komedi",
            "Dram",
            "Aksiyon",
            "Korku",
            "Gerilim",
            "Fantezi",
            "Aşk",
            "Animasyon",
            "Bilim Kurgu"});
            this.cmbEkleTur.Location = new System.Drawing.Point(142, 83);
            this.cmbEkleTur.Name = "cmbEkleTur";
            this.cmbEkleTur.Size = new System.Drawing.Size(349, 32);
            this.cmbEkleTur.TabIndex = 73;
            // 
            // btneEklePoster
            // 
            this.btneEklePoster.Location = new System.Drawing.Point(512, 42);
            this.btneEklePoster.Name = "btneEklePoster";
            this.btneEklePoster.Size = new System.Drawing.Size(223, 48);
            this.btneEklePoster.TabIndex = 72;
            this.btneEklePoster.Text = "Poster Seçin";
            this.btneEklePoster.UseVisualStyleBackColor = true;
            this.btneEklePoster.Click += new System.EventHandler(this.btneEklePoster_Click);
            // 
            // lblEkleOzet
            // 
            this.lblEkleOzet.AutoSize = true;
            this.lblEkleOzet.Location = new System.Drawing.Point(83, 194);
            this.lblEkleOzet.Name = "lblEkleOzet";
            this.lblEkleOzet.Size = new System.Drawing.Size(49, 24);
            this.lblEkleOzet.TabIndex = 59;
            this.lblEkleOzet.Text = "Özet";
            // 
            // txtEkleOzet
            // 
            this.txtEkleOzet.Location = new System.Drawing.Point(142, 191);
            this.txtEkleOzet.Multiline = true;
            this.txtEkleOzet.Name = "txtEkleOzet";
            this.txtEkleOzet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEkleOzet.Size = new System.Drawing.Size(349, 151);
            this.txtEkleOzet.TabIndex = 58;
            // 
            // pbEklePoster
            // 
            this.pbEklePoster.Location = new System.Drawing.Point(531, 96);
            this.pbEklePoster.Name = "pbEklePoster";
            this.pbEklePoster.Size = new System.Drawing.Size(193, 246);
            this.pbEklePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEklePoster.TabIndex = 57;
            this.pbEklePoster.TabStop = false;
            // 
            // txtEkleYil
            // 
            this.txtEkleYil.Location = new System.Drawing.Point(142, 121);
            this.txtEkleYil.Name = "txtEkleYil";
            this.txtEkleYil.Size = new System.Drawing.Size(349, 29);
            this.txtEkleYil.TabIndex = 56;
            // 
            // txtEklePuan
            // 
            this.txtEklePuan.Location = new System.Drawing.Point(142, 156);
            this.txtEklePuan.Name = "txtEklePuan";
            this.txtEklePuan.Size = new System.Drawing.Size(349, 29);
            this.txtEklePuan.TabIndex = 53;
            // 
            // txtEkleFilm
            // 
            this.txtEkleFilm.Location = new System.Drawing.Point(142, 51);
            this.txtEkleFilm.Name = "txtEkleFilm";
            this.txtEkleFilm.Size = new System.Drawing.Size(349, 29);
            this.txtEkleFilm.TabIndex = 51;
            // 
            // lblEkleImdb
            // 
            this.lblEkleImdb.AutoSize = true;
            this.lblEkleImdb.Location = new System.Drawing.Point(35, 161);
            this.lblEkleImdb.Name = "lblEkleImdb";
            this.lblEkleImdb.Size = new System.Drawing.Size(101, 24);
            this.lblEkleImdb.TabIndex = 50;
            this.lblEkleImdb.Text = "Imdb Puan";
            // 
            // lblEkleYil
            // 
            this.lblEkleYil.AutoSize = true;
            this.lblEkleYil.Location = new System.Drawing.Point(106, 126);
            this.lblEkleYil.Name = "lblEkleYil";
            this.lblEkleYil.Size = new System.Drawing.Size(30, 24);
            this.lblEkleYil.TabIndex = 49;
            this.lblEkleYil.Text = "Yıl";
            // 
            // lblEkleTur
            // 
            this.lblEkleTur.AutoSize = true;
            this.lblEkleTur.Location = new System.Drawing.Point(97, 91);
            this.lblEkleTur.Name = "lblEkleTur";
            this.lblEkleTur.Size = new System.Drawing.Size(39, 24);
            this.lblEkleTur.TabIndex = 48;
            this.lblEkleTur.Text = "Tür";
            // 
            // lblEkleFilmAd
            // 
            this.lblEkleFilmAd.AutoSize = true;
            this.lblEkleFilmAd.Location = new System.Drawing.Point(57, 58);
            this.lblEkleFilmAd.Name = "lblEkleFilmAd";
            this.lblEkleFilmAd.Size = new System.Drawing.Size(79, 24);
            this.lblEkleFilmAd.TabIndex = 47;
            this.lblEkleFilmAd.Text = "Film Adı";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage3.Controls.Add(this.cmbGTur);
            this.tabPage3.Controls.Add(this.btnGPoster);
            this.tabPage3.Controls.Add(this.lblGOzet);
            this.tabPage3.Controls.Add(this.txtGOzet);
            this.tabPage3.Controls.Add(this.pbGuncellePoster);
            this.tabPage3.Controls.Add(this.txtGYİL);
            this.tabPage3.Controls.Add(this.txtGImdb);
            this.tabPage3.Controls.Add(this.txtGFilmAd);
            this.tabPage3.Controls.Add(this.lblGImdb);
            this.tabPage3.Controls.Add(this.lblGYil);
            this.tabPage3.Controls.Add(this.lblGTur);
            this.tabPage3.Controls.Add(this.lblGFilmAd);
            this.tabPage3.Location = new System.Drawing.Point(4, 57);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(806, 584);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Film Güncelle";
            // 
            // cmbGTur
            // 
            this.cmbGTur.FormattingEnabled = true;
            this.cmbGTur.Items.AddRange(new object[] {
            "Komedi",
            "Dram",
            "Aksiyon",
            "Korku",
            "Gerilim",
            "Fantezi",
            "Aşk",
            "Animasyon",
            "Bilim Kurgu"});
            this.cmbGTur.Location = new System.Drawing.Point(147, 91);
            this.cmbGTur.Name = "cmbGTur";
            this.cmbGTur.Size = new System.Drawing.Size(340, 32);
            this.cmbGTur.TabIndex = 74;
            // 
            // btnGPoster
            // 
            this.btnGPoster.Location = new System.Drawing.Point(505, 41);
            this.btnGPoster.Name = "btnGPoster";
            this.btnGPoster.Size = new System.Drawing.Size(223, 48);
            this.btnGPoster.TabIndex = 71;
            this.btnGPoster.Text = "Poster Seçin";
            this.btnGPoster.UseVisualStyleBackColor = true;
            // 
            // lblGOzet
            // 
            this.lblGOzet.AutoSize = true;
            this.lblGOzet.Location = new System.Drawing.Point(88, 201);
            this.lblGOzet.Name = "lblGOzet";
            this.lblGOzet.Size = new System.Drawing.Size(49, 24);
            this.lblGOzet.TabIndex = 70;
            this.lblGOzet.Text = "Özet";
            // 
            // txtGOzet
            // 
            this.txtGOzet.Location = new System.Drawing.Point(147, 198);
            this.txtGOzet.Multiline = true;
            this.txtGOzet.Name = "txtGOzet";
            this.txtGOzet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGOzet.Size = new System.Drawing.Size(340, 151);
            this.txtGOzet.TabIndex = 69;
            // 
            // pbGuncellePoster
            // 
            this.pbGuncellePoster.Location = new System.Drawing.Point(505, 95);
            this.pbGuncellePoster.Name = "pbGuncellePoster";
            this.pbGuncellePoster.Size = new System.Drawing.Size(223, 254);
            this.pbGuncellePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuncellePoster.TabIndex = 68;
            this.pbGuncellePoster.TabStop = false;
            // 
            // txtGYİL
            // 
            this.txtGYİL.Location = new System.Drawing.Point(147, 128);
            this.txtGYİL.Name = "txtGYİL";
            this.txtGYİL.Size = new System.Drawing.Size(340, 29);
            this.txtGYİL.TabIndex = 67;
            // 
            // txtGImdb
            // 
            this.txtGImdb.Location = new System.Drawing.Point(147, 163);
            this.txtGImdb.Name = "txtGImdb";
            this.txtGImdb.Size = new System.Drawing.Size(340, 29);
            this.txtGImdb.TabIndex = 66;
            // 
            // txtGFilmAd
            // 
            this.txtGFilmAd.Location = new System.Drawing.Point(147, 58);
            this.txtGFilmAd.Name = "txtGFilmAd";
            this.txtGFilmAd.Size = new System.Drawing.Size(340, 29);
            this.txtGFilmAd.TabIndex = 64;
            // 
            // lblGImdb
            // 
            this.lblGImdb.AutoSize = true;
            this.lblGImdb.Location = new System.Drawing.Point(40, 168);
            this.lblGImdb.Name = "lblGImdb";
            this.lblGImdb.Size = new System.Drawing.Size(101, 24);
            this.lblGImdb.TabIndex = 63;
            this.lblGImdb.Text = "Imdb Puan";
            // 
            // lblGYil
            // 
            this.lblGYil.AutoSize = true;
            this.lblGYil.Location = new System.Drawing.Point(111, 133);
            this.lblGYil.Name = "lblGYil";
            this.lblGYil.Size = new System.Drawing.Size(30, 24);
            this.lblGYil.TabIndex = 62;
            this.lblGYil.Text = "Yıl";
            // 
            // lblGTur
            // 
            this.lblGTur.AutoSize = true;
            this.lblGTur.Location = new System.Drawing.Point(98, 94);
            this.lblGTur.Name = "lblGTur";
            this.lblGTur.Size = new System.Drawing.Size(39, 24);
            this.lblGTur.TabIndex = 61;
            this.lblGTur.Text = "Tür";
            // 
            // lblGFilmAd
            // 
            this.lblGFilmAd.AutoSize = true;
            this.lblGFilmAd.Location = new System.Drawing.Point(62, 65);
            this.lblGFilmAd.Name = "lblGFilmAd";
            this.lblGFilmAd.Size = new System.Drawing.Size(79, 24);
            this.lblGFilmAd.TabIndex = 60;
            this.lblGFilmAd.Text = "Film Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 645);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEklePoster)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuncellePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblFilmAd;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdb_puan;
        private System.Windows.Forms.DataGridViewTextBoxColumn film_posteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbEkleTur;
        private System.Windows.Forms.Button btneEklePoster;
        private System.Windows.Forms.Label lblEkleOzet;
        private System.Windows.Forms.TextBox txtEkleOzet;
        private System.Windows.Forms.PictureBox pbEklePoster;
        private System.Windows.Forms.TextBox txtEkleYil;
        private System.Windows.Forms.TextBox txtEklePuan;
        private System.Windows.Forms.TextBox txtEkleFilm;
        private System.Windows.Forms.Label lblEkleImdb;
        private System.Windows.Forms.Label lblEkleYil;
        private System.Windows.Forms.Label lblEkleTur;
        private System.Windows.Forms.Label lblEkleFilmAd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbGTur;
        private System.Windows.Forms.Button btnGPoster;
        private System.Windows.Forms.Label lblGOzet;
        private System.Windows.Forms.TextBox txtGOzet;
        private System.Windows.Forms.PictureBox pbGuncellePoster;
        private System.Windows.Forms.TextBox txtGYİL;
        private System.Windows.Forms.TextBox txtGImdb;
        private System.Windows.Forms.TextBox txtGFilmAd;
        private System.Windows.Forms.Label lblGImdb;
        private System.Windows.Forms.Label lblGYil;
        private System.Windows.Forms.Label lblGTur;
        private System.Windows.Forms.Label lblGFilmAd;
    }
}

