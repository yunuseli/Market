using Market.DataAccess.Contexts;
using System.Data;
using System.Data.SqlClient;

namespace Market.Test.LocalDb
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      LocalDbContext.SetLocalDBConn(Application.StartupPath);
    }
    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show(LocalDbContext.GetLocalDBConn().ClientConnectionId.ToString());

      DataTable dt = new DataTable();

      String sql = @"
                SELECT * FROM Musteriler
                ";
      try
      {
        using (SqlDataAdapter da = new SqlDataAdapter(sql, 
          LocalDbContext.GetLocalDBConn()))
        {
          da.Fill(dt);
        }

        dataGridView1.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }


  }
}