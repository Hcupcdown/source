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
    public partial class InspectPatientForm : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
        private int admissionID;
        private void loadData() 
        { patient_AdmissionBindingSource.DataSource = from patient in database.Patient_Admissions
                                                      where patient.Patient_ad_id == admissionID 
                                                      select patient; 
        }
        public InspectPatientForm(int admissionID) 
        { 
            InitializeComponent(); 
            this.admissionID = admissionID; 
        }
        public InspectPatientForm()
        {
            InitializeComponent();
        }

        private void InspectPatientForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Validate();
            patient_AdmissionBindingSource.EndEdit(); 
            database.SubmitChanges();
        }
    }
}
