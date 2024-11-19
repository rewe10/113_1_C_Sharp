namespace Q2
{
    public partial class Form1 : Form
    {
        const decimal b = 115;
        const decimal a = 80;
        const decimal o = 90;
        const decimal l = 120;
        private decimal total = 0m;
        private bool isBananaAdded = false;
        private bool isAppleAdded = false;
        private bool isOrangeAdded = false;
        private bool isPearAdded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void butReset_Click(object sender, EventArgs e)
        {

            total = 0;
            laboutput.Text = "0";
            isAppleAdded = false;
            isOrangeAdded = false;
            isPearAdded = false;
            isBananaAdded = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isAppleAdded)
            {
                total = total - a;
                isAppleAdded = false;
                laboutput.Text = total.ToString();
            }
            else 
            {
                total = total + a;
                isAppleAdded = true;
                laboutput.Text = total.ToString();
            }
        }

        private void picB_Click(object sender, EventArgs e)
        {
            if (isBananaAdded)
            {
                total = total - b;
                isBananaAdded = false;
                laboutput.Text = total.ToString();
            }
            else
            {
                total = total + b;
                isBananaAdded = true;
                laboutput.Text = total.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isOrangeAdded)
            {
                total = total - o;
                isOrangeAdded = false;
                laboutput.Text = total.ToString();
            }
            else
            {
                total = total + o;
                isOrangeAdded = true;
                laboutput.Text = total.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isPearAdded)
            {
                total = total - l;
                isPearAdded = false;
                laboutput.Text = total.ToString();
            }
            else
            {
                total = total + l;
                isPearAdded = true;
                laboutput.Text = total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
