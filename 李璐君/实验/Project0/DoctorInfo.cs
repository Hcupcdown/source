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
    public partial class DoctorInfo : Form
    {
        private HospitalDataContext database = new HospitalDataContext();
       
   

        public DoctorInfo()
        {
            InitializeComponent();
        }

        private void DoctorInfo_Load(object sender, EventArgs e)
        {
            doctorBindingSource.DataSource = from doctor in database.Doctors 
                                             orderby doctor.Doctor_name, doctor.Doctor_surname 
                                             select doctor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedDoctorID = (int)doctorDataGridView[0, doctorDataGridView.CurrentRow.Index].Value; 
            DoctorInfoExtendedForm dief = new DoctorInfoExtendedForm(selectedDoctorID); dief.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DoctorInfo_Load(sender, e);
        }
    }
}
