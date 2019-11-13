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
                ds.Tables[0].Columns[0].ColumnName = "ҽʦ���";
                ds.Tables[0].Columns[1].ColumnName = "����";
                ds.Tables[0].Columns[2].ColumnName = "�Ա�";
                ds.Tables[0].Columns[3].ColumnName = "����";
                ds.Tables[0].Columns[4].ColumnName = "ѧ��";
                ds.Tables[0].Columns[5].ColumnName = "ְ��";
                ds.Tables[0].Columns[6].ColumnName = "����";
                dataGridView1.DataSource = ds.Tables[0];
                this.gbYiShi.Text = "��ǰ��" + ds.Tables[0].Rows.Count + "��ҽʦ��¼";
                KeShi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// �����ҵ��������������
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
        /// ��datagrideviewѡ����仯ʱ�ұߵ���Ϣͬʱ�����仯
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
        //���
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();
            frm.ShowDialog();
            frmMenZhenYiShi_Load(this,null);
        }
        //ˢ��
        private void btnShuaXin_Click(object sender, EventArgs e)
        {
            frmMenZhenYiShi_Load(this,null);
        }
        //ɾ��
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id =Convert.ToInt32( ds.Tables[0].Rows[dataGridView1.CurrentRow.Index][0].ToString());
                DoctorBL bl = new DoctorBL();
                if (DialogResult.Yes == MessageBox.Show("��ȷ��Ҫɾ����", "ȷ��",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bl.DeleteData(id);
                    MessageBox.Show("ɾ���ɹ���", "�ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmMenZhenYiShi_Load(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //�޸�
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
            CheckInfo ch = new CheckInfo();
            if (ch.checkNull(txtName.Text) != "" || ch.checkNull(txtAge.Text) != "" || ch.checkNull(cbSex.Text) != "")
            {
                MessageBox.Show("���������Ϣ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ch.checkLength(txtName.Text) != "" || ch.checkLength(txtAge.Text) != "" || ch.checkLength(cbSex.Text) != "")
            {
                MessageBox.Show("���������Ϣ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ch.checkT(txtName.Text) != "" || ch.checkT(txtAge.Text) != "" || ch.checkT(cbSex.Text) != "")
            {
                MessageBox.Show("�Բ������������Ϣ�к��������ַ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("�޸ĳɹ���", "�ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDaYin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�Բ�����û��װ��ӡ�����޷���ӡ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}