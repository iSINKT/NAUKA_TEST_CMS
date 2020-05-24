namespace NAUKA_CMS
{
    partial class ForgotAPass
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
            this.Mail_T = new System.Windows.Forms.TextBox();
            this.Confirm_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your E-mail to recovery login and password";
            // 
            // Mail_T
            // 
            this.Mail_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mail_T.Location = new System.Drawing.Point(18, 67);
            this.Mail_T.Name = "Mail_T";
            this.Mail_T.Size = new System.Drawing.Size(248, 29);
            this.Mail_T.TabIndex = 1;
            // 
            // Confirm_B
            // 
            this.Confirm_B.Location = new System.Drawing.Point(308, 67);
            this.Confirm_B.Name = "Confirm_B";
            this.Confirm_B.Size = new System.Drawing.Size(91, 29);
            this.Confirm_B.TabIndex = 2;
            this.Confirm_B.Text = "Confirm";
            this.Confirm_B.UseVisualStyleBackColor = true;
            this.Confirm_B.Click += new System.EventHandler(this.Confirm_B_Click);
            // 
            // ForgotAPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 124);
            this.Controls.Add(this.Confirm_B);
            this.Controls.Add(this.Mail_T);
            this.Controls.Add(this.label1);
            this.Name = "ForgotAPass";
            this.Text = "Forgot a Pass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgotAPass_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mail_T;
        private System.Windows.Forms.Button Confirm_B;
    }
}