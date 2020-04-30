namespace PerKır
{
    partial class frmTanımBelge
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
            this.personelDataSetHepsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet_Hepsi = new PerKır.PersonelDataSet_Hepsi();
            this.lblSilBelgeGizli = new System.Windows.Forms.Label();
            this.btnSilBelge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkleBelge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEkleBelge = new System.Windows.Forms.TextBox();
            this.cmb_tabloset = new PerKır.cmb_tabloset();
            this.cmbtablosetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbbelgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_belgeTableAdapter = new PerKır.cmb_tablosetTableAdapters.cmb_belgeTableAdapter();
            this.belgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetHepsiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet_Hepsi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tabloset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtablosetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbelgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblSilBelgeGizli);
            this.groupBox2.Controls.Add(this.btnSilBelge);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtara);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 271);
            this.groupBox2.TabIndex = 5;
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
            this.belgeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cmbbelgeBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(13, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(246, 189);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelDataSetHepsiBindingSource
            // 
            this.personelDataSetHepsiBindingSource.DataSource = this.personelDataSet_Hepsi;
            this.personelDataSetHepsiBindingSource.Position = 0;
            // 
            // personelDataSet_Hepsi
            // 
            this.personelDataSet_Hepsi.DataSetName = "PersonelDataSet_Hepsi";
            this.personelDataSet_Hepsi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSilBelgeGizli
            // 
            this.lblSilBelgeGizli.AutoSize = true;
            this.lblSilBelgeGizli.Location = new System.Drawing.Point(44, 15);
            this.lblSilBelgeGizli.Name = "lblSilBelgeGizli";
            this.lblSilBelgeGizli.Size = new System.Drawing.Size(51, 13);
            this.lblSilBelgeGizli.TabIndex = 3;
            this.lblSilBelgeGizli.Text = "seçimyok";
            this.lblSilBelgeGizli.Visible = false;
            // 
            // btnSilBelge
            // 
            this.btnSilBelge.BackColor = System.Drawing.Color.White;
            this.btnSilBelge.Location = new System.Drawing.Point(210, 30);
            this.btnSilBelge.Name = "btnSilBelge";
            this.btnSilBelge.Size = new System.Drawing.Size(49, 21);
            this.btnSilBelge.TabIndex = 2;
            this.btnSilBelge.Text = "Sil";
            this.btnSilBelge.UseVisualStyleBackColor = false;
            this.btnSilBelge.Click += new System.EventHandler(this.btnSilBelge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(47, 31);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(157, 20);
            this.txtara.TabIndex = 0;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkleBelge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEkleBelge);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // btnEkleBelge
            // 
            this.btnEkleBelge.BackColor = System.Drawing.Color.White;
            this.btnEkleBelge.Location = new System.Drawing.Point(210, 27);
            this.btnEkleBelge.Name = "btnEkleBelge";
            this.btnEkleBelge.Size = new System.Drawing.Size(49, 21);
            this.btnEkleBelge.TabIndex = 2;
            this.btnEkleBelge.Text = "Ekle";
            this.btnEkleBelge.UseVisualStyleBackColor = false;
            this.btnEkleBelge.Click += new System.EventHandler(this.btnEkleBelge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Belge";
            // 
            // txtEkleBelge
            // 
            this.txtEkleBelge.Location = new System.Drawing.Point(47, 28);
            this.txtEkleBelge.Name = "txtEkleBelge";
            this.txtEkleBelge.Size = new System.Drawing.Size(157, 20);
            this.txtEkleBelge.TabIndex = 0;
            // 
            // cmb_tabloset
            // 
            this.cmb_tabloset.DataSetName = "cmb_tabloset";
            this.cmb_tabloset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbtablosetBindingSource
            // 
            this.cmbtablosetBindingSource.DataSource = this.cmb_tabloset;
            this.cmbtablosetBindingSource.Position = 0;
            // 
            // cmbbelgeBindingSource
            // 
            this.cmbbelgeBindingSource.DataMember = "cmb_belge";
            this.cmbbelgeBindingSource.DataSource = this.cmbtablosetBindingSource;
            // 
            // cmb_belgeTableAdapter
            // 
            this.cmb_belgeTableAdapter.ClearBeforeFill = true;
            // 
            // belgeDataGridViewTextBoxColumn
            // 
            this.belgeDataGridViewTextBoxColumn.DataPropertyName = "belge";
            this.belgeDataGridViewTextBoxColumn.HeaderText = "Belge Durumu";
            this.belgeDataGridViewTextBoxColumn.Name = "belgeDataGridViewTextBoxColumn";
            this.belgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.belgeDataGridViewTextBoxColumn.Width = 225;
            // 
            // frmTanımBelge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTanımBelge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesleki Yeterlilik Tanımlama";
            this.Load += new System.EventHandler(this.frmTanımBelge_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetHepsiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet_Hepsi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tabloset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtablosetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbelgeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSilBelgeGizli;
        private System.Windows.Forms.Button btnSilBelge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEkleBelge;
        private System.Windows.Forms.BindingSource personelDataSetHepsiBindingSource;
        private PersonelDataSet_Hepsi personelDataSet_Hepsi;
        private System.Windows.Forms.Button btnEkleBelge;
        private System.Windows.Forms.BindingSource cmbtablosetBindingSource;
        private cmb_tabloset cmb_tabloset;
        private System.Windows.Forms.BindingSource cmbbelgeBindingSource;
        private cmb_tablosetTableAdapters.cmb_belgeTableAdapter cmb_belgeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeDataGridViewTextBoxColumn;
    }
}