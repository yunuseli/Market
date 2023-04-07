using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Market.Test.Uygulamalar
{
  public class ReadonlyOrnek
  {
    public readonly int myConstant = 5;
    public readonly string myString;

    public ReadonlyOrnek(string inputString) {
      myString = inputString;
    }
    public void ModifyValues()
    {
     // myConstant = 10; // Bu satır hata verecektir, çünkü myConstant değiştirilemez bir alandır.
      // myString = "new value"; // Bu satır hata verecektir, çünkü myString değiştirilemez bir alandır.
    }

  }
}
