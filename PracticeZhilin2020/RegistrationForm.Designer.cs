namespace PracticeZhilin2020
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.Registrationlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button_Login);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Registrationlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 454);
            this.panel1.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Login.Location = new System.Drawing.Point(107, 411);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(200, 31);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Зарегестрироваться";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.phoneTB);
            this.panel2.Controls.Add(this.emailTB);
            this.panel2.Controls.Add(this.lastnameTB);
            this.panel2.Controls.Add(this.firstnameTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.PasswordTB);
            this.panel2.Controls.Add(this.LoginTB);
            this.panel2.Location = new System.Drawing.Point(107, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 331);
            this.panel2.TabIndex = 1;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(48, 164);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(100, 22);
            this.phoneTB.TabIndex = 6;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(48, 119);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 22);
            this.emailTB.TabIndex = 5;
            // 
            // lastnameTB
            // 
            this.lastnameTB.Location = new System.Drawing.Point(48, 77);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(100, 22);
            this.lastnameTB.TabIndex = 4;
            // 
            // firstnameTB
            // 
            this.firstnameTB.Location = new System.Drawing.Point(48, 33);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(100, 22);
            this.firstnameTB.TabIndex = 3;
            this.firstnameTB.TextChanged += new System.EventHandler(this.firstnameTB_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(48, 289);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 22);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(48, 238);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(100, 22);
            this.LoginTB.TabIndex = 2;
            // 
            // Registrationlabel
            // 
            this.Registrationlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Registrationlabel.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registrationlabel.Location = new System.Drawing.Point(0, 0);
            this.Registrationlabel.Name = "Registrationlabel";
            this.Registrationlabel.Size = new System.Drawing.Size(424, 54);
            this.Registrationlabel.TabIndex = 0;
            this.Registrationlabel.Text = "Регистрация";
            this.Registrationlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 454);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label Registrationlabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.TextBox firstnameTB;
    }
}