using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project0
{
    public partial class AdminChangePassword : Form
    {
        private HospitalDataContext database = new HospitalDataContext();

        public string username { get; private set; }

        public AdminChangePassword(string username)
        {    InitializeComponent();
            this.username= username; 
        }

        public AdminChangePassword()
        {
            InitializeComponent();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
   
        }

        private void AdminChangePassword_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var admin = from user in database.Users
                        where user.User_name == username 
                        select user; if (admin.First().Password.Equals(passwordTextBox.Text)) 
            { if (!(newPasswordTextBox.Text.Equals(newPassword2TextBox.Text))) 
                { MessageBox.Show("新密码不一致。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (newPasswordTextBox.Text == "") 
                { MessageBox.Show("密码字段不能为空。", "空字段", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else 
                { foreach (Users user in admin) { user.Password = newPasswordTextBox.Text; } 
                        database.SubmitChanges(); 
                    MessageBox.Show("密码已成功更改。", "密码已更改", MessageBoxButtons.OK); 
                }
            } else 
                MessageBox.Show("密码错误，请重新输入密码。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
