namespace PerKır
{
    partial class frmBölümKısımları
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
            this.bölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kısımDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbbölümBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet7 = new PerKır.PersonelDataSet7();
            this.lblBölümSilGizli = new System.Windows.Forms.Label();
            this.btnSilBölüm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.cmbbölümBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet6 = new PerKır.PersonelDataSet6();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKısım_seç = new System.Windows.Forms.ComboBox();
            this.btnEkleKısım = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKısımEkle = new System.Windows.Forms.TextBox();
            this.cmb_bölümTableAdapter = new PerKır.PersonelDataSet6TableAdapters.cmb_bölümTableAdapter();
            this.personelDataSet5 = new PerKır.PersonelDataSet5();
            this.personelDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbkısımBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_kısımTableAdapter = new PerKır.PersonelDataSet5TableAdapters.cmb_kısımTableAdapter();
            this.personelDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_bölümTableAdapter1 = new PerKır.PersonelDataSet7TableAdapters.cmb_bölümTableAdapter();
            this.personelDataSet13 = new PerKır.PersonelDataSet13();
            this.cmbbölümBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_bölümTableAdapter2 = new PerKır.PersonelDataSet13TableAdapters.cmb_bölümTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbölümBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbölümBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbkısımBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbölümBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblBölümSilGizli);
            this.groupBox2.Controls.Add(this.btnSilBölüm);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtara);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bölümDataGridViewTextBoxColumn,
            this.kısımDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cmbbölümBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(56, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(232, 184);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            this.bölümDataGridViewTextBoxColumn.DataPropertyName = "bölüm";
            this.bölümDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            this.bölümDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kısımDataGridViewTextBoxColumn
            // 
            this.kısımDataGridViewTextBoxColumn.DataPropertyName = "kısım";
            this.kısımDataGridViewTextBoxColumn.HeaderText = "Bağlı Kısım";
            this.kısımDataGridViewTextBoxColumn.Name = "kısımDataGridViewTextBoxColumn";
            this.kısımDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmbbölümBindingSource1
            // 
            this.cmbbölümBindingSource1.DataMember = "cmb_bölüm";
            this.cmbbölümBindingSource1.DataSource = this.personelDataSet7;
            // 
            // personelDataSet7
            // 
            this.personelDataSet7.DataSetName = "PersonelDataSet7";
            this.personelDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBölümSilGizli
            // 
            this.lblBölümSilGizli.AutoSize = true;
            this.lblBölümSilGizli.Location = new System.Drawing.Point(53, 243);
            this.lblBölümSilGizli.Name = "lblBölümSilGizli";
            this.lblBölümSilGizli.Size = new System.Drawing.Size(51, 13);
            this.lblBölümSilGizli.TabIndex = 3;
            this.lblBölümSilGizli.Text = "seçimyok";
            this.lblBölümSilGizli.Visible = false;
            // 
            // btnSilBölüm
            // 
            this.btnSilBölüm.Location = new System.Drawing.Point(253, 21);
            this.btnSilBölüm.Name = "btnSilBölüm";
            this.btnSilBölüm.Size = new System.Drawing.Size(35, 20);
            this.btnSilBölüm.TabIndex = 2;
            this.btnSilBölüm.Text = "Sil";
            this.btnSilBölüm.UseVisualStyleBackColor = true;
            this.btnSilBölüm.Click += new System.EventHandler(this.btnSilKısım_Click_1);
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
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged_1);
            // 
            // cmbbölümBindingSource
            // 
            this.cmbbölümBindingSource.DataMember = "cmb_bölüm";
            this.cmbbölümBindingSource.DataSource = this.personelDataSet6;
            // 
            // personelDataSet6
            // 
            this.personelDataSet6.DataSetName = "PersonelDataSet6";
            this.personelDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKısım_seç);
            this.groupBox1.Controls.Add(this.btnEkleKısım);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKısımEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // cmbKısım_seç
            // 
            this.cmbKısım_seç.FormattingEnabled = true;
            this.cmbKısım_seç.Location = new System.Drawing.Point(224, 18);
            this.cmbKısım_seç.Name = "cmbKısım_seç";
            this.cmbKısım_seç.Size = new System.Drawing.Size(108, 21);
            this.cmbKısım_seç.TabIndex = 3;
            // 
            // btnEkleKısım
            // 
            this.btnEkleKısım.Location = new System.Drawing.Point(283, 49);
            this.btnEkleKısım.Name = "btnEkleKısım";
            this.btnEkleKısım.Size = new System.Drawing.Size(49, 20);
            this.btnEkleKısım.TabIndex = 2;
            this.btnEkleKısım.Text = "Ekle";
            this.btnEkleKısım.UseVisualStyleBackColor = true;
            this.btnEkleKısım.Click += new System.EventHandler(this.btnEkleKısım_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm";
            // 
            // txtKısımEkle
            // 
            this.txtKısımEkle.Location = new System.Drawing.Point(47, 19);
            this.txtKısımEkle.Name = "txtKısımEkle";
            this.txtKısımEkle.Size = new System.Drawing.Size(157, 20);
            this.txtKısımEkle.TabIndex = 0;
            // 
            // cmb_bölümTableAdapter
            // 
            this.cmb_bölümTableAdapter.ClearBeforeFill = true;
            // 
            // personelDataSet5
            // 
            this.personelDataSet5.DataSetName = "PersonelDataSet5";
            this.personelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDataSet5BindingSource
            // 
            this.personelDataSet5BindingSource.DataSource = this.personelDataSet5;
            this.personelDataSet5BindingSource.Position = 0;
            // 
            // cmbkısımBindingSource
            // 
            this.cmbkısımBindingSource.DataMember = "cmb_kısım";
            this.cmbkısımBindingSource.DataSource = this.personelDataSet5BindingSource;
            // 
            // cmb_kısımTableAdapter
            // 
            this.cmb_kısımTableAdapter.ClearBeforeFill = true;
            // 
            // personelDataSet6BindingSource
            // 
            this.personelDataSet6BindingSource.DataSource = this.personelDataSet6;
            this.personelDataSet6BindingSource.Position = 0;
            // 
            // cmb_bölümTableAdapter1
            // 
            this.cmb_bölümTableAdapter1.ClearBeforeFill = true;
            // 
            // personelDataSet13
            // 
            this.personelDataSet13.DataSetName = "PersonelDataSet13";
            this.personelDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbbölümBindingSource2
            // 
            this.cmbbölümBindingSource2.DataMember = "cmb_bölüm";
            this.cmbbölümBindingSource2.DataSource = this.personelDataSet13;
            // 
            // cmb_bölümTableAdapter2
            // 
            this.cmb_bölümTableAdapter2.ClearBeforeFill = true;
            // 
            // frmBölümKısımları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBölümKısımları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölüm Kısımlarını Tanımla";
            this.Load += new System.EventHandler(this.frmBölümKısımları_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbölümBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbölümBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbkısımBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbölümBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBölümSilGizli;
        private System.Windows.Forms.Button btnSilBölüm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbKısım_seç;
        private System.Windows.Forms.Button btnEkleKısım;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKısımEkle;
        private PersonelDataSet6 personelDataSet6;
        private System.Windows.Forms.BindingSource cmbbölümBindingSource;
        private PersonelDataSet6TableAdapters.cmb_bölümTableAdapter cmb_bölümTableAdapter;
        private System.Windows.Forms.BindingSource personelDataSet5BindingSource;
        private PersonelDataSet5 personelDataSet5;
        private System.Windows.Forms.BindingSource cmbkısımBindingSource;
        private PersonelDataSet5TableAdapters.cmb_kısımTableAdapter cmb_kısımTableAdapter;
        private System.Windows.Forms.BindingSource personelDataSet6BindingSource;
        private PersonelDataSet7 personelDataSet7;
        private System.Windows.Forms.BindingSource cmbbölümBindingSource1;
        private PersonelDataSet7TableAdapters.cmb_bölümTableAdapter cmb_bölümTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kısımDataGridViewTextBoxColumn;
        private PersonelDataSet13 personelDataSet13;
        private System.Windows.Forms.BindingSource cmbbölümBindingSource2;
        private PersonelDataSet13TableAdapters.cmb_bölümTableAdapter cmb_bölümTableAdapter2;
    }
}