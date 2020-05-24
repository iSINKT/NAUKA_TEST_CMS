namespace NAUKA_CMS
{
    partial class SuperUserSettings
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
            this.Log_T = new System.Windows.Forms.TextBox();
            this.Pass_T = new System.Windows.Forms.TextBox();
            this.Discard_B = new System.Windows.Forms.Button();
            this.Ok_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Log_T
            // 
            this.Log_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_T.Location = new System.Drawing.Point(149, 95);
            this.Log_T.Name = "Log_T";
            this.Log_T.Size = new System.Drawing.Size(183, 29);
            this.Log_T.TabIndex = 1;
            // 
            // Pass_T
            // 
            this.Pass_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass_T.Location = new System.Drawing.Point(149, 130);
            this.Pass_T.Name = "Pass_T";
            this.Pass_T.Size = new System.Drawing.Size(183, 29);
            this.Pass_T.TabIndex = 2;
            // 
            // Discard_B
            // 
            this.Discard_B.Location = new System.Drawing.Point(253, 188);
            this.Discard_B.Name = "Discard_B";
            this.Discard_B.Size = new System.Drawing.Size(75, 23);
            this.Discard_B.TabIndex = 4;
            this.Discard_B.Text = "Discard";
            this.Discard_B.UseVisualStyleBackColor = true;
            this.Discard_B.Click += new System.EventHandler(this.Discard_B_Click);
            // 
            // Ok_B
            // 
            this.Ok_B.Location = new System.Drawing.Point(172, 188);
            this.Ok_B.Name = "Ok_B";
            this.Ok_B.Size = new System.Drawing.Size(75, 23);
            this.Ok_B.TabIndex = 3;
            this.Ok_B.Text = "Ok";
            this.Ok_B.UseVisualStyleBackColor = true;
            this.Ok_B.Click += new System.EventHandler(this.Ok_B_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "You can change login or password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // SuperUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok_B);
            this.Controls.Add(this.Discard_B);
            this.Controls.Add(this.Pass_T);
            this.Controls.Add(this.Log_T);
            this.Name = "SuperUserSettings";
            this.Text = "SuperUserSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log_T;
        private System.Windows.Forms.TextBox Pass_T;
        private System.Windows.Forms.Button Discard_B;
        private System.Windows.Forms.Button Ok_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}