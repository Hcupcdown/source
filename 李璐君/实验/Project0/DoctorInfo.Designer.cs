namespace Project0
{
    partial class DoctorInfo
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
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.Doctor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.AutoGenerateColumns = false;
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor_id,
            this.Doctor_name,
            this.Doctor_surname});
            this.doctorDataGridView.DataSource = this.doctorBindingSource;
            this.doctorDataGridView.Location = new System.Drawing.Point(12, 50);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.RowHeadersWidth = 62;
            this.doctorDataGridView.RowTemplate.Height = 30;
            this.doctorDataGridView.Size = new System.Drawing.Size(549, 72);
            this.doctorDataGridView.TabIndex = 0;
            this.doctorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Doctor_id
            // 
            this.Doctor_id.HeaderText = "Doctor_id";
            this.Doctor_id.MinimumWidth = 8;
            this.Doctor_id.Name = "Doctor_id";
            this.Doctor_id.Width = 150;
            // 
            // Doctor_name
            // 
            this.Doctor_name.HeaderText = "Doctor_name";
            this.Doctor_name.MinimumWidth = 8;
            this.Doctor_name.Name = "Doctor_name";
            this.Doctor_name.Width = 150;
            // 
            // Doctor_surname
            // 
            this.Doctor_surname.HeaderText = "Doctor_surname";
            this.Doctor_surname.MinimumWidth = 8;
            this.Doctor_surname.Name = "Doctor_surname";
            this.Doctor_surname.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "所有医生";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "请双击数据行，以查看和更新行政人员信息!";
            // 
            // button1
            // 
            this.button1.Image = global::Project0.Properties.Resources.previousButton_Image;
            this.button1.Location = new System.Drawing.Point(468, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Project0.Properties.Resources.closeButton_Image;
            this.button2.Location = new System.Drawing.Point(567, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorDataGridView);
            this.Name = "DoctorInfo";
            this.Text = "医生信息";
            this.Load += new System.EventHandler(this.DoctorInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.DataGridView doctorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}