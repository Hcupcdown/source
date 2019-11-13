using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Hospital.entity;
using Hospital.Hospital.bl;

namespace Hospital.Hospital.view
{
    public partial class UpdatePwd : Form
    {
        public UpdatePwd()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (checkPass())
            {
                return;
            }
            try
            {
                UsersBL bl = new UsersBL();
                bl.UpdateUsers(UsersEntity.un, txtNewPwd.Text);
                MessageBox.Show("密码修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void check()
        {
            CheckInfo ch = new CheckInfo();
            if (ch.checkNull(txtOldPwd.Text) != "" || ch.checkNull(txtNewPwd.Text) != "" || ch.checkNull(txtNewPwd1.Text) != "")
            {
                MessageBox.Show("您输入的信息不完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(txtOldPwd.Text) != "" || ch.checkLength(txtNewPwd.Text) != "" || ch.checkLength(txtNewPwd1.Text) != "")
            {
                MessageBox.Show("您输入的信息长度有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ch.checkT(txtOldPwd.Text) != "" || ch.checkT(txtNewPwd.Text) != "" || ch.checkT(txtNewPwd1.Text) != "")
            {
                MessageBox.Show("对不起，你输入的信息中含有特殊字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private bool checkPass()
        {
            check();
            if (txtOldPwd.Text != UsersEntity.pass)
            {
                MessageBox.Show("旧密码错误，请重新输入！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPwd.Clear();
                txtNewPwd.Clear();
                txtNewPwd1.Clear();
                txtOldPwd.Focus();
                return true;
            }
            else if (txtNewPwd.Text != txtNewPwd1.Text)
            {
                MessageBox.Show("两次密码不一致，请重新输入！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPwd.Clear();
                txtNewPwd.Clear();
                txtNewPwd1.Clear();
                txtOldPwd.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}