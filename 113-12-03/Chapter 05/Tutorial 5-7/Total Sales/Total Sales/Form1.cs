using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                decimal total = 0m;
                decimal sales;
              StreamReader inputFile;
                inputFile = File.OpenText("Sales.txt");

                while (!inputFile.EndOfStream)
                {
                    if (decimal.TryParse(inputFile.ReadLine(), out sales))
                    {
                        total = sales;
                    }
                    else 
                    {
                        MessageBox.Show("ramn");
                    }
                }
            }
            catch (Exception ex) 
            {
                
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void a_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不好意思，請問可以先將程式打完，在對程式做介紹嗎?在打的時候真的很難同時聽講解，但如果不在講解的時候做又會跟不上打不完，而最常發生的情況是打完了就下一題，但不知道上一題是甚麼意思，感謝老師看到最後");
        }
    }
}
