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
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void button_createAcc_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_firstname.Text) && !String.IsNullOrEmpty(textBox_surname.Text) && !String.IsNullOrEmpty(textBox_age.Text) && !String.IsNullOrEmpty(textBox_username.Text))
            {
                if (FormMain.checkInt(textBox_age.Text))
                {
                    if (!FormMain.checkUsername(textBox_username.Text))
                    {
                        var acc = new Account()
                        {
                            name = textBox_firstname.Text,
                            surname = textBox_surname.Text,
                            userName = textBox_username.Text,
                            age = int.Parse(textBox_age.Text),
                            entryCount = 0,
                            is_valid = "Y",
                            password = FormMain.createPassword()
                        };

                        FormMain.dbl.Account.Add(acc);
                        FormMain.dbl.SaveChanges();

                        DialogResult dr = MessageBox.Show($"Your password : {acc.password}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (dr == DialogResult.OK)
                            this.Close();
                    }

                    else
                    {
                        DialogResult dr = MessageBox.Show($"Username is exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (dr == DialogResult.OK)
                            textBox_username.Text = "";
                    }
                }

                else
                {
                    DialogResult dr = MessageBox.Show("Age is invalid input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (dr == DialogResult.OK)
                        textBox_age.Text = "";
                }
            }

            else
            {
                DialogResult dr = MessageBox.Show("İnvalid input/inputs", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                {
                    textBox_firstname.Text = "";
                    textBox_surname.Text = "";
                    textBox_username.Text = "";
                    textBox_age.Text = "";
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
