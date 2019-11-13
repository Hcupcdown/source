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
    public partial class UpdatePatientForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private void refreshPatients() { 
            patientBindingSource.DataSource = 
                from patient in database.Patients
                orderby patient.Patient_id 
                select patient; 
            patientBindingSource.MoveFirst(); 
            ssnTextBox.Clear(); 
        }
        public UpdatePatientForm()
        {
            InitializeComponent();
        }

        private void UpdatePatientForm_Load(object sender, EventArgs e)
        {
            refreshPatients();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            patientBindingSource.DataSource = from patient in database.Patients
                                              where patient.Ssn == ssnTextBox.Text select patient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshPatients();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); 
            patientBindingSource.EndEdit();
            database.SubmitChanges(); 
            refreshPatients();
        }

        private void sexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
