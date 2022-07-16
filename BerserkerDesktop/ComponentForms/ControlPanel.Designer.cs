namespace BerserkerDesktop.ComponentForms
{
    partial class ControlPanel
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
            this.addCpuBtn = new System.Windows.Forms.Button();
            this.AddMotherboardBtn = new System.Windows.Forms.Button();
            this.AddGpuBtn = new System.Windows.Forms.Button();
            this.AddRamBtn = new System.Windows.Forms.Button();
            this.AddStorageBtn = new System.Windows.Forms.Button();
            this.AddPsuBtn = new System.Windows.Forms.Button();
            this.allComponentsBtn = new System.Windows.Forms.Button();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCpuBtn
            // 
            this.addCpuBtn.Location = new System.Drawing.Point(25, 25);
            this.addCpuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCpuBtn.Name = "addCpuBtn";
            this.addCpuBtn.Size = new System.Drawing.Size(118, 46);
            this.addCpuBtn.TabIndex = 0;
            this.addCpuBtn.Text = "Add CPU";
            this.addCpuBtn.UseVisualStyleBackColor = true;
            this.addCpuBtn.Click += new System.EventHandler(this.addCpuBtn_Click);
            // 
            // AddMotherboardBtn
            // 
            this.AddMotherboardBtn.Location = new System.Drawing.Point(25, 75);
            this.AddMotherboardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMotherboardBtn.Name = "AddMotherboardBtn";
            this.AddMotherboardBtn.Size = new System.Drawing.Size(118, 46);
            this.AddMotherboardBtn.TabIndex = 1;
            this.AddMotherboardBtn.Text = "Add Motherboard";
            this.AddMotherboardBtn.UseVisualStyleBackColor = true;
            this.AddMotherboardBtn.Click += new System.EventHandler(this.AddMotherboardBtn_Click);
            // 
            // AddGpuBtn
            // 
            this.AddGpuBtn.Location = new System.Drawing.Point(25, 125);
            this.AddGpuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddGpuBtn.Name = "AddGpuBtn";
            this.AddGpuBtn.Size = new System.Drawing.Size(118, 46);
            this.AddGpuBtn.TabIndex = 2;
            this.AddGpuBtn.Text = "Add GPU";
            this.AddGpuBtn.UseVisualStyleBackColor = true;
            this.AddGpuBtn.Click += new System.EventHandler(this.AddGpuBtn_Click);
            // 
            // AddRamBtn
            // 
            this.AddRamBtn.Location = new System.Drawing.Point(25, 176);
            this.AddRamBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRamBtn.Name = "AddRamBtn";
            this.AddRamBtn.Size = new System.Drawing.Size(118, 46);
            this.AddRamBtn.TabIndex = 3;
            this.AddRamBtn.Text = "Add RAM";
            this.AddRamBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRamBtn.UseVisualStyleBackColor = true;
            this.AddRamBtn.Click += new System.EventHandler(this.AddRamBtn_Click);
            // 
            // AddStorageBtn
            // 
            this.AddStorageBtn.Location = new System.Drawing.Point(25, 276);
            this.AddStorageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddStorageBtn.Name = "AddStorageBtn";
            this.AddStorageBtn.Size = new System.Drawing.Size(118, 46);
            this.AddStorageBtn.TabIndex = 4;
            this.AddStorageBtn.Text = "Add Storage";
            this.AddStorageBtn.UseVisualStyleBackColor = true;
            this.AddStorageBtn.Click += new System.EventHandler(this.AddStorageBtn_Click);
            // 
            // AddPsuBtn
            // 
            this.AddPsuBtn.Location = new System.Drawing.Point(25, 226);
            this.AddPsuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPsuBtn.Name = "AddPsuBtn";
            this.AddPsuBtn.Size = new System.Drawing.Size(118, 46);
            this.AddPsuBtn.TabIndex = 5;
            this.AddPsuBtn.Text = "Add PSU";
            this.AddPsuBtn.UseVisualStyleBackColor = true;
            this.AddPsuBtn.Click += new System.EventHandler(this.AddPsuBtn_Click);
            // 
            // allComponentsBtn
            // 
            this.allComponentsBtn.Location = new System.Drawing.Point(248, 42);
            this.allComponentsBtn.Name = "allComponentsBtn";
            this.allComponentsBtn.Size = new System.Drawing.Size(160, 46);
            this.allComponentsBtn.TabIndex = 6;
            this.allComponentsBtn.Text = "AllComponents components";
            this.allComponentsBtn.UseVisualStyleBackColor = true;
            this.allComponentsBtn.Click += new System.EventHandler(this.allComponentsBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(528, 280);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(160, 46);
            this.goBackBtn.TabIndex = 6;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.allComponentsBtn);
            this.Controls.Add(this.AddPsuBtn);
            this.Controls.Add(this.AddStorageBtn);
            this.Controls.Add(this.AddRamBtn);
            this.Controls.Add(this.AddGpuBtn);
            this.Controls.Add(this.AddMotherboardBtn);
            this.Controls.Add(this.addCpuBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private Button addCpuBtn;
        private Button AddMotherboardBtn;
        private Button AddGpuBtn;
        private Button AddRamBtn;
        private Button AddStorageBtn;
        private Button AddPsuBtn;
        private Button allComponentsBtn;
        private Button goBackBtn;
    }
}