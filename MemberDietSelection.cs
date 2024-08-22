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
    public partial class MemberDietSelection : Form
    {
        private Form prevForm;
        private int Member_ID;
        public MemberDietSelection(Form prevForm, int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Member_ID = id;
        }
        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void MemberDietSelection_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"SELECT DISTINCT d.DietPlan_ID, d.Purpose FROM DietPlan d ";

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
            else if (Meal_Time.SelectedIndex == 3  || Meal_Time.SelectedIndex==-1)
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
            if (Allergens.SelectedIndex!=-1)
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
                        query += $"AND morningMeal.Carbs <= {carbsValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 1)
                    {
                        query += $"AND lunchMeal.Carbs <= {carbsValue} ";
                    }
                    else if (Meal_Time.SelectedIndex == 2)
                    {
                        query += $"AND dinnerMeal.Carbs <= {carbsValue} ";
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

                            richTextBox1.AppendText($"Diet Plan ID: {DietPlan_ID}\n");
                            richTextBox1.AppendText($"Purpose: {Purpose}\n\n");
                        }
                    }
                }
                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query2 = $"Update MemberUser Set DietPlan_ID='{dietID}' where Member_ID='{Member_ID}'";
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Diet Plan Follow!");
        }
    }
}
