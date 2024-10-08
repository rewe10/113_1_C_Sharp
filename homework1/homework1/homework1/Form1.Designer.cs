namespace homework1
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
            梅花2 = new PictureBox();
            梅花3 = new PictureBox();
            黑桃2 = new PictureBox();
            愛心2 = new PictureBox();
            菱形2 = new PictureBox();
            結束 = new Button();
            label1 = new Label();
            顯示名稱 = new Label();
            ((System.ComponentModel.ISupportInitialize)梅花2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)梅花3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)黑桃2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)愛心2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)菱形2).BeginInit();
            SuspendLayout();
            // 
            // 梅花2
            // 
            梅花2.Image = Properties.Resources._2_Clubs;
            梅花2.Location = new Point(67, 111);
            梅花2.Name = "梅花2";
            梅花2.Size = new Size(100, 147);
            梅花2.SizeMode = PictureBoxSizeMode.StretchImage;
            梅花2.TabIndex = 0;
            梅花2.TabStop = false;
            梅花2.Click += 梅花2_Click;
            // 
            // 梅花3
            // 
            梅花3.Image = Properties.Resources._3_Clubs;
            梅花3.Location = new Point(593, 111);
            梅花3.Name = "梅花3";
            梅花3.Size = new Size(100, 147);
            梅花3.SizeMode = PictureBoxSizeMode.StretchImage;
            梅花3.TabIndex = 1;
            梅花3.TabStop = false;
            // 
            // 黑桃2
            // 
            黑桃2.Image = Properties.Resources._2_Spades;
            黑桃2.Location = new Point(464, 111);
            黑桃2.Name = "黑桃2";
            黑桃2.Size = new Size(100, 147);
            黑桃2.SizeMode = PictureBoxSizeMode.StretchImage;
            黑桃2.TabIndex = 2;
            黑桃2.TabStop = false;
            // 
            // 愛心2
            // 
            愛心2.Image = Properties.Resources._2_Hearts;
            愛心2.Location = new Point(333, 111);
            愛心2.Name = "愛心2";
            愛心2.Size = new Size(100, 147);
            愛心2.SizeMode = PictureBoxSizeMode.StretchImage;
            愛心2.TabIndex = 3;
            愛心2.TabStop = false;
            // 
            // 菱形2
            // 
            菱形2.Image = Properties.Resources._2_Diamonds;
            菱形2.Location = new Point(205, 111);
            菱形2.Name = "菱形2";
            菱形2.Size = new Size(100, 147);
            菱形2.SizeMode = PictureBoxSizeMode.StretchImage;
            菱形2.TabIndex = 4;
            菱形2.TabStop = false;
            菱形2.Click += 菱形2_Click;
            // 
            // 結束
            // 
            結束.Location = new Point(262, 353);
            結束.Name = "結束";
            結束.Size = new Size(292, 73);
            結束.TabIndex = 6;
            結束.Text = "button2";
            結束.UseVisualStyleBackColor = true;
            結束.Click += 結束_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // 顯示名稱
            // 
            顯示名稱.BorderStyle = BorderStyle.Fixed3D;
            顯示名稱.Font = new Font("Microsoft JhengHei UI", 12F);
            顯示名稱.Location = new Point(262, 283);
            顯示名稱.Name = "顯示名稱";
            顯示名稱.Size = new Size(292, 52);
            顯示名稱.TabIndex = 8;
            顯示名稱.Text = "label2";
            顯示名稱.TextAlign = ContentAlignment.MiddleCenter;
            顯示名稱.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(顯示名稱);
            Controls.Add(label1);
            Controls.Add(結束);
            Controls.Add(菱形2);
            Controls.Add(愛心2);
            Controls.Add(黑桃2);
            Controls.Add(梅花3);
            Controls.Add(梅花2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)梅花2).EndInit();
            ((System.ComponentModel.ISupportInitialize)梅花3).EndInit();
            ((System.ComponentModel.ISupportInitialize)黑桃2).EndInit();
            ((System.ComponentModel.ISupportInitialize)愛心2).EndInit();
            ((System.ComponentModel.ISupportInitialize)菱形2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox 梅花2;
        private PictureBox 梅花3;
        private PictureBox 黑桃2;
        private PictureBox 愛心2;
        private PictureBox 菱形2;
        private Button 結束;
        private Label label1;
        private Label 顯示名稱;
    }
}
