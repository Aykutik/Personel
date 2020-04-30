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
    public partial class frmTanımBelge : Form
    {
        public frmTanımBelge()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");

        private void datagrid_güncelle()
        {
            this.cmb_belgeTableAdapter.Fill(this.cmb_tabloset.cmb_belge);
        }

        private void cmblarıgüncelle()
        {
            frmDüzenle listele = (frmDüzenle)Application.OpenForms["frmDüzenle"]; // Güncelle formundaki combobaxlar **
            listele.cmbTekrargüncelleMYK_İSG();
        }

        private void frmTanımBelge_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cmb_tabloset.cmb_belge' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmb_belgeTableAdapter.Fill(this.cmb_tabloset.cmb_belge);
        }

        private void btnEkleBelge_Click(object sender, EventArgs e)
        {
            if (txtEkleBelge.Text == "")
            {
                MessageBox.Show("Geçerli bir BELGE adı girin.", "HATALI BELGE ADI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglantı.Open();
                string sorgu = "Insert into cmb_belge (belge) values (@pr)";
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@pr", txtEkleBelge.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                //
                datagrid_güncelle();
                cmblarıgüncelle();
                //
                MessageBox.Show("Kayıt başarılı", "Başarılı");
                txtEkleBelge.Clear();
            }
        }

        private void btnSilBelge_Click(object sender, EventArgs e)
        {
            if (lblSilBelgeGizli.Text == "seçimyok")
            {
                MessageBox.Show("Herhangi bir alan seçilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Silmek istediğiniz alanı seçip tekrar deneyiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("SİLİNECEK BELGE: " + lblSilBelgeGizli.Text + "" + Environment.NewLine + "" + Environment.NewLine + "Onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglantı.Open();
                    string sorgu = "Delete from cmb_belge Where belge=@pr";
                    SqlCommand komut = new SqlCommand(sorgu, baglantı);
                    komut.Parameters.AddWithValue("@pr", lblSilBelgeGizli.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    datagrid_güncelle();
                    cmblarıgüncelle();
                }
            }
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from cmb_belge where belge like '%" + txtara.Text + "%'", baglantı);
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
            lblSilBelgeGizli.Text = kısım;
        }
    }
}
