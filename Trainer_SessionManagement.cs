using System;
using System.Collections;
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
    public partial class Trainer_SessionManagement : Form
    {
        private Form prevForm;
        private int Trainer_ID;
        public Trainer_SessionManagement(Form prevForm, int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Trainer_ID = id;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");


        private void Trainer_SessionManagement_Load(object sender, EventArgs e)
        {
            CurrentStatus.Visible = false;
            Current.Visible = false;
            ChangeStatus.Visible = false;
            Change.Visible = false;


            string query = $"Select TrainingSession_ID from Training_Session where Trainer_ID='{Trainer_ID}'";
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
                            TrainingSession.Items.Add(reader.GetInt32(0).ToString());

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

        private void TrainingSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TrainingSession.SelectedIndex!=-1)
            {
                CurrentStatus.Visible = true;
                Current.Visible = true;
                ChangeStatus.Visible = true;
                Change.Visible = true;

                connection.Open();
                string query1 = $"Select SessionStatus From Training_Session where TrainingSession_ID='{TrainingSession.Text}'";
                SqlCommand cmd = new SqlCommand(query1, connection);
                string result4 = (string)cmd.ExecuteScalar();
                connection.Close();

                CurrentStatus.Text= result4;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(TrainingSession.SelectedIndex!=-1 && ChangeStatus.SelectedIndex!=-1)
            {
                connection.Open();
                string query = $"Update Training_Session set SessionStatus='{ChangeStatus.Text}' where TrainingSession_ID='{TrainingSession.Text}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Status Updated!");
                prevForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in the boxes!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();

            this.Close();
        }
    }
}
