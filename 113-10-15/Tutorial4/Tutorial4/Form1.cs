namespace Tutorial4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double average;

            kms = double.Parse(txbKM.Text);
            liters = double.Parse(txbLiter.Text);
            average = kms / liters;

            lblShow.Text = average.ToString("f2");
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
