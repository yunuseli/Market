using AdoEntityDataModelTest.ModelsMarket;
using Microsoft.EntityFrameworkCore;

namespace AdoEntityDataModelTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    MarketDBContext context;
    private void Form1_Load(object sender, EventArgs e)
    {
      DbContextOptions<MarketDBContext> options = new DbContextOptions<MarketDBContext>();

      
      context = new MarketDBContext(options);

      context.Musteriler.ToList();
    }
  }
}