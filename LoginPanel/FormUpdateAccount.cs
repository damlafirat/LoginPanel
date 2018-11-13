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
    public partial class FormUpdateAccount : Form
    {
        DB_LoginEntities dbl = new DB_LoginEntities();
        
        public FormUpdateAccount()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_firstname.Text) && !String.IsNullOrEmpty(textBox_surname.Text) && !String.IsNullOrEmpty(textBox_age.Text))
            {
                if (FormMain.checkInt(textBox_age.Text))
                {
                    var user = dbl.Account.Where(p => p.userName == textBox_username.Text).FirstOrDefault();

                    user.name = textBox_firstname.Text;
                    user.surname = textBox_surname.Text;
                    user.age = int.Parse(textBox_age.Text);

                    dbl.SaveChanges();

                    DialogResult dr = MessageBox.Show("Transaction successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                        this.Close();
                }

                else
                {
                    DialogResult dr = MessageBox.Show("İnvalid age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (dr == DialogResult.OK)
                        textBox_age.Text = "";
                }
            }

            else
            {
                DialogResult dr = MessageBox.Show("İnvalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                {
                    textBox_firstname.Text = "";
                    textBox_surname.Text = "";
                    textBox_age.Text = "";
                }
            }

        }

        private void FormUpdateAccount_Load(object sender, EventArgs e)
        {
            label_name.Visible = false;
            label_surname.Visible = false;
            label_age.Visible = false;

            textBox_firstname.Visible = false;
            textBox_surname.Visible = false;
            textBox_age.Visible = false;

            button_update.Visible = false;
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_username.Text))
            {
                if (FormMain.checkUsername(textBox_username.Text))
                {
                    var user = dbl.Account.Where(p => p.userName == textBox_username.Text).FirstOrDefault();

                    textBox_username.Enabled = false;
                    button_check.Enabled = false;

                    label_name.Visible = true;
                    label_surname.Visible = true;
                    label_age.Visible = true;

                    textBox_firstname.Visible = true;
                    textBox_surname.Visible = true;
                    textBox_age.Visible = true;

                    textBox_firstname.Text = user.name;
                    textBox_surname.Text = user.surname;
                    textBox_age.Text = user.age.ToString();

                    button_update.Visible = true;
                }

                else
                {
                    DialogResult dr = MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                        textBox_username.Text = "";
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("İnvalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                    textBox_username.Text = "";
            }
        }
    }
}
