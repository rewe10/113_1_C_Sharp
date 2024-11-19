using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
                //收入
            decimal taxrate;   //稅率
            decimal payable;   //應交稅額
            decimal netIncome; //淨收入
            if(decimal.TryParse(incomeTextBox.Text,out decimal income))
            {
                if(income<=590000)
                {
                    taxrate = 0.05m;
                }
                else if(income>590000 && income<=1330000)
                {
                    taxrate = 0.12m;
                }
                else if (income>1330000 && income<=2660000)
                {
                    taxrate = 0.20m;
                }
                else if(income>2660000 && income <= 4980000)
                {
                    taxrate = 0.30m;
                }
                else
                {
                    taxrate = 0.40m;
                }
                payable= taxrate*income;
                netIncome=income-payable;
                labOutput1.Text= payable.ToString();
                labOutput2.Text= netIncome.ToString();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
