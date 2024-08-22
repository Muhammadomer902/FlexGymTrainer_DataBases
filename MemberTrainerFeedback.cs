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

namespace Database_Project
{
    public partial class MemberTrainerFeedback : Form
    {
        private Form prevForm;
        private int Member_ID;
        private int TrainingSession_ID;
        private int Trainer_ID;
        public MemberTrainerFeedback(Form prevForm, int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Member_ID = id;
            TrainingSession_ID = -1;
            Trainer_ID = -1;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void MemberTrainerFeedback_Load(object sender, EventArgs e)
        {

            connection.Open();
            string query1 = $"SELECT TrainingSession_ID FROM MemberUser Where Member_ID='{Member_ID}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            object result = Cmd1.ExecuteScalar();
            connection.Close();

            TrainingSession_ID = -1;
            if (result != DBNull.Value)
            {
                TrainingSession_ID = (int)result;

                connection.Open();
                string query3 = $"SELECT SessionStatus FROM Training_Session Where TrainingSession_ID='{TrainingSession_ID}'";
                SqlCommand Cmd3 = new SqlCommand(query3, connection);
                object result3 = Cmd3.ExecuteScalar();
                connection.Close();
                
                if (result3 != DBNull.Value)
                {
                    string status = (string)result3;

                    if(status=="Pending")
                    {
                        MessageBox.Show("You Have No Training Session!\nYour Request Is being Processed!");
                        prevForm.Show();
                        this.Close();
                    }
                    else{

                    connection.Open();
                    string query2 = $"SELECT Trainer_ID FROM Training_Session Where TrainingSession_ID='{TrainingSession_ID}'";
                    SqlCommand Cmd2 = new SqlCommand(query2, connection);
                    Trainer_ID = (int)Cmd2.ExecuteScalar();
                    connection.Close();

                    connection.Open();
                    string query4 = $"SELECT Count(*) FROM Feedback Where Trainer_ID='{Trainer_ID}' and Member_ID='{Member_ID}'";
                    SqlCommand Cmd4 = new SqlCommand(query4, connection);
                    int result4 = (int)Cmd4.ExecuteScalar();
                    connection.Close();

                    if (result4 > 0)
                    {
                        MessageBox.Show("You Have Already Given Feedback!");
                        prevForm.Show();
                        this.Close();
                    }
                    string query = $"SELECT Users.Username " +
                                   $"FROM Users " +
                                   $"JOIN Training_Session ON Users.User_ID = Training_Session.Trainer_ID " +
                                   $"WHERE Training_Session.TrainingSession_ID = '{TrainingSession_ID}'";

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
                }
                else
                {
                    MessageBox.Show("You Have No Training Session!");
                    prevForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You Have No Training Session!");
                prevForm.Show();
                this.Close();
            }
            // Connection string to your SQL Server database


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(TrainerAvailable.SelectedIndex != -1 && Rating.Value!=0)
            { 

                connection.Open();
                string query = $"insert into Feedback values ('{Member_ID}','{Trainer_ID}','{Rating.Value}')";
                SqlCommand Cmd = new SqlCommand(query, connection);
                Cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Trainer Feedback Given!");
                prevForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Trainer Not Selected OR Rating is Zero!");
            }
        }
    }
}
