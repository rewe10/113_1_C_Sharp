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
            ClubsTwo = new PictureBox();
            ClubsThree = new PictureBox();
            SpadesTwo = new PictureBox();
            HeartsTwo = new PictureBox();
            DiamondsTwo = new PictureBox();
            Exit = new Button();
            label1 = new Label();
            labename = new Label();
            ((System.ComponentModel.ISupportInitialize)ClubsTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClubsThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpadesTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeartsTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiamondsTwo).BeginInit();
            SuspendLayout();
            // 
            // ClubsTwo
            // 
            ClubsTwo.Image = Properties.Resources._2_Clubs;
            ClubsTwo.Location = new Point(69, 111);
            ClubsTwo.Name = "ClubsTwo";
            ClubsTwo.Size = new Size(100, 147);
            ClubsTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            ClubsTwo.TabIndex = 0;
            ClubsTwo.TabStop = false;
            ClubsTwo.Click += 梅花2_Click;
            // 
            // ClubsThree
            // 
            ClubsThree.Image = Properties.Resources._3_Clubs;
            ClubsThree.Location = new Point(593, 111);
            ClubsThree.Name = "ClubsThree";
            ClubsThree.Size = new Size(100, 147);
            ClubsThree.SizeMode = PictureBoxSizeMode.StretchImage;
            ClubsThree.TabIndex = 1;
            ClubsThree.TabStop = false;
            ClubsThree.Click += ClubsThree_Click;
            // 
            // SpadesTwo
            // 
            SpadesTwo.Image = Properties.Resources._2_Spades;
            SpadesTwo.Location = new Point(464, 111);
            SpadesTwo.Name = "SpadesTwo";
            SpadesTwo.Size = new Size(100, 147);
            SpadesTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            SpadesTwo.TabIndex = 2;
            SpadesTwo.TabStop = false;
            SpadesTwo.Click += SpadesTwo_Click;
            // 
            // HeartsTwo
            // 
            HeartsTwo.Image = Properties.Resources._2_Hearts;
            HeartsTwo.Location = new Point(333, 111);
            HeartsTwo.Name = "HeartsTwo";
            HeartsTwo.Size = new Size(100, 147);
            HeartsTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            HeartsTwo.TabIndex = 3;
            HeartsTwo.TabStop = false;
            HeartsTwo.Click += HeartsTwo_Click;
            // 
            // DiamondsTwo
            // 
            DiamondsTwo.Image = Properties.Resources._2_Diamonds;
            DiamondsTwo.Location = new Point(205, 111);
            DiamondsTwo.Name = "DiamondsTwo";
            DiamondsTwo.Size = new Size(100, 147);
            DiamondsTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            DiamondsTwo.TabIndex = 4;
            DiamondsTwo.TabStop = false;
            DiamondsTwo.Click += 菱形2_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(262, 353);
            Exit.Name = "Exit";
            Exit.Size = new Size(292, 73);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += 結束_Click;
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
            // labename
            // 
            labename.BorderStyle = BorderStyle.Fixed3D;
            labename.Font = new Font("Microsoft JhengHei UI", 12F);
            labename.Location = new Point(262, 283);
            labename.Name = "labename";
            labename.Size = new Size(292, 52);
            labename.TabIndex = 8;
            labename.TextAlign = ContentAlignment.MiddleCenter;
            labename.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labename);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(DiamondsTwo);
            Controls.Add(HeartsTwo);
            Controls.Add(SpadesTwo);
            Controls.Add(ClubsThree);
            Controls.Add(ClubsTwo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ClubsTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClubsThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpadesTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeartsTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiamondsTwo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ClubsTwo;
        private PictureBox ClubsThree;
        private PictureBox SpadesTwo;
        private PictureBox HeartsTwo;
        private PictureBox DiamondsTwo;
        private Button Exit;
        private Label label1;
        private Label labename;
    }
}
