using Dapper;
using Market.Entity.Classes.DbClasses.MusteriSiniflari;
using Market.Entity.Classes.DbClasses.UserClasses;

namespace Market.Test.Dapper
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    //https://github.com/mertmtn/DapperORMUsage

    //https://code-maze.com/using-dapper-with-asp-net-core-web-api/
    //https://www.mshowto.org/c-dapper-kullanimi.html

    //https://www.borakasmer.com/dapper-nedir/

    //https://www.learndapper.com/

    MarketDbContextDapper SetMarketDbContextDapper = new MarketDbContextDapper();

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private async void button1_Click(object sender, EventArgs e)
    {
      try
      {
        var queryUser = "SELECT * FROM MarketUser";
        var users1 = MarketDbContextDapper.GetSqlDbConn().Query<MarketUser>(queryUser);
        var users2 = MarketDbContextDapper.GetDapperDbConn().Query<MarketUser>(queryUser);
        dataGridView1.DataSource = users2.ToList();

        var queryMust = "SELECT * FROM Musteriler";
        var Must1 = await MarketDbContextDapper.GetSqlDbConn().QueryAsync<Musteri>(queryMust);
        var Must2 = await MarketDbContextDapper.GetDapperDbConn().QueryAsync<Musteri>(queryMust);
        dataGridView2.DataSource = Must2.ToList();

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }





    }


  }
}