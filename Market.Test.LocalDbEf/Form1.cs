using Market.DataAccess.Contexts;
using Market.Entity.Classes.TestClasses;

namespace Market.Test.LocalDbEf
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    LocalDbContextEf context;

    private void Form1_Load(object sender, EventArgs e)
    {
      string dbConnStr = "";

      dbConnStr = Properties.Settings.Default.connectionString;

      context = new LocalDbContextEf(dbConnStr);
      context.Database.EnsureCreated();

      //dbConnStr = dbConnStr.Replace("#path#", Application.StartupPath);
      //dbConnStr = dbConnStr.Replace("#path#", "|DataDirectory|\\");

      //      dbConnStr = @"
      //Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\MyFolder\MyData.mdf;
      //Data Source=(localdb)\MSSQLLocalDB;
      //Initial Catalog=TestLocalDbEf;
      //";

      //  <connectionStrings>
      //<add name="DataModel.Context" connectionString="Data Source=(LocalDb)\v11.0;Initial Catalog=database;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\database.mdf" providerName="System.Data.SqlClient" />


      Listele();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      try
      {
        var arkadaslar = new List<Arkadas>
          {
              new Arkadas { Ad="Carson", Soyad="Alexander", DogumTarihi = DateTime.Parse("1985-09-01"), Telefon="11111111"},
              new Arkadas { Ad="Meredith", Soyad="Alonso", DogumTarihi = DateTime.Parse("1970-09-01"), Telefon="22222"},
              new Arkadas { Ad="Arturo", Soyad="Anand", DogumTarihi = DateTime.Parse("1963-09-01"), Telefon="333333"},
              new Arkadas { Ad="Gytis", Soyad="Barzdukas", DogumTarihi = DateTime.Parse("1988-09-01"), Telefon="444444"},
              new Arkadas { Ad="Yan", Soyad="Li", DogumTarihi = DateTime.Parse("2000-09-01"), Telefon="5555555"},
          };

        context.Arkadaslar.AddRange(arkadaslar);
        await context.SaveChangesAsync();

        Listele();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    Arkadas SeciliSatirVerisi()
    {
      if (dataGridView1.SelectedRows.Count == 0)
      {
        return null;
      }


      Arkadas arkadas = new Arkadas();
      arkadas.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
      arkadas.Ad = dataGridView1.SelectedRows[0].Cells["Ad"].Value.ToString();
      arkadas.Soyad = dataGridView1.SelectedRows[0].Cells["Soyad"].Value.ToString();
      arkadas.DogumTarihi = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DogumTarihi"].Value);
      arkadas.Telefon = dataGridView1.SelectedRows[0].Cells["Telefon"].Value.ToString();
      return arkadas;
    }



    private async void button2_Click(object sender, EventArgs e)
    {
      context.Arkadaslar.Remove(SeciliSatirVerisi());
      await context.SaveChangesAsync();

      Listele();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Listele();
    }
     void Listele()
    {
      dataGridView1.DataSource =  context.Arkadaslar.ToList();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Arkadas arkadas = SeciliSatirVerisi();
      textBox1.Text = arkadas.Ad;
      textBox2.Text = arkadas.Soyad;
      dataGridView1.Enabled = false;
    }

    private async void button5_Click(object sender, EventArgs e)
    {
      Arkadas arkadas = SeciliSatirVerisi();
      arkadas.Ad = textBox1.Text;
      arkadas.Soyad = textBox2.Text;

      context.Arkadaslar.Update(arkadas);
      await context.SaveChangesAsync();

      Listele();
      
      dataGridView1.Enabled = true;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      dataGridView1.Enabled = true;
    }
  }
}