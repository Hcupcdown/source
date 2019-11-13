namespace Hospital.Hospital.view
{
    partial class frmMenZhenKeShi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenZhenKeShi));
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnDaYin = new System.Windows.Forms.Button();
            this.btnShuaXin = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbXinXi = new System.Windows.Forms.GroupBox();
            this.txtFuZeRen = new System.Windows.Forms.TextBox();
            this.txtGuaHaoFei = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGuaHaoFei = new System.Windows.Forms.Label();
            this.lblFuZeRen = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbKeShi = new System.Windows.Forms.GroupBox();
            this.dgdInfo = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbXinXi.SuspendLayout();
            this.gbKeShi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Location = new System.Drawing.Point(604, 470);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(66, 23);
            this.btnCanel.TabIndex = 16;
            this.btnCanel.Text = "关闭";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnDaYin
            // 
            this.btnDaYin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaYin.Location = new System.Drawing.Point(516, 470);
            this.btnDaYin.Name = "btnDaYin";
            this.btnDaYin.Size = new System.Drawing.Size(66, 23);
            this.btnDaYin.TabIndex = 15;
            this.btnDaYin.Text = "打印";
            this.btnDaYin.UseVisualStyleBackColor = true;
            this.btnDaYin.Click += new System.EventHandler(this.btnDaYin_Click);
            // 
            // btnShuaXin
            // 
            this.btnShuaXin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuaXin.Location = new System.Drawing.Point(428, 470);
            this.btnShuaXin.Name = "btnShuaXin";
            this.btnShuaXin.Size = new System.Drawing.Size(66, 23);
            this.btnShuaXin.TabIndex = 14;
            this.btnShuaXin.Text = "刷新";
            this.btnShuaXin.UseVisualStyleBackColor = true;
            this.btnShuaXin.Click += new System.EventHandler(this.btnShuaXin_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(340, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(252, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(5, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 10);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // gbXinXi
            // 
            this.gbXinXi.BackColor = System.Drawing.Color.Transparent;
            this.gbXinXi.Controls.Add(this.txtFuZeRen);
            this.gbXinXi.Controls.Add(this.txtGuaHaoFei);
            this.gbXinXi.Controls.Add(this.txtName);
            this.gbXinXi.Controls.Add(this.lblGuaHaoFei);
            this.gbXinXi.Controls.Add(this.lblFuZeRen);
            this.gbXinXi.Controls.Add(this.lblName);
            this.gbXinXi.Location = new System.Drawing.Point(400, 175);
            this.gbXinXi.Name = "gbXinXi";
            this.gbXinXi.Size = new System.Drawing.Size(286, 212);
            this.gbXinXi.TabIndex = 10;
            this.gbXinXi.TabStop = false;
            this.gbXinXi.Text = "科室信息";
            // 
            // txtFuZeRen
            // 
            this.txtFuZeRen.Location = new System.Drawing.Point(132, 99);
            this.txtFuZeRen.Name = "txtFuZeRen";
            this.txtFuZeRen.Size = new System.Drawing.Size(139, 21);
            this.txtFuZeRen.TabIndex = 8;
            // 
            // txtGuaHaoFei
            // 
            this.txtGuaHaoFei.Location = new System.Drawing.Point(132, 149);
            this.txtGuaHaoFei.Name = "txtGuaHaoFei";
            this.txtGuaHaoFei.Size = new System.Drawing.Size(139, 21);
            this.txtGuaHaoFei.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 21);
            this.txtName.TabIndex = 6;
            // 
            // lblGuaHaoFei
            // 
            this.lblGuaHaoFei.AutoSize = true;
            this.lblGuaHaoFei.Location = new System.Drawing.Point(28, 152);
            this.lblGuaHaoFei.Name = "lblGuaHaoFei";
            this.lblGuaHaoFei.Size = new System.Drawing.Size(53, 12);
            this.lblGuaHaoFei.TabIndex = 2;
            this.lblGuaHaoFei.Text = "挂号费：";
            // 
            // lblFuZeRen
            // 
            this.lblFuZeRen.AutoSize = true;
            this.lblFuZeRen.Location = new System.Drawing.Point(28, 102);
            this.lblFuZeRen.Name = "lblFuZeRen";
            this.lblFuZeRen.Size = new System.Drawing.Size(53, 12);
            this.lblFuZeRen.TabIndex = 1;
            this.lblFuZeRen.Text = "负责人：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "科室名称：";
            // 
            // gbKeShi
            // 
            this.gbKeShi.BackColor = System.Drawing.Color.Transparent;
            this.gbKeShi.Controls.Add(this.dgdInfo);
            this.gbKeShi.Location = new System.Drawing.Point(12, 136);
            this.gbKeShi.Name = "gbKeShi";
            this.gbKeShi.Size = new System.Drawing.Size(369, 309);
            this.gbKeShi.TabIndex = 9;
            this.gbKeShi.TabStop = false;
            this.gbKeShi.Text = "当前有几条科室记录";
            // 
            // dgdInfo
            // 
            this.dgdInfo.AllowUserToAddRows = false;
            this.dgdInfo.AllowUserToDeleteRows = false;
            this.dgdInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgdInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdInfo.Location = new System.Drawing.Point(3, 17);
            this.dgdInfo.Name = "dgdInfo";
            this.dgdInfo.ReadOnly = true;
            this.dgdInfo.RowTemplate.Height = 23;
            this.dgdInfo.Size = new System.Drawing.Size(363, 289);
            this.dgdInfo.TabIndex = 0;
            this.dgdInfo.SelectionChanged += new System.EventHandler(this.dgdInfo_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(161, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMenZhenKeShi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 509);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnDaYin);
            this.Controls.Add(this.btnShuaXin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbXinXi);
            this.Controls.Add(this.gbKeShi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenZhenKeShi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "科室管理";
            this.Load += new System.EventHandler(this.frmMenZhenKeShi_Load);
            this.gbXinXi.ResumeLayout(false);
            this.gbXinXi.PerformLayout();
            this.gbKeShi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnDaYin;
        private System.Windows.Forms.Button btnShuaXin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbXinXi;
        private System.Windows.Forms.TextBox txtGuaHaoFei;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGuaHaoFei;
        private System.Windows.Forms.Label lblFuZeRen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbKeShi;
        private System.Windows.Forms.DataGridView dgdInfo;
        private System.Windows.Forms.TextBox txtFuZeRen;
        private System.Windows.Forms.Button btnAdd;
    }
}