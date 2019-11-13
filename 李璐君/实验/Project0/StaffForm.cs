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
    public partial class StaffForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private string username;
        public StaffForm(string username) { InitializeComponent(); this.username = username; }

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; 
            timer1.Start(); 
            var staff = from user in database.Users
                        from stf in user.Staffs
                        where user.User_name == username 
                        select stf; helloLabel.Text = "欢迎, " + staff.First().Name + " " + staff.First().Surname;
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

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm apf = new AddPatientForm(); 
            apf.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdatePatientForm upf = new UpdatePatientForm(); upf.ShowDialog();
        }

        private void changeUserSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings suf = new UserSettings(username); 
            suf.ShowDialog();
        }

        private void personalInfoSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            octorPersonalInfoForm spif = new octorPersonalInfoForm(username); 
            spif.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm logf = new LoginForm();
            logf.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       // private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        //{
          //  MessageBox.Show("本系统设计为医院管理系统。", "关于应用", MessageBoxButtons.OK, MessageBoxIcon.Information);
       // }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { 
          MessageBox.Show("本系统设计为医院管理系统。", "关于应用", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
