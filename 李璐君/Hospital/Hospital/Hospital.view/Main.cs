using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Hospital.view;
using Hospital.Hospital.bl;
using Hospital.Hospital.dal;
using Hospital.Hospital.entity;
using System.Media;

namespace Hospital.Hospital.view
{
    public partial class Main : Form
    {
        private bool  bl;
        private bool puriew;//判断权限的变量
        private DataSet ds = new DataSet();
        private SoundPlayer sound = new SoundPlayer();//加载声音
        //private UsersEntity userEntity;
        
        public Main()
        {
            InitializeComponent();

            //this.userEntity = userEntity;
        }
        //单击版权信息时，弹出网页
        private void pbMessage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.31mj.cn");
        }
        /// <summary>
        /// 判断权限
        /// </summary>
        private void Puriew()
        {
            try
            {
                UsersBL ubl = new UsersBL();
                ds = ubl.SelectData(UsersEntity.un,UsersEntity.pass);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if ( ds.Tables[0].Rows[0][4].ToString().Equals("False"))
            {
                puriew= false;
            }
            else
            {
                puriew = true;
            }
            
        }
        private void lblGuaHao_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = Application.StartupPath + "\\sound\\1.wav";
            sound.Play();
            //单击时，换小圆点的图片
            pbGuaHao.BackgroundImage = imlMain.Images[1];
            pbQuanXian.BackgroundImage = imlMain.Images[0];
            pbXiTong.BackgroundImage = imlMain.Images[0];
            //单击时，改变字体颜色
            lblGuaHao.ForeColor = Color.Red;
            lblQuanXian.ForeColor = Color.Black;
            lblXiTong.ForeColor = Color.Black;
            //切换中间的图片
            pbMenZhenGuaHao.Visible = true;
            pbGuaHaoMingXi.Visible = true;
            pbTuiHaoMingXi.Visible = true;

            pbLog.Visible = false;
            pbUserQuanXian.Visible = false;
            pbMenZhenKeShi.Visible = false;
            pbMenZhenDoctor.Visible = false;

            pbHelp.Visible = false;
            pbUpdatePwd.Visible = false;
            pbPingMuSuoDing.Visible = false;
            pbGengHuanUser.Visible = false;
            pbCanel.Visible = false;
        }

        private void lblQuanXian_Click(object sender, EventArgs e)
        {
            //调用判断权限的方法
            sound.SoundLocation = Application.StartupPath + "\\sound\\1.wav";
            sound.Play();
            Puriew();
            if (puriew)
            {
                MessageBox.Show("对不起，您权限不足！",
                    "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            //单击时，换小圆点的图片
            pbGuaHao.BackgroundImage = imlMain.Images[0];
            pbQuanXian.BackgroundImage = imlMain.Images[1];
            pbXiTong.BackgroundImage = imlMain.Images[0];
            //单击时，改变字体颜色
            lblGuaHao.ForeColor = Color.Black;
            lblQuanXian.ForeColor = Color.Red;
            lblXiTong.ForeColor = Color.Black;
            //切换中间的图片
            pbMenZhenGuaHao.Visible = false;
            pbGuaHaoMingXi.Visible = false;
            pbTuiHaoMingXi.Visible = false;

            pbLog.Visible = true;
            pbUserQuanXian.Visible = true;
            pbMenZhenKeShi.Visible = true;
            pbMenZhenDoctor.Visible = true;

            pbHelp.Visible = false;
            pbUpdatePwd.Visible = false;
            pbPingMuSuoDing.Visible = false;
            pbGengHuanUser.Visible = false;
            pbCanel.Visible = false;
        }

        private void lblXiTong_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = Application.StartupPath + "\\sound\\1.wav";
            sound.Play();
            //单击时，换小圆点的图片
            pbGuaHao.BackgroundImage = imlMain.Images[0];
            pbQuanXian.BackgroundImage = imlMain.Images[0];
            pbXiTong.BackgroundImage = imlMain.Images[1];
            //单击时，改变字体颜色
            lblGuaHao.ForeColor = Color.Black;
            lblQuanXian.ForeColor = Color.Black;
            lblXiTong.ForeColor = Color.Red;
            //切换中间的图片
            pbMenZhenGuaHao.Visible = false;
            pbGuaHaoMingXi.Visible = false;
            pbTuiHaoMingXi.Visible = false;

            pbLog.Visible = false;
            pbUserQuanXian.Visible = false;
            pbMenZhenKeShi.Visible = false;
            pbMenZhenDoctor.Visible = false;

            pbHelp.Visible = true;
            pbUpdatePwd.Visible = true;
            pbPingMuSuoDing.Visible = true;
            pbGengHuanUser.Visible = true;
            pbCanel.Visible = true;
        }
        //窗体加载时显示系统管理
        private void Main_Load(object sender, EventArgs e)
        {
            tmOpacity.Start();
            
            //调用puriew判断权限
            try
            {
                sound.SoundLocation = Application.StartupPath + "\\sound\\取消.wav";
                sound.Play();
            }
            catch
            { }
            Puriew();
            if (puriew)
            {
                menuJiBenSheZhi.Enabled = false;
            }
            pbMenZhenGuaHao.Visible = false;
            pbGuaHaoMingXi.Visible = false;
            pbTuiHaoMingXi.Visible = false;

            pbLog.Visible = false;
            pbUserQuanXian.Visible = false;
            pbMenZhenKeShi.Visible = false;
            pbMenZhenDoctor.Visible = false;

            pbHelp.Visible = true;
            pbUpdatePwd.Visible = true;
            pbPingMuSuoDing.Visible = true;
            pbGengHuanUser.Visible = true;
            pbCanel.Visible = true;
            
        }
       
        //退出系统
        private void tsmiCanel_Click(object sender, EventArgs e)
        {
            bl = false;
            this.Close();
        }


    

        //注销重新登陆
        private void tsmiZhuXiao_Click(object sender, EventArgs e)
        {
            bl = true;
            frmLogin frm = new frmLogin();
            this.Close();
            frm.ShowDialog();
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Hospital.exe");
            
        
            
        }
        //关于本系统
        private void tsmiGuanYu_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }
        //关于本系统
        private void pbHelp_Click(object sender, EventArgs e)
        {
            tsmiGuanYu_Click(this,null);
        }
        //系统退出
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!bl)
            {
                DialogResult dr = MessageBox.Show("是否真的要退出系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
               
            }
        }
        
        //修改密码
        private void tsmiUpdatePwd_Click(object sender, EventArgs e)
        {
            UpdatePwd up = new UpdatePwd();
            up.ShowDialog();
        }
        //修改密码
        private void pbUpdatePwd_Click(object sender, EventArgs e)
        {
            tsmiUpdatePwd_Click(this,null);
        }
        //退出系统
        private void pbCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //注销，重新登陆
        private void pbGengHuanUser_Click(object sender, EventArgs e)
        {
            tsmiZhuXiao_Click(this,null);
        }

        private void pbPingMuSuoDing_Click(object sender, EventArgs e)
        {
            tsmiPingMuSuoDing_Click(this,null);
        }

        private void tsmiMenZhenGuaHao_Click(object sender, EventArgs e)
        {
            frmGuaHao fmGH = new frmGuaHao();
            fmGH.ShowDialog();
        }

        private void tsmiGuaHao_Click(object sender, EventArgs e)
        {
            frmGuaHaoMingXiBiao frm = new frmGuaHaoMingXiBiao();
            frm.ShowDialog();
        }

        private void tsmiTuiHao_Click(object sender, EventArgs e)
        {
            frmTuiHaoMingXiBiao frm = new frmTuiHaoMingXiBiao();
            frm.ShowDialog();
        }

        private void tsmiMenZhenKeShi_Click(object sender, EventArgs e)
        {
            frmMenZhenKeShi frm = new frmMenZhenKeShi();
            frm.ShowDialog();
        }

        private void tsmiMenZhenYiShi_Click(object sender, EventArgs e)
        {
            frmMenZhenYiShi frm = new frmMenZhenYiShi();
            frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tsmiMenZhenGuaHao_Click(this,null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tsmiGuaHao_Click(this,null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tsmiTuiHao_Click(this,null);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tsmiMenZhenKeShi_Click(this,null);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tsmiMenZhenYiShi_Click(this,null);
        }

        private void tmsiUserQuanXian_Click(object sender, EventArgs e)
        {
            frmQuanXian frm = new frmQuanXian();
            frm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tmsiUserQuanXian_Click(this,null);
        }

        private void tsmiPingMuSuoDing_Click(object sender, EventArgs e)
        {
            frmSuoDing frm = new frmSuoDing();
            frm.ShowDialog();
        }

        private void tsmiZiDianWeiHu_Click(object sender, EventArgs e)
        {
            frmLog frm = new frmLog();
            frm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tsmiZiDianWeiHu_Click(this,null);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Back bk = new Back();
            bk.ShowDialog();
        }
        //从透明带可见
        private void tmOpacity_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity = Opacity + 0.03;
            }
            else
            {
                tmOpacity.Stop();
            }

        }
    }
}