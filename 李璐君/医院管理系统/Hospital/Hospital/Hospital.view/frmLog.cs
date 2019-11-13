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
        /// ��������ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTiaoJian.SelectedIndex == 0&&cbUserName.Text=="")
                {
                    MessageBox.Show("��ѡ���û�����","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                LogBL bl = new LogBL();
                string name = cbUserName.Text.Trim();
                ds=bl.SelectData(name);
                ds.Tables[0].Columns[0].ColumnName = "���";
                ds.Tables[0].Columns[1].ColumnName = "�û���";
                ds.Tables[0].Columns[2].ColumnName = "ʱ��";
                ds.Tables[0].Columns[3].ColumnName = "�¼�";
                dgdLogInfo.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// ����ѯ���������仯ʱ���û����������Ƿ����
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