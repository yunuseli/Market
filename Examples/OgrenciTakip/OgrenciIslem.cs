using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OgrenciTakip.Classes;
using OgrenciTakip.Enums;
using OgrenciTakip.Models;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Reflection;
using System.Windows.Forms;

namespace OgrenciTakip
{
  public partial class OgrenciIslem : Form
  {
    public OgrenciIslem()
    {
      InitializeComponent();
    }

    OgrenciClass ogrenciClass;
    //DataTable dtOgrenci;
    //KayitModlari kayitModu;


    //http://csharp.net-informations.com/datagridview/csharp-datagridview-filter.htm


    private void Form_Load(object sender, EventArgs e)
    {
      NesneDurum(NesneDurumlari.Form_Init);
    }

    void NesneDurum(NesneDurumlari durum)
    {
      switch (durum)
      {
        #region Form işlemleri
        // Form_Load olayından sonra tetiklenecek ve form ve gerekli nesneler üzerinde yapılacak işlemler
        case NesneDurumlari.Form_Init:
          Cursor.Current = Cursors.WaitCursor;

          ogrenciClass = new OgrenciClass();
          ogrenciClass.dtOgrenci = new System.Data.DataTable();
          ogrenciClass.TabloyuOlustur();
          gvListe.DataSource = ogrenciClass.dtOgrenci;
          GridHazirla();

          NesneDurum(NesneDurumlari.Form_Start);

          Cursor.Current = Cursors.Default;
          break;
        case NesneDurumlari.Form_Start:
          NesneDurum(NesneDurumlari.Form_Clear);

          toolTipInfo.SetToolTip(btnEkle, "Ekle");
          toolTipInfo.SetToolTip(btnDuzenle, "Düzenle");
          toolTipInfo.SetToolTip(btnSil, "Sil");
          toolTipInfo.SetToolTip(btnKaydet, "Kaydet");
          toolTipInfo.SetToolTip(btnIslemIptal, "İşlem İptal");

          NesneDurum(NesneDurumlari.Mod_Liste);

          this.WindowState = FormWindowState.Maximized;

          gvListe.EditMode = DataGridViewEditMode.EditProgrammatically;
          gvListe.ReadOnly = true;
          gvListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          gvListe.AllowUserToAddRows = false;


          gvListe.RowsDefaultCellStyle.BackColor = Color.Bisque;
          gvListe.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
          gvListe.CellBorderStyle = DataGridViewCellBorderStyle.None;
          gvListe.DefaultCellStyle.SelectionBackColor = Color.Red;
          gvListe.DefaultCellStyle.SelectionForeColor = Color.Yellow;
          gvListe.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
          gvListe.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


          break;
        case NesneDurumlari.Form_Stop:

          break;
        case NesneDurumlari.Form_Clear:
          NesneDurum(NesneDurumlari.KayitGirisNesneTemizle);
          break;
        case NesneDurumlari.Form_Refresh:

          break;
        #endregion

        #region Nesne işlemleri
        // Kayit veya listeleme işlemlerinde çağrılacak
        case NesneDurumlari.KayitGirisNesneTemizle:
          txtAd.Text = string.Empty;
          txtSoyad.Text = string.Empty;
          txtSinif.Text = string.Empty;
          txtSube.Text = string.Empty;
          txtNumara.Text = string.Empty;
          txtNot1.Text = string.Empty;
          txtNot2.Text = string.Empty;
          txtNot3.Text = string.Empty;
          lblOrtalama.Text = string.Empty;
          lblDurum.Text = string.Empty;
          break;
        case NesneDurumlari.KayitNesneAktif:
          //pnlIslem.Enabled = true;
          //pnlUst.Enabled = false;
          txtAd.ReadOnly = false;
          txtSoyad.ReadOnly = false;
          txtSinif.ReadOnly = false;
          txtSube.ReadOnly = false;
          txtNumara.ReadOnly = false;
          txtNot1.ReadOnly = false;
          txtNot2.ReadOnly = false;
          txtNot3.ReadOnly = false;
          btnDuzenle.Enabled = false;
          btnEkle.Enabled = false;
          btnSil.Enabled = false;
          btnKaydet.Enabled = true;
          btnIslemIptal.Enabled = true;
          break;
        case NesneDurumlari.KayitNesnePasif:
          //pnlIslem.Enabled = false;
          //pnlUst.Enabled = true;
          txtAd.ReadOnly = true;
          txtSoyad.ReadOnly = true;
          txtSinif.ReadOnly = true;
          txtSube.ReadOnly = true;
          txtNumara.ReadOnly = true;
          txtNot1.ReadOnly = true;
          txtNot2.ReadOnly = true;
          txtNot3.ReadOnly = true;
          btnDuzenle.Enabled = true;
          btnEkle.Enabled = true;
          btnSil.Enabled = true;
          btnKaydet.Enabled = false;
          btnIslemIptal.Enabled = false;
          break;
        #endregion

        #region Kayit Modu işlemleri
        case NesneDurumlari.Mod_Liste:
          NesneDurum(NesneDurumlari.KayitNesnePasif);
          break;
        case NesneDurumlari.Mod_Ekle:
          ogrenciClass.kayitModu = KayitModlari.Ekle;
          NesneDurum(NesneDurumlari.KayitNesneAktif);
          NesneDurum(NesneDurumlari.KayitGirisNesneTemizle);
          break;
        case NesneDurumlari.Mod_Duzenle:
          ogrenciClass.kayitModu = KayitModlari.Duzenle;
          NesneDurum(NesneDurumlari.KayitNesneAktif);
          break;
        case NesneDurumlari.Mod_Sil:

          break;
          #endregion
      }
    }

    void VeriDoldurEdit(OgrenciModel ogrenci)
    {
      if (ogrenci == null)
      {
        NesneDurum(NesneDurumlari.KayitGirisNesneTemizle);
        return;
      }

      txtAd.Text = ogrenci.Ad;
      txtSoyad.Text = ogrenci.Soyad;
      txtSinif.Text = ogrenci.Sinif;
      txtSube.Text = ogrenci.Sube;
      txtNumara.Text = ogrenci.Numara.ToString();
      txtNot1.Text = ogrenci.Not1.ToString();
      txtNot2.Text = ogrenci.Not2.ToString();
      txtNot3.Text = ogrenci.Not3.ToString();
      lblOrtalama.Text = ogrenci.Ortalama.ToString();
      lblDurum.Text = ogrenciClass.OgrenciDurum(ogrenci.Durum);
    }
    void GridHazirla()
    {
      gvListe.DataSource = ogrenciClass.dtOgrenci;

      DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
      gvListe.Columns.Insert(0, btn);
      btn.HeaderText = "İşlem";
      btn.Text = "Sil";
      btn.Name = "btn";
      btn.UseColumnTextForButtonValue = true;

      DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
      gvListe.Columns.Insert(1, chk);
      chk.HeaderText = "Seç";
      chk.Name = "chk";

      gvListe.Columns["Id"].ValueType = typeof(int);
      gvListe.Columns["Id"].HeaderText = "Kayıt No";

      gvListe.Columns["Ad"].HeaderText = "Ad";
      gvListe.Columns["Soyad"].HeaderText = "Soyad";
      gvListe.Columns["Sinif"].HeaderText = "Sınıf";
      gvListe.Columns["Sube"].HeaderText = "Şube";
      gvListe.Columns["Numara"].HeaderText = "Numara";

      gvListe.Columns["Not1"].HeaderText = "Not 1";
      gvListe.Columns["Not2"].HeaderText = "Not 2";
      gvListe.Columns["Not3"].HeaderText = "Not 3";
      gvListe.Columns["Not1"].DefaultCellStyle.Format = "N0";
      gvListe.Columns["Not2"].DefaultCellStyle.Format = "N0";
      gvListe.Columns["Not3"].DefaultCellStyle.Format = "N0";

      gvListe.Columns["Ortalama"].HeaderText = "Ortalama";
      gvListe.Columns["Ortalama"].DefaultCellStyle.Format = "#.#";

      gvListe.Columns["Durum"].Visible = false;

      gvListe.Columns["DurumTanim"].HeaderText = "Durum";



    }
    void GridVeriGoster()
    {
      gvListe.DataSource = ogrenciClass.dtOgrenci;
      VeriDoldurEdit(GridSeciliSatirOgrenci());
      GridVeriRenklendir();
    }
    void GridVeriRenklendir()
    {
      if (gvListe.Rows.Count == 0)
        return;

      foreach (DataGridViewRow row in gvListe.Rows)
      {
        if ((bool)row.Cells["Durum"].Value == true)
          row.DefaultCellStyle.BackColor = Color.LightSeaGreen;
        else
          row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
      }
    }
    void GridSecimTemizle()
    {
      //foreach (DataGridViewRow item in gvListe.SelectedRows)
      //  item.Selected = false;

      gvListe.ClearSelection();
      gvListe.CurrentCell = null;
    }
    void GridSecimTumunuSec()
    {
      gvListe.SelectAll();
    }
    bool GridSeciliSatirdaVeriVar()
    {
      if (gvListe.SelectedRows.Count < 1)
        return false;
      if (gvListe.CurrentCell == null)
        return false;

      return true;
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      // model 1
      //OgrenciModel yeniOgrenci = ogrenciClass.RasgeleOgrenciOlustur();
      //VeriDoldurEdit(yeniOgrenci);

      //model 2
      ogrenciClass.TabloyaVeriEkle(ogrenciClass.RasgeleOgrenciOlustur());
      GridVeriGoster();
    }

    private void gvListe_SelectionChanged(object sender, EventArgs e)
    {
      if (!GridSeciliSatirdaVeriVar()) return;

      VeriDoldurEdit(GridSeciliSatirOgrenci());
    }
    OgrenciModel GridSeciliSatirOgrenci()
    {
      OgrenciModel ogrenci = new OgrenciModel();

      if (!GridSeciliSatirdaVeriVar()) return null;

      try
      {
        ogrenci.Id = Convert.ToInt32(gvListe.SelectedRows[0].Cells["Id"].Value);
        ogrenci.Ad = gvListe.SelectedRows[0].Cells["Ad"].Value.ToString();
        ogrenci.Soyad = gvListe.SelectedRows[0].Cells["Soyad"].Value.ToString();
        ogrenci.Sinif = gvListe.SelectedRows[0].Cells["Sinif"].Value.ToString();
        ogrenci.Sube = gvListe.SelectedRows[0].Cells["Sube"].Value.ToString();
        ogrenci.Numara = Convert.ToUInt16(gvListe.SelectedRows[0].Cells["Numara"].Value);
        ogrenci.Not1 = Convert.ToByte(gvListe.SelectedRows[0].Cells["Not1"].Value);
        ogrenci.Not2 = Convert.ToByte(gvListe.SelectedRows[0].Cells["Not2"].Value);
        ogrenci.Not3 = Convert.ToByte(gvListe.SelectedRows[0].Cells["Not3"].Value);
        ogrenci.Ortalama = Convert.ToSingle(gvListe.SelectedRows[0].Cells["Ortalama"].Value);
        ogrenci.Durum = Convert.ToBoolean(gvListe.SelectedRows[0].Cells["Durum"].Value);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      return ogrenci;
    }
    private void gvListe_Sorted(object sender, EventArgs e)
    {
      GridVeriRenklendir();
    }
    private void gvListe_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 0)
      {
        //MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");

        GridSecimTemizle();

        gvListe.Rows[e.RowIndex].Selected = true;
        btnSil.PerformClick();
      }
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      NesneDurum(NesneDurumlari.Mod_Ekle);
    }
    private void btnDuzenle_Click(object sender, EventArgs e)
    {
      if (!GridSeciliSatirdaVeriVar()) return;

      NesneDurum(NesneDurumlari.Mod_Duzenle);
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      if (!GridSeciliSatirdaVeriVar())
      {
        MessageBox.Show("Seçim Yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (gvListe.SelectedRows.Count > 1)
      {
        MessageBox.Show("Aynı anda sedece tek satır silinebilir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      KayitSil();
    }
    void KayitSil()
    {
      try
      {
        OgrenciModel silinecekOgrenci = GridSeciliSatirOgrenci();
        if (MessageBox.Show(
          $"{silinecekOgrenci.Isim} adlı öğrenci silinecek\nEminmisiniz?", "Silme Onayı",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          if (MessageBox.Show(
                    $"Son kararınızmı", "Silme Onayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            foreach (DataRow row in ogrenciClass.dtOgrenci.Rows)
            {
              if (row["Id"].ToString() == silinecekOgrenci.Id.ToString())
              {
                row.Delete();
                break;
              }
            }

            GridVeriGoster();
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnIslemIptal_Click(object sender, EventArgs e)
    {
      NesneDurum(NesneDurumlari.Mod_Liste);
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      KayitIslemi();
    }
    void KayitIslemi()
    {
      CevapModel cevap = new CevapModel();

      if (ogrenciClass.kayitModu == KayitModlari.Ekle)
      {
        // // Model 1 : Form içindeki metot ile
        //OgrenciModel eklenecekOgrenci = KayitEdilecekOgrenci();
        //if (eklenecekOgrenci == null)
        //  return;
        //foreach (DataRow row in dtOgrenci.Rows)
        //{
        //  if (row["Numara"].ToString() == eklenecekOgrenci.Numara.ToString())
        //  {
        //    MessageBox.Show($"Bu numara kullanımda : {eklenecekOgrenci.Numara}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    return;
        //  }
        //}

        // Model 2 : Class içinden çok parametreli metot ve cevap model ile
        OgrenciModel eklenecekOgrenci = ogrenciClass.KayitEdilecekOgrenci(ogrenciClass.kayitModu, 0,
          txtAd.Text, txtSoyad.Text, txtSinif.Text, txtSube.Text,
          txtNumara.Text, txtNot1.Text, txtNot2.Text, txtNot3.Text, out cevap);
        if (cevap.Durum == CevapDurumlari.Hata)
        {
          MesajGoster(cevap);
          return;
        }

        //// Model 3 : Class içinden model parametreli metot ve cevap model ile
        //OgrenciModel eklenecekOgrenci = ogrenciClass.KayitEdilecekOgrenci(kayitModu, GirilenKayitVerisi(kayitModu), out cevap);
        //if (cevap.Durum == CevapDurumlari.Hata)
        //{
        //  MesajGoster(cevap);
        //  return;
        //}

        ogrenciClass.TabloyaVeriEkle(eklenecekOgrenci);
      }
      else
      {
        //OgrenciModel degisenOgrenci = KayitEdilecekOgrenci();
        //if (degisenOgrenci == null)
        //  return;

        OgrenciModel degisenOgrenci = ogrenciClass.KayitEdilecekOgrenci(ogrenciClass.kayitModu, GirilenKayitVerisi(ogrenciClass.kayitModu), out cevap);
        if (cevap.Durum == CevapDurumlari.Hata)
        {
          MesajGoster(cevap);
          return;
        }

        foreach (DataRow row in ogrenciClass.dtOgrenci.Rows)
        {

          if (row["Numara"].ToString() == degisenOgrenci.Numara.ToString() &&
          row["Id"].ToString() != degisenOgrenci.Id.ToString())
          {
            if (ogrenciClass.kayitModu == KayitModlari.Duzenle)
              break;

            MessageBox.Show($"Bu numara kullanımda : {degisenOgrenci.Numara}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
        }

        ogrenciClass.TabloVeriDegistir(degisenOgrenci);
      }

      NesneDurum(NesneDurumlari.Mod_Liste);
      GridVeriGoster();
      MesajGoster(cevap);
    }

    void MesajGoster(CevapModel cevap)
    {
      string mesaj = cevap.Mesaj;
      if (cevap.Kaynak != "")
      {
        mesaj += Environment.NewLine + Environment.NewLine + cevap.Kaynak;
      }

      switch (cevap.Durum)
      {
        case CevapDurumlari.Basarili:
        case CevapDurumlari.Bilgi:
          MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          break;
        case CevapDurumlari.Uyari:
          MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          break;
        case CevapDurumlari.Hata:
          MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
          break;
      }
    }

    KayitVeriModel GirilenKayitVerisi(KayitModlari kayitModu)
    {
      KayitVeriModel kayitVerisi = new KayitVeriModel();

      if (kayitModu == KayitModlari.Ekle)
        kayitVerisi.Id = ogrenciClass.RasgeleOgrenciOlustur().Id;
      else
        kayitVerisi.Id = GridSeciliSatirOgrenci().Id;
      kayitVerisi.Ad = txtAd.Text;
      kayitVerisi.Soyad = txtSoyad.Text;
      kayitVerisi.Sinif = txtSinif.Text;
      kayitVerisi.Sube = txtSube.Text;
      kayitVerisi.Numara = txtNumara.Text;
      kayitVerisi.Not1 = txtNot1.Text;
      kayitVerisi.Not2 = txtNot2.Text;
      kayitVerisi.Not3 = txtNot3.Text;

      return kayitVerisi;
    }



    private void DosyaAc(string path)
    {
      Process process = new Process();
      ProcessStartInfo processStartInfo = process.StartInfo;
      var prevWorking = Environment.CurrentDirectory;
      try
      {

        string pathF = path;
        while (pathF.Contains("\\"))
        {
          pathF = pathF.Remove(0, pathF.IndexOf("\\") + 1);
        }
        string pathP = path.Replace(pathF, "");

        //FileInfo myRelativeFileExe = new FileInfo(@"excel.exe");

        processStartInfo.FileName = pathF;
        processStartInfo.WorkingDirectory = pathP;
        processStartInfo.FileName = pathF;

        //proc.StartInfo.Arguments = "-v -s -a";
        Process.Start(processStartInfo);
        //proc.WaitForExit();
        //var exitCode = proc.ExitCode;
        //proc.Close();


        //Environment.CurrentDirectory = System.Windows.Forms.Application.StartupPath;
        //Environment.CurrentDirectory = System.Windows.Forms.Application.StartupPath;

        //processStartInfo.FileName= path;
        //Process.Start(processStartInfo);
        //  Process proc = new Process
        //  {
        //    StartInfo =
        //      {
        //         FileName =  exe,
        //         CreateNoWindow = true,
        //         RedirectStandardInput = true,
        //         WindowStyle = ProcessWindowStyle.Hidden,
        //         UseShellExecute = false,
        //         RedirectStandardError = true,
        //         RedirectStandardOutput = true,
        //         Arguments = args,
        //      }
        //  };

        //  proc.Start();
        //  proc.StandardInput.WriteLine(args);
        //  proc.StandardInput.Flush();
        //  proc.StandardInput.Close();

        //  return true;
        //}
        //finally
        //{

        //}


        // System.Diagnostics.Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\EXCEL.EXE");


        //var process = new Process
        //{
        //  StartInfo = new ProcessStartInfo
        //  {
        //    FileName = "C:\\Windows\\System32\\fsutil.exe",
        //    Arguments = "behavior query SymlinkEvaluation",
        //    UseShellExecute = false,
        //    RedirectStandardOutput = true,
        //    CreateNoWindow = true
        //  }
        //};

        //process.Start();

        //while (!process.StandardOutput.EndOfStream)
        //{
        //  var line = process.StandardOutput.ReadLine();
        //  Console.WriteLine(line);
        //}

        //process.WaitForExit();



        //Environment.CurrentDirectory = workingDir;
        // Process.Start(new ProcessStartInfo { FileName = "excel.exe" });
        //Process.Start(new ProcessStartInfo { FileName = "run.exe " + path, WorkingDirectory = Environment.CurrentDirectory });

        //////"excel.exe "
        //process.StartInfo.FileName = "RUN.EXE " + path;
        //process.Start();
        ////process.WaitForInputIdle();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        Environment.CurrentDirectory = prevWorking;
      }
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
      ExceleAktar(out CevapModel cevap);
    }
    void ExceleAktar(out CevapModel cevap)
    {
      cevap = new CevapModel();
      cevap.Durum = CevapDurumlari.Hata;
      cevap.Kaynak = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";

      try
      {
        System.Data.DataTable dataTable = ogrenciClass.dtOgrenci.Copy();
        string filePath = "";

        SaveFileDialog dialog = new SaveFileDialog();

        dialog.Filter = "Excel | *.xlsx";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          filePath = dialog.FileName;
        }
        if (string.IsNullOrEmpty(filePath))
        {
          cevap.Mesaj = "Dosya adı hatalı";
          MesajGoster(cevap);
        }
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        using (ExcelPackage p = new ExcelPackage())
        {
          p.Workbook.Properties.Author = "Ogrenci Takip";
          p.Workbook.Properties.Title = "Öğrenci Raporu";
          p.Workbook.Worksheets.Add("Ogrenciler");

          ExcelWorksheet ws = p.Workbook.Worksheets[0];

          ws.Name = "Ogrenciler";
          ws.Cells.Style.Font.Size = 12;
          ws.Cells.Style.Font.Bold = true;
          ws.Cells.Style.Font.Name = "Times New Roman";

          string[] arrColumnHeader = { "Ad", "Soyad", "Sınıf", "Şube", "Numara", "Not1", "Not2", "Not3", "Ortalama", "Durum" };
          var countColHeader = arrColumnHeader.Count();
          ws.Cells[1, 1].Value = "Öğrenci Listesi";
          ws.Cells[1, 1, 1, countColHeader].Merge = true;
          ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
          int colHeader = 1;
          int rowHeader = 2;
          foreach (var header in arrColumnHeader)
          {
            var cell = ws.Cells[rowHeader, colHeader];

            var fill = cell.Style.Fill;
            fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

            cell.Value = header;
            colHeader++;
          }

          int colIndex = 1;
          int rowIndex = 2;

          foreach (DataRow dr in dataTable.Rows)
          {
            Color c;
            if ((bool)dr["Durum"] == true)
              c = Color.LightSeaGreen;
            else
              c = Color.MediumVioletRed;

            colIndex = 1;
            rowIndex++;
            ws.Cells[rowIndex, colIndex++].Value = dr["Ad"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["Soyad"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["Sinif"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["Sube"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["Numara"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["Not1"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["Not2"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["Not3"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["Ortalama"].ToString();
            ws.Cells[rowIndex, colIndex++].Value = dr["DurumTanim"].ToString();


            for (int i = 1; i < 11; i++)
            {
              ws.Cells[rowIndex, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
              ws.Cells[rowIndex, i].Style.Fill.BackgroundColor.SetColor(c);
            }

          }
          Byte[] bin = p.GetAsByteArray();
          File.WriteAllBytes(filePath, bin);

          //DosyaAc(dialog.FileName);
        }
      }
      catch (Exception ex)
      {
        cevap.Mesaj = ex.Message;
        return;
      }

      //copyAlltoClipboard();
    }
    private void copyAlltoClipboard()
    {
      gvListe.SelectAll();
      DataObject dataObj = gvListe.GetClipboardContent();
      if (dataObj != null)
        Clipboard.SetDataObject(dataObj);
    }



    private void btnAra_Click(object sender, EventArgs e)
    {
      if (txtFiltre.Text.Length == 0)
        return;

      GridSecimTemizle();

      foreach (DataGridViewRow gRow in gvListe.Rows)
      {
        foreach (DataGridViewCell gCell in gRow.Cells)
        {
          if (gCell.Value.ToString().ToLower().Contains(txtFiltre.Text.ToLower()))
          {
            gRow.Selected = true;
            break;
          }
        }
      }
    }

    private void btnSecimiTemizle_Click(object sender, EventArgs e)
    {
      GridSecimTemizle();
    }
    private void btnTumunuSec_Click(object sender, EventArgs e)
    {
      GridSecimTumunuSec();
    }

    private void btnYazdir_Click(object sender, EventArgs e)
    {
      //  printDocument.Print();

      // Allow the user to choose the page range he or she would
      // like to print.
      printDialog.AllowSomePages = true;

      // Show the help button.
      printDialog.ShowHelp = true;


      // Set the Document property to the PrintDocument for 
      // which the PrintPage Event has been handled. To display the
      // dialog, either this property or the PrinterSettings property 
      // must be set 
      printDialog.Document = printDocument;

      DialogResult result = printDialog.ShowDialog();

      // If the result is OK then print the document.
      if (result == DialogResult.OK)
      {
        printDocument.Print();
      }
    }

    private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
      //e.Graphics.DrawEllipse(Pens.Red, e.MarginBounds);
      //System.Drawing.Drawing2D.GraphicsPath grYol = new System.Drawing.Drawing2D.GraphicsPath();
      //grYol.AddRectangle(new System.Drawing.Rectangle(280, 280, 300, 450));
      //e.Graphics.DrawPath(Pens.Yellow, grYol);
      //e.HasMorePages = false;

      Bitmap bm = new Bitmap(this.gvListe.Width, this.gvListe.Height);
      gvListe.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.gvListe.Width, this.gvListe.Height));
    
      e.Graphics.DrawImage(bm, 0, 0);
      e.Graphics.ScaleTransform(100, 100);

      //https://learn.microsoft.com/tr-tr/dotnet/api/system.drawing.printing.printdocument.printpage?view=dotnet-plat-ext-7.0
    }

    private void btnYazdirOnizle_Click(object sender, EventArgs e)
    {
      //string docName = "testPage.txt";
      //string docPath = @"C:\";
      //string fullPath = System.IO.Path.Combine(docPath, docName);
      //printDocument.DocumentName = docName;
      //string stringToPrint = System.IO.File.ReadAllText(fullPath);


      PrintDialog pd = new PrintDialog();
      PrintDocument pdoc = new PrintDocument();
      PaperSize ps = new PaperSize();
      ps.RawKind = (int)PaperKind.A4;
      pdoc.DefaultPageSettings.PaperSize = ps;
      pdoc.DefaultPageSettings.Landscape = true;

      pdoc.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);


      //int w = Convert.ToInt32(Length / 2.54) * 100;
      //int h = Convert.ToInt32(Width / 2.54) * 100;
      //PaperSize psize = new PaperSize("Custom", w, h);
      //pdoc.DefaultPageSettings.PaperSize = psize;

      pd.Document = pdoc;
      if (pd.ShowDialog() == DialogResult.OK)
      {
        PrintPreviewDialog ppd = new PrintPreviewDialog();
        ppd.Document = pdoc;
        ppd.PrintPreviewControl.Zoom = 1.0;
        ((Form)ppd).WindowState = FormWindowState.Maximized;
        DialogResult ppdResult = ppd.ShowDialog();
        // if i comment the above  line and uncomment pdoc.Print(); i can save the print as pdf.
        // pdoc.Print();
      }


      //printPreviewDialog.Document = printDocument;

      //if (printPreviewDialog.ShowDialog() == DialogResult.OK)
      //{
      //  printDocument.Print();
      //}
    }

    private void btnYazdirAyar_Click(object sender, EventArgs e)
    {
      //pageSetupDialog.ShowDialog();
    }
  } // Form Sonu
}
