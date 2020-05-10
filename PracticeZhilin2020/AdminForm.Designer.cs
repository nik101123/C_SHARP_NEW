namespace PracticeZhilin2020
{
    partial class AdminForm
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
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.AddTeamAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Controls.Add(this.button3);
            this.PanelAdmin.Controls.Add(this.button2);
            this.PanelAdmin.Controls.Add(this.AddTeamAdmin);
            this.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAdmin.Location = new System.Drawing.Point(0, 0);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(800, 450);
            this.PanelAdmin.TabIndex = 0;
            // 
            // AddTeamAdmin
            // 
            this.AddTeamAdmin.Location = new System.Drawing.Point(53, 34);
            this.AddTeamAdmin.Name = "AddTeamAdmin";
            this.AddTeamAdmin.Size = new System.Drawing.Size(149, 91);
            this.AddTeamAdmin.TabIndex = 0;
            this.AddTeamAdmin.Text = "Добавить администратора команды";
            this.AddTeamAdmin.UseVisualStyleBackColor = true;
            this.AddTeamAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить команду";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить игрока";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelAdmin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.PanelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAdmin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddTeamAdmin;
    }
}