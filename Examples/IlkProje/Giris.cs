using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkProje
{
  public partial class Giris : Form
  {
    public Giris()
    {
      InitializeComponent();
    }

    string user = "admin";
    string password = "1234";

    private void btnLogin_Click(object sender, EventArgs e)
    {
      string u = txtUserName.Text;
      string p = txtPassword.Text;
      if (u == user && p == password)
      {
        //MessageBox.Show("Giriş Başarılı");
        // (https://www.gencayyildiz.com/blog/cta-programatik-nesne-olusturma/)
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

        Form1 form1 = new Form1();
        this.Hide();
        form1.ShowDialog();
      }
      else
      {
        MessageBox.Show("Hatalı kullanıcı adı yada şifre");
      }
    }
  }
}
