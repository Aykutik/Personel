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
    public partial class TanımBirimAmir : Form
    {
        public TanımBirimAmir()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");

        private void cmblarıgüncelle()
        {
            frmDüzenle listele = (frmDüzenle)Application.OpenForms["frmDüzenle"]; // Güncelle formundaki combobaxlar **
            listele.cmbTekrargüncelle();
        }

        private void btnEkleBirimAmiri_Click(object sender, EventArgs e)
        {
            if (cmbBölüm_seç.Text != "Bölüm Seç")
            {
                baglantı.Open();
                string sorgu = "Insert into cmb_br_amir (br_amir,bölüm) values (@br_amir,@bölüm)";
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@br_amir", txtBirimAmiriEkle.Text);
                komut.Parameters.AddWithValue("@bölüm", cmbBölüm_seç.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                // TODO: Bu kod satırı 'personelDataSet9.cmb_br_amir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.cmb_br_amirTableAdapter.Fill(this.personelDataSet9.cmb_br_amir);
                cmblarıgüncelle();
                MessageBox.Show("BÖLÜM: " + cmbBölüm_seç.Text + "" + Environment.NewLine + " " + Environment.NewLine + "BİRİM AMİRİ: " + txtBirimAmiriEkle.Text + "", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBirimAmiriEkle.Clear();

            }
            else
            {
                MessageBox.Show("Lütfen Birim Amirinin ekleneceği Bölüm kısmını seçin!", "BÖLÜM SEÇİMİ YAPILMADI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BirimAmirTanim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSet9.cmb_br_amir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmb_br_amirTableAdapter.Fill(this.personelDataSet9.cmb_br_amir);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string kısım = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            lblBirimAmiriSilGizli.Text = kısım;
        }

        private void btnSilBirimAmiri_Click(object sender, EventArgs e) 
        {
            if (lblBirimAmiriSilGizli.Text == "seçimyok")
            {
                MessageBox.Show("Herhangi bir alan seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz alanı seçip tekrar deneyiniz", "SEÇİM YAPILMADI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("SİLİNECEK BİRİM AMİRİ: " + lblBirimAmiriSilGizli.Text + "" + Environment.NewLine + "" + Environment.NewLine + "Onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from cmb_br_amir Where br_amir=@br_amir";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@br_amir", lblBirimAmiriSilGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    // TODO: Bu kod satırı 'personelDataSet9.cmb_br_amir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                    this.cmb_br_amirTableAdapter.Fill(this.personelDataSet9.cmb_br_amir); // taabloyu yenile
                }
            }
            cmblarıgüncelle();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_br_amir where br_amir like '%" + txtara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_br_amir where bölüm like '%" + textBox1.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
        }
    }
}
