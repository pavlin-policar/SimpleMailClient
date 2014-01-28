namespace MailClient.wuc
{
    partial class wuc_login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.cb_domains = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.Label();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.cb_domains);
            this.gb_login.Controls.Add(this.label2);
            this.gb_login.Controls.Add(this.button1);
            this.gb_login.Controls.Add(this.tb_password);
            this.gb_login.Controls.Add(this.tb_username);
            this.gb_login.Controls.Add(this.label1);
            this.gb_login.Controls.Add(this.l_username);
            this.gb_login.Location = new System.Drawing.Point(3, 3);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(342, 104);
            this.gb_login.TabIndex = 2;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Login";
            // 
            // cb_domains
            // 
            this.cb_domains.FormattingEnabled = true;
            this.cb_domains.Location = new System.Drawing.Point(210, 16);
            this.cb_domains.Name = "cb_domains";
            this.cb_domains.Size = new System.Drawing.Size(126, 21);
            this.cb_domains.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "@";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Login);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(72, 44);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(264, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(72, 17);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(113, 20);
            this.tb_username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.Location = new System.Drawing.Point(8, 20);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(58, 13);
            this.l_username.TabIndex = 0;
            this.l_username.Text = "Username:";
            // 
            // wuc_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_login);
            this.Name = "wuc_login";
            this.Size = new System.Drawing.Size(348, 112);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.ComboBox cb_domains;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_username;
    }
}
