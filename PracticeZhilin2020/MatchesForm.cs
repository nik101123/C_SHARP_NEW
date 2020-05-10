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
    public partial class MatchesForm : Form
    {
        private Panel[] MatchPanel;    // Array of textboxes
        int count = 0;
        int DynamicButtonCount = 0;
        private string user_login;
        public MatchesForm()
        {
            InitializeComponent();
            MatchPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `matches` INNER JOIN `clubs` ON matches.home_team_id AND matches.visitor_team_id" +
                "ON clubs.ID ORDER BY date_match", db.getConnection());
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
            int home_team_id,visitors_team_id, goal_visitor, goal_home;
            
            //panel
            MatchPanel[count] = new Panel();
            MatchPanel[count].BackColor = Color.White;
            MatchPanel[count].BorderStyle = BorderStyle.FixedSingle;
            MatchPanel[count].Size = new System.Drawing.Size(665, 60);
            MatchPanel[count].Name = reader["matches.Id"].ToString();


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


            MatchPanel[count].Controls.Add(nameLabel);
            MatchPanel[count].Controls.Add(infoLabel);
            MatchesPanel.Controls.Add(MatchPanel[count]);

            count++;
            
        }

        private void MatchesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
