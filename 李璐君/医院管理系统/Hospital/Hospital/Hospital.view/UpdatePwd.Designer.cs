namespace Hospital.Hospital.view
{
    partial class UpdatePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePwd));
            this.gbUpdatePwd = new System.Windows.Forms.GroupBox();
            this.txtNewPwd1 = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd1 = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.gbUpdatePwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUpdatePwd
            // 
            this.gbUpdatePwd.BackColor = System.Drawing.Color.White;
            this.gbUpdatePwd.Controls.Add(this.txtNewPwd1);
            this.gbUpdatePwd.Controls.Add(this.txtNewPwd);
            this.gbUpdatePwd.Controls.Add(this.txtOldPwd);
            this.gbUpdatePwd.Controls.Add(this.lblNewPwd1);
            this.gbUpdatePwd.Controls.Add(this.lblNewPwd);
            this.gbUpdatePwd.Controls.Add(this.lblOldPwd);
            this.gbUpdatePwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbUpdatePwd.Location = new System.Drawing.Point(32, 90);
            this.gbUpdatePwd.Name = "gbUpdatePwd";
            this.gbUpdatePwd.Size = new System.Drawing.Size(348, 175);
            this.gbUpdatePwd.TabIndex = 0;
            this.gbUpdatePwd.TabStop = false;
            this.gbUpdatePwd.Text = "密码修改";
            // 
            // txtNewPwd1
            // 
            this.txtNewPwd1.Location = new System.Drawing.Point(168, 112);
            this.txtNewPwd1.Name = "txtNewPwd1";
            this.txtNewPwd1.PasswordChar = '*';
            this.txtNewPwd1.Size = new System.Drawing.Size(100, 26);
            this.txtNewPwd1.TabIndex = 5;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(168, 71);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(100, 26);
            this.txtNewPwd.TabIndex = 4;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(168, 29);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(100, 26);
            this.txtOldPwd.TabIndex = 3;
            // 
            // lblNewPwd1
            // 
            this.lblNewPwd1.AutoSize = true;
            this.lblNewPwd1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewPwd1.Location = new System.Drawing.Point(57, 124);
            this.lblNewPwd1.Name = "lblNewPwd1";
            this.lblNewPwd1.Size = new System.Drawing.Size(77, 14);
            this.lblNewPwd1.TabIndex = 2;
            this.lblNewPwd1.Text = "确认新密码";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewPwd.Location = new System.Drawing.Point(57, 76);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(49, 14);
            this.lblNewPwd.TabIndex = 1;
            this.lblNewPwd.Text = "新密码";
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOldPwd.Location = new System.Drawing.Point(57, 34);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(49, 14);
            this.lblOldPwd.TabIndex = 0;
            this.lblOldPwd.Text = "原密码";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(244, 285);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(67, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.BackColor = System.Drawing.Color.White;
            this.btnCanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanel.Location = new System.Drawing.Point(349, 285);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(67, 23);
            this.btnCanel.TabIndex = 2;
            this.btnCanel.Text = "退出";
            this.btnCanel.UseVisualStyleBackColor = false;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // UpdatePwd
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCanel;
            this.ClientSize = new System.Drawing.Size(428, 320);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbUpdatePwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "密码修改";
            this.gbUpdatePwd.ResumeLayout(false);
            this.gbUpdatePwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUpdatePwd;
        private System.Windows.Forms.Label lblNewPwd1;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblOldPwd;
        private System.Windows.Forms.TextBox txtNewPwd1;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCanel;
    }
}