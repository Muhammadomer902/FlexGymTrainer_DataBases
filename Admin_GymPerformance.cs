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
    public partial class Admin_GymPerformance : Form
    {
        private Form prevForm;
        private int Admin_ID;
        public Admin_GymPerformance(Form prevForm, int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Admin_ID = gymOwner_ID;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");


        private void Admin_GymPerformance_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
            {
                string query = @"
                        SELECT g.GymName AS Gym_Name, go.FirstName + ' ' + go.LastName AS Gym_Owner, COUNT(mu.Member_ID) AS Total_Members
                        FROM Gym g
                        JOIN GymOwner go ON g.Owner_ID = go.GymOwner_ID
                        LEFT JOIN Membership m ON g.Gym_ID = m.Gym_ID
                        LEFT JOIN MemberUser mu ON m.Membership_ID = mu.Membership_ID
                       
                        GROUP BY g.GymName, go.FirstName, go.LastName";

                connection.Open();

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                 

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing text in the RichTextBox
                        richTextBox1.Clear();

                        // Iterate through the results and append them to the RichTextBox
                        while (reader.Read())
                        {
                            // Format the data and append to the RichTextBox
                            richTextBox1.AppendText($"Gym Name: {reader["Gym_Name"]}\n");
                            richTextBox1.AppendText($"Gym Owner: {reader["Gym_Owner"]}\n");
                            richTextBox1.AppendText($"Total Members: {reader["Total_Members"]}\n");
                            richTextBox1.AppendText("--------------------\n");
                        }
                    }
                }

                // Close the connection
                connection.Close();
            }

        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
