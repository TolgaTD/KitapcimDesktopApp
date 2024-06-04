namespace kitapcim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KitapAdi = new System.Windows.Forms.Label();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.textBoxYAZAR = new System.Windows.Forms.TextBox();
            this.KitapYazari = new System.Windows.Forms.Label();
            this.textBoxSAYFA = new System.Windows.Forms.TextBox();
            this.SayfaSayisi = new System.Windows.Forms.Label();
            this.stok_var = new System.Windows.Forms.RadioButton();
            this.stok_yok = new System.Windows.Forms.RadioButton();
            this.comboBoxTUR = new System.Windows.Forms.ComboBox();
            this.KitapTuru = new System.Windows.Forms.Label();
            this.stokdurumu = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.KitapID = new System.Windows.Forms.Label();
            this.button_listele = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxara = new System.Windows.Forms.TextBox();
            this.kitapAraLabel = new System.Windows.Forms.Label();
            this.buttonbul = new System.Windows.Forms.Button();
            this.buttonbul2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxResim = new System.Windows.Forms.TextBox();
            this.labelResim = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridView1.Location = new System.Drawing.Point(18, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1097, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KitapAdi
            // 
            this.KitapAdi.AutoSize = true;
            this.KitapAdi.BackColor = System.Drawing.Color.Transparent;
            this.KitapAdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapAdi.ForeColor = System.Drawing.Color.White;
            this.KitapAdi.Location = new System.Drawing.Point(14, 58);
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.Size = new System.Drawing.Size(92, 19);
            this.KitapAdi.TabIndex = 1;
            this.KitapAdi.Text = "Kitap Adı : ";
            this.KitapAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(9, 89);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(135, 23);
            this.textBoxAD.TabIndex = 2;
            // 
            // textBoxYAZAR
            // 
            this.textBoxYAZAR.Location = new System.Drawing.Point(9, 158);
            this.textBoxYAZAR.Name = "textBoxYAZAR";
            this.textBoxYAZAR.Size = new System.Drawing.Size(135, 23);
            this.textBoxYAZAR.TabIndex = 4;
            // 
            // KitapYazari
            // 
            this.KitapYazari.AutoSize = true;
            this.KitapYazari.BackColor = System.Drawing.Color.Transparent;
            this.KitapYazari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapYazari.ForeColor = System.Drawing.Color.White;
            this.KitapYazari.Location = new System.Drawing.Point(14, 127);
            this.KitapYazari.Name = "KitapYazari";
            this.KitapYazari.Size = new System.Drawing.Size(109, 19);
            this.KitapYazari.TabIndex = 3;
            this.KitapYazari.Text = "Kitap Yazarı :";
            // 
            // textBoxSAYFA
            // 
            this.textBoxSAYFA.Location = new System.Drawing.Point(9, 223);
            this.textBoxSAYFA.Name = "textBoxSAYFA";
            this.textBoxSAYFA.Size = new System.Drawing.Size(135, 23);
            this.textBoxSAYFA.TabIndex = 6;
            // 
            // SayfaSayisi
            // 
            this.SayfaSayisi.AutoSize = true;
            this.SayfaSayisi.BackColor = System.Drawing.Color.Transparent;
            this.SayfaSayisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SayfaSayisi.ForeColor = System.Drawing.Color.White;
            this.SayfaSayisi.Location = new System.Drawing.Point(14, 192);
            this.SayfaSayisi.Name = "SayfaSayisi";
            this.SayfaSayisi.Size = new System.Drawing.Size(102, 19);
            this.SayfaSayisi.TabIndex = 5;
            this.SayfaSayisi.Text = "Sayfa Sayısı:";
            // 
            // stok_var
            // 
            this.stok_var.AutoSize = true;
            this.stok_var.BackColor = System.Drawing.Color.Transparent;
            this.stok_var.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_var.ForeColor = System.Drawing.Color.White;
            this.stok_var.Location = new System.Drawing.Point(129, 409);
            this.stok_var.Name = "stok_var";
            this.stok_var.Size = new System.Drawing.Size(54, 23);
            this.stok_var.TabIndex = 7;
            this.stok_var.TabStop = true;
            this.stok_var.Text = "Var";
            this.stok_var.UseVisualStyleBackColor = false;
            this.stok_var.CheckedChanged += new System.EventHandler(this.stok_var_CheckedChanged);
            // 
            // stok_yok
            // 
            this.stok_yok.AutoSize = true;
            this.stok_yok.BackColor = System.Drawing.Color.Transparent;
            this.stok_yok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_yok.ForeColor = System.Drawing.Color.White;
            this.stok_yok.Location = new System.Drawing.Point(185, 409);
            this.stok_yok.Name = "stok_yok";
            this.stok_yok.Size = new System.Drawing.Size(56, 23);
            this.stok_yok.TabIndex = 8;
            this.stok_yok.TabStop = true;
            this.stok_yok.Text = "Yok";
            this.stok_yok.UseVisualStyleBackColor = false;
            this.stok_yok.CheckedChanged += new System.EventHandler(this.stok_yok_CheckedChanged);
            // 
            // comboBoxTUR
            // 
            this.comboBoxTUR.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxTUR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTUR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTUR.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.comboBoxTUR.FormattingEnabled = true;
            this.comboBoxTUR.Items.AddRange(new object[] {
            "",
            "Hikaye",
            "Roman",
            "Eğitim",
            "Korku",
            "Serüven",
            "Psikoloji",
            "Biyografi",
            "Deneme",
            "Kişisel gelişim"});
            this.comboBoxTUR.Location = new System.Drawing.Point(9, 358);
            this.comboBoxTUR.Name = "comboBoxTUR";
            this.comboBoxTUR.Size = new System.Drawing.Size(121, 29);
            this.comboBoxTUR.TabIndex = 9;
            // 
            // KitapTuru
            // 
            this.KitapTuru.AutoSize = true;
            this.KitapTuru.BackColor = System.Drawing.Color.Transparent;
            this.KitapTuru.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapTuru.ForeColor = System.Drawing.Color.White;
            this.KitapTuru.Location = new System.Drawing.Point(14, 323);
            this.KitapTuru.Name = "KitapTuru";
            this.KitapTuru.Size = new System.Drawing.Size(93, 19);
            this.KitapTuru.TabIndex = 10;
            this.KitapTuru.Text = "Kitap Türü :";
            // 
            // stokdurumu
            // 
            this.stokdurumu.AutoSize = true;
            this.stokdurumu.BackColor = System.Drawing.Color.Transparent;
            this.stokdurumu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokdurumu.ForeColor = System.Drawing.Color.White;
            this.stokdurumu.Location = new System.Drawing.Point(14, 410);
            this.stokdurumu.Name = "stokdurumu";
            this.stokdurumu.Size = new System.Drawing.Size(114, 19);
            this.stokdurumu.TabIndex = 11;
            this.stokdurumu.Text = "Stok Durumu :";
            this.stokdurumu.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(9, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(135, 23);
            this.textBoxID.TabIndex = 13;
            // 
            // KitapID
            // 
            this.KitapID.AutoSize = true;
            this.KitapID.BackColor = System.Drawing.Color.Transparent;
            this.KitapID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapID.ForeColor = System.Drawing.Color.White;
            this.KitapID.Location = new System.Drawing.Point(14, 4);
            this.KitapID.Name = "KitapID";
            this.KitapID.Size = new System.Drawing.Size(80, 19);
            this.KitapID.TabIndex = 12;
            this.KitapID.Text = "Kitap ID : ";
            // 
            // button_listele
            // 
            this.button_listele.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_listele.FlatAppearance.BorderSize = 0;
            this.button_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_listele.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_listele.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button_listele.Location = new System.Drawing.Point(209, 23);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(132, 46);
            this.button_listele.TabIndex = 14;
            this.button_listele.Text = "Listele";
            this.button_listele.UseVisualStyleBackColor = false;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_kaydet.FlatAppearance.BorderSize = 0;
            this.button_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kaydet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button_kaydet.Location = new System.Drawing.Point(209, 85);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(132, 46);
            this.button_kaydet.TabIndex = 15;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_sil.FlatAppearance.BorderSize = 0;
            this.button_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sil.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button_sil.Location = new System.Drawing.Point(209, 150);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(132, 46);
            this.button_sil.TabIndex = 16;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_guncelle.FlatAppearance.BorderSize = 0;
            this.button_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guncelle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button_guncelle.Location = new System.Drawing.Point(209, 210);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(132, 46);
            this.button_guncelle.TabIndex = 17;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kitapcim.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(872, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // textboxara
            // 
            this.textboxara.Location = new System.Drawing.Point(11, 128);
            this.textboxara.Name = "textboxara";
            this.textboxara.Size = new System.Drawing.Size(199, 23);
            this.textboxara.TabIndex = 19;
            // 
            // kitapAraLabel
            // 
            this.kitapAraLabel.AutoSize = true;
            this.kitapAraLabel.BackColor = System.Drawing.Color.Transparent;
            this.kitapAraLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAraLabel.ForeColor = System.Drawing.Color.Snow;
            this.kitapAraLabel.Location = new System.Drawing.Point(38, 76);
            this.kitapAraLabel.Name = "kitapAraLabel";
            this.kitapAraLabel.Size = new System.Drawing.Size(144, 36);
            this.kitapAraLabel.TabIndex = 20;
            this.kitapAraLabel.Text = "Kitap Ara";
            // 
            // buttonbul
            // 
            this.buttonbul.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonbul.FlatAppearance.BorderSize = 0;
            this.buttonbul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbul.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbul.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonbul.Location = new System.Drawing.Point(11, 180);
            this.buttonbul.Name = "buttonbul";
            this.buttonbul.Size = new System.Drawing.Size(199, 98);
            this.buttonbul.TabIndex = 21;
            this.buttonbul.Text = "İsime Göre Bul";
            this.buttonbul.UseVisualStyleBackColor = false;
            this.buttonbul.Click += new System.EventHandler(this.buttonbul_Click);
            // 
            // buttonbul2
            // 
            this.buttonbul2.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonbul2.FlatAppearance.BorderSize = 0;
            this.buttonbul2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbul2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbul2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonbul2.Location = new System.Drawing.Point(11, 313);
            this.buttonbul2.Name = "buttonbul2";
            this.buttonbul2.Size = new System.Drawing.Size(199, 97);
            this.buttonbul2.TabIndex = 22;
            this.buttonbul2.Text = "Harfe Göre Bul";
            this.buttonbul2.UseVisualStyleBackColor = false;
            this.buttonbul2.Click += new System.EventHandler(this.buttonbul2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(10, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 345);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxResim
            // 
            this.textBoxResim.Location = new System.Drawing.Point(9, 290);
            this.textBoxResim.Name = "textBoxResim";
            this.textBoxResim.Size = new System.Drawing.Size(135, 23);
            this.textBoxResim.TabIndex = 25;
            // 
            // labelResim
            // 
            this.labelResim.AutoSize = true;
            this.labelResim.BackColor = System.Drawing.Color.Transparent;
            this.labelResim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelResim.ForeColor = System.Drawing.Color.White;
            this.labelResim.Location = new System.Drawing.Point(14, 259);
            this.labelResim.Name = "labelResim";
            this.labelResim.Size = new System.Drawing.Size(98, 19);
            this.labelResim.TabIndex = 24;
            this.labelResim.Text = "Kitap Resmi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(150, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonTemizle);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxResim);
            this.panel1.Controls.Add(this.labelResim);
            this.panel1.Controls.Add(this.button_guncelle);
            this.panel1.Controls.Add(this.button_sil);
            this.panel1.Controls.Add(this.button_kaydet);
            this.panel1.Controls.Add(this.button_listele);
            this.panel1.Controls.Add(this.KitapID);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.stokdurumu);
            this.panel1.Controls.Add(this.KitapTuru);
            this.panel1.Controls.Add(this.comboBoxTUR);
            this.panel1.Controls.Add(this.stok_yok);
            this.panel1.Controls.Add(this.stok_var);
            this.panel1.Controls.Add(this.textBoxSAYFA);
            this.panel1.Controls.Add(this.SayfaSayisi);
            this.panel1.Controls.Add(this.textBoxYAZAR);
            this.panel1.Controls.Add(this.KitapYazari);
            this.panel1.Controls.Add(this.textBoxAD);
            this.panel1.Controls.Add(this.KitapAdi);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 447);
            this.panel1.TabIndex = 27;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonTemizle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTemizle.FlatAppearance.BorderSize = 0;
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonTemizle.Location = new System.Drawing.Point(209, 271);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(132, 46);
            this.buttonTemizle.TabIndex = 27;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::kitapcim.Properties.Resources.symbol3;
            this.pictureBox4.Location = new System.Drawing.Point(237, 333);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.buttonbul2);
            this.panel2.Controls.Add(this.buttonbul);
            this.panel2.Controls.Add(this.kitapAraLabel);
            this.panel2.Controls.Add(this.textboxara);
            this.panel2.Location = new System.Drawing.Point(380, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 447);
            this.panel2.TabIndex = 28;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::kitapcim.Properties.Resources.symbol1;
            this.pictureBox3.Location = new System.Drawing.Point(44, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 60);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1133, 178);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(621, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 447);
            this.panel4.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kapak Resmi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::kitapcim.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1157, 667);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kitapcim Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label KitapAdi;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.TextBox textBoxYAZAR;
        private System.Windows.Forms.Label KitapYazari;
        private System.Windows.Forms.TextBox textBoxSAYFA;
        private System.Windows.Forms.Label SayfaSayisi;
        private System.Windows.Forms.RadioButton stok_var;
        private System.Windows.Forms.RadioButton stok_yok;
        private System.Windows.Forms.ComboBox comboBoxTUR;
        private System.Windows.Forms.Label KitapTuru;
        private System.Windows.Forms.Label stokdurumu;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label KitapID;
        private System.Windows.Forms.Button button_listele;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxara;
        private System.Windows.Forms.Label kitapAraLabel;
        private System.Windows.Forms.Button buttonbul;
        private System.Windows.Forms.Button buttonbul2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxResim;
        private System.Windows.Forms.Label labelResim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTemizle;
    }
}

