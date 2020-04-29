namespace PerKır
{
    partial class frmTanımMYK
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
            this.lblBirimSilGizli = new System.Windows.Forms.Label();
            this.btnSilBirim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirimEkle = new System.Windows.Forms.TextBox();
            this.btnEkleBirim = new System.Windows.Forms.Button();
            this.personelDataSet_Hepsi = new PerKır.PersonelDataSet_Hepsi();
            this.personelDataSetHepsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet_Hepsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetHepsiBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.personelDataSetHepsiBindingSource;
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
            // 
            // lblBirimSilGizli
            // 
            this.lblBirimSilGizli.AutoSize = true;
            this.lblBirimSilGizli.Location = new System.Drawing.Point(44, 15);
            this.lblBirimSilGizli.Name = "lblBirimSilGizli";
            this.lblBirimSilGizli.Size = new System.Drawing.Size(51, 13);
            this.lblBirimSilGizli.TabIndex = 3;
            this.lblBirimSilGizli.Text = "seçimyok";
            this.lblBirimSilGizli.Visible = false;
            // 
            // btnSilBirim
            // 
            this.btnSilBirim.BackColor = System.Drawing.Color.White;
            this.btnSilBirim.Location = new System.Drawing.Point(210, 30);
            this.btnSilBirim.Name = "btnSilBirim";
            this.btnSilBirim.Size = new System.Drawing.Size(49, 21);
            this.btnSilBirim.TabIndex = 2;
            this.btnSilBirim.Text = "Sil";
            this.btnSilBirim.UseVisualStyleBackColor = false;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkleBirim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBirimEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
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
            // txtBirimEkle
            // 
            this.txtBirimEkle.Location = new System.Drawing.Point(47, 28);
            this.txtBirimEkle.Name = "txtBirimEkle";
            this.txtBirimEkle.Size = new System.Drawing.Size(157, 20);
            this.txtBirimEkle.TabIndex = 0;
            // 
            // btnEkleBirim
            // 
            this.btnEkleBirim.BackColor = System.Drawing.Color.White;
            this.btnEkleBirim.Location = new System.Drawing.Point(210, 27);
            this.btnEkleBirim.Name = "btnEkleBirim";
            this.btnEkleBirim.Size = new System.Drawing.Size(49, 21);
            this.btnEkleBirim.TabIndex = 2;
            this.btnEkleBirim.Text = "Ekle";
            this.btnEkleBirim.UseVisualStyleBackColor = false;
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
            // frmTanımMYK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTanımMYK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Tanım_MYK";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet_Hepsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetHepsiBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirimEkle;
        private System.Windows.Forms.BindingSource personelDataSetHepsiBindingSource;
        private PersonelDataSet_Hepsi personelDataSet_Hepsi;
        private System.Windows.Forms.Button btnEkleBirim;
    }
}