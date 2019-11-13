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
    public partial class frmGuaHaoMingXiBiao : Form
    {
        DataSet ds = new DataSet();
        public frmGuaHaoMingXiBiao()
        {
            InitializeComponent();
        }

        private void frmGuaHaoMingXiBiao_Load(object sender, EventArgs e)
        {
            AddShuJu();
        }
        //加载数据
        private void AddShuJu()
        {
            try
            {
                GuaHaoBL bl = new GuaHaoBL();
                ds = bl.SelectData(1);
                ds.Tables[0].Columns[0].ColumnName = "编号";
                ds.Tables[0].Columns[1].ColumnName = "就诊类型";
                ds.Tables[0].Columns[2].ColumnName = "付费方式";
                ds.Tables[0].Columns[3].ColumnName = "姓名";
                ds.Tables[0].Columns[4].ColumnName = "性别";
                ds.Tables[0].Columns[5].ColumnName = "年龄";
                ds.Tables[0].Columns[6].ColumnName = "民族";
                ds.Tables[0].Columns[7].ColumnName = "联系电话";
                ds.Tables[0].Columns[8].ColumnName = "联系地址";
                ds.Tables[0].Columns[9].ColumnName = "医师姓名";
                ds.Tables[0].Columns[10].ColumnName = "挂诊科室";
                ds.Tables[0].Columns[11].ColumnName = "挂诊项目";
                ds.Tables[0].Columns[12].ColumnName = "挂号费";
                ds.Tables[0].Columns[13].ColumnName = "诊断费";
                ds.Tables[0].Columns[14].ColumnName = "挂号员";
                ds.Tables[0].Columns[15].ColumnName = "挂号信息";
                dgdGuaHaoMingXi.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //刷新
        private void btnShuaXin_Click(object sender, EventArgs e)
        {
            AddShuJu();
        }
        //关闭
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgdGuaHaoMingXi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtGuaHaoFei.Text = ds.Tables[0].Rows[dgdGuaHaoMingXi.CurrentRow.Index][12].ToString();
                txtZhenDuanFei.Text = ds.Tables[0].Rows[dgdGuaHaoMingXi.CurrentRow.Index][13].ToString();
                txtHeJi.Text = Convert.ToString(Convert.ToDecimal(txtGuaHaoFei.Text) + Convert.ToDecimal(txtZhenDuanFei.Text));
            }
            catch
            { }
        }

        private void btnDaYin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("对不起，您没有装打印机，无法打印！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}