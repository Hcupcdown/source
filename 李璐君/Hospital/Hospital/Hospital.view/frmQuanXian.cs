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
    public partial class frmQuanXian : Form
    {
        DataSet ds = new DataSet();
        public frmQuanXian()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string name=ds.Tables[0].Rows[dgdUserInfo.CurrentRow.Index][0].ToString();
                UsersBL bl = new UsersBL();
                if (DialogResult.Yes == MessageBox.Show("您确定要删除？", "确认",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bl.DeleteUsers(name);
                    MessageBox.Show("删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AddShuJu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShuaXin_Click(object sender, EventArgs e)
        {
            AddShuJu();
        }
        //加载数据
        private void AddShuJu()
        {
            UsersBL bl = new UsersBL();
            ds=bl.SelectData("", "");
            ds.Tables[0].Columns[0].ColumnName = "用户名";
            ds.Tables[0].Columns[1].ColumnName = "密码";
            ds.Tables[0].Columns[2].ColumnName = "姓名";
            ds.Tables[0].Columns[3].ColumnName = "部门";
            ds.Tables[0].Columns[4].ColumnName = "权限";
            groupBox1.Text = "当前有" + ds.Tables[0].Rows.Count+ "条用户信息";
            dgdUserInfo.DataSource = ds.Tables[0];
        }

        private void frmQuanXian_Load(object sender, EventArgs e)
        {
            AddShuJu();
        }

        private void dgdUserInfo_SelectionChanged(object sender, EventArgs e)
        {
            tvQuanXian.Nodes[0].Checked = false;
            tvQuanXian.Nodes[1].Checked = false;

            try
            {
                txtUserName.Text = ds.Tables[0].Rows[dgdUserInfo.CurrentRow.Index][0].ToString();
                txtPwd.Text = ds.Tables[0].Rows[dgdUserInfo.CurrentRow.Index][1].ToString();
                txtName.Text = ds.Tables[0].Rows[dgdUserInfo.CurrentRow.Index][2].ToString();
                cbBuMen.Text = ds.Tables[0].Rows[dgdUserInfo.CurrentRow.Index][3].ToString();
                if (ds.Tables[0].Rows[dgdUserInfo.CurrentRow.Index][4].ToString() == "False")
                {
                    tvQuanXian.Nodes[0].Checked = true;
                    tvQuanXian.Nodes[1].Checked = true;
                }
                else
                {
                    tvQuanXian.Nodes[1].Checked = true;
                }
                
            }
            catch
            { }
        }
        //修改
        private void btnUpdate_Click(object sender, EventArgs e)
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
                if (tvQuanXian.Nodes[0].Checked && tvQuanXian.Nodes[1].Checked)
                {
                    entity.UquanXian = 0;
                }
                else if (tvQuanXian.Nodes[0].Checked)
                {
                    entity.UquanXian = 0;
                }
                else
                {
                    entity.UquanXian = 1;
                }
                UsersBL bl = new UsersBL();
                bl.UpdateUsers(entity);
                AddShuJu();
                MessageBox.Show("修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
            AddShuJu();
        }

        private void btnDaYin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("对不起，您没有装打印机，无法打印！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}