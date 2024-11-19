namespace Q1
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
            label2 = new Label();
            label3 = new Label();
            labOutput = new Label();
            texa = new TextBox();
            texb = new TextBox();
            texc = new TextBox();
            butArea = new Button();
            butBoun = new Button();
            butCost = new Button();
            butExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(61, 51);
            label1.Name = "label1";
            label1.Size = new Size(156, 51);
            label1.TabIndex = 0;
            label1.Text = "長";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(61, 121);
            label2.Name = "label2";
            label2.Size = new Size(156, 51);
            label2.TabIndex = 1;
            label2.Text = "寬";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(61, 186);
            label3.Name = "label3";
            label3.Size = new Size(156, 51);
            label3.TabIndex = 2;
            label3.Text = "單位成本";
            // 
            // labOutput
            // 
            labOutput.BorderStyle = BorderStyle.Fixed3D;
            labOutput.Font = new Font("Microsoft JhengHei UI", 24F);
            labOutput.Location = new Point(288, 267);
            labOutput.Name = "labOutput";
            labOutput.Size = new Size(220, 51);
            labOutput.TabIndex = 3;
            // 
            // texa
            // 
            texa.Font = new Font("Microsoft JhengHei UI", 24F);
            texa.Location = new Point(288, 48);
            texa.Name = "texa";
            texa.Size = new Size(229, 48);
            texa.TabIndex = 4;
            // 
            // texb
            // 
            texb.Font = new Font("Microsoft JhengHei UI", 24F);
            texb.Location = new Point(288, 124);
            texb.Name = "texb";
            texb.Size = new Size(229, 48);
            texb.TabIndex = 5;
            // 
            // texc
            // 
            texc.Font = new Font("Microsoft JhengHei UI", 24F);
            texc.Location = new Point(288, 189);
            texc.Name = "texc";
            texc.Size = new Size(229, 48);
            texc.TabIndex = 6;
            // 
            // butArea
            // 
            butArea.Location = new Point(61, 356);
            butArea.Name = "butArea";
            butArea.Size = new Size(98, 57);
            butArea.TabIndex = 7;
            butArea.Text = "面積";
            butArea.UseVisualStyleBackColor = true;
            butArea.Click += butArea_Click;
            // 
            // butBoun
            // 
            butBoun.Location = new Point(229, 356);
            butBoun.Name = "butBoun";
            butBoun.Size = new Size(98, 57);
            butBoun.TabIndex = 8;
            butBoun.Text = "周長";
            butBoun.UseVisualStyleBackColor = true;
            butBoun.Click += butBoun_Click;
            // 
            // butCost
            // 
            butCost.Location = new Point(410, 356);
            butCost.Name = "butCost";
            butCost.Size = new Size(98, 57);
            butCost.TabIndex = 9;
            butCost.Text = "計算成本";
            butCost.UseVisualStyleBackColor = true;
            butCost.Click += butCost_Click;
            // 
            // butExit
            // 
            butExit.Location = new Point(589, 356);
            butExit.Name = "butExit";
            butExit.Size = new Size(98, 57);
            butExit.TabIndex = 10;
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
            Controls.Add(butCost);
            Controls.Add(butBoun);
            Controls.Add(butArea);
            Controls.Add(texc);
            Controls.Add(texb);
            Controls.Add(texa);
            Controls.Add(labOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labOutput;
        private TextBox texa;
        private TextBox texb;
        private TextBox texc;
        private Button butArea;
        private Button butBoun;
        private Button butCost;
        private Button butExit;
    }
}
