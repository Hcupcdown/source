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
    public partial class DoctorForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private string username;
        private void allPatients()
        {
            var patient = from user in database.Users
                          from doc in user.Doctors
                          from pad in doc.Patient_Admissions
                          let pat = pad.Patients
                          where user.User_name == username
                          orderby pad.Date_in, pat.Name, pat.Surname
                          select new
                          { 
                              AdmissionID = pad.Patient_ad_id, Name = pat.Name, Surname = pat.Surname, Date = pad.Date_in
                          }; 
            dataGridView1.DataSource = patient; label2.Text = "所有患者";
        }
        private void todaysPatients() 
        { 
            var patient = from user in database.Users
                          from doc in user.Doctors
                          from pad in doc.Patient_Admissions
                         let pat = pad.Patients 
                          where user.User_name == username && pad.Date_in.Equals(DateTime.Today) orderby pad.Date_in, pat.Name, pat.Surname 
                          select new 
                          { 
                              AdmissionID = pad.Patient_ad_id,
                              Name = pat.Name, 
                              Surname = pat.Surname, Date = pad.Date_in
                          };
            dataGridView1.DataSource = patient;
            label2.Text = "今天的患者";
        }
        public DoctorForm(string username) 
        { 
            InitializeComponent();
            this.username = username;
        }


        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start(); 
            allPatients();
           
            var doc = from doctor in database.Doctors
                      where doctor.Users.User_name == username 
                      select doctor; 
            helloLabel.Text = "你好, Dr. " + doc.First().Doctor_name + " " + doc.First().Doctor_surname;
          
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString(); 
            hourLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void inspectButton_Click(object sender, EventArgs e)
        {
            int selectedPatient = (int)dataGridView1[0, 
                dataGridView1.CurrentRow.Index].Value; 
            InspectPatientForm ipf = new InspectPatientForm(selectedPatient); 
            ipf.ShowDialog();
        }

        private void 所有患者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allPatients();
        }

        private void 今日患者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todaysPatients();
        }

        private void 更改用户设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings susf = new UserSettings(username);
            susf.ShowDialog();
        }

        private void 我的个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorPersonalInfoForm dpif = new DoctorPersonalInfoForm(username);
            dpif.ShowDialog();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); LoginForm logf = new LoginForm(); logf.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本程序设计为医院管理系统。", "关于应用程序", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
