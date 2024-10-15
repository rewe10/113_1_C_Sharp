namespace texboxdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string fullName;//變數一定要先宣告型態後，才可以使用
            string firstName;
            string lastName;

            firstName = txtfirstname.Text;
            lastName=txtlastname.Text;
            fullName = lastName + "" + firstName;

            lebshow.Text= fullName;
        }
    }
}
