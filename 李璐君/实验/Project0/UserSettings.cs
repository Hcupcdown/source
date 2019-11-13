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
    public partial class UserSettings : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private string username;
        private void loadData()
        { userBindingSource.DataSource = from user in database.Users
                where user.User_name == username 
                select user; 
        }
        public UserSettings(string username)
        {
            InitializeComponent(); 
            this.username = username;
        }
        public UserSettings()
        {
            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
                MessageBox.Show("密码字段不能为空。", "空白字段", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (user_nameTextBox.Text == "") 
                MessageBox.Show("用户名字段不能为空。", "空白字段", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            { 
                Validate(); 
                userBindingSource.EndEdit(); 
                database.SubmitChanges(); 
                loadData(); 
                MessageBox.Show("你的更改已成功保存。", "已更改", MessageBoxButtons.OK); 
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
        }
    }
}
