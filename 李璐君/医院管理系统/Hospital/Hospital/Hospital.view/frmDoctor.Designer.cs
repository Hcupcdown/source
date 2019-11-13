namespace Hospital.Hospital.view
{
    partial class frmDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.gbXinXi.SuspendLayout();
            this.SuspendLayout();
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
            this.gbXinXi.Location = new System.Drawing.Point(45, 101);
            this.gbXinXi.Name = "gbXinXi";
            this.gbXinXi.Size = new System.Drawing.Size(325, 251);
            this.gbXinXi.TabIndex = 3;
            this.gbXinXi.TabStop = false;
            this.gbXinXi.Text = "信息设置";
            // 
            // cbKeShi
            // 
            this.cbKeShi.FormattingEnabled = true;
            this.cbKeShi.Location = new System.Drawing.Point(149, 193);
            this.cbKeShi.Name = "cbKeShi";
            this.cbKeShi.Size = new System.Drawing.Size(139, 20);
            this.cbKeShi.TabIndex = 11;
            // 
            // cbZhiCheng
            // 
            this.cbZhiCheng.FormattingEnabled = true;
            this.cbZhiCheng.Location = new System.Drawing.Point(149, 159);
            this.cbZhiCheng.Name = "cbZhiCheng";
            this.cbZhiCheng.Size = new System.Drawing.Size(139, 20);
            this.cbZhiCheng.TabIndex = 10;
            // 
            // cbXueLi
            // 
            this.cbXueLi.FormattingEnabled = true;
            this.cbXueLi.Location = new System.Drawing.Point(149, 125);
            this.cbXueLi.Name = "cbXueLi";
            this.cbXueLi.Size = new System.Drawing.Size(139, 20);
            this.cbXueLi.TabIndex = 9;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(149, 57);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(139, 20);
            this.cbSex.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(149, 91);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(139, 21);
            this.txtAge.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 21);
            this.txtName.TabIndex = 6;
            // 
            // lblKeShi
            // 
            this.lblKeShi.AutoSize = true;
            this.lblKeShi.Location = new System.Drawing.Point(29, 196);
            this.lblKeShi.Name = "lblKeShi";
            this.lblKeShi.Size = new System.Drawing.Size(65, 12);
            this.lblKeShi.TabIndex = 5;
            this.lblKeShi.Text = "所在科室：";
            // 
            // lblZhiCheng
            // 
            this.lblZhiCheng.AutoSize = true;
            this.lblZhiCheng.Location = new System.Drawing.Point(29, 162);
            this.lblZhiCheng.Name = "lblZhiCheng";
            this.lblZhiCheng.Size = new System.Drawing.Size(41, 12);
            this.lblZhiCheng.TabIndex = 4;
            this.lblZhiCheng.Text = "职称：";
            // 
            // lblXueLi
            // 
            this.lblXueLi.AutoSize = true;
            this.lblXueLi.Location = new System.Drawing.Point(29, 128);
            this.lblXueLi.Name = "lblXueLi";
            this.lblXueLi.Size = new System.Drawing.Size(41, 12);
            this.lblXueLi.TabIndex = 3;
            this.lblXueLi.Text = "学历：";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(29, 94);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 12);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "年龄：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(29, 60);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "医师姓名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(250, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Location = new System.Drawing.Point(331, 367);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(58, 23);
            this.btnCanel.TabIndex = 5;
            this.btnCanel.Text = "取消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 399);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbXinXi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加医师信息";
            this.gbXinXi.ResumeLayout(false);
            this.gbXinXi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbXinXi;
        private System.Windows.Forms.ComboBox cbKeShi;
        private System.Windows.Forms.ComboBox cbZhiCheng;
        private System.Windows.Forms.ComboBox cbXueLi;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblKeShi;
        private System.Windows.Forms.Label lblZhiCheng;
        private System.Windows.Forms.Label lblXueLi;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCanel;
    }
}