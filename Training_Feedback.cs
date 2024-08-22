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
    public partial class Training_Feedback : Form
    {
        private Form prevForm;
        private int Trainer_ID;
        public Training_Feedback(Form prevForm, int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Trainer_ID = id;

            using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
            {
                string query = $"SELECT Member_ID, rating FROM Feedback WHERE Trainer_ID = '{Trainer_ID}'";

                connection.Open();

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter for TrainerID
                   

                    // Execute the query and get a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing text in the RichTextBox
                        richTextBox1.Clear();

                        int totalRating = 0;
                        int count = 0;

                        // Iterate through the results and append them to the RichTextBox
                        while (reader.Read())
                        {
                            // Format the data and append to the RichTextBox
                            int memberID = reader.GetInt32(0);
                            int rating = reader.GetInt32(1);

                            richTextBox1.AppendText($"Member ID: {memberID}, Rating: {rating}\n");

                            // Calculate total rating
                            totalRating += rating;
                            count++;
                        }

                        // Calculate average rating
                        double averageRating = count > 0 ? (double)totalRating / count : 0;

                        // Display average rating in the RichTextBox
                        richTextBox1.AppendText($"Average Rating: {averageRating:F2}");
                    }
                }

                // Close the connection
                connection.Close();
            }

        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");


        private void Training_Feedback_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
