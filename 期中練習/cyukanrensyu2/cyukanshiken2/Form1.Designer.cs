namespace cyukanshiken2
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
            butCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            labOut1 = new Label();
            texIncome = new TextBox();
            labOut2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // butCalculate
            // 
            butCalculate.Location = new Point(304, 327);
            butCalculate.Name = "butCalculate";
            butCalculate.Size = new Size(180, 76);
            butCalculate.TabIndex = 0;
            butCalculate.Text = "計算";
            butCalculate.UseVisualStyleBackColor = true;
            butCalculate.Click += butCalculate_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(58, 101);
            label1.Name = "label1";
            label1.Size = new Size(126, 54);
            label1.TabIndex = 1;
            label1.Text = "稅收";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(58, 262);
            label2.Name = "label2";
            label2.Size = new Size(240, 54);
            label2.TabIndex = 2;
            label2.Text = "納稅後收入";
            // 
            // labOut1
            // 
            labOut1.BorderStyle = BorderStyle.Fixed3D;
            labOut1.Font = new Font("Microsoft JhengHei UI", 12F);
            labOut1.Location = new Point(304, 173);
            labOut1.Name = "labOut1";
            labOut1.Size = new Size(317, 54);
            labOut1.TabIndex = 3;
            // 
            // texIncome
            // 
            texIncome.Font = new Font("Microsoft JhengHei UI", 24F);
            texIncome.Location = new Point(304, 101);
            texIncome.Name = "texIncome";
            texIncome.Size = new Size(317, 48);
            texIncome.TabIndex = 4;
            // 
            // labOut2
            // 
            labOut2.BorderStyle = BorderStyle.Fixed3D;
            labOut2.Font = new Font("Microsoft JhengHei UI", 12F);
            labOut2.Location = new Point(304, 262);
            labOut2.Name = "labOut2";
            labOut2.Size = new Size(317, 54);
            labOut2.TabIndex = 5;
            labOut2.Click += labOut2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(58, 173);
            label3.Name = "label3";
            label3.Size = new Size(240, 54);
            label3.TabIndex = 6;
            label3.Text = "納稅後稅額";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(labOut2);
            Controls.Add(texIncome);
            Controls.Add(labOut1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butCalculate;
        private Label label1;
        private Label label2;
        private Label labOut1;
        private TextBox texIncome;
        private Label labOut2;
        private Label label3;
    }
}
