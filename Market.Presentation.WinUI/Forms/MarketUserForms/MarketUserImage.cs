namespace Market.Presentation.WinUI.Forms.MarketUserForms
{
  public partial class MarketUserImage : Form
  {
    public MarketUserImage()
    {
      InitializeComponent();
    }

    public byte[] ImageBytes { get; set; }

    private void Form_Load(object sender, EventArgs e)
    {
      pbImage.Image = Image.FromStream(new MemoryStream(ImageBytes));
      pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    private void pbImage_MouseLeave(object sender, EventArgs e)
    {
      this.Close();
    }
  } // EOF
}
