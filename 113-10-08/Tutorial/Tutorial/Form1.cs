namespace Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblShow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LblShow.Text = "����";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LblShow.Text = "�k��";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LblShow.Text = "�w��";
        }
    }
}
