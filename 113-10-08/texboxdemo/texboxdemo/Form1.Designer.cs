namespace texboxdemo
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
            btnconfirm = new Button();
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(89, 92);
            label1.Name = "label1";
            label1.Size = new Size(170, 41);
            label1.TabIndex = 0;
            label1.Text = "Fist Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(89, 190);
            label2.Name = "label2";
            label2.Size = new Size(179, 41);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(89, 297);
            label3.Name = "label3";
            label3.Size = new Size(170, 41);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // btnconfirm
            // 
            btnconfirm.Font = new Font("Microsoft JhengHei UI", 24F);
            btnconfirm.Location = new Point(286, 363);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(188, 45);
            btnconfirm.TabIndex = 3;
            btnconfirm.Text = "button1";
            btnconfirm.UseVisualStyleBackColor = true;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // txtfirstname
            // 
            txtfirstname.Font = new Font("Microsoft JhengHei UI", 24F);
            txtfirstname.Location = new Point(304, 92);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(348, 48);
            txtfirstname.TabIndex = 4;
            // 
            // txtlastname
            // 
            txtlastname.Font = new Font("Microsoft JhengHei UI", 24F);
            txtlastname.Location = new Point(304, 187);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(348, 48);
            txtlastname.TabIndex = 5;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(304, 297);
            label4.Name = "label4";
            label4.Size = new Size(348, 41);
            label4.TabIndex = 6;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Controls.Add(btnconfirm);
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
        private Button btnconfirm;
        private TextBox txtfirstname;
        private TextBox txtlastname;
        private Label label4;
    }
}
