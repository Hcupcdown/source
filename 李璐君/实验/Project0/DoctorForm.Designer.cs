namespace Project0
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.患者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有患者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.今日患者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户账户ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改用户设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.inspectButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.helloLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.患者ToolStripMenuItem,
            this.用户账户ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 患者ToolStripMenuItem
            // 
            this.患者ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.所有患者ToolStripMenuItem,
            this.今日患者ToolStripMenuItem,
            this.用户账户ToolStripMenuItem1});
            this.患者ToolStripMenuItem.Name = "患者ToolStripMenuItem";
            this.患者ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.患者ToolStripMenuItem.Text = "患者";
            // 
            // 所有患者ToolStripMenuItem
            // 
            this.所有患者ToolStripMenuItem.Name = "所有患者ToolStripMenuItem";
            this.所有患者ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.所有患者ToolStripMenuItem.Text = "所有患者";
            this.所有患者ToolStripMenuItem.Click += new System.EventHandler(this.所有患者ToolStripMenuItem_Click);
            // 
            // 今日患者ToolStripMenuItem
            // 
            this.今日患者ToolStripMenuItem.Name = "今日患者ToolStripMenuItem";
            this.今日患者ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.今日患者ToolStripMenuItem.Text = "今日患者";
            this.今日患者ToolStripMenuItem.Click += new System.EventHandler(this.今日患者ToolStripMenuItem_Click);
            // 
            // 用户账户ToolStripMenuItem1
            // 
            this.用户账户ToolStripMenuItem1.Name = "用户账户ToolStripMenuItem1";
            this.用户账户ToolStripMenuItem1.Size = new System.Drawing.Size(182, 34);
            this.用户账户ToolStripMenuItem1.Text = "用户账户";
            // 
            // 用户账户ToolStripMenuItem
            // 
            this.用户账户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改用户设置ToolStripMenuItem,
            this.我的个人信息ToolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.帮助ToolStripMenuItem1});
            this.用户账户ToolStripMenuItem.Name = "用户账户ToolStripMenuItem";
            this.用户账户ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.用户账户ToolStripMenuItem.Text = "用户账户";
            // 
            // 更改用户设置ToolStripMenuItem
            // 
            this.更改用户设置ToolStripMenuItem.Name = "更改用户设置ToolStripMenuItem";
            this.更改用户设置ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.更改用户设置ToolStripMenuItem.Text = "更改用户设置";
            this.更改用户设置ToolStripMenuItem.Click += new System.EventHandler(this.更改用户设置ToolStripMenuItem_Click);
            // 
            // 我的个人信息ToolStripMenuItem
            // 
            this.我的个人信息ToolStripMenuItem.Name = "我的个人信息ToolStripMenuItem";
            this.我的个人信息ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.我的个人信息ToolStripMenuItem.Text = "我的个人信息";
            this.我的个人信息ToolStripMenuItem.Click += new System.EventHandler(this.我的个人信息ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(218, 34);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inspectButton
            // 
            this.inspectButton.Image = ((System.Drawing.Image)(resources.GetObject("inspectButton.Image")));
            this.inspectButton.Location = new System.Drawing.Point(777, 222);
            this.inspectButton.Name = "inspectButton";
            this.inspectButton.Size = new System.Drawing.Size(159, 148);
            this.inspectButton.TabIndex = 2;
            this.inspectButton.Text = "检查";
            this.inspectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.inspectButton, "检查病人");
            this.inspectButton.UseVisualStyleBackColor = true;
            this.inspectButton.Click += new System.EventHandler(this.inspectButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 519);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "退出";
            this.toolTip1.SetToolTip(this.exitButton, "退出");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(51, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择患者并单击“检查”按钮";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(652, 86);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 18);
            this.dateLabel.TabIndex = 6;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(652, 55);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(0, 18);
            this.hourLabel.TabIndex = 7;
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(46, 55);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(0, 18);
            this.helloLabel.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(674, 358);
            this.dataGridView1.TabIndex = 9;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.inspectButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorForm";
            this.Text = "医生视图";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 患者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有患者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 今日患者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户账户ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 用户账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改用户设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button inspectButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}