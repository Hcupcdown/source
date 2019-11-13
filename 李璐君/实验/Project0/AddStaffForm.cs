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
    
    public partial class AddStaffForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void close2Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != password2TextBox.Text)
            {
                MessageBox.Show("无法匹配密码。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userNameTextBox.Text == "" || passwordTextBox.Text == "" || emailTextBox.Text == "")
            {
                MessageBox.Show("必须在字段中输入数据。", "空白字段", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || surnameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("你必须在字段中输入数据。", "空白字段", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Staffs myStaff = new Staffs(); 
                Users myUser = new Users(); 
                myUser.User_name = userNameTextBox.Text; 
                myUser.Password = passwordTextBox.Text; 
                myUser.Job = "Staff"; 
                myUser.E_mail = emailTextBox.Text;
                database.Users.InsertOnSubmit(myUser);
                database.SubmitChanges(); 
                int addedUserID = (from user in database.Users
                                   where userNameTextBox.Text == user.User_name 
                                   select (user.User_id)).First(); 
                myStaff.Name = nameTextBox.Text; 
                myStaff.Surname = surnameTextBox.Text;
                myStaff.Address = addressTextBox.Text; 
                myStaff.Phone = phoneTextBox.Text; 
                myStaff.User_id = addedUserID;
                database.Staffs.InsertOnSubmit(myStaff); 
                database.SubmitChanges(); 
                DialogResult dialogResult = MessageBox.Show("已成功添加新行政人员..\n 你想再添加一个行政 人员吗?", "添加完成", 
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Utilizations.ResetControls(tabControl);
                else this.Close();
            }
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                if (passwordTextBox.Text != password2TextBox.Text)
                {
                    tabControl.SelectedIndex = 0;
                    MessageBox.Show("无法匹配密码。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (userNameTextBox.Text == "" || passwordTextBox.Text == "" || emailTextBox.Text == "") 
                { tabControl.SelectedIndex = 0; MessageBox.Show("你必须在字段中输入数据。", "空白字段", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }



    }
}
