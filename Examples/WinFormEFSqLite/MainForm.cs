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

  Bu operatör, bir deðiþkenin veya özelliðin null olmadýðýndan emin olduðumuzda kullanýlýr.
  Null-forgiving operator, bir deðiþkenin veya özelliðin deðerini kullanýrken kullanýlýr. 
  Normalde, bir deðiþken veya özellik nullable olduðunda, bunun null olmadýðýndan emin olmak 
  için null kontrolü yapmamýz gerekir. Ancak null-forgiving operatörü kullanarak, 
  null olmadýðýndan emin olduðumuz bir deðiþken veya özellik için null kontrolü yapmamýz gerekmez.
  
  Örneðin, aþaðýdaki kodda myNullableString deðiþkeni nullable bir string'dir ve null kontrolü yapmadan kullanýlýr:
  string? myNullableString = null;
  string myNonNullString = myNullableString!;
    myNullableString! ifadesinde ! operatörü, myNullableString deðiþkeninin null olmadýðýný garanti ettiðimizi belirtir. 
    Böylece, myNonNullString deðiþkenine atama yaparken, null kontrolü yapmamýza gerek yoktur.

  Null-forgiving operatorün kullanýmý, dikkatli olunmasý gereken bir durumdur. 
  Deðiþkenin veya özelliðin aslýnda null olmasý durumunda, bu operatör kullanýldýðýnda hata alýnýr. 
  Bu nedenle, null-forgiving operatorün kullanýmý, null olmadýðýndan emin olduðumuz durumlarda sýnýrlý olarak kullanýlmalýdýr.
*/

/* 
  Null-Conditional Operator (?) C# 6.0 

  Null-Conditional Operator, programcýlara null olan nesneler üzerinde daha güvenli iþlemler yapma 
  imkaný veren bir operatördür. Bu operatör, bir nesnenin null olup olmadýðýný kontrol etmeden 
  önce iþlemler yapýlmasýna izin verir.

  Null-Conditional Operator, ? iþaretiyle temsil edilir. Bu operatör, bir nesnenin null olup olmadýðýný 
  kontrol eder ve nesne null ise iþlem yapmadan null deðerini döndürür. 
  Eðer nesne null deðilse, normal iþlemi yapar. 

  Örneðin:
  Person person = null;
  string name = person?.Name;
  Bu kod, person nesnesinin null olup olmadýðýný kontrol eder. person null ise, 
  name deðiþkenine null deðer atanýr. Eðer person null deðilse, Name özelliði normal þekilde atanýr.

  Null-Conditional Operator ayrýca yöntem çaðrýlarý ve dizin eriþimi gibi diðer iþlemler için de kullanýlabilir. 

  Örneðin:
  List<int> numbers = null;
  int? firstNumber = numbers?[0];
  Bu kod, numbers nesnesinin null olup olmadýðýný kontrol eder ve null ise, firstNumber deðiþkenine null deðer atanýr. 
  Eðer numbers null deðilse ve ilk öðe varsa, firstNumber deðiþkenine ilk öðe atanýr.

  Null-Conditional Operator, kodun okunabilirliðini artýrýr ve null deðerlerden kaynaklanan hatalarý azaltýr. 
  Ancak, kullanýrken dikkatli olunmasý gerekir ve gereksiz kullanýmý kodun karmaþýklýðýný artýrabilir.
*/

/* 
  Null Coalescing Operator (??) C# 2.0 

  Null Coalescing Operator (??) C# dilinde sýkça kullanýlan bir operatördür. 
  Bu operatör, null bir deðer kontrolü yaparak bir varsayýlan deðer atamamýzý saðlar.

  Örneðin, bir deðiþkenin null olup olmadýðýný kontrol edip null deðilse deðeri almak 
  istediðimiz bir senaryoda, Null Coalescing Operator kullanabiliriz. Örnek kullanýmý aþaðýdaki gibidir:
  int? nullableValue = null;
  int result = nullableValue ?? 10; // nullableValue null ise result 10 olur, null deðilse nullableValue deðeri atanýr
  Burada ?? operatörüyle, nullableValue deðiþkeninin null olup olmadýðýný kontrol ediyoruz. 
  Eðer null ise, result deðiþkenine 10 deðeri atanýr. Eðer nullableValue null deðilse, result deðiþkenine 
  nullableValue deðiþkeninin deðeri atanýr.

  Null Coalescing Operator'ü ayný zamanda zincirleme olarak da kullanabiliriz. 

  Örneðin, bir nesnenin özelliklerinin null olup olmadýðýný kontrol etmek için aþaðýdaki þekilde kullanabiliriz:
  int? nullableValue1 = null;
  int? nullableValue2 = 20;
  int result = nullableValue1 ?? nullableValue2 ?? 30; // result 20 olur, çünkü nullableValue1 ve nullableValue2 null
  Bu örnekte, nullableValue1 ve nullableValue2 deðiþkenlerinin null olup olmadýðýný kontrol ediyoruz. 
  Eðer her ikisi de null ise, result deðiþkenine 30 deðeri atanýr. Eðer bir tanesi null ise, diðeri atanýr. 
  Eðer her ikisi de null deðilse, nullableValue1 deðeri atanýr.

  Null Coalescing Operator, C# dilinde sýkça kullanýlan ve kodlamayý daha basit hale getiren bir operatördür. 
  Ancak, gereksiz kullanýmý okunabilirliði azaltabilir, bu yüzden dikkatli bir þekilde kullanýlmalýdýr.
*/

/* 
  Null Coalescing Assignment Operator (??=) C# 8.0 

  Bu operatör, bir deðiþkenin null olup olmadýðýný kontrol eder ve null deðilse deðiþkenin mevcut deðerini 
  korurken null ise sað tarafýndaki deðeri atar. Özetle, bu operatör bir deðer atama operatörüdür.

  Örnek olarak, bir deðiþkenin null olup olmadýðýný kontrol edip null ise yeni bir deðer atamak için aþaðýdaki kod kullanýlabilir:
  string name = null;
  name ??= "John Doe"; // eðer name null ise "John Doe" atamasý yap
  Bu kod, name deðiþkeninin null olup olmadýðýný kontrol eder. Eðer name null ise, name deðiþkenine "John Doe" deðeri atanýr. 
  Eðer name null deðilse, mevcut deðer korunur.

  Ayrýca, null coalescing operator ?? ile birlikte kullanarak daha karmaþýk ifadeler de yazýlabilir:
  int? number = null;
  int result = number ?? (GetDefaultValue() ?? 0);
  Bu örnekte, number deðiþkeninin null olup olmadýðý kontrol edilir. Eðer number null ise, GetDefaultValue() metodunun 
  dönüþ deðeri kontrol edilir. Eðer GetDefaultValue() da null ise, son olarak 0 deðeri atanýr. Sonuç olarak, 
  result deðiþkeni number veya GetDefaultValue() veya 0 deðerlerinden birisini alýr.
*/