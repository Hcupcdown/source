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
    public partial class frmMenZhenYiShi : Form
    {
        DataSet ds = new DataSet();
        public frmMenZhenYiShi()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenZhenYiShi_Load(object sender, EventArgs e)
        {
            try
            {
                DoctorBL bl = new DoctorBL();
                ds = bl.SelectData();
                ds.Tables[0].Columns[0].ColumnName = "医师编号";
                ds.Tables[0].Columns[1].ColumnName = "姓名";
                ds.Tables[0].Columns[2].ColumnName = "性别";
                ds.Tables[0].Columns[3].ColumnName = "年龄";
                ds.Tables[0].Columns[4].ColumnName = "学历";
                ds.Tables[0].Columns[5].ColumnName = "职称";
                ds.Tables[0].Columns[6].ColumnName = "科室";
                dataGridView1.DataSource = ds.Tables[0];
                this.gbYiShi.Text = "当前有" + ds.Tables[0].Rows.Count + "条医师记录";
                KeShi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 给科室的下拉框加载数据
        /// </summary>
        private void KeShi()
        {
            try
            {
                cbKeShi.Items.Clear();
                DataSet ds1 = new DataSet();
                KeShiBL bl = new KeShiBL();
                ds1=bl.SelectData();
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    cbKeShi.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 当datagrideview选项发生变化时右边的信息同时发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = ds.Tables[0].Rows[dataGridView1.CurrentRow.Index][1].ToString();
                cbSex.Text = ds.Tables[0].Rows[dataGridView1.CurrentRow.Index][2].ToString();
                txtAge.Text = ds.Tables[0].Rows[dataGridView1.CurrentRow.Index][3].ToString();
                cbXueLi.Text = ds.Tables[0].Rows[dataGridView1.CurrentRow.Index][4].ToString();
                cbZhiCheng.Text = ds.Tables[0].Rows[dataGridView1.CurrentRow.Index][5].ToString();
                cbKeShi.Text = ds.Tables[0].Rows[dataGridView1.CurrentRow.Index][6].ToString();
            }
            catch
            { }
        }
        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();
            frm.ShowDialog();
            frmMenZhenYiShi_Load(this,null);
        }
        //刷新
        private void btnShuaXin_Click(object sender, EventArgs e)
        {
            frmMenZhenYiShi_Load(this,null);
        }
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id =Convert.ToInt32( ds.Tables[0].Rows[dataGridView1.CurrentRow.Index][0].ToString());
                DoctorBL bl = new DoctorBL();
                if (DialogResult.Yes == MessageBox.Show("您确定要删除？", "确认",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bl.DeleteData(id);
                    MessageBox.Show("删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmMenZhenYiShi_Load(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //修改
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
            CheckInfo ch = new CheckInfo();
            if (ch.checkNull(txtName.Text) != "" || ch.checkNull(txtAge.Text) != "" || ch.checkNull(cbSex.Text) != "")
            {
                MessageBox.Show("您输入的信息不完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(txtName.Text) != "" || ch.checkLength(txtAge.Text) != "" || ch.checkLength(cbSex.Text) != "")
            {
                MessageBox.Show("您输入的信息长度有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ch.checkT(txtName.Text) != "" || ch.checkT(txtAge.Text) != "" || ch.checkT(cbSex.Text) != "")
            {
                MessageBox.Show("对不起，你输入的信息中含有特殊字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DoctorEntity entity = new DoctorEntity();
                entity.Id1 = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                entity.Name1 = txtName.Text;
                entity.Sex1 = cbSex.Text;
                entity.Age1 = Convert.ToInt32(txtAge.Text);
                entity.XueLi1 = cbXueLi.Text;
                entity.ZhiCheng1 = cbZhiCheng.Text;
                entity.KeShi1 = cbKeShi.Text;
                DoctorBL bl = new DoctorBL();
                bl.UpdateData(entity);
                frmMenZhenYiShi_Load(this, null);
                MessageBox.Show("修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDaYin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("对不起，您没有装打印机，无法打印！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}