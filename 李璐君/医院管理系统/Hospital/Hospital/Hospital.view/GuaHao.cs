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
    public partial class frmGuaHao : Form
    {
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        public frmGuaHao()
        {
            InitializeComponent();
        }
        //关闭
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGuaHao_Load(object sender, EventArgs e)
        {
            btnTuiHao.Enabled = false;
            btnGaiHao.Enabled = false;
            txtGuaHaoYuan.Text = UsersEntity.un;
            AddShuJu();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        private void AddShuJu()
        {
            try
            {
                //给医师下拉框加载数据
                DoctorBL dbl = new DoctorBL();
                ds = dbl.SelectData();
                for (int i=0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cbYiShi.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                }
                //给科室信息加载数据
                KeShiBL kbl = new KeShiBL();
                
                ds1 = kbl.SelectData();
                ds1.Tables[0].Columns[0].ColumnName = "科室名称";
                ds1.Tables[0].Columns[1].ColumnName = "科室负责人";
                ds1.Tables[0].Columns[2].ColumnName = "挂号费";
                dgdKeShi.DataSource = ds1.Tables[0];
                //给挂诊科目加载信息
                GuaHaoItemBL gbl = new GuaHaoItemBL();
                
                ds2 = gbl.SelectData();
                ds2.Tables[0].Columns[0].ColumnName = "编号";
                ds2.Tables[0].Columns[1].ColumnName = "科目";
                ds2.Tables[0].Columns[2].ColumnName = "诊断费";
                dgdXiangMu.DataSource = ds2.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //挂诊科室选项发生改变时发生事件
        private void dgdKeShi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtGuaZhenKeShi.Text = ds1.Tables[0].Rows[dgdKeShi.CurrentRow.Index][0].ToString();
                txtGuaHaoFei.Text = ds1.Tables[0].Rows[dgdKeShi.CurrentRow.Index][2].ToString();
            }
            catch
            { }
        }
        //挂诊项目选项发生改变时发生事件
        private void dgdXiangMu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtGuaZhenXiangMu.Text = ds2.Tables[0].Rows[dgdXiangMu.CurrentRow.Index][1].ToString();
                txtZhenDuanFei.Text = ds2.Tables[0].Rows[dgdXiangMu.CurrentRow.Index][2].ToString();
            }
            catch
            { }
        }
        /// <summary>
        /// 挂号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuaHao_Click(object sender, EventArgs e)
        {
            check();
            
            try
            {
                GuaHaoEntity entity = new GuaHaoEntity();
                entity.Type1 = cbJiuZhenLeiXing.Text;
                entity.Mode1 = cbFuFeiFangShi.Text;
                entity.Name1 = txtName.Text;
                entity.Sex1 = cbSex.Text;
                entity.Age1 = Convert.ToInt32(txtAge.Text);
                entity.Folk1 = cbMinZu.Text;
                entity.Phone1 = txtPhone.Text;
                entity.Address1 = txtAddress.Text;
                entity.DoctorName1 = cbYiShi.Text;
                entity.Office1 = txtGuaZhenKeShi.Text;
                entity.Item1 = txtGuaZhenXiangMu.Text;
                entity.GuaHaoMoney1 = Convert.ToDecimal(txtGuaHaoFei.Text);
                entity.ZhenDuanMoney1 = Convert.ToDecimal(txtZhenDuanFei.Text);
                entity.UserName1 = txtGuaHaoYuan.Text;
                entity.Bool1 = 1;
                GuaHaoBL gbl = new GuaHaoBL();
                gbl.InsertData(entity);
                MessageBox.Show("挂号成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbJiuZhenLeiXing.Text = "";
                cbFuFeiFangShi.Text = "";
                txtName.Text = "";
                cbSex.Text = "";
                txtAge.Text = "";
                cbMinZu.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                cbYiShi.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void check()
        {
            CheckInfo ch = new CheckInfo();
            if (ch.checkNull(txtName.Text) != "" || ch.checkNull(txtAge.Text) != "" || ch.checkNull(txtPhone.Text) != ""|| ch.checkNull(txtAddress.Text) != "")
                
            {
                MessageBox.Show("您输入的信息不完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(txtName.Text) != "" || ch.checkLength(txtAge.Text) != "" || ch.checkLength(txtPhone.Text) != "" || ch.checkLength(txtAddress.Text) != "")
            {
                MessageBox.Show("您输入的信息长度有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ch.checkT(txtName.Text) != "" || ch.checkT(txtAge.Text) != "" || ch.checkT(txtPhone.Text) != "" || ch.checkT(txtAddress.Text) != "")
            {
                MessageBox.Show("对不起，你输入的信息中含有特殊字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }
        /// <summary>
        /// 查询挂号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                GuaHaoBL gbl = new GuaHaoBL();
                ds3 = gbl.SelectData(Convert.ToInt32(txtMenZhenHao.Text));
                if (ds3.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("对不起，您已经退过号了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    cbJiuZhenLeiXing.Text = ds3.Tables[0].Rows[0][1].ToString();
                    cbFuFeiFangShi.Text = ds3.Tables[0].Rows[0][2].ToString();
                    txtName.Text = ds3.Tables[0].Rows[0][3].ToString();
                    cbSex.Text = ds3.Tables[0].Rows[0][4].ToString();
                    txtAge.Text = ds3.Tables[0].Rows[0][5].ToString();
                    cbMinZu.Text = ds3.Tables[0].Rows[0][6].ToString();
                    txtPhone.Text = ds3.Tables[0].Rows[0][7].ToString();
                    txtAddress.Text = ds3.Tables[0].Rows[0][8].ToString();
                    cbYiShi.Text = ds3.Tables[0].Rows[0][9].ToString();
                    txtGuaZhenKeShi.Text = ds3.Tables[0].Rows[0][10].ToString();
                    txtGuaZhenXiangMu.Text = ds3.Tables[0].Rows[0][11].ToString();
                    txtGuaHaoFei.Text = ds3.Tables[0].Rows[0][12].ToString();
                    txtZhenDuanFei.Text = ds3.Tables[0].Rows[0][13].ToString();
                    txtGuaHaoYuan.Text = ds3.Tables[0].Rows[0][14].ToString();
                    btnGaiHao.Enabled = true;
                    btnTuiHao.Enabled = true;
                    btnGuaHao.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 改号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGaiHao_Click(object sender, EventArgs e)
        {
            check();
            
            try
            {
                GuaHaoEntity entity = new GuaHaoEntity();
                entity.Id1 = Convert.ToInt32(txtMenZhenHao.Text.Trim());
                entity.Type1 = cbJiuZhenLeiXing.Text;
                entity.Mode1 = cbFuFeiFangShi.Text;
                entity.Name1 = txtName.Text;
                entity.Sex1 = cbSex.Text;
                entity.Age1 = Convert.ToInt32(txtAge.Text);
                entity.Folk1 = cbMinZu.Text;
                entity.Phone1 = txtPhone.Text;
                entity.Address1 = txtAddress.Text;
                entity.DoctorName1 = cbYiShi.Text;
                entity.Office1 = txtGuaZhenKeShi.Text;
                entity.Item1 = txtGuaZhenXiangMu.Text;
                entity.GuaHaoMoney1 = Convert.ToDecimal(txtGuaHaoFei.Text);
                entity.ZhenDuanMoney1 = Convert.ToDecimal(txtZhenDuanFei.Text);
                entity.UserName1 = txtGuaHaoYuan.Text;
                entity.Bool1 = 1;
                GuaHaoBL gbl = new GuaHaoBL();
                gbl.UpdateData(entity);
                MessageBox.Show("改号成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuaHao.Enabled = true;
                cbJiuZhenLeiXing.Text = "";
                cbFuFeiFangShi.Text = "";
                txtName.Text = "";
                cbSex.Text = "";
                txtAge.Text = "";
                cbMinZu.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                cbYiShi.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 退号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTuiHao_Click(object sender, EventArgs e)
        {
            GuaHaoEntity entity = new GuaHaoEntity();
            entity.Id1 = Convert.ToInt32(txtMenZhenHao.Text.Trim());
            entity.Type1 = cbJiuZhenLeiXing.Text;
            entity.Mode1 = cbFuFeiFangShi.Text;
            entity.Name1 = txtName.Text;
            entity.Sex1 = cbSex.Text;
            entity.Age1 = Convert.ToInt32(txtAge.Text);
            entity.Folk1 = cbMinZu.Text;
            entity.Phone1 = txtPhone.Text;
            entity.Address1 = txtAddress.Text;
            entity.DoctorName1 = cbYiShi.Text;
            entity.Office1 = txtGuaZhenKeShi.Text;
            entity.Item1 = txtGuaZhenXiangMu.Text;
            entity.GuaHaoMoney1 = Convert.ToDecimal(txtGuaHaoFei.Text);
            entity.ZhenDuanMoney1 = Convert.ToDecimal(txtZhenDuanFei.Text);
            entity.UserName1 = txtGuaHaoYuan.Text;
            entity.Bool1 =0;
            try
            {
                GuaHaoBL gbl = new GuaHaoBL();
                gbl.UpdateData(entity);
                MessageBox.Show("退号成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuaHao.Enabled = true;
                cbJiuZhenLeiXing.Text = "";
                cbFuFeiFangShi.Text = "";
                txtName.Text = "";
                cbSex.Text = "";
                txtAge.Text = "";
                cbMinZu.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                cbYiShi.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}