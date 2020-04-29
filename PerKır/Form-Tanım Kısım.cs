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
    public partial class frmKısımTanımları : Form
    {
        public frmKısımTanımları()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");

        private void cmblarıgüncelle()
        {
            frmDüzenle listele = (frmDüzenle)Application.OpenForms["frmDüzenle"]; // Güncelle formundaki combobaxlar **
            listele.cmbTekrargüncelle();
        }

        private void frmKısımTanımları_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSet5.cmb_kısım' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmb_kısımTableAdapter.Fill(this.personelDataSet5.cmb_kısım);
            // TODO: Bu kod satırı 'personelDataSet4.cmb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmbTableAdapter.Fill(this.personelDataSet4.cmb);
           
        }

        private void btnSilKısım_Click(object sender, EventArgs e)
        {
            if (lblKısımSilGizli.Text == "seçimyok")
            {
                MessageBox.Show("Herhangi bir alan seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz alanı seçip tekrar deneyiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("SİLİNECEK KISIM: " + lblKısımSilGizli.Text + "" + Environment.NewLine + "" + Environment.NewLine + "Onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from cmb_kısım Where kısım=@kısım";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@kısım", lblKısımSilGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    this.cmb_kısımTableAdapter.Fill(this.personelDataSet5.cmb_kısım);
                    cmblarıgüncelle();
                }
            }
        }        

        private void btnEkleKısım_Click(object sender, EventArgs e)
        {
            if (txtKısımEkle.Text == "")
            {
                MessageBox.Show("Geçerli bir KISIM adı girin.", "HATALI KISIM ADI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglantı.Open();
                string sorgu = "Insert into cmb_kısım (kısım) values (@kısım)";
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@kısım", txtKısımEkle.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                //
                this.cmb_kısımTableAdapter.Fill(this.personelDataSet5.cmb_kısım); // ** bunları bir private açıp tek saferde yapabilirsin
                cmblarıgüncelle();
                //
                MessageBox.Show("Kayıt başarılı", "Başarılı");
                txtKısımEkle.Clear();
            }
         
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string kısım = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            lblKısımSilGizli.Text = kısım;
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
    }
}
