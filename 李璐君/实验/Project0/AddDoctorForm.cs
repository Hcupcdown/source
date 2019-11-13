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
    public partial class AddDoctorForm : Form
    {
        public AddDoctorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private HospitalDataContext database = new HospitalDataContext();
        private void AddDoctorForm_Load(object sender, EventArgs e)
        {
            deptComboBox.DataSource = from dept in database.Departments
                                      orderby dept.Dept_name
                                      select dept.Dept_name;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != password2TextBox.Text)
            {
                MessageBox.Show("无法匹配密码。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userNameTextBox.Text == "" || passwordTextBox.Text == "" || emailTextBox.Text == "")
            {
                MessageBox.Show("你必须在文本框中输入数据。", "空白数据项", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else tabControl.SelectedIndex = 1;
        }

        private void step1TabPage_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || surnameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("你必须在文本框中输入数据。", "空白数据项", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Doctors myDoctor = new Doctors();
                Users myUser = new Users(); myUser.User_name = userNameTextBox.Text;
                myUser.Password = passwordTextBox.Text; myUser.E_mail = emailTextBox.Text; myUser.Job = "Doctor"; database.Users.InsertOnSubmit(myUser);
                database.SubmitChanges();
                int addedUserID = (from user in database.Users where userNameTextBox.Text == user.User_name select (user.User_id)).First();
                int addedDeptID = (from dept in database.Departments where deptComboBox.Text == dept.Dept_name select (dept.Dept_id)).First();
                myDoctor.Doctor_name = nameTextBox.Text; myDoctor.Doctor_surname = surnameTextBox.Text; myDoctor.Dept_id = addedDeptID; myDoctor.User_id = addedUserID;
                myDoctor.Phone = phoneTextBox.Text; myDoctor.Address = addressTextBox.Text; database.Doctors.InsertOnSubmit(myDoctor); database.SubmitChanges();
                DialogResult dialogResult = MessageBox.Show("新医生成功添加..\n 你还想添加另外一个医生 吗?", "添加完成", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) Utilizations.ResetControls(tabControl);
                else this.Close();
            }
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                if (passwordTextBox.Text != password2TextBox.Text)
                {
                    tabControl.SelectedIndex = 0; MessageBox.Show("无法匹配密码。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (userNameTextBox.Text == "" || passwordTextBox.Text == "" || emailTextBox.Text == "")
                {
                    tabControl.SelectedIndex = 0; MessageBox.Show("你必须在文本框中输入数据。", "空白数据项", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}

