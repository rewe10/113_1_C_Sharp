namespace homework2_1
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
            texInputC = new TextBox();
            texInputB = new TextBox();
            texInputA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            labOutputAll = new Label();
            label11 = new Label();
            labOutputC = new Label();
            labOutputB = new Label();
            labOutputA = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            butCalculate = new Button();
            butClear = new Button();
            butExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(texInputC);
            groupBox1.Controls.Add(texInputB);
            groupBox1.Controls.Add(texInputA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 18F);
            groupBox1.Location = new Point(43, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "票價";
            // 
            // texInputC
            // 
            texInputC.Location = new Point(158, 170);
            texInputC.Name = "texInputC";
            texInputC.Size = new Size(118, 38);
            texInputC.TabIndex = 6;
            // 
            // texInputB
            // 
            texInputB.Location = new Point(158, 111);
            texInputB.Name = "texInputB";
            texInputB.Size = new Size(118, 38);
            texInputB.TabIndex = 5;
            // 
            // texInputA
            // 
            texInputA.AcceptsTab = true;
            texInputA.Location = new Point(158, 52);
            texInputA.Name = "texInputA";
            texInputA.Size = new Size(118, 38);
            texInputA.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 173);
            label4.Name = "label4";
            label4.Size = new Size(125, 30);
            label4.TabIndex = 3;
            label4.Text = "C級座位：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 114);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 2;
            label3.Text = "B級座位：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 52);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 1;
            label2.Text = "A級座位：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labOutputAll);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(labOutputC);
            groupBox2.Controls.Add(labOutputB);
            groupBox2.Controls.Add(labOutputA);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft JhengHei UI", 18F);
            groupBox2.Location = new Point(397, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 268);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "選購票價";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // labOutputAll
            // 
            labOutputAll.BorderStyle = BorderStyle.FixedSingle;
            labOutputAll.Location = new Point(148, 213);
            labOutputAll.Name = "labOutputAll";
            labOutputAll.Size = new Size(149, 38);
            labOutputAll.TabIndex = 9;
            labOutputAll.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 217);
            label11.Name = "label11";
            label11.Size = new Size(85, 30);
            label11.TabIndex = 8;
            label11.Text = "總計：";
            // 
            // labOutputC
            // 
            labOutputC.BorderStyle = BorderStyle.FixedSingle;
            labOutputC.Location = new Point(148, 170);
            labOutputC.Name = "labOutputC";
            labOutputC.Size = new Size(149, 38);
            labOutputC.TabIndex = 7;
            labOutputC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labOutputB
            // 
            labOutputB.BorderStyle = BorderStyle.FixedSingle;
            labOutputB.Location = new Point(148, 111);
            labOutputB.Name = "labOutputB";
            labOutputB.Size = new Size(149, 38);
            labOutputB.TabIndex = 6;
            labOutputB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labOutputA
            // 
            labOutputA.BorderStyle = BorderStyle.FixedSingle;
            labOutputA.Location = new Point(148, 52);
            labOutputA.Name = "labOutputA";
            labOutputA.Size = new Size(149, 38);
            labOutputA.TabIndex = 5;
            labOutputA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 173);
            label7.Name = "label7";
            label7.Size = new Size(125, 30);
            label7.TabIndex = 4;
            label7.Text = "C級座位：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 114);
            label6.Name = "label6";
            label6.Size = new Size(124, 30);
            label6.TabIndex = 3;
            label6.Text = "B級座位：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 52);
            label5.Name = "label5";
            label5.Size = new Size(126, 30);
            label5.TabIndex = 2;
            label5.Text = "A級座位：";
            // 
            // butCalculate
            // 
            butCalculate.Font = new Font("Microsoft JhengHei UI", 16F);
            butCalculate.Location = new Point(64, 334);
            butCalculate.Name = "butCalculate";
            butCalculate.Size = new Size(131, 61);
            butCalculate.TabIndex = 2;
            butCalculate.Text = "計算票價";
            butCalculate.UseVisualStyleBackColor = true;
            butCalculate.Click += butCalculate_Click;
            // 
            // butClear
            // 
            butClear.Font = new Font("Microsoft JhengHei UI", 16F);
            butClear.Location = new Point(313, 334);
            butClear.Name = "butClear";
            butClear.Size = new Size(131, 61);
            butClear.TabIndex = 3;
            butClear.Text = "清除";
            butClear.UseVisualStyleBackColor = true;
            butClear.Click += butClear_Click;
            // 
            // butExit
            // 
            butExit.Font = new Font("Microsoft JhengHei UI", 16F);
            butExit.Location = new Point(563, 334);
            butExit.Name = "butExit";
            butExit.Size = new Size(131, 61);
            butExit.TabIndex = 4;
            butExit.Text = "關閉程式";
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
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button butCalculate;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button butClear;
        private Button butExit;
        private TextBox texInputC;
        private TextBox texInputB;
        private TextBox texInputA;
        private Label label7;
        private Label label6;
        private Label label5;
        internal Label labOutputA;
        internal Label labOutputC;
        internal Label labOutputB;
        internal Label labOutputAll;
        private Label label11;
    }
}
