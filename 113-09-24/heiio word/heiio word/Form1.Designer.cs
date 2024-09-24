namespace heiio_word
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
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = SystemColors.ActiveCaption;
            btnDisplay.Font = new Font("Yu Gothic UI Semibold", 20F);
            btnDisplay.ForeColor = Color.Snow;
            btnDisplay.Location = new Point(254, 155);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(252, 111);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "顯示訊息";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 421);
            Controls.Add(btnDisplay);
            Name = "Form1";
            Text = "name";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
    }
}
