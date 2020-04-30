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
    public partial class frmTanımBelgeDurumu : Form
    {
        public frmTanımBelgeDurumu()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");

        private void DataGridiyenile() // Data gridi güncelle döngüsü
        {
            // TODO: Bu kod satırı 'cmb_tabloset.cmb_belge_durum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmb_belge_durumTableAdapter.Fill(this.cmb_tabloset.cmb_belge_durum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridiyenile();
            //
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM cmb_belge";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbSeçBelgeDurumu.Items.Add(dr["Belge"]);
                cmbSeçBelgeDurumu.Text = "Belge Seç";
            }
            baglantı.Close();

        }

        private void cmblarıgüncelle() // Güncelle formundaki combobaxları güncelle
        {
            frmDüzenle frmDüzenle = (frmDüzenle)Application.OpenForms["frmDüzenle"];
            frmDüzenle.cmbTekrargüncelleMYK_İSG();
        }

        private void btnEkleGörevTanımı_Click(object sender, EventArgs e)
        {
            if (cmbSeçBelgeDurumu.Text != "Belge Seç")
            {
                baglantı.Open();
                string sorgu = "Insert into cmb_belge_durum (belge_durum,belge) values (@pr1,@pr2)";
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@pr1", txtEkleBelgeDurumu.Text);
                komut.Parameters.AddWithValue("@pr2", cmbSeçBelgeDurumu.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                //
                cmblarıgüncelle();
                DataGridiyenile();
                //
                MessageBox.Show("BELGE: " + cmbSeçBelgeDurumu.Text + "" + Environment.NewLine + " " + Environment.NewLine + "DURUM: " + txtEkleBelgeDurumu.Text + "", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEkleBelgeDurumu.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen durumun ekleneceği Belge kısmını seçin!", "BELGE SEÇİMİ YAPILMADI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            txtBelgeAra.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_belge_durum where belge_durum like '%" + txtara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
        }

        private void txtBelgeAra_TextChanged(object sender, EventArgs e)
        {
            txtara.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_belge_durum where belge like '%" + txtBelgeAra.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string kısım = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            cmbSeçBelgeDurumu.Text = kısım;
        }

        private void btnSilBelgeDurumu_Click(object sender, EventArgs e)
        {
            if (lblBelgeDurumuGizli.Text == "seçimyok")
            {
                MessageBox.Show("Herhangi bir alan seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz alanı seçip tekrar deneyiniz", "SEÇİM YAPILMADI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("SİLİNECEK DURUM: " + lblBelgeDurumuGizli.Text + "" + Environment.NewLine + "" + Environment.NewLine + "Onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from cmb_belge_durum Where belge_durum=@parametre";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@parametre", lblBelgeDurumuGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    DataGridiyenile();
                    cmblarıgüncelle();
                }
            }
        }
    }
}
