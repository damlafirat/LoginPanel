namespace LoginPanel
{
    partial class FormResetPassword
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
            this.button_reset = new System.Windows.Forms.Button();
            this.textBox_passwordNewConfirm = new System.Windows.Forms.TextBox();
            this.label_passwordConfirm = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.label_newPassword = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_reset.Location = new System.Drawing.Point(234, 231);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(85, 35);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // textBox_passwordNewConfirm
            // 
            this.textBox_passwordNewConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_passwordNewConfirm.Location = new System.Drawing.Point(200, 191);
            this.textBox_passwordNewConfirm.Name = "textBox_passwordNewConfirm";
            this.textBox_passwordNewConfirm.PasswordChar = '*';
            this.textBox_passwordNewConfirm.Size = new System.Drawing.Size(210, 26);
            this.textBox_passwordNewConfirm.TabIndex = 5;
            // 
            // label_passwordConfirm
            // 
            this.label_passwordConfirm.AutoSize = true;
            this.label_passwordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_passwordConfirm.Location = new System.Drawing.Point(25, 191);
            this.label_passwordConfirm.Name = "label_passwordConfirm";
            this.label_passwordConfirm.Size = new System.Drawing.Size(172, 20);
            this.label_passwordConfirm.TabIndex = 18;
            this.label_passwordConfirm.Text = "Confirm New Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_password.Location = new System.Drawing.Point(200, 60);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(210, 26);
            this.textBox_password.TabIndex = 2;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_password.Location = new System.Drawing.Point(25, 60);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(78, 20);
            this.label_password.TabIndex = 16;
            this.label_password.Text = "Password";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_username.Location = new System.Drawing.Point(200, 20);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(210, 26);
            this.textBox_username.TabIndex = 1;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_username.Location = new System.Drawing.Point(25, 20);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(83, 20);
            this.label_username.TabIndex = 14;
            this.label_username.Text = "Username";
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cancel.Location = new System.Drawing.Point(325, 231);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(85, 35);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_newPassword.Location = new System.Drawing.Point(200, 151);
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.PasswordChar = '*';
            this.textBox_newPassword.Size = new System.Drawing.Size(210, 26);
            this.textBox_newPassword.TabIndex = 4;
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_newPassword.Location = new System.Drawing.Point(25, 151);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(113, 20);
            this.label_newPassword.TabIndex = 22;
            this.label_newPassword.Text = "New Password";
            // 
            // button_check
            // 
            this.button_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_check.Location = new System.Drawing.Point(325, 101);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(85, 35);
            this.button_check.TabIndex = 3;
            this.button_check.Text = "Check";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 289);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.textBox_newPassword);
            this.Controls.Add(this.label_newPassword);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox_passwordNewConfirm);
            this.Controls.Add(this.label_passwordConfirm);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.Name = "FormResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResetPassword";
            this.Load += new System.EventHandler(this.FormResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox textBox_passwordNewConfirm;
        private System.Windows.Forms.Label label_passwordConfirm;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private System.Windows.Forms.Label label_newPassword;
        private System.Windows.Forms.Button button_check;
    }
}