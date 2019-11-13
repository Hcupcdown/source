namespace Hospital.Hospital.view
{
    partial class frmAddKeShi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddKeShi));
            this.gbXinXi = new System.Windows.Forms.GroupBox();
            this.txtFuZeRen = new System.Windows.Forms.TextBox();
            this.txtGuaHaoFei = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGuaHaoFei = new System.Windows.Forms.Label();
            this.lblFuZeRen = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.gbXinXi.SuspendLayout();
            this.SuspendLayout();
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
            this.gbXinXi.Location = new System.Drawing.Point(27, 83);
            this.gbXinXi.Name = "gbXinXi";
            this.gbXinXi.Size = new System.Drawing.Size(348, 206);
            this.gbXinXi.TabIndex = 11;
            this.gbXinXi.TabStop = false;
            this.gbXinXi.Text = "科室信息";
            // 
            // txtFuZeRen
            // 
            this.txtFuZeRen.Location = new System.Drawing.Point(163, 94);
            this.txtFuZeRen.Name = "txtFuZeRen";
            this.txtFuZeRen.Size = new System.Drawing.Size(139, 21);
            this.txtFuZeRen.TabIndex = 8;
            // 
            // txtGuaHaoFei
            // 
            this.txtGuaHaoFei.Location = new System.Drawing.Point(163, 144);
            this.txtGuaHaoFei.Name = "txtGuaHaoFei";
            this.txtGuaHaoFei.Size = new System.Drawing.Size(139, 21);
            this.txtGuaHaoFei.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 21);
            this.txtName.TabIndex = 6;
            // 
            // lblGuaHaoFei
            // 
            this.lblGuaHaoFei.AutoSize = true;
            this.lblGuaHaoFei.Location = new System.Drawing.Point(59, 147);
            this.lblGuaHaoFei.Name = "lblGuaHaoFei";
            this.lblGuaHaoFei.Size = new System.Drawing.Size(53, 12);
            this.lblGuaHaoFei.TabIndex = 2;
            this.lblGuaHaoFei.Text = "挂号费：";
            // 
            // lblFuZeRen
            // 
            this.lblFuZeRen.AutoSize = true;
            this.lblFuZeRen.Location = new System.Drawing.Point(59, 97);
            this.lblFuZeRen.Name = "lblFuZeRen";
            this.lblFuZeRen.Size = new System.Drawing.Size(53, 12);
            this.lblFuZeRen.TabIndex = 1;
            this.lblFuZeRen.Text = "负责人：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "科室名称：";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(242, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Location = new System.Drawing.Point(318, 299);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(57, 23);
            this.btnCanel.TabIndex = 13;
            this.btnCanel.Text = "取消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // frmAddKeShi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 327);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbXinXi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddKeShi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加科室信息";
            this.gbXinXi.ResumeLayout(false);
            this.gbXinXi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbXinXi;
        private System.Windows.Forms.TextBox txtFuZeRen;
        private System.Windows.Forms.TextBox txtGuaHaoFei;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGuaHaoFei;
        private System.Windows.Forms.Label lblFuZeRen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCanel;
    }
}