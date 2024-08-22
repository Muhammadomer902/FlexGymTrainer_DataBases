using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class Admin_ExtraReport : Form
    {
        private Form prevForm;
        private int Admin_ID;
        private int GymID;
        private int TrainerID;
        private int DietID;



        public Admin_ExtraReport(Form prevForm, int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Admin_ID = gymOwner_ID;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");


        private void trainerbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string query1 = $"SELECT User_ID FROM ( SELECT User_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Users WHERE UserType='Trainer' ) AS SubQuery WHERE RowNum = '{trainerbox.SelectedIndex + 1}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            TrainerID = (int)Cmd1.ExecuteScalar();
            connection.Close();
        }

        private void GymNamebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string query1 = $"SELECT Gym_ID FROM ( SELECT Gym_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Verified=1 ) AS SubQuery WHERE RowNum = '{GymNamebox.SelectedIndex + 1}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            GymID = (int)Cmd1.ExecuteScalar();
            connection.Close();
        }

        private void Admin_ExtraReport_Load(object sender, EventArgs e)
        {
            // Connection string to your SQL Server database

            string query = $"SELECT GymName FROM Gym Where Verified= 1 ";
            // Create a SqlConnection object to connect to the database
            // Create a SqlCommand object with the SQL query and the SqlConnection
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Open the connection
                connection.Open();

                // Execute the query and obtain a SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Check if there are any rows returned
                    if (reader.HasRows)
                    {
                        // Iterate over the SqlDataReader
                        while (reader.Read())
                        {
                            // Retrieve the value from the reader and add it to the ComboBox
                            GymNamebox.Items.Add(reader.GetString(0)); // Assuming the value is a string
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Gym Available!");
                        prevForm.Show();
                        this.Close();
                    }
                }

                connection.Close();

            }

            string query1 = $"SELECT Username FROM Users Where UserType='Trainer'";
            // Create a SqlConnection object to connect to the database
            // Create a SqlCommand object with the SQL query and the SqlConnection
            using (SqlCommand command = new SqlCommand(query1, connection))
            {
                // Open the connection
                connection.Open();

                // Execute the query and obtain a SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Check if there are any rows returned
                    if (reader.HasRows)
                    {
                        // Iterate over the SqlDataReader
                        while (reader.Read())
                        {
                            // Retrieve the value from the reader and add it to the ComboBox
                            trainerbox.Items.Add(reader.GetString(0)); // Assuming the value is a string
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Trainer Available!");
                        prevForm.Show();
                        this.Close();
                    }
                }

                connection.Close();

            }

            string query2 = $"SELECT DietPlan_ID FROM DietPlan";
            // Create a SqlConnection object to connect to the database
            // Create a SqlCommand object with the SQL query and the SqlConnection
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                // Open the connection
                connection.Open();

                // Execute the query and obtain a SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Check if there are any rows returned
                    if (reader.HasRows)
                    {
                        // Iterate over the SqlDataReader
                        while (reader.Read())
                        {
                            // Retrieve the value from the reader and add it to the ComboBox
                            dietplanbox.Items.Add(reader.GetInt32(0)); // Assuming the value is a string
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Diet PLan Available!");
                        prevForm.Show();
                        this.Close();
                    }
                }

                connection.Close();

            }
        }

        private void dietplanbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string query1 = $"SELECT DietPlan_ID FROM ( SELECT User_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM DietPlan) AS SubQuery WHERE RowNum = '{dietplanbox.SelectedIndex + 1}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
             DietID= (int)Cmd1.ExecuteScalar();
            connection.Close();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
            {
                string query = @"
                SELECT mu.FirstName, mu.MiddleName, mu.LastName, mu.Contact, mu.Gender, mu.DoB, mu.CNIC, mu.Height, mu.Weight, mu.Experience, mu.Purpose
                FROM MemberUser mu
                JOIN Membership m ON mu.Membership_ID = m.Membership_ID
                JOIN Gym g ON m.Gym_ID = g.Gym_ID
	            Join Training_Session on Training_Session.TrainingSession_ID = Mu.TrainingSession_ID
                JOIN DietPlan dpm ON mu.DietPlan_ID = dpm.DietPlan_ID
                WHERE 1 =1  ";

                if(GymNamebox.SelectedIndex != -1)
                {
                    query += $" AND  g.Gym_ID = '{GymID}' ";
                }
                if(trainerbox.SelectedIndex != -1)
                {
                    query += $" AND ts.Trainer_ID = '{TrainerID}' ";
                }
                if(dietplanbox.SelectedIndex != -1)
                {
                    query += $" AND dpm.DietPlan_ID = '{DietID}' ";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing text in the RichTextBox
                        richTextBox1.Clear();

                        // Iterate through the results and append them to the RichTextBox
                        while (reader.Read())
                        {
                            richTextBox1.AppendText($"First Name: {reader["FirstName"]}\n");
                            richTextBox1.AppendText($"Middle Name: {reader["MiddleName"]}\n");
                            richTextBox1.AppendText($"Last Name: {reader["LastName"]}\n");
                            richTextBox1.AppendText($"Contact: {reader["Contact"]}\n");
                            richTextBox1.AppendText($"Gender: {reader["Gender"]}\n");
                            richTextBox1.AppendText($"Date of Birth: {reader["DoB"]}\n");
                            richTextBox1.AppendText($"CNIC: {reader["CNIC"]}\n");
                            richTextBox1.AppendText($"Height: {reader["Height"]}\n");
                            richTextBox1.AppendText($"Weight: {reader["Weight"]}\n");
                            richTextBox1.AppendText($"Experience: {reader["Experience"]}\n");
                            richTextBox1.AppendText($"Purpose: {reader["Purpose"]}\n\n");
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
