﻿namespace Program4_10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texcalory = new System.Windows.Forms.TextBox();
            this.texgram = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labOutput = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "The total number of calories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "The number of fat grams:";
            // 
            // texcalory
            // 
            this.texcalory.Location = new System.Drawing.Point(161, 12);
            this.texcalory.Name = "texcalory";
            this.texcalory.Size = new System.Drawing.Size(100, 22);
            this.texcalory.TabIndex = 2;
            // 
            // texgram
            // 
            this.texgram.Location = new System.Drawing.Point(161, 42);
            this.texgram.Name = "texgram";
            this.texgram.Size = new System.Drawing.Size(100, 22);
            this.texgram.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labOutput
            // 
            this.labOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labOutput.Location = new System.Drawing.Point(15, 125);
            this.labOutput.Name = "labOutput";
            this.labOutput.Size = new System.Drawing.Size(246, 60);
            this.labOutput.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(237, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Check if you want to know the food is low fat";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 197);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texgram);
            this.Controls.Add(this.texcalory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program4_10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texcalory;
        private System.Windows.Forms.TextBox texgram;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labOutput;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

