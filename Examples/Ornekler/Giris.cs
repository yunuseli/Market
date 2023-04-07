

namespace Ornekler
{
  public partial class Giris : Form
  {
    public Giris()
    {
      InitializeComponent();
    }

    //https://www.iconfinder.com/

    string kullaniciAdi = "";
    string kullaniciSifre = "";

    private void Giris_Load(object sender, EventArgs e)
    {
      kullaniciAdi = "admin";
      kullaniciSifre = "1234";

      this.MinimizeBox = false;
      this.MaximizeBox = false;
      this.BackColor = Color.YellowGreen;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;


      btnGiris.BackColor = Color.AliceBlue;

      txtKullanici.Text = kullaniciAdi;
      txtSifre.Text = kullaniciSifre;

      //**** Giriş butonunun click olayını otomatik çağırma
      btnGiris_Click(null, null);

    }

    private void btnGiris_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("Giriş Başarılı");
      /*
        Bir formdan başka bir formu açmak için new operatörü ile kullanılacak 
      formun (nesnenin) yeni bir örneğini oluşturmamız gerek.
        new operatörü, talep edilecek olan nesnenin hangi sınıftan olacağını 
      kesin bilmek ister ve dolayısıyla bu ihtiyacını ilgili sınıfın tarafımızdan 
      belirtilerek giderilmesini istemektedir.
        Form aslında bir sınıftır (class). Dikkat ederseniz bu sayfanın en üstünde namespace
      altında "public partial class Giris : Form" şeklinde balar.
        Sınıf (class) soyut (abstract) bir veri tipidir ve kullanmak için somut (concrete) olan bir nesne (object)
      haline getirmeliyiz. 
        Bu sayede diğer formun özelliklerini kullanabiliriz.
      */

      if (txtKullanici.Text == kullaniciAdi && txtSifre.Text == kullaniciSifre)
      {
        Menu menu = new Menu();
        this.Hide();
        menu.ShowDialog();
      }
      else
      {
        MessageBox.Show("Hatalı kullanıcı adı yada şifre");
      }

    }
  }
}
