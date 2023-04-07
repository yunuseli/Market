using Market.Business.Classes.ProductCategoryManagers;
using Market.Entity.Classes.DbClasses.ProductClasses;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using Market.Presentation.WinUI.Classes.HelperClasses;
using Market.Presentation.WinUI.Classes.ProgramClasses;
using System.Reflection;

namespace Market.Presentation.WinUI.Forms.ProductForms
{
  public partial class CategoriesList : Form
  {
    public CategoriesList()
    {
      InitializeComponent();
    }

    // Lokal Nesneler - Değişkenler
    ResultObject result;
    ProductCategoryManager productCategoryManager;
    List<Category> categories;

    CrudOperations previusCrudOperation = CrudOperations.None;

    private void CategoriesList_Load(object sender, EventArgs e)
    {
      StartSettings();
    }
    void StartSettings()
    {
      result = new ResultObject();
      productCategoryManager = new ProductCategoryManager();
      categories = new List<Category>();

      CrudOperation_Process(CrudOperations.List);
    }

    void GetDataToList()
    {
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Kullanıcı Listeleme";

      try
      {
        // Veri Listesini çek
        categories = productCategoryManager.ListCategory(out result, false, true);
        if (result.ResultStatus != ResultStatus.Success)
        {
          result.Title = title;
          result.OriginProcess += $"{opc}\n{result.OriginProcess}";
          ShowMessage.MesajGoster(result);
          return;
        }

        FillGridAndFormat();
      }
      catch (Exception ex)
      {
        result.Title = title;
        result.ResultStatus = ResultStatus.Error;
        result.Message = "İşlem hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }
    void FillGridAndFormat()
    {
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Listeleme";

      try
      {
        // Eğer hiç satır olmazsa, AutoGenerateColumns = false durumunda gridde kolonlar oluşmaz
        //if (categories.Count == 0)
        gvList.AutoGenerateColumns = true;

        gvList.DataSource = categories;

        //BindingSource bs = new BindingSource { DataSource = categories };
        //gvList.DataSource = bs;

        //gvList.DataSource = categories.FindAll(t => t.Id > 0).ToList();

        gvList.AutoGenerateColumns = false;

        gvList.RowTemplate.Height = 50;
        //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

        int displayIndex = 0;

        gvList.Columns["Id"].ValueType = typeof(int);
        gvList.Columns["Id"].HeaderText = "Kayıt No";
        gvList.Columns["Id"].DisplayIndex = displayIndex++;
        gvList.Columns["Id"].Visible = true;

        gvList.Columns["CreatedOn"].HeaderText = "Oluşturma";
        gvList.Columns["CreatedOn"].DisplayIndex = displayIndex++;
        gvList.Columns["CreatedOn"].Visible = true;
        gvList.Columns["CreatedBy"].HeaderText = "Oluşturan";
        gvList.Columns["CreatedBy"].DisplayIndex = displayIndex++;
        gvList.Columns["CreatedBy"].Visible = true;
        gvList.Columns["LastModifiedOn"].HeaderText = "Düzenleme";
        gvList.Columns["LastModifiedOn"].DisplayIndex = displayIndex++;
        gvList.Columns["LastModifiedOn"].Visible = true;
        gvList.Columns["LastModifiedBy"].HeaderText = "Düzenleyen";
        gvList.Columns["LastModifiedBy"].DisplayIndex = displayIndex++;
        gvList.Columns["LastModifiedBy"].Visible = true;

        gvList.Columns["Definition"].HeaderText = "Tanım";
        gvList.Columns["Definition"].DisplayIndex = displayIndex++;
        gvList.Columns["Id"].Visible = true;
        gvList.Columns["Description"].HeaderText = "Açıklama";
        gvList.Columns["Description"].DisplayIndex = displayIndex++;
        gvList.Columns["Description"].Visible = true;

        gvList.Columns["ImageBytes"].HeaderText = "Resim";
        gvList.Columns["ImageBytes"].DisplayIndex = displayIndex++;
        gvList.Columns["ImageBytes"].Visible = true;
        gvList.Columns["ImageBytes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        gvList.Columns["ImageBytes"].Width = 50;
        ((DataGridViewImageColumn)gvList.Columns["ImageBytes"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        gvList.Columns["IsDeleted"].Visible = false;
        gvList.Columns["IsActive"].Visible = false;
        gvList.Columns["ImageType"].Visible = false;
        gvList.Columns["IsDeleted"].DisplayIndex = displayIndex++;
        gvList.Columns["IsActive"].DisplayIndex = displayIndex++;
        gvList.Columns["ImageType"].DisplayIndex = displayIndex++;

        if (gvList.Rows.Count > 0)
          gvList.Rows[0].Selected = true;
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = "İşlem hatası";
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

    Category GetSelectedRowData()
    {
      Category category = new Category();
      category.Id = Convert.ToInt32(gvList.SelectedRows[0].Cells["Id"].Value);
      category.CreatedOn = Convert.ToDateTime(gvList.SelectedRows[0].Cells["CreatedOn"].Value);
      category.CreatedBy = gvList.SelectedRows[0].Cells["CreatedBy"].Value.ToString();
      category.LastModifiedOn = Convert.ToDateTime(gvList.SelectedRows[0].Cells["LastModifiedOn"].Value);
      category.LastModifiedBy = gvList.SelectedRows[0].Cells["LastModifiedBy"].Value.ToString();
      category.IsActive = Convert.ToBoolean(gvList.SelectedRows[0].Cells["IsActive"].Value);
      category.IsDeleted = Convert.ToBoolean(gvList.SelectedRows[0].Cells["IsDeleted"].Value);
      category.Description = gvList.SelectedRows[0].Cells["Description"].Value.ToString();
      category.Definition = gvList.SelectedRows[0].Cells["Definition"].Value.ToString();
      category.ImageType = gvList.SelectedRows[0].Cells["ImageType"].Value.ToString();
      category.ImageBytes = (byte[])gvList.SelectedRows[0].Cells["ImageBytes"].Value;
      return category;
    }






    private void btnCrud_Click(object sender, EventArgs e)
    {
      // Butonu al
      Button btn = (Button)sender;
      // İşlem enumu boş olarak ayarla
      CrudOperations crudOperation = CrudOperations.None;
      // Butondan gelen string tag bilgisini enuma çevir
      Enum.TryParse<CrudOperations>(btn.Tag.ToString(), out crudOperation);
      // Enum None değeri dışında bir değerle eşlendi ise metodu çağır
      if (crudOperation != CrudOperations.None)
        CrudOperation_Process(crudOperation);
    }
    void CrudOperation_Process(CrudOperations crudOperation)
    {
      // crudOperation 'a göre arayüz nesne durumlarını ayarla
      switch (crudOperation)
      {
        case CrudOperations.List:
          btnSave.Enabled = false;
          btnCancel.Enabled = false;
          btnAdd.Enabled = true;
          btnEdit.Enabled = true;
          btnDelete.Enabled = true;

          btnSave.Text = "Kaydet";

          gvList.EditMode = DataGridViewEditMode.EditProgrammatically;
          gvList.ReadOnly = true;
          gvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          gvList.AllowUserToAddRows = false;
          gvList.AutoGenerateColumns = false;

          GetDataToList();
          break;
        case CrudOperations.Insert:
          btnSave.Enabled = true;
          btnCancel.Enabled = true;
          btnAdd.Enabled = false;
          btnEdit.Enabled = false;
          btnDelete.Enabled = false;

          //btnSave.Text = "Ekle";

          // grid düzenleme ayarları
          gvList.ReadOnly = false;
          gvList.EditMode = DataGridViewEditMode.EditOnEnter;
          // yeni satır ekle
          categories.Add(new Category());
          // verileri tekrar yükle
          FillGridAndFormat();
          // yeni satır harici kalanları sadece okunabilir yap
          foreach (DataGridViewRow item in gvList.Rows)
          {
            if (item.Cells["Id"].Value.ToString() != "0")
              item.ReadOnly = true;
          }

          // Düzenlenmeyecek kolonları gizle
          // gvList.Columns["Id"].ReadOnly = true;
          gvList.Columns["Id"].Visible = false;
          gvList.Columns["CreatedOn"].Visible = false;
          gvList.Columns["CreatedBy"].Visible = false;
          gvList.Columns["LastModifiedOn"].Visible = false;
          gvList.Columns["LastModifiedBy"].Visible = false;

          break;
        case CrudOperations.Update:
          btnSave.Enabled = true;
          btnCancel.Enabled = true;
          btnAdd.Enabled = false;
          btnEdit.Enabled = false;
          btnDelete.Enabled = false;

          //btnSave.Text = "Güncelle";

          // grid düzenleme ayarları
          gvList.ReadOnly = false;
          gvList.EditMode = DataGridViewEditMode.EditOnEnter;
          // Id kolonunu sadece okunur yap
          gvList.Columns["Id"].ReadOnly = true;
          // Düzenlenmeyecek kolonları gizle
          gvList.Columns["Id"].Visible = false;
          gvList.Columns["CreatedOn"].Visible = false;
          gvList.Columns["CreatedBy"].Visible = false;
          gvList.Columns["LastModifiedOn"].Visible = false;
          gvList.Columns["LastModifiedBy"].Visible = false;

          break;
        case CrudOperations.Delete:
          if (gvList.SelectedRows.Count != 1)
            return;

          btnSave.Enabled = true;
          btnCancel.Enabled = true;
          btnAdd.Enabled = false;
          btnEdit.Enabled = false;
          btnDelete.Enabled = false;

          int deletedIndex = gvList.SelectedRows[0].Index;

          // satır sil
          categories.Remove(categories.Find(t => t.Id == GetSelectedRowData().Id));

          // verileri tekrar yükle
          FillGridAndFormat();

          SelectGridRowByPreviusIndex(deletedIndex);

          //btnSave.Text = "Sil";

          break;

        case CrudOperations.Cancel:
          // Ekle ile yeni satır eklenmiş ve vazgeçilmiş olabilir, bu durumda Id = 0 olanı sil
          categories.Remove(categories.Find(t => t.Id == 0));

          CrudOperation_Process(CrudOperations.List);
          break;
        case CrudOperations.Save:
          SaveData();
          break;
        default:
          break;
      }

      previusCrudOperation = crudOperation;
    }

    private void gvList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
      //Sadece mouse sol tuşu
      if (e.Button != MouseButtons.Left)
        return;
      // Başlık satırları iptal
      if (e.RowIndex < 0 || e.ColumnIndex < 0)
        return;
      // sadece düzenlemeye açık satırlarda
      if (gvList.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
        return;
      // sadece resim hücresinde
      if (gvList.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name != "ImageBytes")
        return;

      Forms.HelperForms.ImageFromFileForm imageFromFileForm = new HelperForms.ImageFromFileForm();
      // imageFromFileForm.ImageBytes = null; // png gibi arka plan null resimlerde üst üste biniyor
      if (imageFromFileForm.ShowDialog() != DialogResult.OK)
        return;

      gvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = imageFromFileForm.ImageBytes;

      gvList.Rows[e.RowIndex].Cells["ImageType"].Value = imageFromFileForm.ImageType;
    }

    void SaveData()
    {
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Kayıt İşlemi";

      List<Category> categoriesGrid = gvList.DataSource as List<Category>;
      List<Category> categoriesDb = productCategoryManager.ListCategory(out result, false, true);

      switch (previusCrudOperation)
      {
        case CrudOperations.Insert:
          Category categoryInserted = categoriesGrid.Single(t => t.Id == 0);
          categoryInserted.IsDeleted = false;
          categoryInserted.IsActive = true;
          productCategoryManager.InsertCategory(out result, categoryInserted, ProgramInfo.Session.CurrenUser);
          if (result.ResultStatus != ResultStatus.Success)
          {
            result.Title = title;
            result.OriginProcess += $"{opc}\n{result.OriginProcess}";
            ShowMessage.MesajGoster(result);
            return;
          }
          break;
        case CrudOperations.Update:
          var res1 = from outer in categoriesGrid
                     from inner in categoriesDb
                     where outer.Id == inner.Id &&
                            (outer.Definition != inner.Definition ||
                            outer.Description != inner.Description ||
                            (outer.ImageBytes != null ? outer.ImageBytes.Length : 0) != (inner.ImageBytes != null ? inner.ImageBytes.Length : 0)
                            )
                     select outer;

          var res2 = categoriesGrid
            .Where(x => !categoriesDb
              .Any(y => y.Id == x.Id && y.Definition == x.Definition && y.Description == x.Description &&
              (y.ImageBytes != null ? y.ImageBytes.Length : 0) == (x.ImageBytes != null ? x.ImageBytes.Length : 0)
              )).ToList();

          //itemGv.ImageBytes.Length == itemDb.ImageBytes.Length
          List<Category> categoriesDiff = new List<Category>();
          foreach (Category itemGv in categoriesGrid)
          {
            bool sameFound = false;
            foreach (Category itemDb in categoriesDb)
            {
              if (
                itemGv.Id == itemDb.Id &&
                itemGv.Definition == itemDb.Definition &&
                itemGv.Description == itemDb.Description &&
                (itemGv.ImageBytes != null ? itemGv.ImageBytes.Length : 0) == (itemDb.ImageBytes != null ? itemDb.ImageBytes.Length : 0)
                )
              {
                sameFound = true;
                break;
              }
            }
            if (!sameFound)
            {
              categoriesDiff.Add(itemGv);
            }
          }

          productCategoryManager.UpdateCategory(out result, categoriesDiff, ProgramInfo.Session.CurrenUser);
          if (result.ResultStatus != ResultStatus.Success)
          {
            result.Title = title;
            result.OriginProcess += $"{opc}\n{result.OriginProcess}";
            ShowMessage.MesajGoster(result);
            return;
          }

          //if (categoriesDiff.Count() == 1)
          //{
          //  Category categoryUpdated = categoriesDiff.FirstOrDefault();
          //}
          //else if (categoriesDiff.Count() > 1)
          //{
          //  List<Category> categoriesUpdated = categoriesDiff.ToList();
          //}

          break;
        case CrudOperations.Delete:
          Category categoryDeleted = categoriesDb
            .Where(x => !categoriesGrid
              .Any(y => y.Id == x.Id && y.Definition == x.Definition && y.Description == x.Description &&
              (y.ImageBytes != null ? y.ImageBytes.Length : 0) == (x.ImageBytes != null ? x.ImageBytes.Length : 0)
              )).First();

          productCategoryManager.DeleteCategory(out result, categoryDeleted.Id, previusCrudOperation, ProgramInfo.Session.CurrenUser);
          if (result.ResultStatus != ResultStatus.Success)
          {
            result.Title = title;
            result.OriginProcess += $"{opc}\n{result.OriginProcess}";
            ShowMessage.MesajGoster(result);
            return;
          }

          break;
        default:
          break;
      }

      result.Title = title;
      result.OriginProcess += $"{opc}\n{result.OriginProcess}";
      ShowMessage.MesajGoster(result);

      CrudOperation_Process(CrudOperations.List);
    }

  } // EOF
}


