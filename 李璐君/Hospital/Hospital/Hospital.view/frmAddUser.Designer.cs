namespace Hospital.Hospital.view
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.cbQuanXian = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuMen = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBuMen = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.BackColor = System.Drawing.Color.Transparent;
            this.gbAdd.Controls.Add(this.cbQuanXian);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Controls.Add(this.cbBuMen);
            this.gbAdd.Controls.Add(this.txtPwd);
            this.gbAdd.Controls.Add(this.txtUserName);
            this.gbAdd.Controls.Add(this.txtName);
            this.gbAdd.Controls.Add(this.lblBuMen);
            this.gbAdd.Controls.Add(this.lblPwd);
            this.gbAdd.Controls.Add(this.lblUserName);
            this.gbAdd.Controls.Add(this.lblName);
            this.gbAdd.Location = new System.Drawing.Point(34, 80);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(406, 201);
            this.gbAdd.TabIndex = 2;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "信息设置";
            // 
            // cbQuanXian
            // 
            this.cbQuanXian.FormattingEnabled = true;
            this.cbQuanXian.Items.AddRange(new object[] {
            "管理员",
            "门诊"});
            this.cbQuanXian.Location = new System.Drawing.Point(181, 152);
            this.cbQuanXian.Name = "cbQuanXian";
            this.cbQuanXian.Size = new System.Drawing.Size(93, 20);
            this.cbQuanXian.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "权限：";
            // 
            // cbBuMen
            // 
            this.cbBuMen.FormattingEnabled = true;
            this.cbBuMen.Items.AddRange(new object[] {
            "门诊部",
            "住院部"});
            this.cbBuMen.Location = new System.Drawing.Point(261, 103);
            this.cbBuMen.Name = "cbBuMen";
            this.cbBuMen.Size = new System.Drawing.Size(93, 20);
            this.cbBuMen.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(103, 108);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(93, 21);
            this.txtPwd.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(103, 51);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(93, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblBuMen
            // 
            this.lblBuMen.AutoSize = true;
            this.lblBuMen.Location = new System.Drawing.Point(202, 111);
            this.lblBuMen.Name = "lblBuMen";
            this.lblBuMen.Size = new System.Drawing.Size(41, 12);
            this.lblBuMen.TabIndex = 3;
            this.lblBuMen.Text = "部门：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(56, 111);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(41, 12);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密码：";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(44, 54);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "用户名：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(202, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(302, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Location = new System.Drawing.Point(391, 309);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(58, 23);
            this.btnCanel.TabIndex = 6;
            this.btnCanel.Text = "取消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加用户信息";
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.ComboBox cbBuMen;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBuMen;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.ComboBox cbQuanXian;
        private System.Windows.Forms.Label label1;
    }
}