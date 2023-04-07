namespace MerhabaClass2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      MerhabaClassKutuphanesi.Islemler islemler2 = new MerhabaClassKutuphanesi.Islemler();
      MessageBox.Show(islemler2.Toplama(textBox1.Text, textBox2.Text));

    }
  }
}