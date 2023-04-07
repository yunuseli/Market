using System.Collections;

namespace AynilariBulma
{
  public partial class AynilariBul : Form
  {
    public AynilariBul()
    {
      InitializeComponent();
    }

    int butonBasimSayac = 0;
    string butonBasim1 = "";
    string butonBasim2 = "";
    int bulunanSayac = 0;
    int toplamBasim = 0;
    int toplamHata = 0;

    private void Form_Load(object sender, EventArgs e)
    {
      comboBoxBoyut.Items.AddRange(new object[] { "2x2", "2x3", "3x4", "4x4", "5x6", "6x6", "7x6" });
      comboBoxBoyut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      comboBoxBoyut.Text = "Seçiniz";
      labelMesaj.Text = "Hadi baþlayýn";
      labelMesaj.BackColor = Color.White;
    }

    private void buttonBaslat_Click(object sender, EventArgs e)
    {
      // Boyut seçili deðilse hata ver
      if (comboBoxBoyut.SelectedIndex < 0)
      {
        MessageBox.Show("Boyut Seçiniz");
        return;
      }

      // Sýfýrla
      if (panelOrta.Controls.Count > 0)
        panelOrta.Controls.Clear();
      listBoxLog.Items.Clear();
      labelMesaj.Text = "Butunlara basarak oynayabilirsiniz";
      labelMesaj.BackColor = Color.Yellow;
      butonBasimSayac = 0;
      butonBasim1 = "";
      butonBasim2 = "";
      bulunanSayac = 0;
      toplamBasim = 0;
      toplamHata = 0;
      labelToplamBasim.Text = toplamBasim.ToString();
      labelToplamHata.Text = toplamHata.ToString();

      // Boyut Belirle
      string boyut = comboBoxBoyut.SelectedItem.ToString();
      string[] boyutlar = boyut.Split('x', StringSplitOptions.RemoveEmptyEntries);
      int boyutYukseklik = Convert.ToInt32(boyutlar[0]);
      int boyutGenislik = Convert.ToInt32(boyutlar[1]);

      Random rnd = new Random();

      // Boyuta göre random harfleri oluþtur
      // ascii tablosu 48-93 arasý / 0 - ] // sayýlar, büyük harfler, bazý özel karakterler - 46 adet
      int toplamUretilecekKarakter = (boyutYukseklik * boyutGenislik) / 2;
      byte[] karakterListesi = new byte[toplamUretilecekKarakter];
      for (int i = 0; i < toplamUretilecekKarakter; i++)
      {
        byte rastgele = (byte)rnd.Next(48, 94);
        while (karakterListesi.Contains(rastgele))
        {
          rastgele = (byte)rnd.Next(48, 94);
        }
        karakterListesi[i] = rastgele;
      }

      // elde edilen harf listesinden, her karakterden 2 adet olacak þekilde
      // toplam buton sayýsý kadar rasgele yerleþmiþ yeni liste oluþtur
      int toplamButonSayisi = boyutYukseklik * boyutGenislik;
      string[] butonHarfListesi = new string[toplamButonSayisi];
      for (int i = 0; i < toplamButonSayisi / 2; i++)
      {
        string rastgeleHarf = Convert.ToChar(karakterListesi[rnd.Next(0, toplamUretilecekKarakter)]).ToString();
        while (butonHarfListesi.Contains(rastgeleHarf))
        {
          rastgeleHarf = Convert.ToChar(karakterListesi[rnd.Next(0, toplamUretilecekKarakter)]).ToString();
        }

        int konum1 = rnd.Next(0, toplamButonSayisi);
        while (!String.IsNullOrEmpty(butonHarfListesi[konum1]))
        {
          konum1 = rnd.Next(0, toplamButonSayisi);
        }
        butonHarfListesi[konum1] = rastgeleHarf;

        int konum2 = rnd.Next(0, toplamButonSayisi);
        while (!String.IsNullOrEmpty(butonHarfListesi[konum2]))
        {
          konum2 = rnd.Next(0, toplamButonSayisi);
        }
        butonHarfListesi[konum2] = rastgeleHarf;
      }

      // elde edilen harf listesi ile buton oluþtur ve panele ekle
      int harfSayac = 0;
      int butonTop = 10;
      int butonLeft = 10;
      for (int i = 0; i < boyutYukseklik; i++)
      {
        for (int j = 0; j < boyutGenislik; j++)
        {
          Button btn = new Button();
          btn.Name = $"button{i}{j}";
          btn.Text = "";
          btn.Tag = butonHarfListesi[harfSayac];
          btn.Height = 50;
          btn.Width = 50;
          btn.BackColor = Color.White;
          btn.Top = butonTop;
          btn.Left = butonLeft;
          btn.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
          btn.Click += new System.EventHandler(buttonBul_Click);
          panelOrta.Controls.Add(btn);

          harfSayac++;
          butonLeft += 53;
        }
        butonLeft = 10;
        butonTop += 53;
      }

    }

    private void buttonBul_Click(object sender, EventArgs e)
    {
      toplamBasim++;
      labelToplamBasim.Text = toplamBasim.ToString();

      Button btnSonBasilan = sender as Button;
      if (butonBasimSayac == 0)
      {
        butonBasim1 = btnSonBasilan.Tag.ToString();
        btnSonBasilan.Text = butonBasim1;
        btnSonBasilan.Enabled = false;
        btnSonBasilan.BackColor = Color.Turquoise;
        butonBasimSayac++;
        listBoxLog.Items.Insert(0, $"{btnSonBasilan.Name}/sayac:{butonBasimSayac}/karakter:{butonBasim1}");

        labelMesaj.Text = "Bir seçim daha yapýnýz";
        labelMesaj.BackColor = Color.LightYellow;

        return;
      }
      else if (butonBasimSayac == 1)
      {
        butonBasim2 = btnSonBasilan.Tag.ToString();
        btnSonBasilan.Text = butonBasim2;
        btnSonBasilan.Enabled = false;
        butonBasimSayac++;
        listBoxLog.Items.Insert(0, $"{btnSonBasilan.Name}/sayac:{butonBasimSayac}/karakter:{butonBasim1}");

        if (butonBasim2 == butonBasim1)
        {
          labelMesaj.Text = $"Tebrikler, buldunuz : {butonBasim2}";
          labelMesaj.BackColor = Color.AliceBlue;
          listBoxLog.Items.Insert(0, $"Tebrikler, buldunuz : {butonBasim2}");
          btnSonBasilan.BackColor = Color.Turquoise;
          butonBasimSayac = 0;
          bulunanSayac++;
          if (bulunanSayac == panelOrta.Controls.Count / 2)
          {
            labelMesaj.Text = "Tebrikler, tamaladýnýz";
            labelMesaj.BackColor = Color.GreenYellow;
            listBoxLog.Items.Insert(0, $"Tebrikler, tamaladýnýz");
          }
          return;
        }
        else
        {
          labelMesaj.Text = $"Bulamadýnýz, farklý seçimler : {butonBasim2} - {butonBasim1}";
          labelMesaj.BackColor = Color.OrangeRed;
          listBoxLog.Items.Insert(0, $"Bulamadýnýz, farklý seçimler : {butonBasim2} - {butonBasim1}");
          btnSonBasilan.BackColor = Color.PaleVioletRed;
          toplamHata++;
          labelToplamHata.Text=toplamHata.ToString(); 
          return;
        }
      }
      else
      {
        foreach (Button item in panelOrta.Controls)
        {
          if (item.Text == butonBasim1 || item.Text == butonBasim2)
          {
            Button b = panelOrta.Controls.Find(item.Name, false)[0] as Button;
            b.Text = "";
            b.Enabled = true;
            b.BackColor = Color.White;
          }
        }

        butonBasimSayac = 0;
        butonBasim2 = "";

        butonBasim1 = btnSonBasilan.Tag.ToString();
        btnSonBasilan.Text = butonBasim1;
        btnSonBasilan.Enabled = false;
        btnSonBasilan.BackColor = Color.Turquoise;
        butonBasimSayac++;
        listBoxLog.Items.Insert(0, $"{btnSonBasilan.Name}/sayac:{butonBasimSayac}/karakter:{butonBasim1}");

        labelMesaj.Text = "Bir seçim daha yapýnýz";
        labelMesaj.BackColor = Color.LightYellow;

        return;
      }
    }


  } // Form Sonu
}