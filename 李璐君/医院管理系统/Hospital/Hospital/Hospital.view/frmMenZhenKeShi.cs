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
    public partial class frmMenZhenKeShi : Form
    {
        DataSet ds = new DataSet();
        public frmMenZhenKeShi()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载时显示数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenZhenKeShi_Load(object sender, EventArgs e)
        {
            try
            {
                KeShiBL bl = new KeShiBL();
                ds = bl.SelectData();
                ds.Tables[0].Columns[0].ColumnName = "科室名称";
                ds.Tables[0].Columns[1].ColumnName = "负责人";
                ds.Tables[0].Columns[2].ColumnName = "挂号费";
                dgdInfo.DataSource = ds.Tables[0];
                this.gbKeShi.Text = "当前有"+ds.Tables[0].Rows.Count+"条科室记录";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 当datagrideview选项发生变化时给右面的信息栏传值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgdInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = ds.Tables[0].Rows[dgdInfo.CurrentRow.Index][0].ToString();
                txtFuZeRen.Text = ds.Tables[0].Rows[dgdInfo.CurrentRow.Index][1].ToString();
                txtGuaHaoFei.Text = ds.Tables[0].Rows[dgdInfo.CurrentRow.Index][2].ToString();
            }
            catch
            {}
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ds.Tables[0].Rows[dgdInfo.CurrentRow.Index][0].ToString();
                KeShiBL bl = new KeShiBL();
                if (DialogResult.Yes == MessageBox.Show("您确定要删除？", "确认",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bl.DeleteData(name);
                    MessageBox.Show("删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmMenZhenKeShi_Load(this,null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShuaXin_Click(object sender, EventArgs e)
        {
            frmMenZhenKeShi_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                bl.UpdateData(entity);
                frmMenZhenKeShi_Load(this, null);
                MessageBox.Show("修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddKeShi frm = new frmAddKeShi();
            frm.ShowDialog();
            frmMenZhenKeShi_Load(this, null);

        }

        private void btnDaYin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("对不起，您没有装打印机，无法打印！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 
    }
}