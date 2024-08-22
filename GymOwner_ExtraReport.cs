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
    public partial class GymOwner_ExtraReport : Form
    {
        private Form prevForm;
        private int GymOwner_ID;
        private int GymID; string gymname;
       
        public GymOwner_ExtraReport(Form prevForm, int gymOwner_ID)
        {
            this.prevForm = prevForm;
            this.GymOwner_ID = gymOwner_ID;
            GymID = -1;
            InitializeComponent();
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GymOwner_ExtraReport_Load(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
            {
                string query = $@"
    SELECT Membership_ID, Membership_Type, StartDate, Duration, Membership.Gym_ID
    FROM Membership
    INNER JOIN Gym ON Membership.Gym_ID = Gym.Gym_ID
    WHERE StartDate >= DATEADD(month, -{Month.Text}, GETDATE()) 
    AND Gym.Owner_ID = {GymOwner_ID}";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the connection
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing text in the RichTextBox
                        richTextBox1.Clear();

                        // Iterate through the results and append them to the RichTextBox
                        while (reader.Read())
                        {
                            richTextBox1.AppendText($"Membership ID: {reader["Membership_ID"]}\n");
                            richTextBox1.AppendText($"Membership Type: {reader["Membership_Type"]}\n");
                            richTextBox1.AppendText($"Start Date: {reader["StartDate"]}\n");
                            richTextBox1.AppendText($"Duration: {reader["Duration"]}\n");
                            richTextBox1.AppendText($"Gym ID: {reader["Gym_ID"]}\n\n");
                        }
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
