namespace cyukanrensyu1
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
            groupBox1 = new GroupBox();
            radBlue1 = new RadioButton();
            radYellow1 = new RadioButton();
            radRed1 = new RadioButton();
            groupBox2 = new GroupBox();
            radYellow2 = new RadioButton();
            radBlue2 = new RadioButton();
            radRed2 = new RadioButton();
            butColorOut = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radBlue1);
            groupBox1.Controls.Add(radYellow1);
            groupBox1.Controls.Add(radRed1);
            groupBox1.Location = new Point(43, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "調色器";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radBlue1
            // 
            radBlue1.AutoSize = true;
            radBlue1.Location = new Point(26, 104);
            radBlue1.Name = "radBlue1";
            radBlue1.Size = new Size(49, 19);
            radBlue1.TabIndex = 2;
            radBlue1.TabStop = true;
            radBlue1.Text = "藍色";
            radBlue1.UseVisualStyleBackColor = true;
            // 
            // radYellow1
            // 
            radYellow1.AutoSize = true;
            radYellow1.Location = new Point(26, 154);
            radYellow1.Name = "radYellow1";
            radYellow1.Size = new Size(49, 19);
            radYellow1.TabIndex = 1;
            radYellow1.TabStop = true;
            radYellow1.Text = "黃色";
            radYellow1.UseVisualStyleBackColor = true;
            // 
            // radRed1
            // 
            radRed1.AutoSize = true;
            radRed1.Location = new Point(26, 50);
            radRed1.Name = "radRed1";
            radRed1.Size = new Size(49, 19);
            radRed1.TabIndex = 0;
            radRed1.TabStop = true;
            radRed1.Text = "紅色";
            radRed1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radYellow2);
            groupBox2.Controls.Add(radBlue2);
            groupBox2.Controls.Add(radRed2);
            groupBox2.Location = new Point(424, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 202);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "調色器";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radYellow2
            // 
            radYellow2.AutoSize = true;
            radYellow2.Location = new Point(30, 154);
            radYellow2.Name = "radYellow2";
            radYellow2.Size = new Size(49, 19);
            radYellow2.TabIndex = 5;
            radYellow2.TabStop = true;
            radYellow2.Text = "黃色";
            radYellow2.UseVisualStyleBackColor = true;
            // 
            // radBlue2
            // 
            radBlue2.AutoSize = true;
            radBlue2.Location = new Point(30, 104);
            radBlue2.Name = "radBlue2";
            radBlue2.Size = new Size(49, 19);
            radBlue2.TabIndex = 4;
            radBlue2.TabStop = true;
            radBlue2.Text = "藍色";
            radBlue2.UseVisualStyleBackColor = true;
            // 
            // radRed2
            // 
            radRed2.AutoSize = true;
            radRed2.Location = new Point(30, 50);
            radRed2.Name = "radRed2";
            radRed2.Size = new Size(49, 19);
            radRed2.TabIndex = 3;
            radRed2.TabStop = true;
            radRed2.Text = "紅色";
            radRed2.UseVisualStyleBackColor = true;
            // 
            // butColorOut
            // 
            butColorOut.Location = new Point(298, 350);
            butColorOut.Name = "butColorOut";
            butColorOut.Size = new Size(147, 57);
            butColorOut.TabIndex = 1;
            butColorOut.Text = "調色";
            butColorOut.UseVisualStyleBackColor = true;
            butColorOut.Click += butColorOut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butColorOut);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radBlue1;
        private RadioButton radYellow1;
        private RadioButton radRed1;
        private GroupBox groupBox2;
        private RadioButton radYellow2;
        private RadioButton radBlue2;
        private RadioButton radRed2;
        private Button butColorOut;
    }
}
