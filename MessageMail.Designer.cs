namespace NAUKA_CMS
{
    partial class MessageMail
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
            this.Message_T = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Mail_T = new System.Windows.Forms.TextBox();
            this.Body_L = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message_T
            // 
            this.Message_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_T.Location = new System.Drawing.Point(12, 100);
            this.Message_T.Multiline = true;
            this.Message_T.Name = "Message_T";
            this.Message_T.Size = new System.Drawing.Size(405, 276);
            this.Message_T.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mail_T
            // 
            this.Mail_T.Enabled = false;
            this.Mail_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mail_T.Location = new System.Drawing.Point(200, 25);
            this.Mail_T.Name = "Mail_T";
            this.Mail_T.Size = new System.Drawing.Size(217, 29);
            this.Mail_T.TabIndex = 2;
            // 
            // Body_L
            // 
            this.Body_L.AutoSize = true;
            this.Body_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Body_L.Location = new System.Drawing.Point(12, 71);
            this.Body_L.Name = "Body_L";
            this.Body_L.Size = new System.Drawing.Size(135, 24);
            this.Body_L.TabIndex = 3;
            this.Body_L.Text = "Body message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail";
            // 
            // MessageMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Body_L);
            this.Controls.Add(this.Mail_T);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Message_T);
            this.Name = "MessageMail";
            this.Text = "Message Mail";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message_T;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Mail_T;
        private System.Windows.Forms.Label Body_L;
        private System.Windows.Forms.Label label1;
    }
}