namespace PracticeZhilin2020
{
    partial class HeadForm
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
            this.AutorizatePanel = new System.Windows.Forms.Panel();
            this.User_info_label = new System.Windows.Forms.Label();
            this.User_label_info = new System.Windows.Forms.Label();
            this.AutorizatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutorizatePanel
            // 
            this.AutorizatePanel.Controls.Add(this.User_info_label);
            this.AutorizatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutorizatePanel.Location = new System.Drawing.Point(0, 0);
            this.AutorizatePanel.Name = "AutorizatePanel";
            this.AutorizatePanel.Size = new System.Drawing.Size(800, 100);
            this.AutorizatePanel.TabIndex = 0;
            // 
            // User_info_label
            // 
            this.User_info_label.AutoSize = true;
            this.User_info_label.Location = new System.Drawing.Point(367, 47);
            this.User_info_label.Name = "User_info_label";
            this.User_info_label.Size = new System.Drawing.Size(0, 17);
            this.User_info_label.TabIndex = 0;
            // 
            // User_label_info
            // 
            this.User_label_info.AutoSize = true;
            this.User_label_info.Location = new System.Drawing.Point(514, 191);
            this.User_label_info.Name = "User_label_info";
            this.User_label_info.Size = new System.Drawing.Size(46, 17);
            this.User_label_info.TabIndex = 1;
            this.User_label_info.Text = "label1";
            // 
            // HeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User_label_info);
            this.Controls.Add(this.AutorizatePanel);
            this.Name = "HeadForm";
            this.Text = "HeadForm";
            this.AutorizatePanel.ResumeLayout(false);
            this.AutorizatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AutorizatePanel;
        private System.Windows.Forms.Label User_info_label;
        private System.Windows.Forms.Label User_label_info;
    }
}