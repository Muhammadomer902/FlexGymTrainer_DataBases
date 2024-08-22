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
    public partial class GymOwner_TrainerRequest : Form
    {
        private Form prevForm;
        private int GymOwner_ID;
        private int GymID;
        public GymOwner_TrainerRequest(Form prevForm, int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.GymOwner_ID = gymOwner_ID;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void GymOwner_TrainerRequest_Load(object sender, EventArgs e)
        {

            GymAvailable.Items.Clear();
            TrainerAvailable.Items.Clear();

            // Connection string to your SQL Server database

            string query = $"SELECT GymName FROM Gym Where Verified=1 and Owner_ID='{GymOwner_ID}'";
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
                            GymAvailable.Items.Add(reader.GetString(0)); // Assuming the value is a string
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
        }

        private void GymAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrainerAvailable.Items.Clear();
            connection.Open();
            string query1 = $"SELECT Gym_ID FROM ( SELECT Gym_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Verified=1 and Owner_ID='{GymOwner_ID}') AS SubQuery WHERE RowNum = '{GymAvailable.SelectedIndex + 1}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            GymID = (int)Cmd1.ExecuteScalar();
            connection.Close();

            // Connection string to your SQL Server database

            string query = $"SELECT Trainer_ID FROM Gym_Trainer Where Approved=0 and Gym_ID='{GymID}'";
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
                            TrainerAvailable.Items.Add(reader.GetInt32(0).ToString());
                            // Assuming the value is a string
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Trainer Available!");
                    }
                }

                connection.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GymAvailable.SelectedIndex != -1 && TrainerAvailable.SelectedIndex != -1)
            {
                connection.Open();
                string query1 = $"SELECT Trainer_ID FROM ( SELECT Trainer_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym_Trainer WHERE Approved=0 and Gym_ID='{GymID}') AS SubQuery WHERE RowNum = '{TrainerAvailable.SelectedIndex + 1}'";
                SqlCommand Cmd1 = new SqlCommand(query1, connection);
                int Trainer_ID = (int)Cmd1.ExecuteScalar();
                connection.Close();

                connection.Open();
                string query = $"update Gym_Trainer Set Approved=1 where Gym_ID='{GymID}' and Trainer_ID='{Trainer_ID}'";
                SqlCommand Cmd = new SqlCommand(query, connection);
                Cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Request Approved!");

                GymOwner_TrainerRequest_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please Fill In The Boxe!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();   
            this.Close();
        }
    }
}
