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
    public partial class MemberPersonalTraining : Form
    {
        private Form prevForm;
        private int Member_ID;
        private int GymID;

        public MemberPersonalTraining(Form prevForm,int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Member_ID = id;
            GymID = -1;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void MemberPersonalTraining_Load(object sender, EventArgs e)
        {

            connection.Open();
            string query1 = $"SELECT Membership_ID FROM MemberUser Where Member_ID='{Member_ID}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            object result = Cmd1.ExecuteScalar();
            connection.Close();

            int Membership_ID=-1;
            if (result != DBNull.Value)
            {
                Membership_ID = (int)result;
                connection.Open();
                string query2 = $"SELECT Gym_ID FROM Membership Where Membership_ID='{Membership_ID}'";
                SqlCommand Cmd = new SqlCommand(query2, connection);
                GymID = (int)Cmd.ExecuteScalar();
                connection.Close();

                // Connection string to your SQL Server database

                string query = $"SELECT Users.Username " +
               $"FROM Users " +
               $"JOIN Gym_Trainer ON Users.User_ID = Gym_Trainer.Trainer_ID " +
               $"WHERE Gym_Trainer.Gym_ID = '{GymID}' AND Gym_Trainer.Approved = 1";

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
                                TrainerAvailable.Items.Add(reader.GetString(0)); // Assuming the value is a string
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
            }
            else
            {
                MessageBox.Show("You are Not Registered In Any Gym!");
                prevForm.Show();
                this.Close();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(TrainerAvailable.SelectedIndex!=-1 && Duration.SelectedIndex!=-1 && SessionTime.Value.TimeOfDay != TimeSpan.Zero)
            {
                connection.Open();
                string query1 = $"SELECT User_ID FROM ( " +
                $"SELECT Users.User_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum " +
                $"FROM Users " +
                $"JOIN Gym_Trainer ON Users.User_ID = Gym_Trainer.Trainer_ID " +
                $"WHERE Gym_Trainer.Gym_ID = '{GymID}' AND Gym_Trainer.Approved = 1) AS SubQuery " +
                $"WHERE RowNum = '{TrainerAvailable.SelectedIndex + 1}'";

                SqlCommand Cmd1 = new SqlCommand(query1, connection);
                int TrainerID = (int)Cmd1.ExecuteScalar();
                connection.Close();

                string status = "Pending";

                connection.Open();
                string query = $"insert into Training_Session values ('{DateTime.Today}','{Duration.Text}','{SessionTime.Value.TimeOfDay}','{status}','{TrainerID}')";
                SqlCommand Cmd = new SqlCommand(query, connection);
                Cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string query3 = $"SELECT TOP 1 TrainingSession_ID FROM Training_Session ORDER BY TrainingSession_ID DESC";
                SqlCommand Cmd3 = new SqlCommand(query3, connection);
                int TrainingSession_ID = (int)Cmd3.ExecuteScalar();
                connection.Close();

                connection.Open();
                string query2 = $"Update MemberUser Set TrainingSession_ID='{TrainingSession_ID}' where Member_ID='{Member_ID}'";
                SqlCommand Cmd2 = new SqlCommand(query2, connection);
                Cmd2.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Your Training Session Request is Sent!");

                prevForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill In the Boxes!");
            }
        }
    }
}
