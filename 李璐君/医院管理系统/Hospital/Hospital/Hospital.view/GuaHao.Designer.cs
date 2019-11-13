namespace Hospital.Hospital.view
{
    partial class frmGuaHao
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuaHao));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbGuaZhenKeShi = new System.Windows.Forms.GroupBox();
            this.dgdKeShi = new System.Windows.Forms.DataGridView();
            this.gbGuaZhenXiangMu = new System.Windows.Forms.GroupBox();
            this.dgdXiangMu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtGuaHaoYuan = new System.Windows.Forms.TextBox();
            this.txtZhenDuanFei = new System.Windows.Forms.TextBox();
            this.txtGuaHaoFei = new System.Windows.Forms.TextBox();
            this.txtGuaZhenXiangMu = new System.Windows.Forms.TextBox();
            this.txtGuaZhenKeShi = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbYiShi = new System.Windows.Forms.ComboBox();
            this.cbMinZu = new System.Windows.Forms.ComboBox();
            this.cbFuFeiFangShi = new System.Windows.Forms.ComboBox();
            this.cbJiuZhenLeiXing = new System.Windows.Forms.ComboBox();
            this.lblGuaHaoYuan = new System.Windows.Forms.Label();
            this.lblZhenDuanFei = new System.Windows.Forms.Label();
            this.lblGuaHaoFei = new System.Windows.Forms.Label();
            this.lblGuaZhenXiangMu = new System.Windows.Forms.Label();
            this.lblGuaZhenKeShi = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMinZu = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFuFeiFangShi = new System.Windows.Forms.Label();
            this.lblJiuZhenLeiXing = new System.Windows.Forms.Label();
            this.btnGuaHao = new System.Windows.Forms.Button();
            this.btnGaiHao = new System.Windows.Forms.Button();
            this.btnTuiHao = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblMenZhenHao = new System.Windows.Forms.Label();
            this.txtMenZhenHao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbGuaZhenKeShi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdKeShi)).BeginInit();
            this.gbGuaZhenXiangMu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdXiangMu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(879, 65);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // gbGuaZhenKeShi
            // 
            this.gbGuaZhenKeShi.BackColor = System.Drawing.Color.Transparent;
            this.gbGuaZhenKeShi.Controls.Add(this.dgdKeShi);
            this.gbGuaZhenKeShi.Location = new System.Drawing.Point(0, 70);
            this.gbGuaZhenKeShi.Name = "gbGuaZhenKeShi";
            this.gbGuaZhenKeShi.Size = new System.Drawing.Size(294, 451);
            this.gbGuaZhenKeShi.TabIndex = 2;
            this.gbGuaZhenKeShi.TabStop = false;
            this.gbGuaZhenKeShi.Text = "挂诊科室";
            // 
            // dgdKeShi
            // 
            this.dgdKeShi.AllowUserToAddRows = false;
            this.dgdKeShi.AllowUserToDeleteRows = false;
            this.dgdKeShi.BackgroundColor = System.Drawing.Color.White;
            this.dgdKeShi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdKeShi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdKeShi.Location = new System.Drawing.Point(3, 17);
            this.dgdKeShi.Name = "dgdKeShi";
            this.dgdKeShi.ReadOnly = true;
            this.dgdKeShi.RowTemplate.Height = 23;
            this.dgdKeShi.Size = new System.Drawing.Size(288, 431);
            this.dgdKeShi.TabIndex = 2;
            this.dgdKeShi.SelectionChanged += new System.EventHandler(this.dgdKeShi_SelectionChanged);
            // 
            // gbGuaZhenXiangMu
            // 
            this.gbGuaZhenXiangMu.BackColor = System.Drawing.Color.Transparent;
            this.gbGuaZhenXiangMu.Controls.Add(this.dgdXiangMu);
            this.gbGuaZhenXiangMu.Location = new System.Drawing.Point(300, 70);
            this.gbGuaZhenXiangMu.Name = "gbGuaZhenXiangMu";
            this.gbGuaZhenXiangMu.Size = new System.Drawing.Size(304, 451);
            this.gbGuaZhenXiangMu.TabIndex = 3;
            this.gbGuaZhenXiangMu.TabStop = false;
            this.gbGuaZhenXiangMu.Text = "挂诊项目";
            // 
            // dgdXiangMu
            // 
            this.dgdXiangMu.AllowUserToAddRows = false;
            this.dgdXiangMu.AllowUserToDeleteRows = false;
            this.dgdXiangMu.BackgroundColor = System.Drawing.Color.White;
            this.dgdXiangMu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdXiangMu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdXiangMu.Location = new System.Drawing.Point(3, 17);
            this.dgdXiangMu.Name = "dgdXiangMu";
            this.dgdXiangMu.ReadOnly = true;
            this.dgdXiangMu.RowTemplate.Height = 23;
            this.dgdXiangMu.Size = new System.Drawing.Size(298, 431);
            this.dgdXiangMu.TabIndex = 1;
            this.dgdXiangMu.SelectionChanged += new System.EventHandler(this.dgdXiangMu_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbSex);
            this.groupBox1.Controls.Add(this.txtGuaHaoYuan);
            this.groupBox1.Controls.Add(this.txtZhenDuanFei);
            this.groupBox1.Controls.Add(this.txtGuaHaoFei);
            this.groupBox1.Controls.Add(this.txtGuaZhenXiangMu);
            this.groupBox1.Controls.Add(this.txtGuaZhenKeShi);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cbYiShi);
            this.groupBox1.Controls.Add(this.cbMinZu);
            this.groupBox1.Controls.Add(this.cbFuFeiFangShi);
            this.groupBox1.Controls.Add(this.cbJiuZhenLeiXing);
            this.groupBox1.Controls.Add(this.lblGuaHaoYuan);
            this.groupBox1.Controls.Add(this.lblZhenDuanFei);
            this.groupBox1.Controls.Add(this.lblGuaHaoFei);
            this.groupBox1.Controls.Add(this.lblGuaZhenXiangMu);
            this.groupBox1.Controls.Add(this.lblGuaZhenKeShi);
            this.groupBox1.Controls.Add(this.lblDoctor);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblMinZu);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblFuFeiFangShi);
            this.groupBox1.Controls.Add(this.lblJiuZhenLeiXing);
            this.groupBox1.Location = new System.Drawing.Point(610, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 448);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "挂诊项目";
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.White;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(122, 102);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(106, 20);
            this.cbSex.TabIndex = 4;
            // 
            // txtGuaHaoYuan
            // 
            this.txtGuaHaoYuan.BackColor = System.Drawing.Color.White;
            this.txtGuaHaoYuan.Enabled = false;
            this.txtGuaHaoYuan.Location = new System.Drawing.Point(122, 363);
            this.txtGuaHaoYuan.Name = "txtGuaHaoYuan";
            this.txtGuaHaoYuan.Size = new System.Drawing.Size(106, 21);
            this.txtGuaHaoYuan.TabIndex = 14;
            // 
            // txtZhenDuanFei
            // 
            this.txtZhenDuanFei.BackColor = System.Drawing.Color.White;
            this.txtZhenDuanFei.Enabled = false;
            this.txtZhenDuanFei.Location = new System.Drawing.Point(122, 337);
            this.txtZhenDuanFei.Name = "txtZhenDuanFei";
            this.txtZhenDuanFei.Size = new System.Drawing.Size(106, 21);
            this.txtZhenDuanFei.TabIndex = 13;
            // 
            // txtGuaHaoFei
            // 
            this.txtGuaHaoFei.BackColor = System.Drawing.Color.White;
            this.txtGuaHaoFei.Enabled = false;
            this.txtGuaHaoFei.Location = new System.Drawing.Point(122, 310);
            this.txtGuaHaoFei.Name = "txtGuaHaoFei";
            this.txtGuaHaoFei.Size = new System.Drawing.Size(106, 21);
            this.txtGuaHaoFei.TabIndex = 12;
            // 
            // txtGuaZhenXiangMu
            // 
            this.txtGuaZhenXiangMu.BackColor = System.Drawing.Color.White;
            this.txtGuaZhenXiangMu.Enabled = false;
            this.txtGuaZhenXiangMu.Location = new System.Drawing.Point(122, 284);
            this.txtGuaZhenXiangMu.Name = "txtGuaZhenXiangMu";
            this.txtGuaZhenXiangMu.Size = new System.Drawing.Size(106, 21);
            this.txtGuaZhenXiangMu.TabIndex = 11;
            // 
            // txtGuaZhenKeShi
            // 
            this.txtGuaZhenKeShi.BackColor = System.Drawing.Color.White;
            this.txtGuaZhenKeShi.Enabled = false;
            this.txtGuaZhenKeShi.Location = new System.Drawing.Point(122, 257);
            this.txtGuaZhenKeShi.Name = "txtGuaZhenKeShi";
            this.txtGuaZhenKeShi.Size = new System.Drawing.Size(106, 21);
            this.txtGuaZhenKeShi.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(122, 206);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(106, 21);
            this.txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(122, 180);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(106, 21);
            this.txtPhone.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Location = new System.Drawing.Point(122, 127);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(106, 21);
            this.txtAge.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(122, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 21);
            this.txtName.TabIndex = 3;
            // 
            // cbYiShi
            // 
            this.cbYiShi.BackColor = System.Drawing.Color.White;
            this.cbYiShi.FormattingEnabled = true;
            this.cbYiShi.Location = new System.Drawing.Point(122, 233);
            this.cbYiShi.Name = "cbYiShi";
            this.cbYiShi.Size = new System.Drawing.Size(106, 20);
            this.cbYiShi.TabIndex = 9;
            // 
            // cbMinZu
            // 
            this.cbMinZu.BackColor = System.Drawing.Color.White;
            this.cbMinZu.FormattingEnabled = true;
            this.cbMinZu.Items.AddRange(new object[] {
            "汉族",
            "少数民族"});
            this.cbMinZu.Location = new System.Drawing.Point(122, 154);
            this.cbMinZu.Name = "cbMinZu";
            this.cbMinZu.Size = new System.Drawing.Size(106, 20);
            this.cbMinZu.TabIndex = 6;
            // 
            // cbFuFeiFangShi
            // 
            this.cbFuFeiFangShi.BackColor = System.Drawing.Color.White;
            this.cbFuFeiFangShi.FormattingEnabled = true;
            this.cbFuFeiFangShi.Items.AddRange(new object[] {
            "现金",
            "刷卡",
            "支票"});
            this.cbFuFeiFangShi.Location = new System.Drawing.Point(122, 50);
            this.cbFuFeiFangShi.Name = "cbFuFeiFangShi";
            this.cbFuFeiFangShi.Size = new System.Drawing.Size(106, 20);
            this.cbFuFeiFangShi.TabIndex = 2;
            // 
            // cbJiuZhenLeiXing
            // 
            this.cbJiuZhenLeiXing.BackColor = System.Drawing.Color.White;
            this.cbJiuZhenLeiXing.FormattingEnabled = true;
            this.cbJiuZhenLeiXing.Items.AddRange(new object[] {
            "初诊",
            "复诊"});
            this.cbJiuZhenLeiXing.Location = new System.Drawing.Point(122, 26);
            this.cbJiuZhenLeiXing.Name = "cbJiuZhenLeiXing";
            this.cbJiuZhenLeiXing.Size = new System.Drawing.Size(106, 20);
            this.cbJiuZhenLeiXing.TabIndex = 1;
            // 
            // lblGuaHaoYuan
            // 
            this.lblGuaHaoYuan.AutoSize = true;
            this.lblGuaHaoYuan.Location = new System.Drawing.Point(34, 367);
            this.lblGuaHaoYuan.Name = "lblGuaHaoYuan";
            this.lblGuaHaoYuan.Size = new System.Drawing.Size(53, 12);
            this.lblGuaHaoYuan.TabIndex = 15;
            this.lblGuaHaoYuan.Text = "挂号员：";
            // 
            // lblZhenDuanFei
            // 
            this.lblZhenDuanFei.AutoSize = true;
            this.lblZhenDuanFei.Location = new System.Drawing.Point(34, 341);
            this.lblZhenDuanFei.Name = "lblZhenDuanFei";
            this.lblZhenDuanFei.Size = new System.Drawing.Size(53, 12);
            this.lblZhenDuanFei.TabIndex = 14;
            this.lblZhenDuanFei.Text = "诊断费：";
            // 
            // lblGuaHaoFei
            // 
            this.lblGuaHaoFei.AutoSize = true;
            this.lblGuaHaoFei.Location = new System.Drawing.Point(34, 315);
            this.lblGuaHaoFei.Name = "lblGuaHaoFei";
            this.lblGuaHaoFei.Size = new System.Drawing.Size(53, 12);
            this.lblGuaHaoFei.TabIndex = 13;
            this.lblGuaHaoFei.Text = "挂号费：";
            // 
            // lblGuaZhenXiangMu
            // 
            this.lblGuaZhenXiangMu.AutoSize = true;
            this.lblGuaZhenXiangMu.Location = new System.Drawing.Point(34, 289);
            this.lblGuaZhenXiangMu.Name = "lblGuaZhenXiangMu";
            this.lblGuaZhenXiangMu.Size = new System.Drawing.Size(65, 12);
            this.lblGuaZhenXiangMu.TabIndex = 12;
            this.lblGuaZhenXiangMu.Text = "挂诊项目：";
            // 
            // lblGuaZhenKeShi
            // 
            this.lblGuaZhenKeShi.AutoSize = true;
            this.lblGuaZhenKeShi.Location = new System.Drawing.Point(34, 263);
            this.lblGuaZhenKeShi.Name = "lblGuaZhenKeShi";
            this.lblGuaZhenKeShi.Size = new System.Drawing.Size(65, 12);
            this.lblGuaZhenKeShi.TabIndex = 11;
            this.lblGuaZhenKeShi.Text = "挂诊科室：";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(34, 237);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(41, 12);
            this.lblDoctor.TabIndex = 10;
            this.lblDoctor.Text = "医师：";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 211);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 12);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "住址：";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(34, 185);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "联系电话：";
            // 
            // lblMinZu
            // 
            this.lblMinZu.AutoSize = true;
            this.lblMinZu.Location = new System.Drawing.Point(34, 159);
            this.lblMinZu.Name = "lblMinZu";
            this.lblMinZu.Size = new System.Drawing.Size(41, 12);
            this.lblMinZu.TabIndex = 5;
            this.lblMinZu.Text = "民族：";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(34, 133);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 12);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "年龄：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(34, 107);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "性别：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名：";
            // 
            // lblFuFeiFangShi
            // 
            this.lblFuFeiFangShi.AutoSize = true;
            this.lblFuFeiFangShi.Location = new System.Drawing.Point(34, 55);
            this.lblFuFeiFangShi.Name = "lblFuFeiFangShi";
            this.lblFuFeiFangShi.Size = new System.Drawing.Size(65, 12);
            this.lblFuFeiFangShi.TabIndex = 1;
            this.lblFuFeiFangShi.Text = "付费方式：";
            // 
            // lblJiuZhenLeiXing
            // 
            this.lblJiuZhenLeiXing.AutoSize = true;
            this.lblJiuZhenLeiXing.Location = new System.Drawing.Point(34, 29);
            this.lblJiuZhenLeiXing.Name = "lblJiuZhenLeiXing";
            this.lblJiuZhenLeiXing.Size = new System.Drawing.Size(65, 12);
            this.lblJiuZhenLeiXing.TabIndex = 0;
            this.lblJiuZhenLeiXing.Text = "就诊类型：";
            // 
            // btnGuaHao
            // 
            this.btnGuaHao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuaHao.Location = new System.Drawing.Point(504, 560);
            this.btnGuaHao.Name = "btnGuaHao";
            this.btnGuaHao.Size = new System.Drawing.Size(75, 23);
            this.btnGuaHao.TabIndex = 15;
            this.btnGuaHao.Text = "挂号";
            this.btnGuaHao.UseVisualStyleBackColor = true;
            this.btnGuaHao.Click += new System.EventHandler(this.btnGuaHao_Click);
            // 
            // btnGaiHao
            // 
            this.btnGaiHao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGaiHao.Location = new System.Drawing.Point(597, 560);
            this.btnGaiHao.Name = "btnGaiHao";
            this.btnGaiHao.Size = new System.Drawing.Size(75, 23);
            this.btnGaiHao.TabIndex = 16;
            this.btnGaiHao.Text = "改号";
            this.btnGaiHao.UseVisualStyleBackColor = true;
            this.btnGaiHao.Click += new System.EventHandler(this.btnGaiHao_Click);
            // 
            // btnTuiHao
            // 
            this.btnTuiHao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuiHao.Location = new System.Drawing.Point(690, 560);
            this.btnTuiHao.Name = "btnTuiHao";
            this.btnTuiHao.Size = new System.Drawing.Size(75, 23);
            this.btnTuiHao.TabIndex = 17;
            this.btnTuiHao.Text = "退号";
            this.btnTuiHao.UseVisualStyleBackColor = true;
            this.btnTuiHao.Click += new System.EventHandler(this.btnTuiHao_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Location = new System.Drawing.Point(783, 560);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 23);
            this.btnCanel.TabIndex = 18;
            this.btnCanel.Text = "关闭";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Location = new System.Drawing.Point(210, 562);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblMenZhenHao
            // 
            this.lblMenZhenHao.AutoSize = true;
            this.lblMenZhenHao.Location = new System.Drawing.Point(12, 566);
            this.lblMenZhenHao.Name = "lblMenZhenHao";
            this.lblMenZhenHao.Size = new System.Drawing.Size(53, 12);
            this.lblMenZhenHao.TabIndex = 10;
            this.lblMenZhenHao.Text = "门诊号：";
            // 
            // txtMenZhenHao
            // 
            this.txtMenZhenHao.BackColor = System.Drawing.Color.White;
            this.txtMenZhenHao.Location = new System.Drawing.Point(81, 562);
            this.txtMenZhenHao.Name = "txtMenZhenHao";
            this.txtMenZhenHao.Size = new System.Drawing.Size(100, 21);
            this.txtMenZhenHao.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 10);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // frmGuaHao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMenZhenHao);
            this.Controls.Add(this.lblMenZhenHao);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnTuiHao);
            this.Controls.Add(this.btnGaiHao);
            this.Controls.Add(this.btnGuaHao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGuaZhenXiangMu);
            this.Controls.Add(this.gbGuaZhenKeShi);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGuaHao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "门诊挂号";
            this.Load += new System.EventHandler(this.frmGuaHao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbGuaZhenKeShi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdKeShi)).EndInit();
            this.gbGuaZhenXiangMu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdXiangMu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbGuaZhenKeShi;
        private System.Windows.Forms.GroupBox gbGuaZhenXiangMu;
        private System.Windows.Forms.DataGridView dgdXiangMu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGuaHaoYuan;
        private System.Windows.Forms.Label lblZhenDuanFei;
        private System.Windows.Forms.Label lblGuaHaoFei;
        private System.Windows.Forms.Label lblGuaZhenXiangMu;
        private System.Windows.Forms.Label lblGuaZhenKeShi;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMinZu;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFuFeiFangShi;
        private System.Windows.Forms.Label lblJiuZhenLeiXing;
        private System.Windows.Forms.Button btnGuaHao;
        private System.Windows.Forms.Button btnGaiHao;
        private System.Windows.Forms.Button btnTuiHao;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblMenZhenHao;
        private System.Windows.Forms.TextBox txtMenZhenHao;
        private System.Windows.Forms.TextBox txtGuaHaoYuan;
        private System.Windows.Forms.TextBox txtZhenDuanFei;
        private System.Windows.Forms.TextBox txtGuaHaoFei;
        private System.Windows.Forms.TextBox txtGuaZhenXiangMu;
        private System.Windows.Forms.TextBox txtGuaZhenKeShi;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbYiShi;
        private System.Windows.Forms.ComboBox cbMinZu;
        private System.Windows.Forms.ComboBox cbFuFeiFangShi;
        private System.Windows.Forms.ComboBox cbJiuZhenLeiXing;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DataGridView dgdKeShi;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}