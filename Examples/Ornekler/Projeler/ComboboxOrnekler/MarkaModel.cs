using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.ComboboxOrnekler
{
  public partial class MarkaModel : Form
  {
    public MarkaModel()
    {
      InitializeComponent();
    }

    private void MarkaModel_Load(object sender, EventArgs e)
    {
      cmbMarka.Items.Add("BMW");
      cmbMarka.Items.Add("Mercedes");
      cmbMarka.Items.Add("Nissan");
      cmbMarka.Items.Add("Toyota");
      cmbMarka.Items.Add("Renault");
      cmbMarka.SelectedIndex = 0;
      cmbMarka.DropDownStyle = ComboBoxStyle.DropDownList;
    }


    private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
    {
      cmbModel.Items.Clear();

      if (cmbMarka.SelectedItem.ToString() == "BMW")
      {
        cmbModel.Items.Add("320");
        cmbModel.Items.Add("520");
        cmbModel.Items.Add("f30");
        cmbModel.Items.Add("f40");
        cmbModel.Items.Add("f50");
      }

      if (cmbMarka.SelectedItem.ToString() == "Mercedes")
      {
        cmbModel.Items.Add("Amg Gt Black Series");
        cmbModel.Items.Add("cla 180");
        cmbModel.Items.Add("cla 200");
        cmbModel.Items.Add("s500");
        cmbModel.Items.Add("Sl 63");
      }

      if (cmbMarka.SelectedItem.ToString() == "Nissan")
      {
        cmbModel.Items.Add("GTR R35");
        cmbModel.Items.Add("GTR R35 Nismo");
        cmbModel.Items.Add("GTR R34");
        cmbModel.Items.Add("Z 350");
        cmbModel.Items.Add("Z 370");
      }

      if (cmbMarka.SelectedItem.ToString() == "Toyota")
      {
        cmbModel.Items.Add("Supra MK 5");
        cmbModel.Items.Add("Supra MK 4");
        cmbModel.Items.Add("Corolla");
        cmbModel.Items.Add("Rav 4");
        cmbModel.Items.Add("Auris");
      }

      if (cmbMarka.SelectedItem.ToString() == "Renault")
      {
        cmbModel.Items.Add("Megane");
        cmbModel.Items.Add("Clio");
        cmbModel.Items.Add("Symbol");
        cmbModel.Items.Add("Taliant");
        cmbModel.Items.Add("Twingo");
      }

      cmbModel.SelectedIndex = 0;
      cmbModel.AutoCompleteMode = AutoCompleteMode.Suggest;
      cmbModel.AutoCompleteSource = AutoCompleteSource.ListItems;
    }

    private void btnGoster_Click(object sender, EventArgs e)
    {
      if (cmbMarka.SelectedItem == null || cmbModel.SelectedItem == null)
      {
        MessageBox.Show("Seçim yapınız");
        return;
      }
      else
      {
        string marka = cmbMarka.SelectedItem.ToString();
        string model = cmbModel.SelectedItem.ToString();
        MessageBox.Show($"Seçilen Marka : {marka}, Model : {model}");
      }
    }
  }
}
