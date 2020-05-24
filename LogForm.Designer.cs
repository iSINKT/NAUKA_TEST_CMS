namespace NAUKA_CMS
{
    partial class LogForm
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.B_Sing_in = new System.Windows.Forms.Button();
            this.Forgot_LL = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAUKA_CMS";
            // 
            // Login
            // 
            this.Login.AccessibleDescription = "";
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(29, 109);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(267, 38);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // Pass
            // 
            this.Pass.AccessibleDescription = "";
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass.Location = new System.Drawing.Point(29, 153);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(267, 38);
            this.Pass.TabIndex = 2;
            this.Pass.Text = "Password";
            // 
            // B_Sing_in
            // 
            this.B_Sing_in.Location = new System.Drawing.Point(108, 197);
            this.B_Sing_in.Name = "B_Sing_in";
            this.B_Sing_in.Size = new System.Drawing.Size(116, 38);
            this.B_Sing_in.TabIndex = 3;
            this.B_Sing_in.Text = "Sing in";
            this.B_Sing_in.UseVisualStyleBackColor = true;
            this.B_Sing_in.Click += new System.EventHandler(this.B_Sing_in_Click);
            // 
            // Forgot_LL
            // 
            this.Forgot_LL.AutoSize = true;
            this.Forgot_LL.Location = new System.Drawing.Point(123, 255);
            this.Forgot_LL.Name = "Forgot_LL";
            this.Forgot_LL.Size = new System.Drawing.Size(71, 13);
            this.Forgot_LL.TabIndex = 5;
            this.Forgot_LL.TabStop = true;
            this.Forgot_LL.Text = "Forgot a pass";
            this.Forgot_LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forgot_LL_LinkClicked);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 280);
            this.Controls.Add(this.Forgot_LL);
            this.Controls.Add(this.B_Sing_in);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Name = "LogForm";
            this.Text = "NAUKA_CMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogForm_FormClosing);
     
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button B_Sing_in;
        private System.Windows.Forms.LinkLabel Forgot_LL;
    }
}

