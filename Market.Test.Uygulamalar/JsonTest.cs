using Newtonsoft.Json;
using System.Net;

namespace Market.Test.Uygulamalar
{
  public partial class JsonTest : Form
  {
    public JsonTest()
    {
      InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      try
      {
        string serviceUrl = "https://mocki.io/v1/97f04168-f512-4d35-a4d1-d0b6d564da53";
        string jsonData;
        //using (WebClient wc = new WebClient())
        //{
        //  jsonData = wc.DownloadString(serviceUrl);
        //}
        using (HttpClient c = new HttpClient())
        {
          jsonData = await c.GetStringAsync(serviceUrl);
        }


        Root root = JsonConvert.DeserializeObject<Root>(jsonData);



        List<Root> listRoot = new List<Root>();
        listRoot.Add(root);
        dataGridView1.DataSource = listRoot;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    public class Child
    {
      public string name { get; set; }
      public int age { get; set; }
    }
    public class CurrentJob
    {
      public string title { get; set; }
      public string salary { get; set; }
    }
    public class Job
    {
      public string title { get; set; }
      public string salary { get; set; }
    }
    public class Root
    {
      public string id { get; set; }
      public List<Child> children { get; set; }
      public CurrentJob currentJob { get; set; }
      public List<Job> jobs { get; set; }
      public int maxRunDistance { get; set; }
      public string cpf { get; set; }
      public string cnpj { get; set; }
      public string pretendSalary { get; set; }
      public int age { get; set; }
      public string gender { get; set; }
      public string firstName { get; set; }
      public string lastName { get; set; }
      public string phone { get; set; }
      public string address { get; set; }
      public string hairColor { get; set; }
    }








    // örnek 2
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    
    public class Ornek2_Datum
    {
      public int id { get; set; }
      public string name { get; set; }
      public int year { get; set; }
      public string color { get; set; }
      public string pantone_value { get; set; }
    }

    /// <summary>
    /// Ornek2 root modeli
    /// </summary>
    public class Ornek2_Root
    {
      public int page { get; set; }
      public int per_page { get; set; }
      public int total { get; set; }
      public int total_pages { get; set; }
      public List<Ornek2_Datum> data { get; set; }
      public Ornek2_Support support { get; set; }
    }

    /// <summary>
    /// Ornek 2 Support sınıfı
    /// Bu sınıf içine url ve text bilgileri string olarak girilmelidir.
    /// </summary>
    public class Ornek2_Support
    {
      public string url { get; set; }
      public string text { get; set; }
    }


    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        string serviceUrl = "https://reqres.in/api/unknown";
        string jsonData;
        using (WebClient wc = new WebClient())
        {
          jsonData = wc.DownloadString(serviceUrl);
        }

        Ornek2_Root root = JsonConvert.DeserializeObject<Ornek2_Root>(jsonData);

        List<Ornek2_Root> listRoot = new List<Ornek2_Root>();
        listRoot.Add(root);
        dataGridView2.DataSource = listRoot;

        List<Ornek2_Datum> listDatum = root.data.ToList();
        dataGridView3.DataSource = listDatum;

        List<Ornek2_Support> listSupport = new List<Ornek2_Support>();
        listSupport.Add(root.support);
        dataGridView4.DataSource = listSupport;


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void JsonTest_Load(object sender, EventArgs e)
    {

    }
  }
}
