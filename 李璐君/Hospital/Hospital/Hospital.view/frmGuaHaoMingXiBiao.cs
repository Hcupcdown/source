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
        //��������
        private void AddShuJu()
        {
            try
            {
                GuaHaoBL bl = new GuaHaoBL();
                ds = bl.SelectData(1);
                ds.Tables[0].Columns[0].ColumnName = "���";
                ds.Tables[0].Columns[1].ColumnName = "��������";
                ds.Tables[0].Columns[2].ColumnName = "���ѷ�ʽ";
                ds.Tables[0].Columns[3].ColumnName = "����";
                ds.Tables[0].Columns[4].ColumnName = "�Ա�";
                ds.Tables[0].Columns[5].ColumnName = "����";
                ds.Tables[0].Columns[6].ColumnName = "����";
                ds.Tables[0].Columns[7].ColumnName = "��ϵ�绰";
                ds.Tables[0].Columns[8].ColumnName = "��ϵ��ַ";
                ds.Tables[0].Columns[9].ColumnName = "ҽʦ����";
                ds.Tables[0].Columns[10].ColumnName = "�������";
                ds.Tables[0].Columns[11].ColumnName = "������Ŀ";
                ds.Tables[0].Columns[12].ColumnName = "�Һŷ�";
                ds.Tables[0].Columns[13].ColumnName = "��Ϸ�";
                ds.Tables[0].Columns[14].ColumnName = "�Һ�Ա";
                ds.Tables[0].Columns[15].ColumnName = "�Һ���Ϣ";
                dgdGuaHaoMingXi.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //ˢ��
        private void btnShuaXin_Click(object sender, EventArgs e)
        {
            AddShuJu();
        }
        //�ر�
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
            MessageBox.Show("�Բ�����û��װ��ӡ�����޷���ӡ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}