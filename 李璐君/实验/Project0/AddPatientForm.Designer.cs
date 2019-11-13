namespace Project0
{
    partial class AddPatientForm
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birth_placeLabel = new System.Windows.Forms.Label();
            this.father_nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.ssnTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.birth_placeTextBox = new System.Windows.Forms.TextBox();
            this.father_nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.exiButton = new System.Windows.Forms.Button();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageLabel = new System.Windows.Forms.Label();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inspectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientAdmissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientAdmissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(70, 39);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(479, 32);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "请在添加病人之前，先校验病人记录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ssn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ssn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "病人名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "病人姓";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "出生日期";
            // 
            // birth_placeLabel
            // 
            this.birth_placeLabel.AutoSize = true;
            this.birth_placeLabel.Location = new System.Drawing.Point(70, 367);
            this.birth_placeLabel.Name = "birth_placeLabel";
            this.birth_placeLabel.Size = new System.Drawing.Size(62, 18);
            this.birth_placeLabel.TabIndex = 7;
            this.birth_placeLabel.Text = "出生地";
            // 
            // father_nameLabel
            // 
            this.father_nameLabel.AutoSize = true;
            this.father_nameLabel.Location = new System.Drawing.Point(70, 403);
            this.father_nameLabel.Name = "father_nameLabel";
            this.father_nameLabel.Size = new System.Drawing.Size(80, 18);
            this.father_nameLabel.TabIndex = 8;
            this.father_nameLabel.Text = "父亲姓名";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(70, 439);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(44, 18);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "电话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "检查日期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "科室";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "医生";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkButton);
            this.groupBox1.Controls.Add(this.ssnTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(75, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 80);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "根据Ssn号校验病人记录";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(196, 48);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(102, 32);
            this.checkButton.TabIndex = 23;
            this.checkButton.Text = "校验";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(118, 18);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(180, 28);
            this.ssnTextBox.TabIndex = 15;
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexComboBox.Location = new System.Drawing.Point(183, 297);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(204, 26);
            this.sexComboBox.TabIndex = 18;
            // 
            // ssnTextBox1
            // 
            this.ssnTextBox1.Location = new System.Drawing.Point(183, 181);
            this.ssnTextBox1.Multiline = true;
            this.ssnTextBox1.Name = "ssnTextBox1";
            this.ssnTextBox1.Size = new System.Drawing.Size(204, 28);
            this.ssnTextBox1.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(183, 263);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 28);
            this.nameTextBox.TabIndex = 17;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(183, 222);
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(204, 28);
            this.surnameTextBox.TabIndex = 18;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // birth_placeTextBox
            // 
            this.birth_placeTextBox.Location = new System.Drawing.Point(183, 357);
            this.birth_placeTextBox.Multiline = true;
            this.birth_placeTextBox.Name = "birth_placeTextBox";
            this.birth_placeTextBox.Size = new System.Drawing.Size(204, 28);
            this.birth_placeTextBox.TabIndex = 19;
            // 
            // father_nameTextBox
            // 
            this.father_nameTextBox.Location = new System.Drawing.Point(183, 399);
            this.father_nameTextBox.Multiline = true;
            this.father_nameTextBox.Name = "father_nameTextBox";
            this.father_nameTextBox.Size = new System.Drawing.Size(204, 28);
            this.father_nameTextBox.TabIndex = 20;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(183, 435);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(204, 28);
            this.phoneTextBox.TabIndex = 21;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(183, 471);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(204, 97);
            this.addressTextBox.TabIndex = 22;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataSource = this.doctorsBindingSource3;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(609, 260);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(141, 26);
            this.doctorComboBox.TabIndex = 16;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // doctorsBindingSource2
            // 
            this.doctorsBindingSource2.DataSource = typeof(Project0.Doctors);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(519, 363);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 50);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exiButton
            // 
            this.exiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exiButton.ForeColor = System.Drawing.Color.Red;
            this.exiButton.Location = new System.Drawing.Point(688, 363);
            this.exiButton.Name = "exiButton";
            this.exiButton.Size = new System.Drawing.Size(112, 50);
            this.exiButton.TabIndex = 25;
            this.exiButton.Text = "关闭";
            this.exiButton.UseVisualStyleBackColor = true;
            this.exiButton.Click += new System.EventHandler(this.exiButton_Click);
            // 
            // deptComboBox
            // 
            this.deptComboBox.DataSource = this.departmentsBindingSource;
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(609, 219);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(137, 26);
            this.deptComboBox.TabIndex = 27;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataSource = typeof(Project0.Departments);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(0, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 18);
            this.messageLabel.TabIndex = 29;
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(183, 329);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(204, 28);
            this.birth_dateDateTimePicker.TabIndex = 30;
            // 
            // inspectionDateTimePicker
            // 
            this.inspectionDateTimePicker.Location = new System.Drawing.Point(609, 174);
            this.inspectionDateTimePicker.Name = "inspectionDateTimePicker";
            this.inspectionDateTimePicker.Size = new System.Drawing.Size(137, 28);
            this.inspectionDateTimePicker.TabIndex = 31;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(Project0.Patients);
            // 
            // patientAdmissionsBindingSource
            // 
            this.patientAdmissionsBindingSource.DataMember = "Patient_Admissions";
            this.patientAdmissionsBindingSource.DataSource = this.doctorsBindingSource1;
            this.patientAdmissionsBindingSource.CurrentChanged += new System.EventHandler(this.patientAdmissionsBindingSource_CurrentChanged);
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataSource = typeof(Project0.Doctors);
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataSource = typeof(Project0.Doctors);
            // 
            // doctorsBindingSource3
            // 
            this.doctorsBindingSource3.DataSource = typeof(Project0.Doctors);
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(992, 620);
            this.Controls.Add(this.inspectionDateTimePicker);
            this.Controls.Add(this.birth_dateDateTimePicker);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.deptComboBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.exiButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.father_nameTextBox);
            this.Controls.Add(this.birth_placeTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ssnTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.father_nameLabel);
            this.Controls.Add(this.birth_placeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstLabel);
            this.Name = "AddPatientForm";
            this.Text = "添加病人";
            this.Load += new System.EventHandler(this.AddPatientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientAdmissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label birth_placeLabel;
        private System.Windows.Forms.Label father_nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox ssnTextBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox birth_placeTextBox;
        private System.Windows.Forms.TextBox father_nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exiButton;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker inspectionDateTimePicker;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private System.Windows.Forms.BindingSource doctorsBindingSource2;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource patientAdmissionsBindingSource;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.BindingSource doctorsBindingSource3;
    }
}