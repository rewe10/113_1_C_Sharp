﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // 這裡是取得國家按鈕的點擊事件處理程式。
            try
            {
                StreamReader inputFile;
                string countryName;
                inputFile = File.OpenText("Countries.txt");
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
