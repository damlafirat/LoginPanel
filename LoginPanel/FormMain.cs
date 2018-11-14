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
    public partial class FormMain : Form
    {
        static public DB_LoginEntities dbl = new DB_LoginEntities();
     
        public FormMain()
        {
            InitializeComponent();
        }

        public static bool checkInt(string s)
        {
            int result;

            if (int.TryParse(s, out result))
                return true;

            else return false;
        }

        public static string createPassword()
        {
            Random rnd = new Random();

            string s = "";

            for (int i = 0; i < 8; i++)
            {
                s += (char)rnd.Next(97, 121);
            }

            return s;
        }

        public static bool checkUsername(string s)
        {
            var user = dbl.Account.Where(p => p.userName == s).Where(q => q.is_valid == "Y").FirstOrDefault();

            if (user != null)
                return true;

            else
                return false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_userName.Text) && !String.IsNullOrEmpty(textBox_password.Text))
            {
                var user = dbl.Account.Where(p => p.userName == textBox_userName.Text).Where(q => q.is_valid =="Y").FirstOrDefault();

                if (user != null)
                {
                    if (user.password == textBox_password.Text)
                    {
                        user.entryCount++;
                        dbl.SaveChanges();

                        FormWelcome frmW = new FormWelcome();
                        frmW.userName = user.name;
                        frmW.ShowDialog();
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
                    DialogResult dr = MessageBox.Show("İnvalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (dr == DialogResult.OK)
                    {
                        textBox_userName.Text = "";
                        textBox_password.Text = "";
                    }
                }
            }

            else
            {
                DialogResult dr = MessageBox.Show("İnvalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                {
                    textBox_userName.Text = "";
                    textBox_password.Text = "";
                }
            }
        }

        private void linkLabel_resetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormResetPassword frmRP = new FormResetPassword();
            frmRP.ShowDialog();
        }

        private void linkLabel_createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCreateAccount frmCA = new FormCreateAccount();
            frmCA.ShowDialog();
        }

        private void linkLabel_UpdateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUpdateAccount frmUA = new FormUpdateAccount();
            frmUA.ShowDialog();
        }

        private void linkLabel_deleteAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDeleteAccount frmDA = new FormDeleteAccount();
            frmDA.ShowDialog();
        }
    }
}
