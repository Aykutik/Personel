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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Kutularıpasifet();
        }

        private void Kutularıaktifet()
        {
            txtAdres.Enabled = true;
            txtDahili.Enabled = true;
            txtBabaAdı.Enabled = true;
            txtCepTelNo.Enabled = true;
            txtEPosta.Enabled = true;
            txtGörev.Enabled = true;
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
            txtGörev.Enabled = true;
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
            txtGörev.Enabled = false;
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

        SqlConnection baglantı = new SqlConnection("Data Source=IK-IQT-2\\KIRIKERNAME;Initial Catalog=Personel;Integrated Security=True;Pooling=False");

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
            komut.Parameters.AddWithValue("@pergo", txtGörev.Text);
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
            MessageBox.Show("Yeni Personel Ekleme Başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            komut.Parameters.AddWithValue("@pergo", txtGörev.Text);
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

        private void verilerimigöster()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from Perlist where peradsoyad=@PerAd", baglantı);
            komut.Parameters.AddWithValue("@PerAd", txtAdSoyad.Text);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtAdres.Text = oku["peradres"].ToString();
                txtDahili.Text = oku["perdahili"].ToString();
                txtBabaAdı.Text = oku["perbabaadı"].ToString();
                txtCepTelNo.Text = oku["perceptelefonu"].ToString();
                txtEPosta.Text = oku["pereposta"].ToString();
                txtGörev.Text = oku["pergörev"].ToString();
                txtPersonelKodu.Text = oku["perkod"].ToString();
                txtTcKimlik.Text = oku["pertcno"].ToString();
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
                lblFirmaÜnvanı.Text = oku["perfirma"].ToString();
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
            //*******   FORM ELEMANLARI    ******
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

        private void formlarıtemizle()
        {
            txtAdres.Clear();
            txtDahili.Clear();
            txtBabaAdı.Clear();
            txtCepTelNo.Clear();
            txtEPosta.Clear();
            txtGörev.Clear();
            txtPersonelKodu.Clear();
            txtTcKimlik.Clear();
            cmbAskerlikDurumu.ResetText();
            cmbBelgeDurumu.ResetText();
            cmbBölüm.ResetText();
            cmbDoğumYeri.ResetText();
            cmbDurak.ResetText();
            cmbEmekli.ResetText();
            cmbKanGrubu.ResetText();
            cmbKısım.ResetText();
            cmbMedeniHali.ResetText();
            cmbmykbelge.ResetText();
            cmbServis.ResetText();
            cmbBirim.ResetText();
            cmbUyruğu.ResetText();
            cmbÇalışmaŞekli.ResetText();
            cmbÖzelDurum.ResetText();
            cmbÖğrenimDurumu.ResetText();
            cmbİlkYardımBelgesi.ResetText();
            dtDoğumTarihi.ResetText();
            dtKıdemTarihi.ResetText();
            //dtPeriyodikMuayene.Clear();
            dtİşeGirişTarihi.ResetText();
            dtİştenÇıkışTarihi.ResetText();
            lblKıdemYılı.Text = "Kıdem Yılı";
            pbPerFoto.ResetText();
            //lblFirmaÜnvanı.Clear();
            txtİbanNo.Clear();
            txtHesapNo.Clear();
            //dtİsgEğitimTarihi.Clear();
            //cmbBirimAmiri.Clear();
            //cmbEşDurumu.Clear();
            txtÇocukSayısı.Clear();
            //cmbCinsiyet.Clear();
            //cmbAcilDurumGrubuClear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kutularıaktifet();
            verilerimigöster();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblPersonelKodu_Click(object sender, EventArgs e)
        {

        }

        private void lblKanGrubu_Click(object sender, EventArgs e)
        {

        }

        private void cmbAskerlikDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMedeniHali_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblMedeniHali_Click(object sender, EventArgs e)
        {

        }

        private void dtDoğumTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbPerFoto.ImageLocation = openFileDialog1.FileName;
        }

        private void btnperkaydet_Click(object sender, EventArgs e)
        {
            verilerimigüncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSet2.cmb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmbTableAdapter2.Fill(this.personelDataSet2.cmb);
            // TODO: Bu kod satırı 'personelDataSet1.cmb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmbTableAdapter1.Fill(this.personelDataSet1.cmb);
            // TODO: Bu kod satırı 'personelDataSet.cmb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cmbTableAdapter.Fill(this.personelDataSet.cmb);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cmbTableAdapter.FillBy(this.personelDataSet.cmb);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tpKişiselBilgiler_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            verilerimigir();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KutularıaktifetEkle();        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            verilerimisil();
            formlarıtemizle();
        }
    }
}
