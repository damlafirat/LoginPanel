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
            this.label_UpdateAcc = new System.Windows.Forms.Label();
            this.label_createAccount = new System.Windows.Forms.Label();
            this.label_resetPassword = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_deleteAcc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_UpdateAcc
            // 
            this.label_UpdateAcc.AutoSize = true;
            this.label_UpdateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_UpdateAcc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_UpdateAcc.Location = new System.Drawing.Point(63, 172);
            this.label_UpdateAcc.Name = "label_UpdateAcc";
            this.label_UpdateAcc.Size = new System.Drawing.Size(104, 16);
            this.label_UpdateAcc.TabIndex = 7;
            this.label_UpdateAcc.Text = "Update Account";
            this.label_UpdateAcc.Click += new System.EventHandler(this.label_UpdateAcc_Click);
            // 
            // label_createAccount
            // 
            this.label_createAccount.AutoSize = true;
            this.label_createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_createAccount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_createAccount.Location = new System.Drawing.Point(173, 146);
            this.label_createAccount.Name = "label_createAccount";
            this.label_createAccount.Size = new System.Drawing.Size(99, 16);
            this.label_createAccount.TabIndex = 6;
            this.label_createAccount.Text = "Create Account";
            this.label_createAccount.Click += new System.EventHandler(this.label_createAccount_Click);
            // 
            // label_resetPassword
            // 
            this.label_resetPassword.AutoSize = true;
            this.label_resetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_resetPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_resetPassword.Location = new System.Drawing.Point(63, 146);
            this.label_resetPassword.Name = "label_resetPassword";
            this.label_resetPassword.Size = new System.Drawing.Size(107, 16);
            this.label_resetPassword.TabIndex = 5;
            this.label_resetPassword.Text = "Reset Password";
            this.label_resetPassword.Click += new System.EventHandler(this.label_resetPassword_Click);
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
            // label_deleteAcc
            // 
            this.label_deleteAcc.AutoSize = true;
            this.label_deleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_deleteAcc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_deleteAcc.Location = new System.Drawing.Point(173, 172);
            this.label_deleteAcc.Name = "label_deleteAcc";
            this.label_deleteAcc.Size = new System.Drawing.Size(99, 16);
            this.label_deleteAcc.TabIndex = 8;
            this.label_deleteAcc.Text = "Delete Account";
            this.label_deleteAcc.Click += new System.EventHandler(this.label_deleteAcc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 204);
            this.Controls.Add(this.label_deleteAcc);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_UpdateAcc);
            this.Controls.Add(this.label_createAccount);
            this.Controls.Add(this.label_resetPassword);
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

        private System.Windows.Forms.Label label_UpdateAcc;
        private System.Windows.Forms.Label label_createAccount;
        private System.Windows.Forms.Label label_resetPassword;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_deleteAcc;
    }
}

