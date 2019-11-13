namespace Hospital.Hospital.view
{
    partial class frmMenZhenYiShi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenZhenYiShi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbYiShi = new System.Windows.Forms.GroupBox();
            this.gbXinXi = new System.Windows.Forms.GroupBox();
            this.cbKeShi = new System.Windows.Forms.ComboBox();
            this.cbZhiCheng = new System.Windows.Forms.ComboBox();
            this.cbXueLi = new System.Windows.Forms.ComboBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblKeShi = new System.Windows.Forms.Label();
            this.lblZhiCheng = new System.Windows.Forms.Label();
            this.lblXueLi = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShuaXin = new System.Windows.Forms.Button();
            this.btnDaYin = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbYiShi.SuspendLayout();
            this.gbXinXi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(363, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // gbYiShi
            // 
            this.gbYiShi.BackColor = System.Drawing.Color.Transparent;
            this.gbYiShi.Controls.Add(this.dataGridView1);
            this.gbYiShi.Location = new System.Drawing.Point(5, 138);
            this.gbYiShi.Name = "gbYiShi";
            this.gbYiShi.Size = new System.Drawing.Size(369, 309);
            this.gbYiShi.TabIndex = 1;
            this.gbYiShi.TabStop = false;
            this.gbYiShi.Text = "当前有几条医师记录";
            // 
            // gbXinXi
            // 
            this.gbXinXi.BackColor = System.Drawing.Color.Transparent;
            this.gbXinXi.Controls.Add(this.cbKeShi);
            this.gbXinXi.Controls.Add(this.cbZhiCheng);
            this.gbXinXi.Controls.Add(this.cbXueLi);
            this.gbXinXi.Controls.Add(this.cbSex);
            this.gbXinXi.Controls.Add(this.txtAge);
            this.gbXinXi.Controls.Add(this.txtName);
            this.gbXinXi.Controls.Add(this.lblKeShi);
            this.gbXinXi.Controls.Add(this.lblZhiCheng);
            this.gbXinXi.Controls.Add(this.lblXueLi);
            this.gbXinXi.Controls.Add(this.lblAge);
            this.gbXinXi.Controls.Add(this.lblSex);
            this.gbXinXi.Controls.Add(this.lblName);
            this.gbXinXi.Location = new System.Drawing.Point(395, 138);
            this.gbXinXi.Name = "gbXinXi";
            this.gbXinXi.Size = new System.Drawing.Size(286, 251);
            this.gbXinXi.TabIndex = 2;
            this.gbXinXi.TabStop = false;
            this.gbXinXi.Text = "信息设置";
            // 
            // cbKeShi
            // 
            this.cbKeShi.FormattingEnabled = true;
            this.cbKeShi.Location = new System.Drawing.Point(124, 193);
            this.cbKeShi.Name = "cbKeShi";
            this.cbKeShi.Size = new System.Drawing.Size(139, 20);
            this.cbKeShi.TabIndex = 11;
            // 
            // cbZhiCheng
            // 
            this.cbZhiCheng.FormattingEnabled = true;
            this.cbZhiCheng.Items.AddRange(new object[] {
            "专家",
            "教授"});
            this.cbZhiCheng.Location = new System.Drawing.Point(124, 159);
            this.cbZhiCheng.Name = "cbZhiCheng";
            this.cbZhiCheng.Size = new System.Drawing.Size(139, 20);
            this.cbZhiCheng.TabIndex = 10;
            // 
            // cbXueLi
            // 
            this.cbXueLi.FormattingEnabled = true;
            this.cbXueLi.Items.AddRange(new object[] {
            "高中",
            "大专",
            "本科",
            "研究生",
            "博士"});
            this.cbXueLi.Location = new System.Drawing.Point(124, 125);
            this.cbXueLi.Name = "cbXueLi";
            this.cbXueLi.Size = new System.Drawing.Size(139, 20);
            this.cbXueLi.TabIndex = 9;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(124, 57);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(139, 20);
            this.cbSex.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(124, 91);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(139, 21);
            this.txtAge.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 21);
            this.txtName.TabIndex = 6;
            // 
            // lblKeShi
            // 
            this.lblKeShi.AutoSize = true;
            this.lblKeShi.Location = new System.Drawing.Point(20, 196);
            this.lblKeShi.Name = "lblKeShi";
            this.lblKeShi.Size = new System.Drawing.Size(65, 12);
            this.lblKeShi.TabIndex = 5;
            this.lblKeShi.Text = "所在科室：";
            // 
            // lblZhiCheng
            // 
            this.lblZhiCheng.AutoSize = true;
            this.lblZhiCheng.Location = new System.Drawing.Point(20, 162);
            this.lblZhiCheng.Name = "lblZhiCheng";
            this.lblZhiCheng.Size = new System.Drawing.Size(41, 12);
            this.lblZhiCheng.TabIndex = 4;
            this.lblZhiCheng.Text = "职称：";
            // 
            // lblXueLi
            // 
            this.lblXueLi.AutoSize = true;
            this.lblXueLi.Location = new System.Drawing.Point(20, 128);
            this.lblXueLi.Name = "lblXueLi";
            this.lblXueLi.Size = new System.Drawing.Size(41, 12);
            this.lblXueLi.TabIndex = 3;
            this.lblXueLi.Text = "学历：";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 94);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 12);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "年龄：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(20, 60);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "医师姓名：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(5, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 10);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(184, 487);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(356, 487);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShuaXin
            // 
            this.btnShuaXin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuaXin.Location = new System.Drawing.Point(442, 487);
            this.btnShuaXin.Name = "btnShuaXin";
            this.btnShuaXin.Size = new System.Drawing.Size(66, 23);
            this.btnShuaXin.TabIndex = 6;
            this.btnShuaXin.Text = "刷新";
            this.btnShuaXin.UseVisualStyleBackColor = true;
            this.btnShuaXin.Click += new System.EventHandler(this.btnShuaXin_Click);
            // 
            // btnDaYin
            // 
            this.btnDaYin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaYin.Location = new System.Drawing.Point(528, 487);
            this.btnDaYin.Name = "btnDaYin";
            this.btnDaYin.Size = new System.Drawing.Size(66, 23);
            this.btnDaYin.TabIndex = 7;
            this.btnDaYin.Text = "打印";
            this.btnDaYin.UseVisualStyleBackColor = true;
            this.btnDaYin.Click += new System.EventHandler(this.btnDaYin_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Location = new System.Drawing.Point(615, 487);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(66, 23);
            this.btnCanel.TabIndex = 8;
            this.btnCanel.Text = "关闭";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(270, 487);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmMenZhenYiShi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 534);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnDaYin);
            this.Controls.Add(this.btnShuaXin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbXinXi);
            this.Controls.Add(this.gbYiShi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenZhenYiShi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "门诊医师管理";
            this.Load += new System.EventHandler(this.frmMenZhenYiShi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbYiShi.ResumeLayout(false);
            this.gbXinXi.ResumeLayout(false);
            this.gbXinXi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbYiShi;
        private System.Windows.Forms.GroupBox gbXinXi;
        private System.Windows.Forms.Label lblKeShi;
        private System.Windows.Forms.Label lblZhiCheng;
        private System.Windows.Forms.Label lblXueLi;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbKeShi;
        private System.Windows.Forms.ComboBox cbZhiCheng;
        private System.Windows.Forms.ComboBox cbXueLi;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShuaXin;
        private System.Windows.Forms.Button btnDaYin;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnUpdate;
    }
}