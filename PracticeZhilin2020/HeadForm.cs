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
    public partial class HeadForm : Form
    {
        public HeadForm(string user_login)
        {
            InitializeComponent();
            
            string user_info,user_firstname,user_lastname,user_email;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_l", db.getConnection());
            command.Parameters.Add("@u_l", MySqlDbType.VarChar).Value = user_login;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                user_firstname =reader["First_name"].ToString();
                user_lastname = reader["Last_name"].ToString();
                user_email = reader["email"].ToString();
                user_info = user_login +" "+ user_firstname +" "+ user_lastname +" "+ user_email;
                db.closeConnection();
                reader.Close();
                User_label_info.Text = user_info;
            }

        }

        private void HeadForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TopPForm topPForm = new TopPForm();
            topPForm.Show();
            Hide();

        }
    }
}

