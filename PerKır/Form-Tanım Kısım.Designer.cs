namespace PerKır
{
    partial class frmKısımTanımları
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkleKısım = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKısımEkle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kısımDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbkısımBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet5 = new PerKır.PersonelDataSet5();
            this.lblKısımSilGizli = new System.Windows.Forms.Label();
            this.btnSilKısım = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.personelDataSet4 = new PerKır.PersonelDataSet4();
            this.cmbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTableAdapter = new PerKır.PersonelDataSet4TableAdapters.cmbTableAdapter();
            this.personelDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet_Hepsi = new PerKır.PersonelDataSet_Hepsi();
            this.personelDataSetHepsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_kısımTableAdapter = new PerKır.PersonelDataSet5TableAdapters.cmb_kısımTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbkısımBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet_Hepsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetHepsiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkleKısım);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKısımEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // btnEkleKısım
            // 
            this.btnEkleKısım.Location = new System.Drawing.Point(157, 45);
            this.btnEkleKısım.Name = "btnEkleKısım";
            this.btnEkleKısım.Size = new System.Drawing.Size(49, 20);
            this.btnEkleKısım.TabIndex = 2;
            this.btnEkleKısım.Text = "Ekle";
            this.btnEkleKısım.UseVisualStyleBackColor = true;
            this.btnEkleKısım.Click += new System.EventHandler(this.btnEkleKısım_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kısım";
            // 
            // txtKısımEkle
            // 
            this.txtKısımEkle.Location = new System.Drawing.Point(49, 19);
            this.txtKısımEkle.Name = "txtKısımEkle";
            this.txtKısımEkle.Size = new System.Drawing.Size(157, 20);
            this.txtKısımEkle.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblKısımSilGizli);
            this.groupBox2.Controls.Add(this.btnSilKısım);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtara);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 277);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kısımDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cmbkısımBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(33, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(148, 184);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // kısımDataGridViewTextBoxColumn
            // 
            this.kısımDataGridViewTextBoxColumn.DataPropertyName = "kısım";
            this.kısımDataGridViewTextBoxColumn.HeaderText = "kısım";
            this.kısımDataGridViewTextBoxColumn.Name = "kısımDataGridViewTextBoxColumn";
            // 
            // cmbkısımBindingSource
            // 
            this.cmbkısımBindingSource.DataMember = "cmb_kısım";
            this.cmbkısımBindingSource.DataSource = this.personelDataSet5;
            // 
            // personelDataSet5
            // 
            this.personelDataSet5.DataSetName = "PersonelDataSet5";
            this.personelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblKısımSilGizli
            // 
            this.lblKısımSilGizli.AutoSize = true;
            this.lblKısımSilGizli.Location = new System.Drawing.Point(30, 251);
            this.lblKısımSilGizli.Name = "lblKısımSilGizli";
            this.lblKısımSilGizli.Size = new System.Drawing.Size(51, 13);
            this.lblKısımSilGizli.TabIndex = 3;
            this.lblKısımSilGizli.Text = "seçimyok";
            this.lblKısımSilGizli.Visible = false;
            // 
            // btnSilKısım
            // 
            this.btnSilKısım.Location = new System.Drawing.Point(132, 247);
            this.btnSilKısım.Name = "btnSilKısım";
            this.btnSilKısım.Size = new System.Drawing.Size(49, 20);
            this.btnSilKısım.TabIndex = 2;
            this.btnSilKısım.Text = "Sil";
            this.btnSilKısım.UseVisualStyleBackColor = true;
            this.btnSilKısım.Click += new System.EventHandler(this.btnSilKısım_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(59, 30);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(122, 20);
            this.txtara.TabIndex = 0;
            this.txtara.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // personelDataSet4
            // 
            this.personelDataSet4.DataSetName = "PersonelDataSet4";
            this.personelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBindingSource
            // 
            this.cmbBindingSource.DataMember = "cmb";
            this.cmbBindingSource.DataSource = this.personelDataSet4;
            // 
            // cmbTableAdapter
            // 
            this.cmbTableAdapter.ClearBeforeFill = true;
            // 
            // personelDataSet4BindingSource
            // 
            this.personelDataSet4BindingSource.DataSource = this.personelDataSet4;
            this.personelDataSet4BindingSource.Position = 0;
            // 
            // cmbBindingSource1
            // 
            this.cmbBindingSource1.DataMember = "cmb";
            this.cmbBindingSource1.DataSource = this.personelDataSet4BindingSource;
            // 
            // personelDataSet_Hepsi
            // 
            this.personelDataSet_Hepsi.DataSetName = "PersonelDataSet_Hepsi";
            this.personelDataSet_Hepsi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDataSetHepsiBindingSource
            // 
            this.personelDataSetHepsiBindingSource.DataSource = this.personelDataSet_Hepsi;
            this.personelDataSetHepsiBindingSource.Position = 0;
            // 
            // cmb_kısımTableAdapter
            // 
            this.cmb_kısımTableAdapter.ClearBeforeFill = true;
            // 
            // frmKısımTanımları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(245, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKısımTanımları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kısım Tanımları";
            this.Load += new System.EventHandler(this.frmKısımTanımları_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbkısımBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet_Hepsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetHepsiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKısımEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtara;
        private PersonelDataSet4 personelDataSet4;
        private System.Windows.Forms.BindingSource cmbBindingSource;
        private PersonelDataSet4TableAdapters.cmbTableAdapter cmbTableAdapter;
        private System.Windows.Forms.Button btnEkleKısım;
        private System.Windows.Forms.Button btnSilKısım;
        private System.Windows.Forms.Label lblKısımSilGizli;
        private System.Windows.Forms.BindingSource personelDataSet4BindingSource;
        private System.Windows.Forms.BindingSource cmbBindingSource1;
        private System.Windows.Forms.BindingSource personelDataSetHepsiBindingSource;
        private PersonelDataSet_Hepsi personelDataSet_Hepsi;
        private PersonelDataSet5 personelDataSet5;
        private System.Windows.Forms.BindingSource cmbkısımBindingSource;
        private PersonelDataSet5TableAdapters.cmb_kısımTableAdapter cmb_kısımTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kısımDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}