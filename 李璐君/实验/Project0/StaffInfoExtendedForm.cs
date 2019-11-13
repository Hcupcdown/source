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
    public partial class StaffInfoExtendedForm : Form
    {
        private int value;

        public StaffInfoExtendedForm()
        {
            InitializeComponent();
        }

        public StaffInfoExtendedForm(int value)
        {
            this.value = value;
        }

        private void StaffInfoExtendedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
