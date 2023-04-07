using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Market.Helper.Classes.Encrypt
{
  public class AesHelper
  {
    //https://www.allkeysgenerator.com/Random/Security-Encryption-Key-Generator.aspx

    private string AesMyKey = "E)H@McQfTjWnZr4u7x!z%C*F-JaNdRgU";
    private string AesMyVector = "n2r5u8x/A?D(G-Ka";//n2r5u8x/A?D(G-Ka //abcede0123456789
    public string AesEncrypt(string data)
    {
      byte[] initializationVector = Encoding.ASCII.GetBytes(AesMyVector);
      using (Aes aes = Aes.Create())
      {
        aes.Key = Encoding.UTF8.GetBytes(AesMyKey);
        aes.IV = initializationVector;
        var symmetricEncryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using (var memoryStream = new MemoryStream())
        {
          using (var cryptoStream = new CryptoStream(memoryStream as Stream, symmetricEncryptor, CryptoStreamMode.Write))
          {
            using (var streamWriter = new StreamWriter(cryptoStream as Stream))
            {
              streamWriter.Write(data);
            }
            return Convert.ToBase64String(memoryStream.ToArray());
          }
        }
      }
    }
    public string AesDecrypt(string cipherText)
    {
      byte[] initializationVector = Encoding.ASCII.GetBytes(AesMyVector);
      byte[] buffer = Convert.FromBase64String(cipherText);
      using (Aes aes = Aes.Create())
      {
        aes.Key = Encoding.UTF8.GetBytes(AesMyKey);
        aes.IV = initializationVector;
        var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        using (var memoryStream = new MemoryStream(buffer))
        {
          using (var cryptoStream = new CryptoStream(memoryStream as Stream, decryptor, CryptoStreamMode.Read))
          {
            using (var streamReader = new StreamReader(cryptoStream as Stream))
            {
              return streamReader.ReadToEnd();
            }
          }
        }
      }
    }

  }
}
