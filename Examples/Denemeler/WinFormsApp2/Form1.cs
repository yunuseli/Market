namespace WinFormsApp2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      panel2.Visible = false;
      panel3.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      panel2.Visible = true;
      panel3.Visible = false;
      panel2.Dock= DockStyle.Fill;
      foreach (Control item in panel2.Controls)
      {
        item.Enabled = false;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      panel3.Visible = true;
      panel2.Visible= false;
      panel3.Dock= DockStyle.Fill;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {

    }
  }
}