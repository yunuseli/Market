using Market.Business.Classes.ProductCategoryManagers;
using Market.Entity.Classes.DbClasses.ProductClasses;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using Market.Presentation.WinUI.Classes.HelperClasses;
using Market.Presentation.WinUI.Classes.ProgramClasses;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Market.Presentation.WinUI.Forms.ProductForms
{
  public partial class BrandModelList : Form
  {
    public BrandModelList()
    {
      InitializeComponent();
    }

    // Lokal Nesneler - Değişkenler
    ResultObject result;
    ProductBrandModelManager productBrandModelManager;
    List<BrandModel> brandsModels;
    //BindingList<BrandModel> brandsModels;

    CrudOperations previusCrudOperation = CrudOperations.None;

    private void BrandModelList_Load(object sender, EventArgs e)
    {
      StartSettings();
    }
    void StartSettings()
    {
      result = new ResultObject();
      productBrandModelManager = new ProductBrandModelManager();
      brandsModels = new List<BrandModel>();
      // brandsModels = new BindingList<BrandModel>();

      CrudOperation_Process(CrudOperations.List);
    }

    void GetDataToList()
    {
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Kullanıcı Listeleme";

      try
      {
        // Veri Listesini çek
        //brandsModels = new BindingList<BrandModel>(productBrandModelManager.List(out result, false, true));
        brandsModels = productBrandModelManager.List(out result, false, true);
        if (result.ResultStatus != ResultStatus.Success)
        {
          result.Title = title;
          result.OriginProcess += $"{opc}\n{result.OriginProcess}";
          ShowMessage.MesajGoster(result);
          return;
        }

        FillTreeAndFormat();
        FillGridBrandAndFormat();
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


    void FillTreeAndFormat()
    {
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Marka-Model Listeleme";

      try
      {
        treeViewList.Nodes.Clear();

        foreach (BrandModel parent in brandsModels)
        {
          if (parent.ParentId == 0)
          {
            TreeNode nodeParent = new TreeNode();
            nodeParent.Text = parent.Definition;
            nodeParent.Tag = parent.Id;
            treeViewList.Nodes.Add(nodeParent);

            foreach (BrandModel child in brandsModels)
            {
              if (child.ParentId == parent.Id)
              {
                TreeNode nodeChild = new TreeNode();
                nodeChild.Text = child.Definition;
                nodeChild.Tag = child.Id;
                treeViewList.Nodes[nodeParent.Index].Nodes.Add(nodeChild);
              }
            }
          }
        }

        treeViewList.ExpandAll(); 


        // Eğer hiç satır olmazsa, AutoGenerateColumns = false durumunda gridde kolonlar oluşmaz
        gvBrand.AutoGenerateColumns = true;

        // gvBrand.DataSource = brandsModels.Where(t => t.ParentId == 0);
        gvBrand.DataSource = new BindingList<BrandModel>(brandsModels.Where(t => t.ParentId == 0).ToList());

        //BindingSource bs = new BindingSource { DataSource = categories };
        //gvList.DataSource = bs;

        //gvList.DataSource = categories.FindAll(t => t.Id > 0).ToList();

        gvBrand.AutoGenerateColumns = false;

        gvBrand.RowHeadersVisible = false;
        gvBrand.ColumnHeadersVisible = false;

        gvBrand.RowTemplate.Height = 50;
        //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

        int displayIndex = 0;

        gvBrand.Columns["Definition"].HeaderText = "Tanım";
        gvBrand.Columns["Definition"].DisplayIndex = displayIndex++;
        gvBrand.Columns["Definition"].Visible = true;

        foreach (DataGridViewColumn col in gvBrand.Columns)
        {
          if (col.Name != "Definition")
          {
            col.Visible = false;
            col.DisplayIndex = displayIndex++;
          }
        }

        if (gvBrand.Rows.Count > 0)
          gvBrand.Rows[0].Selected = true;
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = "İşlem hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }
    private void treeViewList_AfterSelect(object sender, TreeViewEventArgs e)
    {
      int id = Convert.ToInt32(e.Node.Tag);
      int parentId = brandsModels.Find(t => t.Id == id).ParentId;

      
      if (parentId == 0)
      {
        gvBrand.ClearSelection();
        DataGridViewRow r = gvBrand.Rows.Cast<DataGridViewRow>().Where(x => x.Cells["Id"].Value.ToString() == id.ToString()).ToList()[0];
        //gvBrand.Rows.Cast<DataGridViewRow>().Where(x => x.Cells["Id"].Value.ToString() == id.ToString()).ToList()[0].Selected = true;
          gvBrand.Rows[r.Index].Selected = true;
      }
      else
      {
        gvBrand.ClearSelection();
        DataGridViewRow r = gvBrand.Rows.Cast<DataGridViewRow>().Where(x => x.Cells["Id"].Value.ToString() == parentId.ToString()).ToList()[0];
        gvBrand.Rows[r.Index].Selected = true;

        gvModel.ClearSelection();
        DataGridViewRow v = gvModel.Rows.Cast<DataGridViewRow>().Where(x => x.Cells["Id"].Value.ToString() == id.ToString()).ToList()[0];
        gvModel.Rows[v.Index].Selected = true;
      }


    }

    void FillGridBrandAndFormat()
    {
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Marka Listeleme";

      try
      {
        gvBrand.AutoGenerateColumns = true;

        gvBrand.DataSource = new BindingList<BrandModel>(brandsModels.Where(t => t.ParentId == 0).ToList());

        gvBrand.AutoGenerateColumns = false;

        gvBrand.RowHeadersVisible = false;
        gvBrand.ColumnHeadersVisible = false;

        int displayIndex = 0;

        gvBrand.Columns["Definition"].HeaderText = "Tanım";
        gvBrand.Columns["Definition"].DisplayIndex = displayIndex++;
        gvBrand.Columns["Definition"].Visible = true;

        foreach (DataGridViewColumn col in gvBrand.Columns)
        {
          if (col.Name != "Definition")
          {
            col.Visible = false;
            col.DisplayIndex = displayIndex++;
          }
        }

        if (gvBrand.Rows.Count > 0)
          gvBrand.Rows[0].Selected = true;
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = "İşlem hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }
    private void gvBrand_SelectionChanged(object sender, EventArgs e)
    {
      if (gvBrand.SelectedRows.Count == 0)
        return;

      int id = Convert.ToInt32(gvBrand.SelectedRows[0].Cells["Id"].Value);
      //int parentId = Convert.ToInt32(gvBrand.SelectedRows[0].Cells["ParentId"].Value);

      FillGridModelAndFormat(id);
    }
    void FillGridModelAndFormat(int parentId)
    {
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Model Listeleme";

      try
      {
        gvModel.AutoGenerateColumns = true;

        gvModel.DataSource = new BindingList<BrandModel>(brandsModels.Where(t => t.ParentId == parentId).ToList());

        gvModel.AutoGenerateColumns = false;

        gvModel.RowHeadersVisible = false;
        gvModel.ColumnHeadersVisible = false;

        int displayIndex = 0;

        gvModel.Columns["Definition"].HeaderText = "Tanım";
        gvModel.Columns["Definition"].DisplayIndex = displayIndex++;
        gvModel.Columns["Definition"].Visible = true;

        foreach (DataGridViewColumn col in gvModel.Columns)
        {
          if (col.Name != "Definition")
          {
            col.Visible = false;
            col.DisplayIndex = displayIndex++;
          }
        }

        if (gvModel.Rows.Count > 0)
          gvModel.Rows[0].Selected = true;
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

      gvBrand.ClearSelection();
      gvBrand.CurrentCell = null;

      foreach (DataGridViewRow row in gvBrand.Rows)
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
      gvBrand.ClearSelection();
      gvBrand.CurrentCell = null;

      if (gvBrand.Rows.Count == 0)
        return;
      else if (gvBrand.Rows.Count == 1)
        gvBrand.Rows[0].Selected = true;
      else
        gvBrand.Rows[index - 1].Selected = true;
    }

    BrandModel GetSelectedRowData()
    {
      BrandModel brandModel = new BrandModel();
      brandModel.Id = Convert.ToInt32(gvBrand.SelectedRows[0].Cells["Id"].Value);
      brandModel.CreatedOn = Convert.ToDateTime(gvBrand.SelectedRows[0].Cells["CreatedOn"].Value);
      brandModel.CreatedBy = gvBrand.SelectedRows[0].Cells["CreatedBy"].Value.ToString();
      brandModel.LastModifiedOn = Convert.ToDateTime(gvBrand.SelectedRows[0].Cells["LastModifiedOn"].Value);
      brandModel.LastModifiedBy = gvBrand.SelectedRows[0].Cells["LastModifiedBy"].Value.ToString();
      brandModel.IsActive = Convert.ToBoolean(gvBrand.SelectedRows[0].Cells["IsActive"].Value);
      brandModel.IsDeleted = Convert.ToBoolean(gvBrand.SelectedRows[0].Cells["IsDeleted"].Value);
      brandModel.ParentId = Convert.ToInt32(gvBrand.SelectedRows[0].Cells["ParentId"].Value);
      brandModel.Description = gvBrand.SelectedRows[0].Cells["Description"].Value.ToString();
      brandModel.Definition = gvBrand.SelectedRows[0].Cells["Definition"].Value.ToString();
      brandModel.ImageType = gvBrand.SelectedRows[0].Cells["ImageType"].Value.ToString();
      brandModel.ImageBytes = (byte[])gvBrand.SelectedRows[0].Cells["ImageBytes"].Value;
      return brandModel;
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

          gvBrand.EditMode = DataGridViewEditMode.EditProgrammatically;
          gvBrand.ReadOnly = true;
          gvBrand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          gvBrand.AllowUserToAddRows = false;
          gvBrand.AutoGenerateColumns = false;

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
          gvBrand.ReadOnly = false;
          gvBrand.EditMode = DataGridViewEditMode.EditOnEnter;
          // yeni satır ekle
          brandsModels.Add(new BrandModel());
          // verileri tekrar yükle
          FillGridBrandAndFormat();
          // yeni satır harici kalanları sadece okunabilir yap
          foreach (DataGridViewRow item in gvBrand.Rows)
          {
            if (item.Cells["Id"].Value.ToString() != "0")
              item.ReadOnly = true;
          }

          // Düzenlenmeyecek kolonları gizle
          // gvList.Columns["Id"].ReadOnly = true;
          gvBrand.Columns["Id"].Visible = false;
          gvBrand.Columns["CreatedOn"].Visible = false;
          gvBrand.Columns["CreatedBy"].Visible = false;
          gvBrand.Columns["LastModifiedOn"].Visible = false;
          gvBrand.Columns["LastModifiedBy"].Visible = false;

          break;
        case CrudOperations.Update:
          btnSave.Enabled = true;
          btnCancel.Enabled = true;
          btnAdd.Enabled = false;
          btnEdit.Enabled = false;
          btnDelete.Enabled = false;

          //btnSave.Text = "Güncelle";

          // grid düzenleme ayarları
          gvBrand.ReadOnly = false;
          gvBrand.EditMode = DataGridViewEditMode.EditOnEnter;
          // Id kolonunu sadece okunur yap
          gvBrand.Columns["Id"].ReadOnly = true;
          // Düzenlenmeyecek kolonları gizle
          gvBrand.Columns["Id"].Visible = false;
          gvBrand.Columns["CreatedOn"].Visible = false;
          gvBrand.Columns["CreatedBy"].Visible = false;
          gvBrand.Columns["LastModifiedOn"].Visible = false;
          gvBrand.Columns["LastModifiedBy"].Visible = false;

          break;
        case CrudOperations.Delete:
          if (gvBrand.SelectedRows.Count != 1)
            return;

          btnSave.Enabled = true;
          btnCancel.Enabled = true;
          btnAdd.Enabled = false;
          btnEdit.Enabled = false;
          btnDelete.Enabled = false;

          int deletedIndex = gvBrand.SelectedRows[0].Index;

          // satır sil
          brandsModels.Remove(brandsModels.First(t => t.Id == GetSelectedRowData().Id));

          // verileri tekrar yükle
          FillGridBrandAndFormat();

          SelectGridRowByPreviusIndex(deletedIndex);

          //btnSave.Text = "Sil";

          break;

        case CrudOperations.Cancel:
          // Ekle ile yeni satır eklenmiş ve vazgeçilmiş olabilir, bu durumda Id = 0 olanı sil
          brandsModels.Remove(brandsModels.First(t => t.Id == 0));

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
      if (gvBrand.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
        return;
      // sadece resim hücresinde
      if (gvBrand.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name != "ImageBytes")
        return;

      Forms.HelperForms.ImageFromFileForm imageFromFileForm = new HelperForms.ImageFromFileForm();
      // imageFromFileForm.ImageBytes = null; // png gibi arka plan null resimlerde üst üste biniyor
      if (imageFromFileForm.ShowDialog() != DialogResult.OK)
        return;

      gvBrand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = imageFromFileForm.ImageBytes;

      gvBrand.Rows[e.RowIndex].Cells["ImageType"].Value = imageFromFileForm.ImageType;
    }

    void SaveData()
    {
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Kayıt İşlemi";

      //List<Category> categoriesGrid = gvBrand.DataSource as List<Category>;
      //List<Category> categoriesDb = productCategoryManager.ListCategory(out result, false, true);

      //switch (previusCrudOperation)
      //{
      //  case CrudOperations.Insert:
      //    Category categoryInserted = categoriesGrid.Single(t => t.Id == 0);
      //    categoryInserted.IsDeleted = false;
      //    categoryInserted.IsActive = true;
      //    productCategoryManager.InsertCategory(out result, categoryInserted, ProgramInfo.Session.CurrenUser);
      //    if (result.ResultStatus != ResultStatus.Success)
      //    {
      //      result.Title = title;
      //      result.OriginProcess += $"{opc}\n{result.OriginProcess}";
      //      ShowMessage.MesajGoster(result);
      //      return;
      //    }
      //    break;
      //  case CrudOperations.Update:
      //    var res1 = from outer in categoriesGrid
      //               from inner in categoriesDb
      //               where outer.Id == inner.Id &&
      //                      (outer.Definition != inner.Definition ||
      //                      outer.Description != inner.Description ||
      //                      (outer.ImageBytes != null ? outer.ImageBytes.Length : 0) != (inner.ImageBytes != null ? inner.ImageBytes.Length : 0)
      //                      )
      //               select outer;

      //    var res2 = categoriesGrid
      //      .Where(x => !categoriesDb
      //        .Any(y => y.Id == x.Id && y.Definition == x.Definition && y.Description == x.Description &&
      //        (y.ImageBytes != null ? y.ImageBytes.Length : 0) == (x.ImageBytes != null ? x.ImageBytes.Length : 0)
      //        )).ToList();

      //    //itemGv.ImageBytes.Length == itemDb.ImageBytes.Length
      //    List<Category> categoriesDiff = new List<Category>();
      //    foreach (Category itemGv in categoriesGrid)
      //    {
      //      bool sameFound = false;
      //      foreach (Category itemDb in categoriesDb)
      //      {
      //        if (
      //          itemGv.Id == itemDb.Id &&
      //          itemGv.Definition == itemDb.Definition &&
      //          itemGv.Description == itemDb.Description &&
      //          (itemGv.ImageBytes != null ? itemGv.ImageBytes.Length : 0) == (itemDb.ImageBytes != null ? itemDb.ImageBytes.Length : 0)
      //          )
      //        {
      //          sameFound = true;
      //          break;
      //        }
      //      }
      //      if (!sameFound)
      //      {
      //        categoriesDiff.Add(itemGv);
      //      }
      //    }

      //    productCategoryManager.UpdateCategory(out result, categoriesDiff, ProgramInfo.Session.CurrenUser);
      //    if (result.ResultStatus != ResultStatus.Success)
      //    {
      //      result.Title = title;
      //      result.OriginProcess += $"{opc}\n{result.OriginProcess}";
      //      ShowMessage.MesajGoster(result);
      //      return;
      //    }

      //    //if (categoriesDiff.Count() == 1)
      //    //{
      //    //  Category categoryUpdated = categoriesDiff.FirstOrDefault();
      //    //}
      //    //else if (categoriesDiff.Count() > 1)
      //    //{
      //    //  List<Category> categoriesUpdated = categoriesDiff.ToList();
      //    //}

      //    break;
      //  case CrudOperations.Delete:
      //    Category categoryDeleted = categoriesDb
      //      .Where(x => !categoriesGrid
      //        .Any(y => y.Id == x.Id && y.Definition == x.Definition && y.Description == x.Description &&
      //        (y.ImageBytes != null ? y.ImageBytes.Length : 0) == (x.ImageBytes != null ? x.ImageBytes.Length : 0)
      //        )).First();

      //    productCategoryManager.DeleteCategory(out result, categoryDeleted.Id, previusCrudOperation, ProgramInfo.Session.CurrenUser);
      //    if (result.ResultStatus != ResultStatus.Success)
      //    {
      //      result.Title = title;
      //      result.OriginProcess += $"{opc}\n{result.OriginProcess}";
      //      ShowMessage.MesajGoster(result);
      //      return;
      //    }

      //    break;
      //  default:
      //    break;
      //}

      result.Title = title;
      result.OriginProcess += $"{opc}\n{result.OriginProcess}";
      ShowMessage.MesajGoster(result);

      CrudOperation_Process(CrudOperations.List);
    }


  } // EOF
}


