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
    public partial class frmDüzenle : Form
    {
        public frmDüzenle()
        {
            InitializeComponent();
        }

        //*******   FORM ELEMANLARI    ******
        //txtAdSoyad.
        //txtAdres.
        //txtDahili.
        //txtBabaAdı.
        //txtCepTelNo.
        //txtEPosta.
        //txtGörev.
        //txtPersonelKodu.
        //txtTcKimlik.
        //cmbAskerlikDurumu.
        //cmbBelgeDurumu.
        //cmbBölüm.
        //cmbDoğumYeri.
        //cmbDurak.
        //cmbEmekli.
        //cmbKanGrubu.
        //cmbKısım.
        //cmbMedeniHali
        //cmbmykbelge.
        //cmbServis.
        //cmbBirim.
        //cmbUyruğu.
        //cmbÇalışmaŞekli.
        //cmbÖzelDurum.
        //cmbÖğrenimDurumu.
        //cmbİlkYardımBelgesi.
        //dtDoğumTarihi.
        //dtKıdemTarihi.
        //dtPeriyodikMuayene.
        //dtİşeGirişTarihi.
        //dtİştenÇıkışTarihi.
        //lblKıdemYılı.
        //pbPerFoto.
        //lblFirmaÜnvanı.
        //txtİbanNo.
        //txtHesapNo.
        //dtİsgEğitimTarihi.
        //cmbBirimAmiri.
        //cmbEşDurumu.
        //txtÇocukSayısı.
        //cmbCinsiyet.
        //cmbAcilDurumGrubu

        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");



        private void Form3_Load(object sender, EventArgs e) // Form Yükleme Alanı
        {
            verilerimigöster();
            cmb_Kısım();
        }

     
        // ** Buton eylemleri
        private void verilerimigüncelle() // Verilerin üzerine yaz.
        {
            baglantı.Open();
            string sorgu = "Update Perlist Set peradres=@peradr, perdahili=@perdah, pereposta=@perep, pergörev=@pergo, perkod=@perkod, peraskerlik=@peraskerlik, perbölüm=@perbölüm," +
                "perdoğumyeri=@perdoğumyeri, perdurak=@perdurak, peremeklilik=@peremeklilik, perbabaadı=@perbabaadı, perceptelefonu=@percep, " +
                "perkangrubu=@perkangrubu, perkısım=@perkısım, permedenihali=@permedenihali, permykdurumu=@permykdurumu, perservis=@perservis, perbirim=@perbirim, " +
                "perçalışmaşekli=@perçalışmaşekli, perözeldurum=@perözeldurum, perilkyardımbelgesi=@perilkyardımbelgesi, peröğrenimdurumu=@peröğrenimdurumu, " +
                "perkıdemtarihi=@perkıdemtarihi, perişegiriştarihi=@perişegiriştarihi, periştençıkıştarihi=@periştençıkıştarihi, perfoto=@perfoto," +
                "peruyruğu=@peruyruğu, perbelgedurumu=@perbelgedurumu, perdoğumtarihi=@perdoğumtarihi, perperiyodikmuayene=@perperiyodikmuayene, " +
                "perbankahesapno=@perbankahesapno, peribanno=@peribanno, perisgeğitim=@perisgeğitim, perbirimamiri=@perbirimamiri," +
                "pereşdurumu=@pereşdurumu, perçocuk=@perçocuk, percinsiyet=@percinsiyet, peracildurumgrubu=@peracildurumgrubu, peradsoyad=@perAd" +
                "" +
                " Where pertcno=@pertcno";
            SqlCommand komut = new SqlCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@perAd", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@peradr", txtAdres.Text);
            komut.Parameters.AddWithValue("@perdah", txtDahili.Text);
            komut.Parameters.AddWithValue("@perbabaadı", txtBabaAdı.Text);
            komut.Parameters.AddWithValue("@percep", txtCepTelNo.Text);
            komut.Parameters.AddWithValue("@perep", txtEPosta.Text);
            komut.Parameters.AddWithValue("@pergo", cmbGörevi.Text);
            komut.Parameters.AddWithValue("@perkod", txtPersonelKodu.Text);
            komut.Parameters.AddWithValue("@pertcno", txtTcKimlik.Text);
            komut.Parameters.AddWithValue("@peraskerlik", cmbAskerlikDurumu.Text);
            komut.Parameters.AddWithValue("@perbölüm", cmbBölüm.Text);
            komut.Parameters.AddWithValue("@perdoğumyeri", cmbDoğumYeri.Text);
            komut.Parameters.AddWithValue("@perdurak", cmbDurak.Text);
            komut.Parameters.AddWithValue("@peremeklilik", cmbEmekli.Text);
            komut.Parameters.AddWithValue("@perkangrubu", cmbKanGrubu.Text);
            komut.Parameters.AddWithValue("@perkısım", cmbKısım.Text);
            komut.Parameters.AddWithValue("@permedenihali", cmbMedeniHali.Text);
            komut.Parameters.AddWithValue("@permykdurumu", cmbmykbelge.Text);
            komut.Parameters.AddWithValue("@perservis", cmbServis.Text);
            komut.Parameters.AddWithValue("@perbirim", cmbBirim.Text);
            komut.Parameters.AddWithValue("@perçalışmaşekli", cmbÇalışmaŞekli.Text);
            komut.Parameters.AddWithValue("@perözeldurum", cmbÖzelDurum.Text);
            komut.Parameters.AddWithValue("@perilkyardımbelgesi", cmbİlkYardımBelgesi.Text);
            komut.Parameters.AddWithValue("@peröğrenimdurumu", cmbÖğrenimDurumu.Text);
            komut.Parameters.AddWithValue("@perkıdemtarihi", dtKıdemTarihi.Value);
            komut.Parameters.AddWithValue("@perişegiriştarihi", dtİşeGirişTarihi.Value);
            komut.Parameters.AddWithValue("@periştençıkıştarihi", dtİştenÇıkışTarihi.Value);
            komut.Parameters.AddWithValue("@perfoto", pbPerFoto.ImageLocation);
            komut.Parameters.AddWithValue("@peruyruğu", cmbUyruğu.Text);
            komut.Parameters.AddWithValue("@perbelgedurumu", cmbBelgeDurumu.Text);
            komut.Parameters.AddWithValue("@perdoğumtarihi", dtDoğumTarihi.Value);
            komut.Parameters.AddWithValue("@perperiyodikmuayene", dtPeriyodikMuayene.Value);
            komut.Parameters.AddWithValue("@peribanno", txtİbanNo.Text);
            komut.Parameters.AddWithValue("@perbankahesapno", txtHesapNo.Text);
            komut.Parameters.AddWithValue("@perisgeğitim", dtİsgEğitimTarihi.Value);
            komut.Parameters.AddWithValue("@perbirimamiri", cmbBirimAmiri.Text);
            komut.Parameters.AddWithValue("@pereşdurumu", cmbEşDurumu.Text);
            komut.Parameters.AddWithValue("@perçocuk", txtÇocukSayısı.Text);
            komut.Parameters.AddWithValue("@percinsiyet", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@peracildurumgrubu", cmbAcilDurumGrubu.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Persenel bilgileri güncelleştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

        private void verilerimigöster() // TC kimlik no ya göre diğer alanları dolduruyor.
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from Perlist where pertcno=@pertcno", baglantı);
            komut.Parameters.AddWithValue("@pertcno", txtTcKimlik.Text);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtAdSoyad.Text = oku["peradsoyad"].ToString();
                txtAdres.Text = oku["peradres"].ToString();
                txtDahili.Text = oku["perdahili"].ToString();
                txtBabaAdı.Text = oku["perbabaadı"].ToString();
                txtCepTelNo.Text = oku["perceptelefonu"].ToString();
                txtEPosta.Text = oku["pereposta"].ToString();
                cmbGörevi.Text = oku["pergörev"].ToString();
                txtPersonelKodu.Text = oku["perkod"].ToString();
                cmbAskerlikDurumu.Text = oku["peraskerlik"].ToString();
                cmbBelgeDurumu.Text = oku["perbelgedurumu"].ToString();
                cmbBölüm.Text = oku["perbölüm"].ToString();
                cmbDoğumYeri.Text = oku["perdoğumyeri"].ToString();
                cmbDurak.Text = oku["perdurak"].ToString();
                cmbEmekli.Text = oku["peremeklilik"].ToString();
                cmbKanGrubu.Text = oku["perkangrubu"].ToString();
                cmbKısım.Text = oku["perkısım"].ToString();
                cmbMedeniHali.Text = oku["permedenihali"].ToString();
                cmbmykbelge.Text = oku["permykdurumu"].ToString();
                cmbServis.Text = oku["perservis"].ToString();
                cmbBirim.Text = oku["perbirim"].ToString();
                cmbUyruğu.Text = oku["peruyruğu"].ToString();
                cmbÇalışmaŞekli.Text = oku["perçalışmaşekli"].ToString();
                cmbÖzelDurum.Text = oku["perözeldurum"].ToString();
                cmbÖğrenimDurumu.Text = oku["peröğrenimdurumu"].ToString();
                cmbİlkYardımBelgesi.Text = oku["perilkyardımbelgesi"].ToString();
                dtDoğumTarihi.Text = oku["perdoğumtarihi"].ToString();
                dtKıdemTarihi.Text = oku["perkıdemtarihi"].ToString();
                dtPeriyodikMuayene.Text = oku["perperiyodikmuayene"].ToString();
                dtİşeGirişTarihi.Text = oku["perişegiriştarihi"].ToString();
                dtİştenÇıkışTarihi.Text = oku["periştençıkıştarihi"].ToString();
                lblKıdemYılı.Text = oku["perkıdemyılı"].ToString();
                pbPerFoto.ImageLocation = oku["perFoto"].ToString();
                
                txtİbanNo.Text = oku["peribanno"].ToString();
                txtHesapNo.Text = oku["perbankahesapno"].ToString();
                dtİsgEğitimTarihi.Text = oku["perisgeğitim"].ToString();
                cmbBirimAmiri.Text = oku["perbirimamiri"].ToString();
                cmbEşDurumu.Text = oku["pereşdurumu"].ToString();
                txtÇocukSayısı.Text = oku["perçocuk"].ToString();
                cmbCinsiyet.Text = oku["percinsiyet"].ToString();
                cmbAcilDurumGrubu.Text = oku["peracildurumgrubu"].ToString();
            }
            baglantı.Close();
        }

        private void btnperkaydet_Click_1(object sender, EventArgs e) // Kaydet Tuşu.
        {
            verilerimigüncelle();
            FrmAnaForm listele = (FrmAnaForm)Application.OpenForms["FrmAnaForm"];
            listele.kayitGetir();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e) //İptal tuşu
        {
            this.Close();
        }


        // Ayarlar
        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            txtAdSoyad.Text = txtAdSoyad.Text.ToUpper();
            txtAdSoyad.SelectionStart = txtAdSoyad.Text.Length;
        } // Ad Soyadı 'ı büyük yaz.


        // ** Seçilenlere göre comboboxların indexlerini gir.
        private void cmb_Kısım()
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
                cmbKısım.Items.Add(dr["kısım"]);
            }
            baglantı.Close();

        } // Kısım comboboxın indexlerini çek.

        public void cmb_bölüm() // Bölüm combo sununun indexlerini kısıma seçilen göre gir.
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM cmb_bölüm where kısım=@sec";
            komut.Parameters.AddWithValue("@sec", cmbKısım.Text); /// kısımda seçilen değer ne ise ona göre 
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = komut.ExecuteReader(); // if seçeneği ile uğraşırken onun hallettimama burası hata verdi // eve geldim şimdi hata vermedi.
            while (dr.Read())
            {
                cmbBölüm.Items.Add(dr["bölüm"]);
            }
            baglantı.Close();
        }

        public void cmb_birim() // Birim Combosunun indexlerini bölüme seçilen göre gir.
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM cmb_birim where bölüm=@seçilendeğer";
            komut.Parameters.AddWithValue("@seçilendeğer", cmbBölüm.Text);
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBirim.Items.Add(dr["birim"]);
            }
            baglantı.Close();
        }

        public void cmb_birim_amiri() // Birim Amiri combosunun indexlerini seçilen bölüme göre gir.
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM cmb_br_amir where bölüm=@seçilendeğer";
            komut.Parameters.AddWithValue("@seçilendeğer", cmbBölüm.Text);
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBirimAmiri.Items.Add(dr["br_amir"]);
            }
            baglantı.Close();
        }

        public void cmb_Görev() // Görevi combosunun indexlerini seçilen birime göre gir.
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM cmb_görev where birim=@seçilendeğer";
            komut.Parameters.AddWithValue("@seçilendeğer", cmbBirim.Text);
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbGörevi.Items.Add(dr["görevi"]);
            
            }
            baglantı.Close();
        }


        //  ** Comboboxlar değiştirildiğinde
        private void cmbKısım_SelectedIndexChanged(object sender, EventArgs e) //Kısım değiştirildiğinde bölümü yenile.
        {
            cmbBölüm.Items.Clear();
            cmb_bölüm();
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e) //Birim değiştirildiğinde görevi yenile.
        {
            cmbGörevi.Items.Clear();
            cmb_Görev();
        }

        private void cmbBölüm_SelectedIndexChanged(object sender, EventArgs e) //Bölüm değiştirildiğinde birimi ve birim amirini yenile.
        {
            cmbBirim.Items.Clear();
            cmb_birim();
            //
            cmbBirimAmiri.Items.Clear();
            cmb_birim_amiri();
        }


        // ** //Comboboxları temizle ve yeniden yükle
        public void cmbTekrargüncelle()
        { 
            cmbKısım.Items.Clear();
            cmb_Kısım();

            cmbBölüm.Items.Clear();
            cmb_bölüm();

            cmbBirim.Items.Clear();
            cmb_birim();

            cmbBirimAmiri.Items.Clear();
            cmb_birim_amiri();
            
            cmbGörevi.Items.Clear();
            cmb_Görev();
        }

        // ** Comboboxları düzenle butonları
        private void btnEkleKısım_Click(object sender, EventArgs e) //Kısım Ekle
        {
            frmKısımTanımları frm5 = new frmKısımTanımları();
            frm5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //Bölüm ekle
        {
            frmBölümKısımları frm5 = new frmBölümKısımları();
            frm5.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e) //Birim Ekle
        {
            frmBirimTanım frm6 = new frmBirimTanım();
            frm6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)  //Birim Amiri Ekle
        {
            TanımBirimAmir frm7 = new TanımBirimAmir();      
            frm7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) //GörevTanımıAç
        {
            GörevTanım frm8 = new GörevTanım();
            frm8.ShowDialog();
        }
    }
}
    
