namespace Tutorial2
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
            ptxBack = new PictureBox();
            ptxFrom = new PictureBox();
            btnShowBack = new Button();
            btnShowFrom = new Button();
            btnexid = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxFrom).BeginInit();
            SuspendLayout();
            // 
            // ptxBack
            // 
            ptxBack.Image = Properties.Resources.Backface_Blue;
            ptxBack.Location = new Point(21, 70);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(166, 256);
            ptxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxBack.TabIndex = 0;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            ptxBack.Click += ptxBack_Click;
            // 
            // ptxFrom
            // 
            ptxFrom.Image = Properties.Resources.Ace_Spades;
            ptxFrom.Location = new Point(254, 70);
            ptxFrom.Name = "ptxFrom";
            ptxFrom.Size = new Size(166, 256);
            ptxFrom.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxFrom.TabIndex = 1;
            ptxFrom.TabStop = false;
            ptxFrom.Visible = false;
            ptxFrom.Click += ptxFrom_Click;
            // 
            // btnShowBack
            // 
            btnShowBack.Location = new Point(36, 366);
            btnShowBack.Name = "btnShowBack";
            btnShowBack.Size = new Size(132, 72);
            btnShowBack.TabIndex = 2;
            btnShowBack.Text = "背面";
            btnShowBack.UseVisualStyleBackColor = true;
            btnShowBack.Click += btnShowBack_Click;
            // 
            // btnShowFrom
            // 
            btnShowFrom.Location = new Point(275, 366);
            btnShowFrom.Name = "btnShowFrom";
            btnShowFrom.Size = new Size(132, 72);
            btnShowFrom.TabIndex = 3;
            btnShowFrom.Text = "正面";
            btnShowFrom.UseVisualStyleBackColor = true;
            btnShowFrom.Click += btnShowFrom_Click;
            // 
            // btnexid
            // 
            btnexid.Location = new Point(36, 497);
            btnexid.Name = "btnexid";
            btnexid.Size = new Size(371, 62);
            btnexid.TabIndex = 4;
            btnexid.Text = "離開";
            btnexid.UseVisualStyleBackColor = true;
            btnexid.Click += btnexid_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 612);
            Controls.Add(btnexid);
            Controls.Add(btnShowFrom);
            Controls.Add(btnShowBack);
            Controls.Add(ptxFrom);
            Controls.Add(ptxBack);
            Name = "Form1";
            Text = "翻牌";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxFrom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxBack;
        private PictureBox ptxFrom;
        private Button btnShowBack;
        private Button btnShowFrom;
        private Button btnexid;
    }
}
