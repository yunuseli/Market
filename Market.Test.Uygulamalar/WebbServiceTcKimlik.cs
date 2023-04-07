using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Test.Uygulamalar
{
  public partial class WebbServiceTcKimlik : Form
  {
    public WebbServiceTcKimlik()
    {
      InitializeComponent();
    }

    private void WebbServiceTcKimlik_Load(object sender, EventArgs e)
    {

    }

    private async void btnTC_Click(object sender, EventArgs e)
    {
      try
      {
        long tc = 37099075954;
        string ad = "FUAT";
        string soyad = "AŞIK";
        int dyil = 1980;


        KimlikDogrulamaServisi.TCKimlikNoDogrulaResponse resp = 
          new KimlikDogrulamaServisi.TCKimlikNoDogrulaResponse();

        using (KimlikDogrulamaServisi.KPSPublicSoapClient servis = 
          new KimlikDogrulamaServisi.KPSPublicSoapClient(
            KimlikDogrulamaServisi.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
        {
          resp = await servis.TCKimlikNoDogrulaAsync(tc, ad, soyad, dyil);
        }

        MessageBox.Show(resp.Body.TCKimlikNoDogrulaResult.ToString());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
