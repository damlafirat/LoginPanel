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
    public partial class FormDeleteAccount : Form
    {
        public FormDeleteAccount()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_username.Text) && !String.IsNullOrEmpty(textBox_password.Text) && ! String.IsNullOrEmpty(textBox_passwordConfirm.Text))
            {
                if (textBox_password.Text == textBox_passwordConfirm.Text)
                {
                    if (FormMain.checkUsername(textBox_username.Text))
                    {
                        var user = FormMain.dbl.Account.Where(p => p.userName == textBox_username.Text).FirstOrDefault();

                        if (user.password == textBox_password.Text)
                        {
                            DialogResult dr = MessageBox.Show("Are you sure to delete your account", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dr == DialogResult.Yes)
                            {
                                user.is_valid = "N";
                                FormMain.dbl.SaveChanges();

                                DialogResult drs = MessageBox.Show("Transaction successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (drs == DialogResult.OK)
                                    this.Close();
                            }
                        }

                        else
                        {
                            DialogResult dr = MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (dr == DialogResult.OK)
                            {
                                textBox_password.Text = "";
                                textBox_passwordConfirm.Text = "";

                            }
                        }
                    }
                    
                    else
                    {
                        DialogResult dr = MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (dr == DialogResult.OK)
                        {
                            textBox_username.Text = "";
                            textBox_password.Text = "";
                            textBox_passwordConfirm.Text = "";
                        }
                    }
                }

                else
                {
                    DialogResult dr = MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (dr == DialogResult.OK)
                    {
                        textBox_password.Text = "";
                        textBox_passwordConfirm.Text = "";
                    }
                }
            }

            else
            {
                DialogResult dr = MessageBox.Show("İnvalid input/inputs", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                {
                    textBox_username.Text = "";
                    textBox_password.Text = "";
                    textBox_passwordConfirm.Text = "";
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
