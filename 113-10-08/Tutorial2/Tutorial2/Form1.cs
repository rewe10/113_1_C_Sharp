namespace Tutorial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------
        �Z��:��ޤ@��
        �Ǹ�:a112340039
        �m�W:�w�A��
        */
        private void ptxBack_Click(object sender, EventArgs e)
        {

        }

        private void ptxFrom_Click(object sender, EventArgs e)
        {

        }
        //��ܼ��J�P�I��
        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;//�]�wvisibl�ݩʬ���
            ptxFrom.Visible = false;
        }
        //��ܼ��J�P����
        private void btnShowFrom_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = false;
            ptxFrom.Visible = true;
        }

        private void btnexid_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
