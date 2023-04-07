using Market.Test.AdoEntityDataModel.Models;
using Microsoft.EntityFrameworkCore;

namespace Market.Test.AdoEntityDataModel
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Models.MarketDBContext context;

  //  https://blog.devart.com/best-practices-in-using-the-dbcontext-in-ef-core.html

   // http://vunvulearadu.blogspot.com/2015/06/entity-framework-hybrid-code-first.html

    //https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database

    private void Form1_Load(object sender, EventArgs e)
    {
      DbContextOptions<MarketDBContext> options = new DbContextOptions<MarketDBContext>();
      context = new Models.MarketDBContext(options);

      context.Musteriler.ToList();
    }
  }
}