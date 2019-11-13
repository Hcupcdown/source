namespace Project0
{
    partial class DoctorPersonalInfoForm
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorPersonalInfoLabel = new System.Windows.Forms.Label();
            this.doctor_idLabel = new System.Windows.Forms.Label();
            this.doctor_nameLabel = new System.Windows.Forms.Label();
            this.doctor_surnameLabel = new System.Windows.Forms.Label();
            this.dept_nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.doctor_idTextBox = new System.Windows.Forms.TextBox();
            this.doctor_nameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_surnameTextBox = new System.Windows.Forms.TextBox();
            this.dept_nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(Project0.Doctors);
            // 
            // doctorPersonalInfoLabel
            // 
            this.doctorPersonalInfoLabel.AutoSize = true;
            this.doctorPersonalInfoLabel.Location = new System.Drawing.Point(118, 39);
            this.doctorPersonalInfoLabel.Name = "doctorPersonalInfoLabel";
            this.doctorPersonalInfoLabel.Size = new System.Drawing.Size(116, 18);
            this.doctorPersonalInfoLabel.TabIndex = 0;
            this.doctorPersonalInfoLabel.Text = "医生个人信息";
            // 
            // doctor_idLabel
            // 
            this.doctor_idLabel.AutoSize = true;
            this.doctor_idLabel.Location = new System.Drawing.Point(64, 81);
            this.doctor_idLabel.Name = "doctor_idLabel";
            this.doctor_idLabel.Size = new System.Drawing.Size(62, 18);
            this.doctor_idLabel.TabIndex = 1;
            this.doctor_idLabel.Text = "医生ID";
            // 
            // doctor_nameLabel
            // 
            this.doctor_nameLabel.AutoSize = true;
            this.doctor_nameLabel.Location = new System.Drawing.Point(64, 123);
            this.doctor_nameLabel.Name = "doctor_nameLabel";
            this.doctor_nameLabel.Size = new System.Drawing.Size(62, 18);
            this.doctor_nameLabel.TabIndex = 2;
            this.doctor_nameLabel.Text = "医生名";
            // 
            // doctor_surnameLabel
            // 
            this.doctor_surnameLabel.AutoSize = true;
            this.doctor_surnameLabel.Location = new System.Drawing.Point(64, 162);
            this.doctor_surnameLabel.Name = "doctor_surnameLabel";
            this.doctor_surnameLabel.Size = new System.Drawing.Size(62, 18);
            this.doctor_surnameLabel.TabIndex = 3;
            this.doctor_surnameLabel.Text = "医生姓";
            // 
            // dept_nameLabel
            // 
            this.dept_nameLabel.AutoSize = true;
            this.dept_nameLabel.Location = new System.Drawing.Point(64, 203);
            this.dept_nameLabel.Name = "dept_nameLabel";
            this.dept_nameLabel.Size = new System.Drawing.Size(62, 18);
            this.dept_nameLabel.TabIndex = 4;
            this.dept_nameLabel.Text = "科室名";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(64, 240);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(44, 18);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "电话";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(64, 277);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(44, 18);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "地址";
            // 
            // doctor_idTextBox
            // 
            this.doctor_idTextBox.Location = new System.Drawing.Point(167, 81);
            this.doctor_idTextBox.Name = "doctor_idTextBox";
            this.doctor_idTextBox.ReadOnly = true;
            this.doctor_idTextBox.Size = new System.Drawing.Size(187, 28);
            this.doctor_idTextBox.TabIndex = 7;
            // 
            // doctor_nameTextBox
            // 
            this.doctor_nameTextBox.Location = new System.Drawing.Point(167, 123);
            this.doctor_nameTextBox.Name = "doctor_nameTextBox";
            this.doctor_nameTextBox.ReadOnly = true;
            this.doctor_nameTextBox.Size = new System.Drawing.Size(187, 28);
            this.doctor_nameTextBox.TabIndex = 8;
            // 
            // doctor_surnameTextBox
            // 
            this.doctor_surnameTextBox.Location = new System.Drawing.Point(167, 162);
            this.doctor_surnameTextBox.Name = "doctor_surnameTextBox";
            this.doctor_surnameTextBox.ReadOnly = true;
            this.doctor_surnameTextBox.Size = new System.Drawing.Size(187, 28);
            this.doctor_surnameTextBox.TabIndex = 9;
            // 
            // dept_nameTextBox
            // 
            this.dept_nameTextBox.Location = new System.Drawing.Point(167, 200);
            this.dept_nameTextBox.Name = "dept_nameTextBox";
            this.dept_nameTextBox.ReadOnly = true;
            this.dept_nameTextBox.Size = new System.Drawing.Size(187, 28);
            this.dept_nameTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(167, 240);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(187, 28);
            this.phoneTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(167, 277);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(187, 28);
            this.addressTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(279, 363);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "关闭";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DoctorPersonalInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 449);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.dept_nameTextBox);
            this.Controls.Add(this.doctor_surnameTextBox);
            this.Controls.Add(this.doctor_nameTextBox);
            this.Controls.Add(this.doctor_idTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.dept_nameLabel);
            this.Controls.Add(this.doctor_surnameLabel);
            this.Controls.Add(this.doctor_nameLabel);
            this.Controls.Add(this.doctor_idLabel);
            this.Controls.Add(this.doctorPersonalInfoLabel);
            this.Name = "DoctorPersonalInfoForm";
            this.Text = "医生个人信息";
            this.Load += new System.EventHandler(this.DoctorPersonalInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Label doctorPersonalInfoLabel;
        private System.Windows.Forms.Label doctor_idLabel;
        private System.Windows.Forms.Label doctor_nameLabel;
        private System.Windows.Forms.Label doctor_surnameLabel;
        private System.Windows.Forms.Label dept_nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox doctor_idTextBox;
        private System.Windows.Forms.TextBox doctor_nameTextBox;
        private System.Windows.Forms.TextBox doctor_surnameTextBox;
        private System.Windows.Forms.TextBox dept_nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
    }
}