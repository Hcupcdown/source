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
    public partial class frmAddKeShi : Form
    {
        public frmAddKeShi()
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
            if (ch.checkNull(txtName.Text) != "" || ch.checkNull(txtFuZeRen.Text) != "" || ch.checkNull(txtGuaHaoFei.Text) != "")
            {
                MessageBox.Show("您输入的信息不完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(txtName.Text) != "" || ch.checkLength(txtFuZeRen.Text) != "" || ch.checkLength(txtGuaHaoFei.Text) != "")
            {
                MessageBox.Show("您输入的信息长度有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ch.checkT(txtName.Text) != "" || ch.checkT(txtFuZeRen.Text) != "" || ch.checkT(txtGuaHaoFei.Text) != "")
            {
                MessageBox.Show("对不起，你输入的信息中含有特殊字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                KeShiBL bl = new KeShiBL();
                KeShiEntity entity = new KeShiEntity();
                entity.OfficeName1 = txtName.Text;
                entity.OfficePeople1 = txtFuZeRen.Text;
                entity.Money1 = Convert.ToDecimal(txtGuaHaoFei.Text);
                bl.InsertData(entity);
                MessageBox.Show("添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtFuZeRen.Clear();
                txtGuaHaoFei.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}