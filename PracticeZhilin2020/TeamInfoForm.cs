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
    public partial class TeamInfoForm : Form
    {
        public TeamInfoForm(int id_club)
        {
            InitializeComponent();

            ObjectInfoSystem.Club team = new ObjectInfoSystem.Club();
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clubs` WHERE `Id` = @i_c", db.getConnection());
            command.Parameters.Add("@i_c", MySqlDbType.VarChar).Value = id_club;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                team.club_info = reader["team_name"].ToString();
                team.club_location = reader["club_location"].ToString();
                team.creator_id = Int32.Parse(reader["Creator_id"].ToString());
                team.captain_id = Int32.Parse(reader["captain_id"].ToString());
                team.top_scorer_id = Int32.Parse(reader["top_scorer_id"].ToString());
                team.rudest_player_id = Int32.Parse(reader["rudest_player_id"].ToString());
                team.coach_id = Int32.Parse(reader["coach_id"].ToString());
                team.goal_scored= Int32.Parse(reader["goal_scored"].ToString());
                team.winning_mathes= Int32.Parse(reader["winning_matches"].ToString());
                team.goal_conceded = Int32.Parse(reader["goal_conceded"].ToString());
                team.loses_mathes = Int32.Parse(reader["losing_matches"].ToString());
            }
            reader.Close();

            ObjectInfoSystem.User club_manager = new ObjectInfoSystem.User();
            command = new MySqlCommand("SELECT * FROM `users` WHERE `Id` = @c_m", db.getConnection());
            command.Parameters.Add("@c_m", MySqlDbType.VarChar).Value = team.creator_id;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                club_manager.first_name = reader["First_name"].ToString();
                club_manager.last_name = reader["Last_name"].ToString();
                club_manager.phone = reader["phone"].ToString();
                club_manager.email = reader["email"].ToString();
            }
            reader.Close();
            ClubManagerLabel.Text = club_manager.first_name + " " + club_manager.last_name +
                " " + club_manager.phone + " " + club_manager.email;
            ObjectInfoSystem.Coach coach = new ObjectInfoSystem.Coach();
            command = new MySqlCommand("SELECT * FROM `coaches` WHERE `Id` = @c_i", db.getConnection());
            command.Parameters.Add("@c_i", MySqlDbType.VarChar).Value = team.coach_id;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                coach.first_name = reader["first_name"].ToString();
                coach.last_name = reader["last_name"].ToString();
                coach.nationality = reader["nationality"].ToString();
                coach.date_of_birth = reader["date_of_birth"].ToString();
            }
            reader.Close();
            HeadCoachLabel.Text = coach.first_name +" " +coach.last_name + " " + coach.nationality + " " + coach.date_of_birth;
            ObjectInfoSystem.Player captain = new ObjectInfoSystem.Player();
            command = new MySqlCommand("SELECT * FROM `players` WHERE `Id` = @c_i", db.getConnection());
            command.Parameters.Add("@c_i", MySqlDbType.VarChar).Value = team.captain_id;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                captain.first_name = reader["first_name"].ToString();
                captain.last_name = reader["last_name"].ToString();
                captain.nationality = reader["nationality"].ToString();
                captain.positions = reader["positions"].ToString();
                captain.work_foot = Char.Parse(reader["work_foot"].ToString());
                captain.date_of_birth = reader["date_of_birth"].ToString();
                /*    captain.yellow_cards = Int32.Parse(reader["yellow_cards"].ToString());
                      captain.red_cards = Int32.Parse(reader["red_cards"].ToString());
                      captain.goals_scored = Int32.Parse(reader["goal_scored"].ToString());
                      captain.asissts = Int32.Parse(reader["assists"].ToString());*/
            }
            ClubCaptainLabel.Text = captain.first_name + " " + captain.last_name +
                " " + captain.nationality + " " + captain.positions + " " + captain.work_foot +" "+
                captain.date_of_birth;
            reader.Close();
            ObjectInfoSystem.Player top_scorer = new ObjectInfoSystem.Player();
            command = new MySqlCommand("SELECT * FROM `players` WHERE `Id` = @t_s", db.getConnection());
            command.Parameters.Add("@t_s", MySqlDbType.VarChar).Value = team.top_scorer_id;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                top_scorer.first_name = reader["first_name"].ToString();
                top_scorer.last_name = reader["last_name"].ToString();
                top_scorer.nationality = reader["nationality"].ToString();
                top_scorer.positions = reader["positions"].ToString();
                top_scorer.work_foot = Char.Parse(reader["work_foot"].ToString());
                top_scorer.goals_scored = Int32.Parse(reader["goals"].ToString());
                //top_scorer.date_of_birth = reader["date_of_birth"].ToString();
                /*    captain.yellow_cards = Int32.Parse(reader["yellow_cards"].ToString());
                      captain.red_cards = Int32.Parse(reader["red_cards"].ToString());
                      captain.asissts = Int32.Parse(reader["assists"].ToString());*/
            }
            BestScorerLabel.Text = top_scorer.first_name + " " + top_scorer.last_name +
                " " + top_scorer.nationality + " " + top_scorer.positions + " " + top_scorer.work_foot + " " +
                top_scorer.date_of_birth +" Голов забил: "+ top_scorer.goals_scored;
            TeamsGoalScoredLabel.Text = "Голов забито: " + team.goal_scored;
            TeamsGoalConcededLabel.Text = "Голов пропущено: " + team.goal_conceded;
            TeamsWinnsLabel.Text = "Побед:" + team.winning_mathes;
            TeamsLosesLabel.Text = "Поражений: " + team.loses_mathes;
            reader.Close();
            db.closeConnection();
        }
    }
}
