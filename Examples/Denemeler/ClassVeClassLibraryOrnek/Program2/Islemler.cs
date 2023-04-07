using BenimKutuphanem.Diziler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
  public partial class Islemler : Form
  {
    public Islemler()
    {
      InitializeComponent();
    }

    BenimKutuphanem.Hesaplamalar hesaplamalar = new BenimKutuphanem.Hesaplamalar();  // ClassLibrary
    StackSinifi stackSinifi = new StackSinifi();
    QueueSinifi queueSinifi = new QueueSinifi();

    private void Islemler_Load(object sender, EventArgs e)
    {
      radioButtonTopla.Checked = true;
      lblSonuc.Text = string.Empty;
    }

    string OperatorBul()
    {
      // bu metot ile panel içindeki radiobuttonlar içinde dönüp, radioButton nesnesine atayıp,
      // işaretli olanı buluyoruz ve tag içine yazılan operatör bilgisini geri dönüyoruz
      string opr = "";
      foreach (var control in panelIslemSec.Controls)
      {
        //if (control is RadioButton)
        //{
        RadioButton radio = control as RadioButton;
        if (radio != null && radio.Checked)
          opr = radio.Tag.ToString();
        //}
      }
      return opr;
    }

    private void buttonIslem4_Click(object sender, EventArgs e)
    {
      // ClassLibrary içindeki sınıfa tanımlanan metot üzerinden işlem
      string sonuc = hesaplamalar.DortIslemIkiSayi(txtSayi1.Text, txtSayi2.Text, OperatorBul());
      if (sonuc.StartsWith("Hata"))
        MessageBox.Show(sonuc);
      else
        lblSonuc.Text = sonuc;
    }

    private void buttonTemizle1_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
    }

    private void buttonStackEkle_Click(object sender, EventArgs e)
    {
      stackSinifi.Ekle(textBoxYigin.Text);

      listBox2.DataSource = stackSinifi.Liste();
    }

    private void buttonStackGetir_Click(object sender, EventArgs e)
    {
      listBox1.Items.Add(stackSinifi.Getir());

      listBox2.DataSource = stackSinifi.Liste();
    }

    private void buttonQEkle_Click(object sender, EventArgs e)
    {
      queueSinifi.Ekle(textBoxYigin.Text);

      listBox2.DataSource = queueSinifi.Liste();
    }

    private void buttonQGetir_Click(object sender, EventArgs e)
    {
      listBox1.Items.Add(queueSinifi.Getir());

      listBox2.DataSource = queueSinifi.Liste();
    }
  }
}
