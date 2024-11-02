namespace homework2_2
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
            label1 = new Label();
            labOutput = new Label();
            label3 = new Label();
            texIntput = new TextBox();
            butCalculate = new Button();
            butClear = new Button();
            butExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 18F);
            label1.Location = new Point(82, 82);
            label1.Name = "label1";
            label1.Size = new Size(161, 48);
            label1.TabIndex = 0;
            label1.Text = "消費金額：";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labOutput
            // 
            labOutput.BorderStyle = BorderStyle.FixedSingle;
            labOutput.Font = new Font("Microsoft JhengHei UI", 18F);
            labOutput.Location = new Point(330, 182);
            labOutput.Name = "labOutput";
            labOutput.Size = new Size(247, 48);
            labOutput.TabIndex = 1;
            labOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.Location = new Point(82, 182);
            label3.Name = "label3";
            label3.Size = new Size(161, 48);
            label3.TabIndex = 2;
            label3.Text = "累積點數：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texIntput
            // 
            texIntput.Font = new Font("Microsoft JhengHei UI", 18F);
            texIntput.Location = new Point(330, 88);
            texIntput.Name = "texIntput";
            texIntput.Size = new Size(247, 38);
            texIntput.TabIndex = 3;
            // 
            // butCalculate
            // 
            butCalculate.Font = new Font("Microsoft JhengHei UI", 18F);
            butCalculate.Location = new Point(33, 325);
            butCalculate.Name = "butCalculate";
            butCalculate.Size = new Size(187, 77);
            butCalculate.TabIndex = 4;
            butCalculate.Text = "顯示點數";
            butCalculate.UseVisualStyleBackColor = true;
            butCalculate.Click += butCalculate_Click;
            // 
            // butClear
            // 
            butClear.Font = new Font("Microsoft JhengHei UI", 18F);
            butClear.Location = new Point(308, 325);
            butClear.Name = "butClear";
            butClear.Size = new Size(187, 77);
            butClear.TabIndex = 5;
            butClear.Text = "清除";
            butClear.UseVisualStyleBackColor = true;
            butClear.Click += butClear_Click;
            // 
            // butExit
            // 
            butExit.Font = new Font("Microsoft JhengHei UI", 18F);
            butExit.Location = new Point(575, 325);
            butExit.Name = "butExit";
            butExit.Size = new Size(187, 77);
            butExit.TabIndex = 6;
            butExit.Text = "關閉";
            butExit.UseVisualStyleBackColor = true;
            butExit.Click += butExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butExit);
            Controls.Add(butClear);
            Controls.Add(butCalculate);
            Controls.Add(texIntput);
            Controls.Add(label3);
            Controls.Add(labOutput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "VV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labOutput;
        private Label label3;
        private TextBox texIntput;
        private Button butCalculate;
        private Button butClear;
        private Button butExit;
    }
}
