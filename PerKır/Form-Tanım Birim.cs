using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PerKır
{
    public partial class frmBirimTanım : Form
    {
        public frmBirimTanım()
        {
            InitializeComponent();
        }

        private void BirimTanım_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSet8.cmb_birim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmb_birimTableAdapter.Fill(this.personelDataSet8.cmb_birim);

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM cmb_Bölüm";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBölüm_seç.Items.Add(dr["Bölüm"]);
                cmbBölüm_seç.Text = "Bölüm Seç";
            }
            baglantı.Close();

        }

        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");

        private void cmblarıgüncelle()
        {
            frmDüzenle Fr4 = (frmDüzenle)Application.OpenForms["frmDüzenle"]; // Güncelle formundaki combobaxlar **
            Fr4.cmbTekrargüncelle();
        }


        private void btnSilKısım_Click(object sender, EventArgs e)
        {
            if (lblBirimSilGizli.Text == "seçimyok")
            {
                MessageBox.Show("Herhangi bir alan seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz alanı seçip tekrar deneyiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("SİLİNECEK BİRİM: " + lblBirimSilGizli.Text + "" + Environment.NewLine + "" + Environment.NewLine + "Onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from cmb_kısım Where kısım=@kısım";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@kısım", lblBirimSilGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    this.cmb_birimTableAdapter.Fill(this.personelDataSet8.cmb_birim); // taabloyu yenile
                    cmblarıgüncelle();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string kısım = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            lblBirimSilGizli.Text = kısım;
        }

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_kısım where kısım like '%" + txtara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();

        }

        private void btnEkleBölüm_Click(object sender, EventArgs e)//birim
        {
            if (cmbBölüm_seç.Text != "Bölüm Seç")
            {
                baglantı.Open();
                string sorgu = "Insert into cmb_birim (birim,bölüm) values (@birim,@bölüm)";
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@birim", txtBirimEkle.Text);
                komut.Parameters.AddWithValue("@bölüm", cmbBölüm_seç.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();

                // TODO: Bu kod satırı 'personelDataSet7.cmb_bölüm' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.cmb_birimTableAdapter.Fill(this.personelDataSet8.cmb_birim); // ** bunları bir private açıp tek saferde yapabilirsin

                MessageBox.Show("BÖLÜM: " + cmbBölüm_seç.Text + "" + Environment.NewLine + " " + Environment.NewLine + "BİRİM: " + txtBirimEkle.Text + "", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtBirimEkle.Clear();
                cmblarıgüncelle();
            }
            else
            {
                MessageBox.Show("Lütfen Birimin ekleneceği Bölüm kısmını seçin!", "BÖLÜM SEÇİMİ YAPILMADI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSilBirim_Click(object sender, EventArgs e)
        {

            if (lblBirimSilGizli.Text == "seçimyok")
            {
                MessageBox.Show("Herhangi bir alan seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz alanı seçip tekrar deneyiniz", "SEÇİM YAPILMADI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("SİLİNECEK BİRİM: " + lblBirimSilGizli.Text + "" + Environment.NewLine + "" + Environment.NewLine + "Onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from cmb_birim Where birim=@birim";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@birim", lblBirimSilGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    this.cmb_birimTableAdapter.Fill(this.personelDataSet8.cmb_birim); // taabloyu yenile
                }
            }
            cmblarıgüncelle();
        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string kısım = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            lblBirimSilGizli.Text = kısım;
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_birim where birim like '%" + txtara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
        }
    }
}
   