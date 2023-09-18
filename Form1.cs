namespace Calculator
{
    public partial class Form1 : Form
    {
        double sonuc = 0;
        string islem = " ";
        bool yapilanIslem = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BT_CL(object sender, EventArgs e)
        {
            if (MTBOX.Text == "0" || yapilanIslem)
            {
                MTBOX.Clear();
            }
            Button X = (Button)sender;
            yapilanIslem = false;
            if (X.Text == ",")
            {
                if (!MTBOX.Text.Contains(","))
                {
                    MTBOX.Text = MTBOX.Text + X.Text;

                }
            }
            else
            {
                MTBOX.Text = MTBOX.Text + X.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OP_CL(object sender, EventArgs e)
        {
            Button Y = (Button)sender;
            yapilanIslem = true;
            islem = Y.Text;
            sonuc = double.Parse(MTBOX.Text);
            label1.Text = sonuc + " " + islem;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    MTBOX.Text = (sonuc + double.Parse(MTBOX.Text)).ToString();
                    break;
                case "-":
                    MTBOX.Text = (sonuc - double.Parse(MTBOX.Text)).ToString();
                    break;
                case "*":
                    MTBOX.Text = (sonuc * double.Parse(MTBOX.Text)).ToString();
                    break;
                case "/":
                    MTBOX.Text = (sonuc / double.Parse(MTBOX.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MTBOX.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MTBOX.Clear();
            label1.Text = "";
        }
    }
}