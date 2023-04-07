using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Market.Test.Uygulamalar
{
  public partial class EmailTest : Form
  {
    public EmailTest()
    {
      InitializeComponent();
    }

    #region sf
    //*******
    string sifrem = "spvvjjygzoqteauh";
    //************ 
    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
    {

      System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
      mail.To.Add("fuat.asik@input.com.tr");
      mail.From = new MailAddress("fuat.input@gmail.com", "Fuat AŞIK", System.Text.Encoding.UTF8);
      mail.Subject = "Mail Deneme";
      mail.SubjectEncoding = System.Text.Encoding.UTF8;
      mail.Body = "Merhaba, bu maili ben programladım";
      mail.BodyEncoding =  System.Text.Encoding.UTF8;
      mail.IsBodyHtml = true;
      mail.Priority = MailPriority.High;

      SmtpClient client = new SmtpClient();
      client.DeliveryMethod = SmtpDeliveryMethod.Network;
      client.UseDefaultCredentials = false;
      client.Credentials = new System.Net.NetworkCredential("fuat.input@gmail.com", sifrem);
      client.Port = 587;
      client.Host = "smtp.gmail.com";
      client.EnableSsl = true;

      try
      {
        client.Send(mail);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

  }
}
