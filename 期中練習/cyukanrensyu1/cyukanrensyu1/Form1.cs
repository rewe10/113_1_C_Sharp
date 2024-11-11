using System.Drawing;
using System.Runtime.Serialization.Json;
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
            string color1="";
            string color2="";
            if (radRed1.Checked)
            {
                color1 = "紅色";
            }
            else if (radBlue1.Checked)
            {
                color1 = "藍色";
            }
            else if (radYellow1.Checked)
            {
                color1 = "黃色";
            }
            if(radRed2.Checked)
            {
                color2 = "紅色";
            }
            else if(radBlue2.Checked)
            {
                color2 = "藍色";
            }
            else if(radYellow2.Checked)
            {
                color2 = "黃色";
            }
               
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
