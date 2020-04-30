namespace PerKır
{
    partial class frmTanımBelgeDurumu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBelgeAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBelgeDurumuGizli = new System.Windows.Forms.Label();
            this.btnSilBelgeDurumu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSeçBelgeDurumu = new System.Windows.Forms.ComboBox();
            this.btnEkleGörevTanımı = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEkleBelgeDurumu = new System.Windows.Forms.TextBox();
            this.cmb_tabloset = new PerKır.cmb_tabloset();
            this.cmbbelgedurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_belge_durumTableAdapter = new PerKır.cmb_tablosetTableAdapters.cmb_belge_durumTableAdapter();
            this.belgedurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tabloset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbelgedurumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBelgeAra);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblBelgeDurumuGizli);
            this.groupBox2.Controls.Add(this.btnSilBelgeDurumu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtara);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 296);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // txtBelgeAra
            // 
            this.txtBelgeAra.Location = new System.Drawing.Point(327, 57);
            this.txtBelgeAra.Name = "txtBelgeAra";
            this.txtBelgeAra.Size = new System.Drawing.Size(115, 20);
            this.txtBelgeAra.TabIndex = 5;
            this.txtBelgeAra.TextChanged += new System.EventHandler(this.txtBelgeAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.belgedurumDataGridViewTextBoxColumn,
            this.belgeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cmbbelgedurumBindingSource;
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
            // lblBelgeDurumuGizli
            // 
            this.lblBelgeDurumuGizli.AutoSize = true;
            this.lblBelgeDurumuGizli.Location = new System.Drawing.Point(18, 272);
            this.lblBelgeDurumuGizli.Name = "lblBelgeDurumuGizli";
            this.lblBelgeDurumuGizli.Size = new System.Drawing.Size(51, 13);
            this.lblBelgeDurumuGizli.TabIndex = 3;
            this.lblBelgeDurumuGizli.Text = "seçimyok";
            // 
            // btnSilBelgeDurumu
            // 
            this.btnSilBelgeDurumu.BackColor = System.Drawing.Color.White;
            this.btnSilBelgeDurumu.Location = new System.Drawing.Point(393, 30);
            this.btnSilBelgeDurumu.Name = "btnSilBelgeDurumu";
            this.btnSilBelgeDurumu.Size = new System.Drawing.Size(49, 21);
            this.btnSilBelgeDurumu.TabIndex = 2;
            this.btnSilBelgeDurumu.Text = "Sil";
            this.btnSilBelgeDurumu.UseVisualStyleBackColor = false;
            this.btnSilBelgeDurumu.Click += new System.EventHandler(this.btnSilBelgeDurumu_Click);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSeçBelgeDurumu);
            this.groupBox1.Controls.Add(this.btnEkleGörevTanımı);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEkleBelgeDurumu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 94);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // cmbSeçBelgeDurumu
            // 
            this.cmbSeçBelgeDurumu.FormattingEnabled = true;
            this.cmbSeçBelgeDurumu.Location = new System.Drawing.Point(21, 29);
            this.cmbSeçBelgeDurumu.Name = "cmbSeçBelgeDurumu";
            this.cmbSeçBelgeDurumu.Size = new System.Drawing.Size(108, 21);
            this.cmbSeçBelgeDurumu.TabIndex = 3;
            // 
            // btnEkleGörevTanımı
            // 
            this.btnEkleGörevTanımı.BackColor = System.Drawing.Color.White;
            this.btnEkleGörevTanımı.Location = new System.Drawing.Point(393, 55);
            this.btnEkleGörevTanımı.Name = "btnEkleGörevTanımı";
            this.btnEkleGörevTanımı.Size = new System.Drawing.Size(49, 20);
            this.btnEkleGörevTanımı.TabIndex = 2;
            this.btnEkleGörevTanımı.Text = "Ekle";
            this.btnEkleGörevTanımı.UseVisualStyleBackColor = false;
            this.btnEkleGörevTanımı.Click += new System.EventHandler(this.btnEkleGörevTanımı_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Belge";
            // 
            // txtEkleBelgeDurumu
            // 
            this.txtEkleBelgeDurumu.Location = new System.Drawing.Point(199, 29);
            this.txtEkleBelgeDurumu.Name = "txtEkleBelgeDurumu";
            this.txtEkleBelgeDurumu.Size = new System.Drawing.Size(243, 20);
            this.txtEkleBelgeDurumu.TabIndex = 0;
            // 
            // cmb_tabloset
            // 
            this.cmb_tabloset.DataSetName = "cmb_tabloset";
            this.cmb_tabloset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbbelgedurumBindingSource
            // 
            this.cmbbelgedurumBindingSource.DataMember = "cmb_belge_durum";
            this.cmbbelgedurumBindingSource.DataSource = this.cmb_tabloset;
            // 
            // cmb_belge_durumTableAdapter
            // 
            this.cmb_belge_durumTableAdapter.ClearBeforeFill = true;
            // 
            // belgedurumDataGridViewTextBoxColumn
            // 
            this.belgedurumDataGridViewTextBoxColumn.DataPropertyName = "belge_durum";
            this.belgedurumDataGridViewTextBoxColumn.HeaderText = "Belgenin Durumu";
            this.belgedurumDataGridViewTextBoxColumn.Name = "belgedurumDataGridViewTextBoxColumn";
            this.belgedurumDataGridViewTextBoxColumn.ReadOnly = true;
            this.belgedurumDataGridViewTextBoxColumn.Width = 275;
            // 
            // belgeDataGridViewTextBoxColumn
            // 
            this.belgeDataGridViewTextBoxColumn.DataPropertyName = "belge";
            this.belgeDataGridViewTextBoxColumn.HeaderText = "Belge";
            this.belgeDataGridViewTextBoxColumn.Name = "belgeDataGridViewTextBoxColumn";
            this.belgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmTanımBelgeDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTanımBelgeDurumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belge Durumu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tabloset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbelgedurumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBelgeAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBelgeDurumuGizli;
        private System.Windows.Forms.Button btnSilBelgeDurumu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSeçBelgeDurumu;
        private System.Windows.Forms.Button btnEkleGörevTanımı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEkleBelgeDurumu;
        private cmb_tabloset cmb_tabloset;
        private System.Windows.Forms.BindingSource cmbbelgedurumBindingSource;
        private cmb_tablosetTableAdapters.cmb_belge_durumTableAdapter cmb_belge_durumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgedurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeDataGridViewTextBoxColumn;
    }
}