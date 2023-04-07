using System.Data;
using System.Globalization;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Market.Presentation.WinUI.Forms.InfoForms
{
  public partial class WeatherInfo : Form
  {

    //https://collectapi.com/tr/


    public WeatherInfo()
    {
      InitializeComponent();
    }

    // https://openweathermap.org sitesinden kayıt olunarak bir alt satırdaki api kodu alınır
    private const string api = "b87d124450c2c1d68a146fceec3d1a63";
    // hava durumu bilgileri bir alt satırdaki web adresinden çekilecektir
    private const string baglanti = "http://api.openweathermap.org/data/2.5/weather?q=Turkey,Bursa&mode=xml&units=metric&APPID=" + api;

    private void WeatherInfo_Load(object sender, EventArgs e)
    {

    }
    private void btnGetData_Click(object sender, EventArgs e)
    {
      GetData();
    }
    private void GetData()
    {
      XDocument Hava = XDocument.Load(baglanti);
      var Sicaklik = Hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
      lblInfo.Text = "Sıcaklık : " + Sicaklik.ToString() + "°";

      var hava = Hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
      lblInfo.Text += "\nHava: " + hava.ToString();

      var bulut = Hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;
      lblInfo.Text += "\nBulut: " + bulut.ToString();

      var icon = Hava.Descendants("weather").ElementAt(0).Attribute("icon").Value;
      pbStatus.Load("http://openweathermap.org/img/w/" + icon + ".png");


    }

    private void btnTcmb_Click(object sender, EventArgs e)
    {
      DataSet ds = new DataSet();
      XmlDocument xmlDoc = new XmlDocument();
      xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

      // Xml içinden tarihi alma - gerekli olabilir
      DateTime exchangeDate = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
      string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
      string EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
      string POUND = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
      MessageBox.Show("Dolar Kuru : " + USD + "\nEuro Kuru : " + EURO, "Güncel Kur Bilgileri");



      var kurlar = XDocument
        .Load("http://www.tcmb.gov.tr/kurlar/today.xml")
        .Descendants("Currency")
        .Where(p => !string.IsNullOrEmpty(p.Element("ForexSelling").Value))
        .Select(p => new Kur
        {
          Kod = p.Attribute("Kod").Value,
          Ad = p.Element("Isim").Value,
          Alış = decimal.Parse(p.Element("ForexBuying").Value, CultureInfo.InvariantCulture),
          Satış = decimal.Parse(p.Element("ForexSelling").Value, CultureInfo.InvariantCulture)
        }).ToList();


      dataGridView1.DataSource = kurlar;
    }


    class Kur
    {
      public string Kod { get; set; }
      public string Ad { get; set; }
      public decimal Alış { get; set; }
      public decimal Satış { get; set; }
    }
  }
}
