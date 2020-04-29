namespace PerKır
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.pbPerFoto = new System.Windows.Forms.PictureBox();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDahili = new System.Windows.Forms.TextBox();
            this.lblDahiliNo = new System.Windows.Forms.Label();
            this.txtPersonelKodu = new System.Windows.Forms.TextBox();
            this.lblPersonelKodu = new System.Windows.Forms.Label();
            this.txtCepTelNo = new System.Windows.Forms.TextBox();
            this.lblCepTelefonNo = new System.Windows.Forms.Label();
            this.tbcperbilgiler = new System.Windows.Forms.TabControl();
            this.tpKişiselBilgiler = new System.Windows.Forms.TabPage();
            this.dtDoğumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbUyruğu = new System.Windows.Forms.ComboBox();
            this.cmbMedeniHali = new System.Windows.Forms.ComboBox();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.cmbAskerlikDurumu = new System.Windows.Forms.ComboBox();
            this.cmbİlçe = new System.Windows.Forms.ComboBox();
            this.cmbİl = new System.Windows.Forms.ComboBox();
            this.cmbDoğumYeri = new System.Windows.Forms.ComboBox();
            this.cmbÖğrenimDurumu = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblİlçe = new System.Windows.Forms.Label();
            this.lblİl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBabaAdı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUyruğu = new System.Windows.Forms.Label();
            this.lblDoğumTarihi = new System.Windows.Forms.Label();
            this.lblMedeniHali = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDoğumYeri = new System.Windows.Forms.Label();
            this.lblKanGrubu = new System.Windows.Forms.Label();
            this.tbÇalışmaBilgileri = new System.Windows.Forms.TabPage();
            this.dtKıdemTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbDurak = new System.Windows.Forms.ComboBox();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.dtGeçerlilikİY = new System.Windows.Forms.DateTimePicker();
            this.dtİştenÇıkışTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtİşeGirişTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtPeriyodikMuayene = new System.Windows.Forms.DateTimePicker();
            this.txtGörev = new System.Windows.Forms.TextBox();
            this.cmbÖzelDurum = new System.Windows.Forms.ComboBox();
            this.cmbİlkYardımBelgesi = new System.Windows.Forms.ComboBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.cmbKısım = new System.Windows.Forms.ComboBox();
            this.cmbBölüm = new System.Windows.Forms.ComboBox();
            this.lblÖzelDurum = new System.Windows.Forms.Label();
            this.lblİlkYardımBelgesi = new System.Windows.Forms.Label();
            this.Durak = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblBölüm = new System.Windows.Forms.Label();
            this.lblServis = new System.Windows.Forms.Label();
            this.lblKıdemYılı = new System.Windows.Forms.Label();
            this.cmbÇalışmaŞekli = new System.Windows.Forms.ComboBox();
            this.cmbEmekli = new System.Windows.Forms.ComboBox();
            this.lblKısım = new System.Windows.Forms.Label();
            this.cmbBelgeDurumu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmykbelge = new System.Windows.Forms.ComboBox();
            this.lblEmekli = new System.Windows.Forms.Label();
            this.lblKıdemTarihi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGörev = new System.Windows.Forms.Label();
            this.lblİştençıkıştarihi = new System.Windows.Forms.Label();
            this.lblBelgeDurumu = new System.Windows.Forms.Label();
            this.lblİşeGirişTarihi = new System.Windows.Forms.Label();
            this.lblMykBelgesi = new System.Windows.Forms.Label();
            this.lblPeriyodikMuayene = new System.Windows.Forms.Label();
            this.cmbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet = new PerKır.PersonelDataSet();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnperkaydet = new System.Windows.Forms.Button();
            this.cmbTableAdapter = new PerKır.PersonelDataSetTableAdapters.cmbTableAdapter();
            this.cmbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet1 = new PerKır.PersonelDataSet1();
            this.cmbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTableAdapter1 = new PerKır.PersonelDataSet1TableAdapters.cmbTableAdapter();
            this.personelDataSet2 = new PerKır.PersonelDataSet2();
            this.cmbBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTableAdapter2 = new PerKır.PersonelDataSet2TableAdapters.cmbTableAdapter();
            this.lblFirmaÜnvanı = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpbxMeslekiYeterlilik = new System.Windows.Forms.GroupBox();
            this.grpbxİSG = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblİbanNo = new System.Windows.Forms.Label();
            this.txtİbanNo = new System.Windows.Forms.TextBox();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.lblİsgEğitimTarihi = new System.Windows.Forms.Label();
            this.dtİsgEğitimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBirimAmiri = new System.Windows.Forms.Label();
            this.cmbBirimAmiri = new System.Windows.Forms.ComboBox();
            this.lblNetÜcret = new System.Windows.Forms.Label();
            this.txtNetÜcret = new System.Windows.Forms.TextBox();
            this.lblAGİ = new System.Windows.Forms.Label();
            this.txtAGİ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEşDurumu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtÇocukSayısı = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblAcilDurumGrubu = new System.Windows.Forms.Label();
            this.cmbAcilDurumGrubu = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerFoto)).BeginInit();
            this.tbcperbilgiler.SuspendLayout();
            this.tpKişiselBilgiler.SuspendLayout();
            this.tbÇalışmaBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource4)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.grpbxMeslekiYeterlilik.SuspendLayout();
            this.grpbxİSG.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResimEkle);
            this.groupBox1.Controls.Add(this.pbPerFoto);
            this.groupBox1.Controls.Add(this.txtTcKimlik);
            this.groupBox1.Controls.Add(this.lblTcKimlik);
            this.groupBox1.Controls.Add(this.txtEPosta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDahili);
            this.groupBox1.Controls.Add(this.lblDahiliNo);
            this.groupBox1.Controls.Add(this.txtPersonelKodu);
            this.groupBox1.Controls.Add(this.lblPersonelKodu);
            this.groupBox1.Controls.Add(this.txtCepTelNo);
            this.groupBox1.Controls.Add(this.lblCepTelefonNo);
            this.groupBox1.Controls.Add(this.tbcperbilgiler);
            this.groupBox1.Location = new System.Drawing.Point(22, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnResimEkle.Location = new System.Drawing.Point(155, 141);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(20, 20);
            this.btnResimEkle.TabIndex = 5;
            this.btnResimEkle.Text = "...";
            this.btnResimEkle.UseVisualStyleBackColor = false;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // pbPerFoto
            // 
            this.pbPerFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPerFoto.Location = new System.Drawing.Point(26, 34);
            this.pbPerFoto.Name = "pbPerFoto";
            this.pbPerFoto.Size = new System.Drawing.Size(123, 127);
            this.pbPerFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerFoto.TabIndex = 4;
            this.pbPerFoto.TabStop = false;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(276, 36);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(256, 20);
            this.txtTcKimlik.TabIndex = 3;
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcKimlik.Location = new System.Drawing.Point(166, 36);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(86, 18);
            this.lblTcKimlik.TabIndex = 2;
            this.lblTcKimlik.Text = "TC Kimlik No";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(805, 73);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(211, 20);
            this.txtEPosta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(695, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Posta";
            // 
            // txtDahili
            // 
            this.txtDahili.Location = new System.Drawing.Point(805, 108);
            this.txtDahili.Name = "txtDahili";
            this.txtDahili.Size = new System.Drawing.Size(74, 20);
            this.txtDahili.TabIndex = 3;
            // 
            // lblDahiliNo
            // 
            this.lblDahiliNo.AutoSize = true;
            this.lblDahiliNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDahiliNo.Location = new System.Drawing.Point(695, 108);
            this.lblDahiliNo.Name = "lblDahiliNo";
            this.lblDahiliNo.Size = new System.Drawing.Size(65, 18);
            this.lblDahiliNo.TabIndex = 2;
            this.lblDahiliNo.Text = "Dahili No";
            // 
            // txtPersonelKodu
            // 
            this.txtPersonelKodu.Location = new System.Drawing.Point(276, 73);
            this.txtPersonelKodu.Name = "txtPersonelKodu";
            this.txtPersonelKodu.Size = new System.Drawing.Size(256, 20);
            this.txtPersonelKodu.TabIndex = 3;
            // 
            // lblPersonelKodu
            // 
            this.lblPersonelKodu.AutoSize = true;
            this.lblPersonelKodu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKodu.Location = new System.Drawing.Point(166, 73);
            this.lblPersonelKodu.Name = "lblPersonelKodu";
            this.lblPersonelKodu.Size = new System.Drawing.Size(98, 18);
            this.lblPersonelKodu.TabIndex = 2;
            this.lblPersonelKodu.Text = "Personel Kodu";
            this.lblPersonelKodu.Click += new System.EventHandler(this.lblPersonelKodu_Click);
            // 
            // txtCepTelNo
            // 
            this.txtCepTelNo.Location = new System.Drawing.Point(805, 36);
            this.txtCepTelNo.Name = "txtCepTelNo";
            this.txtCepTelNo.Size = new System.Drawing.Size(211, 20);
            this.txtCepTelNo.TabIndex = 3;
            // 
            // lblCepTelefonNo
            // 
            this.lblCepTelefonNo.AutoSize = true;
            this.lblCepTelefonNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCepTelefonNo.Location = new System.Drawing.Point(695, 36);
            this.lblCepTelefonNo.Name = "lblCepTelefonNo";
            this.lblCepTelefonNo.Size = new System.Drawing.Size(74, 18);
            this.lblCepTelefonNo.TabIndex = 2;
            this.lblCepTelefonNo.Text = "Cep Tel No";
            // 
            // tbcperbilgiler
            // 
            this.tbcperbilgiler.Controls.Add(this.tpKişiselBilgiler);
            this.tbcperbilgiler.Controls.Add(this.tbÇalışmaBilgileri);
            this.tbcperbilgiler.Controls.Add(this.tabPage1);
            this.tbcperbilgiler.Controls.Add(this.tabPage2);
            this.tbcperbilgiler.Location = new System.Drawing.Point(26, 176);
            this.tbcperbilgiler.Name = "tbcperbilgiler";
            this.tbcperbilgiler.SelectedIndex = 0;
            this.tbcperbilgiler.Size = new System.Drawing.Size(994, 344);
            this.tbcperbilgiler.TabIndex = 0;
            // 
            // tpKişiselBilgiler
            // 
            this.tpKişiselBilgiler.Controls.Add(this.dtDoğumTarihi);
            this.tpKişiselBilgiler.Controls.Add(this.cmbEşDurumu);
            this.tpKişiselBilgiler.Controls.Add(this.cmbCinsiyet);
            this.tpKişiselBilgiler.Controls.Add(this.cmbUyruğu);
            this.tpKişiselBilgiler.Controls.Add(this.cmbMedeniHali);
            this.tpKişiselBilgiler.Controls.Add(this.cmbKanGrubu);
            this.tpKişiselBilgiler.Controls.Add(this.cmbAskerlikDurumu);
            this.tpKişiselBilgiler.Controls.Add(this.txtÇocukSayısı);
            this.tpKişiselBilgiler.Controls.Add(this.cmbİlçe);
            this.tpKişiselBilgiler.Controls.Add(this.cmbİl);
            this.tpKişiselBilgiler.Controls.Add(this.cmbDoğumYeri);
            this.tpKişiselBilgiler.Controls.Add(this.cmbÖğrenimDurumu);
            this.tpKişiselBilgiler.Controls.Add(this.txtAdres);
            this.tpKişiselBilgiler.Controls.Add(this.lblİlçe);
            this.tpKişiselBilgiler.Controls.Add(this.lblİl);
            this.tpKişiselBilgiler.Controls.Add(this.label2);
            this.tpKişiselBilgiler.Controls.Add(this.label9);
            this.tpKişiselBilgiler.Controls.Add(this.txtBabaAdı);
            this.tpKişiselBilgiler.Controls.Add(this.label8);
            this.tpKişiselBilgiler.Controls.Add(this.lblCinsiyet);
            this.tpKişiselBilgiler.Controls.Add(this.label3);
            this.tpKişiselBilgiler.Controls.Add(this.lblUyruğu);
            this.tpKişiselBilgiler.Controls.Add(this.lblDoğumTarihi);
            this.tpKişiselBilgiler.Controls.Add(this.lblMedeniHali);
            this.tpKişiselBilgiler.Controls.Add(this.label6);
            this.tpKişiselBilgiler.Controls.Add(this.label5);
            this.tpKişiselBilgiler.Controls.Add(this.lblDoğumYeri);
            this.tpKişiselBilgiler.Controls.Add(this.lblKanGrubu);
            this.tpKişiselBilgiler.Location = new System.Drawing.Point(4, 22);
            this.tpKişiselBilgiler.Name = "tpKişiselBilgiler";
            this.tpKişiselBilgiler.Padding = new System.Windows.Forms.Padding(3);
            this.tpKişiselBilgiler.Size = new System.Drawing.Size(986, 318);
            this.tpKişiselBilgiler.TabIndex = 0;
            this.tpKişiselBilgiler.Text = "KişiselBilgiler";
            this.tpKişiselBilgiler.UseVisualStyleBackColor = true;
            this.tpKişiselBilgiler.Click += new System.EventHandler(this.tpKişiselBilgiler_Click);
            // 
            // dtDoğumTarihi
            // 
            this.dtDoğumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDoğumTarihi.Location = new System.Drawing.Point(148, 77);
            this.dtDoğumTarihi.Name = "dtDoğumTarihi";
            this.dtDoğumTarihi.Size = new System.Drawing.Size(96, 20);
            this.dtDoğumTarihi.TabIndex = 4;
            this.dtDoğumTarihi.ValueChanged += new System.EventHandler(this.dtDoğumTarihi_ValueChanged);
            // 
            // cmbUyruğu
            // 
            this.cmbUyruğu.FormattingEnabled = true;
            this.cmbUyruğu.Location = new System.Drawing.Point(148, 46);
            this.cmbUyruğu.Name = "cmbUyruğu";
            this.cmbUyruğu.Size = new System.Drawing.Size(96, 21);
            this.cmbUyruğu.TabIndex = 4;
            // 
            // cmbMedeniHali
            // 
            this.cmbMedeniHali.FormattingEnabled = true;
            this.cmbMedeniHali.Location = new System.Drawing.Point(800, 46);
            this.cmbMedeniHali.Name = "cmbMedeniHali";
            this.cmbMedeniHali.Size = new System.Drawing.Size(121, 21);
            this.cmbMedeniHali.TabIndex = 4;
            this.cmbMedeniHali.SelectedIndexChanged += new System.EventHandler(this.cmbMedeniHali_SelectedIndexChanged);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Location = new System.Drawing.Point(386, 110);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(116, 21);
            this.cmbKanGrubu.TabIndex = 4;
            this.cmbKanGrubu.SelectedIndexChanged += new System.EventHandler(this.cmbKanGrubu_SelectedIndexChanged);
            // 
            // cmbAskerlikDurumu
            // 
            this.cmbAskerlikDurumu.FormattingEnabled = true;
            this.cmbAskerlikDurumu.Location = new System.Drawing.Point(800, 240);
            this.cmbAskerlikDurumu.Name = "cmbAskerlikDurumu";
            this.cmbAskerlikDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbAskerlikDurumu.TabIndex = 4;
            this.cmbAskerlikDurumu.SelectedIndexChanged += new System.EventHandler(this.cmbAskerlikDurumu_SelectedIndexChanged);
            // 
            // cmbİlçe
            // 
            this.cmbİlçe.FormattingEnabled = true;
            this.cmbİlçe.Location = new System.Drawing.Point(381, 265);
            this.cmbİlçe.Name = "cmbİlçe";
            this.cmbİlçe.Size = new System.Drawing.Size(121, 21);
            this.cmbİlçe.TabIndex = 4;
            // 
            // cmbİl
            // 
            this.cmbİl.FormattingEnabled = true;
            this.cmbİl.Location = new System.Drawing.Point(148, 265);
            this.cmbİl.Name = "cmbİl";
            this.cmbİl.Size = new System.Drawing.Size(121, 21);
            this.cmbİl.TabIndex = 4;
            // 
            // cmbDoğumYeri
            // 
            this.cmbDoğumYeri.FormattingEnabled = true;
            this.cmbDoğumYeri.Location = new System.Drawing.Point(386, 75);
            this.cmbDoğumYeri.Name = "cmbDoğumYeri";
            this.cmbDoğumYeri.Size = new System.Drawing.Size(116, 21);
            this.cmbDoğumYeri.TabIndex = 4;
            // 
            // cmbÖğrenimDurumu
            // 
            this.cmbÖğrenimDurumu.FormattingEnabled = true;
            this.cmbÖğrenimDurumu.Location = new System.Drawing.Point(800, 213);
            this.cmbÖğrenimDurumu.Name = "cmbÖğrenimDurumu";
            this.cmbÖğrenimDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbÖğrenimDurumu.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(148, 200);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(354, 59);
            this.txtAdres.TabIndex = 3;
            // 
            // lblİlçe
            // 
            this.lblİlçe.AutoSize = true;
            this.lblİlçe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİlçe.Location = new System.Drawing.Point(339, 265);
            this.lblİlçe.Name = "lblİlçe";
            this.lblİlçe.Size = new System.Drawing.Size(30, 18);
            this.lblİlçe.TabIndex = 2;
            this.lblİlçe.Text = "İlçe";
            // 
            // lblİl
            // 
            this.lblİl.AutoSize = true;
            this.lblİl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİl.Location = new System.Drawing.Point(104, 265);
            this.lblİl.Name = "lblİl";
            this.lblİl.Size = new System.Drawing.Size(16, 18);
            this.lblİl.TabIndex = 2;
            this.lblİl.Text = "İl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres";
            // 
            // txtBabaAdı
            // 
            this.txtBabaAdı.Location = new System.Drawing.Point(148, 114);
            this.txtBabaAdı.Name = "txtBabaAdı";
            this.txtBabaAdı.Size = new System.Drawing.Size(96, 20);
            this.txtBabaAdı.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baba Adı";
            // 
            // lblUyruğu
            // 
            this.lblUyruğu.AutoSize = true;
            this.lblUyruğu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyruğu.Location = new System.Drawing.Point(68, 46);
            this.lblUyruğu.Name = "lblUyruğu";
            this.lblUyruğu.Size = new System.Drawing.Size(53, 18);
            this.lblUyruğu.TabIndex = 2;
            this.lblUyruğu.Text = "Uyruğu";
            // 
            // lblDoğumTarihi
            // 
            this.lblDoğumTarihi.AutoSize = true;
            this.lblDoğumTarihi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoğumTarihi.Location = new System.Drawing.Point(33, 79);
            this.lblDoğumTarihi.Name = "lblDoğumTarihi";
            this.lblDoğumTarihi.Size = new System.Drawing.Size(89, 18);
            this.lblDoğumTarihi.TabIndex = 2;
            this.lblDoğumTarihi.Text = "Doğum Tarihi";
            this.lblDoğumTarihi.Click += new System.EventHandler(this.lblPersonelKodu_Click);
            // 
            // lblMedeniHali
            // 
            this.lblMedeniHali.AutoSize = true;
            this.lblMedeniHali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMedeniHali.Location = new System.Drawing.Point(684, 46);
            this.lblMedeniHali.Name = "lblMedeniHali";
            this.lblMedeniHali.Size = new System.Drawing.Size(84, 18);
            this.lblMedeniHali.TabIndex = 2;
            this.lblMedeniHali.Text = "Medeni Hali";
            this.lblMedeniHali.Click += new System.EventHandler(this.lblMedeniHali_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(657, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Askerlik Durumu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(657, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Öğrenim Durumu";
            // 
            // lblDoğumYeri
            // 
            this.lblDoğumYeri.AutoSize = true;
            this.lblDoğumYeri.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoğumYeri.Location = new System.Drawing.Point(289, 79);
            this.lblDoğumYeri.Name = "lblDoğumYeri";
            this.lblDoğumYeri.Size = new System.Drawing.Size(79, 18);
            this.lblDoğumYeri.TabIndex = 2;
            this.lblDoğumYeri.Text = "Doğum Yeri";
            // 
            // lblKanGrubu
            // 
            this.lblKanGrubu.AutoSize = true;
            this.lblKanGrubu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKanGrubu.Location = new System.Drawing.Point(295, 114);
            this.lblKanGrubu.Name = "lblKanGrubu";
            this.lblKanGrubu.Size = new System.Drawing.Size(73, 18);
            this.lblKanGrubu.TabIndex = 2;
            this.lblKanGrubu.Text = "Kan Grubu";
            this.lblKanGrubu.Click += new System.EventHandler(this.lblKanGrubu_Click);
            // 
            // tbÇalışmaBilgileri
            // 
            this.tbÇalışmaBilgileri.Controls.Add(this.dtKıdemTarihi);
            this.tbÇalışmaBilgileri.Controls.Add(this.dtİştenÇıkışTarihi);
            this.tbÇalışmaBilgileri.Controls.Add(this.dtİşeGirişTarihi);
            this.tbÇalışmaBilgileri.Controls.Add(this.txtGörev);
            this.tbÇalışmaBilgileri.Controls.Add(this.cmbÖzelDurum);
            this.tbÇalışmaBilgileri.Controls.Add(this.cmbBirimAmiri);
            this.tbÇalışmaBilgileri.Controls.Add(this.txtAGİ);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblAGİ);
            this.tbÇalışmaBilgileri.Controls.Add(this.txtNetÜcret);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblNetÜcret);
            this.tbÇalışmaBilgileri.Controls.Add(this.cmbBirim);
            this.tbÇalışmaBilgileri.Controls.Add(this.cmbKısım);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblBirimAmiri);
            this.tbÇalışmaBilgileri.Controls.Add(this.cmbBölüm);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblBirim);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblÖzelDurum);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblBölüm);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblKıdemYılı);
            this.tbÇalışmaBilgileri.Controls.Add(this.cmbÇalışmaŞekli);
            this.tbÇalışmaBilgileri.Controls.Add(this.cmbEmekli);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblKısım);
            this.tbÇalışmaBilgileri.Controls.Add(this.label1);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblEmekli);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblKıdemTarihi);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblGörev);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblİştençıkıştarihi);
            this.tbÇalışmaBilgileri.Controls.Add(this.lblİşeGirişTarihi);
            this.tbÇalışmaBilgileri.Location = new System.Drawing.Point(4, 22);
            this.tbÇalışmaBilgileri.Name = "tbÇalışmaBilgileri";
            this.tbÇalışmaBilgileri.Padding = new System.Windows.Forms.Padding(3);
            this.tbÇalışmaBilgileri.Size = new System.Drawing.Size(986, 318);
            this.tbÇalışmaBilgileri.TabIndex = 1;
            this.tbÇalışmaBilgileri.Text = "Çalışma Bilgileri";
            this.tbÇalışmaBilgileri.UseVisualStyleBackColor = true;
            // 
            // dtKıdemTarihi
            // 
            this.dtKıdemTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKıdemTarihi.Location = new System.Drawing.Point(181, 73);
            this.dtKıdemTarihi.Name = "dtKıdemTarihi";
            this.dtKıdemTarihi.Size = new System.Drawing.Size(96, 20);
            this.dtKıdemTarihi.TabIndex = 4;
            // 
            // cmbDurak
            // 
            this.cmbDurak.FormattingEnabled = true;
            this.cmbDurak.Location = new System.Drawing.Point(84, 79);
            this.cmbDurak.Name = "cmbDurak";
            this.cmbDurak.Size = new System.Drawing.Size(157, 21);
            this.cmbDurak.TabIndex = 4;
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(84, 41);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(157, 21);
            this.cmbServis.TabIndex = 4;
            // 
            // dtGeçerlilikİY
            // 
            this.dtGeçerlilikİY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGeçerlilikİY.Location = new System.Drawing.Point(224, 156);
            this.dtGeçerlilikİY.Name = "dtGeçerlilikİY";
            this.dtGeçerlilikİY.Size = new System.Drawing.Size(121, 20);
            this.dtGeçerlilikİY.TabIndex = 4;
            // 
            // dtİştenÇıkışTarihi
            // 
            this.dtİştenÇıkışTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtİştenÇıkışTarihi.Location = new System.Drawing.Point(447, 47);
            this.dtİştenÇıkışTarihi.Name = "dtİştenÇıkışTarihi";
            this.dtİştenÇıkışTarihi.Size = new System.Drawing.Size(96, 20);
            this.dtİştenÇıkışTarihi.TabIndex = 4;
            this.dtİştenÇıkışTarihi.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // dtİşeGirişTarihi
            // 
            this.dtİşeGirişTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtİşeGirişTarihi.Location = new System.Drawing.Point(181, 47);
            this.dtİşeGirişTarihi.Name = "dtİşeGirişTarihi";
            this.dtİşeGirişTarihi.Size = new System.Drawing.Size(96, 20);
            this.dtİşeGirişTarihi.TabIndex = 4;
            // 
            // dtPeriyodikMuayene
            // 
            this.dtPeriyodikMuayene.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriyodikMuayene.Location = new System.Drawing.Point(224, 78);
            this.dtPeriyodikMuayene.Name = "dtPeriyodikMuayene";
            this.dtPeriyodikMuayene.Size = new System.Drawing.Size(121, 20);
            this.dtPeriyodikMuayene.TabIndex = 4;
            // 
            // txtGörev
            // 
            this.txtGörev.Location = new System.Drawing.Point(181, 254);
            this.txtGörev.Name = "txtGörev";
            this.txtGörev.Size = new System.Drawing.Size(247, 20);
            this.txtGörev.TabIndex = 3;
            // 
            // cmbÖzelDurum
            // 
            this.cmbÖzelDurum.FormattingEnabled = true;
            this.cmbÖzelDurum.Location = new System.Drawing.Point(796, 197);
            this.cmbÖzelDurum.Name = "cmbÖzelDurum";
            this.cmbÖzelDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbÖzelDurum.TabIndex = 4;
            // 
            // cmbİlkYardımBelgesi
            // 
            this.cmbİlkYardımBelgesi.FormattingEnabled = true;
            this.cmbİlkYardımBelgesi.Location = new System.Drawing.Point(224, 129);
            this.cmbİlkYardımBelgesi.Name = "cmbİlkYardımBelgesi";
            this.cmbİlkYardımBelgesi.Size = new System.Drawing.Size(121, 21);
            this.cmbİlkYardımBelgesi.TabIndex = 4;
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(181, 194);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(144, 21);
            this.cmbBirim.TabIndex = 4;
            // 
            // cmbKısım
            // 
            this.cmbKısım.FormattingEnabled = true;
            this.cmbKısım.Location = new System.Drawing.Point(181, 143);
            this.cmbKısım.Name = "cmbKısım";
            this.cmbKısım.Size = new System.Drawing.Size(144, 21);
            this.cmbKısım.TabIndex = 4;
            // 
            // cmbBölüm
            // 
            this.cmbBölüm.FormattingEnabled = true;
            this.cmbBölüm.Location = new System.Drawing.Point(181, 167);
            this.cmbBölüm.Name = "cmbBölüm";
            this.cmbBölüm.Size = new System.Drawing.Size(144, 21);
            this.cmbBölüm.TabIndex = 4;
            // 
            // lblÖzelDurum
            // 
            this.lblÖzelDurum.AutoSize = true;
            this.lblÖzelDurum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÖzelDurum.Location = new System.Drawing.Point(665, 197);
            this.lblÖzelDurum.Name = "lblÖzelDurum";
            this.lblÖzelDurum.Size = new System.Drawing.Size(81, 18);
            this.lblÖzelDurum.TabIndex = 2;
            this.lblÖzelDurum.Text = "Özel Durum";
            // 
            // lblİlkYardımBelgesi
            // 
            this.lblİlkYardımBelgesi.AutoSize = true;
            this.lblİlkYardımBelgesi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİlkYardımBelgesi.Location = new System.Drawing.Point(93, 132);
            this.lblİlkYardımBelgesi.Name = "lblİlkYardımBelgesi";
            this.lblİlkYardımBelgesi.Size = new System.Drawing.Size(117, 18);
            this.lblİlkYardımBelgesi.TabIndex = 2;
            this.lblİlkYardımBelgesi.Text = "İlk Yardım Belgesi";
            // 
            // Durak
            // 
            this.Durak.AutoSize = true;
            this.Durak.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Durak.Location = new System.Drawing.Point(110, 173);
            this.Durak.Name = "Durak";
            this.Durak.Size = new System.Drawing.Size(44, 18);
            this.Durak.TabIndex = 2;
            this.Durak.Text = "Durak";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirim.Location = new System.Drawing.Point(50, 197);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(41, 18);
            this.lblBirim.TabIndex = 2;
            this.lblBirim.Text = "Birim";
            // 
            // lblBölüm
            // 
            this.lblBölüm.AutoSize = true;
            this.lblBölüm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBölüm.Location = new System.Drawing.Point(50, 170);
            this.lblBölüm.Name = "lblBölüm";
            this.lblBölüm.Size = new System.Drawing.Size(48, 18);
            this.lblBölüm.TabIndex = 2;
            this.lblBölüm.Text = "Bölüm";
            // 
            // lblServis
            // 
            this.lblServis.AutoSize = true;
            this.lblServis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServis.Location = new System.Drawing.Point(110, 135);
            this.lblServis.Name = "lblServis";
            this.lblServis.Size = new System.Drawing.Size(35, 18);
            this.lblServis.TabIndex = 2;
            this.lblServis.Text = "Araç";
            // 
            // lblKıdemYılı
            // 
            this.lblKıdemYılı.AutoSize = true;
            this.lblKıdemYılı.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKıdemYılı.Location = new System.Drawing.Point(292, 73);
            this.lblKıdemYılı.Name = "lblKıdemYılı";
            this.lblKıdemYılı.Size = new System.Drawing.Size(64, 18);
            this.lblKıdemYılı.TabIndex = 2;
            this.lblKıdemYılı.Text = "Kıdem Yılı";
            // 
            // cmbÇalışmaŞekli
            // 
            this.cmbÇalışmaŞekli.FormattingEnabled = true;
            this.cmbÇalışmaŞekli.Location = new System.Drawing.Point(796, 167);
            this.cmbÇalışmaŞekli.Name = "cmbÇalışmaŞekli";
            this.cmbÇalışmaŞekli.Size = new System.Drawing.Size(121, 21);
            this.cmbÇalışmaŞekli.TabIndex = 4;
            // 
            // cmbEmekli
            // 
            this.cmbEmekli.FormattingEnabled = true;
            this.cmbEmekli.Location = new System.Drawing.Point(796, 224);
            this.cmbEmekli.Name = "cmbEmekli";
            this.cmbEmekli.Size = new System.Drawing.Size(121, 21);
            this.cmbEmekli.TabIndex = 4;
            // 
            // lblKısım
            // 
            this.lblKısım.AutoSize = true;
            this.lblKısım.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKısım.Location = new System.Drawing.Point(50, 143);
            this.lblKısım.Name = "lblKısım";
            this.lblKısım.Size = new System.Drawing.Size(42, 18);
            this.lblKısım.TabIndex = 2;
            this.lblKısım.Text = "Kısım";
            // 
            // cmbBelgeDurumu
            // 
            this.cmbBelgeDurumu.FormattingEnabled = true;
            this.cmbBelgeDurumu.Location = new System.Drawing.Point(154, 65);
            this.cmbBelgeDurumu.Name = "cmbBelgeDurumu";
            this.cmbBelgeDurumu.Size = new System.Drawing.Size(144, 21);
            this.cmbBelgeDurumu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(665, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çalışma Şekli";
            // 
            // cmbmykbelge
            // 
            this.cmbmykbelge.FormattingEnabled = true;
            this.cmbmykbelge.Location = new System.Drawing.Point(154, 38);
            this.cmbmykbelge.Name = "cmbmykbelge";
            this.cmbmykbelge.Size = new System.Drawing.Size(144, 21);
            this.cmbmykbelge.TabIndex = 4;
            // 
            // lblEmekli
            // 
            this.lblEmekli.AutoSize = true;
            this.lblEmekli.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmekli.Location = new System.Drawing.Point(665, 227);
            this.lblEmekli.Name = "lblEmekli";
            this.lblEmekli.Size = new System.Drawing.Size(50, 18);
            this.lblEmekli.TabIndex = 2;
            this.lblEmekli.Text = "Emekli";
            // 
            // lblKıdemTarihi
            // 
            this.lblKıdemTarihi.AutoSize = true;
            this.lblKıdemTarihi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKıdemTarihi.Location = new System.Drawing.Point(50, 73);
            this.lblKıdemTarihi.Name = "lblKıdemTarihi";
            this.lblKıdemTarihi.Size = new System.Drawing.Size(85, 18);
            this.lblKıdemTarihi.TabIndex = 2;
            this.lblKıdemTarihi.Text = "Kıdem Tarihi";
            this.lblKıdemTarihi.Click += new System.EventHandler(this.lblPersonelKodu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(113, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Geçerlik Tarihi";
            this.label7.Click += new System.EventHandler(this.lblPersonelKodu_Click);
            // 
            // lblGörev
            // 
            this.lblGörev.AutoSize = true;
            this.lblGörev.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGörev.Location = new System.Drawing.Point(50, 254);
            this.lblGörev.Name = "lblGörev";
            this.lblGörev.Size = new System.Drawing.Size(46, 18);
            this.lblGörev.TabIndex = 2;
            this.lblGörev.Text = "Görev";
            // 
            // lblİştençıkıştarihi
            // 
            this.lblİştençıkıştarihi.AutoSize = true;
            this.lblİştençıkıştarihi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİştençıkıştarihi.Location = new System.Drawing.Point(295, 47);
            this.lblİştençıkıştarihi.Name = "lblİştençıkıştarihi";
            this.lblİştençıkıştarihi.Size = new System.Drawing.Size(108, 18);
            this.lblİştençıkıştarihi.TabIndex = 2;
            this.lblİştençıkıştarihi.Text = "İşten Çıkış Tarihi";
            this.lblİştençıkıştarihi.Click += new System.EventHandler(this.lblPersonelKodu_Click);
            // 
            // lblBelgeDurumu
            // 
            this.lblBelgeDurumu.AutoSize = true;
            this.lblBelgeDurumu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBelgeDurumu.Location = new System.Drawing.Point(37, 65);
            this.lblBelgeDurumu.Name = "lblBelgeDurumu";
            this.lblBelgeDurumu.Size = new System.Drawing.Size(88, 18);
            this.lblBelgeDurumu.TabIndex = 2;
            this.lblBelgeDurumu.Text = "Belge Durum";
            // 
            // lblİşeGirişTarihi
            // 
            this.lblİşeGirişTarihi.AutoSize = true;
            this.lblİşeGirişTarihi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİşeGirişTarihi.Location = new System.Drawing.Point(50, 47);
            this.lblİşeGirişTarihi.Name = "lblİşeGirişTarihi";
            this.lblİşeGirişTarihi.Size = new System.Drawing.Size(95, 18);
            this.lblİşeGirişTarihi.TabIndex = 2;
            this.lblİşeGirişTarihi.Text = "İşe Giriş Tarihi";
            this.lblİşeGirişTarihi.Click += new System.EventHandler(this.lblPersonelKodu_Click);
            // 
            // lblMykBelgesi
            // 
            this.lblMykBelgesi.AutoSize = true;
            this.lblMykBelgesi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMykBelgesi.Location = new System.Drawing.Point(37, 38);
            this.lblMykBelgesi.Name = "lblMykBelgesi";
            this.lblMykBelgesi.Size = new System.Drawing.Size(85, 18);
            this.lblMykBelgesi.TabIndex = 2;
            this.lblMykBelgesi.Text = "MYK Belgesi";
            // 
            // lblPeriyodikMuayene
            // 
            this.lblPeriyodikMuayene.AutoSize = true;
            this.lblPeriyodikMuayene.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPeriyodikMuayene.Location = new System.Drawing.Point(81, 78);
            this.lblPeriyodikMuayene.Name = "lblPeriyodikMuayene";
            this.lblPeriyodikMuayene.Size = new System.Drawing.Size(129, 18);
            this.lblPeriyodikMuayene.TabIndex = 2;
            this.lblPeriyodikMuayene.Text = "Periyodik Muayene";
            this.lblPeriyodikMuayene.Click += new System.EventHandler(this.lblPersonelKodu_Click);
            // 
            // cmbBindingSource
            // 
            this.cmbBindingSource.DataMember = "cmb";
            this.cmbBindingSource.DataSource = this.personelDataSet;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "PersonelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAra
            // 
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAra.Location = new System.Drawing.Point(355, 55);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(76, 20);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(22, 55);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(65, 18);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(93, 55);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(256, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnperkaydet
            // 
            this.btnperkaydet.Location = new System.Drawing.Point(437, 55);
            this.btnperkaydet.Name = "btnperkaydet";
            this.btnperkaydet.Size = new System.Drawing.Size(74, 20);
            this.btnperkaydet.TabIndex = 4;
            this.btnperkaydet.Text = "Güncelle";
            this.btnperkaydet.UseVisualStyleBackColor = true;
            this.btnperkaydet.Click += new System.EventHandler(this.btnperkaydet_Click);
            // 
            // cmbTableAdapter
            // 
            this.cmbTableAdapter.ClearBeforeFill = true;
            // 
            // cmbBindingSource1
            // 
            this.cmbBindingSource1.DataMember = "cmb";
            this.cmbBindingSource1.DataSource = this.personelDataSet;
            // 
            // personelDataSetBindingSource
            // 
            this.personelDataSetBindingSource.DataSource = this.personelDataSet;
            this.personelDataSetBindingSource.Position = 0;
            // 
            // cmbBindingSource2
            // 
            this.cmbBindingSource2.DataMember = "cmb";
            this.cmbBindingSource2.DataSource = this.personelDataSetBindingSource;
            // 
            // personelDataSet1
            // 
            this.personelDataSet1.DataSetName = "PersonelDataSet1";
            this.personelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBindingSource3
            // 
            this.cmbBindingSource3.DataMember = "cmb";
            this.cmbBindingSource3.DataSource = this.personelDataSet1;
            // 
            // cmbTableAdapter1
            // 
            this.cmbTableAdapter1.ClearBeforeFill = true;
            // 
            // personelDataSet2
            // 
            this.personelDataSet2.DataSetName = "PersonelDataSet2";
            this.personelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBindingSource4
            // 
            this.cmbBindingSource4.DataMember = "cmb";
            this.cmbBindingSource4.DataSource = this.personelDataSet2;
            // 
            // cmbTableAdapter2
            // 
            this.cmbTableAdapter2.ClearBeforeFill = true;
            // 
            // lblFirmaÜnvanı
            // 
            this.lblFirmaÜnvanı.AutoSize = true;
            this.lblFirmaÜnvanı.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaÜnvanı.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirmaÜnvanı.Location = new System.Drawing.Point(900, 62);
            this.lblFirmaÜnvanı.Name = "lblFirmaÜnvanı";
            this.lblFirmaÜnvanı.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirmaÜnvanı.Size = new System.Drawing.Size(0, 13);
            this.lblFirmaÜnvanı.TabIndex = 5;
            this.lblFirmaÜnvanı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.grpbxMeslekiYeterlilik);
            this.tabPage1.Controls.Add(this.grpbxİSG);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 318);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "MY - İSG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpbxMeslekiYeterlilik
            // 
            this.grpbxMeslekiYeterlilik.Controls.Add(this.cmbmykbelge);
            this.grpbxMeslekiYeterlilik.Controls.Add(this.lblBelgeDurumu);
            this.grpbxMeslekiYeterlilik.Controls.Add(this.cmbBelgeDurumu);
            this.grpbxMeslekiYeterlilik.Controls.Add(this.lblMykBelgesi);
            this.grpbxMeslekiYeterlilik.Location = new System.Drawing.Point(39, 21);
            this.grpbxMeslekiYeterlilik.Name = "grpbxMeslekiYeterlilik";
            this.grpbxMeslekiYeterlilik.Size = new System.Drawing.Size(463, 115);
            this.grpbxMeslekiYeterlilik.TabIndex = 5;
            this.grpbxMeslekiYeterlilik.TabStop = false;
            this.grpbxMeslekiYeterlilik.Text = " ";
            // 
            // grpbxİSG
            // 
            this.grpbxİSG.Controls.Add(this.dtİsgEğitimTarihi);
            this.grpbxİSG.Controls.Add(this.lblİsgEğitimTarihi);
            this.grpbxİSG.Controls.Add(this.dtPeriyodikMuayene);
            this.grpbxİSG.Controls.Add(this.lblPeriyodikMuayene);
            this.grpbxİSG.Controls.Add(this.dtGeçerlilikİY);
            this.grpbxİSG.Controls.Add(this.cmbAcilDurumGrubu);
            this.grpbxİSG.Controls.Add(this.lblAcilDurumGrubu);
            this.grpbxİSG.Controls.Add(this.cmbİlkYardımBelgesi);
            this.grpbxİSG.Controls.Add(this.lblİlkYardımBelgesi);
            this.grpbxİSG.Controls.Add(this.label7);
            this.grpbxİSG.Location = new System.Drawing.Point(531, 21);
            this.grpbxİSG.Name = "grpbxİSG";
            this.grpbxİSG.Size = new System.Drawing.Size(414, 281);
            this.grpbxİSG.TabIndex = 6;
            this.grpbxİSG.TabStop = false;
            this.grpbxİSG.Text = "İş Sağlığı ve Güvenliği";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.Durak);
            this.tabPage2.Controls.Add(this.lblServis);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 318);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Diğer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbServis);
            this.groupBox2.Controls.Add(this.cmbDurak);
            this.groupBox2.Location = new System.Drawing.Point(85, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 137);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHesapNo);
            this.groupBox3.Controls.Add(this.lblHesapNo);
            this.groupBox3.Controls.Add(this.txtİbanNo);
            this.groupBox3.Controls.Add(this.lblİbanNo);
            this.groupBox3.Location = new System.Drawing.Point(545, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 137);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Banka Bilgileri";
            // 
            // lblİbanNo
            // 
            this.lblİbanNo.AutoSize = true;
            this.lblİbanNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİbanNo.Location = new System.Drawing.Point(21, 39);
            this.lblİbanNo.Name = "lblİbanNo";
            this.lblİbanNo.Size = new System.Drawing.Size(56, 18);
            this.lblİbanNo.TabIndex = 2;
            this.lblİbanNo.Text = "İban No";
            // 
            // txtİbanNo
            // 
            this.txtİbanNo.Location = new System.Drawing.Point(149, 41);
            this.txtİbanNo.Name = "txtİbanNo";
            this.txtİbanNo.Size = new System.Drawing.Size(198, 20);
            this.txtİbanNo.TabIndex = 3;
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNo.Location = new System.Drawing.Point(21, 77);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(107, 18);
            this.lblHesapNo.TabIndex = 2;
            this.lblHesapNo.Text = "Banka Hesap No";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(149, 79);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(130, 20);
            this.txtHesapNo.TabIndex = 3;
            // 
            // lblİsgEğitimTarihi
            // 
            this.lblİsgEğitimTarihi.AutoSize = true;
            this.lblİsgEğitimTarihi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİsgEğitimTarihi.Location = new System.Drawing.Point(106, 51);
            this.lblİsgEğitimTarihi.Name = "lblİsgEğitimTarihi";
            this.lblİsgEğitimTarihi.Size = new System.Drawing.Size(104, 18);
            this.lblİsgEğitimTarihi.TabIndex = 2;
            this.lblİsgEğitimTarihi.Text = "İsg Eğitim Tarihi";
            this.lblİsgEğitimTarihi.Click += new System.EventHandler(this.lblPersonelKodu_Click);
            // 
            // dtİsgEğitimTarihi
            // 
            this.dtİsgEğitimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtİsgEğitimTarihi.Location = new System.Drawing.Point(224, 51);
            this.dtİsgEğitimTarihi.Name = "dtİsgEğitimTarihi";
            this.dtİsgEğitimTarihi.Size = new System.Drawing.Size(121, 20);
            this.dtİsgEğitimTarihi.TabIndex = 4;
            // 
            // lblBirimAmiri
            // 
            this.lblBirimAmiri.AutoSize = true;
            this.lblBirimAmiri.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimAmiri.Location = new System.Drawing.Point(50, 224);
            this.lblBirimAmiri.Name = "lblBirimAmiri";
            this.lblBirimAmiri.Size = new System.Drawing.Size(78, 18);
            this.lblBirimAmiri.TabIndex = 2;
            this.lblBirimAmiri.Text = "Birim Amiri";
            // 
            // cmbBirimAmiri
            // 
            this.cmbBirimAmiri.FormattingEnabled = true;
            this.cmbBirimAmiri.Location = new System.Drawing.Point(181, 221);
            this.cmbBirimAmiri.Name = "cmbBirimAmiri";
            this.cmbBirimAmiri.Size = new System.Drawing.Size(144, 21);
            this.cmbBirimAmiri.TabIndex = 4;
            // 
            // lblNetÜcret
            // 
            this.lblNetÜcret.AutoSize = true;
            this.lblNetÜcret.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetÜcret.Location = new System.Drawing.Point(665, 47);
            this.lblNetÜcret.Name = "lblNetÜcret";
            this.lblNetÜcret.Size = new System.Drawing.Size(68, 18);
            this.lblNetÜcret.TabIndex = 2;
            this.lblNetÜcret.Text = "Net Ücret";
            // 
            // txtNetÜcret
            // 
            this.txtNetÜcret.Location = new System.Drawing.Point(796, 47);
            this.txtNetÜcret.Name = "txtNetÜcret";
            this.txtNetÜcret.Size = new System.Drawing.Size(121, 20);
            this.txtNetÜcret.TabIndex = 3;
            // 
            // lblAGİ
            // 
            this.lblAGİ.AutoSize = true;
            this.lblAGİ.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAGİ.Location = new System.Drawing.Point(665, 68);
            this.lblAGİ.Name = "lblAGİ";
            this.lblAGİ.Size = new System.Drawing.Size(31, 18);
            this.lblAGİ.TabIndex = 2;
            this.lblAGİ.Text = "AGİ";
            // 
            // txtAGİ
            // 
            this.txtAGİ.Location = new System.Drawing.Point(796, 68);
            this.txtAGİ.Name = "txtAGİ";
            this.txtAGİ.Size = new System.Drawing.Size(121, 20);
            this.txtAGİ.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(684, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Eş Durumu";
            // 
            // cmbEşDurumu
            // 
            this.cmbEşDurumu.FormattingEnabled = true;
            this.cmbEşDurumu.Location = new System.Drawing.Point(800, 76);
            this.cmbEşDurumu.Name = "cmbEşDurumu";
            this.cmbEşDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbEşDurumu.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(684, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Çocuk Sayısı";
            // 
            // txtÇocukSayısı
            // 
            this.txtÇocukSayısı.Location = new System.Drawing.Point(800, 113);
            this.txtÇocukSayısı.Name = "txtÇocukSayısı";
            this.txtÇocukSayısı.Size = new System.Drawing.Size(121, 20);
            this.txtÇocukSayısı.TabIndex = 3;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(311, 43);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(58, 18);
            this.lblCinsiyet.TabIndex = 2;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(386, 43);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(115, 21);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // lblAcilDurumGrubu
            // 
            this.lblAcilDurumGrubu.AutoSize = true;
            this.lblAcilDurumGrubu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcilDurumGrubu.Location = new System.Drawing.Point(93, 225);
            this.lblAcilDurumGrubu.Name = "lblAcilDurumGrubu";
            this.lblAcilDurumGrubu.Size = new System.Drawing.Size(118, 18);
            this.lblAcilDurumGrubu.TabIndex = 2;
            this.lblAcilDurumGrubu.Text = "Acil Durum Grubu";
            // 
            // cmbAcilDurumGrubu
            // 
            this.cmbAcilDurumGrubu.FormattingEnabled = true;
            this.cmbAcilDurumGrubu.Location = new System.Drawing.Point(224, 222);
            this.cmbAcilDurumGrubu.Name = "cmbAcilDurumGrubu";
            this.cmbAcilDurumGrubu.Size = new System.Drawing.Size(121, 21);
            this.cmbAcilDurumGrubu.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(41, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 144);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mesleki Yeterlilik";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(286, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Alt Beden";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(35, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Üst Beden";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(35, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ayakkabı No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(546, 55);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 20);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(517, 55);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(23, 20);
            this.btnYeni.TabIndex = 7;
            this.btnYeni.Text = "+";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(627, 55);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(26, 20);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "x";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 663);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblFirmaÜnvanı);
            this.Controls.Add(this.btnperkaydet);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Perkır Personel Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerFoto)).EndInit();
            this.tbcperbilgiler.ResumeLayout(false);
            this.tpKişiselBilgiler.ResumeLayout(false);
            this.tpKişiselBilgiler.PerformLayout();
            this.tbÇalışmaBilgileri.ResumeLayout(false);
            this.tbÇalışmaBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource4)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.grpbxMeslekiYeterlilik.ResumeLayout(false);
            this.grpbxMeslekiYeterlilik.PerformLayout();
            this.grpbxİSG.ResumeLayout(false);
            this.grpbxİSG.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblKanGrubu;
        private System.Windows.Forms.TextBox txtBabaAdı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.TabControl tbcperbilgiler;
        private System.Windows.Forms.TabPage tpKişiselBilgiler;
        private System.Windows.Forms.TabPage tbÇalışmaBilgileri;
        private System.Windows.Forms.DateTimePicker dtDoğumTarihi;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDahili;
        private System.Windows.Forms.Label lblDahiliNo;
        private System.Windows.Forms.TextBox txtPersonelKodu;
        private System.Windows.Forms.Label lblPersonelKodu;
        private System.Windows.Forms.TextBox txtCepTelNo;
        private System.Windows.Forms.Label lblCepTelefonNo;
        private System.Windows.Forms.ComboBox cmbAskerlikDurumu;
        private System.Windows.Forms.ComboBox cmbÖğrenimDurumu;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMedeniHali;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDoğumYeri;
        private System.Windows.Forms.TextBox txtGörev;
        private System.Windows.Forms.Label lblGörev;
        private System.Windows.Forms.Label lblDoğumTarihi;
        private System.Windows.Forms.ComboBox cmbMedeniHali;
        private System.Windows.Forms.ComboBox cmbKanGrubu;
        private System.Windows.Forms.ComboBox cmbDurak;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.Label Durak;
        private System.Windows.Forms.Label lblServis;
        private System.Windows.Forms.ComboBox cmbİlkYardımBelgesi;
        private System.Windows.Forms.ComboBox cmbBölüm;
        private System.Windows.Forms.Label lblİlkYardımBelgesi;
        private System.Windows.Forms.Label lblBölüm;
        private System.Windows.Forms.ComboBox cmbEmekli;
        private System.Windows.Forms.Label lblKısım;
        private System.Windows.Forms.ComboBox cmbmykbelge;
        private System.Windows.Forms.Label lblEmekli;
        private System.Windows.Forms.Label lblMykBelgesi;
        private System.Windows.Forms.DateTimePicker dtKıdemTarihi;
        private System.Windows.Forms.DateTimePicker dtİşeGirişTarihi;
        private System.Windows.Forms.DateTimePicker dtPeriyodikMuayene;
        private System.Windows.Forms.ComboBox cmbÖzelDurum;
        private System.Windows.Forms.Label lblÖzelDurum;
        private System.Windows.Forms.Label lblKıdemTarihi;
        private System.Windows.Forms.Label lblİşeGirişTarihi;
        private System.Windows.Forms.Label lblPeriyodikMuayene;
        private System.Windows.Forms.Label lblKıdemYılı;
        private System.Windows.Forms.DateTimePicker dtGeçerlilikİY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbPerFoto;
        private System.Windows.Forms.ComboBox cmbUyruğu;
        private System.Windows.Forms.ComboBox cmbİlçe;
        private System.Windows.Forms.ComboBox cmbİl;
        private System.Windows.Forms.ComboBox cmbDoğumYeri;
        private System.Windows.Forms.Label lblİlçe;
        private System.Windows.Forms.Label lblİl;
        private System.Windows.Forms.Label lblUyruğu;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.ComboBox cmbÇalışmaŞekli;
        private System.Windows.Forms.ComboBox cmbBelgeDurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBelgeDurumu;
        private System.Windows.Forms.Label lblİştençıkıştarihi;
        private System.Windows.Forms.DateTimePicker dtİştenÇıkışTarihi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnperkaydet;
        private PersonelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource cmbBindingSource;
        private PersonelDataSetTableAdapters.cmbTableAdapter cmbTableAdapter;
        private System.Windows.Forms.BindingSource cmbBindingSource1;
        private System.Windows.Forms.ComboBox cmbKısım;
        private System.Windows.Forms.BindingSource cmbBindingSource2;
        private System.Windows.Forms.BindingSource personelDataSetBindingSource;
        private PersonelDataSet1 personelDataSet1;
        private System.Windows.Forms.BindingSource cmbBindingSource3;
        private PersonelDataSet1TableAdapters.cmbTableAdapter cmbTableAdapter1;
        private PersonelDataSet2 personelDataSet2;
        private System.Windows.Forms.BindingSource cmbBindingSource4;
        private PersonelDataSet2TableAdapters.cmbTableAdapter cmbTableAdapter2;
        private System.Windows.Forms.Label lblFirmaÜnvanı;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpbxMeslekiYeterlilik;
        private System.Windows.Forms.GroupBox grpbxİSG;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.TextBox txtİbanNo;
        private System.Windows.Forms.Label lblİbanNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtİsgEğitimTarihi;
        private System.Windows.Forms.Label lblİsgEğitimTarihi;
        private System.Windows.Forms.ComboBox cmbBirimAmiri;
        private System.Windows.Forms.Label lblBirimAmiri;
        private System.Windows.Forms.ComboBox cmbEşDurumu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAGİ;
        private System.Windows.Forms.Label lblAGİ;
        private System.Windows.Forms.TextBox txtNetÜcret;
        private System.Windows.Forms.Label lblNetÜcret;
        private System.Windows.Forms.TextBox txtÇocukSayısı;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbAcilDurumGrubu;
        private System.Windows.Forms.Label lblAcilDurumGrubu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
    }
}

