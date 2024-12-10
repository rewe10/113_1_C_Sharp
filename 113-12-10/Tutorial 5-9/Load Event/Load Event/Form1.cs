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

namespace Load_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                string countryName;
                if (openFile.ShowDialog() = DialogResult.OK)
                {
                    inputFile = File.OpenText(openFile.FileName);
                    countriesListBox.Items.Clear();
                    while (!inputFile.EndOfStream)
                    {
                        countryName = inputFile.ReadLine();//讀取一行資料
                        countriesListBox.Items.Add(countryName);//將資料加入
                    }
                    inputFile.Close();//關閉檔案
                }
                else
                {
                    MessageBox.Show("未選擇資料夾");
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            private void exitButton_Click(object sender, EventArgs e)
            {
                // Close the form.
                this.Close();
            }
        }
    }
}
