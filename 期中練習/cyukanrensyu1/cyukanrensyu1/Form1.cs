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
            // ���o�ϥΪ̿�ܪ��C��
            string color1 = GetSelectedColor(groupBox1);
            string color2 = GetSelectedColor(groupBox2);

            // �ھ��C��զX���I���C��
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

        // ����k�ΨӨ��o�襤�� RadioButton �C��
        private string GetSelectedColor(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // ��^�襤���C��W��
                }
            }
            return null; // �p�G�S���襤�����C��A��^ null
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
