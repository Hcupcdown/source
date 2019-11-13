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
    public partial class octorPersonalInfoForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private string username;
        private void loadData()
        { 
            staffBindingSource.DataSource = from user in database.Users
                                            from staff in user.Staffs
                                            where user.User_name == username 
                                            select staff;
        }
        public octorPersonalInfoForm(string username) { InitializeComponent(); this.username = username;
        }
       
        

        public octorPersonalInfoForm()
        {
            InitializeComponent();
        }

        private void octorPersonalInfoForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || surnameTextBox.Text == "" || phoneTextBox.Text == "" || addressTextBox.Text == "") 
                MessageBox.Show("你必须在字段中输入数据。", "空白字段", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
            { 
                Validate(); 
                staffBindingSource.EndEdit(); 
                database.SubmitChanges(); 
                MessageBox.Show("你的更改已成功保存。", "已更改", MessageBoxButtons.OK); 
            }
        }
    }
}
