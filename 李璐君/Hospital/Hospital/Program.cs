using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hospital.Hospital.view;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Application.Run(new Main());

            }
            else
            {
                Application.Exit();
            }
        }
    }
}