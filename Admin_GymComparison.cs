using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class Admin_GymComparison : Form
    {
        private Form prevForm;
        private int Admin_ID;
        private int GymID1;
        private int GymID2;


        public Admin_GymComparison(Form prevForm, int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Admin_ID = gymOwner_ID;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");


        private void Admin_GymComparison_Load(object sender, EventArgs e)
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
                            GymName1.Items.Add(reader.GetString(0));
                            GymName2.Items.Add(reader.GetString(0));

                            // Assuming the value is a string
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

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if(GymName1.SelectedIndex!=-1 && GymName2.SelectedIndex!=-1)
            {
                richTextBox2.Clear();
                richTextBox1.Clear();
                using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
                {
                    string query = $@"
                    SELECT COUNT(*) AS TotalMembers
                        FROM Membership where Membership.Gym_ID = '{GymID1}'
                        AND Membership.StartDate >= DATEADD(month, -6, GETDATE()) ";

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int totalMembers = (int)command.ExecuteScalar();
                        richTextBox1.AppendText($"Total Members: {totalMembers}");
                    }

                    connection.Close();
                }
                using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
                {
                    string query = $@"
                    SELECT COUNT(*) AS TotalMembers
                        FROM Membership where Membership.Gym_ID = '{GymID2}' 
                        AND Membership.StartDate >= DATEADD(month, -6, GETDATE()) ";

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int totalMembers = (int)command.ExecuteScalar();
                        richTextBox2.AppendText($"Total Members: {totalMembers}");
                    }

                    connection.Close();
                }
            }
        }

        private void GymName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string query1 = $"SELECT Gym_ID FROM ( SELECT Gym_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Verified=1 ) AS SubQuery WHERE RowNum = '{GymName1.SelectedIndex + 1}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            GymID1 = (int)Cmd1.ExecuteScalar();
            connection.Close();
        }

        private void GymName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string query1 = $"SELECT Gym_ID FROM ( SELECT Gym_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Verified=1 ) AS SubQuery WHERE RowNum = '{GymName2.SelectedIndex + 1}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            GymID2 = (int)Cmd1.ExecuteScalar();
            connection.Close();
        }
    }
}
