namespace Project0
{
    partial class AddStaffForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.step1TabPage = new System.Windows.Forms.TabPage();
            this.closeButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordcontrolLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.step2TabPage = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.close2Button = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.step1TabPage.SuspendLayout();
            this.step2TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.step1TabPage);
            this.tabControl.Controls.Add(this.step2TabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(444, 395);
            this.tabControl.TabIndex = 0;
            // 
            // step1TabPage
            // 
            this.step1TabPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.step1TabPage.Controls.Add(this.closeButton);
            this.step1TabPage.Controls.Add(this.continueButton);
            this.step1TabPage.Controls.Add(this.emailTextBox);
            this.step1TabPage.Controls.Add(this.password2TextBox);
            this.step1TabPage.Controls.Add(this.passwordTextBox);
            this.step1TabPage.Controls.Add(this.userNameTextBox);
            this.step1TabPage.Controls.Add(this.emailLabel);
            this.step1TabPage.Controls.Add(this.passwordcontrolLabel);
            this.step1TabPage.Controls.Add(this.passwordLabel);
            this.step1TabPage.Controls.Add(this.usernameLabel);
            this.step1TabPage.Controls.Add(this.loginLabel);
            this.step1TabPage.Location = new System.Drawing.Point(4, 28);
            this.step1TabPage.Name = "step1TabPage";
            this.step1TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.step1TabPage.Size = new System.Drawing.Size(436, 363);
            this.step1TabPage.TabIndex = 0;
            this.step1TabPage.Text = "第一步";
            this.step1TabPage.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::Project0.Properties.Resources.closeButton_Image;
            this.closeButton.Location = new System.Drawing.Point(370, 26);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 24);
            this.closeButton.TabIndex = 10;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackgroundImage = global::Project0.Properties.Resources.continueButton_Image;
            this.continueButton.Location = new System.Drawing.Point(294, 296);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(120, 44);
            this.continueButton.TabIndex = 9;
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(190, 233);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(194, 28);
            this.emailTextBox.TabIndex = 8;
            // 
            // password2TextBox
            // 
            this.password2TextBox.Location = new System.Drawing.Point(190, 186);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(194, 28);
            this.password2TextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(190, 123);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 28);
            this.passwordTextBox.TabIndex = 6;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(190, 83);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(194, 28);
            this.userNameTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(54, 243);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(71, 18);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "E-mail:";
            // 
            // passwordcontrolLabel
            // 
            this.passwordcontrolLabel.AutoSize = true;
            this.passwordcontrolLabel.Location = new System.Drawing.Point(54, 189);
            this.passwordcontrolLabel.Name = "passwordcontrolLabel";
            this.passwordcontrolLabel.Size = new System.Drawing.Size(98, 18);
            this.passwordcontrolLabel.TabIndex = 3;
            this.passwordcontrolLabel.Text = "确认密码：";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(54, 126);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(62, 18);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "密码：";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(54, 83);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 18);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "用户名：";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(54, 26);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(80, 18);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "登录信息";
            // 
            // step2TabPage
            // 
            this.step2TabPage.Controls.Add(this.saveButton);
            this.step2TabPage.Controls.Add(this.close2Button);
            this.step2TabPage.Controls.Add(this.previousButton);
            this.step2TabPage.Controls.Add(this.addressTextBox);
            this.step2TabPage.Controls.Add(this.phoneTextBox);
            this.step2TabPage.Controls.Add(this.nameTextBox);
            this.step2TabPage.Controls.Add(this.surnameTextBox);
            this.step2TabPage.Controls.Add(this.addressLabel);
            this.step2TabPage.Controls.Add(this.phoneLabel);
            this.step2TabPage.Controls.Add(this.nameLabel);
            this.step2TabPage.Controls.Add(this.surnameLabel);
            this.step2TabPage.Controls.Add(this.label6);
            this.step2TabPage.Location = new System.Drawing.Point(4, 28);
            this.step2TabPage.Name = "step2TabPage";
            this.step2TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.step2TabPage.Size = new System.Drawing.Size(436, 363);
            this.step2TabPage.TabIndex = 1;
            this.step2TabPage.Text = "第二步";
            this.step2TabPage.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(325, 317);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // close2Button
            // 
            this.close2Button.BackgroundImage = global::Project0.Properties.Resources.close2Button_Image;
            this.close2Button.Location = new System.Drawing.Point(364, 35);
            this.close2Button.Name = "close2Button";
            this.close2Button.Size = new System.Drawing.Size(27, 30);
            this.close2Button.TabIndex = 10;
            this.close2Button.UseVisualStyleBackColor = true;
            this.close2Button.Click += new System.EventHandler(this.close2Button_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackgroundImage = global::Project0.Properties.Resources.previousButton_Image;
            this.previousButton.Location = new System.Drawing.Point(37, 324);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(25, 23);
            this.previousButton.TabIndex = 9;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(135, 241);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(188, 69);
            this.addressTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(135, 198);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(188, 28);
            this.phoneTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(135, 148);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 28);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(135, 106);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(188, 28);
            this.surnameTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(30, 251);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 18);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "地址：";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(31, 208);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(62, 18);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "电话：";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(31, 158);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 18);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "名：";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(31, 116);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(44, 18);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "姓：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "医生信息";
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "AddStaffForm";
            this.Text = "添加行政人员";
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            this.tabControl.ResumeLayout(false);
            this.step1TabPage.ResumeLayout(false);
            this.step1TabPage.PerformLayout();
            this.step2TabPage.ResumeLayout(false);
            this.step2TabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage step1TabPage;
        private System.Windows.Forms.TabPage step2TabPage;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox password2TextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordcontrolLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button close2Button;
    }
}