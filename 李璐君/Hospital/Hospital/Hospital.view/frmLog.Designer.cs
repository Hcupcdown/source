namespace Hospital.Hospital.view
{
    partial class frmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.dgdLogInfo = new System.Windows.Forms.DataGridView();
            this.gbLogSelect = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.cbTiaoJian = new System.Windows.Forms.ComboBox();
            this.lblTiaoJian = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdLogInfo)).BeginInit();
            this.gbLogSelect.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdLogInfo
            // 
            this.dgdLogInfo.AllowUserToAddRows = false;
            this.dgdLogInfo.AllowUserToDeleteRows = false;
            this.dgdLogInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgdLogInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdLogInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdLogInfo.Location = new System.Drawing.Point(3, 17);
            this.dgdLogInfo.Name = "dgdLogInfo";
            this.dgdLogInfo.ReadOnly = true;
            this.dgdLogInfo.RowTemplate.Height = 23;
            this.dgdLogInfo.Size = new System.Drawing.Size(402, 235);
            this.dgdLogInfo.TabIndex = 0;
            // 
            // gbLogSelect
            // 
            this.gbLogSelect.BackColor = System.Drawing.Color.White;
            this.gbLogSelect.Controls.Add(this.lblUserName);
            this.gbLogSelect.Controls.Add(this.cbUserName);
            this.gbLogSelect.Controls.Add(this.cbTiaoJian);
            this.gbLogSelect.Controls.Add(this.lblTiaoJian);
            this.gbLogSelect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbLogSelect.Location = new System.Drawing.Point(418, 122);
            this.gbLogSelect.Name = "gbLogSelect";
            this.gbLogSelect.Size = new System.Drawing.Size(272, 145);
            this.gbLogSelect.TabIndex = 1;
            this.gbLogSelect.TabStop = false;
            this.gbLogSelect.Text = "日志查询";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(19, 97);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "用户名：";
            // 
            // cbUserName
            // 
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Location = new System.Drawing.Point(97, 90);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(146, 24);
            this.cbUserName.TabIndex = 5;
            // 
            // cbTiaoJian
            // 
            this.cbTiaoJian.FormattingEnabled = true;
            this.cbTiaoJian.Items.AddRange(new object[] {
            "按用户名查询",
            "查询所有"});
            this.cbTiaoJian.Location = new System.Drawing.Point(97, 34);
            this.cbTiaoJian.Name = "cbTiaoJian";
            this.cbTiaoJian.Size = new System.Drawing.Size(146, 24);
            this.cbTiaoJian.TabIndex = 1;
            this.cbTiaoJian.SelectedIndexChanged += new System.EventHandler(this.cbTiaoJian_SelectedIndexChanged);
            // 
            // lblTiaoJian
            // 
            this.lblTiaoJian.AutoSize = true;
            this.lblTiaoJian.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTiaoJian.Location = new System.Drawing.Point(19, 42);
            this.lblTiaoJian.Name = "lblTiaoJian";
            this.lblTiaoJian.Size = new System.Drawing.Size(65, 12);
            this.lblTiaoJian.TabIndex = 0;
            this.lblTiaoJian.Text = "选择条件：";
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(537, 302);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(65, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCanel.Location = new System.Drawing.Point(623, 302);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(65, 23);
            this.btnCanel.TabIndex = 4;
            this.btnCanel.Text = "关闭";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.White;
            this.gbInfo.Controls.Add(this.dgdLogInfo);
            this.gbInfo.Location = new System.Drawing.Point(4, 105);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(408, 255);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "查询结果";
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbLogSelect);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "日志查询";
            this.Load += new System.EventHandler(this.frmLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdLogInfo)).EndInit();
            this.gbLogSelect.ResumeLayout(false);
            this.gbLogSelect.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdLogInfo;
        private System.Windows.Forms.GroupBox gbLogSelect;
        private System.Windows.Forms.Label lblTiaoJian;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbTiaoJian;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbInfo;
    }
}