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
            // 取得使用者輸入的所得並轉換為 decimal
            if (decimal.TryParse(texIncome.Text, out decimal income))
            {
                decimal taxRate = 0m;
                decimal taxAmount = 0m;
                decimal netIncome = 0m;

                // 根據所得區間判斷稅率
                if (income <= 10000)
                {
                    taxRate = 0.10m; // 10%稅率
                }
                else if (income <= 50000)
                {
                    taxRate = 0.15m; // 15% 稅率
                }
                else if (income <= 100000)
                {
                    taxRate = 0.25m; // 25% 稅率
                }
                else
                {
                    taxRate = 0.30m; // 30% 稅率
                }

                // 計算稅額與繳稅後的淨收入
                taxAmount = income * taxRate;
                netIncome = income - taxAmount;

                // 顯示結果
                labOut1.Text = taxAmount.ToString("n2");
                labOut2.Text = netIncome.ToString("n2");
            }
            else
            {
                // 如果輸入無效，提示使用者
                MessageBox.Show("請輸入有效的數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labOut2_Click(object sender, EventArgs e)
        {

        }
    }
}
