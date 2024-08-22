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
    public partial class Trainer_DietPlanReport : Form
    {
        private Form prevForm;
        private int Trainer_ID;
        public Trainer_DietPlanReport(Form prevForm, int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Trainer_ID = id;
        }
        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");


        private void Trainer_DietPlanReport_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $@"SELECT DISTINCT d.DietPlan_ID, d.Purpose, d.CreatedBy FROM DietPlan d 
			JOIN Users u ON d.CreatedBy = u.User_ID
			JOIN MemberUser On U.User_ID = MemberUser.Member_ID 
			JOIN Training_Session on Training_Session.TrainingSession_ID = MemberUser.TrainingSession_ID
			Join Trainer on Trainer.Trainer_ID = Training_Session.Trainer_ID ";

            if (Meal_Time.SelectedIndex == 0)
            {
                query += $"JOIN Meal morningMeal ON d.MorningMeal_ID = morningMeal.Meal_ID ";
            }
            else if (Meal_Time.SelectedIndex == 1)
            {
                query += $"JOIN Meal lunchMeal ON d.LunchMeal_ID = lunchMeal.Meal_ID ";
            }
            else if (Meal_Time.SelectedIndex == 2)
            {
                query += $"JOIN Meal dinnerMeal ON d.DinnerMeal_ID = dinnerMeal.Meal_ID ";
            }
            else if (Meal_Time.SelectedIndex == 3 || Meal_Time.SelectedIndex == -1)
            {
                query += $"JOIN Meal morningMeal ON d.MorningMeal_ID = morningMeal.Meal_ID ";
                query += $"JOIN Meal lunchMeal ON d.LunchMeal_ID = lunchMeal.Meal_ID ";
                query += $"JOIN Meal dinnerMeal ON d.DinnerMeal_ID = dinnerMeal.Meal_ID ";
            }

            query += $"WHERE 1=1 ";

            if (purposebox.SelectedIndex != -1)
            {
                query += $"AND d.Purpose = '{purposebox.Text}' ";
            }

            // Exclude specified allergens
            if (Allergens.SelectedIndex != -1)
            {
                string allergen = Allergens.Text;

                if (Meal_Time.SelectedIndex == 0)
                {
                    query += $"AND NOT EXISTS (SELECT 1 FROM Meal morningMeal WHERE morningMeal.Allergen = '{allergen}' AND d.MorningMeal_ID = morningMeal.Meal_ID) ";
                }
                else if (Meal_Time.SelectedIndex == 1)
                {
                    query += $"AND NOT EXISTS (SELECT 1 FROM Meal lunchMeal WHERE lunchMeal.Allergen = '{allergen}' AND d.LunchMeal_ID = lunchMeal.Meal_ID) ";
                }
                else if (Meal_Time.SelectedIndex == 2)
                {
                    query += $"AND NOT EXISTS (SELECT 1 FROM Meal dinnerMeal WHERE dinnerMeal.Allergen = '{allergen}' AND d.DinnerMeal_ID = dinnerMeal.Meal_ID) ";
                }
                else if (Meal_Time.SelectedIndex == 3 || Meal_Time.SelectedIndex == -1)
                {
                    query += $"AND NOT EXISTS (SELECT 1 FROM Meal morningMeal WHERE morningMeal.Allergen = '{allergen}' AND d.MorningMeal_ID = morningMeal.Meal_ID) ";
                    query += $"AND NOT EXISTS (SELECT 1 FROM Meal lunchMeal WHERE lunchMeal.Allergen = '{allergen}' AND d.LunchMeal_ID = lunchMeal.Meal_ID) ";
                    query += $"AND NOT EXISTS (SELECT 1 FROM Meal dinnerMeal WHERE dinnerMeal.Allergen = '{allergen}' AND d.DinnerMeal_ID = dinnerMeal.Meal_ID) ";
                }
            }

            if (Fat.Text != "")
            {
                int fatValue = int.Parse(Fat.Text);
                if (Meal_Time.SelectedIndex != -1 && Meal_Time.SelectedIndex != 3)
                {
                    // Apply the filter based on the selected meal time
                    if (Meal_Time.SelectedIndex == 0)
                    {
                        query += $"AND morningMeal.Fat <= {fatValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 1)
                    {
                        query += $"AND lunchMeal.Fat <= {fatValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 2)
                    {
                        query += $"AND dinnerMeal.Fat <= {fatValue} ";
                    }
                }
                else
                {
                    // Apply the filter for combined Fat in all meals
                    query += $"AND (morningMeal.Fat + lunchMeal.Fat + dinnerMeal.Fat) <= {fatValue} ";
                }
            }

            if (Carbs.Text != "")
            {
                int carbsValue = int.Parse(Carbs.Text);
                if (Meal_Time.SelectedIndex != -1 && Meal_Time.SelectedIndex != 3)
                {
                    // Apply the filter based on the selected meal time
                    if (Meal_Time.SelectedIndex == 0)
                    {
                        query += $" AND morningMeal.Carbs <= {carbsValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 1)
                    {
                        query += $" AND lunchMeal.Carbs <= {carbsValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 2)
                    {
                        query += $" AND dinnerMeal.Carbs <= {carbsValue} ";
                    }
                }
                else
                {
                    // Apply the filter for combined Carbs in all meals
                    query += $"AND (morningMeal.Carbs + lunchMeal.Carbs + dinnerMeal.Carbs) <= {carbsValue} ";
                }
            }

            if (Fbr.Text != "")
            {
                int fiberValue = int.Parse(Fbr.Text);
                if (Meal_Time.SelectedIndex != -1 && Meal_Time.SelectedIndex != 3)
                {
                    // Apply the filter based on the selected meal time
                    if (Meal_Time.SelectedIndex == 0)
                    {
                        query += $"AND morningMeal.Fiber <= {fiberValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 1)
                    {
                        query += $"AND lunchMeal.Fiber <= {fiberValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 2)
                    {
                        query += $"AND dinnerMeal.Fiber <= {fiberValue} ";
                    }
                }
                else
                {
                    // Apply the filter for combined Fiber in all meals
                    query += $"AND (morningMeal.Fiber + lunchMeal.Fiber + dinnerMeal.Fiber) <= {fiberValue} ";
                }
            }


            if (Pro.Text != "")
            {
                int proteinValue = int.Parse(Pro.Text);
                if (Meal_Time.SelectedIndex != -1 && Meal_Time.SelectedIndex != 3)
                {
                    // Apply the filter based on the selected meal time
                    if (Meal_Time.SelectedIndex == 0)
                    {
                        query += $"AND morningMeal.Protien <= {proteinValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 1)
                    {
                        query += $"AND lunchMeal.Protien <= {proteinValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 2)
                    {
                        query += $"AND dinnerMeal.Protien <= {proteinValue} ";
                    }
                }
                else
                {
                    // Apply the filter for combined Protein in all meals
                    query += $"AND (morningMeal.Protien + lunchMeal.Protien + dinnerMeal.Protien) <= {proteinValue} ";
                }
            }

            if (Cal.Text != "")
            {
                int caloriesValue = int.Parse(Cal.Text);
                if (Meal_Time.SelectedIndex != -1 && Meal_Time.SelectedIndex != 3)
                {
                    // Apply the filter based on the selected meal time
                    if (Meal_Time.SelectedIndex == 0)
                    {
                        query += $"AND morningMeal.Calories <= {caloriesValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 1)
                    {
                        query += $"AND lunchMeal.Calories <= {caloriesValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 2)
                    {
                        query += $"AND dinnerMeal.Calories <= {caloriesValue} ";
                    }
                }
                else
                {
                    // Apply the filter for combined Calories in all meals
                    query += $"AND (morningMeal.Calories + lunchMeal.Calories + dinnerMeal.Calories) <= {caloriesValue} ";
                }
            }


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
                            string DietPlan_ID = reader["DietPlan_ID"].ToString();
                            string Purpose = reader["Purpose"].ToString();
                            string creater = reader["createdby"].ToString() ;

                            richTextBox1.AppendText($"Diet Plan ID: {DietPlan_ID}\n");
                            richTextBox1.AppendText($"Purpose: {Purpose}\n");
                            richTextBox1.AppendText($"Created By : { creater}\n\n");
                        }
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
    }
}
