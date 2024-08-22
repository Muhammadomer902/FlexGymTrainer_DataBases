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
    public partial class Admin_GymApproval : Form
    {
        private Form prevForm;
        private int Admin_ID;
        private int GymID;



        public Admin_GymApproval(Form prevForm, int admin_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            Admin_ID = admin_ID;
            GymID = -1;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void Admin_GymApproval_Load(object sender, EventArgs e)
        {
            GymAvailable.Items.Clear();
            string query = $"SELECT GymName FROM Gym Where Verified=0";

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
                        MessageBox.Show("No Pending Gym Request Available!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (GymAvailable != null && GymAvailable.SelectedIndex >= 0)
            {
                connection.Open();
                int temp = GymAvailable.SelectedIndex + 1;
                string query1 = $"SELECT Gym_ID FROM ( SELECT Gym_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Verified=0) AS SubQuery WHERE RowNum = '{temp}'";
                SqlCommand Cmd1 = new SqlCommand(query1, connection);
                GymID = (int)Cmd1.ExecuteScalar();
                connection.Close();

                connection.Open();
                string query = $"Update Gym Set Verified=1 WHERE Gym_ID = '{GymID}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Request Approved!");
                Admin_GymApproval_Load(sender, e);
            }
            else
            {
                MessageBox.Show("No Gym Selected!");
            }
            

        }
    }
}
