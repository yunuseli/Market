using OgrenciTakip.Enums;
using OgrenciTakip.Models;
using System.Data;
using System.Reflection;

namespace OgrenciTakip.Classes
{
  public class OgrenciClass
  {
    public OgrenciClass()
    {

    }

    public KayitModlari kayitModu { get; set; }

    public DataTable dtOgrenci { get; set; }
    public void TabloyuOlustur()
    {
      // Kolonlar
      dtOgrenci.Columns.Add("Id", typeof(int));
      dtOgrenci.Columns.Add("Ad", typeof(string));
      dtOgrenci.Columns.Add("Soyad", typeof(string));
      dtOgrenci.Columns.Add("Sinif", typeof(string));
      dtOgrenci.Columns.Add("Sube", typeof(string));
      dtOgrenci.Columns.Add("Numara", typeof(ushort));
      dtOgrenci.Columns.Add("Not1", typeof(byte));
      dtOgrenci.Columns.Add("Not2", typeof(byte));
      dtOgrenci.Columns.Add("Not3", typeof(byte));
      dtOgrenci.Columns.Add("Ortalama", typeof(float));
      dtOgrenci.Columns.Add("Durum", typeof(bool));
      dtOgrenci.Columns.Add("DurumTanim", typeof(string));
    }
    public void TabloyaVeriEkle(OgrenciModel ogrenci)
    {
      dtOgrenci.Rows.Add(
      ogrenci.Id,
      ogrenci.Ad,
      ogrenci.Soyad,
      ogrenci.Sinif,
      ogrenci.Sube,
      ogrenci.Numara,
      ogrenci.Not1,
      ogrenci.Not2,
      ogrenci.Not3,
      ogrenci.Ortalama,
      ogrenci.Durum,
      OgrenciDurum(ogrenci.Durum)
        );
    }
    public void TabloVeriDegistir(OgrenciModel ogrenci)
    {
      foreach (DataRow row in dtOgrenci.Rows)
      {
        if (row["Id"].ToString() == ogrenci.Id.ToString())
        {
          row["Ad"] = ogrenci.Ad;
          row["Soyad"] = ogrenci.Soyad;
          row["Sinif"] = ogrenci.Sinif;
          row["Sube"] = ogrenci.Sube;
          row["Numara"] = ogrenci.Numara;
          row["Not1"] = ogrenci.Not1;
          row["Not2"] = ogrenci.Not2;
          row["Not3"] = ogrenci.Not3;
          row["Ortalama"] = ogrenci.Ortalama;
          row["Durum"] = ogrenci.Durum;
          row["DurumTanim"] = OgrenciDurum(ogrenci.Durum);
          break;
        }
      }
    }

    public OgrenciModel RasgeleOgrenciOlustur()
    {
      OgrenciModel ogrenci = new OgrenciModel();

      Random rnd = new Random();

      int idMaks = int.MaxValue;
      string[] adlar = { "Ahmet", "Ersan", "Veli", "Burak", "Murat", "Emine", "Canan", "Ayşe", "Simge", "Öznur" };
      string[] soyadlar = { "ÇEVİK", "VURAL", "ASLAN", "ÖZER", "DEMİR", "BULUT", "ÖZDEMİR", "GÜNDÜZ", "KAYA", "ALTUN" };
      string[] siniflar = { "1", "2", "3", "4", "5", "6", "7", "8" };
      string[] subeler = { "A", "B", "C", "D", "E" };
      ushort numaraMaks = 1001;
      byte notMaks = 101;

      int rndSayi;

      rndSayi = rnd.Next(0, idMaks);
      ogrenci.Id = rndSayi;

      rndSayi = rnd.Next(0, adlar.Length);
      ogrenci.Ad = adlar[rndSayi];

      rndSayi = rnd.Next(0, soyadlar.Length);
      ogrenci.Soyad = soyadlar[rndSayi];

      rndSayi = rnd.Next(0, siniflar.Length);
      ogrenci.Sinif = siniflar[rndSayi];

      rndSayi = rnd.Next(0, subeler.Length);
      ogrenci.Sube = subeler[rndSayi];

      rndSayi = rnd.Next(0, numaraMaks);
      ogrenci.Numara = (ushort)rndSayi;

      rndSayi = rnd.Next(0, notMaks);
      ogrenci.Not1 = (byte)rndSayi;

      rndSayi = rnd.Next(0, notMaks);
      ogrenci.Not2 = (byte)rndSayi;

      rndSayi = rnd.Next(0, notMaks);
      ogrenci.Not3 = (byte)rndSayi;

      ogrenci.Ortalama = (ogrenci.Not1 + ogrenci.Not2 + ogrenci.Not3) / 3;

      if (ogrenci.Ortalama > 49)
        ogrenci.Durum = true;
      else
        ogrenci.Durum = false;

      return ogrenci;
    }

    public string OgrenciDurum(bool durum)
    {
      if (durum)
        return "Geçti";
      else
        return "Kaldı";
    }

    public OgrenciModel KayitEdilecekOgrenci(KayitModlari kayitModu, int id, string ad, 
      string soyad, string sinif, string sube, string numara,
      string not1, string not2, string not3, out CevapModel cevap)
    {
      // Boş öğrenci modeli oluştur
      OgrenciModel ogrenci = new OgrenciModel();

      // Cevap geri dönüşü için cevap modeli oluştur ve başta hata durumları genel bilgileri ayarla ** en son başarılı ise durum için dikkat et
      cevap = new CevapModel();
      cevap.Durum = CevapDurumlari.Hata;
      cevap.Kaynak = "OgrenciTakip.Classes.OgrenciClass.KayitEdilecekOgrenci";

      try
      {
        // Doğrulanacak veriler için gerekli değişkenleri tanımla
        int _id = id;
        if (kayitModu == KayitModlari.Ekle)
          _id = RasgeleOgrenciOlustur().Id;
        //string _ad = "";
        //string _soyad = "";
        //string _sinif = "";
        //string _sube = "";
        ushort _numara = 0;
        byte _not1 = 0;
        byte _not2 = 0;
        byte _not3 = 0;

        #region Veri Doğrulama ve Kontroller
        #region Ad Kontrolleri
        if (String.IsNullOrEmpty(ad) || String.IsNullOrWhiteSpace(ad))
        {
          cevap.Mesaj = "Ad boş olamaz";
          return ogrenci;
        }
        if (ad.Length < 2)
        {
          cevap.Mesaj = "Ad çok kısa";
          return ogrenci;
        }
        if (ad.Length > 20)
        {
          cevap.Mesaj = "Ad çok uzun";
          return ogrenci;
        }
        foreach (char harf in ad)
        {
          if (!Char.IsLetter(harf))
          {
            cevap.Mesaj = "Ad sadece harflerden oluşabilir";
            return ogrenci;
          }
        }
        //_ad = ad; 
        #endregion
        #region Soyad Kontrolleri
        if (String.IsNullOrEmpty(soyad) || String.IsNullOrWhiteSpace(soyad))
        {
          cevap.Mesaj = "Soyad boş olamaz";
          return ogrenci;
        }
        if (soyad.Length < 2)
        {
          cevap.Mesaj = "Soyad çok kısa";
          return ogrenci;
        }
        if (soyad.Length > 20)
        {
          cevap.Mesaj = "Soyad çok uzun";
          return ogrenci;
        }
        foreach (char harf in soyad)
        {
          if (!Char.IsLetter(harf))
          {
            cevap.Mesaj = "Soyad sadece harflerden oluşabilir";
            return ogrenci;
          }
        }
        //_soyad = soyad; 
        #endregion
        #region Sınıf Kontrolleri
        if (String.IsNullOrEmpty(sinif) || String.IsNullOrWhiteSpace(sinif))
        {
          cevap.Mesaj = "Sınıf bilgisi boş olamaz";
          return ogrenci;
        }
        if (sinif.Length > 3)
        {
          cevap.Mesaj = "Sınıf 3 karakterden uzun olamaz";
          return ogrenci;
        }
        //_sinif = sinif; 
        #endregion
        #region Şube Kontrolleri
        if (String.IsNullOrEmpty(sube) || String.IsNullOrWhiteSpace(sube))
        {
          cevap.Mesaj = "Şube bilgisi boş olamaz";
          return ogrenci;
        }
        if (sube.Length > 3)
        {
          cevap.Mesaj = "Şube 3 karakterden uzun olamaz";
          return ogrenci;
        }
        //_sinif = sinif; 
        #endregion
        #region Numara Kontrolleri
        if (ushort.TryParse(numara, out _numara) == false)
        {
          cevap.Mesaj = "Numara girişi hatalı";
          return ogrenci;
        }
        #endregion
        #region Not1
        if (byte.TryParse(not1, out _not1) == false)
        {
          cevap.Mesaj = "Not 1 girişi hatalı";
          return ogrenci;
        }
        if (_not1 < 0)
        {
          cevap.Mesaj = "Not 1 girişi 0'dan küçük olamaz";
          return ogrenci;
        }
        if (_not1 > 100)
        {
          cevap.Mesaj = "Not 1 girişi 100'den büyük olamaz";
          return ogrenci;
        }
        #endregion
        #region Not2
        if (byte.TryParse(not2, out _not2) == false)
        {
          cevap.Mesaj = "Not 2 girişi hatalı";
          return ogrenci;
        }
        if (_not2 < 0)
        {
          cevap.Mesaj = "Not 2 girişi 0'dan küçük olamaz";
          return ogrenci;
        }
        if (_not2 > 100)
        {
          cevap.Mesaj = "Not 2 girişi 100'den büyük olamaz";
          return ogrenci;
        }
        #endregion
        #region Not3
        if (byte.TryParse(not3, out _not3) == false)
        {
          cevap.Mesaj = "Not 3 girişi hatalı";
          return ogrenci;
        }
        if (_not3 < 0)
        {
          cevap.Mesaj = "Not 3 girişi 0'dan küçük olamaz";
          return ogrenci;
        }
        if (_not3 > 100)
        {
          cevap.Mesaj = "Not 3 girişi 100'den büyük olamaz";
          return ogrenci;
        }
        #endregion
        #endregion

        // ogrenci veri doldur
        ogrenci.Id = _id;
        ogrenci.Ad = ad;
        ogrenci.Soyad = soyad;
        ogrenci.Sinif = sinif;
        ogrenci.Sube = sube;
        ogrenci.Numara = _numara;
        ogrenci.Not1 = _not1;
        ogrenci.Not2 = _not2;
        ogrenci.Not3 = _not3;
        ogrenci.Ortalama = (ogrenci.Not1 + ogrenci.Not2 + ogrenci.Not3) / 3;
        if (ogrenci.Ortalama > 49)
          ogrenci.Durum = true;
        else
          ogrenci.Durum = false;
      }
      catch (Exception ex)
      {
        cevap.Mesaj = ex.Message;
        return ogrenci;
      }

      cevap.Durum = CevapDurumlari.Basarili;
      cevap.Mesaj = "Kayıt işlemi başarılı";
      return ogrenci;
    }

    public OgrenciModel KayitEdilecekOgrenci(KayitModlari kayitModu, KayitVeriModel girilenVeri, out CevapModel cevap)
    {
      // Metot adı (tam isim; proje.varsa_klasör.class.metot)
      string cn = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";

      // Verileri doldurmak için yeni öğrenci modeli oluştur
      OgrenciModel ogrenci = new OgrenciModel();

      // Cevap geri dönüşü için cevap modeli oluştur ve başta hata durumları genel bilgileri ayarla ** en son başarılı ise durum için dikkat et
      cevap = new CevapModel();
      cevap.Durum = CevapDurumlari.Hata;
      //cevap.Kaynak = "OgrenciTakip.Classes.OgrenciClass.KayitEdilecekOgrenci";
      cevap.Kaynak = cn;

      try
      {
        // Doğrulanacak veriler için gerekli değişkenleri tanımla
        int _id = girilenVeri.Id;
        if (kayitModu == KayitModlari.Ekle)
          _id = RasgeleOgrenciOlustur().Id;
        //string _ad = "";
        //string _soyad = "";
        //string _sinif = "";
        //string _sube = "";
        ushort _numara = 0;
        byte _not1 = 0;
        byte _not2 = 0;
        byte _not3 = 0;

        #region Veri Doğrulama ve Kontroller
        #region Ad Kontrolleri
        if (String.IsNullOrEmpty(girilenVeri.Ad) || String.IsNullOrWhiteSpace(girilenVeri.Ad))
        {
          cevap.Mesaj = "Ad boş olamaz";
          return ogrenci;
        }
        if (girilenVeri.Ad.Length < 2)
        {
          cevap.Mesaj = "Ad çok kısa";
          return ogrenci;
        }
        if (girilenVeri.Ad.Length > 20)
        {
          cevap.Mesaj = "Ad çok uzun";
          return ogrenci;
        }
        foreach (char harf in girilenVeri.Ad)
        {
          if (!Char.IsLetter(harf))
          {
            cevap.Mesaj = "Ad sadece harflerden oluşabilir";
            return ogrenci;
          }
        }
        //_ad = ad; 
        #endregion
        #region Soyad Kontrolleri
        if (String.IsNullOrEmpty(girilenVeri.Soyad) || String.IsNullOrWhiteSpace(girilenVeri.Soyad))
        {
          cevap.Mesaj = "Soyad boş olamaz";
          return ogrenci;
        }
        if (girilenVeri.Soyad.Length < 2)
        {
          cevap.Mesaj = "Soyad çok kısa";
          return ogrenci;
        }
        if (girilenVeri.Soyad.Length > 20)
        {
          cevap.Mesaj = "Soyad çok uzun";
          return ogrenci;
        }
        foreach (char harf in girilenVeri.Soyad)
        {
          if (!Char.IsLetter(harf))
          {
            cevap.Mesaj = "Soyad sadece harflerden oluşabilir";
            return ogrenci;
          }
        }
        //_soyad = soyad; 
        #endregion
        #region Sınıf Kontrolleri
        if (String.IsNullOrEmpty(girilenVeri.Sinif) || String.IsNullOrWhiteSpace(girilenVeri.Sinif))
        {
          cevap.Mesaj = "Sınıf bilgisi boş olamaz";
          return ogrenci;
        }
        if (girilenVeri.Sinif.Length > 3)
        {
          cevap.Mesaj = "Sınıf 3 karakterden uzun olamaz";
          return ogrenci;
        }
        //_sinif = sinif; 
        #endregion
        #region Şube Kontrolleri
        if (String.IsNullOrEmpty(girilenVeri.Sube) || String.IsNullOrWhiteSpace(girilenVeri.Sube))
        {
          cevap.Mesaj = "Şube bilgisi boş olamaz";
          return ogrenci;
        }
        if (girilenVeri.Sube.Length > 3)
        {
          cevap.Mesaj = "Şube 3 karakterden uzun olamaz";
          return ogrenci;
        }
        //_sinif = sinif; 
        #endregion
        #region Numara Kontrolleri
        if (ushort.TryParse(girilenVeri.Numara, out _numara) == false)
        {
          cevap.Mesaj = "Numara girişi hatalı";
          return ogrenci;
        }
        #endregion
        #region Not1
        if (byte.TryParse(girilenVeri.Not1, out _not1) == false)
        {
          cevap.Mesaj = "Not 1 girişi hatalı";
          return ogrenci;
        }
        if (_not1 < 0)
        {
          cevap.Mesaj = "Not 1 girişi 0'dan küçük olamaz";
          return ogrenci;
        }
        if (_not1 > 100)
        {
          cevap.Mesaj = "Not 1 girişi 100'den büyük olamaz";
          return ogrenci;
        }
        #endregion
        #region Not2
        if (byte.TryParse(girilenVeri.Not2, out _not2) == false)
        {
          cevap.Mesaj = "Not 2 girişi hatalı";
          return ogrenci;
        }
        if (_not2 < 0)
        {
          cevap.Mesaj = "Not 2 girişi 0'dan küçük olamaz";
          return ogrenci;
        }
        if (_not2 > 100)
        {
          cevap.Mesaj = "Not 2 girişi 100'den büyük olamaz";
          return ogrenci;
        }
        #endregion
        #region Not3
        if (byte.TryParse(girilenVeri.Not3, out _not3) == false)
        {
          cevap.Mesaj = "Not 3 girişi hatalı";
          return ogrenci;
        }
        if (_not3 < 0)
        {
          cevap.Mesaj = "Not 3 girişi 0'dan küçük olamaz";
          return ogrenci;
        }
        if (_not3 > 100)
        {
          cevap.Mesaj = "Not 3 girişi 100'den büyük olamaz";
          return ogrenci;
        }
        #endregion
        #endregion

        // ogrenci veri doldur
        ogrenci.Id = _id;
        ogrenci.Ad = girilenVeri.Ad;
        ogrenci.Soyad = girilenVeri.Soyad;
        ogrenci.Sinif = girilenVeri.Sinif;
        ogrenci.Sube = girilenVeri.Sube;
        ogrenci.Numara = _numara;
        ogrenci.Not1 = _not1;
        ogrenci.Not2 = _not2;
        ogrenci.Not3 = _not3;
        ogrenci.Ortalama = (ogrenci.Not1 + ogrenci.Not2 + ogrenci.Not3) / 3;
        if (ogrenci.Ortalama > 49)
          ogrenci.Durum = true;
        else
          ogrenci.Durum = false;
      }
      catch (Exception ex)
      {
        cevap.Mesaj = ex.Message;
        return new OgrenciModel();
      }

      cevap.Durum = CevapDurumlari.Basarili;
      cevap.Mesaj = "Kayıt işlemi başarılı";
      return ogrenci;
    }





    //OgrenciModel KayitEdilecekOgrenci()
    //{
    //  OgrenciModel ogrenci = null;
    //  try
    //  {
    //    int id = 0;
    //    if (kayitModu == KayitModlari.Ekle)
    //      id = ogrenciClass.RasgeleOgrenciOlustur().Id;
    //    else
    //      id = GridSeciliSatirOgrenci().Id;
    //    string ad = "";
    //    string soyad = "";
    //    string sinif = "";
    //    string sube = "";
    //    ushort numara = 0;
    //    byte not1 = 0;
    //    byte not2 = 0;
    //    byte not3 = 0;

    //    #region Ön Kontroller
    //    // Ad
    //    if (String.IsNullOrEmpty(txtAd.Text) || String.IsNullOrWhiteSpace(txtAd.Text))
    //    {
    //      MessageBox.Show("Ad boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    if (txtAd.Text.Length < 3)
    //    {
    //      MessageBox.Show("Ad çok kısa", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    if (txtAd.Text.Length > 20)
    //    {
    //      MessageBox.Show("Ad çok uzun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    foreach (char harf in txtAd.Text)
    //    {
    //      if (!Char.IsLetter(harf))
    //      {
    //        MessageBox.Show("Ad sadece harflerden oluşabilir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        return ogrenci;
    //      }
    //    }
    //    ad = txtAd.Text;

    //    soyad = txtSoyad.Text;
    //    sinif = txtSinif.Text;
    //    sube = txtSube.Text;

    //    //Numara
    //    if (ushort.TryParse(txtNumara.Text, out numara) == false)
    //    {
    //      MessageBox.Show("Numara girişi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }

    //    //Not1
    //    if (byte.TryParse(txtNot1.Text, out not1) == false)
    //    {
    //      MessageBox.Show("Not 1 girişi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    if (not1 < 0)
    //    {
    //      MessageBox.Show("Not 1 girişi 0'dan küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    if (not1 > 100)
    //    {
    //      MessageBox.Show("Not 1 girişi 100'den büyük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }

    //    //Not2
    //    if (byte.TryParse(txtNot2.Text, out not2) == false)
    //    {
    //      MessageBox.Show("Not 2 girişi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    if (not2 < 0)
    //    {
    //      MessageBox.Show("Not 2 girişi 0'dan küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    if (not2 > 100)
    //    {
    //      MessageBox.Show("Not 2 girişi 100'den büyük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }

    //    //Not3
    //    if (byte.TryParse(txtNot3.Text, out not3) == false)
    //    {
    //      MessageBox.Show("Not 3 girişi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    if (not3 < 0)
    //    {
    //      MessageBox.Show("Not 3 girişi 0'dan küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    if (not3 > 100)
    //    {
    //      MessageBox.Show("Not 3 girişi 100'den büyük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      return ogrenci;
    //    }
    //    #endregion


    //    // ogrenci veri doldur
    //    ogrenci = new OgrenciModel();
    //    ogrenci.Id = id;
    //    ogrenci.Ad = ad;
    //    ogrenci.Soyad = soyad;
    //    ogrenci.Sinif = sinif;
    //    ogrenci.Sube = sube;
    //    ogrenci.Numara = numara;
    //    ogrenci.Not1 = not1;
    //    ogrenci.Not2 = not2;
    //    ogrenci.Not3 = not3;
    //    ogrenci.Ortalama = (ogrenci.Not1 + ogrenci.Not2 + ogrenci.Not3) / 3;
    //    if (ogrenci.Ortalama > 49)
    //      ogrenci.Durum = true;
    //    else
    //      ogrenci.Durum = false;
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    return new OgrenciModel();
    //  }

    //  return ogrenci;
    //}





  }
}
