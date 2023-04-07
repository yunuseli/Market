using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography;

namespace Metotlar
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private int privateSayi = 5;
    public int publicSayi = 10;
    private static int privateStaticSayi = 15;
    public static int publicStaticSayi = 20;
    private int privateMethod() { return 105; }
    public int publicMethod() { return 110; }
    private static int privateStaticMethod() { return 115; }
    public static int publicStaticMethod() { return 120; }
    public static int publicStaticMethodTopla(int s1, int s2)
    {
      return s1 + s2;
    }






    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      parametresizMetotDegerDonmeyen();
    }
    void parametresizMetotDegerDonmeyen()
    {
      // MessageBox.Show("Test");

      //foreach (Control item in Form1.ActiveForm.Controls)
      //{
      //  // MessageBox.Show(item.Name);
      //  if (item.Name == "button5")
      //  {
      //    button5_Click(null,null);
      //  }
      //}


      try
      {
        int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        for (int i = 0; i < dizi.Length; i++)
        {
          if (i == 3)
          {
            MessageBox.Show("Test");
          }
          else
          {
            int deger = dizi[i];
          }
        }

        int sayac = 0;
        int toplam = 0;
        foreach (int sayi in dizi)
        {
          toplam += sayi;

          if (sayac == 3)
          {
            MessageBox.Show("Test");
          }
          sayac++;
        }
        MessageBox.Show($"Toplam = {toplam}");




        //string c = "sjgfjsdf";
        //// int.Parse(c);
        //int s = 0;
        //if (int.TryParse(c, out s) == false)
        //{
        //  MessageBox.Show("yaþ bilgi giriþi hatalý");
        //}

        //int xz = 3;
        //int say = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //  if (i == 2 && xz == 3)
        //    continue;

        //  if (i == 6)
        //    break;

        //  say += i;
        //}
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        MessageBox.Show("iþim bitti");
      }


      int x = 0;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      MessageBox.Show(parametresizMetotDegerDonen());
    }
    string parametresizMetotDegerDonen()
    {
      float pi = 3.14F;
      return pi.ToString();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      parametreliMetotDegerDonmeyen("DataHouse");
    }
    void parametreliMetotDegerDonmeyen(string isim)
    {
      MessageBox.Show(isim);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      MessageBox.Show(parametreliMetotDegerDonen(3, 5).ToString());
    }
    int parametreliMetotDegerDonen(int sayi1, int sayi2)
    {
      int toplam = sayi1 + sayi2;
      return toplam;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      string[] prm = { "abc", "def", "ghi", "jkl", "mno" };
      degiskenSayidaParametreli(prm);
    }
    void degiskenSayidaParametreli(params string[] parametreler)
    {
      string sonuc = "";
      for (int i = 0; i < parametreler.Length; i++)
        sonuc += $"Parametre-{i}: {parametreler[i]}{Environment.NewLine}";

      sonuc += $"Toplam {parametreler.Length} parametre girildi";
      MessageBox.Show(sonuc);

    }

    private void button6_Click(object sender, EventArgs e)
    {
      diziParametreli(new int[] { 1, 3, 5, 7, 9 });
    }
    void diziParametreli(int[] dizi)
    {
      foreach (var item in dizi)
      {
        MessageBox.Show(item.ToString());
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      int[] dizi = { 1, 2, 3, 4, 5 };
      DiziDegistir(dizi);
      string sonuc = "";
      foreach (var item in dizi)
        sonuc += $"{item} - ";
      MessageBox.Show(sonuc);
    }
    void DiziDegistir(int[] dizi)
    {
      string sonuc = "";
      for (int i = 0; i < dizi.Length; i++)
      {
        sonuc += $"{dizi[i]} - ";
        dizi[i] = 10;
      }
      MessageBox.Show(sonuc);
    }

    private void button8_Click(object sender, EventArgs e)
    {
      int sayi = 1;
      DegiskenDegistir(sayi);
      MessageBox.Show(sayi.ToString());
    }
    void DegiskenDegistir(int sayi)
    {
      sayi = 10;
    }

    private void button9_Click(object sender, EventArgs e)
    {
      int sayi = 5;
      DegistirRef(ref sayi);
      MessageBox.Show(sayi.ToString());
    }
    void DegistirRef(ref int sayi)
    {
      sayi = 10;
    }

    private void button10_Click(object sender, EventArgs e)
    {
      int sayi;
      DegistirOut(out sayi);
      MessageBox.Show(sayi.ToString());
    }
    void DegistirOut(out int sayi)
    {
      sayi = 10;
    }

    private void button13_Click(object sender, EventArgs e)
    {
      MethodOverloading(15F, 16F, 20F);
    }

    private void button12_Click(object sender, EventArgs e)
    {
      MethodOverloading(15F, 16F);
    }
    private void button11_Click(object sender, EventArgs e)
    {
      MethodOverloading(5, 6);
      MethodOverloading(15F, 16F);
      MethodOverloading(15F, 16F, 20F);
      MethodOverloading(15, 16, 20);
      MethodOverloading(15, 16, 20, 25);
    }
    void MethodOverloading(int x, int y)
    {
      MessageBox.Show("MethodOverloading 1 çaðrýldý");
    }
    void MethodOverloading(float x, float y)
    {
      MessageBox.Show("MethodOverloading 2 çaðrýldý");
    }
    void MethodOverloading(float x, float y, float z)
    {
      MessageBox.Show("MethodOverloading 3 çaðrýldý");
    }
    void MethodOverloading(float x, float y, float z, float a)
    {
      MessageBox.Show("MethodOverloading 3 çaðrýldý");
    }

    private void button14_Click(object sender, EventArgs e)
    {
      MessageBox.Show(FaktoriyelRecursive(0).ToString());
      MessageBox.Show(FaktoriyelRecursive(1).ToString());
      MessageBox.Show(FaktoriyelRecursive(2).ToString());
      MessageBox.Show(FaktoriyelRecursive(3).ToString());
    }
    int FaktoriyelRecursive(int sayi)
    {
      if (sayi == 0)
        return 1;
      return sayi * FaktoriyelRecursive(sayi - 1);
    }

    private void button15_Click(object sender, EventArgs e)
    {
      MessageBox.Show(FibonacciRecursive(9).ToString());
    }
    int FibonacciRecursive(int sayi)
    {
      if (sayi == 0)
        return 0;
      else if (sayi == 1)
        return 1;
      else
        return FibonacciRecursive(sayi - 1) + FibonacciRecursive(sayi - 2);
    }

    private void button16_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ToplaRakamlarRecursive(123456789).ToString());
    }
    int ToplaRakamlarRecursive(int sayi)
    {
      if (sayi != 0)
        return (sayi % 10 + ToplaRakamlarRecursive(sayi / 10));
      else
        return 0;
    }

    private void button17_Click(object sender, EventArgs e)
    {
      OpsiyonelParametre("deneme"); //s1="deneme" s2="varsayilan" i=0
      OpsiyonelParametre("deneme1", "deneme2"); //s1="deneme1" s2="deneme2" i=0
      OpsiyonelParametre("deneme1", "deneme2", 2); //s1="deneme1" s2="deneme2" i=2
      //OpsiyonelParametre("deneme", 2); //hatalý
    }
    void OpsiyonelParametre(string s1, string s2 = "varsayilan", int i = 0)
    {
      MessageBox.Show($"{s1} | {s2} | {i}");
    }

    private void button18_Click(object sender, EventArgs e)
    {
      IsimlendirilmisParametre("deneme1", i: 5, s2: "deneme2");
      IsimlendirilmisParametre(i: 5, s2: "deneme2", s1: "deneme1");
    }
    void IsimlendirilmisParametre(string s1, string s2 = "varsayilan", int i = 0)
    {
      MessageBox.Show($"{s1} | {s2} | {i}");
    }


    private void button19_Click(object sender, EventArgs e)
    {
      Form2 form2 = new Form2();
      form2.Show();
    }

    private void button20_Click(object sender, EventArgs e)
    {
      DirSearch("C:\\VMs");
    }
    void DirSearch(string sDir)
    {
      try
      {
        listBox1.Items.Add(sDir);
        foreach (string f in Directory.GetFiles(sDir))
          listBox1.Items.Add(f);
        foreach (string d in Directory.GetDirectories(sDir))
          DirSearch(d);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }

    private void button21_Click(object sender, EventArgs e)
    {
      MessageBox.Show(publicStaticSayi.ToString());
      publicStaticSayi = 111;

      MessageBox.Show(publicSayi.ToString());
      publicSayi = 1111;


    }

    private void button22_Click(object sender, EventArgs e)
    {
      IntMinMaxGoster();
      int kelimesayisi = KacKelimeVar("    Cumartesi günü kursa geldik    ");
      MessageBox.Show($"Kelime sayýsý = {kelimesayisi}");
    }
    public static void IntMinMaxGoster()
    {
      int mindeger = int.MinValue;
      int maxdeger = int.MaxValue;
      int defaultdeger = default(int);
      string sonuc = $"Int.Min={mindeger}, Max={maxdeger}, Default={defaultdeger}";
      MessageBox.Show(sonuc);
    }
    public int KacKelimeVar(string cumle)
    {
      int sayac = 0;
      cumle = cumle.Trim();
      for (int i = 0; i < cumle.Length; i++)
      {
        if (cumle[i].ToString() == " ")
        {
          sayac++;
        }
      }
      return sayac + 1;
    }

    private void button23_Click(object sender, EventArgs e)
    {
      DataTable dt = new DataTable();
      dt.Columns.Add("OrganizationId", typeof(int));
      dt.Columns.Add("Id", typeof(int));
      dt.Columns.Add("Defination", typeof(string));
      dt.Rows.Add(0, 1, "Genel Müdürlük");
      dt.Rows.Add(1, 2, "Bilgi Ýþlem");
      dt.Rows.Add(1, 3, "Finans");
      dt.Rows.Add(2, 4, "Yazýlým");
      dt.Rows.Add(2, 5, "Sistem");
      dt.Rows.Add(5, 6, "Server");

      string menu = "";
      string data = "";
      foreach (DataRow row in dt.Rows)
      {
        if (row["OrganizationId"].ToString() == "0")
        {
          data = row["Defination"].ToString();

        }
        else
        {
          string tempId = row["Id"].ToString();
          while (tempId != "0")
          {
            foreach (DataRow item in dt.Rows)
            {
              if (item["Id"].ToString() == tempId)
              {
                if (item["OrganizationId"].ToString() != "0")
                  data =  ">" + item["Defination"].ToString() + data;
                else
                  data = item["Defination"].ToString() + data;
                tempId = item["OrganizationId"].ToString();
                break;
              }
            }
          }
        }
        menu += data + Environment.NewLine;
        data = "";
      }
      MessageBox.Show(menu);
    }
  }
}