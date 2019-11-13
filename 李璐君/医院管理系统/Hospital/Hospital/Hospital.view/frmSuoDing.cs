using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Hospital.entity;

namespace Hospital.Hospital.view
{
    public partial class frmSuoDing : Form
    {
        public frmSuoDing()
        {
            InitializeComponent();
        }

        private void frmSuoDing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.F4)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(txtPwd.Text=="")
                {
                    MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPwd.Text == UsersEntity.pass)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("对不起，您输入的密码错误，请查证后再试，谢谢合作！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtPwd.Text = "";
                }

            }
        }
    }
}