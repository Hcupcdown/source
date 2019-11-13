using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Hospital.bl;
using Hospital.Hospital.entity;
using Hospital.Hospital.view;

namespace Hospital.Hospital.view
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
            CheckInfo ch = new CheckInfo();
            if (ch.checkNull(txtUserName.Text) != "" || ch.checkNull(txtName.Text) != "" || ch.checkNull(txtPwd.Text) != "")
            {
                MessageBox.Show("您输入的信息不完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(txtUserName.Text) != "" || ch.checkLength(txtName.Text) != "" || ch.checkLength(txtPwd.Text) != "")
            {
                MessageBox.Show("您输入的信息长度有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ch.checkT(txtUserName.Text) != "" || ch.checkT(txtName.Text) != "" || ch.checkT(txtPwd.Text) != "")
            {
                MessageBox.Show("对不起，你输入的信息中含有特殊字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            try
            {
                UsersEntity entity = new UsersEntity();
                entity.UUserName = txtUserName.Text;
                entity.UName = txtName.Text;
                entity.UPwd = txtPwd.Text;
                entity.UbuMen = cbBuMen.Text;
                entity.UquanXian = cbQuanXian.SelectedIndex;
                UsersBL bl = new UsersBL();
                bl.InsertUsers(entity);
                MessageBox.Show("添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Clear();
                txtName.Clear();
                txtPwd.Clear();
                cbBuMen.Text = "";
                cbQuanXian.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}