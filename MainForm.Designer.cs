namespace NAUKA_CMS
{
    partial class MainForm
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
            this.TDep_CB = new System.Windows.Forms.ComboBox();
            this.ListOfPerson = new System.Windows.Forms.ListBox();
            this.CardOfPerson = new System.Windows.Forms.Panel();
            this.Tcon_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Email_L = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.AbM_T = new System.Windows.Forms.TextBox();
            this.Email_T = new System.Windows.Forms.TextBox();
            this.Patr_T = new System.Windows.Forms.TextBox();
            this.Dep_CB = new System.Windows.Forms.ComboBox();
            this.Addr_T = new System.Windows.Forms.TextBox();
            this.LName_T = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.FName_T = new System.Windows.Forms.TextBox();
            this.Save_Bt = new System.Windows.Forms.Button();
            this.Edit_B = new System.Windows.Forms.Button();
            this.DoB_L = new System.Windows.Forms.Label();
            this.AbM_L = new System.Windows.Forms.Label();
            this.Dep_L = new System.Windows.Forms.Label();
            this.Addr_L = new System.Windows.Forms.Label();
            this.Patr_L = new System.Windows.Forms.Label();
            this.LName_L = new System.Windows.Forms.Label();
            this.FName_L = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Depart_L = new System.Windows.Forms.Label();
            this.ListOfPersons_L = new System.Windows.Forms.Label();
            this.CardOfPerson.SuspendLayout();
            this.Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TDep_CB
            // 
            this.TDep_CB.FormattingEnabled = true;
            this.TDep_CB.Location = new System.Drawing.Point(11, 66);
            this.TDep_CB.Name = "TDep_CB";
            this.TDep_CB.Size = new System.Drawing.Size(228, 21);
            this.TDep_CB.TabIndex = 0;
            this.TDep_CB.SelectedIndexChanged += new System.EventHandler(this.TDep_CM_SelectedIndexChanged);
            // 
            // ListOfPerson
            // 
            this.ListOfPerson.FormattingEnabled = true;
            this.ListOfPerson.Location = new System.Drawing.Point(12, 132);
            this.ListOfPerson.Name = "ListOfPerson";
            this.ListOfPerson.Size = new System.Drawing.Size(227, 355);
            this.ListOfPerson.TabIndex = 1;
            this.ListOfPerson.SelectedIndexChanged += new System.EventHandler(this.ListOfPerson_SelectedIndexChanged);
            // 
            // CardOfPerson
            // 
            this.CardOfPerson.Controls.Add(this.Tcon_B);
            this.CardOfPerson.Controls.Add(this.Del_B);
            this.CardOfPerson.Controls.Add(this.Email_L);
            this.CardOfPerson.Controls.Add(this.Panel);
            this.CardOfPerson.Controls.Add(this.Save_Bt);
            this.CardOfPerson.Controls.Add(this.Edit_B);
            this.CardOfPerson.Controls.Add(this.DoB_L);
            this.CardOfPerson.Controls.Add(this.AbM_L);
            this.CardOfPerson.Controls.Add(this.Dep_L);
            this.CardOfPerson.Controls.Add(this.Addr_L);
            this.CardOfPerson.Controls.Add(this.Patr_L);
            this.CardOfPerson.Controls.Add(this.LName_L);
            this.CardOfPerson.Controls.Add(this.FName_L);
            this.CardOfPerson.Location = new System.Drawing.Point(245, 27);
            this.CardOfPerson.Name = "CardOfPerson";
            this.CardOfPerson.Size = new System.Drawing.Size(488, 484);
            this.CardOfPerson.TabIndex = 2;
            this.CardOfPerson.Visible = false;
            // 
            // Tcon_B
            // 
            this.Tcon_B.Location = new System.Drawing.Point(16, 341);
            this.Tcon_B.Name = "Tcon_B";
            this.Tcon_B.Size = new System.Drawing.Size(97, 25);
            this.Tcon_B.TabIndex = 31;
            this.Tcon_B.Text = "To connect";
            this.Tcon_B.UseVisualStyleBackColor = true;
            this.Tcon_B.Click += new System.EventHandler(this.Tcon_B_Click);
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(16, 435);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(97, 25);
            this.Del_B.TabIndex = 12;
            this.Del_B.Text = "Delete";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Email_L
            // 
            this.Email_L.AutoSize = true;
            this.Email_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_L.Location = new System.Drawing.Point(12, 260);
            this.Email_L.Name = "Email_L";
            this.Email_L.Size = new System.Drawing.Size(63, 24);
            this.Email_L.TabIndex = 30;
            this.Email_L.Text = "E-mail";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.AbM_T);
            this.Panel.Controls.Add(this.Email_T);
            this.Panel.Controls.Add(this.Patr_T);
            this.Panel.Controls.Add(this.Dep_CB);
            this.Panel.Controls.Add(this.Addr_T);
            this.Panel.Controls.Add(this.LName_T);
            this.Panel.Controls.Add(this.Data);
            this.Panel.Controls.Add(this.FName_T);
            this.Panel.Enabled = false;
            this.Panel.Location = new System.Drawing.Point(202, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(283, 478);
            this.Panel.TabIndex = 29;
            // 
            // AbM_T
            // 
            this.AbM_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AbM_T.Location = new System.Drawing.Point(20, 295);
            this.AbM_T.Multiline = true;
            this.AbM_T.Name = "AbM_T";
            this.AbM_T.Size = new System.Drawing.Size(252, 162);
            this.AbM_T.TabIndex = 8;
            // 
            // Email_T
            // 
            this.Email_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_T.Location = new System.Drawing.Point(20, 257);
            this.Email_T.Name = "Email_T";
            this.Email_T.Size = new System.Drawing.Size(252, 29);
            this.Email_T.TabIndex = 7;
            // 
            // Patr_T
            // 
            this.Patr_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patr_T.Location = new System.Drawing.Point(20, 79);
            this.Patr_T.Name = "Patr_T";
            this.Patr_T.Size = new System.Drawing.Size(252, 29);
            this.Patr_T.TabIndex = 3;
            // 
            // Dep_CB
            // 
            this.Dep_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dep_CB.FormattingEnabled = true;
            this.Dep_CB.ItemHeight = 24;
            this.Dep_CB.Location = new System.Drawing.Point(20, 214);
            this.Dep_CB.Name = "Dep_CB";
            this.Dep_CB.Size = new System.Drawing.Size(252, 32);
            this.Dep_CB.TabIndex = 6;
            // 
            // Addr_T
            // 
            this.Addr_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addr_T.Location = new System.Drawing.Point(20, 149);
            this.Addr_T.Multiline = true;
            this.Addr_T.Name = "Addr_T";
            this.Addr_T.Size = new System.Drawing.Size(252, 59);
            this.Addr_T.TabIndex = 5;
            // 
            // LName_T
            // 
            this.LName_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName_T.Location = new System.Drawing.Point(20, 44);
            this.LName_T.Name = "LName_T";
            this.LName_T.Size = new System.Drawing.Size(252, 29);
            this.LName_T.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data.Location = new System.Drawing.Point(20, 114);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(252, 29);
            this.Data.TabIndex = 4;
            // 
            // FName_T
            // 
            this.FName_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FName_T.Location = new System.Drawing.Point(20, 9);
            this.FName_T.Name = "FName_T";
            this.FName_T.Size = new System.Drawing.Size(252, 29);
            this.FName_T.TabIndex = 1;
            // 
            // Save_Bt
            // 
            this.Save_Bt.Enabled = false;
            this.Save_Bt.Location = new System.Drawing.Point(16, 403);
            this.Save_Bt.Name = "Save_Bt";
            this.Save_Bt.Size = new System.Drawing.Size(97, 25);
            this.Save_Bt.TabIndex = 11;
            this.Save_Bt.Text = "Save";
            this.Save_Bt.UseVisualStyleBackColor = true;
            this.Save_Bt.Click += new System.EventHandler(this.Save_Bt_Click);
            // 
            // Edit_B
            // 
            this.Edit_B.Location = new System.Drawing.Point(16, 372);
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(97, 25);
            this.Edit_B.TabIndex = 10;
            this.Edit_B.Text = "Edit";
            this.Edit_B.UseVisualStyleBackColor = true;
            this.Edit_B.Click += new System.EventHandler(this.Edit_B_Click);
            // 
            // DoB_L
            // 
            this.DoB_L.AutoSize = true;
            this.DoB_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoB_L.Location = new System.Drawing.Point(12, 117);
            this.DoB_L.Name = "DoB_L";
            this.DoB_L.Size = new System.Drawing.Size(110, 24);
            this.DoB_L.TabIndex = 20;
            this.DoB_L.Text = "Date of Birth";
            // 
            // AbM_L
            // 
            this.AbM_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AbM_L.Location = new System.Drawing.Point(12, 295);
            this.AbM_L.Name = "AbM_L";
            this.AbM_L.Size = new System.Drawing.Size(160, 31);
            this.AbM_L.TabIndex = 21;
            this.AbM_L.Text = "About Myself";
            // 
            // Dep_L
            // 
            this.Dep_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dep_L.Location = new System.Drawing.Point(12, 217);
            this.Dep_L.Name = "Dep_L";
            this.Dep_L.Size = new System.Drawing.Size(160, 38);
            this.Dep_L.TabIndex = 22;
            this.Dep_L.Text = "Fraction";
            // 
            // Addr_L
            // 
            this.Addr_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addr_L.Location = new System.Drawing.Point(12, 152);
            this.Addr_L.Name = "Addr_L";
            this.Addr_L.Size = new System.Drawing.Size(103, 59);
            this.Addr_L.TabIndex = 23;
            this.Addr_L.Text = "Address of residence";
            // 
            // Patr_L
            // 
            this.Patr_L.AutoSize = true;
            this.Patr_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patr_L.Location = new System.Drawing.Point(12, 85);
            this.Patr_L.Name = "Patr_L";
            this.Patr_L.Size = new System.Drawing.Size(103, 24);
            this.Patr_L.TabIndex = 24;
            this.Patr_L.Text = "Patronymic";
            // 
            // LName_L
            // 
            this.LName_L.AutoSize = true;
            this.LName_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName_L.Location = new System.Drawing.Point(14, 47);
            this.LName_L.Name = "LName_L";
            this.LName_L.Size = new System.Drawing.Size(99, 24);
            this.LName_L.TabIndex = 16;
            this.LName_L.Text = "Last Name";
            // 
            // FName_L
            // 
            this.FName_L.AutoSize = true;
            this.FName_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FName_L.Location = new System.Drawing.Point(12, 12);
            this.FName_L.Name = "FName_L";
            this.FName_L.Size = new System.Drawing.Size(101, 24);
            this.FName_L.TabIndex = 14;
            this.FName_L.Text = "First Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPersonToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPersonToolStripMenuItem
            // 
            this.newPersonToolStripMenuItem.Name = "newPersonToolStripMenuItem";
            this.newPersonToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.newPersonToolStripMenuItem.Text = "New person";
            this.newPersonToolStripMenuItem.Click += new System.EventHandler(this.newPersonToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // Depart_L
            // 
            this.Depart_L.AutoSize = true;
            this.Depart_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Depart_L.Location = new System.Drawing.Point(8, 39);
            this.Depart_L.Name = "Depart_L";
            this.Depart_L.Size = new System.Drawing.Size(78, 24);
            this.Depart_L.TabIndex = 15;
            this.Depart_L.Text = "Fraction";
            // 
            // ListOfPersons_L
            // 
            this.ListOfPersons_L.AutoSize = true;
            this.ListOfPersons_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfPersons_L.Location = new System.Drawing.Point(8, 102);
            this.ListOfPersons_L.Name = "ListOfPersons_L";
            this.ListOfPersons_L.Size = new System.Drawing.Size(130, 24);
            this.ListOfPersons_L.TabIndex = 16;
            this.ListOfPersons_L.Text = "List of persons";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 497);
            this.Controls.Add(this.ListOfPersons_L);
            this.Controls.Add(this.Depart_L);
            this.Controls.Add(this.CardOfPerson);
            this.Controls.Add(this.ListOfPerson);
            this.Controls.Add(this.TDep_CB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NAUKA_CMS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CardOfPerson.ResumeLayout(false);
            this.CardOfPerson.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TDep_CB;
        private System.Windows.Forms.ListBox ListOfPerson;
        private System.Windows.Forms.Panel CardOfPerson;
        private System.Windows.Forms.ComboBox Dep_CB;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Label DoB_L;
        private System.Windows.Forms.Label AbM_L;
        private System.Windows.Forms.Label Dep_L;
        private System.Windows.Forms.Label Addr_L;
        private System.Windows.Forms.TextBox AbM_T;
        private System.Windows.Forms.TextBox Addr_T;
        private System.Windows.Forms.Label Patr_L;
        private System.Windows.Forms.TextBox Patr_T;
        private System.Windows.Forms.Label LName_L;
        private System.Windows.Forms.TextBox LName_T;
        private System.Windows.Forms.Label FName_L;
        private System.Windows.Forms.TextBox FName_T;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Edit_B;
        private System.Windows.Forms.Label Depart_L;
        private System.Windows.Forms.Label ListOfPersons_L;
        private System.Windows.Forms.Button Save_Bt;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label Email_L;
        private System.Windows.Forms.TextBox Email_T;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.Button Tcon_B;
    }
}