using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.DigerOrnekler
{
  public partial class Kelime : Form
  {
    public Kelime()
    {
      InitializeComponent();
    }

    private void Kelime_Load(object sender, EventArgs e)
    {
      lblToplam.Text = string.Empty;
    }

    private void btnBul_Click(object sender, EventArgs e)
    {
      listBoxSonuc.Items.Clear();

      List<string> kelimeListesi = new List<string>();

      string cumle = richTextBoxCumle.Text;
      cumle = cumle.ToLower();
      cumle = cumle.Replace(",", "").Replace(":", "").Replace(".", "").Replace(";", "");
      string[] kelimeler = cumle.Split(' ');

      foreach (string item in kelimeler)
      {
        if (!kelimeListesi.Contains(item))
          kelimeListesi.Add(item);
      }

      kelimeListesi.Sort();

      foreach (string siradakiKelime in kelimeListesi)
      {
        int sayac = 0;
        foreach (string bakilanKelime in kelimeler)
        {
          if (siradakiKelime == bakilanKelime)
            sayac++;
        }

        listBoxSonuc.Items.Add($"{siradakiKelime} -> {sayac} adet");
      }

      lblToplam.Text = $"Toplam Kelime Sayısı = {kelimeler.Count()}";
    }

    private void btnBulHarf_Click(object sender, EventArgs e)
    {
      listBoxSonuc.Items.Clear();

      List<string> harfListesi = new List<string>();

      string cumle = richTextBoxCumle.Text;

      for (int i = 0; i < cumle.Length; i++)
      {
        if (!harfListesi.Contains(cumle[i].ToString()))
          harfListesi.Add(cumle[i].ToString());
      }

      harfListesi.Sort();

      foreach (string siradakiHarf in harfListesi)
      {
        int sayac = 0;
        for (int i = 0; i < cumle.Length; i++)
        {
          if (siradakiHarf == cumle[i].ToString())
            sayac++;
        }

        listBoxSonuc.Items.Add($"{siradakiHarf} -> {sayac} adet");
      }

      lblToplam.Text = $"Toplam Harf Sayısı = {cumle.Length}";
    }
  }
}
