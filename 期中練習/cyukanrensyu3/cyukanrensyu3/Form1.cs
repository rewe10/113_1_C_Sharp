using System.Runtime.Intrinsics.X86;

namespace cyukanrensyu3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Kg;
            double M;
            double BMI;
            Kg = double.Parse(texKg.Text);
            M = double.Parse(texM.Text);
            BMI = Kg / (M * M);
            labBMI.Text=BMI.ToString("n2");
            if (BMI < 18.5)
            {
                labKarada.Text = "過輕";
            }
            else if (BMI >= 18.5 && BMI <= 25)
            {
                labKarada.Text = "正常";
            }
            else
            {
                labKarada.Text = "過重";
            }
        }
    }
}
