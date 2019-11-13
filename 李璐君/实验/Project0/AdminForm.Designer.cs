namespace Project0
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addDoctorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.医生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科室信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.行政人员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.infoToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addDoctorButton
            // 
            this.addDoctorButton.Image = ((System.Drawing.Image)(resources.GetObject("addDoctorButton.Image")));
            this.addDoctorButton.Location = new System.Drawing.Point(71, 82);
            this.addDoctorButton.Name = "addDoctorButton";
            this.addDoctorButton.Size = new System.Drawing.Size(168, 161);
            this.addDoctorButton.TabIndex = 1;
            this.addDoctorButton.Text = "添加医生";
            this.addDoctorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.addDoctorButton, "添加医生");
            this.addDoctorButton.UseVisualStyleBackColor = true;
            this.addDoctorButton.Click += new System.EventHandler(this.addDoctorButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(71, 291);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "退出";
            this.toolTip1.SetToolTip(this.exitButton, "退出应用程序");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.infoToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.infoToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.infoToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(756, 32);
            this.infoToolStripMenuItem.TabIndex = 0;
            this.infoToolStripMenuItem.Text = "基本信息";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.医生信息ToolStripMenuItem,
            this.科室信息ToolStripMenuItem,
            this.行政人员信息ToolStripMenuItem,
            this.用户操作ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 28);
            this.toolStripMenuItem1.Text = "基本信息";
            // 
            // 医生信息ToolStripMenuItem
            // 
            this.医生信息ToolStripMenuItem.Name = "医生信息ToolStripMenuItem";
            this.医生信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.医生信息ToolStripMenuItem.Text = "医生信息";
            this.医生信息ToolStripMenuItem.Click += new System.EventHandler(this.医生信息ToolStripMenuItem_Click);
            // 
            // 科室信息ToolStripMenuItem
            // 
            this.科室信息ToolStripMenuItem.Name = "科室信息ToolStripMenuItem";
            this.科室信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.科室信息ToolStripMenuItem.Text = "科室信息";
            this.科室信息ToolStripMenuItem.Click += new System.EventHandler(this.科室信息ToolStripMenuItem_Click);
            // 
            // 行政人员信息ToolStripMenuItem
            // 
            this.行政人员信息ToolStripMenuItem.Name = "行政人员信息ToolStripMenuItem";
            this.行政人员信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.行政人员信息ToolStripMenuItem.Text = "行政人员信息";
            this.行政人员信息ToolStripMenuItem.Click += new System.EventHandler(this.行政人员信息ToolStripMenuItem_Click);
            // 
            // 用户操作ToolStripMenuItem
            // 
            this.用户操作ToolStripMenuItem.Name = "用户操作ToolStripMenuItem";
            this.用户操作ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.用户操作ToolStripMenuItem.Text = "用户操作";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改密码ToolStripMenuItem,
            this.锁定系统ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 28);
            this.toolStripMenuItem2.Text = "用户操作";
            // 
            // 更改密码ToolStripMenuItem
            // 
            this.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            this.更改密码ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.更改密码ToolStripMenuItem.Text = "更改密码";
            this.更改密码ToolStripMenuItem.Click += new System.EventHandler(this.更改密码ToolStripMenuItem_Click);
            // 
            // 锁定系统ToolStripMenuItem
            // 
            this.锁定系统ToolStripMenuItem.Name = "锁定系统ToolStripMenuItem";
            this.锁定系统ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.锁定系统ToolStripMenuItem.Text = "锁定系统";
            this.锁定系统ToolStripMenuItem.Click += new System.EventHandler(this.锁定系统ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(62, 30);
            this.toolStripMenuItem3.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // addStaffButton
            // 
            this.addStaffButton.Image = ((System.Drawing.Image)(resources.GetObject("addStaffButton.Image")));
            this.addStaffButton.Location = new System.Drawing.Point(303, 82);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(168, 161);
            this.addStaffButton.TabIndex = 2;
            this.addStaffButton.Text = "添加行政人员";
            this.addStaffButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(569, 82);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 18);
            this.dateLabel.TabIndex = 4;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(569, 194);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(0, 18);
            this.hourLabel.TabIndex = 5;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 368);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.addDoctorButton);
            this.Controls.Add(this.infoToolStripMenuItem);
            this.MainMenuStrip = this.infoToolStripMenuItem;
            this.Name = "AdminForm";
            this.Text = "管理员视图";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.infoToolStripMenuItem.ResumeLayout(false);
            this.infoToolStripMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 医生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科室信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 行政人员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button addDoctorButton;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label hourLabel;
    }
}