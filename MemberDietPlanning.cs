using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class MemberDietPlanning : Form
    {
        private Form prevForm;
        private int Member_ID;
        private int purpose_idx;

        public MemberDietPlanning(Form prevForm, int id)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Member_ID = id;
            this.purpose_idx = -2;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void MemberDietPlanning_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void B_Breakfast_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(B_Breakfast.SelectedIndex != -1)
            {
                switch(B_Breakfast.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_B.Text = "15";
                            Carbs_B.Text = "30";
                            Pro_B.Text = "25";
                            Fbr_B.Text = "3";
                            Cal_B.Text = "400";

                            break; 
                        }
                    case 1:
                        {
                            Fat_B.Text = "10";
                            Carbs_B.Text = "45";
                            Pro_B.Text = "20";
                            Fbr_B.Text = "6";
                            Cal_B.Text = "350";
                            break;
                        }
                    case 2:
                        {
                            Fat_B.Text = "12";
                            Carbs_B.Text = "60";
                            Pro_B.Text = "15";
                            Fbr_B.Text = "8";
                            Cal_B.Text = "450";
                            break;
                        }
                    case 3:
                        {
                            Fat_B.Text = "8";
                            Carbs_B.Text = "50";
                            Pro_B.Text = "30";
                            Fbr_B.Text = "5";
                            Cal_B.Text = "400";
                            break;
                        }
                    case 4:
                        {
                            Fat_B.Text = "20";
                            Carbs_B.Text = "30";
                            Pro_B.Text = "15";
                            Fbr_B.Text = "10";
                            Cal_B.Text = "380";
                            break;
                        }
                }
            }
        }

        private void Purpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(purpose_idx == -2) 
            {
                if (Purpose.SelectedIndex != -1)
                {
                    purpose_idx = Purpose.SelectedIndex;
                    if (Purpose.SelectedIndex == 0)
                    {
                        B_Breakfast.Visible = true;
                        C_Breakfast.Visible = false;
                        W_Breakfast.Visible = false;

                        B_Lunch.Visible = true;
                        C_Lunch.Visible = false;
                        W_Lunch.Visible = false;

                        B_Dinner.Visible = true;
                        C_Dinner.Visible = false;
                        W_Dinner.Visible = false;
                    }
                    else if (Purpose.SelectedIndex == 1)
                    {
                        B_Breakfast.Visible = false;
                        C_Breakfast.Visible = true;
                        W_Breakfast.Visible = false;

                        B_Lunch.Visible = false;
                        C_Lunch.Visible = true;
                        W_Lunch.Visible = false;

                        B_Dinner.Visible = false;
                        C_Dinner.Visible = true;
                        W_Dinner.Visible = false;
                    }
                    else if (Purpose.SelectedIndex == 2)
                    {
                        B_Breakfast.Visible = false;
                        C_Breakfast.Visible = false;
                        W_Breakfast.Visible = true;

                        B_Lunch.Visible = false;
                        C_Lunch.Visible = false;
                        W_Lunch.Visible = true;

                        B_Dinner.Visible = false;
                        C_Dinner.Visible = false;
                        W_Dinner.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Purpose have been already selected!");
                Purpose.SelectedIndex = purpose_idx;
            }
        }

        private void C_Breakfast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Breakfast.SelectedIndex != -1)
            {
                switch (C_Breakfast.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_B.Text = "5";
                            Carbs_B.Text = "25";
                            Pro_B.Text = "20";
                            Fbr_B.Text = "3";
                            Cal_B.Text = "250";

                            break;
                        }
                    case 1:
                        {
                            Fat_B.Text = "3";
                            Carbs_B.Text = "10";
                            Pro_B.Text = "20";
                            Fbr_B.Text = "2";
                            Cal_B.Text = "150";
                            break;
                        }
                    case 2:
                        {
                            Fat_B.Text = "3";
                            Carbs_B.Text = "30";
                            Pro_B.Text = "6";
                            Fbr_B.Text = "5";
                            Cal_B.Text = "200";
                            break;
                        }
                    case 3:
                        {
                            Fat_B.Text = "10";
                            Carbs_B.Text = "20";
                            Pro_B.Text = "5";
                            Fbr_B.Text = "6";
                            Cal_B.Text = "250";
                            break;
                        }
                    case 4:
                        {
                            Fat_B.Text = "3";
                            Carbs_B.Text = "20";
                            Pro_B.Text = "25";
                            Fbr_B.Text = "4";
                            Cal_B.Text = "200";
                            break;
                        }
                }
            }
        }

        private void W_Breakfast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (W_Breakfast.SelectedIndex != -1)
            {
                switch (W_Breakfast.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_B.Text = "8";
                            Carbs_B.Text = "30";
                            Pro_B.Text = "20";
                            Fbr_B.Text = "6";
                            Cal_B.Text = "280";

                            break;
                        }
                    case 1:
                        {
                            Fat_B.Text = "3";
                            Carbs_B.Text = "5";
                            Pro_B.Text = "20";
                            Fbr_B.Text = "2";
                            Cal_B.Text = "150";
                            break;
                        }
                    case 2:
                        {
                            Fat_B.Text = "6";
                            Carbs_B.Text = "45";
                            Pro_B.Text = "10";
                            Fbr_B.Text = "9";
                            Cal_B.Text = "280";
                            break;
                        }
                    case 3:
                        {
                            Fat_B.Text = "12";
                            Carbs_B.Text = "20";
                            Pro_B.Text = "12";
                            Fbr_B.Text = "7";
                            Cal_B.Text = "250";
                            break;
                        }
                    case 4:
                        {
                            Fat_B.Text = "5";
                            Carbs_B.Text = "30";
                            Pro_B.Text = "5";
                            Fbr_B.Text = "6";
                            Cal_B.Text = "200";
                            break;
                        }
                }
            }
        }

        private void B_Lunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (B_Lunch.SelectedIndex != -1)
            {
                switch (B_Lunch.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_L.Text = "10";
                            Carbs_L.Text = "40";
                            Pro_L.Text = "30";
                            Fbr_L.Text = "8";
                            Cal_L.Text = "400";

                            break;
                        }
                    case 1:
                        {
                            Fat_L.Text = "15";
                            Carbs_L.Text = "50";
                            Pro_L.Text = "35";
                            Fbr_L.Text = "6";
                            Cal_L.Text = "480";
                            break;
                        }
                    case 2:
                        {
                            Fat_L.Text = "20";
                            Carbs_L.Text = "40";
                            Pro_L.Text = "35";
                            Fbr_L.Text = "7";
                            Cal_L.Text = "500";
                            break;
                        }
                    case 3:
                        {
                            Fat_L.Text = "12";
                            Carbs_L.Text = "35";
                            Pro_L.Text = "25";
                            Fbr_L.Text = "5";
                            Cal_L.Text = "380";
                            break;
                        }
                    case 4:
                        {
                            Fat_L.Text = "8";
                            Carbs_L.Text = "50";
                            Pro_L.Text = "20";
                            Fbr_L.Text = "12";
                            Cal_L.Text = "420";
                            break;
                        }
                }
            }
        }

        private void C_Lunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Lunch.SelectedIndex != -1)
            {
                switch (C_Lunch.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_L.Text = "10";
                            Carbs_L.Text = "15";
                            Pro_L.Text = "30";
                            Fbr_L.Text = "5";
                            Cal_L.Text = "300";

                            break;
                        }
                    case 1:
                        {
                            Fat_L.Text = "8";
                            Carbs_L.Text = "25";
                            Pro_L.Text = "20";
                            Fbr_L.Text = "7";
                            Cal_L.Text = "250";
                            break;
                        }
                    case 2:
                        {
                            Fat_L.Text = "12";
                            Carbs_L.Text = "30";
                            Pro_L.Text = "25";
                            Fbr_L.Text = "8";
                            Cal_L.Text = "350";
                            break;
                        }
                    case 3:
                        {
                            Fat_L.Text = "15";
                            Carbs_L.Text = "35";
                            Pro_L.Text = "25";
                            Fbr_L.Text = "10";
                            Cal_L.Text = "400";
                            break;
                        }
                    case 4:
                        {
                            Fat_L.Text = "7";
                            Carbs_L.Text = "40";
                            Pro_L.Text = "10";
                            Fbr_L.Text = "12";
                            Cal_L.Text = "280";
                            break;
                        }
                }
            }
        }

        private void W_Lunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (W_Lunch.SelectedIndex != -1)
            {
                switch (W_Lunch.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_L.Text = "10";
                            Carbs_L.Text = "15";
                            Pro_L.Text = "30";
                            Fbr_L.Text = "5";
                            Cal_L.Text = "300";

                            break;
                        }
                    case 1:
                        {
                            Fat_L.Text = "8";
                            Carbs_L.Text = "25";
                            Pro_L.Text = "20";
                            Fbr_L.Text = "8";
                            Cal_L.Text = "250";
                            break;
                        }
                    case 2:
                        {
                            Fat_L.Text = "5";
                            Carbs_L.Text = "30";
                            Pro_L.Text = "15";
                            Fbr_L.Text = "10";
                            Cal_L.Text = "280";
                            break;
                        }
                    case 3:
                        {
                            Fat_L.Text = "12";
                            Carbs_L.Text = "30";
                            Pro_L.Text = "20";
                            Fbr_L.Text = "6";
                            Cal_L.Text = "320";
                            break;
                        }
                    case 4:
                        {
                            Fat_L.Text = "6";
                            Carbs_L.Text = "20";
                            Pro_L.Text = "25";
                            Fbr_L.Text = "8";
                            Cal_L.Text = "280";
                            break;
                        }
                }
            }
        }

        private void B_Dinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (B_Dinner.SelectedIndex != -1)
            {
                switch (B_Dinner.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_D.Text = "12";
                            Carbs_D.Text = "30";
                            Pro_D.Text = "35";
                            Fbr_D.Text = "5";
                            Cal_D.Text = "400";

                            break;
                        }
                    case 1:
                        {
                            Fat_D.Text = "15";
                            Carbs_D.Text = "45";
                            Pro_D.Text = "40";
                            Fbr_D.Text = "8";
                            Cal_D.Text = "500";
                            break;
                        }
                    case 2:
                        {
                            Fat_D.Text = "8";
                            Carbs_D.Text = "40";
                            Pro_D.Text = "45";
                            Fbr_D.Text = "7";
                            Cal_D.Text = "450";
                            break;
                        }
                    case 3:
                        {
                            Fat_D.Text = "7";
                            Carbs_D.Text = "50";
                            Pro_D.Text = "20";
                            Fbr_D.Text = "15";
                            Cal_D.Text = "380";
                            break;
                        }
                    case 4:
                        {
                            Fat_D.Text = "10";
                            Carbs_D.Text = "35";
                            Pro_D.Text = "30";
                            Fbr_D.Text = "6";
                            Cal_D.Text = "420";
                            break;
                        }
                }
            }
        }

        private void C_Dinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Dinner.SelectedIndex != -1)
            {
                switch (C_Dinner.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_D.Text = "5";
                            Carbs_D.Text = "10";
                            Pro_D.Text = "30";
                            Fbr_D.Text = "5";
                            Cal_D.Text = "250";

                            break;
                        }
                    case 1:
                        {
                            Fat_D.Text = "15";
                            Carbs_D.Text = "30";
                            Pro_D.Text = "25";
                            Fbr_D.Text = "8";
                            Cal_D.Text = "350";
                            break;
                        }
                    case 2:
                        {
                            Fat_D.Text = "8";
                            Carbs_D.Text = "25";
                            Pro_D.Text = "20";
                            Fbr_D.Text = "10";
                            Cal_D.Text = "280";
                            break;
                        }
                    case 3:
                        {
                            Fat_D.Text = "10";
                            Carbs_D.Text = "20";
                            Pro_D.Text = "15";
                            Fbr_D.Text = "8";
                            Cal_D.Text = "220";
                            break;
                        }
                    case 4:
                        {
                            Fat_D.Text = "12";
                            Carbs_D.Text = "15";
                            Pro_D.Text = "20";
                            Fbr_D.Text = "5";
                            Cal_D.Text = "280";
                            break;
                        }
                }
            }
        }

        private void W_Dinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (W_Dinner.SelectedIndex != -1)
            {
                switch (W_Dinner.SelectedIndex)
                {
                    case 0:
                        {
                            Fat_D.Text = "10";
                            Carbs_D.Text = "10";
                            Pro_D.Text = "30";
                            Fbr_D.Text = "5";
                            Cal_D.Text = "300";

                            break;
                        }
                    case 1:
                        {
                            Fat_D.Text = "5";
                            Carbs_D.Text = "40";
                            Pro_D.Text = "15";
                            Fbr_D.Text = "10";
                            Cal_D.Text = "300";
                            break;
                        }
                    case 2:
                        {
                            Fat_D.Text = "8";
                            Carbs_D.Text = "20";
                            Pro_D.Text = "25";
                            Fbr_D.Text = "6";
                            Cal_D.Text = "300";
                            break;
                        }
                    case 3:
                        {
                            Fat_D.Text = "6";
                            Carbs_D.Text = "15";
                            Pro_D.Text = "20";
                            Fbr_D.Text = "8";
                            Cal_D.Text = "250";
                            break;
                        }
                    case 4:
                        {
                            Fat_D.Text = "12";
                            Carbs_D.Text = "20";
                            Pro_D.Text = "15";
                            Fbr_D.Text = "8";
                            Cal_D.Text = "280";
                            break;
                        }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (purpose_idx != -2 /*&& (B_Breakfast.SelectedIndex!=-1 || B_Lunch.SelectedIndex != -1|| B_Dinner.SelectedIndex != -1) && (C_Breakfast.SelectedIndex != -1 || C_Lunch.SelectedIndex != -1 || C_Dinner.SelectedIndex != -1) && (W_Breakfast.SelectedIndex != -1 || W_Lunch.SelectedIndex != -1 || W_Dinner.SelectedIndex != -1)*/)
            { 
                switch (purpose_idx)
                {
                    case 0:
                        {
                            
                            int Breakfast = getMeal_ID(B_Breakfast.Text);
                            int Lunch = getMeal_ID(B_Lunch.Text);
                            int Dinner = getMeal_ID(B_Dinner.Text);

                            connection.Open();
                            string query = $"SELECT COUNT(*) AS AllergenCount FROM Meal m JOIN Member_Allergens ma ON m.Allergen = ma.Allergen WHERE ma.Member_ID = '{Member_ID}' AND (m.Meal_ID = '{Breakfast}' OR m.Meal_ID = '{Lunch}' OR m.Meal_ID = '{Dinner}'";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            int count=(int)cmd.ExecuteScalar();
                            connection.Close();

                            if(count>0)
                            {
                                MessageBox.Show("You Have Selected Meal Matches With Your Allergen!");
                                check = true;

                            }
                            else
                            {
                                connection.Open();
                                string query1 = $"Insert into DietPlan Values('{Purpose.Text}','{Breakfast}','{Lunch}','{Dinner}',{Member_ID},'Member')";
                                SqlCommand cmd1 = new SqlCommand(query1, connection);
                                cmd1.ExecuteNonQuery();
                                connection.Close();
                            }
                            break;
                        }
                    case 1:
                        {
                            int Breakfast = getMeal_ID(C_Breakfast.Text);
                            int Lunch = getMeal_ID(C_Lunch.Text);
                            int Dinner = getMeal_ID(C_Dinner.Text);

                            connection.Open();
                            string query = $"SELECT COUNT(*) AS AllergenCount FROM Meal m JOIN Member_Allergens ma ON m.Allergen = ma.Allergen WHERE ma.Member_ID = '{Member_ID}' AND (m.Meal_ID = '{Breakfast}' OR m.Meal_ID = '{Lunch}' OR m.Meal_ID = '{Dinner}'";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            int count = (int)cmd.ExecuteScalar();
                            connection.Close();
                            if (count > 0)
                            {
                                check = true;
                                MessageBox.Show("You Have Selected Meal Matches With Your Allergen!");
                            }
                            else
                            {
                                connection.Open();
                                string query1 = $"Insert into DietPlan Values('{Purpose.Text}','{Breakfast}','{Lunch}','{Dinner}',{Member_ID},'Member')";
                                SqlCommand cmd1 = new SqlCommand(query1, connection);
                                cmd1.ExecuteNonQuery();
                                connection.Close();
                            }
                            break;
                        }
                    case 2:
                        {
                            int Breakfast = getMeal_ID(W_Breakfast.Text);
                            int Lunch = getMeal_ID(W_Lunch.Text);
                            int Dinner = getMeal_ID(W_Dinner.Text);

                            connection.Open();
                            string query = $"SELECT COUNT(*) AS AllergenCount FROM Meal m JOIN Member_Allergens ma ON m.Allergen = ma.Allergen WHERE ma.Member_ID = '{Member_ID}' AND (m.Meal_ID = '{Breakfast}' OR m.Meal_ID = '{Lunch}' OR m.Meal_ID = '{Dinner}'";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            int count = (int)cmd.ExecuteScalar();
                            connection.Close();
                            
                            if (count > 0)
                            {
                                check = true;
                                MessageBox.Show("You Have Selected Meal Matches With Your Allergen!");
                            }
                            else
                            {
                                connection.Open();
                                string query1 = $"Insert into DietPlan Values('{Purpose.Text}','{Breakfast}','{Lunch}','{Dinner}',{Member_ID},'Member')";
                                SqlCommand cmd1 = new SqlCommand(query1, connection);
                                cmd1.ExecuteNonQuery();
                                connection.Close();
                            }

                            break;
                        }
                }
                if(!check)
                { 
                    connection.Open();
                    string query3 = "select TOP 1 DietPLan_ID from DietPlan Order By DietPlan_ID DESC";
                    SqlCommand cmd3 = new SqlCommand(query3, connection);
                    int dietplanID = (int)cmd3.ExecuteScalar();
                    connection.Close();

                    connection.Open();
                    string query2 = $"Update MemberUser Set DietPlan_ID='{dietplanID}' where Member_ID='{Member_ID}'";
                    SqlCommand cmd2 = new SqlCommand(query2, connection);
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Diet Plan Created and Follow!");
                    prevForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Fill The Boxes!");
            }
        }

        int getMeal_ID(string MealName)
        {
            connection.Open();
            string query = "select Meal_ID from Meal where MealName='" + MealName + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();

            return v;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (purpose_idx != -2 /*&& (B_Breakfast.SelectedIndex!=-1 || B_Lunch.SelectedIndex != -1|| B_Dinner.SelectedIndex != -1) && (C_Breakfast.SelectedIndex != -1 || C_Lunch.SelectedIndex != -1 || C_Dinner.SelectedIndex != -1) && (W_Breakfast.SelectedIndex != -1 || W_Lunch.SelectedIndex != -1 || W_Dinner.SelectedIndex != -1)*/)
            {
                switch (purpose_idx)
                {
                    case 0:
                        {

                            int Breakfast = getMeal_ID(B_Breakfast.Text);
                            int Lunch = getMeal_ID(B_Lunch.Text);
                            int Dinner = getMeal_ID(B_Dinner.Text);

                            connection.Open();
                            string query1 = $"Insert into DietPlan Values('{Purpose.Text}','{Breakfast}','{Lunch}','{Dinner}',{Member_ID},'Member')";
                            SqlCommand cmd1 = new SqlCommand(query1, connection);
                            cmd1.ExecuteNonQuery();
                            connection.Close();
                            break;
                        }
                    case 1:
                        {
                            int Breakfast = getMeal_ID(C_Breakfast.Text);
                            int Lunch = getMeal_ID(C_Lunch.Text);
                            int Dinner = getMeal_ID(C_Dinner.Text);

                            connection.Open();
                            string query1 = $"Insert into DietPlan Values('{Purpose.Text}','{Breakfast}','{Lunch}','{Dinner}',{Member_ID},'Member')";
                            SqlCommand cmd1 = new SqlCommand(query1, connection);
                            cmd1.ExecuteNonQuery();
                            connection.Close();
                            break;
                        }
                    case 2:
                        {
                            int Breakfast = getMeal_ID(W_Breakfast.Text);
                            int Lunch = getMeal_ID(W_Lunch.Text);
                            int Dinner = getMeal_ID(W_Dinner.Text);

                            connection.Open();
                            string query1 = $"Insert into DietPlan Values('{Purpose.Text}','{Breakfast}','{Lunch}','{Dinner}',{Member_ID},'Member')";
                            SqlCommand cmd1 = new SqlCommand(query1, connection);
                            cmd1.ExecuteNonQuery();
                            connection.Close();

                            break;
                        }
                }

                MessageBox.Show("Diet Plan Created!");
                prevForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill The Boxes!");
            }
        }
    }


}
