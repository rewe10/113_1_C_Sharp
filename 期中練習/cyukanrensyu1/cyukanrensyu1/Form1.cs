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
                color1 = "����";
            }
            else if (radBlue1.Checked)
            {
                color1 = "�Ŧ�";
            }
            else if (radYellow1.Checked)
            {
                color1 = "����";
            }
            if(radRed2.Checked)
            {
                color2 = "����";
            }
            else if(radBlue2.Checked)
            {
                color2 = "�Ŧ�";
            }
            else if(radYellow2.Checked)
            {
                color2 = "����";
            }
               
            if ((color1 == "����" && color2 == "�Ŧ�") || (color1 == "�Ŧ�" && color2 == "����"))
            {
                this.BackColor = Color.Purple;
            }
            else if ((color1 == "����" && color2 == "����") || (color1 == "����" && color2 == "����"))
            {
                this.BackColor = Color.Orange;
            }
            else if ((color1 == "�Ŧ�" && color2 == "����") || (color1 == "����" && color2 == "�Ŧ�"))
            {
                this.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("�п�ܨ�Ӥ��P���C��i��V�X�C");
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
