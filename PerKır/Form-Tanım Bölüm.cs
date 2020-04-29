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
    public partial class frmBölümKısımları : Form
    {
        public frmBölümKısımları()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");


        // ** Kısa Yollar
        private void DataGridiGüncelle()
        {
            // TODO: Bu kod satırı 'personelDataSet13.cmb_bölüm' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmb_bölümTableAdapter2.Fill(this.personelDataSet13.cmb_bölüm);
        }

       
        private void cmb_Kısım_Verilerini_Gir() // Kısım Seç combobox ına verileri gir.
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM cmb_kısım";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKısım_seç.Items.Add(dr["kısım"]);
                cmbKısım_seç.Text = "Kısım Seç";
            }
            baglantı.Close();
        } 
               

        private void frmBölümKısımları_Load(object sender, EventArgs e) // Form Load Kısmı
        {
            DataGridiGüncelle();
            cmb_Kısım_Verilerini_Gir();
        }

        private void cmblarıgüncelle() // Kısım hariç diğer comboboxları günceller
        {
            frmDüzenle listele = (frmDüzenle)Application.OpenForms["frmDüzenle"]; // Güncelle formundaki combobaxlar **
            listele.cmbTekrargüncelle();
        }

        private void btnSilKısım_Click_1(object sender, EventArgs e) // bölüm sil
        {
            if (lblBölümSilGizli.Text == "seçimyok")
            {
                MessageBox.Show("Herhangi bir alan seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz alanı seçip tekrar deneyiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("SİLİNECEK BÖLÜM: " + lblBölümSilGizli.Text + "" + Environment.NewLine + "" + Environment.NewLine + "Onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from cmb_bölüm Where bölüm=@bölüm";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@bölüm", lblBölümSilGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    //
                    DataGridiGüncelle();
                    cmblarıgüncelle();
                }
            }
        }

        private void btnEkleKısım_Click_1(object sender, EventArgs e) // Yeni Bölüm Ekle
        {
            if (cmbKısım_seç.Text != "Kısım Seç")
            {
                baglantı.Open();
                string sorgu = "Insert into cmb_bölüm (kısım,bölüm) values (@kısım,@bölüm)";
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@bölüm", txtKısımEkle.Text);
                komut.Parameters.AddWithValue("@kısım", cmbKısım_seç.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                //
                DataGridiGüncelle();
                txtKısımEkle.Clear(); // Kısım ekle texboxı temizle.
                //
                MessageBox.Show("KISIM: " + cmbKısım_seç.Text + "" + Environment.NewLine + " " + Environment.NewLine + "BÖLÜM: " + txtKısımEkle.Text + "", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
                cmblarıgüncelle();
            }
            else
            {
                MessageBox.Show("Lütfen bir KISIM seçin!", "KISIM SEÇİMİ YAPILMADI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
              
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //Tablodan seçimi labal a yazdır.
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string bölüm = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            lblBölümSilGizli.Text = bölüm;
        }

        private void txtara_TextChanged_1(object sender, EventArgs e) //Bölüme Göre Ara
        {

            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_bölüm where bölüm like '%" + txtara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();

        }
    }
}
