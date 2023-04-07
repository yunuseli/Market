using System.Data;
using System.Data.SqlClient;

namespace VeriTabaniDeneme
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    DbConnection SetDbConnection = new DbConnection();  

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void buttonBaglan_Click(object sender, EventArgs e)
    {
      try
      {
        //string conStrDB = "Data Source=\"INPUTFF\\SQLEXPRESS\";";
        //conStrDB += "Initial Catalog=\"BilgisayarDB\";";
        //conStrDB += "Persist Security Info=True;";
        //conStrDB += "User ID=\"UserWinforms\";";
        //conStrDB += "Password=\"12345678\"";

        //SqlConnection conDB = new SqlConnection(conStrDB);
        //if (conDB.State == System.Data.ConnectionState.Closed)
        //{
        //  conDB.Open();
        //}

        MessageBox.Show("Baðlantý saðlandý, server versiyonu :" + DbConnection.GetDbConn().ServerVersion);


        DataTable dt = new DataTable();
        using (SqlDataAdapter da = new SqlDataAdapter(@"
          SELECT * FROM Urunler
          ", DbConnection.GetDbConn()))
        {
          da.Fill(dt);
        }

        MessageBox.Show(dt.Rows[0]["Tanim"].ToString());

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}