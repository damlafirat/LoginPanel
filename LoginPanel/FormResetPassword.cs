using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPanel
{
    public partial class FormResetPassword : Form
    {
        public FormResetPassword()
        {
            InitializeComponent();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_newPassword.Text) && !String.IsNullOrEmpty(textBox_passwordNewConfirm.Text))
            {
                if (textBox_newPassword.Text == textBox_passwordNewConfirm.Text)
                {
                    var user = FormMain.dbl.Account.Where(p => p.userName == textBox_username.Text).FirstOrDefault();

                    user.password = textBox_newPassword.Text;

                    FormMain.dbl.SaveChanges();

                    DialogResult dr = MessageBox.Show("Transaction successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                        this.Close();
                }

                else
                {
                    DialogResult dr = MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (dr == DialogResult.OK)
                    {
                        textBox_newPassword.Text = "";
                        textBox_passwordNewConfirm.Text = "";
                    }
                }
            }

            else
            {
                DialogResult dr = MessageBox.Show("İnvalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                {
                    textBox_newPassword.Text = "";
                    textBox_passwordNewConfirm.Text = "";
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_username.Text) && !String.IsNullOrEmpty(textBox_password.Text))
            {
                if (FormMain.checkUsername(textBox_username.Text))
                {
                    var user = FormMain.dbl.Account.Where(p => p.userName == textBox_username.Text).FirstOrDefault();

                    if (user.password == textBox_password.Text)
                    {
                        label_newPassword.Visible = true;
                        label_passwordConfirm.Visible = true;

                        textBox_newPassword.Visible = true;
                        textBox_passwordNewConfirm.Visible = true;

                        button_reset.Visible = true;

                        textBox_username.Enabled = false;
                        textBox_password.Enabled = false;

                        button_check.Enabled = false;
                    }

                    else
                    {
                        DialogResult dr = MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dr == DialogResult.OK)
                            textBox_password.Text = "";
                    }
                }

                else
                {
                    DialogResult dr = MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        textBox_username.Text = "";
                        textBox_password.Text = "";
                    }
                }
            }

            else
            {
                DialogResult dr = MessageBox.Show("İnvalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                {
                    textBox_username.Text = "";
                    textBox_password.Text = "";
                }
            }
        }

        private void FormResetPassword_Load(object sender, EventArgs e)
        {
            label_newPassword.Visible = false;
            label_passwordConfirm.Visible = false;

            textBox_newPassword.Visible = false;
            textBox_passwordNewConfirm.Visible = false;

            button_reset.Visible = false;
        }
    }
}
