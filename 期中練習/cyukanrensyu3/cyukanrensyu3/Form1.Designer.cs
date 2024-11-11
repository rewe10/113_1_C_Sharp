namespace cyukanrensyu3
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
            texKg = new TextBox();
            texM = new TextBox();
            labBMI = new Label();
            labKarada = new Label();
            butOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(68, 52);
            label1.Name = "label1";
            label1.Size = new Size(181, 56);
            label1.TabIndex = 0;
            label1.Text = "體重(公斤)";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(68, 135);
            label2.Name = "label2";
            label2.Size = new Size(181, 56);
            label2.TabIndex = 1;
            label2.Text = "身高(公尺)";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(68, 214);
            label3.Name = "label3";
            label3.Size = new Size(141, 56);
            label3.TabIndex = 2;
            label3.Text = "BMI";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(68, 297);
            label4.Name = "label4";
            label4.Size = new Size(141, 56);
            label4.TabIndex = 3;
            label4.Text = "體態";
            // 
            // texKg
            // 
            texKg.Font = new Font("Microsoft JhengHei UI", 24F);
            texKg.Location = new Point(406, 49);
            texKg.Name = "texKg";
            texKg.Size = new Size(251, 48);
            texKg.TabIndex = 4;
            // 
            // texM
            // 
            texM.Font = new Font("Microsoft JhengHei UI", 24F);
            texM.Location = new Point(406, 135);
            texM.Name = "texM";
            texM.Size = new Size(251, 48);
            texM.TabIndex = 5;
            // 
            // labBMI
            // 
            labBMI.BorderStyle = BorderStyle.Fixed3D;
            labBMI.Font = new Font("Microsoft JhengHei UI", 24F);
            labBMI.Location = new Point(406, 214);
            labBMI.Name = "labBMI";
            labBMI.Size = new Size(251, 56);
            labBMI.TabIndex = 6;
            // 
            // labKarada
            // 
            labKarada.BorderStyle = BorderStyle.Fixed3D;
            labKarada.Font = new Font("Microsoft JhengHei UI", 24F);
            labKarada.Location = new Point(406, 296);
            labKarada.Name = "labKarada";
            labKarada.Size = new Size(251, 56);
            labKarada.TabIndex = 7;
            // 
            // butOut
            // 
            butOut.Location = new Point(272, 375);
            butOut.Name = "butOut";
            butOut.Size = new Size(273, 63);
            butOut.TabIndex = 8;
            butOut.Text = "計算與顯示";
            butOut.UseVisualStyleBackColor = true;
            butOut.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butOut);
            Controls.Add(labKarada);
            Controls.Add(labBMI);
            Controls.Add(texM);
            Controls.Add(texKg);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox texKg;
        private TextBox texM;
        private Label labBMI;
        private Label labKarada;
        private Button butOut;
    }
}
