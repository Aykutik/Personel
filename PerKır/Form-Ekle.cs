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
    public partial class FormEkle : Form
    {
        public FormEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");

        private void Kutularıaktifet()
        {
            txtAdres.Enabled = true;
            txtDahili.Enabled = true;
            txtBabaAdı.Enabled = true;
            txtCepTelNo.Enabled = true;
            txtEPosta.Enabled = true;
            cmbGörevi.Enabled = true;
            txtPersonelKodu.Enabled = true;
            txtTcKimlik.Enabled = true;
            cmbAskerlikDurumu.Enabled = true;
            cmbBirim.Enabled = true;
            cmbİl.Enabled = true;
            cmbİlçe.Enabled = true;
            cmbBelgeDurumu.Enabled = true;
            cmbBölüm.Enabled = true;
            cmbDoğumYeri.Enabled = true;
            cmbDurak.Enabled = true;
            cmbEmekli.Enabled = true;
            cmbKanGrubu.Enabled = true;
            cmbKısım.Enabled = true;
            cmbMedeniHali.Enabled = true;
            cmbmykbelge.Enabled = true;
            cmbServis.Enabled = true;
            cmbUyruğu.Enabled = true;
            cmbÇalışmaŞekli.Enabled = true;
            cmbÖzelDurum.Enabled = true;
            cmbÖğrenimDurumu.Enabled = true;
            cmbİlkYardımBelgesi.Enabled = true;
            dtDoğumTarihi.Enabled = true;
            dtKıdemTarihi.Enabled = true;
            dtPeriyodikMuayene.Enabled = true;
            dtİşeGirişTarihi.Enabled = true;
            dtİştenÇıkışTarihi.Enabled = true;
            dtGeçerlilikİY.Enabled = true;
            cmbUyruğu.Enabled = true;
            txtİbanNo.Enabled = true;
            txtHesapNo.Enabled = true;
            dtİsgEğitimTarihi.Enabled = true;
            cmbBirimAmiri.Enabled = true;
            cmbEşDurumu.Enabled = true;
            txtÇocukSayısı.Enabled = true;
            cmbCinsiyet.Enabled = true;
            cmbAcilDurumGrubu.Enabled = true;
            pbPerFoto.Enabled = true;
            btnResimEkle.Enabled = true;
        }
        private void KutularıaktifetEkle()
        {
            txtAdres.Enabled = true;
            txtDahili.Enabled = true;
            txtBabaAdı.Enabled = true;
            txtCepTelNo.Enabled = true;
            txtEPosta.Enabled = true;
            cmbGörevi.Enabled = true;
            txtPersonelKodu.Enabled = true;
            txtTcKimlik.Enabled = true;
            cmbAskerlikDurumu.Enabled = true;
            cmbBirim.Enabled = true;
            cmbİl.Enabled = true;
            cmbİlçe.Enabled = true;
            cmbBelgeDurumu.Enabled = true;
            cmbBölüm.Enabled = true;
            cmbDoğumYeri.Enabled = true;
            cmbDurak.Enabled = true;
            cmbEmekli.Enabled = true;
            cmbKanGrubu.Enabled = true;
            cmbKısım.Enabled = true;
            cmbMedeniHali.Enabled = true;
            cmbmykbelge.Enabled = true;
            cmbServis.Enabled = true;
            cmbUyruğu.Enabled = true;
            cmbÇalışmaŞekli.Enabled = true;
            cmbÖzelDurum.Enabled = true;
            cmbÖğrenimDurumu.Enabled = true;
            cmbİlkYardımBelgesi.Enabled = true;
            dtDoğumTarihi.Enabled = true;
            dtKıdemTarihi.Enabled = true;
            dtPeriyodikMuayene.Enabled = true;
            dtİşeGirişTarihi.Enabled = true;
            dtİştenÇıkışTarihi.Enabled = true;
            dtGeçerlilikİY.Enabled = true;
            cmbUyruğu.Enabled = true;
            txtİbanNo.Enabled = true;
            txtHesapNo.Enabled = true;
            dtİsgEğitimTarihi.Enabled = true;
            cmbBirimAmiri.Enabled = true;
            cmbEşDurumu.Enabled = true;
            txtÇocukSayısı.Enabled = true;
            cmbCinsiyet.Enabled = true;
            cmbAcilDurumGrubu.Enabled = true;

        }

        private void Kutularıpasifet()
        {
            txtAdres.Enabled = false;
            txtDahili.Enabled = false;
            txtBabaAdı.Enabled = false;
            txtCepTelNo.Enabled = false;
            txtEPosta.Enabled = false;
            cmbGörevi.Enabled = false;
            txtPersonelKodu.Enabled = false;
            txtTcKimlik.Enabled = false;
            cmbAskerlikDurumu.Enabled = false;
            cmbİl.Enabled = false;
            cmbBirim.Enabled = false;
            cmbİlçe.Enabled = false;
            cmbBelgeDurumu.Enabled = false;
            cmbBölüm.Enabled = false;
            cmbDoğumYeri.Enabled = false;
            cmbDurak.Enabled = false;
            cmbEmekli.Enabled = false;
            cmbKanGrubu.Enabled = false;
            cmbKısım.Enabled = false;
            cmbMedeniHali.Enabled = false;
            cmbmykbelge.Enabled = false;
            cmbServis.Enabled = false;
            cmbUyruğu.Enabled = false;
            cmbÇalışmaŞekli.Enabled = false;
            cmbÖzelDurum.Enabled = false;
            cmbÖğrenimDurumu.Enabled = false;
            cmbİlkYardımBelgesi.Enabled = false;
            dtDoğumTarihi.Enabled = false;
            dtKıdemTarihi.Enabled = false;
            dtPeriyodikMuayene.Enabled = false;
            dtİşeGirişTarihi.Enabled = false;
            dtİştenÇıkışTarihi.Enabled = false;
            dtGeçerlilikİY.Enabled = false;
            cmbUyruğu.Enabled = false;
            txtİbanNo.Enabled = false;
            txtHesapNo.Enabled = false;
            dtİsgEğitimTarihi.Enabled = false;
            cmbBirimAmiri.Enabled = false;
            cmbEşDurumu.Enabled = false;
            txtÇocukSayısı.Enabled = false;
            cmbCinsiyet.Enabled = false;
            cmbAcilDurumGrubu.Enabled = false;
            pbPerFoto.Enabled = false;
            btnResimEkle.Enabled = false;

        }

        private void verilerimisil()
        {
            baglantı.Open();
            string sorgu = "Delete from Perlist Where peradsoyad=@perad";
            SqlCommand komut = new SqlCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@perAd", txtAdSoyad.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void verilerimigir()
        {
            baglantı.Open();
            string sorgu = "Insert into Perlist (peradsoyad,peradres,perdahili,pereposta,pergörev,perkod,pertcno,peraskerlik,perbölüm,perdoğumyeri,perdurak,peremeklilik,perbabaadı," +    //tamam
                "perceptelefonu,perkangrubu,perkısım,permedenihali,permykdurumu,perservis,perbirim,perçalışmaşekli,perözeldurum,perilkyardımbelgesi,peröğrenimdurumu,perkıdemtarihi," +    //tamam
                "perişegiriştarihi,periştençıkıştarihi,perbelgedurumu,perdoğumtarihi,perbankahesapno,peribanno,perisgeğitim,perbirimamiri)" +     //tamam,perfoto -eklenecek
                " values " +
                "(@perAd,@peradr,@perdah,@perep,@pergo,@perkod,@pertcno,@peraskerlik,@perbölüm,@perdoğumyeri,@perdurak,@peremeklilik,@perbabaadı," +   //tamam
                "@percep,@perkangrubu,@perkısım,@permedenihali,@permykdurumu,@perservis,@perbirim,@perçalışmaşekli,@perözeldurum,@perilkyardımbelgesi,@peröğrenimdurumu,@perkıdemtarihi," + //tamam
                "@perişegiriştarihi,@periştençıkıştarihi,@perbelgedurumu,@perdoğumtarihi,@perbankahesapno,@peribanno,@perisgeğitim,@perbirimamiri)"; //tamam,@perfoto -eklenecek
            SqlCommand komut = new SqlCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@perAd", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@peradr", txtAdres.Text);
            komut.Parameters.AddWithValue("@perdah", txtDahili.Text);
            komut.Parameters.AddWithValue("@perep", txtEPosta.Text);
            komut.Parameters.AddWithValue("@pergo", cmbGörevi.Text);
            komut.Parameters.AddWithValue("@perkod", txtPersonelKodu.Text);
            komut.Parameters.AddWithValue("@pertcno", txtTcKimlik.Text);
            komut.Parameters.AddWithValue("@peraskerlik", cmbAskerlikDurumu.Text);
            komut.Parameters.AddWithValue("@perbölüm", cmbBölüm.Text);
            komut.Parameters.AddWithValue("@perdoğumyeri", cmbDoğumYeri.Text);
            komut.Parameters.AddWithValue("@perdurak", cmbDurak.Text);
            komut.Parameters.AddWithValue("@peremeklilik", cmbEmekli.Text);
            komut.Parameters.AddWithValue("@perbabaadı", txtBabaAdı.Text);
            komut.Parameters.AddWithValue("@percep", txtCepTelNo.Text);
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
            komut.Parameters.AddWithValue("@perbelgedurumu", cmbBelgeDurumu.Text);
            komut.Parameters.AddWithValue("@perdoğumtarihi", dtDoğumTarihi.Value);
            komut.Parameters.AddWithValue("@perperiyodikmuayene", dtPeriyodikMuayene.Value);
            komut.Parameters.AddWithValue("@perbankahesapno", txtHesapNo.Text);
            komut.Parameters.AddWithValue("@peribanno", txtİbanNo.Text);
            komut.Parameters.AddWithValue("@perisgeğitim", dtİsgEğitimTarihi.Value);
            komut.Parameters.AddWithValue("@perbirimamiri", cmbBirimAmiri.Text);
            komut.Parameters.AddWithValue("@pereşdurumu", cmbEşDurumu.Text);
            komut.Parameters.AddWithValue("@perçocuk", txtÇocukSayısı.Text);
            komut.Parameters.AddWithValue("@percinsiyet", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@peracildurumgrubu", cmbAcilDurumGrubu.Text);
            //komut.Parameters.AddWithValue("@perfoto", pbPerFoto.ImageLocation);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }
        private void verilerimigüncelle()
        {
            baglantı.Open();
            string sorgu = "Update Perlist Set peradres=@peradr, perdahili=@perdah, pereposta=@perep, pergörev=@pergo, perkod=@perkod, pertcno=@pertcno, peraskerlik=@peraskerlik, perbölüm=@perbölüm," +
                "perdoğumyeri=@perdoğumyeri, perdurak=@perdurak, peremeklilik=@peremeklilik, perbabaadı=@perbabaadı, perceptelefonu=@percep, " +
                "perkangrubu=@perkangrubu, perkısım=@perkısım, permedenihali=@permedenihali, permykdurumu=@permykdurumu, perservis=@perservis, perbirim=@perbirim, " +
                "perçalışmaşekli=@perçalışmaşekli, perözeldurum=@perözeldurum, perilkyardımbelgesi=@perilkyardımbelgesi, peröğrenimdurumu=@peröğrenimdurumu, " +
                "perkıdemtarihi=@perkıdemtarihi, perişegiriştarihi=@perişegiriştarihi, periştençıkıştarihi=@periştençıkıştarihi, perfoto=@perfoto," +
                "peruyruğu=@peruyruğu, perbelgedurumu=@perbelgedurumu, perdoğumtarihi=@perdoğumtarihi, perperiyodikmuayene=@perperiyodikmuayene, " +
                "perbankahesapno=@perbankahesapno, peribanno=@peribanno, perisgeğitim=@perisgeğitim, perbirimamiri=@perbirimamiri," +
                "pereşdurumu=@pereşdurumu, perçocuk=@perçocuk, percinsiyet=@percinsiyet, peracildurumgrubu=@peracildurumgrubu" +
                "" +
                " Where peradsoyad=@perAd";
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
        }
        // verileri tex boxlara yazdır kodu ********
        //baglantı.Open();
        //SqlCommand komut = new SqlCommand("select *from Perlist where peradsoyad=@PerAd", baglantı);
        //komut.Parameters.AddWithValue("@PerAd", txtAdSoyad.Text);
        //komut.ExecuteNonQuery();
        //SqlDataReader oku = komut.ExecuteReader();
        //while (oku.Read())
        //{
        //    txtAdres.Text = oku["peradres"].ToString();
        //    txtDahili.Text = oku["perdahili"].ToString();
        //    txtBabaAdı.Text = oku["perbabaadı"].ToString();
        //    txtCepTelNo.Text = oku["perceptelefonu"].ToString();
        //    txtEPosta.Text = oku["pereposta"].ToString();
        //    txtGörev.Text = oku["pergörev"].ToString();
        //    txtPersonelKodu.Text = oku["perkod"].ToString();
        //    txtTcKimlik.Text = oku["pertcno"].ToString();
        //    cmbAskerlikDurumu.Text = oku["peraskerlik"].ToString();
        //    cmbBelgeDurumu.Text = oku["perbelgedurumu"].ToString();
        //    cmbBölüm.Text = oku["perbölüm"].ToString();
        //    cmbDoğumYeri.Text = oku["perdoğumyeri"].ToString();
        //    cmbDurak.Text = oku["perdurak"].ToString();
        //    cmbEmekli.Text = oku["peremeklilik"].ToString();
        //    cmbKanGrubu.Text = oku["perkangrubu"].ToString();
        //    cmbKısım.Text = oku["perkısım"].ToString();
        //    cmbMedeniHali.Text = oku["permedenihali"].ToString();
        //    cmbmykbelge.Text = oku["permykdurumu"].ToString();
        //    cmbServis.Text = oku["perservis"].ToString();
        //    cmbBirim.Text = oku["perbirim"].ToString();
        //    cmbUyruğu.Text = oku["peruyruğu"].ToString();
        //    cmbÇalışmaŞekli.Text = oku["perçalışmaşekli"].ToString();
        //    cmbÖzelDurum.Text = oku["perözeldurum"].ToString();
        //    cmbÖğrenimDurumu.Text = oku["peröğrenimdurumu"].ToString();
        //    cmbİlkYardımBelgesi.Text = oku["perilkyardımbelgesi"].ToString();
        //    dtDoğumTarihi.Text = oku["perdoğumtarihi"].ToString();
        //    dtKıdemTarihi.Text = oku["perkıdemtarihi"].ToString();
        //    dtPeriyodikMuayene.Text = oku["perperiyodikmuayene"].ToString();
        //    dtİşeGirişTarihi.Text = oku["perişegiriştarihi"].ToString();
        //    dtİştenÇıkışTarihi.Text = oku["periştençıkıştarihi"].ToString();
        //    lblKıdemYılı.Text = oku["perkıdemyılı"].ToString();
        //    pbPerFoto.ImageLocation = oku["perFoto"].ToString();
        //    lblFirmaÜnvanı.Text = oku["perfirma"].ToString();
        //    txtİbanNo.Text = oku["peribanno"].ToString();
        //    txtHesapNo.Text = oku["perbankahesapno"].ToString();
        //    dtİsgEğitimTarihi.Text = oku["perisgeğitim"].ToString();
        //    cmbBirimAmiri.Text = oku["perbirimamiri"].ToString();
        //    cmbEşDurumu.Text = oku["pereşdurumu"].ToString();
        //    txtÇocukSayısı.Text = oku["perçocuk"].ToString();
        //    cmbCinsiyet.Text = oku["percinsiyet"].ToString();
        //    cmbAcilDurumGrubu.Text = oku["peracildurumgrubu"].ToString();
        //}
        //baglantı.Close();
        private void verilerimigöster()
        {
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


        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //pbPerFoto.ImageLocation = openFileDialog1.FileName;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Kısım();

        }

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



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void btnEkle_Click(object sender, EventArgs e) // Kaydet
        {
            verilerimigir();
            FrmAnaForm Listele = (FrmAnaForm)Application.OpenForms["Form2"];
            Listele.kayitGetir();
            MessageBox.Show("Personel Ekleme Başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e) // texboxlardan birisi dolu ise emin misin diye soracak*** * **
        {
            if (txtAdSoyad.Text.Length > 0 || txtTcKimlik.Text.Length > 0 || txtPersonelKodu.Text.Length > 0)
            {
                DialogResult secenek = MessageBox.Show("Personel kaydedilmedi!" + Environment.NewLine + "" + Environment.NewLine + "Yapılan Değişiklikleri iptal etmek istiyorsunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (secenek == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            txtAdSoyad.Text = txtAdSoyad.Text.ToUpper();
            txtAdSoyad.SelectionStart = txtAdSoyad.Text.Length;
        }

        private void cmbKısım_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBölüm.Items.Clear();
            cmb_bölüm();
        }

        private void cmbBölüm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBirim.Items.Clear();
            cmb_birim();

            cmbBirimAmiri.Items.Clear();
            cmb_birim_amiri();
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGörevi.Items.Clear();
            cmb_Görev();
        }

        private void FormEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
