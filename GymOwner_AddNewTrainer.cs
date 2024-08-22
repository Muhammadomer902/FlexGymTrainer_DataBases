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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Database_Project
{
    public partial class GymOwner_AddNewTrainer : Form
    {
        private Form prevForm;
        private int GymOwner_ID;
        public GymOwner_AddNewTrainer(Form prevForm, int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.GymOwner_ID = gymOwner_ID;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void GoToSignup_Click(object sender, EventArgs e)
        {
            if(GymNames.SelectedIndex!=-1)
            {try
                {
                    if (username.Text != "" && password.Text != "" && f_name.Text != "" && m_name.Text != "" && l_name.Text != "" && gender.SelectedIndex != -1 && cnic.Text != "" && contact.Text != "" && exp.SelectedIndex != -1 && previousGym.Text != "" && DoB.Text != "" && Speciality.CheckedItems.Count != 0)
                    {
                        int v = checkUnique(username.Text);
                        if (v < 1)
                        {
                            connection.Open();
                            string userType = "Trainer";
                            string Query = $"insert into Users values('{username.Text}','{password.Text}','{userType}')";
                            SqlCommand cmd1 = new SqlCommand(Query, connection);
                            cmd1.ExecuteNonQuery();
                            connection.Close();

                            int Trainer_ID = getUserID(username.Text);

                            connection.Open();
                            string Query1 = $"insert into Trainer values ('{Trainer_ID}','{f_name.Text}','{m_name.Text}','{l_name.Text}','{contact.Text}','{gender.Text}','{Convert.ToDateTime(DoB.Text)}','{cnic.Text}','{exp.Text}','{previousGym.Text}')";
                            SqlCommand cmd = new SqlCommand(Query1, connection);
                            cmd.ExecuteNonQuery();
                            connection.Close();

                            connection.Open();
                            foreach (var checkedItem in Speciality.CheckedItems)
                            {
                                string insertQuery = $"INSERT INTO Trainer_Speciality VALUES ('{Trainer_ID}','{checkedItem}')";
                                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                                {
                                    command.ExecuteNonQuery();
                                }
                            }
                            connection.Close();

                            connection.Open();
                            string query1 = $"SELECT Gym_ID FROM ( SELECT GymName, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Owner_ID = '{GymOwner_ID}'and Verified=1) AS SubQuery WHERE RowNum = '{GymNames.SelectedIndex-1}'";
                            SqlCommand Cmd1 = new SqlCommand(query1, connection);
                            int GymID = (int)Cmd1.ExecuteScalar();
                            connection.Close();


                            connection.Open();
                            string query = $"insert into Gym_Trainer values ('{GymID}','{Trainer_ID}',1)";
                            SqlCommand Cmd = new SqlCommand(query, connection);
                            Cmd.ExecuteNonQuery();
                            connection.Close();



                            MessageBox.Show("Registered Successfully!");

                            prevForm.Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Username already Registered!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill the empty boxes!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select A Gym You Want To Register The Trainer In!");
            }
        }
        int checkUnique(string Username)
        {
            connection.Open();
            string query = "select count(*) from Users where Username='" + Username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }

        int getUserID(string Username)
        {
            connection.Open();
            string query = "select User_ID from Users where Username='" + Username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void GymOwner_AddNewTrainer_Load(object sender, EventArgs e)
        {
            // Connection string to your SQL Server database
            
            string query = $"SELECT GymName FROM Gym Where Owner_ID='{GymOwner_ID}' and Verified=1";

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
                            GymNames.Items.Add(reader.GetString(0)); // Assuming the value is a string
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Register Your Gym First!");
                        prevForm.Show();
                        this.Close();
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
