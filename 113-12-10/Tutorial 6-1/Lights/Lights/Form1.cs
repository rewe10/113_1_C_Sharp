﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void turnLightON()
        {
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = false;
            lightStateLabel.Text = "ON";
        }
        private void turnLightOFF()
        {
            lightOnPictureBox.Visible = false;
            lightOffPictureBox.Visible = true;
            lightStateLabel.Text = "OFF";
        }
        private void switchButton_Click(object sender, EventArgs e)
        {
            if (lightOffPictureBox.Visible == true)
            {
                turnLightOFF();
            }
            else
            {
                turnLightON();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
