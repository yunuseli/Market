using Market.Business.Classes.MarketUserManagers;
using Market.Entity.Classes.DbClasses.UserClasses;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using Market.Presentation.WinUI.Classes.HelperClasses;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Reflection;

namespace Market.Presentation.WinUI.Forms.MarketUserForms
{
  public partial class MarketUserList : Form
  {
    public MarketUserList()
    {
      InitializeComponent();
    }

    // Lokal Nesneler - Değişkenler
    ResultObject result;
    MarketUserManager marketUserManager;
    List<MarketUser> users;

    private void MarketUserList_Load(object sender, EventArgs e)
    {
      StartSettings();

      ListUsers();
    }
    void StartSettings()
    {
      result = new ResultObject();
      marketUserManager = new MarketUserManager();
      users = new List<MarketUser>();

      //gvList.ContextMenuStrip = cmsGrid;
    }

    private void buttonList_Click(object sender, EventArgs e)
    {
      ListUsers();
    }
    void ListUsers()
    {
      string resultOrigin = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";

      try
      {
        // Kullanıcı Listesini çek
        users = marketUserManager.MarketUserList(out result, false, true);
        if (result.ResultStatus != ResultStatus.Success)
        {
          result.OriginProcess += $"\n{resultOrigin}";
          ShowMessage.MesajGoster(result);
          return;
        }

        ListFillAndFormat();
      }
      catch (Exception ex)
      {
        result.Title = "Kullanıcı Listeleme";
        result.ResultStatus = ResultStatus.Error;
        result.Message = "! İşlem hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }
    void ListFillAndFormat()
    {
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Listeleme";

      try
      {
        gvList.DataSource = users;

        //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        //gvList.Columns.Insert(0, btn);
        //btn.HeaderText = "İşlem";
        //btn.Text = "Sil";
        //btn.Name = "btn";
        //btn.UseColumnTextForButtonValue = true;

        //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        //gvList.Columns.Insert(1, chk);
        //chk.HeaderText = "Seç";
        //chk.Name = "chk";

        //gvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //gvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //gvList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        gvList.EditMode = DataGridViewEditMode.EditProgrammatically;
        gvList.ReadOnly = true;
        gvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gvList.AllowUserToAddRows = false;



        //gvList.RowsDefaultCellStyle.BackColor = Color.Bisque;
        //gvList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        //gvList.CellBorderStyle = DataGridViewCellBorderStyle.None;
        //gvList.DefaultCellStyle.SelectionBackColor = Color.Red;
        //gvList.DefaultCellStyle.SelectionForeColor = Color.Yellow;
        //gvList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        gvList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        gvList.RowTemplate.Height = 50;

        gvList.AutoGenerateColumns = false;

        int displayIndex = 0;

        gvList.Columns["Id"].ValueType = typeof(int);
        gvList.Columns["Id"].HeaderText = "Kayıt No";
        gvList.Columns["Id"].DisplayIndex = displayIndex++;

        gvList.Columns["CreatedOn"].HeaderText = "Oluşturma";
        gvList.Columns["CreatedOn"].DisplayIndex = displayIndex++;
        gvList.Columns["CreatedBy"].HeaderText = "Oluşturan";
        gvList.Columns["CreatedBy"].DisplayIndex = displayIndex++;
        gvList.Columns["LastModifiedOn"].HeaderText = "Düzenleme";
        gvList.Columns["LastModifiedOn"].DisplayIndex = displayIndex++;
        gvList.Columns["LastModifiedBy"].HeaderText = "Düzenleyen";
        gvList.Columns["LastModifiedBy"].DisplayIndex = displayIndex++;

        gvList.Columns["Name"].HeaderText = "Ad";
        gvList.Columns["Name"].DisplayIndex = displayIndex++;
        gvList.Columns["SurName"].HeaderText = "Soyad";
        gvList.Columns["SurName"].DisplayIndex = displayIndex++;

        gvList.Columns["EMail"].HeaderText = "Email";
        gvList.Columns["EMail"].DisplayIndex = displayIndex++;

        gvList.Columns["BirthDate"].HeaderText = "Doğum Tarihi";
        gvList.Columns["BirthDate"].DisplayIndex = displayIndex++;

        gvList.Columns["ImageBytes"].HeaderText = "Resim";
        gvList.Columns["ImageBytes"].DisplayIndex = displayIndex++;
        gvList.Columns["ImageBytes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        gvList.Columns["ImageBytes"].Width = 50;
        ((DataGridViewImageColumn)gvList.Columns["ImageBytes"]).ImageLayout = DataGridViewImageCellLayout.Stretch;


        gvList.Columns["IsDeleted"].Visible = false;
        gvList.Columns["IsActive"].Visible = false;
        gvList.Columns["FullName"].Visible = false;
        gvList.Columns["Password"].Visible = false;
        gvList.Columns["ImageType"].Visible = false;
        gvList.Columns["IsDeleted"].DisplayIndex = displayIndex++;
        gvList.Columns["IsActive"].DisplayIndex = displayIndex++;
        gvList.Columns["FullName"].DisplayIndex = displayIndex++;
        gvList.Columns["Password"].DisplayIndex = displayIndex++;
        gvList.Columns["ImageType"].DisplayIndex = displayIndex++;


        if (gvList.Rows.Count > 0)
          gvList.Rows[0].Selected = true;
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = "! İşlem hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }

    void SelectGridRowById(int id)
    {
      //foreach (DataGridViewRow item in gvListe.SelectedRows)
      //  item.Selected = false;

      gvList.ClearSelection();
      gvList.CurrentCell = null;

      foreach (DataGridViewRow row in gvList.Rows)
      {
        if (row.Cells["Id"].Value.ToString() == id.ToString())
        {
          row.Selected = true;
          break;
        }
      }
    }
    void SelectGridRowByPreviusIndex(int index)
    {
      gvList.ClearSelection();
      gvList.CurrentCell = null;

      if (gvList.Rows.Count == 0)
        return;
      else if (gvList.Rows.Count == 1)
        gvList.Rows[0].Selected = true;
      else
        gvList.Rows[index - 1].Selected = true;
    }

    private void gvList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.RowIndex < 0 || e.ColumnIndex < 0)
        return;
      if (gvList.Columns[e.ColumnIndex].Name != "ImageBytes")
        return;
      if (gvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        return;


      Form marketUserImage = new Form();
      PictureBox pbImage = new System.Windows.Forms.PictureBox();
      pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
      pbImage.Location = new System.Drawing.Point(0, 0);
      pbImage.Name = "pbImage";
      pbImage.Size = new System.Drawing.Size(247, 281);
      pbImage.MouseLeave += delegate
      {
        marketUserImage.Close();
      };
      pbImage.Click += delegate
      {
        marketUserImage.Close();
      };

      pbImage.Image = Image.FromStream(new MemoryStream((byte[])gvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
      pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

      marketUserImage.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      marketUserImage.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      marketUserImage.BackColor = System.Drawing.Color.LightGray;
      marketUserImage.ClientSize = new System.Drawing.Size(250, 300);
      marketUserImage.Controls.Add(pbImage);
      marketUserImage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      marketUserImage.ShowInTaskbar = false;
      marketUserImage.Name = "MarketUserImage";

      //MarketUserImage marketUserImage = new MarketUserImage();
      //marketUserImage.ImageBytes = (byte[])gvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

      // Point p = gvList.PointToClient(Cursor.Position);
      Point p = Cursor.Position;
      p.X -= 10;
      p.Y -= 10;
      if (Screen.PrimaryScreen.Bounds.Width - p.X <= 250)
        p.X = Screen.PrimaryScreen.Bounds.Width - 250;
      marketUserImage.StartPosition = FormStartPosition.Manual;
      marketUserImage.Location = p;

      marketUserImage.ShowDialog();
    }
    private void gvList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
    {
      //if (e.RowIndex < 0 || e.ColumnIndex < 0)
      //  return;
      //if (gvList.Columns[e.ColumnIndex].Name != "ImageBytes")
      //  return;

      //foreach (Form item in Application.OpenForms)
      //{
      //  if (item.Name == "MarketUserImage")
      //  {
      //    item.Close();
      //    break;
      //  }
      //}
    }
    private void gvList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      if (e.RowIndex < 0)
        return;

      if (gvList.SelectedRows.Count != 1)
        return;
      if (gvList.CurrentCell == null)
        return;

      gvList.ClearSelection();
      gvList.Rows[e.RowIndex].Selected = true;

      Point p = gvList.PointToClient(Cursor.Position);

      cmsGrid.Show(this, p);
    }
    private void ToolStripMenuGrid_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

      Forms.MarketUserForms.MarketUserCrud marketUserCrud = new MarketUserCrud();

      switch (menuItem.Tag.ToString())
      {
        case "Add":
          marketUserCrud.user = new MarketUser();
          marketUserCrud.operation = CrudOperations.Insert;
          break;
        case "Edit":
          marketUserCrud.user = GetSelectedRowUser();
          marketUserCrud.operation = CrudOperations.Update;
          break;
        case "Delete":
          marketUserCrud.user = GetSelectedRowUser();
          marketUserCrud.operation = CrudOperations.Delete;
          break;
        default:
          break;
      }

      //Mevcut seçili satır bilgisini al
      int currentRowIndex = 0;
      if (gvList.Rows.Count > 0)
        currentRowIndex = gvList.SelectedRows[0].Index;
      // Formu çalıştır
      DialogResult res = marketUserCrud.ShowDialog();
      // Dönüş cevap bilgisini al
      result = marketUserCrud.result;
      int affectedId = result.AffectedId;

      // iptal
      if (res == DialogResult.Cancel)
        return;
      // Sonuç
      if (res != DialogResult.OK)
      {
        ShowMessage.MesajGoster(result);
        return;
      }

      // İşlem başarılı
      ListUsers();
      if (marketUserCrud.operation == CrudOperations.Insert || marketUserCrud.operation == CrudOperations.Update)
        SelectGridRowById(affectedId);
      if (marketUserCrud.operation == CrudOperations.Delete || marketUserCrud.operation == CrudOperations.DeleteHard)
        SelectGridRowByPreviusIndex(currentRowIndex);
    }
    MarketUser GetSelectedRowUser()
    {
      MarketUser user = new MarketUser();
      user.Id = Convert.ToInt32(gvList.SelectedRows[0].Cells["Id"].Value);
      user.CreatedOn = Convert.ToDateTime(gvList.SelectedRows[0].Cells["CreatedOn"].Value);
      user.CreatedBy = gvList.SelectedRows[0].Cells["CreatedBy"].Value.ToString();
      user.LastModifiedOn = Convert.ToDateTime(gvList.SelectedRows[0].Cells["LastModifiedOn"].Value);
      user.LastModifiedBy = gvList.SelectedRows[0].Cells["LastModifiedBy"].Value.ToString();
      user.IsActive = Convert.ToBoolean(gvList.SelectedRows[0].Cells["IsActive"].Value);
      user.IsDeleted = Convert.ToBoolean(gvList.SelectedRows[0].Cells["IsDeleted"].Value);
      user.Name = gvList.SelectedRows[0].Cells["Name"].Value.ToString();
      user.SurName = gvList.SelectedRows[0].Cells["SurName"].Value.ToString();
      user.EMail = gvList.SelectedRows[0].Cells["EMail"].Value.ToString();
      user.Password = gvList.SelectedRows[0].Cells["Password"].Value.ToString();
      user.BirthDate = Convert.ToDateTime(gvList.SelectedRows[0].Cells["BirthDate"].Value);
      return user;
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      if (gvList.Rows.Count == 0)
        return;

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

        // pdoc.Print();
      }
    }
    private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
      //e.Graphics.DrawEllipse(Pens.Red, e.MarginBounds);
      //System.Drawing.Drawing2D.GraphicsPath grYol = new System.Drawing.Drawing2D.GraphicsPath();
      //grYol.AddRectangle(new System.Drawing.Rectangle(280, 280, 300, 450));
      //e.Graphics.DrawPath(Pens.Yellow, grYol);
      //e.HasMorePages = false;

      Bitmap bm = new Bitmap(gvList.Width, gvList.Height);
      gvList.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, gvList.Width, gvList.Height));

      e.Graphics.DrawImage(bm, 0, 0);
      e.Graphics.ScaleTransform(100, 100);

      //https://learn.microsoft.com/tr-tr/dotnet/api/system.drawing.printing.printdocument.printpage?view=dotnet-plat-ext-7.0
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
      PostToExcel();
    }
    void PostToExcel()
    {
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Listeleme";

      try
      {
        // Kayıt dosya adı
        string filePath = "";

        // Dosay diyalog ekranı, ayarları ve kontrol
        SaveFileDialog dialog = new SaveFileDialog();
        dialog.Filter = "Excel | *.xlsx";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          filePath = dialog.FileName;
        }
        if (string.IsNullOrEmpty(filePath))
        {
          result.ResultStatus = ResultStatus.Error;
          result.Message = "Dosya adı hatalı";
          ShowMessage.MesajGoster(result);
          return;
        }

        // EPplus office paketi
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        // Excel dosyası oluşturma ve bilgileri doldurma
        using (ExcelPackage p = new ExcelPackage())
        {
          // Çalışam kitabı
          p.Workbook.Properties.Author = "Ogrenci Takip";
          p.Workbook.Properties.Title = "Öğrenci Raporu";
          p.Workbook.Worksheets.Add("Ogrenciler");


          // Çalışma sayfası
          ExcelWorksheet ws = p.Workbook.Worksheets[0];
          ws.Name = "Kullanıcılar";
          ws.Cells.Style.Font.Size = 12;
          ws.Cells.Style.Font.Bold = true;
          ws.Cells.Style.Font.Name = "Times New Roman";
          //ws.Cells.AutoFitColumns();
          ws.PrinterSettings.PaperSize = ePaperSize.A4;
          ws.PrinterSettings.Orientation = eOrientation.Portrait;
          ws.PrinterSettings.HorizontalCentered = true;
          ws.PrinterSettings.FitToPage = true;
          ws.PrinterSettings.FitToWidth = 1;
          ws.PrinterSettings.FitToHeight = 0;

          // Datagrid görünen kolonlar
          int visibleColumns = 0;
          foreach (DataGridViewColumn item in gvList.Columns)
            if (item.Visible)
              visibleColumns++;

          // İlk satıra bilgi yaz ve kolon sayısı kadar hücreyi birleştir
          ws.Cells[1, 1].Value = "Kullanıcı Listesi";
          ws.Cells[1, 1, 1, visibleColumns].Merge = true;
          ws.Cells[1, 1, 1, visibleColumns].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

          // ikinci satıra kolon isimlerini yaz
          int colHeader = 1;
          int rowHeader = 2;
          for (int i = 0; i < visibleColumns; i++) // görünür kolon sayısı kadar dön
          {
            foreach (DataGridViewColumn item in gvList.Columns) // dinamik olarak visibile indeksi yakalamak için tekrar dön
            {
              if (item.Visible && item.DisplayIndex == i) // eğer kolon görünür ve displayindexte uygunsa veriyi yaz
              {
                var cell = ws.Cells[rowHeader, colHeader];

                var fill = cell.Style.Fill;
                fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                cell.Value = item.HeaderText;
                colHeader++;

                break;
              }
            }
          }

          Color c = Color.LightSeaGreen;

          // veri satırlarını hücrelere yaz
          int colIndex = 1;
          int rowIndex = 3;
          foreach (DataGridViewRow dr in gvList.Rows) // tüm satırları dön
          {
            if (c == Color.LightSeaGreen)
              c = Color.MediumVioletRed;
            else
              c = Color.LightSeaGreen;

            for (int i = 0; i < visibleColumns; i++) // her satırda görünür kolon sayısı kadar dön
            {
              foreach (DataGridViewCell cell in dr.Cells) // satırın her hücresinde tekrar dön ve görünür ve displayindeks uyanları bul
              {
                //if (cell.OwningColumn.Name == "ImageBytes" && cell.OwningColumn.DisplayIndex == i)
                //{
                //  if (cell.Value != null)
                //  {
                //    Byte[] data = new Byte[0];
                //    data = (Byte[])(cell.Value);
                //    MemoryStream mem = new MemoryStream(data);
                //    //Image imgUser = Image.FromStream(mem);
                //    //ws.Cells[rowIndex, colIndex++].Value = Image.FromStream(mem);

                //    cell.OwningColumn.Width = 50;

                //    var picture = ws.Drawings.AddPicture($"{rowIndex}{colIndex}", mem);
                //    picture.SetSize(50, 50);
                //    picture.SetPosition(rowIndex - 1, 2, colIndex - 1, 2);

                //    colIndex++;
                //  }
                //}
                if (cell.OwningColumn.Visible && cell.OwningColumn.DisplayIndex == i)
                {
                  if (cell.OwningColumn.Name != "ImageBytes")
                  {
                    ws.Cells[rowIndex, colIndex++].Value = cell.Value.ToString();
                  }
                  else
                  {
                    if (cell.Value != null)
                    {
                      Byte[] data = new Byte[0];
                      data = (Byte[])(cell.Value);
                      MemoryStream mem = new MemoryStream(data);
                      //Image imgUser = Image.FromStream(mem);
                      //ws.Cells[rowIndex, colIndex++].Value = Image.FromStream(mem);

                      cell.OwningColumn.Width = 50;

                      var picture = ws.Drawings.AddPicture($"{rowIndex}{colIndex}", mem);
                      picture.SetSize(50, 50);
                      picture.SetPosition(rowIndex - 1, 2, colIndex - 1, 2);

                      colIndex++;
                    }
                  }
                  break;
                }
              }
            }

            for (int i = 1; i < 11; i++)
            {
              ws.Cells[rowIndex, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
              ws.Cells[rowIndex, i].Style.Fill.BackgroundColor.SetColor(c);

              ws.Row(rowIndex).Height = 50;
            }

            colIndex = 1;
            rowIndex++;

          }

          ws.Cells.AutoFitColumns();

          Byte[] bin = p.GetAsByteArray();
          File.WriteAllBytes(filePath, bin);

          DosyaAc(dialog.FileName);
        }
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = "İşlem hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }

    private void DosyaAc(string path)
    {
      Process process = new Process();
      ProcessStartInfo processStartInfo = process.StartInfo;
      var prevWorking = Environment.CurrentDirectory;
      try
      {
        //string pathF = path;
        //while (pathF.Contains("\\"))
        //{
        //  pathF = pathF.Remove(0, pathF.IndexOf("\\") + 1);
        //}
        //string pathP = path.Replace(pathF, "");


        processStartInfo.FileName = path;
        processStartInfo.UseShellExecute = true;
        Process.Start(processStartInfo);
        //proc.WaitForExit();
        //var exitCode = proc.ExitCode;
        //proc.Close();

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



    private void copyAlltoClipboard()
    {
      gvList.SelectAll();
      DataObject dataObj = gvList.GetClipboardContent();
      if (dataObj != null)
        Clipboard.SetDataObject(dataObj);
    }

    private void btnCopyAll_Click(object sender, EventArgs e)
    {
      if (gvList.Rows.Count == 0)
        return;

      copyAlltoClipboard();
      gvList.ClearSelection();
      gvList.Rows[0].Selected = true;
    }

    private void btnFind_Click(object sender, EventArgs e)
    {
      FindFilter();
    }
    void FindFilter()
    {
      if (txtFilter.Text.Length == 0)
        return;

      gvList.ClearSelection();

      foreach (DataGridViewRow gRow in gvList.Rows)
      {
        foreach (DataGridViewCell gCell in gRow.Cells)
        {
          if (gCell.Value.ToString().ToLower().Contains(txtFilter.Text.ToLower()))
          {
            gRow.Selected = true;
            break;
          }
        }
      }
    }
  } // Form Sonu
}


