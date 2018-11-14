namespace LoginPanel
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
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.linkLabel_resetPassword = new System.Windows.Forms.LinkLabel();
            this.linkLabel_createAccount = new System.Windows.Forms.LinkLabel();
            this.linkLabel_UpdateAccount = new System.Windows.Forms.LinkLabel();
            this.linkLabel_deleteAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_password.Location = new System.Drawing.Point(120, 60);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(210, 26);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_userName.Location = new System.Drawing.Point(120, 20);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(210, 26);
            this.textBox_userName.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_login.Location = new System.Drawing.Point(155, 100);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(80, 35);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Log in";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_password.Location = new System.Drawing.Point(25, 60);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(78, 20);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Password";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_userName.Location = new System.Drawing.Point(25, 20);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(87, 20);
            this.label_userName.TabIndex = 8;
            this.label_userName.Text = "User name";
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cancel.Location = new System.Drawing.Point(250, 100);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(80, 35);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // linkLabel_resetPassword
            // 
            this.linkLabel_resetPassword.AutoSize = true;
            this.linkLabel_resetPassword.Location = new System.Drawing.Point(274, 156);
            this.linkLabel_resetPassword.Name = "linkLabel_resetPassword";
            this.linkLabel_resetPassword.Size = new System.Drawing.Size(84, 13);
            this.linkLabel_resetPassword.TabIndex = 10;
            this.linkLabel_resetPassword.TabStop = true;
            this.linkLabel_resetPassword.Text = "Reset Password";
            this.linkLabel_resetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_resetPassword_LinkClicked);
            // 
            // linkLabel_createAccount
            // 
            this.linkLabel_createAccount.AutoSize = true;
            this.linkLabel_createAccount.Location = new System.Drawing.Point(9, 156);
            this.linkLabel_createAccount.Name = "linkLabel_createAccount";
            this.linkLabel_createAccount.Size = new System.Drawing.Size(81, 13);
            this.linkLabel_createAccount.TabIndex = 11;
            this.linkLabel_createAccount.TabStop = true;
            this.linkLabel_createAccount.Text = "Create Account";
            this.linkLabel_createAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_createAccount_LinkClicked);
            // 
            // linkLabel_UpdateAccount
            // 
            this.linkLabel_UpdateAccount.AutoSize = true;
            this.linkLabel_UpdateAccount.Location = new System.Drawing.Point(96, 156);
            this.linkLabel_UpdateAccount.Name = "linkLabel_UpdateAccount";
            this.linkLabel_UpdateAccount.Size = new System.Drawing.Size(85, 13);
            this.linkLabel_UpdateAccount.TabIndex = 12;
            this.linkLabel_UpdateAccount.TabStop = true;
            this.linkLabel_UpdateAccount.Text = "Update Account";
            this.linkLabel_UpdateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_UpdateAccount_LinkClicked);
            // 
            // linkLabel_deleteAccount
            // 
            this.linkLabel_deleteAccount.AutoSize = true;
            this.linkLabel_deleteAccount.Location = new System.Drawing.Point(187, 156);
            this.linkLabel_deleteAccount.Name = "linkLabel_deleteAccount";
            this.linkLabel_deleteAccount.Size = new System.Drawing.Size(81, 13);
            this.linkLabel_deleteAccount.TabIndex = 13;
            this.linkLabel_deleteAccount.TabStop = true;
            this.linkLabel_deleteAccount.Text = "Delete Account";
            this.linkLabel_deleteAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_deleteAccount_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.linkLabel_deleteAccount);
            this.Controls.Add(this.linkLabel_UpdateAccount);
            this.Controls.Add(this.linkLabel_createAccount);
            this.Controls.Add(this.linkLabel_resetPassword);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_userName);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.LinkLabel linkLabel_resetPassword;
        private System.Windows.Forms.LinkLabel linkLabel_createAccount;
        private System.Windows.Forms.LinkLabel linkLabel_UpdateAccount;
        private System.Windows.Forms.LinkLabel linkLabel_deleteAccount;
    }
}

