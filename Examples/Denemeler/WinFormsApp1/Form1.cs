namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    int sayac = 0;
    private void timer1_Tick(object sender, EventArgs e)
    {
      sayac++;
      label1.Text = sayac.ToString();
      if (sayac>10)
      {
        timer1.Stop();
      }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      timer1.Interval= 1000;
      timer1.Start();
    }
  }
}