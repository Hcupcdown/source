namespace Hospital.Hospital.view
{
    partial class frmGuaHaoMingXiBiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuaHaoMingXiBiao));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dgdGuaHaoMingXi = new System.Windows.Forms.DataGridView();
            this.lblGuaHaoFei = new System.Windows.Forms.Label();
            this.lblZhenDuanFei = new System.Windows.Forms.Label();
            this.lblHeJi = new System.Windows.Forms.Label();
            this.txtGuaHaoFei = new System.Windows.Forms.TextBox();
            this.txtZhenDuanFei = new System.Windows.Forms.TextBox();
            this.txtHeJi = new System.Windows.Forms.TextBox();
            this.btnShuaXin = new System.Windows.Forms.Button();
            this.btnDaYin = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGuaHaoMingXi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(731, 73);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // dgdGuaHaoMingXi
            // 
            this.dgdGuaHaoMingXi.AllowUserToAddRows = false;
            this.dgdGuaHaoMingXi.AllowUserToDeleteRows = false;
            this.dgdGuaHaoMingXi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdGuaHaoMingXi.BackgroundColor = System.Drawing.Color.White;
            this.dgdGuaHaoMingXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdGuaHaoMingXi.Location = new System.Drawing.Point(0, 74);
            this.dgdGuaHaoMingXi.Name = "dgdGuaHaoMingXi";
            this.dgdGuaHaoMingXi.ReadOnly = true;
            this.dgdGuaHaoMingXi.RowTemplate.Height = 23;
            this.dgdGuaHaoMingXi.Size = new System.Drawing.Size(731, 267);
            this.dgdGuaHaoMingXi.TabIndex = 1;
            this.dgdGuaHaoMingXi.SelectionChanged += new System.EventHandler(this.dgdGuaHaoMingXi_SelectionChanged);
            // 
            // lblGuaHaoFei
            // 
            this.lblGuaHaoFei.AutoSize = true;
            this.lblGuaHaoFei.Location = new System.Drawing.Point(12, 374);
            this.lblGuaHaoFei.Name = "lblGuaHaoFei";
            this.lblGuaHaoFei.Size = new System.Drawing.Size(53, 12);
            this.lblGuaHaoFei.TabIndex = 2;
            this.lblGuaHaoFei.Text = "挂号费：";
            // 
            // lblZhenDuanFei
            // 
            this.lblZhenDuanFei.AutoSize = true;
            this.lblZhenDuanFei.Location = new System.Drawing.Point(147, 374);
            this.lblZhenDuanFei.Name = "lblZhenDuanFei";
            this.lblZhenDuanFei.Size = new System.Drawing.Size(53, 12);
            this.lblZhenDuanFei.TabIndex = 3;
            this.lblZhenDuanFei.Text = "诊断费：";
            // 
            // lblHeJi
            // 
            this.lblHeJi.AutoSize = true;
            this.lblHeJi.Location = new System.Drawing.Point(283, 374);
            this.lblHeJi.Name = "lblHeJi";
            this.lblHeJi.Size = new System.Drawing.Size(41, 12);
            this.lblHeJi.TabIndex = 4;
            this.lblHeJi.Text = "合计：";
            // 
            // txtGuaHaoFei
            // 
            this.txtGuaHaoFei.BackColor = System.Drawing.Color.White;
            this.txtGuaHaoFei.Enabled = false;
            this.txtGuaHaoFei.Location = new System.Drawing.Point(71, 369);
            this.txtGuaHaoFei.Name = "txtGuaHaoFei";
            this.txtGuaHaoFei.Size = new System.Drawing.Size(70, 21);
            this.txtGuaHaoFei.TabIndex = 5;
            // 
            // txtZhenDuanFei
            // 
            this.txtZhenDuanFei.BackColor = System.Drawing.Color.White;
            this.txtZhenDuanFei.Enabled = false;
            this.txtZhenDuanFei.Location = new System.Drawing.Point(206, 369);
            this.txtZhenDuanFei.Name = "txtZhenDuanFei";
            this.txtZhenDuanFei.Size = new System.Drawing.Size(70, 21);
            this.txtZhenDuanFei.TabIndex = 6;
            // 
            // txtHeJi
            // 
            this.txtHeJi.BackColor = System.Drawing.Color.White;
            this.txtHeJi.Enabled = false;
            this.txtHeJi.Location = new System.Drawing.Point(330, 369);
            this.txtHeJi.Name = "txtHeJi";
            this.txtHeJi.Size = new System.Drawing.Size(70, 21);
            this.txtHeJi.TabIndex = 7;
            // 
            // btnShuaXin
            // 
            this.btnShuaXin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuaXin.Location = new System.Drawing.Point(470, 367);
            this.btnShuaXin.Name = "btnShuaXin";
            this.btnShuaXin.Size = new System.Drawing.Size(64, 23);
            this.btnShuaXin.TabIndex = 8;
            this.btnShuaXin.Text = "刷新";
            this.btnShuaXin.UseVisualStyleBackColor = true;
            this.btnShuaXin.Click += new System.EventHandler(this.btnShuaXin_Click);
            // 
            // btnDaYin
            // 
            this.btnDaYin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaYin.Location = new System.Drawing.Point(557, 367);
            this.btnDaYin.Name = "btnDaYin";
            this.btnDaYin.Size = new System.Drawing.Size(64, 23);
            this.btnDaYin.TabIndex = 9;
            this.btnDaYin.Text = "打印";
            this.btnDaYin.UseVisualStyleBackColor = true;
            this.btnDaYin.Click += new System.EventHandler(this.btnDaYin_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Location = new System.Drawing.Point(641, 367);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(64, 23);
            this.btnCanel.TabIndex = 10;
            this.btnCanel.Text = "关闭";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // frmGuaHaoMingXiBiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 408);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnDaYin);
            this.Controls.Add(this.btnShuaXin);
            this.Controls.Add(this.txtHeJi);
            this.Controls.Add(this.txtZhenDuanFei);
            this.Controls.Add(this.txtGuaHaoFei);
            this.Controls.Add(this.lblHeJi);
            this.Controls.Add(this.lblZhenDuanFei);
            this.Controls.Add(this.lblGuaHaoFei);
            this.Controls.Add(this.dgdGuaHaoMingXi);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuaHaoMingXiBiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "挂号明细表";
            this.Load += new System.EventHandler(this.frmGuaHaoMingXiBiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGuaHaoMingXi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DataGridView dgdGuaHaoMingXi;
        private System.Windows.Forms.Label lblGuaHaoFei;
        private System.Windows.Forms.Label lblZhenDuanFei;
        private System.Windows.Forms.Label lblHeJi;
        private System.Windows.Forms.TextBox txtGuaHaoFei;
        private System.Windows.Forms.TextBox txtZhenDuanFei;
        private System.Windows.Forms.TextBox txtHeJi;
        private System.Windows.Forms.Button btnShuaXin;
        private System.Windows.Forms.Button btnDaYin;
        private System.Windows.Forms.Button btnCanel;
    }
}