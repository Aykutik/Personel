namespace PerKır
{
    partial class GörevTanım
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBirimAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.göreviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbgörevBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet1cmbHepsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet1cmbHepsi = new PerKır.PersonelDataSet1cmbHepsi();
            this.lblGörevTanımıSilGizli = new System.Windows.Forms.Label();
            this.btnGörevTanımıSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.cmbgörevBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet12 = new PerKır.PersonelDataSet12();
            this.cmbgörevBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet11 = new PerKır.PersonelDataSet11();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBirim_seç = new System.Windows.Forms.ComboBox();
            this.btnEkleBelgeDurumu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGörevTanımıEkle = new System.Windows.Forms.TextBox();
            this.personelDataSet10 = new PerKır.PersonelDataSet10();
            this.cmbgörevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_görevTableAdapter = new PerKır.PersonelDataSet10TableAdapters.cmb_görevTableAdapter();
            this.cmb_görevTableAdapter1 = new PerKır.PersonelDataSet11TableAdapters.cmb_görevTableAdapter();
            this.cmb_görevTableAdapter2 = new PerKır.PersonelDataSet12TableAdapters.cmb_görevTableAdapter();
            this.cmbbirimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_birimTableAdapter = new PerKır.PersonelDataSet1cmbHepsiTableAdapters.cmb_birimTableAdapter();
            this.cmb_görevTableAdapter3 = new PerKır.PersonelDataSet1cmbHepsiTableAdapters.cmb_görevTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgörevBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1cmbHepsiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1cmbHepsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgörevBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgörevBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgörevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbirimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBirimAra);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblGörevTanımıSilGizli);
            this.groupBox2.Controls.Add(this.btnGörevTanımıSil);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtara);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 296);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // txtBirimAra
            // 
            this.txtBirimAra.Location = new System.Drawing.Point(327, 57);
            this.txtBirimAra.Name = "txtBirimAra";
            this.txtBirimAra.Size = new System.Drawing.Size(115, 20);
            this.txtBirimAra.TabIndex = 5;
            this.txtBirimAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.göreviDataGridViewTextBoxColumn,
            this.birimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cmbgörevBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(21, 85);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(421, 184);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // göreviDataGridViewTextBoxColumn
            // 
            this.göreviDataGridViewTextBoxColumn.DataPropertyName = "görevi";
            this.göreviDataGridViewTextBoxColumn.HeaderText = "Görevi";
            this.göreviDataGridViewTextBoxColumn.Name = "göreviDataGridViewTextBoxColumn";
            this.göreviDataGridViewTextBoxColumn.ReadOnly = true;
            this.göreviDataGridViewTextBoxColumn.Width = 300;
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "Birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "Bağlı Birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            this.birimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmbgörevBindingSource3
            // 
            this.cmbgörevBindingSource3.DataMember = "cmb_görev";
            this.cmbgörevBindingSource3.DataSource = this.personelDataSet1cmbHepsiBindingSource;
            // 
            // personelDataSet1cmbHepsiBindingSource
            // 
            this.personelDataSet1cmbHepsiBindingSource.DataSource = this.personelDataSet1cmbHepsi;
            this.personelDataSet1cmbHepsiBindingSource.Position = 0;
            // 
            // personelDataSet1cmbHepsi
            // 
            this.personelDataSet1cmbHepsi.DataSetName = "PersonelDataSet1cmbHepsi";
            this.personelDataSet1cmbHepsi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblGörevTanımıSilGizli
            // 
            this.lblGörevTanımıSilGizli.AutoSize = true;
            this.lblGörevTanımıSilGizli.Location = new System.Drawing.Point(18, 272);
            this.lblGörevTanımıSilGizli.Name = "lblGörevTanımıSilGizli";
            this.lblGörevTanımıSilGizli.Size = new System.Drawing.Size(51, 13);
            this.lblGörevTanımıSilGizli.TabIndex = 3;
            this.lblGörevTanımıSilGizli.Text = "seçimyok";
            // 
            // btnGörevTanımıSil
            // 
            this.btnGörevTanımıSil.BackColor = System.Drawing.Color.White;
            this.btnGörevTanımıSil.Location = new System.Drawing.Point(393, 30);
            this.btnGörevTanımıSil.Name = "btnGörevTanımıSil";
            this.btnGörevTanımıSil.Size = new System.Drawing.Size(49, 21);
            this.btnGörevTanımıSil.TabIndex = 2;
            this.btnGörevTanımıSil.Text = "Sil";
            this.btnGörevTanımıSil.UseVisualStyleBackColor = false;
            this.btnGörevTanımıSil.Click += new System.EventHandler(this.btnGörevTanımıSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(21, 57);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(300, 20);
            this.txtara.TabIndex = 0;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            this.txtara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtara_KeyDown);
            // 
            // cmbgörevBindingSource2
            // 
            this.cmbgörevBindingSource2.DataMember = "cmb_görev";
            this.cmbgörevBindingSource2.DataSource = this.personelDataSet12;
            // 
            // personelDataSet12
            // 
            this.personelDataSet12.DataSetName = "PersonelDataSet12";
            this.personelDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbgörevBindingSource1
            // 
            this.cmbgörevBindingSource1.DataMember = "cmb_görev";
            this.cmbgörevBindingSource1.DataSource = this.personelDataSet11;
            // 
            // personelDataSet11
            // 
            this.personelDataSet11.DataSetName = "PersonelDataSet11";
            this.personelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBirim_seç);
            this.groupBox1.Controls.Add(this.btnEkleBelgeDurumu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGörevTanımıEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // cmbBirim_seç
            // 
            this.cmbBirim_seç.FormattingEnabled = true;
            this.cmbBirim_seç.Location = new System.Drawing.Point(21, 29);
            this.cmbBirim_seç.Name = "cmbBirim_seç";
            this.cmbBirim_seç.Size = new System.Drawing.Size(108, 21);
            this.cmbBirim_seç.TabIndex = 3;
            // 
            // btnEkleBelgeDurumu
            // 
            this.btnEkleBelgeDurumu.BackColor = System.Drawing.Color.White;
            this.btnEkleBelgeDurumu.Location = new System.Drawing.Point(393, 55);
            this.btnEkleBelgeDurumu.Name = "btnEkleBelgeDurumu";
            this.btnEkleBelgeDurumu.Size = new System.Drawing.Size(49, 20);
            this.btnEkleBelgeDurumu.TabIndex = 2;
            this.btnEkleBelgeDurumu.Text = "Ekle";
            this.btnEkleBelgeDurumu.UseVisualStyleBackColor = false;
            this.btnEkleBelgeDurumu.Click += new System.EventHandler(this.btnEkleBirimAmiri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Görev";
            // 
            // txtGörevTanımıEkle
            // 
            this.txtGörevTanımıEkle.Location = new System.Drawing.Point(199, 29);
            this.txtGörevTanımıEkle.Name = "txtGörevTanımıEkle";
            this.txtGörevTanımıEkle.Size = new System.Drawing.Size(243, 20);
            this.txtGörevTanımıEkle.TabIndex = 0;
            this.txtGörevTanımıEkle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGörevTanımıEkle_KeyDown);
            // 
            // personelDataSet10
            // 
            this.personelDataSet10.DataSetName = "PersonelDataSet10";
            this.personelDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbgörevBindingSource
            // 
            this.cmbgörevBindingSource.DataMember = "cmb_görev";
            this.cmbgörevBindingSource.DataSource = this.personelDataSet10;
            // 
            // cmb_görevTableAdapter
            // 
            this.cmb_görevTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_görevTableAdapter1
            // 
            this.cmb_görevTableAdapter1.ClearBeforeFill = true;
            // 
            // cmb_görevTableAdapter2
            // 
            this.cmb_görevTableAdapter2.ClearBeforeFill = true;
            // 
            // cmbbirimBindingSource
            // 
            this.cmbbirimBindingSource.DataMember = "cmb_birim";
            this.cmbbirimBindingSource.DataSource = this.personelDataSet1cmbHepsiBindingSource;
            // 
            // cmb_birimTableAdapter
            // 
            this.cmb_birimTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_görevTableAdapter3
            // 
            this.cmb_görevTableAdapter3.ClearBeforeFill = true;
            // 
            // GörevTanım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GörevTanım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Tanımlama";
            this.Load += new System.EventHandler(this.GörevTanım_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GörevTanım_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgörevBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1cmbHepsiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1cmbHepsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgörevBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgörevBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgörevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbirimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBirimAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGörevTanımıSilGizli;
        private System.Windows.Forms.Button btnGörevTanımıSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBirim_seç;
        private System.Windows.Forms.Button btnEkleBelgeDurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGörevTanımıEkle;
        private PersonelDataSet10 personelDataSet10;
        private System.Windows.Forms.BindingSource cmbgörevBindingSource;
        private PersonelDataSet10TableAdapters.cmb_görevTableAdapter cmb_görevTableAdapter;
        private PersonelDataSet11 personelDataSet11;
        private System.Windows.Forms.BindingSource cmbgörevBindingSource1;
        private PersonelDataSet11TableAdapters.cmb_görevTableAdapter cmb_görevTableAdapter1;
        private PersonelDataSet12 personelDataSet12;
        private System.Windows.Forms.BindingSource cmbgörevBindingSource2;
        private PersonelDataSet12TableAdapters.cmb_görevTableAdapter cmb_görevTableAdapter2;
        private System.Windows.Forms.BindingSource personelDataSet1cmbHepsiBindingSource;
        private PersonelDataSet1cmbHepsi personelDataSet1cmbHepsi;
        private System.Windows.Forms.BindingSource cmbbirimBindingSource;
        private PersonelDataSet1cmbHepsiTableAdapters.cmb_birimTableAdapter cmb_birimTableAdapter;
        private System.Windows.Forms.BindingSource cmbgörevBindingSource3;
        private PersonelDataSet1cmbHepsiTableAdapters.cmb_görevTableAdapter cmb_görevTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn göreviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
    }
}