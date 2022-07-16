namespace BerserkerDesktop
{
    partial class BuildersPage
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
            this.Requestslb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buildBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Requestslb
            // 
            this.Requestslb.FormattingEnabled = true;
            this.Requestslb.ItemHeight = 15;
            this.Requestslb.Location = new System.Drawing.Point(12, 81);
            this.Requestslb.Name = "Requestslb";
            this.Requestslb.Size = new System.Drawing.Size(538, 274);
            this.Requestslb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a request";
            // 
            // buildBtn
            // 
            this.buildBtn.Location = new System.Drawing.Point(575, 307);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(148, 48);
            this.buildBtn.TabIndex = 2;
            this.buildBtn.Text = "Start building";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // BuildersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buildBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Requestslb);
            this.Name = "BuildersPage";
            this.Text = "Take request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Requestslb;
        private Label label1;
        private Button buildBtn;
    }
}