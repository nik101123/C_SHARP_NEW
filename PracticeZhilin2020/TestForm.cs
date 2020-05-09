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
        private Panel[] ClubPanel;    // Array of textboxes
        int count = 0;
        int DynamicButtonCount = 0;
        public TestForm()
        {
            InitializeComponent();
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
            ClubPanel[count].Name = reader["id"].ToString();
           

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

        private void club_Info_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);
            //int x = Int32.Parse(dynamicButton.Name);
            
            MessageBox.Show("инфа");
           /* roomid = Panel1[x - 1].Name;

            About form = new About(roomid);
            form.Show();*/
        }
        private System.Windows.Forms.FlowLayoutPanel clubsPanel;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.clubsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // clubsPanel
            // 
            this.clubsPanel.AutoScroll = true;
            this.clubsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clubsPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.clubsPanel.Location = new System.Drawing.Point(0, 0);
            this.clubsPanel.Name = "clubsPanel";
            this.clubsPanel.Size = new System.Drawing.Size(550, 400);
            this.clubsPanel.TabIndex = 0;
            this.clubsPanel.Dock = DockStyle.Fill;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.clubsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.Text = "Teams";
            this.BackColor = Color.MediumSeaGreen;
            this.ResumeLayout(false);

        }
    }
}
