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
            string fullName;//�ܼƤ@�w�n���ŧi���A��A�~�i�H�ϥ�
            string firstName;
            string lastName;

            firstName = txtfirstname.Text;
            lastName=txtlastname.Text;
            fullName = lastName + "" + firstName;

            lebshow.Text= fullName;
        }
    }
}
