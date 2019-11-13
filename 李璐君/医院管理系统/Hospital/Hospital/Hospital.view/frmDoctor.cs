using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Hospital.bl;
using Hospital.Hospital.entity;

namespace Hospital.Hospital.view
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
            CheckInfo ch = new CheckInfo();
            if (ch.checkNull(txtName.Text) != "" || ch.checkNull(txtAge.Text) != "")
            {
                MessageBox.Show("您输入的信息不完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(txtName.Text) != "" || ch.checkLength(txtAge.Text) != "")
            {
                MessageBox.Show("您输入的信息长度有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ch.checkT(txtName.Text) != "" || ch.checkT(txtAge.Text) != "")
            {
                MessageBox.Show("对不起，你输入的信息中含有特殊字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            try
            {
                DoctorEntity entity = new DoctorEntity();
                entity.Name1 = txtName.Text;
                entity.Sex1 = cbSex.Text;
                entity.Age1 = Convert.ToInt32(txtAge.Text);
                entity.XueLi1 = cbXueLi.Text;
                entity.ZhiCheng1 = cbZhiCheng.Text;
                entity.KeShi1 = cbKeShi.Text;
                DoctorBL bl = new DoctorBL();
                bl.InsertData(entity);
                MessageBox.Show("添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                cbSex.Text = "";
                txtAge.Clear();
                cbXueLi.Text = "";
                cbZhiCheng.Text = "";
                cbKeShi.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}