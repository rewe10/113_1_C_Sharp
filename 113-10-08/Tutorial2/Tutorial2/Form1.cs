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
        班級:資管一甲
        學號:a112340039
        姓名:安澤寧
        */
        private void ptxBack_Click(object sender, EventArgs e)
        {

        }

        private void ptxFrom_Click(object sender, EventArgs e)
        {

        }
        //顯示撲克牌背面
        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;//設定visibl屬性為假
            ptxFrom.Visible = false;
        }
        //顯示撲克牌正面
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
