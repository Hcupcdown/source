using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Hospital.view;
using Hospital.Hospital.dal;
using Hospital.Hospital.entity;
using Hospital.Hospital.bl;
using Microsoft.Win32;


namespace Hospital.Hospital.view
{
    public partial class frmLogin : Form
    {
        private DataSet ds = new DataSet();
        public frmLogin()
        {
            InitializeComponent();
            skinEngine1.SkinFile = Application.StartupPath + "\\MacOS.ssk";
           
        }
        /// <summary>
        /// 单击左下角信息时弹出网页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.31mj.cn");
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.checkPwd();
        }
        private void checkPwd()
        {
            string userName = txtUserName.Text;
            string pwd = txtUserPwd.Text;
            CheckInfo ch = new CheckInfo();
            if(ch.checkNull(userName)!=""||(ch.checkNull(pwd)!=""))
            {
                MessageBox.Show("您输入的信息不完整！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(userName) != "" || (ch.checkLength(pwd) != ""))
            {
                MessageBox.Show("您输入的信息长度有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(ch.checkT(userName)!=""||ch.checkT(pwd)!="")
            {
                MessageBox.Show("对不起，你输入的信息中含有特殊字符！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            UsersEntity.un = userName;
            UsersEntity.pass = pwd;
            try
            {
                UsersBL ubl = new UsersBL();
                ds = ubl.SelectData(userName, pwd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                LogBL bl = new LogBL();
                LogEntity entity = new LogEntity();
                entity.UserName1 = userName;
                entity.LoginTime1 = DateTime.Now;
                entity.Message1 = "登陆本系统";
                bl.InsertData(entity);
            }
            else
            {
                MessageBox.Show("您输入的帐号密码有误，请重新输入！",
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
        }
    }
}