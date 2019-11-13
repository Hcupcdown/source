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
    public partial class AdminForm : Form
    {

        private string username;
        public AdminForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            hourLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addDoctorButton_Click(object sender, EventArgs e)
        {
            AddDoctorForm adcf = new AddDoctorForm();
            adcf.ShowDialog();
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            AddStaffForm adsf = new AddStaffForm(); 
            adsf.ShowDialog();
        }

        private void 医生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorInfo di = new DoctorInfo(); di.ShowDialog();
        }

        private void 科室信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentInfoForm dif = new DepartmentInfoForm(); dif.ShowDialog();
        }

        private void 行政人员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffInfoForm sif = new StaffInfoForm(); sif.ShowDialog();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminChangePassword acpf = new AdminChangePassword(username); acpf.ShowDialog();
        }

        private void 锁定系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); LoginForm logf = new LoginForm(); logf.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该程序是医院管理信息系统。", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
