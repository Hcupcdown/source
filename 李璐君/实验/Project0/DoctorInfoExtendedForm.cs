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
    public partial class DoctorInfoExtendedForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();

        public int doctorID { get; private set; }

        public DoctorInfoExtendedForm(int doctorID) { InitializeComponent(); 
            this.doctorID = doctorID; }

        public DoctorInfoExtendedForm()
        {
            InitializeComponent();
        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void DoctorInfoExtendedForm_Load(object sender, EventArgs e)
        {
            var doc = from user in database.Users from doctor in user.Doctors where doctor.Doctor_id == doctorID select doctor;
            doctorsBindingSourc.DataSource = doc; 
            deptComboBox.DataSource = from dept in database.Departments select dept.Dept_name; 
            deptComboBox.Text = ""; 
            deptComboBox.SelectedText = doc.First().Departments.Dept_name;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try { Users deletedUser = (from user in database.Users
                                       from doc in user.Doctors 
                                       where doc.Doctor_id == doctorID 
                                       select user).First(); database.Users.DeleteOnSubmit(deletedUser); 
                database.SubmitChanges(); } 
            catch (System.Exception exp) { exp.ToString(); }
        }

        private void colseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
