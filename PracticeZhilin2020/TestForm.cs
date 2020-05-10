using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeZhilin2020
{

    public partial class TestForm : Form
    {
        private Panel[] ClubPanel;    // Массив Панелей
        int count = -1;
        int DynamicButtonCount = 0;
        private Button button1;
        private Label label1;
        int id_club;
        private string user_login;
        public TestForm(string user_login)
        {
            InitializeComponent();
            this.user_login = user_login;
            ClubPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM clubs", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                write_panel(reader);
            }
            reader.Close();
            db.closeConnection();

        }
        void write_panel(MySqlDataReader reader)
        {

            count++;
            DynamicButtonCount++;

            //panel
            ClubPanel[count] = new Panel();
            ClubPanel[count].BackColor = Color.White;
            ClubPanel[count].BorderStyle = BorderStyle.FixedSingle;
            ClubPanel[count].Size = new System.Drawing.Size(665, 80);
            ClubPanel[count].Name = reader["Id"].ToString();
           

            //team_name
            Label nameLabel = new Label();
            nameLabel.Text = reader["team_name"].ToString();
            nameLabel.ForeColor = Color.Black;
            nameLabel.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            nameLabel.Size = new System.Drawing.Size(660, 30);
            nameLabel.Location = new System.Drawing.Point(0, 0);

            //place
            Label infoLabel = new Label();
            infoLabel.Text = reader["club_location"].ToString();
            infoLabel.ForeColor = Color.Black;
            infoLabel.Font = new Font("Century Gothic", 20);
            infoLabel.Size = new System.Drawing.Size(660, 30);
            infoLabel.Location = new System.Drawing.Point(0, 35);

            //button
            string name = "" + DynamicButtonCount;
            Button btnDynamicButton = new Button();
            btnDynamicButton.Name = name;
            btnDynamicButton.Text = "Подробнее";
            btnDynamicButton.Cursor = Cursors.Hand;
            btnDynamicButton.Size = new System.Drawing.Size(150, 30);
            btnDynamicButton.Font = new Font("Century Gothic", 15);
            btnDynamicButton.Location = new System.Drawing.Point(500, 35);
            btnDynamicButton.Click += new EventHandler(this.club_Info_Click);
            btnDynamicButton.BringToFront();

            ClubPanel[count].Controls.Add(btnDynamicButton);
            ClubPanel[count].Controls.Add(nameLabel);
            ClubPanel[count].Controls.Add(infoLabel);
            clubsPanel.Controls.Add(ClubPanel[count]);
        }
        TeamInfoForm teaminfo;
        private void club_Info_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);
            int x = Int32.Parse(dynamicButton.Name);
            id_club = Int32.Parse(ClubPanel[x - 1].Name);
            teaminfo = new TeamInfoForm(id_club);
            teaminfo.Show();
        }
        private System.Windows.Forms.FlowLayoutPanel clubsPanel;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.clubsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clubsPanel
            // 
            this.clubsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clubsPanel.AutoScroll = true;
            this.clubsPanel.Location = new System.Drawing.Point(0, 50);
            this.clubsPanel.Name = "clubsPanel";
            this.clubsPanel.Size = new System.Drawing.Size(900, 385);
            this.clubsPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список команд";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clubsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.Text = "Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeadForm headForm = new HeadForm(user_login);
            headForm.Show();
            teaminfo.Close();
            Close();
            
        }
    }
}
