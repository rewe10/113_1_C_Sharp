namespace Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picB = new PictureBox();
            picA = new PictureBox();
            picL = new PictureBox();
            picO = new PictureBox();
            label1 = new Label();
            laboutput = new Label();
            butReset = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)picB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picO).BeginInit();
            SuspendLayout();
            // 
            // picB
            // 
            picB.ErrorImage = null;
            picB.Image = Properties.Resources.Banana;
            picB.InitialImage = null;
            picB.Location = new Point(50, 28);
            picB.Name = "picB";
            picB.Size = new Size(128, 128);
            picB.TabIndex = 0;
            picB.TabStop = false;
            picB.Click += picB_Click;
            // 
            // picA
            // 
            picA.ErrorImage = null;
            picA.Image = (Image)resources.GetObject("picA.Image");
            picA.InitialImage = null;
            picA.Location = new Point(222, 28);
            picA.Name = "picA";
            picA.Size = new Size(128, 128);
            picA.TabIndex = 1;
            picA.TabStop = false;
            picA.Click += pictureBox1_Click;
            // 
            // picL
            // 
            picL.ErrorImage = null;
            picL.Image = (Image)resources.GetObject("picL.Image");
            picL.InitialImage = null;
            picL.Location = new Point(222, 183);
            picL.Name = "picL";
            picL.Size = new Size(128, 128);
            picL.TabIndex = 2;
            picL.TabStop = false;
            picL.Click += pictureBox2_Click;
            // 
            // picO
            // 
            picO.ErrorImage = null;
            picO.Image = (Image)resources.GetObject("picO.Image");
            picO.InitialImage = null;
            picO.Location = new Point(50, 183);
            picO.Name = "picO";
            picO.Size = new Size(128, 128);
            picO.TabIndex = 3;
            picO.TabStop = false;
            picO.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 12F);
            label1.Location = new Point(505, 28);
            label1.Name = "label1";
            label1.Size = new Size(205, 31);
            label1.TabIndex = 4;
            label1.Text = "總卡路里";
            // 
            // laboutput
            // 
            laboutput.BorderStyle = BorderStyle.Fixed3D;
            laboutput.Font = new Font("Microsoft JhengHei UI", 12F);
            laboutput.Location = new Point(505, 80);
            laboutput.Name = "laboutput";
            laboutput.Size = new Size(205, 59);
            laboutput.TabIndex = 5;
            laboutput.Text = "0";
            // 
            // butReset
            // 
            butReset.Location = new Point(515, 192);
            butReset.Name = "butReset";
            butReset.Size = new Size(157, 63);
            butReset.TabIndex = 6;
            butReset.Text = "reset";
            butReset.UseVisualStyleBackColor = true;
            butReset.Click += butReset_Click;
            // 
            // button2
            // 
            button2.Location = new Point(515, 282);
            button2.Name = "button2";
            button2.Size = new Size(157, 63);
            button2.TabIndex = 7;
            button2.Text = "exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(butReset);
            Controls.Add(laboutput);
            Controls.Add(label1);
            Controls.Add(picO);
            Controls.Add(picL);
            Controls.Add(picA);
            Controls.Add(picB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picB).EndInit();
            ((System.ComponentModel.ISupportInitialize)picA).EndInit();
            ((System.ComponentModel.ISupportInitialize)picL).EndInit();
            ((System.ComponentModel.ISupportInitialize)picO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picB;
        private PictureBox picA;
        private PictureBox picL;
        private PictureBox picO;
        private Label label1;
        private Label laboutput;
        private Button butReset;
        private Button button2;
    }
}
