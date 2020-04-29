namespace PerKır
{
    partial class frmBirimTanım
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbbirimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet8 = new PerKır.PersonelDataSet8();
            this.lblBirimSilGizli = new System.Windows.Forms.Label();
            this.btnSilBirim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBölüm_seç = new System.Windows.Forms.ComboBox();
            this.btnEkleBirim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirimEkle = new System.Windows.Forms.TextBox();
            this.cmb_birimTableAdapter = new PerKır.PersonelDataSet8TableAdapters.cmb_birimTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbirimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet8)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblBirimSilGizli);
            this.groupBox2.Controls.Add(this.btnSilBirim);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtara);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 261);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.birimDataGridViewTextBoxColumn,
            this.bölümDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cmbbirimBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(56, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(232, 184);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_2);
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "Birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            this.birimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            this.bölümDataGridViewTextBoxColumn.DataPropertyName = "bölüm";
            this.bölümDataGridViewTextBoxColumn.HeaderText = "Bağlı Bölüm";
            this.bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            this.bölümDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmbbirimBindingSource
            // 
            this.cmbbirimBindingSource.DataMember = "cmb_birim";
            this.cmbbirimBindingSource.DataSource = this.personelDataSet8;
            // 
            // personelDataSet8
            // 
            this.personelDataSet8.DataSetName = "PersonelDataSet8";
            this.personelDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBirimSilGizli
            // 
            this.lblBirimSilGizli.AutoSize = true;
            this.lblBirimSilGizli.Location = new System.Drawing.Point(53, 243);
            this.lblBirimSilGizli.Name = "lblBirimSilGizli";
            this.lblBirimSilGizli.Size = new System.Drawing.Size(51, 13);
            this.lblBirimSilGizli.TabIndex = 3;
            this.lblBirimSilGizli.Text = "seçimyok";
            this.lblBirimSilGizli.Visible = false;
            // 
            // btnSilBirim
            // 
            this.btnSilBirim.Location = new System.Drawing.Point(253, 21);
            this.btnSilBirim.Name = "btnSilBirim";
            this.btnSilBirim.Size = new System.Drawing.Size(35, 20);
            this.btnSilBirim.TabIndex = 2;
            this.btnSilBirim.Text = "Sil";
            this.btnSilBirim.UseVisualStyleBackColor = true;
            this.btnSilBirim.Click += new System.EventHandler(this.btnSilBirim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(90, 22);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(157, 20);
            this.txtara.TabIndex = 0;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBölüm_seç);
            this.groupBox1.Controls.Add(this.btnEkleBirim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBirimEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // cmbBölüm_seç
            // 
            this.cmbBölüm_seç.FormattingEnabled = true;
            this.cmbBölüm_seç.Location = new System.Drawing.Point(224, 18);
            this.cmbBölüm_seç.Name = "cmbBölüm_seç";
            this.cmbBölüm_seç.Size = new System.Drawing.Size(108, 21);
            this.cmbBölüm_seç.TabIndex = 3;
            // 
            // btnEkleBirim
            // 
            this.btnEkleBirim.Location = new System.Drawing.Point(283, 49);
            this.btnEkleBirim.Name = "btnEkleBirim";
            this.btnEkleBirim.Size = new System.Drawing.Size(49, 20);
            this.btnEkleBirim.TabIndex = 2;
            this.btnEkleBirim.Text = "Ekle";
            this.btnEkleBirim.UseVisualStyleBackColor = true;
            this.btnEkleBirim.Click += new System.EventHandler(this.btnEkleBölüm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birim";
            // 
            // txtBirimEkle
            // 
            this.txtBirimEkle.Location = new System.Drawing.Point(47, 19);
            this.txtBirimEkle.Name = "txtBirimEkle";
            this.txtBirimEkle.Size = new System.Drawing.Size(157, 20);
            this.txtBirimEkle.TabIndex = 0;
            // 
            // cmb_birimTableAdapter
            // 
            this.cmb_birimTableAdapter.ClearBeforeFill = true;
            // 
            // frmBirimTanım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBirimTanım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BirimTanım";
            this.Load += new System.EventHandler(this.BirimTanım_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbirimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBirimSilGizli;
        private System.Windows.Forms.Button btnSilBirim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBölüm_seç;
        private System.Windows.Forms.Button btnEkleBirim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirimEkle;
        private PersonelDataSet8 personelDataSet8;
        private System.Windows.Forms.BindingSource cmbbirimBindingSource;
        private PersonelDataSet8TableAdapters.cmb_birimTableAdapter cmb_birimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
    }
}