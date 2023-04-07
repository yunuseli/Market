namespace HesapMakinasi
{
    public partial class HesapMak : Form
    {
        public HesapMak()
        {
            InitializeComponent();
        }

        double oncekiDeger = 0;
        string oncekiOperator = "";
        double yeniDeger = 0;
        string yeniOperator = "";
        bool sonBasilanOperator = false;

        private void HesapMak_Load(object sender, EventArgs e)
        {
            
            this.KeyPreview = true;

            txtGiris.Text = "0";
            txtGiris.TextAlign = HorizontalAlignment.Right;
            txtGiris.Focus();
            txtGiris.Select(txtGiris.Text.Length, 0);

            lblIslem.Text = "";
        }

        private void button_Click(object sender, EventArgs e)
        {
            veriGirisi(((Button)sender).Text);
        }

        private void HesapMak_KeyDown(object sender, KeyEventArgs e)
        {
            // klavyeden basılan tuşu yakalayıp, buton işlemini tetikleme
            switch (e.KeyData)
            {
                case Keys.D0:
                    btn0.PerformClick();
                    break;
                case Keys.D1:
                    btn1.PerformClick();
                    break;
                case Keys.D2:
                    btn2.PerformClick();
                    break;
                case Keys.D3:
                    btn3.PerformClick();
                    break;
                case Keys.D4:
                    btn4.PerformClick();
                    break;
                case Keys.D5:
                    btn5.PerformClick();
                    break;
                case Keys.D6:
                    btn6.PerformClick();
                    break;
                case Keys.D7:
                    btn7.PerformClick();
                    break;
                case Keys.D8:
                    btn8.PerformClick();
                    break;
                case Keys.D9:
                    btn9.PerformClick();
                    break;

                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;

                case Keys.Oemcomma:
                    btnComma.PerformClick();
                    break;
                case Keys.OemPeriod:
                    btnComma.PerformClick();
                    break;
                case Keys.Decimal:
                    btnComma.PerformClick();
                    break;

                case Keys.Multiply:
                    btnMultiply.PerformClick();
                    break;
                case Keys.Add:
                    btnAdd.PerformClick();
                    break;
                case Keys.Subtract:
                    btnSubtract.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivide.PerformClick();
                    break;
                case Keys.OemMinus:
                    btnSubtract.PerformClick();
                    break;

                default:
                    break;
            }

            // klavye tuşunu iptal etme
            e.SuppressKeyPress = true;
        }

        private void veriGirisi(string deger)
        {
            string giris = txtGiris.Text;
            switch (deger)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (sonBasilanOperator)
                    {
                        sonBasilanOperator = false;
                        giris = string.Empty;
                    }
                    giris += deger;
                    break;

                case ",":
                    if (sonBasilanOperator)
                    {
                        sonBasilanOperator = false;
                        giris = string.Empty;
                    }
                    if (!giris.Contains(","))
                        giris += deger;
                    break;

                case "«": // Son sayıyı sil
                    if (giris.Length > 0)
                        giris = giris.Remove(giris.Length - 1, 1);
                    break;

                case "C": // Tümünü temizle
                    giris = string.Empty;
                    oncekiDeger = 0;
                    oncekiOperator = "";
                    yeniDeger = 0;
                    yeniOperator = "";
                    lblIslem.Text = string.Empty;
                    break;
                case "CE": // Son girişi temizle
                    giris = string.Empty;
                    break;

                case "+":
                case "-":
                case "x":
                case "/":
                case "x²":
                case "√":
                case "Sin":
                case "1/x":
                case "|x|":
                    if (sonBasilanOperator)
                    {
                        if (lblIslem.Text.Substring(lblIslem.Text.Length - 1, 1) == "=")
                            lblIslem.Text = $"{oncekiDeger} {oncekiOperator}";
                        lblIslem.Text = lblIslem.Text.Remove(lblIslem.Text.Length - 1, 1) + deger;
                        oncekiOperator = deger;
                        return;
                    }
                    if (giris.Length == 0)
                        return;
                    yeniDeger = Convert.ToDouble(giris);
                    yeniOperator = deger;
                    Hesap();
                    txtGiris.Focus();
                    txtGiris.Select(txtGiris.Text.Length, 0);
                    sonBasilanOperator = true;
                    return;

                case "=":

                    if (giris.Length == 0)
                        return;
                    yeniDeger = Convert.ToDouble(giris);
                    double hesap = HesapIslem();
                    if (yeniOperator == "x²")
                        lblIslem.Text = $"{oncekiDeger}{oncekiOperator}";
                    else if (yeniOperator == "√")
                    {
                        lblIslem.Text = $"{oncekiOperator}{oncekiDeger}";
                    }
                    else if (yeniOperator == "1/x")
                        lblIslem.Text = $"1/({yeniDeger})";
                    else if (yeniOperator == "|x|")
                        lblIslem.Text = $"|{yeniDeger}|";
                    else
                        lblIslem.Text = $"{oncekiDeger} {oncekiOperator} {yeniDeger} =";

                    txtGiris.Text = hesap.ToString();
                    oncekiDeger = hesap;
                    txtGiris.Focus();
                    txtGiris.Select(txtGiris.Text.Length, 0);
                    sonBasilanOperator = true;
                    return;

                case "±":
                    if (giris.StartsWith("-"))
                        giris = giris.Remove(0, 1);
                    else
                        giris = "-" + giris;
                    break;

                default:
                    break;
            }

            // Virgülle başladı ise 0, yap
            if (giris.StartsWith(",") && giris.Length == 1)
                giris = $"0{giris}";

            // Sıfırla başladı ise, arkadan gelen virgül değilse, baştaki sıfırı sil
            if (giris.StartsWith("0") && giris.Length > 1 && giris[1].ToString() != ",")
                giris = giris.Remove(0, 1);

            if (giris == string.Empty)
                giris = "0";
            txtGiris.Text = giris;
            txtGiris.Focus();
            txtGiris.Select(txtGiris.Text.Length, 0);
        }

        private void Hesap()
        {
            double hesap = HesapIslem();

            //lblIslem.Text = $"{lblIslem.Text} {yeniDeger.ToString()} {yeniOperator}";
            oncekiDeger = hesap;
            oncekiOperator = yeniOperator;
            lblIslem.Text = $"{hesap} {yeniOperator}";
            txtGiris.Text = hesap.ToString();


            
        }
        private double HesapIslem()
        {
            double hesap = 0;
            if (oncekiOperator == "")
            {
                hesap = yeniDeger;
            }
            else
            {
                switch (oncekiOperator)
                {
                    case "+":
                        hesap = oncekiDeger + yeniDeger;
                        break;
                    case "-":
                        hesap = oncekiDeger - yeniDeger;
                        break;
                    case "x":
                        hesap = oncekiDeger * yeniDeger;
                        break;
                    case "/":
                        hesap = oncekiDeger / yeniDeger;
                        break;
                    case "x²":
                        hesap = yeniDeger * yeniDeger;
                        break;
                    case "√":
                        hesap = Math.Sqrt(yeniDeger);
                        break;
                    case "1/x":
                        hesap = 1/oncekiDeger;
                        break;
                    case "|x|":
                        hesap = Math.Abs(yeniDeger);
                        break;
                    default:
                        break;
                }
            }
            return hesap;
        }

    } // Form Sonu
}