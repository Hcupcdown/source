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
    public partial class frmLog : Form
    {
        DataSet ds = new DataSet();
        public frmLog()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTiaoJian.SelectedIndex == 0&&cbUserName.Text=="")
                {
                    MessageBox.Show("请选择用户名！","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                LogBL bl = new LogBL();
                string name = cbUserName.Text.Trim();
                ds=bl.SelectData(name);
                ds.Tables[0].Columns[0].ColumnName = "编号";
                ds.Tables[0].Columns[1].ColumnName = "用户名";
                ds.Tables[0].Columns[2].ColumnName = "时间";
                ds.Tables[0].Columns[3].ColumnName = "事件";
                dgdLogInfo.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 当查询条件发生变化时，用户名下拉框是否可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLog_Load(object sender, EventArgs e)
        {
            cbUserName.Enabled = false;
            AddShuJu();
        }

        private void AddShuJu()
        {
            UsersBL bl = new UsersBL();
            ds=bl.SelectData("","");
            for (int i = 0; i<ds.Tables[0].Rows.Count;i++ )
            {
                cbUserName.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cbTiaoJian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTiaoJian.SelectedIndex == 1)
            {
                cbUserName.Text = "";
                cbUserName.Enabled = false;
            }
            else
            {
                cbUserName.Enabled = true;
            }
        }
    }
}