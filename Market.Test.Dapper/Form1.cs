using Dapper;
using Market.Entity.Classes.DbClasses.MusteriSiniflari;
using Market.Entity.Classes.DbClasses.UserClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Market.Test.Dapper
{
  public partial class Form1 : Form
  {
    //https://caylakyazilimci.com/post/object-relational-mapping-orm-nedir


    public Form1()
    {
      InitializeComponent();
    }
    //https://github.com/mertmtn/DapperORMUsage

    //https://code-maze.com/using-dapper-with-asp-net-core-web-api/
    //https://www.mshowto.org/c-dapper-kullanimi.html

    //https://www.borakasmer.com/dapper-nedir/


    //***************************
    //https://www.learndapper.com/
    //***************************

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

    private void button2_Click(object sender, EventArgs e)
    {
      //val = "my value";
      //cnn.Execute("insert into Table(val) values (@val)", new { val });
      //cnn.Execute("update Table set val = @val where Id = @id", new { val, id = 1 });

      Random rnd = new Random();
      int sayi = rnd.Next(1, 1000);

      string sqlquerry = @"
          INSERT INTO Musteriler (
            CreatedOn
            ,CreatedBy
            ,LastModifiedOn
            ,LastModifiedBy
            ,IsDeleted
            ,IsActive
            ,Ad
            ,Soyad
            ,Telefon) VALUES (
            @CreatedOn
            ,@CreatedBy
            ,@LastModifiedOn
            ,@LastModifiedBy
            ,@IsDeleted
            ,@IsActive
            ,@Ad
            ,@Soyad
            ,@Telefon)
          ";

      Musteri musteri = new Musteri
      {
        Id = 0,
        CreatedBy = "Admin",
        CreatedOn = DateTime.Now,
        LastModifiedBy = "Admin",
        LastModifiedOn = DateTime.Now,
        IsActive = true,
        IsDeleted = false,
        Ad = "Deneme" + sayi.ToString(),
        Soyad = "Dene" + sayi.ToString(),
        Telefon = "Tele" + sayi.ToString()
      };

      var result = MarketDbContextDapper.GetDapperDbConn().Execute(sqlquerry, musteri);
      button1.PerformClick();
    }
  }
}






//Using Dapper.Contrib it is as simple as this:

//Insert list:

//public int Insert(IEnumerable<YourClass> yourClass)
//{
//  using (SqlConnection conn = new SqlConnection(ConnectionString))
//  {
//    return conn.Insert(yourClass);
//  }
//}
//Insert single:

//public int Insert(YourClass yourClass)
//{
//  using (SqlConnection conn = new SqlConnection(ConnectionString))
//  {
//    return conn.Insert(yourClass);
//  }
//}
//Update list:

//public bool Update(IEnumerable<YourClass> yourClass)
//{
//  using (SqlConnection conn = new SqlConnection(ConnectionString))
//  {
//    return conn.Update(yourClass);
//  }
//}
//Update single:

//public bool Update(YourClass yourClass)
//{
//  using (SqlConnection conn = new SqlConnection(ConnectionString))
//  {
//    return conn.Update(yourClass);
//  }
//}





//using Dapper.Contrib.Extensions;
//using System.Data;
//Code:

//string connectionString = "Server=localhost;Database=SampleSQL_DB;Integrated Security=True";

//UserModel objUser1 = new UserModel { UserId = "user0000001", Name = "Jack", Sex = "Male" };
//UserModel objUser2 = new UserModel { UserId = "user0000002", Name = "Marry", Sex = "female" };
//UserModel objUser3 = new UserModel { UserId = "user0000003", Name = "Joe", Sex = "male" };

//List<UserModel> LstUsers = new List<UserModel>();
//LstUsers.Add(objUser2); LstUsers.Add(objUser3);

//try
//{
//  using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
//  {
//    connection.Open();

//    using (var trans = connection.BeginTransaction())
//    {
//      try
//      {
//        //  insert single record with custom data model
//        connection.Insert(objUser1, transaction: trans);

//        // insert multiple record with List<Type>
//        connection.Insert(LstUsers, transaction: trans);

//        // Only save to SQL database if all require SQL operation completed successfully 
//        trans.Commit();
//      }
//      catch (Exception e)
//      {
//        // If one of the SQL operation fail , roll back the whole transaction
//        trans.Rollback();
//      }
//    }
//  }
//}
//catch (Exception e) { }



