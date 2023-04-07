using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace WinFormEFSqLite
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    //https://learn.microsoft.com/tr-tr/ef/core/get-started/winforms

    private ProductsContext? dbContext;

    private void MainForm_Load(object sender, EventArgs e)
    {

    }
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      dbContext = new ProductsContext();

      // Uncomment the line below to start fresh with a new database.
      // this.dbContext.Database.EnsureDeleted();
      dbContext.Database.EnsureCreated();

      dbContext.Categories.Load();

      categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
    }
    protected override void OnClosing(CancelEventArgs e)
    {
      base.OnClosing(e);

      dbContext?.Dispose();
      dbContext = null;     
    }

    private void gvCategory_SelectionChanged(object sender, EventArgs e)
    {
      if (dbContext != null)
      {
        var category = (Category)this.gvCategory.CurrentRow.DataBoundItem;

        if (category != null)
        {
          dbContext.Entry(category).Collection(e => e.Products).Load();
        }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {

      dbContext!.SaveChanges();

      gvCategory.Refresh();
      gvProducts.Refresh();
    }


  }
}



//Null-Conditional Operator (?)
//Null Coalescing Operator (??)
//Null Coalescing Assignment Operator (??=)
//Null-forgiving Operator (!) C# 8.0

//Safer Nullability
/* 
  Null-forgiving Operator (!) C# 8.0 

  //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving

  Bu operat�r, bir de�i�kenin veya �zelli�in null olmad���ndan emin oldu�umuzda kullan�l�r.
  Null-forgiving operator, bir de�i�kenin veya �zelli�in de�erini kullan�rken kullan�l�r. 
  Normalde, bir de�i�ken veya �zellik nullable oldu�unda, bunun null olmad���ndan emin olmak 
  i�in null kontrol� yapmam�z gerekir. Ancak null-forgiving operat�r� kullanarak, 
  null olmad���ndan emin oldu�umuz bir de�i�ken veya �zellik i�in null kontrol� yapmam�z gerekmez.
  
  �rne�in, a�a��daki kodda myNullableString de�i�keni nullable bir string'dir ve null kontrol� yapmadan kullan�l�r:
  string? myNullableString = null;
  string myNonNullString = myNullableString!;
    myNullableString! ifadesinde ! operat�r�, myNullableString de�i�keninin null olmad���n� garanti etti�imizi belirtir. 
    B�ylece, myNonNullString de�i�kenine atama yaparken, null kontrol� yapmam�za gerek yoktur.

  Null-forgiving operator�n kullan�m�, dikkatli olunmas� gereken bir durumdur. 
  De�i�kenin veya �zelli�in asl�nda null olmas� durumunda, bu operat�r kullan�ld���nda hata al�n�r. 
  Bu nedenle, null-forgiving operator�n kullan�m�, null olmad���ndan emin oldu�umuz durumlarda s�n�rl� olarak kullan�lmal�d�r.
*/

/* 
  Null-Conditional Operator (?) C# 6.0 

  Null-Conditional Operator, programc�lara null olan nesneler �zerinde daha g�venli i�lemler yapma 
  imkan� veren bir operat�rd�r. Bu operat�r, bir nesnenin null olup olmad���n� kontrol etmeden 
  �nce i�lemler yap�lmas�na izin verir.

  Null-Conditional Operator, ? i�aretiyle temsil edilir. Bu operat�r, bir nesnenin null olup olmad���n� 
  kontrol eder ve nesne null ise i�lem yapmadan null de�erini d�nd�r�r. 
  E�er nesne null de�ilse, normal i�lemi yapar. 

  �rne�in:
  Person person = null;
  string name = person?.Name;
  Bu kod, person nesnesinin null olup olmad���n� kontrol eder. person null ise, 
  name de�i�kenine null de�er atan�r. E�er person null de�ilse, Name �zelli�i normal �ekilde atan�r.

  Null-Conditional Operator ayr�ca y�ntem �a�r�lar� ve dizin eri�imi gibi di�er i�lemler i�in de kullan�labilir. 

  �rne�in:
  List<int> numbers = null;
  int? firstNumber = numbers?[0];
  Bu kod, numbers nesnesinin null olup olmad���n� kontrol eder ve null ise, firstNumber de�i�kenine null de�er atan�r. 
  E�er numbers null de�ilse ve ilk ��e varsa, firstNumber de�i�kenine ilk ��e atan�r.

  Null-Conditional Operator, kodun okunabilirli�ini art�r�r ve null de�erlerden kaynaklanan hatalar� azalt�r. 
  Ancak, kullan�rken dikkatli olunmas� gerekir ve gereksiz kullan�m� kodun karma��kl���n� art�rabilir.
*/

/* 
  Null Coalescing Operator (??) C# 2.0 

  Null Coalescing Operator (??) C# dilinde s�k�a kullan�lan bir operat�rd�r. 
  Bu operat�r, null bir de�er kontrol� yaparak bir varsay�lan de�er atamam�z� sa�lar.

  �rne�in, bir de�i�kenin null olup olmad���n� kontrol edip null de�ilse de�eri almak 
  istedi�imiz bir senaryoda, Null Coalescing Operator kullanabiliriz. �rnek kullan�m� a�a��daki gibidir:
  int? nullableValue = null;
  int result = nullableValue ?? 10; // nullableValue null ise result 10 olur, null de�ilse nullableValue de�eri atan�r
  Burada ?? operat�r�yle, nullableValue de�i�keninin null olup olmad���n� kontrol ediyoruz. 
  E�er null ise, result de�i�kenine 10 de�eri atan�r. E�er nullableValue null de�ilse, result de�i�kenine 
  nullableValue de�i�keninin de�eri atan�r.

  Null Coalescing Operator'� ayn� zamanda zincirleme olarak da kullanabiliriz. 

  �rne�in, bir nesnenin �zelliklerinin null olup olmad���n� kontrol etmek i�in a�a��daki �ekilde kullanabiliriz:
  int? nullableValue1 = null;
  int? nullableValue2 = 20;
  int result = nullableValue1 ?? nullableValue2 ?? 30; // result 20 olur, ��nk� nullableValue1 ve nullableValue2 null
  Bu �rnekte, nullableValue1 ve nullableValue2 de�i�kenlerinin null olup olmad���n� kontrol ediyoruz. 
  E�er her ikisi de null ise, result de�i�kenine 30 de�eri atan�r. E�er bir tanesi null ise, di�eri atan�r. 
  E�er her ikisi de null de�ilse, nullableValue1 de�eri atan�r.

  Null Coalescing Operator, C# dilinde s�k�a kullan�lan ve kodlamay� daha basit hale getiren bir operat�rd�r. 
  Ancak, gereksiz kullan�m� okunabilirli�i azaltabilir, bu y�zden dikkatli bir �ekilde kullan�lmal�d�r.
*/

/* 
  Null Coalescing Assignment Operator (??=) C# 8.0 

  Bu operat�r, bir de�i�kenin null olup olmad���n� kontrol eder ve null de�ilse de�i�kenin mevcut de�erini 
  korurken null ise sa� taraf�ndaki de�eri atar. �zetle, bu operat�r bir de�er atama operat�r�d�r.

  �rnek olarak, bir de�i�kenin null olup olmad���n� kontrol edip null ise yeni bir de�er atamak i�in a�a��daki kod kullan�labilir:
  string name = null;
  name ??= "John Doe"; // e�er name null ise "John Doe" atamas� yap
  Bu kod, name de�i�keninin null olup olmad���n� kontrol eder. E�er name null ise, name de�i�kenine "John Doe" de�eri atan�r. 
  E�er name null de�ilse, mevcut de�er korunur.

  Ayr�ca, null coalescing operator ?? ile birlikte kullanarak daha karma��k ifadeler de yaz�labilir:
  int? number = null;
  int result = number ?? (GetDefaultValue() ?? 0);
  Bu �rnekte, number de�i�keninin null olup olmad��� kontrol edilir. E�er number null ise, GetDefaultValue() metodunun 
  d�n�� de�eri kontrol edilir. E�er GetDefaultValue() da null ise, son olarak 0 de�eri atan�r. Sonu� olarak, 
  result de�i�keni number veya GetDefaultValue() veya 0 de�erlerinden birisini al�r.
*/