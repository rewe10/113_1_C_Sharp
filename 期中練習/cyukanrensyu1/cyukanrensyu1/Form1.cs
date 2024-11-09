using System.Drawing;
using System.Windows.Forms;

namespace cyukanrensyu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butColorOut_Click(object sender, EventArgs e)
        {
            // 取得使用者選擇的顏色
            string color1 = GetSelectedColor(groupBox1);
            string color2 = GetSelectedColor(groupBox2);

            // 根據顏色組合更改背景顏色
            if ((color1 == "紅色" && color2 == "藍色") || (color1 == "藍色" && color2 == "紅色"))
            {
                this.BackColor = Color.Purple;
            }
            else if ((color1 == "紅色" && color2 == "黃色") || (color1 == "黃色" && color2 == "紅色"))
            {
                this.BackColor = Color.Orange;
            }
            else if ((color1 == "藍色" && color2 == "黃色") || (color1 == "黃色" && color2 == "藍色"))
            {
                this.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("請選擇兩個不同的顏色進行混合。");
            }
        }

        // 此方法用來取得選中的 RadioButton 顏色
        private string GetSelectedColor(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // 返回選中的顏色名稱
                }
            }
            return null; // 如果沒有選中任何顏色，返回 null
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
