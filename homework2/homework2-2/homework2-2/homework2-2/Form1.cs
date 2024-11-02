namespace homework2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            decimal okane;
            int A;
            okane = decimal.Parse(texIntput.Text);

            if (okane <= 100)
            {
                A = 1;
            }
            else if (okane >= 101 || okane <= 500)
            {
                A = 5;
            }
            else if (okane >= 501 || okane <= 1000)
            {
                A = 10;
            }
            else if (okane >= 1001 || okane <= 2000)
            {
                A = 15;
            }
            else if (okane > 2001) ;
            {
                A = 20;
            }
            labOutput.Text = A.ToString("c");
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            labOutput.Text = "";
            texIntput.Text = "";
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}