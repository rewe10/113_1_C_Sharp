namespace WinFormsApp1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDest_TextChanged(object sender, EventArgs e)
        {

        }
        `
        private void Btnshowday_Click(object sender, EventArgs e)
        {
            string output;

            output = "民國" + txtyear.Text + "年" + txtmonth.Text + "月" + txtDest.Text + "日" + "星期" + txtdayofweek.Text;

            lblShow.Text = output;
        }

        private void Btncltar_Click(object sender, EventArgs e)
        {
            txtdayofweek.Text = "";
            txtDest.Text = "";
            txtmonth.Text = "";
            txtyear.Text = "";
            lblShow.Text = "";
        }

        private void Btntxit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
