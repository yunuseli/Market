using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WinFormEFSqLite
{
  public class Category
  {
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ObservableCollectionListSource<Product> Products { get; } = new();
  }
}

/*
  "Category" sınıfı, ürün kategorileri için bir modeldir. "CategoryId" özelliği, her kategori için benzersiz bir kimlik belirleyicisidir. 
  "Name" özelliği, kategori adını içerir. 
  "Products" özelliği, bir kategoriye ait ürünlerin koleksiyonunu tutar.

  "ProductId" özelliği, her ürün için benzersiz bir kimlik belirleyicisidir. 
  "Name" özelliği, ürün adını içerir. 
  "CategoryId" özelliği, ürünün hangi kategoriye ait olduğunu belirler. 
  "Category" özelliği, ürünün ait olduğu kategoriyi temsil eden bir referanstır.

  Product sınıfının Category özelliği, ürünün kategori nesnesine erişim sağlar. 
  Bu özellik, Product sınıfının CategoryId özelliği ile Category sınıfının 
  CategoryId özelliği arasındaki ilişkiyi temsil eder. Category özelliği, 
  Product sınıfına ait bir kategori nesnesini ifade eder.
 */

/*
  Category sınıfının Products özelliği, ObservableCollectionListSource sınıfından 
  türetilen bir koleksiyondur. Bu koleksiyon, Product sınıfı öğelerini içerir.

  Bu kod örneği C# 9.0 sürümünde kullanılan yeni özelliklerden biri olan init özelliğini içeriyor. 
  init özelliği, sadece yapıcılar veya nesne ilk oluşturulduğu sırada atama işlemlerinde 
  kullanılabilen bir özelliktir ve nesnenin özelliklerinin daha sonra değiştirilmesini engeller.

  Ayrıca, ObservableCollectionListSource sınıfı da bir koleksiyon özelliğidir ve 
  ObservableCollection sınıfından türetilmiştir. Bu sınıf, koleksiyonun elemanlarından herhangi biri 
  değiştirildiğinde veya koleksiyona yeni bir öğe eklendiğinde, koleksiyonu kullanan herhangi 
  bir kontrolün bu değişikliği görmesini sağlar.

  ***
  Category nesnesi oluşturulduğunda, Products özelliği zaten yeni bir ObservableCollectionListSource 
  nesnesiyle başlatılmıştır ve bu özellik artık değiştirilemez durumdadır. Bu nedenle, bu özellik üzerindeki 
  herhangi bir değişiklik yapılamaz, örneğin bir farklı ObservableCollectionListSource örneği atanamaz.

  Ancak, özellik değerlerinin yanı sıra ilişkili nesnelerin yüklenmesi veya yükleme zamanında değiştirilmesi 
  gibi özelliklerle ilgili değişiklikler yapmak mümkündür. Bu örnekte, 
  dbContext.Entry(category).Collection(e => e.Products).Load() yöntemi kullanılarak, 
  Category nesnesinin ilişkili Product nesnelerinin yüklenmesi sağlanabilir.


  -----
  Virtual olarak işaretlenen özellikler, Entity Framework gibi ORM araçları tarafından lazy loading 
  özelliğinin kullanılmasına izin verir. Lazy loading, bir nesnenin ilişkili nesnelerinin gerektiği 
  zaman yüklenmesine izin verir. Bu, özellikle büyük veritabanlarında performans açısından faydalıdır, 
  çünkü sadece gerekli olan veriler yüklenir ve gereksiz veriler yüklenmez.

  Örneğin, yukarıdaki örnekte, bir kategori nesnesi yüklendiğinde, ilişkili ürün nesneleri yüklenmeyecek. 
  Ancak, Category.Products özelliğine erişildiğinde, ilişkili ürünler yüklenir. 
  Bu, performansı artırır çünkü veritabanından yalnızca ihtiyaç duyulan veriler yüklenir ve gereksiz veriler yüklenmez. 
  Ayrıca, bir nesnenin tüm ilişkili nesneleri yüklenmeden önce erişilmesi gereken durumlarda da yararlıdır.


 */