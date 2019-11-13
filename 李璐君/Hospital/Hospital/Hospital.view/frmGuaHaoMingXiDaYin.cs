using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Hospital.view;
using Hospital.Hospital.bl;

namespace Hospital.Hospital.view
{
    public partial class frmGuaHaoMingXiDaYin : Form
    {
        public frmGuaHaoMingXiDaYin()
        {
            InitializeComponent();
        }
        public void DaYin()
        {
            GuaHaoBL bl = new GuaHaoBL();
            DataSet ds = bl.SelectData(1);
            crGuaHaoMingXi cr= new crGuaHaoMingXi();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}