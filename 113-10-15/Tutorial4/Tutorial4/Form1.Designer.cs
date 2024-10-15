namespace Tutorial4
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
            txbKM = new TextBox();
            txbLiter = new TextBox();
            lblShow = new Label();
            Btncalculate = new Button();
            Btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(57, 50);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(57, 165);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(57, 265);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 2;
            label3.Text = "每公升/公里";
            // 
            // txbKM
            // 
            txbKM.Font = new Font("Microsoft JhengHei UI", 24F);
            txbKM.Location = new Point(285, 50);
            txbKM.Name = "txbKM";
            txbKM.Size = new Size(404, 48);
            txbKM.TabIndex = 3;
            // 
            // txbLiter
            // 
            txbLiter.Font = new Font("Microsoft JhengHei UI", 24F);
            txbLiter.Location = new Point(285, 165);
            txbLiter.Name = "txbLiter";
            txbLiter.Size = new Size(404, 48);
            txbLiter.TabIndex = 4;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblShow.Location = new Point(285, 265);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(404, 41);
            lblShow.TabIndex = 5;
            // 
            // Btncalculate
            // 
            Btncalculate.Location = new Point(108, 348);
            Btncalculate.Name = "Btncalculate";
            Btncalculate.Size = new Size(151, 90);
            Btncalculate.TabIndex = 6;
            Btncalculate.Text = "計算";
            Btncalculate.UseVisualStyleBackColor = true;
            Btncalculate.Click += Btncalculate_Click;
            // 
            // Btnexit
            // 
            Btnexit.Location = new Point(442, 348);
            Btnexit.Name = "Btnexit";
            Btnexit.Size = new Size(151, 90);
            Btnexit.TabIndex = 7;
            Btnexit.Text = "離開";
            Btnexit.UseVisualStyleBackColor = true;
            Btnexit.Click += Btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btnexit);
            Controls.Add(Btncalculate);
            Controls.Add(lblShow);
            Controls.Add(txbLiter);
            Controls.Add(txbKM);
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
        private TextBox txbKM;
        private TextBox txbLiter;
        private Label lblShow;
        private Button Btncalculate;
        private Button Btnexit;
    }
}
