using System.IO.Ports;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Market.Otomasyon
{
  public partial class SeriPort : Form
  {
    public SeriPort()
    {
      InitializeComponent();
    }

    SerialPort serialPort;

    private void SeriPort_Load(object sender, EventArgs e)
    {
      serialPort = new SerialPort();
      serialPort.DataReceived +=
        new System.IO.Ports.SerialDataReceivedEventHandler(
          SerialPort_DataReceived);

      btnBaglan.BackColor = Color.Yellow;

      timerSorgula.Interval = 1000;
      timerSorgula.Stop();
      cbOku.Enabled = false;
      cbOku.Checked = false;
      btnOku.Enabled = false;
      btnYaz.Enabled = false;

      pbG1.BackColor = Color.White;
      pbG2.BackColor = Color.White;
      pbG3.BackColor = Color.White;
      pbG4.BackColor = Color.White;
      pbC1.BackColor = Color.White;
      pbC2.BackColor = Color.White;
      pbC3.BackColor = Color.White;
      pbC4.BackColor = Color.White;

    }

    private void btnOku_Click(object sender, EventArgs e)
    {
      serialPort.Write("DRM?");
      // MessageBox.Show(serialPort.ReadLine());

    }

    private void btnBaglan_Click(object sender, EventArgs e)
    {
      try
      {
        if (btnBaglan.BackColor == Color.Green)
        {
          if (serialPort.IsOpen)
            serialPort.Close();

          btnBaglan.BackColor = Color.Yellow;

          timerSorgula.Stop();
          cbOku.Enabled = false;
          cbOku.Checked = false;
          btnOku.Enabled = false;
          btnYaz.Enabled = false;

          return;
        }

        serialPort.BaudRate = 9600;
        serialPort.DataBits = 8;
        serialPort.Parity = Parity.None;
        serialPort.StopBits = StopBits.One;
        serialPort.PortName = txtComPort.Text;


        if (!serialPort.IsOpen)
          serialPort.Open();

        cbOku.Enabled = true;
        btnOku.Enabled = true;
        btnYaz.Enabled = true;

        btnBaglan.BackColor = Color.Green;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
    {
      DataReceived();
    }
    private void DataReceived()
    {
      try
      {
        if (pbComPort.BackColor == Color.Yellow)
          pbComPort.BackColor = Color.Blue;
        else if (pbComPort.BackColor == Color.Blue)
          pbComPort.BackColor = Color.Gray;
        else
          pbComPort.BackColor = Color.Yellow;

        //MessageBox.Show(serialPort.ReadExisting());
        string okunanBilgi = serialPort.ReadLine();

        if (okunanBilgi.StartsWith("DRM"))
          BilgiGoster(okunanBilgi);

        if (okunanBilgi.StartsWith("PASS"))
        {
          MessageBox.Show(okunanBilgi.Replace("PASS", ""));
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    private void BilgiGoster(string okunanBilgi)
    {
      try
      {
        if (okunanBilgi.Length < 11)
          return;

        okunanBilgi = okunanBilgi.Remove(0, 3);

        // Girişler
        if (okunanBilgi.Substring(0, 1) == "1")
          pbG1.BackColor = Color.Blue;
        else
          pbG1.BackColor = Color.White;
        if (okunanBilgi.Substring(1, 1) == "1")
          pbG2.BackColor = Color.Blue;
        else
          pbG2.BackColor = Color.White;
        if (okunanBilgi.Substring(2, 1) == "1")
          pbG3.BackColor = Color.Blue;
        else
          pbG3.BackColor = Color.White;
        if (okunanBilgi.Substring(3, 1) == "1")
          pbG4.BackColor = Color.Blue;
        else
          pbG4.BackColor = Color.White;


        //Ledler
        if (okunanBilgi.Substring(4, 1) == "1")
          pbC1.BackColor = Color.Red;
        else
          pbC1.BackColor = Color.White;
        if (okunanBilgi.Substring(5, 1) == "1")
          pbC2.BackColor = Color.Red;
        else
          pbC2.BackColor = Color.White;
        if (okunanBilgi.Substring(6, 1) == "1")
          pbC3.BackColor = Color.Red;
        else
          pbC3.BackColor = Color.White;
        if (okunanBilgi.Substring(7, 1) == "1")
          pbC4.BackColor = Color.Red;
        else
          pbC4.BackColor = Color.White;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void BilgiGoster22(string okunanBilgi)
    {
      try
      {
        if (okunanBilgi.Length < 11)
          return;

        okunanBilgi = okunanBilgi.Remove(0, 3);

        // Girişler
        if (okunanBilgi.Substring(0, 1) == "1")
          pbG1.BackColor = Color.Blue;
        else
          pbG1.BackColor = Color.White;
        if (okunanBilgi.Substring(1, 1) == "1")
          pbG2.BackColor = Color.Blue;
        else
          pbG2.BackColor = Color.White;
        if (okunanBilgi.Substring(2, 1) == "1")
          pbG3.BackColor = Color.Blue;
        else
          pbG3.BackColor = Color.White;
        if (okunanBilgi.Substring(3, 1) == "1")
          pbG4.BackColor = Color.Blue;
        else
          pbG4.BackColor = Color.White;


        //Ledler
        if (okunanBilgi.Substring(4, 1) == "1")
          pbC1.BackColor = Color.Red;
        else
          pbC1.BackColor = Color.White;
        if (okunanBilgi.Substring(5, 1) == "1")
          pbC2.BackColor = Color.Red;
        else
          pbC2.BackColor = Color.White;
        if (okunanBilgi.Substring(6, 1) == "1")
          pbC3.BackColor = Color.Red;
        else
          pbC3.BackColor = Color.White;
        if (okunanBilgi.Substring(7, 1) == "1")
          pbC4.BackColor = Color.Red;
        else
          pbC4.BackColor = Color.White;


        //pbC1.BackColor = Color.White;
        //pbC2.BackColor = Color.White;
        //pbC3.BackColor = Color.White;
        //pbC4.BackColor = Color.White;

        //PLC_HamData += csINFO.COMPORT.SerialPort.ReadExisting();

        //if (!PLC_HamData.Contains(csINFO.PLC.SATIRSONUKARAKTERI))
        //{
        //  tmrComWaiting.Stop();
        //  tmrComWaiting.Start();
        //  SerialPortData_ListeyeEkle(clfBPOrtal.URT.csVTMAKINAPLC.ENUMS.Mesaj.SeriPortMesajYonu.Gelen, $"{PLC_HamData} [Veri Seti Eksik]");
        //  return;
        //}

        //PLC_TemizData = PLC_HamData.Replace(csINFO.PLC.SATIRSONUKARAKTERI, "").Trim();
        //if (PLC_TemizData == "")
        //{
        //  SerialPortData_ListeyeEkle(clfBPOrtal.URT.csVTMAKINAPLC.ENUMS.Mesaj.SeriPortMesajYonu.Gelen, $"{PLC_HamData} [Veri Seti Boş]");
        //  return;
        //}

        //SerialPortData_ListeyeEkle(clfBPOrtal.URT.csVTMAKINAPLC.ENUMS.Mesaj.SeriPortMesajYonu.Gelen, $"{PLC_HamData} [Veri Seti Tamamlandı]");

        //PLC_HamData = "";

        //if (Uretim_DevamEdiyor)
        //{
        //  SerialPortData_ListeyeEkle(clfBPOrtal.URT.csVTMAKINAPLC.ENUMS.Mesaj.SeriPortMesajYonu.Gelen, $"{PLC_TemizData} [Üretim Kaydı Devam Ediyor]");

        //  #region Mail Uyarı --- Hatalar bitince silinecek
        //  csAPP.mail_GONDER_ADMINERR(cn, "İşlem Hatası", "DataReceived", "Sistem Hatası (sp1_DataReceived.UretimKaydiDevamEdiyor)", $"Üretim işlemi devam ederken seri porttan veri geldi - [{PLC_TemizData}]", "", cevrimdekiSERINO, PLC_TemizData);
        //  #endregion

        //  return;
        //}

        //KONTROL(PLC_TemizData);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }


    private void timerSorgula_Tick(object sender, EventArgs e)
    {
      //serialPort.Write("DRM?");
      SeriPortYaz("DRM?");
    }

    private void cbOku_CheckedChanged(object sender, EventArgs e)
    {
      if (cbOku.Checked)
      {
        timerSorgula.Start();
      }
      else
      {
        timerSorgula.Stop();
      }
    }

    private void btnYaz_Click(object sender, EventArgs e)
    {
      SeriPortYaz(txtData.Text);
    }
    private void SeriPortYaz(string data)
    {
      try
      {
        serialPort.WriteLine(data);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }



    private void btnDosyaOku_Click(object sender, EventArgs e)
    {

      string filename = "";

      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog() != DialogResult.OK)
      {
        //txtDosya.Text = File.ReadAllText(ofd.FileName);

        MessageBox.Show("hata");
        return;
      }
      string[] satirlar = File.ReadAllLines(ofd.FileName);
      foreach (string item in satirlar)
      {
        string[] linesOfStr = item.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
      }

      //// using (StreamReader sr = new StreamReader(Application.StartupPath + "\\abc\\cde.txt", Encoding.UTF8))
      //string txtStr = "";
      //using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.UTF8))
      //  txtStr = sr.ReadToEnd();
      //string[] linesOfStr = txtStr.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

    }

    private void btnDosyaLed_Click(object sender, EventArgs e)
    {
      ////string[] array = txtDosya.Text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      ////foreach (string item in array)
      ////  Console.WriteLine(item);


      //using (var reader = new StringReader(txtDosya.Text))
      //{
      //  for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
      //  {
      //    SeriPortYaz("LED" + line);
      //    // Thread.Sleep(300);
      //    // DataReceived();
      //    string okunanBilgi = "";
      //    while (okunanBilgi == "")
      //    {
      //      okunanBilgi = serialPort.ReadLine();
      //    }
      //  }
      //}
    }

    private void btnDosyaKayit_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfd = new SaveFileDialog();
      if (sfd.ShowDialog() == DialogResult.OK)
      {
        //StreamWriter Kayit = new StreamWriter(sfd.FileName);
        //Kayit.WriteLine(txtDosya.Text);
        //Kayit.Close();

        File.WriteAllText(sfd.FileName, txtDosya.Text);
      }
    }
  }
}
