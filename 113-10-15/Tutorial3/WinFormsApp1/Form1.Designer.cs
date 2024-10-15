namespace WinFormsApp1
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
            label4 = new Label();
            txtdayofweek = new TextBox();
            txtDest = new TextBox();
            txtmonth = new TextBox();
            txtyear = new TextBox();
            lblShow = new Label();
            Btnshowday = new Button();
            Btncltar = new Button();
            Btntxit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(61, 65);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 1;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(93, 146);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 2;
            label2.Text = "日期";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(93, 223);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 3;
            label3.Text = "月份";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(93, 303);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 4;
            label4.Text = "年分";
            // 
            // txtdayofweek
            // 
            txtdayofweek.Font = new Font("Microsoft JhengHei UI", 24F);
            txtdayofweek.Location = new Point(318, 65);
            txtdayofweek.Name = "txtdayofweek";
            txtdayofweek.Size = new Size(304, 48);
            txtdayofweek.TabIndex = 5;
            // 
            // txtDest
            // 
            txtDest.Font = new Font("Microsoft JhengHei UI", 24F);
            txtDest.Location = new Point(318, 146);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(304, 48);
            txtDest.TabIndex = 6;
            txtDest.TextChanged += txtDest_TextChanged;
            // 
            // txtmonth
            // 
            txtmonth.Font = new Font("Microsoft JhengHei UI", 24F);
            txtmonth.Location = new Point(318, 223);
            txtmonth.Name = "txtmonth";
            txtmonth.Size = new Size(304, 48);
            txtmonth.TabIndex = 7;
            // 
            // txtyear
            // 
            txtyear.Font = new Font("Microsoft JhengHei UI", 24F);
            txtyear.Location = new Point(318, 300);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(304, 48);
            txtyear.TabIndex = 8;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(93, 365);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(529, 54);
            lblShow.TabIndex = 9;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            lblShow.Click += label5_Click;
            // 
            // Btnshowday
            // 
            Btnshowday.Font = new Font("Microsoft JhengHei UI", 9F);
            Btnshowday.Location = new Point(93, 450);
            Btnshowday.Name = "Btnshowday";
            Btnshowday.Size = new Size(135, 47);
            Btnshowday.TabIndex = 10;
            Btnshowday.Text = "顯示完整訊息";
            Btnshowday.UseVisualStyleBackColor = true;
            Btnshowday.Click += Btnshowday_Click;
            // 
            // Btncltar
            // 
            Btncltar.Font = new Font("Microsoft JhengHei UI", 9F);
            Btncltar.Location = new Point(282, 450);
            Btncltar.Name = "Btncltar";
            Btncltar.Size = new Size(135, 47);
            Btncltar.TabIndex = 11;
            Btncltar.Text = "清空內容";
            Btncltar.UseVisualStyleBackColor = true;
            Btncltar.Click += Btncltar_Click;
            // 
            // Btntxit
            // 
            Btntxit.Font = new Font("Microsoft JhengHei UI", 9F);
            Btntxit.Location = new Point(487, 450);
            Btntxit.Name = "Btntxit";
            Btntxit.Size = new Size(135, 47);
            Btntxit.TabIndex = 12;
            Btntxit.Text = "離開";
            Btntxit.UseVisualStyleBackColor = true;
            Btntxit.Click += Btntxit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(Btntxit);
            Controls.Add(Btncltar);
            Controls.Add(Btnshowday);
            Controls.Add(lblShow);
            Controls.Add(txtyear);
            Controls.Add(txtmonth);
            Controls.Add(txtDest);
            Controls.Add(txtdayofweek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdayofweek;
        private TextBox txtDest;
        private TextBox txtmonth;
        private TextBox txtyear;
        private Label lblShow;
        private Button Btnshowday;
        private Button Btncltar;
        private Button Btntxit;
    }
}
