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
    public partial class MemberWorkoutReport : Form
    {
        private Form prevForm;
        private int Member_ID;
        public MemberWorkoutReport(Form prevForm,int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Member_ID = id;
        }

        private void MemberWorkoutReport_Load(object sender, EventArgs e)
        {
            T_U.Visible = false;
            TrainerUsername.Visible = false;
            MachineName.Visible = false;   
            M_N.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            // SQL query to retrieve data
            string query = @"SELECT wp.Workout_ID, u.Username,
                   STRING_AGG(e.MuscleTarget, ', ') AS MuscleTargets,
                   wp.ExperienceRequired, wp.Purpose
            FROM WorkoutPlan wp
            JOIN Users u ON wp.CreatedBy = u.User_ID
            JOIN Exercise_Routine er ON wp.Workout_ID = er.Workout_ID
            JOIN Exercise e ON er.Routine_ID = e.Routine_ID
            WHERE 1=1 ";

            bool flag = false;

            if (purposebox.SelectedIndex != -1)
            {
                query += $" AND wp.purpose = '{purposebox.Text}'";
                flag = true;
            }

            if (experiencebox.SelectedIndex != -1)
            {
                query += $" AND wp.ExperienceRequired = '{experiencebox.Text}'";
                flag = true;
            }

            if (daysperweekbox.SelectedIndex != -1)
            {
                query += $" AND wp.DaysPerWeek = '{daysperweekbox.Text}'";
                flag = true;
            }

            if (userbox.SelectedIndex != -1)
            {
                if (userbox.SelectedIndex == 2)
                {
                    query += $" AND wp.CreaterType = 'trainer'";
                    flag = true;

                    if (!string.IsNullOrEmpty(TrainerUsername.Text))
                    {
                        query += $" AND u.Username = '{TrainerUsername.Text}'";
                    }
                }
                else if (userbox.SelectedIndex == 1)
                {
                    query += $" AND u.User_ID <> '{Member_ID}' AND wp.CreaterType <> 'trainer'";
                    flag = true;
                }
                else if (userbox.SelectedIndex == 0)
                {
                    query += $" AND u.User_ID = '{Member_ID}' AND wp.CreaterType <> 'trainer'";
                    flag = true;
                }
            }

            if (NotMachine.Checked)
            {
                if(MachineName1.Text!="")
                {
                    query += $" AND wp.Workout_ID NOT IN (SELECT er.Workout_ID FROM Exercise_Routine er JOIN Exercise e ON er.Routine_ID = e.Routine_ID WHERE e.MachineName = '{MachineName1.Text}')";
                    flag = true;
                }
                else
                {
                    query += $" AND wp.Workout_ID NOT IN (SELECT er.Workout_ID FROM Exercise_Routine er JOIN Exercise e ON er.Routine_ID = e.Routine_ID WHERE e.Machine_Req = 'True')";
                    flag = true;
                }
            }

            query += " GROUP BY wp.Workout_ID, u.Username, wp.ExperienceRequired, wp.Purpose ";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
            {
                // Open the connection
                connection.Open();

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing text in the RichTextBox
                        richTextBox1.Clear();

                        // Iterate through the results and append them to the RichTextBox
                        while (reader.Read())
                        {
                            // Format the data and append to the RichTextBox
                            string workoutID = reader["Workout_ID"].ToString();
                            string username = reader["Username"].ToString();
                            string muscleTarget = reader["MuscleTargets"].ToString();
                            string experienceRequired = reader["ExperienceRequired"].ToString();
                            string purpose = reader["Purpose"].ToString();

                            richTextBox1.AppendText($"Workout ID: {workoutID}\n");
                            richTextBox1.AppendText($"Username: {username}\n");
                            richTextBox1.AppendText($"Muscle Target: {muscleTarget}\n");
                            richTextBox1.AppendText($"Experience Required: {experienceRequired}\n");
                            richTextBox1.AppendText($"Purpose: {purpose}\n\n");
                        }
                    }
                }
                connection.Close();
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PurposeBulking_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void purposebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(userbox.SelectedIndex==2)
            {
                T_U.Visible=true;
                TrainerUsername.Visible=true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(Machine.Checked)
            {
                M_N.Visible=true;
                MachineName.Visible=true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            string query = $"Select Count(DISTINCT wp.Workout_ID) FROM WorkoutPlan wp JOIN Exercise_Routine er ON wp.Workout_ID = er.Workout_ID JOIN Exercise e ON er.Routine_ID = e.Routine_ID";
            if (Machine.Checked)
            {
                query += $" Where e.Machine_Req='True'";
                if(MachineName.Text!="")
                {
                    query += $" and e.MachineName='{MachineName.Text}'";
                }
            }
            else
            {
                query += $" Where e.Machine_Req<>'False'";
            }
            using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
            {
                // Open the connection
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int x = (int)command.ExecuteScalar();
                connection.Close();
                richTextBox2.AppendText($"Total Workout Plans:\n '{x}'");

            }

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void experiencebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MachineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MachineName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
