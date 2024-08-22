using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Database_Project
{
    public partial class MemberWorkoutPlanning : Form
    {
        private Form prevForm;
        private int Member_ID;
        private bool check1;
        private bool day1_check;
        private bool day2_check;
        private bool day3_check;
        private bool day4_check;
        private bool day5_check;

        public MemberWorkoutPlanning(Form prevForm, int member_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            Member_ID = member_ID;
            check1 = false;
            day1_check = false;
            day2_check = false;
            day3_check = false;
            day4_check = false;
            day5_check = false;
        }

      

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");


        private void MemberWorkoutPlanning_Load(object sender, EventArgs e)
        {
            D1_L1.Visible = false;
            D1_L2.Visible = false;
            D1_L3.Visible = false;
            D1_L4.Visible = false;
            D1_L5.Visible = false;
            Day1.Visible = false;
            D1_muscleTarget.Visible = false;
            Day1_Sh_Ex.Visible = false;
            Day1_Ab_Ex.Visible = false;
            Day1_Ba_Ex.Visible = false; 
            Day1_Bi_Ex.Visible = false; 
            Day1_Ch_Ex.Visible = false; 
            Day1_Lg_Ex.Visible = false;
            Day1_Sets.Visible = false;
            Day1_Reps.Visible = false;
            Day1_Time.Visible = false;
            D1_save.Visible = false;
            Day1_Machine.Visible = false;
            D1_MachineName.Visible = false;
            D1_MN.Visible = false;

            D2_L1.Visible = false;
            D2_L2.Visible = false;
            D2_L3.Visible = false;
            D2_L4.Visible = false;
            D2_L5.Visible = false;
            Day2.Visible = false;
            D2_muscleTarget.Visible = false;
            Day2_Sh_Ex.Visible = false;
            Day2_Ab_Ex.Visible = false;
            Day2_Ba_Ex.Visible = false;
            Day2_Bi_Ex.Visible = false;
            Day2_Ch_Ex.Visible = false;
            Day2_Lg_Ex.Visible = false;
            Day2_Sets.Visible = false;
            Day2_Reps.Visible = false;
            Day2_Time.Visible = false;
            D2_save.Visible = false;
            Day2_Machine.Visible = false;
            D2_MachineName.Visible = false;
            D2_MN.Visible = false;



            D3_L1.Visible = false;
            D3_L2.Visible = false;
            D3_L3.Visible = false;
            D3_L4.Visible = false;
            D3_L5.Visible = false;
            Day3.Visible = false;
            D3_muscleTarget.Visible = false;
            Day3_Sh_Ex.Visible = false;
            Day3_Ab_Ex.Visible = false;
            Day3_Ba_Ex.Visible = false;
            Day3_Bi_Ex.Visible = false;
            Day3_Ch_Ex.Visible = false;
            Day3_Lg_Ex.Visible = false;
            Day3_Sets.Visible = false;
            Day3_Reps.Visible = false;
            Day3_Time.Visible = false;
            D3_save.Visible = false;
            Day3_Machine.Visible = false;
            D3_MachineName.Visible = false;
            D3_MN.Visible = false;



            D4_L1.Visible = false;
            D4_L2.Visible = false;
            D4_L3.Visible = false;
            D4_L4.Visible = false;
            D4_L5.Visible = false;
            Day4.Visible = false;
            D4_muscleTarget.Visible = false;
            Day4_Sh_Ex.Visible = false;
            Day4_Ab_Ex.Visible = false;
            Day4_Ba_Ex.Visible = false;
            Day4_Bi_Ex.Visible = false;
            Day4_Ch_Ex.Visible = false;
            Day4_Lg_Ex.Visible = false;
            Day4_Sets.Visible = false;
            Day4_Reps.Visible = false;
            Day4_Time.Visible = false;
            D4_save.Visible = false;
            Day4_Machine.Visible = false;
            D4_MachineName.Visible = false;
            D4_MN.Visible = false;



            D5_L1.Visible = false;
            D5_L2.Visible = false;
            D5_L3.Visible = false;
            D5_L4.Visible = false;
            D5_L5.Visible = false;
            Day5.Visible = false;
            D5_muscleTarget.Visible = false;
            Day5_Sh_Ex.Visible = false;
            Day5_Ab_Ex.Visible = false;
            Day5_Ba_Ex.Visible = false;
            Day5_Bi_Ex.Visible = false;
            Day5_Ch_Ex.Visible = false;
            Day5_Lg_Ex.Visible = false;
            Day5_Sets.Visible = false;
            Day5_Reps.Visible = false;
            Day5_Time.Visible = false;
            D5_save.Visible = false;
            Day5_Machine.Visible = false;
            D5_MachineName.Visible = false;
            D5_MN.Visible = false;





        }



        private void DaysPerWeek_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            if(!check1)
            {
                prevForm.Show();
                this.Close();
            }
        }

        private void D1_muscleTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(D1_muscleTarget.SelectedIndex != -1)
            {
                string targetMuscle=D1_muscleTarget.Text;
                if(targetMuscle=="Shoulders")
                {
                    Day1_Sh_Ex.Visible = true;
                    Day1_Ab_Ex.Visible = false;
                    Day1_Ba_Ex.Visible = false;
                    Day1_Bi_Ex.Visible = false;
                    Day1_Ch_Ex.Visible = false;
                    Day1_Lg_Ex.Visible = false;
                }
                else if(targetMuscle== "Biceps/Triceps")
                {
                    Day1_Sh_Ex.Visible = false;
                    Day1_Ab_Ex.Visible = false;
                    Day1_Ba_Ex.Visible = false;
                    Day1_Bi_Ex.Visible = true;
                    Day1_Ch_Ex.Visible = false;
                    Day1_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Chest")
                {
                    Day1_Sh_Ex.Visible = false;
                    Day1_Ab_Ex.Visible = false;
                    Day1_Ba_Ex.Visible = false;
                    Day1_Bi_Ex.Visible = false;
                    Day1_Ch_Ex.Visible = true;
                    Day1_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Abs")
                {
                    Day1_Sh_Ex.Visible = false;
                    Day1_Ab_Ex.Visible = true;
                    Day1_Ba_Ex.Visible = false;
                    Day1_Bi_Ex.Visible = false;
                    Day1_Ch_Ex.Visible = false;
                    Day1_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Leg")
                {
                    Day1_Sh_Ex.Visible = false;
                    Day1_Ab_Ex.Visible = false;
                    Day1_Ba_Ex.Visible = false;
                    Day1_Bi_Ex.Visible = false;
                    Day1_Ch_Ex.Visible = false;
                    Day1_Lg_Ex.Visible = true;
                }
                else if (targetMuscle == "Back")
                {
                    Day1_Sh_Ex.Visible = false;
                    Day1_Ab_Ex.Visible = false;
                    Day1_Ba_Ex.Visible = true;
                    Day1_Bi_Ex.Visible = false;
                    Day1_Ch_Ex.Visible = false;
                    Day1_Lg_Ex.Visible = false;
                }
            }
        }

        private void D1_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!day1_check)
                {
                    if (D1_muscleTarget.SelectedIndex != -1 && (Day1_Ab_Ex.SelectedIndex != -1 || Day1_Ch_Ex.SelectedIndex != -1 || Day1_Sh_Ex.SelectedIndex != -1 || Day1_Ba_Ex.SelectedIndex != -1 || Day1_Lg_Ex.SelectedIndex != -1 || Day1_Bi_Ex.SelectedIndex != -1) && Day1_Sets.Value > 0 && Day1_Reps.Value > 0 && Day1_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();
                        int dayNo = 1;

                        connection.Open();

                        string query = $"insert into Exercise_Routine(Workout_ID,DayNo) values('{workout_id}','{dayNo}')";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.ExecuteNonQuery();
                        
                        connection.Close();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day1_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D1_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day1_Ab_Ex.ResetText();
                        Day1_Ba_Ex.ResetText();
                        Day1_Bi_Ex.ResetText();
                        Day1_Ch_Ex.ResetText();
                        Day1_Lg_Ex.ResetText();
                        Day1_Sh_Ex.ResetText();
                        Day1_Sets.ResetText();
                        Day1_Reps.ResetText();
                        Day1_Time.ResetText();
                        Day1_Machine.Checked = false;




                        day1_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
                else
                {
                    if (D1_muscleTarget.SelectedIndex != -1 && (Day1_Ab_Ex.SelectedIndex != -1 || Day1_Ch_Ex.SelectedIndex != -1 || Day1_Sh_Ex.SelectedIndex != -1 || Day1_Ba_Ex.SelectedIndex != -1 || Day1_Lg_Ex.SelectedIndex != -1 || Day1_Bi_Ex.SelectedIndex != -1) && Day1_Sets.Value > 0 && Day1_Reps.Value > 0 && Day1_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day1_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D1_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day1_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D1_muscleTarget.Text}','{Ex_name}','{Day1_Sets.Value}','{Day1_Reps.Value}','{Day1_Time.Value}','{temp_machine}','{D1_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day1_Ab_Ex.ResetText();
                        Day1_Ba_Ex.ResetText();
                        Day1_Bi_Ex.ResetText();
                        Day1_Ch_Ex.ResetText();
                        Day1_Lg_Ex.ResetText();
                        Day1_Sh_Ex.ResetText();
                        Day1_Sets.ResetText();
                        Day1_Reps.ResetText();
                        Day1_Time.ResetText();
                        Day1_Machine.Checked = false;




                        day1_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int findWorkout_ID()
        {
            connection.Open();
            string query = "select Workout_ID from WorkoutPlan where CreatedBy='" + Member_ID + "' Order by Workout_ID DESC";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }

        int findRoutine_ID(int id)
        {
            connection.Open();
            string query = "select Routine_ID from Exercise_Routine where Workout_ID='" + id + "'Order by Routine_ID DESC";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void D2_muscleTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D2_muscleTarget.SelectedIndex != -1)
            {
                string targetMuscle = D2_muscleTarget.Text;
                if (targetMuscle == "Shoulders")
                {
                    Day2_Sh_Ex.Visible = true;
                    Day2_Ab_Ex.Visible = false;
                    Day2_Ba_Ex.Visible = false;
                    Day2_Bi_Ex.Visible = false;
                    Day2_Ch_Ex.Visible = false;
                    Day2_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Biceps/Triceps")
                {
                    Day2_Sh_Ex.Visible = false;
                    Day2_Ab_Ex.Visible = false;
                    Day2_Ba_Ex.Visible = false;
                    Day2_Bi_Ex.Visible = true;
                    Day2_Ch_Ex.Visible = false;
                    Day2_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Chest")
                {
                    Day2_Sh_Ex.Visible = false;
                    Day2_Ab_Ex.Visible = false;
                    Day2_Ba_Ex.Visible = false;
                    Day2_Bi_Ex.Visible = false;
                    Day2_Ch_Ex.Visible = true;
                    Day2_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Abs")
                {
                    Day2_Sh_Ex.Visible = false;
                    Day2_Ab_Ex.Visible = true;
                    Day2_Ba_Ex.Visible = false;
                    Day2_Bi_Ex.Visible = false;
                    Day2_Ch_Ex.Visible = false;
                    Day2_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Leg")
                {
                    Day2_Sh_Ex.Visible = false;
                    Day2_Ab_Ex.Visible = false;
                    Day2_Ba_Ex.Visible = false;
                    Day2_Bi_Ex.Visible = false;
                    Day2_Ch_Ex.Visible = false;
                    Day2_Lg_Ex.Visible = true;
                }
                else if (targetMuscle == "Back")
                {
                    Day2_Sh_Ex.Visible = false;
                    Day2_Ab_Ex.Visible = false;
                    Day2_Ba_Ex.Visible = true;
                    Day2_Bi_Ex.Visible = false;
                    Day2_Ch_Ex.Visible = false;
                    Day2_Lg_Ex.Visible = false;
                }
            }
        }

        private void D3_muscleTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D3_muscleTarget.SelectedIndex != -1)
            {
                string targetMuscle = D3_muscleTarget.Text;
                if (targetMuscle == "Shoulders")
                {
                    Day3_Sh_Ex.Visible = true;
                    Day3_Ab_Ex.Visible = false;
                    Day3_Ba_Ex.Visible = false;
                    Day3_Bi_Ex.Visible = false;
                    Day3_Ch_Ex.Visible = false;
                    Day3_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Biceps/Triceps")
                {
                    Day3_Sh_Ex.Visible = false;
                    Day3_Ab_Ex.Visible = false;
                    Day3_Ba_Ex.Visible = false;
                    Day3_Bi_Ex.Visible = true;
                    Day3_Ch_Ex.Visible = false;
                    Day3_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Chest")
                {
                    Day3_Sh_Ex.Visible = false;
                    Day3_Ab_Ex.Visible = false;
                    Day3_Ba_Ex.Visible = false;
                    Day3_Bi_Ex.Visible = false;
                    Day3_Ch_Ex.Visible = true;
                    Day3_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Abs")
                {
                    Day3_Sh_Ex.Visible = false;
                    Day3_Ab_Ex.Visible = true;
                    Day3_Ba_Ex.Visible = false;
                    Day3_Bi_Ex.Visible = false;
                    Day3_Ch_Ex.Visible = false;
                    Day3_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Leg")
                {
                    Day3_Sh_Ex.Visible = false;
                    Day3_Ab_Ex.Visible = false;
                    Day3_Ba_Ex.Visible = false;
                    Day3_Bi_Ex.Visible = false;
                    Day3_Ch_Ex.Visible = false;
                    Day3_Lg_Ex.Visible = true;
                }
                else if (targetMuscle == "Back")
                {
                    Day3_Sh_Ex.Visible = false;
                    Day3_Ab_Ex.Visible = false;
                    Day3_Ba_Ex.Visible = true;
                    Day3_Bi_Ex.Visible = false;
                    Day3_Ch_Ex.Visible = false;
                    Day3_Lg_Ex.Visible = false;
                }
            }
        }

        private void D4_muscleTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D4_muscleTarget.SelectedIndex != -1)
            {
                string targetMuscle = D4_muscleTarget.Text;
                if (targetMuscle == "Shoulders")
                {
                    Day4_Sh_Ex.Visible = true;
                    Day4_Ab_Ex.Visible = false;
                    Day4_Ba_Ex.Visible = false;
                    Day4_Bi_Ex.Visible = false;
                    Day4_Ch_Ex.Visible = false;
                    Day4_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Biceps/Triceps")
                {
                    Day4_Sh_Ex.Visible = false;
                    Day4_Ab_Ex.Visible = false;
                    Day4_Ba_Ex.Visible = false;
                    Day4_Bi_Ex.Visible = true;
                    Day4_Ch_Ex.Visible = false;
                    Day4_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Chest")
                {
                    Day4_Sh_Ex.Visible = false;
                    Day4_Ab_Ex.Visible = false;
                    Day4_Ba_Ex.Visible = false;
                    Day4_Bi_Ex.Visible = false;
                    Day4_Ch_Ex.Visible = true;
                    Day4_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Abs")
                {
                    Day4_Sh_Ex.Visible = false;
                    Day4_Ab_Ex.Visible = true;
                    Day4_Ba_Ex.Visible = false;
                    Day4_Bi_Ex.Visible = false;
                    Day4_Ch_Ex.Visible = false;
                    Day4_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Leg")
                {
                    Day4_Sh_Ex.Visible = false;
                    Day4_Ab_Ex.Visible = false;
                    Day4_Ba_Ex.Visible = false;
                    Day4_Bi_Ex.Visible = false;
                    Day4_Ch_Ex.Visible = false;
                    Day4_Lg_Ex.Visible = true;
                }
                else if (targetMuscle == "Back")
                {
                    Day4_Sh_Ex.Visible = false;
                    Day4_Ab_Ex.Visible = false;
                    Day4_Ba_Ex.Visible = true;
                    Day4_Bi_Ex.Visible = false;
                    Day4_Ch_Ex.Visible = false;
                    Day4_Lg_Ex.Visible = false;
                }
            }
        }

        private void D5_muscleTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (D5_muscleTarget.SelectedIndex != -1)
            {
                string targetMuscle = D5_muscleTarget.Text;
                if (targetMuscle == "Shoulders")
                {
                    Day5_Sh_Ex.Visible = true;
                    Day5_Ab_Ex.Visible = false;
                    Day5_Ba_Ex.Visible = false;
                    Day5_Bi_Ex.Visible = false;
                    Day5_Ch_Ex.Visible = false;
                    Day5_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Biceps/Triceps")
                {
                    Day5_Sh_Ex.Visible = false;
                    Day5_Ab_Ex.Visible = false;
                    Day5_Ba_Ex.Visible = false;
                    Day5_Bi_Ex.Visible = true;
                    Day5_Ch_Ex.Visible = false;
                    Day5_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Chest")
                {
                    Day5_Sh_Ex.Visible = false;
                    Day5_Ab_Ex.Visible = false;
                    Day5_Ba_Ex.Visible = false;
                    Day5_Bi_Ex.Visible = false;
                    Day5_Ch_Ex.Visible = true;
                    Day5_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Abs")
                {
                    Day5_Sh_Ex.Visible = false;
                    Day5_Ab_Ex.Visible = true;
                    Day5_Ba_Ex.Visible = false;
                    Day5_Bi_Ex.Visible = false;
                    Day5_Ch_Ex.Visible = false;
                    Day5_Lg_Ex.Visible = false;
                }
                else if (targetMuscle == "Leg")
                {
                    Day5_Sh_Ex.Visible = false;
                    Day5_Ab_Ex.Visible = false;
                    Day5_Ba_Ex.Visible = false;
                    Day5_Bi_Ex.Visible = false;
                    Day5_Ch_Ex.Visible = false;
                    Day5_Lg_Ex.Visible = true;
                }
                else if (targetMuscle == "Back")
                {
                    Day5_Sh_Ex.Visible = false;
                    Day5_Ab_Ex.Visible = false;
                    Day5_Ba_Ex.Visible = true;
                    Day5_Bi_Ex.Visible = false;
                    Day5_Ch_Ex.Visible = false;
                    Day5_Lg_Ex.Visible = false;
                }
            }
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            if (!check1 && DaysPerWeek.SelectedIndex != -1 && purpose.SelectedIndex!=-1)
            {
                string day = DaysPerWeek.Text;
                if (day == "3")
                {
                    D1_L1.Visible = true;
                    D1_L2.Visible = true;
                    D1_L3.Visible = true;
                    D1_L4.Visible = true;
                    D1_L5.Visible = true;
                    Day1.Visible = true;
                    D1_muscleTarget.Visible = true;
                    Day1_Sh_Ex.Visible = true;
                    Day1_Ab_Ex.Visible = true;
                    Day1_Ba_Ex.Visible = true;
                    Day1_Bi_Ex.Visible = true;
                    Day1_Ch_Ex.Visible = true;
                    Day1_Lg_Ex.Visible = true;
                    Day1_Sets.Visible = true;
                    Day1_Reps.Visible = true;
                    Day1_Time.Visible = true;
                    D1_save.Visible = true;
                    Day1_Machine.Visible = true;

                    D2_L1.Visible = true;
                    D2_L2.Visible = true;
                    D2_L3.Visible = true;
                    D2_L4.Visible = true;
                    D2_L5.Visible = true;
                    Day2.Visible = true;
                    D2_muscleTarget.Visible = true;
                    Day2_Sh_Ex.Visible = true;
                    Day2_Ab_Ex.Visible = true;
                    Day2_Ba_Ex.Visible = true;
                    Day2_Bi_Ex.Visible = true;
                    Day2_Ch_Ex.Visible = true;
                    Day2_Lg_Ex.Visible = true;
                    Day2_Sets.Visible = true;
                    Day2_Reps.Visible = true;
                    Day2_Time.Visible = true;
                    D2_save.Visible = true;
                    Day2_Machine.Visible = true;

                    D3_L1.Visible = true;
                    D3_L2.Visible = true;
                    D3_L3.Visible = true;
                    D3_L4.Visible = true;
                    D3_L5.Visible = true;
                    Day3.Visible = true;
                    D3_muscleTarget.Visible = true;
                    Day3_Sh_Ex.Visible = true;
                    Day3_Ab_Ex.Visible = true;
                    Day3_Ba_Ex.Visible = true;
                    Day3_Bi_Ex.Visible = true;
                    Day3_Ch_Ex.Visible = true;
                    Day3_Lg_Ex.Visible = true;
                    Day3_Sets.Visible = true;
                    Day3_Reps.Visible = true;
                    Day3_Time.Visible = true;
                    D3_save.Visible = true;
                    Day3_Machine.Visible = true;

                    D4_L1.Visible = false;
                    D4_L2.Visible = false;
                    D4_L3.Visible = false;
                    D4_L4.Visible = false;
                    D4_L5.Visible = false;
                    Day4.Visible = false;
                    D4_muscleTarget.Visible = false;
                    Day4_Sh_Ex.Visible = false;
                    Day4_Ab_Ex.Visible = false;
                    Day4_Ba_Ex.Visible = false;
                    Day4_Bi_Ex.Visible = false;
                    Day4_Ch_Ex.Visible = false;
                    Day4_Lg_Ex.Visible = false;
                    Day4_Sets.Visible = false;
                    Day4_Reps.Visible = false;
                    Day4_Time.Visible = false;
                    D4_save.Visible = false;
                    Day4_Machine.Visible = false;

                    D5_L1.Visible = false;
                    D5_L2.Visible = false;
                    D5_L3.Visible = false;
                    D5_L4.Visible = false;
                    D5_L5.Visible = false;
                    Day5.Visible = false;
                    D5_muscleTarget.Visible = false;
                    Day5_Sh_Ex.Visible = false;
                    Day5_Ab_Ex.Visible = false;
                    Day5_Ba_Ex.Visible = false;
                    Day5_Bi_Ex.Visible = false;
                    Day5_Ch_Ex.Visible = false;
                    Day5_Lg_Ex.Visible = false;
                    Day5_Sets.Visible = false;
                    Day5_Reps.Visible = false;
                    Day5_Time.Visible = false;
                    D5_save.Visible = false;
                    Day5_Machine.Visible = false;
                }
                else if (day == "5")
                {
                    D1_L1.Visible = true;
                    D1_L2.Visible = true;
                    D1_L3.Visible = true;
                    D1_L4.Visible = true;
                    D1_L5.Visible = true;
                    Day1.Visible = true;
                    D1_muscleTarget.Visible = true;
                    Day1_Sh_Ex.Visible = true;
                    Day1_Ab_Ex.Visible = true;
                    Day1_Ba_Ex.Visible = true;
                    Day1_Bi_Ex.Visible = true;
                    Day1_Ch_Ex.Visible = true;
                    Day1_Lg_Ex.Visible = true;
                    Day1_Sets.Visible = true;
                    Day1_Reps.Visible = true;
                    Day1_Time.Visible = true;
                    D1_save.Visible = true;
                    Day1_Machine.Visible = true;

                    D2_L1.Visible = true;
                    D2_L2.Visible = true;
                    D2_L3.Visible = true;
                    D2_L4.Visible = true;
                    D2_L5.Visible = true;
                    Day2.Visible = true;
                    D2_muscleTarget.Visible = true;
                    Day2_Sh_Ex.Visible = true;
                    Day2_Ab_Ex.Visible = true;
                    Day2_Ba_Ex.Visible = true;
                    Day2_Bi_Ex.Visible = true;
                    Day2_Ch_Ex.Visible = true;
                    Day2_Lg_Ex.Visible = true;
                    Day2_Sets.Visible = true;
                    Day2_Reps.Visible = true;
                    Day2_Time.Visible = true;
                    D2_save.Visible = true;
                    Day2_Machine.Visible = true;

                    D3_L1.Visible = true;
                    D3_L2.Visible = true;
                    D3_L3.Visible = true;
                    D3_L4.Visible = true;
                    D3_L5.Visible = true;
                    Day3.Visible = true;
                    D3_muscleTarget.Visible = true;
                    Day3_Sh_Ex.Visible = true;
                    Day3_Ab_Ex.Visible = true;
                    Day3_Ba_Ex.Visible = true;
                    Day3_Bi_Ex.Visible = true;
                    Day3_Ch_Ex.Visible = true;
                    Day3_Lg_Ex.Visible = true;
                    Day3_Sets.Visible = true;
                    Day3_Reps.Visible = true;
                    Day3_Time.Visible = true;
                    D3_save.Visible = true;
                    Day3_Machine.Visible = true;

                    D4_L1.Visible = true;
                    D4_L2.Visible = true;
                    D4_L3.Visible = true;
                    D4_L4.Visible = true;
                    D4_L5.Visible = true;
                    Day4.Visible = true;
                    D4_muscleTarget.Visible = true;
                    Day4_Sh_Ex.Visible = true;
                    Day4_Ab_Ex.Visible = true;
                    Day4_Ba_Ex.Visible = true;
                    Day4_Bi_Ex.Visible = true;
                    Day4_Ch_Ex.Visible = true;
                    Day4_Lg_Ex.Visible = true;
                    Day4_Sets.Visible = true;
                    Day4_Reps.Visible = true;
                    Day4_Time.Visible = true;
                    D4_save.Visible = true;
                    Day4_Machine.Visible = true;

                    D5_L1.Visible = true;
                    D5_L2.Visible = true;
                    D5_L3.Visible = true;
                    D5_L4.Visible = true;
                    D5_L5.Visible = true;
                    Day5.Visible = true;
                    D5_muscleTarget.Visible = true;
                    Day5_Sh_Ex.Visible = true;
                    Day5_Ab_Ex.Visible = true;
                    Day5_Ba_Ex.Visible = true;
                    Day5_Bi_Ex.Visible = true;
                    Day5_Ch_Ex.Visible = true;
                    Day5_Lg_Ex.Visible = true;
                    Day5_Sets.Visible = true;
                    Day5_Reps.Visible = true;
                    Day5_Time.Visible = true;
                    D5_save.Visible = true;
                    Day5_Machine.Visible = true;
                }
                string createrType="Member";
                connection.Open();
                string Query = $"insert into WorkoutPlan(DaysPerWeek,Purpose,CreatedBy,CreaterType,ExperienceRequired) values('{DaysPerWeek.Text}','{purpose.Text}','{Member_ID}','{createrType}','{ExpReq.Text}')";
                SqlCommand cmd = new SqlCommand(Query, connection);
                check1= true;
                cmd.ExecuteNonQuery();

                connection.Close();

            }
            else
            {
                MessageBox.Show("Please Fill In The Boxes!");
            }
        }

        private void D2_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!day2_check)
                {
                    if (D2_muscleTarget.SelectedIndex != -1 && (Day2_Ab_Ex.SelectedIndex != -1 || Day2_Ch_Ex.SelectedIndex != -1 || Day2_Sh_Ex.SelectedIndex != -1 || Day2_Ba_Ex.SelectedIndex != -1 || Day2_Lg_Ex.SelectedIndex != -1 || Day2_Bi_Ex.SelectedIndex != -1) && Day2_Sets.Value > 0 && Day2_Reps.Value > 0 && Day2_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();
                        int dayNo = 2;

                        connection.Open();

                        string query = $"insert into Exercise_Routine(Workout_ID,DayNo) values('{workout_id}','{dayNo}')";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day2_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D2_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day2_Ab_Ex.ResetText();
                        Day2_Ba_Ex.ResetText();
                        Day2_Bi_Ex.ResetText();
                        Day2_Ch_Ex.ResetText();
                        Day2_Lg_Ex.ResetText();
                        Day2_Sh_Ex.ResetText();
                        Day2_Sets.ResetText();
                        Day2_Reps.ResetText();
                        Day2_Time.ResetText();
                        Day2_Machine.Checked = false;




                        day2_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
                else
                {
                    if (D2_muscleTarget.SelectedIndex != -1 && (Day2_Ab_Ex.SelectedIndex != -1 || Day2_Ch_Ex.SelectedIndex != -1 || Day2_Sh_Ex.SelectedIndex != -1 || Day2_Ba_Ex.SelectedIndex != -1 || Day2_Lg_Ex.SelectedIndex != -1 || Day2_Bi_Ex.SelectedIndex != -1) && Day2_Sets.Value > 0 && Day2_Reps.Value > 0 && Day2_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day2_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D2_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day2_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D2_muscleTarget.Text}','{Ex_name}','{Day2_Sets.Value}','{Day2_Reps.Value}','{Day2_Time.Value}','{temp_machine}','{D2_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day2_Ab_Ex.ResetText();
                        Day2_Ba_Ex.ResetText();
                        Day2_Bi_Ex.ResetText();
                        Day2_Ch_Ex.ResetText();
                        Day2_Lg_Ex.ResetText();
                        Day2_Sh_Ex.ResetText();
                        Day2_Sets.ResetText();
                        Day2_Reps.ResetText();
                        Day2_Time.ResetText();
                        Day2_Machine.Checked = false;




                        day2_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void D3_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!day3_check)
                {
                    if (D3_muscleTarget.SelectedIndex != -1 && (Day3_Ab_Ex.SelectedIndex != -1 || Day3_Ch_Ex.SelectedIndex != -1 || Day3_Sh_Ex.SelectedIndex != -1 || Day3_Ba_Ex.SelectedIndex != -1 || Day3_Lg_Ex.SelectedIndex != -1 || Day3_Bi_Ex.SelectedIndex != -1) && Day3_Sets.Value > 0 && Day3_Reps.Value > 0 && Day3_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();
                        int dayNo = 3;

                        connection.Open();

                        string query = $"insert into Exercise_Routine(Workout_ID,DayNo) values('{workout_id}','{dayNo}')";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day3_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D3_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day3_Ab_Ex.ResetText();
                        Day3_Ba_Ex.ResetText();
                        Day3_Bi_Ex.ResetText();
                        Day3_Ch_Ex.ResetText();
                        Day3_Lg_Ex.ResetText();
                        Day3_Sh_Ex.ResetText();
                        Day3_Sets.ResetText();
                        Day3_Reps.ResetText();
                        Day3_Time.ResetText();
                        Day3_Machine.Checked = false;




                        day3_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
                else
                {
                    if (D3_muscleTarget.SelectedIndex != -1 && (Day3_Ab_Ex.SelectedIndex != -1 || Day3_Ch_Ex.SelectedIndex != -1 || Day3_Sh_Ex.SelectedIndex != -1 || Day3_Ba_Ex.SelectedIndex != -1 || Day3_Lg_Ex.SelectedIndex != -1 || Day3_Bi_Ex.SelectedIndex != -1) && Day3_Sets.Value > 0 && Day3_Reps.Value > 0 && Day3_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day3_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D3_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day3_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D3_muscleTarget.Text}','{Ex_name}','{Day3_Sets.Value}','{Day3_Reps.Value}','{Day3_Time.Value}','{temp_machine}','{D3_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day3_Ab_Ex.ResetText();
                        Day3_Ba_Ex.ResetText();
                        Day3_Bi_Ex.ResetText();
                        Day3_Ch_Ex.ResetText();
                        Day3_Lg_Ex.ResetText();
                        Day3_Sh_Ex.ResetText();
                        Day3_Sets.ResetText();
                        Day3_Reps.ResetText();
                        Day3_Time.ResetText();
                        Day3_Machine.Checked = false;




                        day3_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void D4_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!day4_check)
                {
                    if (D4_muscleTarget.SelectedIndex != -1 && (Day4_Ab_Ex.SelectedIndex != -1 || Day4_Ch_Ex.SelectedIndex != -1 || Day4_Sh_Ex.SelectedIndex != -1 || Day4_Ba_Ex.SelectedIndex != -1 || Day4_Lg_Ex.SelectedIndex != -1 || Day4_Bi_Ex.SelectedIndex != -1) && Day4_Sets.Value > 0 && Day4_Reps.Value > 0 && Day4_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();
                        int dayNo = 4;

                        connection.Open();

                        string query = $"insert into Exercise_Routine(Workout_ID,DayNo) values('{workout_id}','{dayNo}')";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day4_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D4_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day4_Ab_Ex.ResetText();
                        Day4_Ba_Ex.ResetText();
                        Day4_Bi_Ex.ResetText();
                        Day4_Ch_Ex.ResetText();
                        Day4_Lg_Ex.ResetText();
                        Day4_Sh_Ex.ResetText();
                        Day4_Sets.ResetText();
                        Day4_Reps.ResetText();
                        Day4_Time.ResetText();
                        Day4_Machine.Checked = false;




                        day4_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
                else
                {
                    if (D4_muscleTarget.SelectedIndex != -1 && (Day4_Ab_Ex.SelectedIndex != -1 || Day4_Ch_Ex.SelectedIndex != -1 || Day4_Sh_Ex.SelectedIndex != -1 || Day4_Ba_Ex.SelectedIndex != -1 || Day4_Lg_Ex.SelectedIndex != -1 || Day4_Bi_Ex.SelectedIndex != -1) && Day4_Sets.Value > 0 && Day4_Reps.Value > 0 && Day4_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day4_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D4_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day4_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D4_muscleTarget.Text}','{Ex_name}','{Day4_Sets.Value}','{Day4_Reps.Value}','{Day4_Time.Value}','{temp_machine}','{D4_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day4_Ab_Ex.ResetText();
                        Day4_Ba_Ex.ResetText();
                        Day4_Bi_Ex.ResetText();
                        Day4_Ch_Ex.ResetText();
                        Day4_Lg_Ex.ResetText();
                        Day4_Sh_Ex.ResetText();
                        Day4_Sets.ResetText();
                        Day4_Reps.ResetText();
                        Day4_Time.ResetText();
                        Day4_Machine.Checked = false;




                        day4_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void D5_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!day5_check)
                {
                    if (D5_muscleTarget.SelectedIndex != -1 && (Day5_Ab_Ex.SelectedIndex != -1 || Day5_Ch_Ex.SelectedIndex != -1 || Day5_Sh_Ex.SelectedIndex != -1 || Day5_Ba_Ex.SelectedIndex != -1 || Day5_Lg_Ex.SelectedIndex != -1 || Day5_Bi_Ex.SelectedIndex != -1) && Day5_Sets.Value > 0 && Day5_Reps.Value > 0 && Day5_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();
                        int dayNo = 5;

                        connection.Open();

                        string query = $"insert into Exercise_Routine(Workout_ID,DayNo) values('{workout_id}','{dayNo}')";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day5_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D5_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day5_Ab_Ex.ResetText();
                        Day5_Ba_Ex.ResetText();
                        Day5_Bi_Ex.ResetText();
                        Day5_Ch_Ex.ResetText();
                        Day5_Lg_Ex.ResetText();
                        Day5_Sh_Ex.ResetText();
                        Day5_Sets.ResetText();
                        Day5_Reps.ResetText();
                        Day5_Time.ResetText();
                        Day5_Machine.Checked = false;




                        day5_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
                else
                {
                    if (D5_muscleTarget.SelectedIndex != -1 && (Day5_Ab_Ex.SelectedIndex != -1 || Day5_Ch_Ex.SelectedIndex != -1 || Day5_Sh_Ex.SelectedIndex != -1 || Day5_Ba_Ex.SelectedIndex != -1 || Day5_Lg_Ex.SelectedIndex != -1 || Day5_Bi_Ex.SelectedIndex != -1) && Day5_Sets.Value > 0 && Day5_Reps.Value > 0 && Day5_Time.Value > 0)
                    {
                        int workout_id = findWorkout_ID();

                        int routine_id = findRoutine_ID(workout_id);
                        string temp_machine = "False";
                        if (Day5_Machine.Checked)
                        {
                            temp_machine = "True";
                        }

                        switch (D5_muscleTarget.SelectedIndex)
                        {
                            case 0:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Sh_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 1:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Bi_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 2:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Ch_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 3:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Ab_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 4:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Lg_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                            case 5:
                                {
                                    connection.Open();

                                    string Ex_name = Day5_Ba_Ex.Text;
                                    string query1 = $"insert into Exercise values('{routine_id}','{D5_muscleTarget.Text}','{Ex_name}','{Day5_Sets.Value}','{Day5_Reps.Value}','{Day5_Time.Value}','{temp_machine}','{D5_MachineName.Text}')";

                                    SqlCommand cmd1 = new SqlCommand(query1, connection);

                                    cmd1.ExecuteNonQuery();

                                    connection.Close();
                                    break;
                                }
                        }

                        MessageBox.Show("Exercise Added Sucessfully!");

                        Day5_Ab_Ex.ResetText();
                        Day5_Ba_Ex.ResetText();
                        Day5_Bi_Ex.ResetText();
                        Day5_Ch_Ex.ResetText();
                        Day5_Lg_Ex.ResetText();
                        Day5_Sh_Ex.ResetText();
                        Day5_Sets.ResetText();
                        Day5_Reps.ResetText();
                        Day5_Time.ResetText();
                        Day5_Machine.Checked = false;




                        day5_check = true;
                    }
                    else
                    {
                        MessageBox.Show("Please Fill In The Boxes!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            if (check1)
            {
                if (DaysPerWeek.Text == "3")
                {
                    if (day1_check && day2_check && day3_check)
                    {
                        MessageBox.Show("Workout Plan Created and Followed Sucessfully!");
                        prevForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Complete Your Workout Plan!");
                    }
                }
                else
                {
                    if (day1_check && day2_check && day3_check && day4_check && day5_check)
                    {
                        
                        MessageBox.Show("Workout Plan Created and Followed Sucessfully!");
                        prevForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Complete Your Workout Plan!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Workout Plan Created!");
            }
        }

        private void Day1_Machine_CheckedChanged(object sender, EventArgs e)
        {
            if(Day1_Machine.Checked)
            { 
                D1_MachineName.Visible = true;D1_MN.Visible = true; 
            }
            else
            { D1_MachineName.Visible = false; D1_MN.Visible = false; }
        }

        private void Day2_Machine_CheckedChanged(object sender, EventArgs e)
        {
            if (Day2_Machine.Checked)
            { D2_MachineName.Visible = true; D2_MN.Visible = true; }
            else
            { D2_MachineName.Visible = false; D2_MN.Visible = false; }
        }

        private void Day3_Machine_CheckedChanged(object sender, EventArgs e)
        {
            if (Day3_Machine.Checked)
            { D3_MachineName.Visible = true; D3_MN.Visible = true; }
            else
            { D3_MachineName.Visible = false; D3_MN.Visible = false; }
        }

        private void Day4_Machine_CheckedChanged(object sender, EventArgs e)
        {
            if (Day4_Machine.Checked)
            { D4_MachineName.Visible = true; D4_MN.Visible = true; }
            else
            { D4_MachineName.Visible = false; D4_MN.Visible = false; }
        }

        private void Day5_Machine_CheckedChanged(object sender, EventArgs e)
        {
            if (Day5_Machine.Checked)
            { D5_MachineName.Visible = true; D5_MN.Visible = true; }
            else
            { D5_MachineName.Visible = false; D5_MN.Visible = false; }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void D1_MN_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check1)
            {
                if(DaysPerWeek.Text=="3")
                {
                    if(day1_check && day2_check && day3_check)
                    {
                        connection.Open();
                        string query3 = "select TOP 1 Workout_ID from WorkoutPlan Order By Workout_ID DESC";
                        SqlCommand cmd3 = new SqlCommand(query3, connection);
                        int WorkoutID = (int)cmd3.ExecuteScalar();
                        connection.Close();

                        connection.Open();
                        string query2 = $"Update MemberUser Set Workout_ID='{WorkoutID}' where Member_ID='{Member_ID}'";
                        SqlCommand cmd2 = new SqlCommand(query2, connection);
                        cmd2.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Workout Plan Created and Followed Sucessfully!");
                        prevForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Complete Your Workout Plan!");
                    }
                }
                else
                {
                    if (day1_check && day2_check && day3_check && day4_check && day5_check)
                    {
                        connection.Open();
                        string query3 = "select TOP 1 Workout_ID from WorkoutPlan Order By Workout_ID DESC";
                        SqlCommand cmd3 = new SqlCommand(query3, connection);
                        int WorkoutID = (int)cmd3.ExecuteScalar();
                        connection.Close();

                        connection.Open();
                        string query2 = $"Update MemberUser Set Workout_ID='{WorkoutID}' where Member_ID='{Member_ID}'";
                        SqlCommand cmd2 = new SqlCommand(query2, connection);
                        cmd2.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Workout Plan Created and Followed Sucessfully!");
                        prevForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Complete Your Workout Plan!");
                    }
                }
            }


            
        }

        private void WELCOME_Click(object sender, EventArgs e)
        {

        }

        private void ExpReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void D4_MN_Click(object sender, EventArgs e)
        {

        }

        private void D3_MN_Click(object sender, EventArgs e)
        {

        }

        private void D2_MN_Click(object sender, EventArgs e)
        {

        }

        private void D5_MachineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void D4_MachineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void D3_MachineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void D2_MachineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void D1_MachineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Ba_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Lg_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Ab_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Ch_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Bi_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Sh_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day4_Ba_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day4_Lg_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day4_Ab_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day4_Ch_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day4_Bi_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day4_Sh_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day3_Ba_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day3_Lg_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day3_Ab_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day3_Ch_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day3_Bi_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day3_Sh_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day2_Ba_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day2_Lg_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day2_Ab_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day2_Ch_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day2_Bi_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day2_Sh_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Reps_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day5_Sets_ValueChanged(object sender, EventArgs e)
        {

        }

        private void D5_L5_Click(object sender, EventArgs e)
        {

        }

        private void D5_L4_Click(object sender, EventArgs e)
        {

        }

        private void D5_L3_Click(object sender, EventArgs e)
        {

        }

        private void D5_L2_Click(object sender, EventArgs e)
        {

        }

        private void D5_L1_Click(object sender, EventArgs e)
        {

        }

        private void Day5_Click(object sender, EventArgs e)
        {

        }

        private void Day4_Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day4_Reps_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day4_Sets_ValueChanged(object sender, EventArgs e)
        {

        }

        private void D4_L5_Click(object sender, EventArgs e)
        {

        }

        private void D4_L4_Click(object sender, EventArgs e)
        {

        }

        private void D4_L3_Click(object sender, EventArgs e)
        {

        }

        private void D4_L2_Click(object sender, EventArgs e)
        {

        }

        private void D4_L1_Click(object sender, EventArgs e)
        {

        }

        private void Day4_Click(object sender, EventArgs e)
        {

        }

        private void Day3_Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day3_Reps_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day3_Sets_ValueChanged(object sender, EventArgs e)
        {

        }

        private void D3_L5_Click(object sender, EventArgs e)
        {

        }

        private void D3_L4_Click(object sender, EventArgs e)
        {

        }

        private void D3_L3_Click(object sender, EventArgs e)
        {

        }

        private void D3_L2_Click(object sender, EventArgs e)
        {

        }

        private void D3_L1_Click(object sender, EventArgs e)
        {

        }

        private void Day3_Click(object sender, EventArgs e)
        {

        }

        private void Day2_Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day2_Reps_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day2_Sets_ValueChanged(object sender, EventArgs e)
        {

        }

        private void D2_L5_Click(object sender, EventArgs e)
        {

        }

        private void D2_L4_Click(object sender, EventArgs e)
        {

        }

        private void D2_L3_Click(object sender, EventArgs e)
        {

        }

        private void D2_L2_Click(object sender, EventArgs e)
        {

        }

        private void D2_L1_Click(object sender, EventArgs e)
        {

        }

        private void Day2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void purpose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Day1_Ba_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day1_Lg_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day1_Ab_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day1_Ch_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day1_Bi_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Day1_Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day1_Reps_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day1_Sets_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day1_Sh_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void D1_L5_Click(object sender, EventArgs e)
        {

        }

        private void D1_L4_Click(object sender, EventArgs e)
        {

        }

        private void D1_L3_Click(object sender, EventArgs e)
        {

        }

        private void D1_L2_Click(object sender, EventArgs e)
        {

        }

        private void D1_L1_Click(object sender, EventArgs e)
        {

        }

        private void Day1_Click(object sender, EventArgs e)
        {

        }
    }
}
