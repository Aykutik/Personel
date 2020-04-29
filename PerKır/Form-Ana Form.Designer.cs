namespace PerKır
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pertcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdoğumtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perceptelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perişegiriştarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periştençıkıştarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perkıdemtarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pergörevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perçalışmaşekliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aktar = new PerKır.Aktar();
            this.perListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet3 = new PerKır.PersonelDataSet3();
            this.personelDataSet = new PerKır.PersonelDataSet();
            this.personelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perListTableAdapter = new PerKır.PersonelDataSet3TableAdapters.PerListTableAdapter();
            this.txtekle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAraPer = new System.Windows.Forms.TextBox();
            this.lblTcnoGizli = new System.Windows.Forms.Label();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.lblPerAdSoyadGizli = new System.Windows.Forms.Label();
            this.perListTableAdapter1 = new PerKır.AktarTableAdapters.PerListTableAdapter();
            this.txtAraTCNo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perkodDataGridViewTextBoxColumn,
            this.peradsoyadDataGridViewTextBoxColumn,
            this.pertcnoDataGridViewTextBoxColumn,
            this.perdoğumtarihiDataGridViewTextBoxColumn,
            this.perceptelefonuDataGridViewTextBoxColumn,
            this.perişegiriştarihiDataGridViewTextBoxColumn,
            this.periştençıkıştarihiDataGridViewTextBoxColumn,
            this.perkıdemtarihi,
            this.pergörevDataGridViewTextBoxColumn,
            this.perçalışmaşekliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.perListBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 588);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perkodDataGridViewTextBoxColumn
            // 
            this.perkodDataGridViewTextBoxColumn.DataPropertyName = "perkod";
            this.perkodDataGridViewTextBoxColumn.HeaderText = "Personel Kodu";
            this.perkodDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.perkodDataGridViewTextBoxColumn.Name = "perkodDataGridViewTextBoxColumn";
            this.perkodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peradsoyadDataGridViewTextBoxColumn
            // 
            this.peradsoyadDataGridViewTextBoxColumn.DataPropertyName = "peradsoyad";
            this.peradsoyadDataGridViewTextBoxColumn.HeaderText = "Ad Soyad";
            this.peradsoyadDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.peradsoyadDataGridViewTextBoxColumn.Name = "peradsoyadDataGridViewTextBoxColumn";
            this.peradsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.peradsoyadDataGridViewTextBoxColumn.Width = 180;
            // 
            // pertcnoDataGridViewTextBoxColumn
            // 
            this.pertcnoDataGridViewTextBoxColumn.DataPropertyName = "pertcno";
            this.pertcnoDataGridViewTextBoxColumn.HeaderText = "TC NO";
            this.pertcnoDataGridViewTextBoxColumn.Name = "pertcnoDataGridViewTextBoxColumn";
            this.pertcnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perdoğumtarihiDataGridViewTextBoxColumn
            // 
            this.perdoğumtarihiDataGridViewTextBoxColumn.DataPropertyName = "perdoğumtarihi";
            this.perdoğumtarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.perdoğumtarihiDataGridViewTextBoxColumn.Name = "perdoğumtarihiDataGridViewTextBoxColumn";
            this.perdoğumtarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perceptelefonuDataGridViewTextBoxColumn
            // 
            this.perceptelefonuDataGridViewTextBoxColumn.DataPropertyName = "perceptelefonu";
            this.perceptelefonuDataGridViewTextBoxColumn.HeaderText = "Cep Telefonu";
            this.perceptelefonuDataGridViewTextBoxColumn.Name = "perceptelefonuDataGridViewTextBoxColumn";
            this.perceptelefonuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perişegiriştarihiDataGridViewTextBoxColumn
            // 
            this.perişegiriştarihiDataGridViewTextBoxColumn.DataPropertyName = "perişegiriştarihi";
            this.perişegiriştarihiDataGridViewTextBoxColumn.HeaderText = "İşe Giriş Tarihi";
            this.perişegiriştarihiDataGridViewTextBoxColumn.Name = "perişegiriştarihiDataGridViewTextBoxColumn";
            this.perişegiriştarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periştençıkıştarihiDataGridViewTextBoxColumn
            // 
            this.periştençıkıştarihiDataGridViewTextBoxColumn.DataPropertyName = "periştençıkıştarihi";
            this.periştençıkıştarihiDataGridViewTextBoxColumn.HeaderText = "İşten Çıkış Tarihi";
            this.periştençıkıştarihiDataGridViewTextBoxColumn.Name = "periştençıkıştarihiDataGridViewTextBoxColumn";
            this.periştençıkıştarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perkıdemtarihi
            // 
            this.perkıdemtarihi.DataPropertyName = "perkıdemtarihi";
            this.perkıdemtarihi.HeaderText = "Kıdem Tarihi";
            this.perkıdemtarihi.Name = "perkıdemtarihi";
            this.perkıdemtarihi.ReadOnly = true;
            // 
            // pergörevDataGridViewTextBoxColumn
            // 
            this.pergörevDataGridViewTextBoxColumn.DataPropertyName = "pergörev";
            this.pergörevDataGridViewTextBoxColumn.HeaderText = "Görev";
            this.pergörevDataGridViewTextBoxColumn.Name = "pergörevDataGridViewTextBoxColumn";
            this.pergörevDataGridViewTextBoxColumn.ReadOnly = true;
            this.pergörevDataGridViewTextBoxColumn.Width = 220;
            // 
            // perçalışmaşekliDataGridViewTextBoxColumn
            // 
            this.perçalışmaşekliDataGridViewTextBoxColumn.DataPropertyName = "perçalışmaşekli";
            this.perçalışmaşekliDataGridViewTextBoxColumn.HeaderText = "Çalışma Şekli";
            this.perçalışmaşekliDataGridViewTextBoxColumn.Name = "perçalışmaşekliDataGridViewTextBoxColumn";
            this.perçalışmaşekliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perListBindingSource1
            // 
            this.perListBindingSource1.DataMember = "PerList";
            this.perListBindingSource1.DataSource = this.aktar;
            // 
            // aktar
            // 
            this.aktar.DataSetName = "Aktar";
            this.aktar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perListBindingSource
            // 
            this.perListBindingSource.DataMember = "PerList";
            this.perListBindingSource.DataSource = this.personelDataSet3;
            // 
            // personelDataSet3
            // 
            this.personelDataSet3.DataSetName = "PersonelDataSet3";
            this.personelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "PersonelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDataSetBindingSource
            // 
            this.personelDataSetBindingSource.DataSource = this.personelDataSet;
            this.personelDataSetBindingSource.Position = 0;
            // 
            // perListTableAdapter
            // 
            this.perListTableAdapter.ClearBeforeFill = true;
            // 
            // txtekle
            // 
            this.txtekle.BackColor = System.Drawing.Color.White;
            this.txtekle.Location = new System.Drawing.Point(1129, 62);
            this.txtekle.Name = "txtekle";
            this.txtekle.Size = new System.Drawing.Size(75, 23);
            this.txtekle.TabIndex = 1;
            this.txtekle.Text = "Ekle";
            this.txtekle.UseVisualStyleBackColor = false;
            this.txtekle.Click += new System.EventHandler(this.txtekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(142, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Takip Sistemi";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(1291, 62);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAraPer
            // 
            this.txtAraPer.Location = new System.Drawing.Point(117, 65);
            this.txtAraPer.Name = "txtAraPer";
            this.txtAraPer.Size = new System.Drawing.Size(175, 20);
            this.txtAraPer.TabIndex = 6;
            this.txtAraPer.TextChanged += new System.EventHandler(this.txtAraPer_TextChanged);
            // 
            // lblTcnoGizli
            // 
            this.lblTcnoGizli.AutoSize = true;
            this.lblTcnoGizli.Location = new System.Drawing.Point(399, 12);
            this.lblTcnoGizli.Name = "lblTcnoGizli";
            this.lblTcnoGizli.Size = new System.Drawing.Size(35, 13);
            this.lblTcnoGizli.TabIndex = 7;
            this.lblTcnoGizli.Text = "label2";
            this.lblTcnoGizli.Visible = false;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.BackColor = System.Drawing.Color.White;
            this.btnDüzenle.Location = new System.Drawing.Point(1210, 62);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 8;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = false;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // lblPerAdSoyadGizli
            // 
            this.lblPerAdSoyadGizli.AutoSize = true;
            this.lblPerAdSoyadGizli.Location = new System.Drawing.Point(399, 35);
            this.lblPerAdSoyadGizli.Name = "lblPerAdSoyadGizli";
            this.lblPerAdSoyadGizli.Size = new System.Drawing.Size(35, 13);
            this.lblPerAdSoyadGizli.TabIndex = 7;
            this.lblPerAdSoyadGizli.Text = "label2";
            this.lblPerAdSoyadGizli.Visible = false;
            // 
            // perListTableAdapter1
            // 
            this.perListTableAdapter1.ClearBeforeFill = true;
            // 
            // txtAraTCNo
            // 
            this.txtAraTCNo.Location = new System.Drawing.Point(297, 65);
            this.txtAraTCNo.Name = "txtAraTCNo";
            this.txtAraTCNo.Size = new System.Drawing.Size(94, 20);
            this.txtAraTCNo.TabIndex = 6;
            this.txtAraTCNo.TextChanged += new System.EventHandler(this.txtAraPer_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.txtAraPer_TextChanged);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 693);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.lblPerAdSoyadGizli);
            this.Controls.Add(this.lblTcnoGizli);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAraTCNo);
            this.Controls.Add(this.txtAraPer);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtekle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PersonelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource personelDataSetBindingSource;
        private PersonelDataSet3 personelDataSet3;
        private System.Windows.Forms.BindingSource perListBindingSource;
        private PersonelDataSet3TableAdapters.PerListTableAdapter perListTableAdapter;
        private System.Windows.Forms.Button txtekle;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAraPer;
        private System.Windows.Forms.Button btnDüzenle;
        public System.Windows.Forms.Label lblTcnoGizli;
        public System.Windows.Forms.Label lblPerAdSoyadGizli;
        private Aktar aktar;
        private System.Windows.Forms.BindingSource perListBindingSource1;
        private AktarTableAdapters.PerListTableAdapter perListTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pertcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perdoğumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perceptelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perişegiriştarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periştençıkıştarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perkıdemtarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn pergörevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perçalışmaşekliDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAraTCNo;
        private System.Windows.Forms.TextBox textBox1;
    }
}