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
    public partial class AddPatientForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private bool isExist;

        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {

            deptComboBox.DataSource = from dept in database.Departments
                                      select dept.Dept_name;
            doctorComboBox.DataSource = from dept in database.Departments
                                        from doc in dept.Doctors
                                        //where dept.Dept_name == deptComboBox.Text
                                        select (string)doc.Doctor_name + " " + doc.Doctor_surname;

            /*注释掉的这个就是男女男女的罪魁祸首
            sexComboBox.Items.Add("女"); sexComboBox.Items.Add("男");*/
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var patient = from p in database.Patients
                          where ssnTextBox.Text == p.Ssn
                          select p;
            if (patient.Count() > 0)
            {
                messageLabel.Text = "有该患者的病历记录，请输入患者的其他入院信息。";
                patientBindingSource.DataSource = patient;
                isExist = true;
            }
            else
            {
                messageLabel.Text = "没有该患者的病历记录，请输入患者的入院信息。";
                isExist = false;
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ssnTextBox.Text == "" || nameTextBox.Text == "" || surnameTextBox.Text == "" || birth_placeTextBox.Text == ""
                || father_nameTextBox.Text == "" || phoneTextBox.Text == "" || doctorComboBox.Text == "")
            {
                MessageBox.Show("你必须在字段中输入数据.", "空白字段", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isExist == false)
                {
                    Patients patient = new Patients();
                    patient.Ssn = ssnTextBox1.Text;
                    patient.Name = nameTextBox.Text;
                    patient.Surname = surnameTextBox.Text;
                    patient.Father_name = father_nameTextBox.Text;
                    patient.Birth_place = birth_placeTextBox.Text;
                    patient.Birth_date = birth_dateDateTimePicker.Value;
                    patient.Sex = sexComboBox.Text; patient.Phone = phoneTextBox.Text;
                    patient.Address = addressTextBox.Text; database.Patients.InsertOnSubmit(patient);
                    database.SubmitChanges();
                }
                Patient_Admissions patientAdm = new Patient_Admissions();
                patientAdm.Patient_id = (from p in database.Patients where p.Ssn == ssnTextBox1.Text select p).First().Patient_id;
                patientAdm.Dept_id = (from dep in database.Departments
                                      where dep.Dept_name == deptComboBox.Text
                                      select dep).First().Dept_id; patientAdm.Doctor_id = (from doc in database.Doctors
                                                                                           where (doc.Doctor_name + " " + doc.Doctor_surname) == doctorComboBox.Text
                                                                                           select doc).First().Doctor_id; 
                patientAdm.Date_in = inspectionDateTimePicker.Value;
                database.Patient_Admissions.InsertOnSubmit(patientAdm); 
                database.SubmitChanges(); 
                DialogResult dialogResult = MessageBox.Show
                    ("已成功添加新患者..\n 是否要添加其他患者？", "添加完成", MessageBoxButtons.YesNo); 
                if (dialogResult == DialogResult.No)
                    this.Close();
            }
        }

        private void exiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doctors = from dept in database.Departments
                          from doc in dept.Doctors
                          where dept.Dept_name == deptComboBox.Text
                          select (string)doc.Doctor_name + " " + doc.Doctor_surname;
            if (doctors.Count() > 0) 
                doctorComboBox.DataSource = doctors;
            else doctorComboBox.ResetText();
        }

        private void patientAdmissionsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
 }
