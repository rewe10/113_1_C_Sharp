namespace cyukanshiken2
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

        private void butCalculate_Click(object sender, EventArgs e)
        {
            // ���o�ϥΪ̿�J���ұo���ഫ�� decimal
            if (decimal.TryParse(texIncome.Text, out decimal income))
            {
                decimal taxRate = 0m;
                decimal taxAmount = 0m;
                decimal netIncome = 0m;

                // �ھکұo�϶��P�_�|�v
                if (income <= 10000)
                {
                    taxRate = 0.10m; // 10%�|�v
                }
                else if (income <= 50000)
                {
                    taxRate = 0.15m; // 15% �|�v
                }
                else if (income <= 100000)
                {
                    taxRate = 0.25m; // 25% �|�v
                }
                else
                {
                    taxRate = 0.30m; // 30% �|�v
                }

                // �p��|�B�Pú�|�᪺�b���J
                taxAmount = income * taxRate;
                netIncome = income - taxAmount;

                // ��ܵ��G
                labOut1.Text = taxAmount.ToString("n2");
                labOut2.Text = netIncome.ToString("n2");
            }
            else
            {
                // �p�G��J�L�ġA���ܨϥΪ�
                MessageBox.Show("�п�J���Ī��Ʀr", "��J���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labOut2_Click(object sender, EventArgs e)
        {

        }
    }
}
