namespace homework2_1
{
    public partial class Form1 : Form
    {
        private int totalSum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            decimal A;
            decimal B;
            decimal C;
            decimal D;
            decimal OutputA;
            decimal OutputB;
            decimal OutputC;
            A = decimal.Parse(texInputA.Text);
            B = decimal.Parse(texInputB.Text);
            C = decimal.Parse(texInputC.Text);

            OutputA = A * 15;
            OutputB = B * 12;
            OutputC = C * 9;
            D = A * 15 + B * 12 + C * 9;

            labOutputAll.Text = D.ToString("c");
            labOutputA.Text = OutputA.ToString("c");
            labOutputB.Text = OutputB.ToString("c");
            labOutputC.Text = OutputC.ToString("c");
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            labOutputAll.Text = "";
            labOutputA.Text = "";
            labOutputB.Text = "";
            labOutputC.Text = "";
            texInputA.Text = "";
            texInputB.Text = "";
            texInputC.Text = "";
        }

        private void butExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
