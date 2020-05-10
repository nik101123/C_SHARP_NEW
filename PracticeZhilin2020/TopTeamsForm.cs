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
    public partial class TopTeamsForm : Form
    {
        private Panel[] ClubPanel;    // Массив Панелей
        int count = 0;
        int DynamicButtonCount = 0;
        private Button button1;
        private Label label1;
        int id_club;
        private string user_login;
        public TopTeamsForm()
        {
            InitializeComponent();
            this.user_login = user_login;
            ClubPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clubs` ORDER BY points DESC,winning_matches DESC, goals_scored DESC", db.getConnection());
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

            
            //panel
            ClubPanel[count] = new Panel();
            ClubPanel[count].BackColor = Color.White;
            ClubPanel[count].BorderStyle = BorderStyle.FixedSingle;
            ClubPanel[count].Size = new System.Drawing.Size(665, 60);
            ClubPanel[count].Name = reader["Id"].ToString();


            //team_name
            Label nameLabel = new Label();
            nameLabel.Text = reader["team_name"].ToString();
            nameLabel.ForeColor = Color.Black;
            nameLabel.Font = new Font("Century Gothic", 15, FontStyle.Bold);
            nameLabel.Size = new System.Drawing.Size(660, 25);
            nameLabel.Location = new System.Drawing.Point(0, 0);

            //place
            Label infoLabel = new Label();
            infoLabel.Text = reader["club_location"].ToString();
            infoLabel.ForeColor = Color.Black;
            infoLabel.Font = new Font("Century Gothic", 12);
            infoLabel.Size = new System.Drawing.Size(660, 25);
            infoLabel.Location = new System.Drawing.Point(0, 35);


            ClubPanel[count].Controls.Add(nameLabel);
            ClubPanel[count].Controls.Add(infoLabel);
            clubsTopPanel.Controls.Add(ClubPanel[count]);

            count++;
            DynamicButtonCount++;

        }
        private void TopTeamsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
