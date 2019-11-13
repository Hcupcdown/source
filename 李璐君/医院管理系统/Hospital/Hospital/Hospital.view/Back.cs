using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Hospital.bl;

namespace Hospital.Hospital.view
{
    public partial class Back : Form
    {
        private string path;
        public Back()
        {
            
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BackDB.BackupDB("localhost", "sa", "", "Hospital", path,txtBeiFen.Text);
                MessageBox.Show("数据库备份完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = @"c:";
                sfd.ShowDialog();
                path = sfd.FileName;
                txtBeiFen.Text = path;
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:";
            ofd.ShowDialog();
            path = ofd.FileName;
            txtHuanYuan.Text = path;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            { 
                BackDB.RestoreDB("localhost", "sa", "", "Hospital", path);
                MessageBox.Show("还原数据库完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}