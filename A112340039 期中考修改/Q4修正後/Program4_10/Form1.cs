using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calory; //熱量(卡路里)
            double gram;   //克數(脂肪重量)
            double gramCalory;
            double baifenbi;
            //以下作答，必須使用double.TryParse()方法
            double.TryParse(texcalory.Text,out calory);
            double.TryParse(texgram.Text,out gram);
            gramCalory = gram * 9;
            baifenbi = (gramCalory / calory) * 100;
            if(calory<=0)
            {
                MessageBox.Show("卡路里或脂肪克數輸入不正確");
            }
            else if(gram <= 0)
            {
                MessageBox.Show("卡路里或脂肪克數輸入不正確");
            }

            gramCalory = gram * 9;
            baifenbi = (gramCalory / calory) * 100;

            string output = $"脂肪中的卡路里：{gramCalory:n2}，來自脂肪的卡路里百分比：{baifenbi:n2}%";
            if (radioButton1.Checked && baifenbi < 30)
            {
                output += "，屬於低脂食物";
            }

            labOutput.Text = output;

        }
    }
}
