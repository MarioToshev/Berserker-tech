namespace BerserkerDesktop
{
    partial class Home
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
            this.buildComputerbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPartsBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildComputerbtn
            // 
            this.buildComputerbtn.Location = new System.Drawing.Point(39, 248);
            this.buildComputerbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildComputerbtn.Name = "buildComputerbtn";
            this.buildComputerbtn.Size = new System.Drawing.Size(158, 60);
            this.buildComputerbtn.TabIndex = 0;
            this.buildComputerbtn.Text = "Build Computer";
            this.buildComputerbtn.UseVisualStyleBackColor = true;
            this.buildComputerbtn.Click += new System.EventHandler(this.buildComputerbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(310, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // AddPartsBtn
            // 
            this.AddPartsBtn.Location = new System.Drawing.Point(497, 248);
            this.AddPartsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPartsBtn.Name = "AddPartsBtn";
            this.AddPartsBtn.Size = new System.Drawing.Size(158, 60);
            this.AddPartsBtn.TabIndex = 0;
            this.AddPartsBtn.Text = "Add parts to shop";
            this.AddPartsBtn.UseVisualStyleBackColor = true;
            this.AddPartsBtn.Click += new System.EventHandler(this.AddPartsBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(285, 248);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(158, 60);
            this.logOutBtn.TabIndex = 0;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(322, 160);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(30, 15);
            this.welcomeLbl.TabIndex = 2;
            this.welcomeLbl.Text = "User";
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(39, 160);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(158, 60);
            this.adminBtn.TabIndex = 3;
            this.adminBtn.Text = "Admin panel";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.AddPartsBtn);
            this.Controls.Add(this.buildComputerbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buildComputerbtn;
        private Label label1;
        private Button AddPartsBtn;
        private Button logOutBtn;
        private Label welcomeLbl;
        private Button adminBtn;
    }
}