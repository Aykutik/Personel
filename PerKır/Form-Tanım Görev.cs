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
    public partial class GörevTanım : Form
    {
        public GörevTanım()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");
        private void cmblarıgüncelle() // Güncelle formundaki combobaxları güncelle
        {
            frmDüzenle frmDüzenle = (frmDüzenle)Application.OpenForms["frmDüzenle"]; 
            frmDüzenle.cmbTekrargüncelle();
        }

        private void DataGridiyenile() // Data gridi güncelle döngüsü
        {
            // TODO: Bu kod satırı 'personelDataSet1cmbHepsi.cmb_görev' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmb_görevTableAdapter3.Fill(this.personelDataSet1cmbHepsi.cmb_görev);
        }

        private void GörevTanım_Load(object sender, EventArgs e)
        {            
            DataGridiyenile();
            //
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM cmb_birim";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBirim_seç.Items.Add(dr["Birim"]);
                cmbBirim_seç.Text = "Birim Seç";
            }
            baglantı.Close();
        }

        private void kaydet()
        {
            if (cmbBirim_seç.Text != "Birim Seç")
            {
                baglantı.Open();
                string sorgu = "Insert into cmb_görev (görevi,birim) values (@görevi,@birim)";
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@görevi", txtGörevTanımıEkle.Text);
                komut.Parameters.AddWithValue("@birim", cmbBirim_seç.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                //
                cmblarıgüncelle();
                DataGridiyenile();
                //
                MessageBox.Show("BİRİM: " + cmbBirim_seç.Text + "" + Environment.NewLine +" "+Environment.NewLine +"GÖREV: " + txtGörevTanımıEkle.Text + "", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGörevTanımıEkle.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen görevin ekleneceği Birim kısmını seçin!", "BİRİM SEÇİMİ YAPILMADI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEkleBirimAmiri_Click(object sender, EventArgs e) // Ekle Görev Tanımı Butonu
        {
            kaydet();
        }

        private void btnGörevTanımıSil_Click(object sender, EventArgs e)
        {
            if (lblGörevTanımıSilGizli.Text == "seçimyok")
            {
                MessageBox.Show("Herhangi bir alan seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz alanı seçip tekrar deneyiniz", "SEÇİM YAPILMADI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("SİLİNECEK GÖREV: " + lblGörevTanımıSilGizli.Text + "" + Environment.NewLine + "" + Environment.NewLine + "Onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from cmb_görev Where görevi=@parametre";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@parametre", lblGörevTanımıSilGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    DataGridiyenile();
                    cmblarıgüncelle();
                }
            }            
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            txtBirimAra.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_görev where görevi like '%" + txtara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
        } //yazmaya başladığında isme göre ara

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtara.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_görev where birim like '%" + txtBirimAra.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
        } //yazmaya başladığında Birime göre ara

        private void txtGörevTanımıEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {

                kaydet();

            }

            if (e.KeyCode == Keys.Escape)

            {

                this.Close();

            }

        }

        private void GörevTanım_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {

                this.Close();

            }
        }

        private void txtara_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)

            {

                this.Close();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string kısım = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            lblGörevTanımıSilGizli.Text = kısım;
        } //Data gidden veri seçme
    }
}
