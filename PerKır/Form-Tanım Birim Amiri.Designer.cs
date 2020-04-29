namespace PerKır
{
    partial class TanımBirimAmir
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBirimAmiriSilGizli = new System.Windows.Forms.Label();
            this.btnSilBirimAmiri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBölüm_seç = new System.Windows.Forms.ComboBox();
            this.btnEkleBirimAmiri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirimAmiriEkle = new System.Windows.Forms.TextBox();
            this.personelDataSet8 = new PerKır.PersonelDataSet8();
            this.personelDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet9 = new PerKır.PersonelDataSet9();
            this.cmbbramirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_br_amirTableAdapter = new PerKır.PersonelDataSet9TableAdapters.cmb_br_amirTableAdapter();
            this.bramirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbramirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblBirimAmiriSilGizli);
            this.groupBox2.Controls.Add(this.btnSilBirimAmiri);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtara);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 317);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
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
            this.bramirDataGridViewTextBoxColumn,
            this.bölümDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cmbbramirBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(36, 96);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(290, 184);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblBirimAmiriSilGizli
            // 
            this.lblBirimAmiriSilGizli.AutoSize = true;
            this.lblBirimAmiriSilGizli.Location = new System.Drawing.Point(32, 283);
            this.lblBirimAmiriSilGizli.Name = "lblBirimAmiriSilGizli";
            this.lblBirimAmiriSilGizli.Size = new System.Drawing.Size(51, 13);
            this.lblBirimAmiriSilGizli.TabIndex = 3;
            this.lblBirimAmiriSilGizli.Text = "seçimyok";
            // 
            // btnSilBirimAmiri
            // 
            this.btnSilBirimAmiri.BackColor = System.Drawing.Color.White;
            this.btnSilBirimAmiri.Location = new System.Drawing.Point(291, 41);
            this.btnSilBirimAmiri.Name = "btnSilBirimAmiri";
            this.btnSilBirimAmiri.Size = new System.Drawing.Size(35, 21);
            this.btnSilBirimAmiri.TabIndex = 2;
            this.btnSilBirimAmiri.Text = "Sil";
            this.btnSilBirimAmiri.UseVisualStyleBackColor = false;
            this.btnSilBirimAmiri.Click += new System.EventHandler(this.btnSilBirimAmiri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(36, 70);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(169, 20);
            this.txtara.TabIndex = 0;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBölüm_seç);
            this.groupBox1.Controls.Add(this.btnEkleBirimAmiri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBirimAmiriEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // cmbBölüm_seç
            // 
            this.cmbBölüm_seç.FormattingEnabled = true;
            this.cmbBölüm_seç.Location = new System.Drawing.Point(21, 29);
            this.cmbBölüm_seç.Name = "cmbBölüm_seç";
            this.cmbBölüm_seç.Size = new System.Drawing.Size(108, 21);
            this.cmbBölüm_seç.TabIndex = 3;
            // 
            // btnEkleBirimAmiri
            // 
            this.btnEkleBirimAmiri.BackColor = System.Drawing.Color.White;
            this.btnEkleBirimAmiri.Location = new System.Drawing.Point(298, 55);
            this.btnEkleBirimAmiri.Name = "btnEkleBirimAmiri";
            this.btnEkleBirimAmiri.Size = new System.Drawing.Size(49, 20);
            this.btnEkleBirimAmiri.TabIndex = 2;
            this.btnEkleBirimAmiri.Text = "Ekle";
            this.btnEkleBirimAmiri.UseVisualStyleBackColor = false;
            this.btnEkleBirimAmiri.Click += new System.EventHandler(this.btnEkleBirimAmiri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birim Amiri";
            // 
            // txtBirimAmiriEkle
            // 
            this.txtBirimAmiriEkle.Location = new System.Drawing.Point(199, 29);
            this.txtBirimAmiriEkle.Name = "txtBirimAmiriEkle";
            this.txtBirimAmiriEkle.Size = new System.Drawing.Size(148, 20);
            this.txtBirimAmiriEkle.TabIndex = 0;
            // 
            // personelDataSet8
            // 
            this.personelDataSet8.DataSetName = "PersonelDataSet8";
            this.personelDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDataSet8BindingSource
            // 
            this.personelDataSet8BindingSource.DataSource = this.personelDataSet8;
            this.personelDataSet8BindingSource.Position = 0;
            // 
            // personelDataSet9
            // 
            this.personelDataSet9.DataSetName = "PersonelDataSet9";
            this.personelDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbbramirBindingSource
            // 
            this.cmbbramirBindingSource.DataMember = "cmb_br_amir";
            this.cmbbramirBindingSource.DataSource = this.personelDataSet9;
            // 
            // cmb_br_amirTableAdapter
            // 
            this.cmb_br_amirTableAdapter.ClearBeforeFill = true;
            // 
            // bramirDataGridViewTextBoxColumn
            // 
            this.bramirDataGridViewTextBoxColumn.DataPropertyName = "br_amir";
            this.bramirDataGridViewTextBoxColumn.HeaderText = "Birim Amiri";
            this.bramirDataGridViewTextBoxColumn.Name = "bramirDataGridViewTextBoxColumn";
            this.bramirDataGridViewTextBoxColumn.ReadOnly = true;
            this.bramirDataGridViewTextBoxColumn.Width = 170;
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            this.bölümDataGridViewTextBoxColumn.DataPropertyName = "bölüm";
            this.bölümDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            this.bölümDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BirimAmirTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BirimAmirTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birim Amiri Tanım";
            this.Load += new System.EventHandler(this.BirimAmirTanim_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbramirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBirimAmiriSilGizli;
        private System.Windows.Forms.Button btnSilBirimAmiri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBölüm_seç;
        private System.Windows.Forms.Button btnEkleBirimAmiri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirimAmiriEkle;
        private System.Windows.Forms.BindingSource personelDataSet8BindingSource;
        private PersonelDataSet8 personelDataSet8;
        private PersonelDataSet9 personelDataSet9;
        private System.Windows.Forms.BindingSource cmbbramirBindingSource;
        private PersonelDataSet9TableAdapters.cmb_br_amirTableAdapter cmb_br_amirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bramirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}