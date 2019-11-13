namespace Project0
{
    partial class InspectPatientForm
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
            this.patient_AdmissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inspectLabe = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.birth_dateLabel = new System.Windows.Forms.Label();
            this.blood_analysisLabel = new System.Windows.Forms.Label();
            this.urianalysisLabel = new System.Windows.Forms.Label();
            this.xrayLabel = new System.Windows.Forms.Label();
            this.date_inLabel = new System.Windows.Forms.Label();
            this.complaintLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.prescriptionLabel = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateTextBox = new System.Windows.Forms.TextBox();
            this.date_inTextBox = new System.Windows.Forms.TextBox();
            this.complaintTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patient_AdmissionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // patient_AdmissionBindingSource
            // 
            this.patient_AdmissionBindingSource.DataSource = typeof(Project0.Patient_Admissions);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.birth_dateTextBox);
            this.groupBox1.Controls.Add(this.sexTextBox);
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(this.ssnTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.birth_dateLabel);
            this.groupBox1.Controls.Add(this.sexLabel);
            this.groupBox1.Controls.Add(this.surnameLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.ssnLabel);
            this.groupBox1.Location = new System.Drawing.Point(38, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "患者信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xrayLabel);
            this.groupBox2.Controls.Add(this.urianalysisLabel);
            this.groupBox2.Controls.Add(this.blood_analysisLabel);
            this.groupBox2.Location = new System.Drawing.Point(76, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 138);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分  析";
            // 
            // inspectLabe
            // 
            this.inspectLabe.AutoSize = true;
            this.inspectLabe.Location = new System.Drawing.Point(33, 42);
            this.inspectLabe.Name = "inspectLabe";
            this.inspectLabe.Size = new System.Drawing.Size(62, 18);
            this.inspectLabe.TabIndex = 1;
            this.inspectLabe.Text = "检查表";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(22, 24);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(35, 18);
            this.ssnLabel.TabIndex = 2;
            this.ssnLabel.Text = "Ssn";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 18);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "患者名";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(22, 95);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(62, 18);
            this.surnameLabel.TabIndex = 4;
            this.surnameLabel.Text = "患者性";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(22, 138);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(44, 18);
            this.sexLabel.TabIndex = 5;
            this.sexLabel.Text = "性别";
            // 
            // birth_dateLabel
            // 
            this.birth_dateLabel.AutoSize = true;
            this.birth_dateLabel.Location = new System.Drawing.Point(22, 181);
            this.birth_dateLabel.Name = "birth_dateLabel";
            this.birth_dateLabel.Size = new System.Drawing.Size(80, 18);
            this.birth_dateLabel.TabIndex = 6;
            this.birth_dateLabel.Text = "出生日期";
            // 
            // blood_analysisLabel
            // 
            this.blood_analysisLabel.AutoSize = true;
            this.blood_analysisLabel.Location = new System.Drawing.Point(164, 18);
            this.blood_analysisLabel.Name = "blood_analysisLabel";
            this.blood_analysisLabel.Size = new System.Drawing.Size(80, 18);
            this.blood_analysisLabel.TabIndex = 7;
            this.blood_analysisLabel.Text = "血液分析";
            // 
            // urianalysisLabel
            // 
            this.urianalysisLabel.AutoSize = true;
            this.urianalysisLabel.Location = new System.Drawing.Point(164, 61);
            this.urianalysisLabel.Name = "urianalysisLabel";
            this.urianalysisLabel.Size = new System.Drawing.Size(62, 18);
            this.urianalysisLabel.TabIndex = 8;
            this.urianalysisLabel.Text = "尿分析";
            // 
            // xrayLabel
            // 
            this.xrayLabel.AutoSize = true;
            this.xrayLabel.Location = new System.Drawing.Point(164, 101);
            this.xrayLabel.Name = "xrayLabel";
            this.xrayLabel.Size = new System.Drawing.Size(53, 18);
            this.xrayLabel.TabIndex = 9;
            this.xrayLabel.Text = "X射线";
            // 
            // date_inLabel
            // 
            this.date_inLabel.AutoSize = true;
            this.date_inLabel.Location = new System.Drawing.Point(404, 83);
            this.date_inLabel.Name = "date_inLabel";
            this.date_inLabel.Size = new System.Drawing.Size(80, 18);
            this.date_inLabel.TabIndex = 10;
            this.date_inLabel.Text = "检查日期";
            // 
            // complaintLabel
            // 
            this.complaintLabel.AutoSize = true;
            this.complaintLabel.Location = new System.Drawing.Point(404, 123);
            this.complaintLabel.Name = "complaintLabel";
            this.complaintLabel.Size = new System.Drawing.Size(44, 18);
            this.complaintLabel.TabIndex = 11;
            this.complaintLabel.Text = "主诉";
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Location = new System.Drawing.Point(404, 262);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(44, 18);
            this.diagnosisLabel.TabIndex = 12;
            this.diagnosisLabel.Text = "诊断";
            // 
            // prescriptionLabel
            // 
            this.prescriptionLabel.AutoSize = true;
            this.prescriptionLabel.Location = new System.Drawing.Point(404, 440);
            this.prescriptionLabel.Name = "prescriptionLabel";
            this.prescriptionLabel.Size = new System.Drawing.Size(44, 18);
            this.prescriptionLabel.TabIndex = 13;
            this.prescriptionLabel.Text = "处方";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(134, 21);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.ReadOnly = true;
            this.ssnTextBox.Size = new System.Drawing.Size(148, 28);
            this.ssnTextBox.TabIndex = 14;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(134, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(148, 28);
            this.nameTextBox.TabIndex = 15;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(134, 95);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(148, 28);
            this.surnameTextBox.TabIndex = 16;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Location = new System.Drawing.Point(134, 138);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(148, 28);
            this.sexTextBox.TabIndex = 17;
            // 
            // birth_dateTextBox
            // 
            this.birth_dateTextBox.Location = new System.Drawing.Point(134, 181);
            this.birth_dateTextBox.Name = "birth_dateTextBox";
            this.birth_dateTextBox.ReadOnly = true;
            this.birth_dateTextBox.Size = new System.Drawing.Size(148, 28);
            this.birth_dateTextBox.TabIndex = 18;
            // 
            // date_inTextBox
            // 
            this.date_inTextBox.Location = new System.Drawing.Point(528, 73);
            this.date_inTextBox.Name = "date_inTextBox";
            this.date_inTextBox.ReadOnly = true;
            this.date_inTextBox.Size = new System.Drawing.Size(148, 28);
            this.date_inTextBox.TabIndex = 19;
            // 
            // complaintTextBox
            // 
            this.complaintTextBox.Location = new System.Drawing.Point(528, 119);
            this.complaintTextBox.Multiline = true;
            this.complaintTextBox.Name = "complaintTextBox";
            this.complaintTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.complaintTextBox.Size = new System.Drawing.Size(253, 122);
            this.complaintTextBox.TabIndex = 20;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.Location = new System.Drawing.Point(528, 274);
            this.diagnosisTextBox.Multiline = true;
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.diagnosisTextBox.Size = new System.Drawing.Size(253, 122);
            this.diagnosisTextBox.TabIndex = 21;
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.Location = new System.Drawing.Point(528, 443);
            this.prescriptionTextBox.Multiline = true;
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prescriptionTextBox.Size = new System.Drawing.Size(253, 122);
            this.prescriptionTextBox.TabIndex = 22;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.BackgroundImage = global::Project0.Properties.Resources.close2Button_Image;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(743, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(59, 39);
            this.closeButton.TabIndex = 23;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(0, 565);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(832, 41);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // InspectPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(858, 586);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(this.complaintTextBox);
            this.Controls.Add(this.date_inTextBox);
            this.Controls.Add(this.prescriptionLabel);
            this.Controls.Add(this.diagnosisLabel);
            this.Controls.Add(this.complaintLabel);
            this.Controls.Add(this.date_inLabel);
            this.Controls.Add(this.inspectLabe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InspectPatientForm";
            this.Text = "患者问诊";
            this.Load += new System.EventHandler(this.InspectPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patient_AdmissionBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource patient_AdmissionBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label birth_dateLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label xrayLabel;
        private System.Windows.Forms.Label urianalysisLabel;
        private System.Windows.Forms.Label blood_analysisLabel;
        private System.Windows.Forms.Label inspectLabe;
        private System.Windows.Forms.Label date_inLabel;
        private System.Windows.Forms.Label complaintLabel;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.Label prescriptionLabel;
        private System.Windows.Forms.TextBox birth_dateTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox date_inTextBox;
        private System.Windows.Forms.TextBox complaintTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
    }
}