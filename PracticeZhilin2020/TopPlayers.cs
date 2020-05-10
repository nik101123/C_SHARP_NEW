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

    public partial class TopPForm : Form
    {
        private Panel[] ClubPanel;    // Array of textboxes
        int count = 0;
        int DynamicButtonCount = 0;
        public TopPForm()
        {
            InitializeComponent();
            ClubPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM players", db.getConnection());
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
            nameLabel.Text = reader["first_name"].ToString();
            nameLabel.ForeColor = Color.Black;
            nameLabel.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            nameLabel.Size = new System.Drawing.Size(660, 30);
            nameLabel.Location = new System.Drawing.Point(0, 0);

            //place
            Label infoLabel = new Label();
            infoLabel.Text = reader["last_name"].ToString();
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
        private System.Windows.Forms.Label nameForm;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopPForm));
            this.nameForm = new System.Windows.Forms.Label();
            this.clubsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameForm
            // 
            this.nameForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nameForm.Location = new System.Drawing.Point(300, 0);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(300, 50);
            this.nameForm.TabIndex = 0;
            this.nameForm.Text = "Топ игроков";
            this.nameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clubsPanel
            // 
            this.clubsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clubsPanel.AutoScroll = true;
            this.clubsPanel.Location = new System.Drawing.Point(0, 100);
            this.clubsPanel.Name = "clubsPanel";
            this.clubsPanel.Size = new System.Drawing.Size(900, 500);
            this.clubsPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(500, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 50);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Голы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ассисты";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Красные карточки";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Желтые карточки";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TopPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameForm);
            this.Controls.Add(this.clubsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopPForm";
            this.Text = "TopPlayers";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
