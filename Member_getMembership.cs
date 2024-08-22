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
    public partial class Member_getMembership : Form
    {
        private Form prevForm;
        private int Member_ID;
        public Member_getMembership(Form prevForm, int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Member_ID = id;
        }
        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void Member_getMembership_Load(object sender, EventArgs e)
        {
            // Connection string to your SQL Server database

            string query = $"SELECT GymName FROM Gym Where Verified=1";

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

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void Book_Click(object sender, EventArgs e)
        {
            if(GymAvailable.SelectedIndex!=-1 && MembershipType.SelectedIndex!=-1 && Duration.SelectedIndex!=-1)
            {
                connection.Open();
                string query1 = $"SELECT Gym_ID FROM ( SELECT Gym_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Verified=1) AS SubQuery WHERE RowNum = '{GymAvailable.SelectedIndex + 1}'";
                SqlCommand Cmd1 = new SqlCommand(query1, connection);
                int GymID = (int)Cmd1.ExecuteScalar();
                connection.Close();


                connection.Open();
                string query = $"insert into Membership values ('{MembershipType.Text}','{DateTime.Today}','{Duration.Text}','{GymID}')";
                SqlCommand Cmd = new SqlCommand(query, connection);
                Cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string query3 = $"SELECT TOP 1 Membership_ID FROM Membership ORDER BY Membership_ID DESC";
                SqlCommand Cmd3 = new SqlCommand(query3, connection);
                int Membership_ID = (int)Cmd3.ExecuteScalar();
                connection.Close();

                connection.Open() ;
                string query2 = $"Update MemberUser Set Membership_ID='{Membership_ID}' where Member_ID='{Member_ID}'";
                SqlCommand Cmd2 = new SqlCommand(query2, connection);
                Cmd2.ExecuteNonQuery(); 
                connection.Close();

                MessageBox.Show("Welcome aboard! Your Membership is confirmed!");

                prevForm.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Please Fill In The Boxes!");
            }
        }
    }
}
