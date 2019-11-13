namespace Project0
{
    partial class DoctorInfoExtendedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorInfoExtendedForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.doctorsBindingSourc = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.doctorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.dept_idTextBox = new System.Windows.Forms.TextBox();
            this.dept_idLabel = new System.Windows.Forms.Label();
            this.dept_nameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.e_mailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.user_nameLabel = new System.Windows.Forms.Label();
            this.user_nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.doctor_surnameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_nameTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.doctor_surnameLabel = new System.Windows.Forms.Label();
            this.doctor_nameLabel = new System.Windows.Forms.Label();
            this.colseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSourc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingNavigator)).BeginInit();
            this.doctorsBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorsBindingNavigator
            // 
            this.doctorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorsBindingNavigator.BindingSource = this.doctorsBindingSourc;
            this.doctorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.doctorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.doctorsBindingNavigatorSaveItem});
            this.doctorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorsBindingNavigator.Name = "doctorsBindingNavigator";
            this.doctorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorsBindingNavigator.Size = new System.Drawing.Size(795, 33);
            this.doctorsBindingNavigator.TabIndex = 0;
            this.doctorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(46, 28);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // doctorsBindingNavigatorSaveItem
            // 
            this.doctorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorsBindingNavigatorSaveItem.Image")));
            this.doctorsBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.doctorsBindingNavigatorSaveItem.Name = "doctorsBindingNavigatorSaveItem";
            this.doctorsBindingNavigatorSaveItem.RightToLeftAutoMirrorImage = true;
            this.doctorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.doctorsBindingNavigatorSaveItem.Text = "保存数据";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deptComboBox);
            this.groupBox1.Controls.Add(this.dept_idTextBox);
            this.groupBox1.Controls.Add(this.dept_idLabel);
            this.groupBox1.Controls.Add(this.dept_nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(430, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "科室";
            // 
            // deptComboBox
            // 
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(133, 72);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(180, 26);
            this.deptComboBox.TabIndex = 7;
            // 
            // dept_idTextBox
            // 
            this.dept_idTextBox.Location = new System.Drawing.Point(133, 30);
            this.dept_idTextBox.Name = "dept_idTextBox";
            this.dept_idTextBox.ReadOnly = true;
            this.dept_idTextBox.Size = new System.Drawing.Size(180, 28);
            this.dept_idTextBox.TabIndex = 7;
            // 
            // dept_idLabel
            // 
            this.dept_idLabel.AutoSize = true;
            this.dept_idLabel.Location = new System.Drawing.Point(20, 33);
            this.dept_idLabel.Name = "dept_idLabel";
            this.dept_idLabel.Size = new System.Drawing.Size(80, 18);
            this.dept_idLabel.TabIndex = 0;
            this.dept_idLabel.Text = "科室编号";
            // 
            // dept_nameLabel
            // 
            this.dept_nameLabel.AutoSize = true;
            this.dept_nameLabel.Location = new System.Drawing.Point(20, 61);
            this.dept_nameLabel.Name = "dept_nameLabel";
            this.dept_nameLabel.Size = new System.Drawing.Size(80, 18);
            this.dept_nameLabel.TabIndex = 1;
            this.dept_nameLabel.Text = "科室名称";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.e_mailTextBox);
            this.groupBox2.Controls.Add(this.e_mailLabel);
            this.groupBox2.Controls.Add(this.passwordLabel);
            this.groupBox2.Controls.Add(this.user_nameLabel);
            this.groupBox2.Controls.Add(this.user_nameTextBox);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Location = new System.Drawing.Point(430, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户设置";
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.Location = new System.Drawing.Point(133, 94);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(180, 28);
            this.e_mailTextBox.TabIndex = 6;
            // 
            // e_mailLabel
            // 
            this.e_mailLabel.AutoSize = true;
            this.e_mailLabel.Location = new System.Drawing.Point(20, 97);
            this.e_mailLabel.Name = "e_mailLabel";
            this.e_mailLabel.Size = new System.Drawing.Size(71, 18);
            this.e_mailLabel.TabIndex = 4;
            this.e_mailLabel.Text = "E-mail:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(20, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(44, 18);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "密码";
            // 
            // user_nameLabel
            // 
            this.user_nameLabel.AutoSize = true;
            this.user_nameLabel.Location = new System.Drawing.Point(20, 24);
            this.user_nameLabel.Name = "user_nameLabel";
            this.user_nameLabel.Size = new System.Drawing.Size(62, 18);
            this.user_nameLabel.TabIndex = 2;
            this.user_nameLabel.Text = "用户名";
            // 
            // user_nameTextBox
            // 
            this.user_nameTextBox.Location = new System.Drawing.Point(133, 21);
            this.user_nameTextBox.Name = "user_nameTextBox";
            this.user_nameTextBox.Size = new System.Drawing.Size(180, 28);
            this.user_nameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(133, 61);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(180, 28);
            this.passwordTextBox.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addressTextBox);
            this.groupBox3.Controls.Add(this.phoneTextBox);
            this.groupBox3.Controls.Add(this.doctor_surnameTextBox);
            this.groupBox3.Controls.Add(this.doctor_nameTextBox);
            this.groupBox3.Controls.Add(this.addressLabel);
            this.groupBox3.Controls.Add(this.phoneLabel);
            this.groupBox3.Controls.Add(this.doctor_surnameLabel);
            this.groupBox3.Controls.Add(this.doctor_nameLabel);
            this.groupBox3.Location = new System.Drawing.Point(34, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 267);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "个人信息";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(137, 185);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(148, 28);
            this.addressTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(137, 138);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(148, 28);
            this.phoneTextBox.TabIndex = 8;
            // 
            // doctor_surnameTextBox
            // 
            this.doctor_surnameTextBox.Location = new System.Drawing.Point(137, 83);
            this.doctor_surnameTextBox.Name = "doctor_surnameTextBox";
            this.doctor_surnameTextBox.Size = new System.Drawing.Size(148, 28);
            this.doctor_surnameTextBox.TabIndex = 7;
            // 
            // doctor_nameTextBox
            // 
            this.doctor_nameTextBox.Location = new System.Drawing.Point(137, 33);
            this.doctor_nameTextBox.Name = "doctor_nameTextBox";
            this.doctor_nameTextBox.Size = new System.Drawing.Size(148, 28);
            this.doctor_nameTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(21, 188);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(44, 18);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "地址";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(21, 138);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(44, 18);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "电话";
            // 
            // doctor_surnameLabel
            // 
            this.doctor_surnameLabel.AutoSize = true;
            this.doctor_surnameLabel.Location = new System.Drawing.Point(19, 86);
            this.doctor_surnameLabel.Name = "doctor_surnameLabel";
            this.doctor_surnameLabel.Size = new System.Drawing.Size(62, 18);
            this.doctor_surnameLabel.TabIndex = 1;
            this.doctor_surnameLabel.Text = "医生姓";
            // 
            // doctor_nameLabel
            // 
            this.doctor_nameLabel.AutoSize = true;
            this.doctor_nameLabel.Location = new System.Drawing.Point(21, 33);
            this.doctor_nameLabel.Name = "doctor_nameLabel";
            this.doctor_nameLabel.Size = new System.Drawing.Size(62, 18);
            this.doctor_nameLabel.TabIndex = 0;
            this.doctor_nameLabel.Text = "医生名";
            // 
            // colseButton
            // 
            this.colseButton.BackColor = System.Drawing.SystemColors.Control;
            this.colseButton.Image = global::Project0.Properties.Resources.closeButton_Image;
            this.colseButton.Location = new System.Drawing.Point(717, 5);
            this.colseButton.Name = "colseButton";
            this.colseButton.Size = new System.Drawing.Size(34, 43);
            this.colseButton.TabIndex = 4;
            this.colseButton.UseVisualStyleBackColor = false;
            this.colseButton.Click += new System.EventHandler(this.colseButton_Click);
            // 
            // DoctorInfoExtendedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(795, 390);
            this.Controls.Add(this.colseButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doctorsBindingNavigator);
            this.Name = "DoctorInfoExtendedForm";
            this.Text = "医生扩展信息 ";
            this.Load += new System.EventHandler(this.DoctorInfoExtendedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSourc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingNavigator)).EndInit();
            this.doctorsBindingNavigator.ResumeLayout(false);
            this.doctorsBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource doctorsBindingSourc;
        private System.Windows.Forms.BindingNavigator doctorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton doctorsBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dept_idLabel;
        private System.Windows.Forms.Label dept_nameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label e_mailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label user_nameLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label doctor_surnameLabel;
        private System.Windows.Forms.Label doctor_nameLabel;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.TextBox dept_idTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox user_nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox doctor_surnameTextBox;
        private System.Windows.Forms.TextBox doctor_nameTextBox;
        private System.Windows.Forms.Button colseButton;
    }
}