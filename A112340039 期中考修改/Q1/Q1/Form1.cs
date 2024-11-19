namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butArea_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            a = double.Parse(texa.Text);
            b = double.Parse(texb.Text);
            c = a * b;

            labOutput.Text = c.ToString("n2");
        }

        private void butBoun_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            a = double.Parse(texa.Text);
            b = double.Parse(texb.Text);
            c = (a + b) * 2;
            labOutput.Text = c.ToString("n2");
        }

        private void butCost_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            double d;
            a = double.Parse(texa.Text);
            b = double.Parse(texb.Text);
            c = double.Parse(texc.Text);
            d = c * 2 * (a + b);
            labOutput.Text = d.ToString("n2");
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
