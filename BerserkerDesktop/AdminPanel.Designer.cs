namespace BerserkerDesktop
{
    partial class AdminPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.changeRoleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeRoleCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AllEmployees = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pwdTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateUser = new System.Windows.Forms.Button();
            this.roleCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondNameTb = new System.Windows.Forms.TextBox();
            this.phoneNumberTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.changeRoleBtn);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.changeRoleCmb);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.AllEmployees);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(768, 398);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "AllComponents employees";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // changeRoleBtn
            // 
            this.changeRoleBtn.Location = new System.Drawing.Point(534, 187);
            this.changeRoleBtn.Name = "changeRoleBtn";
            this.changeRoleBtn.Size = new System.Drawing.Size(135, 31);
            this.changeRoleBtn.TabIndex = 7;
            this.changeRoleBtn.Text = "Save";
            this.changeRoleBtn.UseVisualStyleBackColor = true;
            this.changeRoleBtn.Click += new System.EventHandler(this.changeRoleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "AllComponents employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(507, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change Role";
            // 
            // changeRoleCmb
            // 
            this.changeRoleCmb.FormattingEnabled = true;
            this.changeRoleCmb.Location = new System.Drawing.Point(534, 97);
            this.changeRoleCmb.Name = "changeRoleCmb";
            this.changeRoleCmb.Size = new System.Drawing.Size(121, 23);
            this.changeRoleCmb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            // 
            // AllEmployees
            // 
            this.AllEmployees.FormattingEnabled = true;
            this.AllEmployees.ItemHeight = 15;
            this.AllEmployees.Location = new System.Drawing.Point(24, 58);
            this.AllEmployees.Name = "AllEmployees";
            this.AllEmployees.Size = new System.Drawing.Size(362, 334);
            this.AllEmployees.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.addressTb);
            this.tabPage2.Controls.Add(this.pwdTb);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CreateUser);
            this.tabPage2.Controls.Add(this.roleCmb);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.secondNameTb);
            this.tabPage2.Controls.Add(this.phoneNumberTb);
            this.tabPage2.Controls.Add(this.emailTb);
            this.tabPage2.Controls.Add(this.firstNameTb);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pwdTb
            // 
            this.pwdTb.Location = new System.Drawing.Point(118, 288);
            this.pwdTb.Name = "pwdTb";
            this.pwdTb.Size = new System.Drawing.Size(121, 23);
            this.pwdTb.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // CreateUser
            // 
            this.CreateUser.Location = new System.Drawing.Point(128, 335);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(100, 48);
            this.CreateUser.TabIndex = 13;
            this.CreateUser.Text = "Add employee";
            this.CreateUser.UseVisualStyleBackColor = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // roleCmb
            // 
            this.roleCmb.FormattingEnabled = true;
            this.roleCmb.Location = new System.Drawing.Point(118, 246);
            this.roleCmb.Name = "roleCmb";
            this.roleCmb.Size = new System.Drawing.Size(121, 23);
            this.roleCmb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Second name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "First name";
            // 
            // secondNameTb
            // 
            this.secondNameTb.Location = new System.Drawing.Point(118, 69);
            this.secondNameTb.Name = "secondNameTb";
            this.secondNameTb.Size = new System.Drawing.Size(121, 23);
            this.secondNameTb.TabIndex = 3;
            // 
            // phoneNumberTb
            // 
            this.phoneNumberTb.Location = new System.Drawing.Point(118, 142);
            this.phoneNumberTb.Name = "phoneNumberTb";
            this.phoneNumberTb.Size = new System.Drawing.Size(121, 23);
            this.phoneNumberTb.TabIndex = 2;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(118, 193);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(121, 23);
            this.emailTb.TabIndex = 1;
            // 
            // firstNameTb
            // 
            this.firstNameTb.Location = new System.Drawing.Point(118, 27);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(121, 23);
            this.firstNameTb.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Address";
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(118, 108);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(121, 23);
            this.addressTb.TabIndex = 16;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab1;
        private TabPage tabPage2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox secondNameTb;
        private TextBox phoneNumberTb;
        private TextBox emailTb;
        private TextBox firstNameTb;
        private ListBox AllEmployees;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox pwdTb;
        private Button CreateUser;
        private ComboBox roleCmb;
        private Button changeRoleBtn;
        private ComboBox changeRoleCmb;
        private Label label10;
        private TextBox addressTb;
    }
}