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
        /// �������ʱ��ʾ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenZhenKeShi_Load(object sender, EventArgs e)
        {
            try
            {
                KeShiBL bl = new KeShiBL();
                ds = bl.SelectData();
                ds.Tables[0].Columns[0].ColumnName = "��������";
                ds.Tables[0].Columns[1].ColumnName = "������";
                ds.Tables[0].Columns[2].ColumnName = "�Һŷ�";
                dgdInfo.DataSource = ds.Tables[0];
                this.gbKeShi.Text = "��ǰ��"+ds.Tables[0].Rows.Count+"�����Ҽ�¼";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// ��datagrideviewѡ����仯ʱ���������Ϣ����ֵ
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
                if (DialogResult.Yes == MessageBox.Show("��ȷ��Ҫɾ����", "ȷ��",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bl.DeleteData(name);
                    MessageBox.Show("ɾ���ɹ���", "�ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("���������Ϣ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(txtName.Text) != "" || ch.checkLength(txtFuZeRen.Text) != "" || ch.checkLength(txtGuaHaoFei.Text) != "")
            {
                MessageBox.Show("���������Ϣ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ch.checkT(txtName.Text) != "" || ch.checkT(txtFuZeRen.Text) != "" || ch.checkT(txtGuaHaoFei.Text) != "")
            {
                MessageBox.Show("�Բ������������Ϣ�к��������ַ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("�޸ĳɹ���", "�ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("�Բ�����û��װ��ӡ�����޷���ӡ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 
    }
}