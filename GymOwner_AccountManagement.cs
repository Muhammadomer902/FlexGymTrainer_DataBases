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
    public partial class GymOwner_AccountManagement : Form
    {
        private Form prevForm;
        private int GymOwner_ID;
        private int GymID;
        public GymOwner_AccountManagement(Form prevForm, int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.GymOwner_ID = gymOwner_ID;
            GymID = -1;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = $"Select User_ID from Users where Username='{MemberUser.Text}' and UserType='Member'";
            SqlCommand cmd = new SqlCommand(query, connection);
            object Member_ID = cmd.ExecuteScalar();
            connection.Close();

            if (Member_ID != null)
            {
                int id = (int)Member_ID;
                connection.Open();
                string query1 = $"Update MemberUser Set Membership_ID=NULL Where Member_ID='{id}'";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Membership Revoked!");


            }
            else
            {
                MessageBox.Show("Incorrect Username!");
            }

        }

        private void GymOwner_AccountManagement_Load(object sender, EventArgs e)
        {
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
                            GymName.Items.Add(reader.GetString(0)); // Assuming the value is a string
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

        private void button2_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void GymName_SelectedIndexChanged(object sender, EventArgs e)
        {

            connection.Open();
            string query1 = $"SELECT Gym_ID FROM ( SELECT Gym_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Verified=1 and Owner_ID='{GymOwner_ID}') AS SubQuery WHERE RowNum = '{GymName.SelectedIndex + 1}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            GymID = (int)Cmd1.ExecuteScalar();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = $"Select User_ID from Users where Username='{TrainerUser.Text}' and UserType='Trainer'";
            SqlCommand cmd = new SqlCommand(query, connection);
            object Trainer_ID = cmd.ExecuteScalar();
            connection.Close();

            if (Trainer_ID != DBNull.Value)
            {
                int id = (int)Trainer_ID;
                connection.Open();
                string query1 = $"Delete From Gym_Trainer Where Trainer_ID='{id}' and Gym_ID='{GymID}'";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Trainer Removed!");

            }
            else
            {
                MessageBox.Show("Incorrect Username!");
            }
        }
    }
}
