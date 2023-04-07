using System;

namespace Ornekler.Projeler.DatetimeOrnekler
{
  public partial class YasHesaplama : Form
  {
    public YasHesaplama()
    {
      InitializeComponent();
    }

    private void YasHesaplama_Load(object sender, EventArgs e)
    {
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

      lblYas.Text = "";
      lblGun.Text = "";
      lblDogumGunu.Text = "";

      pictureBoxDogumGunu.Visible = false;
    }

    private void btnHesapla_Click(object sender, EventArgs e)
    {
      DateTime dogumTarihiGiris = dateTimePicker1.Value;
      DateTime dogumTarihi = Convert.ToDateTime(dogumTarihiGiris.ToShortDateString());
      DateTime suAnkiZaman = Convert.ToDateTime(DateTime.Now.ToShortDateString());

      if (dogumTarihi >= suAnkiZaman)
      {
        MessageBox.Show("! Doğum tarihi bu gün veya sonrası olamaz");
        dateTimePicker1.Value = DateTime.Now.AddDays(-1);

        lblYas.Text = "";
        lblGun.Text = "";
        lblDogumGunu.Text = "";
        return;
      }
      //if (dogumTarihi >= suAnkiZaman.AddYears(-1))
      //{
      //  MessageBox.Show("! Bu yaşta bu zeka, :) büyüksün");
      //}

      TimeSpan fark = suAnkiZaman - dogumTarihi;
      lblGun.Text = fark.Days.ToString();

      int yasYil = suAnkiZaman.Year - dogumTarihi.Year;
      if (dogumTarihi.Month > suAnkiZaman.Month ||
             (suAnkiZaman.Month == dogumTarihi.Month && dogumTarihi.Day > suAnkiZaman.Day))
        yasYil--;

      int yasAy = suAnkiZaman.Month - dogumTarihi.Month;
      if (yasAy < 0)
        yasAy = 12 + yasAy;

      int yasGun = suAnkiZaman.Day - dogumTarihi.Day;
      if (yasGun < 0)
      {
        DateTime newNow = suAnkiZaman.AddMonths(-1);
        yasGun += (int)(suAnkiZaman - newNow).TotalDays;
      }
      lblYas.Text = $" {yasYil} yıl {yasAy} ay {yasGun} gün";

      DateTime birSonrakiDogumGunu;
      if (dogumTarihi.Month > suAnkiZaman.Month ||
            (suAnkiZaman.Month == dogumTarihi.Month && dogumTarihi.Day > suAnkiZaman.Day))
      {
        birSonrakiDogumGunu = new DateTime(suAnkiZaman.Year, dogumTarihi.Month, dogumTarihi.Day);
      }
      else
      {
        birSonrakiDogumGunu =
          new DateTime(suAnkiZaman.AddYears(1).Year, dogumTarihi.Month, dogumTarihi.Day);
      }
      lblDogumGunu.Text =
        $"{birSonrakiDogumGunu.ToShortDateString()} - Kalan {(birSonrakiDogumGunu - suAnkiZaman).Days.ToString()} gün";

      if (dogumTarihi.Day == suAnkiZaman.Day && dogumTarihi.Month == suAnkiZaman.Month)
        pictureBoxDogumGunu.Visible = true;
      else
        pictureBoxDogumGunu.Visible = false;

    }
  }
}
