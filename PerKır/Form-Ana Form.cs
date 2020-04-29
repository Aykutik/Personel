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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");
        public void kayitGetir()
        {
            baglantı.Open();
            string kayit = "SELECT * from PerList";
            
            SqlCommand komut = new SqlCommand(kayit, baglantı);
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;
            
            baglantı.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void txtekle_Click(object sender, EventArgs e) //Tıklayınca FormEkle formunu aç
        {
            FormEkle formEkle = new FormEkle();
            formEkle.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblPerAdSoyadGizli.Text=="label2")
            {
                MessageBox.Show("Herhangi bir personel seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz personeli seçip tekrar deneyiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("" + lblPerAdSoyadGizli.Text + " adlı Personelinizi siliyorsunuz!" + Environment.NewLine + "" + Environment.NewLine + "Bu işlem geri alınamaz, onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from PerList Where pertcno=@pertcno";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@pertcno", lblTcnoGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    kayitGetir();
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string adsoyad = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string tcno = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            lblTcnoGizli.Text = tcno;
            lblPerAdSoyadGizli.Text = adsoyad;
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (lblPerAdSoyadGizli.Text == "label2")
            {
                MessageBox.Show("Herhangi bir personel seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Düzenlemek istediğiniz personeli seçip tekrar deneyiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Persenel bilgileri güncelleştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmDüzenle FormGüncelle = new frmDüzenle();
                FormGüncelle.txtTcKimlik.Text = lblTcnoGizli.Text;
                FormGüncelle.ShowDialog();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDüzenle FormGüncelle = new frmDüzenle();
            FormGüncelle.txtTcKimlik.Text = lblTcnoGizli.Text;
            FormGüncelle.ShowDialog();
        }

        private void txtAraPer_TextChanged(object sender, EventArgs e) // yazdıkça aramaya başlıyor çok iyi yaptım bunu :)
        {
            baglantı.Open();
            SqlCommand komut=new SqlCommand("Select *from Perlist where peradsoyad like '%"+ txtAraPer.Text +"%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //buton silindi çünkü yazdıkça aramaya yapmasına imkan verdim 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
