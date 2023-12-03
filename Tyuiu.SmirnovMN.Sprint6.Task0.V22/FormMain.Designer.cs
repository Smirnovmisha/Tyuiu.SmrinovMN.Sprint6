namespace Tyuiu.SmirnovMN.Sprint6.Task0.V22
{
    partial class FormMain
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
            this.button_PushMe_SMN = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button_PushMe_SMN
            // 
            this.button_PushMe_SMN.Location = new System.Drawing.Point(511, 338);
            this.button_PushMe_SMN.Name = "button_PushMe_SMN";
            this.button_PushMe_SMN.Size = new System.Drawing.Size(97, 92);
            this.button_PushMe_SMN.TabIndex = 0;
            this.button_PushMe_SMN.Text = "?";
            this.button_PushMe_SMN.UseVisualStyleBackColor = true;
            this.button_PushMe_SMN.Click += new System.EventHandler(this.button_PushMe_SMN_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(579, 436);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button_PushMe_SMN);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_PushMe_SMN;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

