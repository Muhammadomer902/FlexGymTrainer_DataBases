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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Database_Project
{
    public partial class Login : Form
    {
        private Form prevForm;


        public Login(Form prevForm)
        {
            InitializeComponent();
            this.prevForm = prevForm;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void exit_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text != "" && password.Text != "")
                {

                    int v = checkUnique(username.Text, password.Text, "Users");
                    if (v == 1)
                    {
                        connection.Open();
                        string query = "select User_ID from Users where Username='" + username.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        int id = (int)cmd.ExecuteScalar();
                        connection.Close();

                        string UserType="";

                        connection.Open();
                        string query1 = "select UserType from Users where Username='" + username.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, connection);
                        using (SqlDataReader reader = cmd1.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    UserType = reader.GetString(0);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                        }
                        connection.Close();

                        if (UserType == "Member")
                        {
                            Form temp_form = new MemberMenu(this, id);
                            this.Hide();
                            temp_form.Show();
                        }
                        else if (UserType == "Trainer")
                        {
                            Form temp_form = new TrainerMenu(this, id);
                            this.Hide();
                            temp_form.Show();
                        }
                        else if (UserType == "Gym Owner")
                        {
                            Form temp_form = new GymOwnerMenu(this, id);
                            this.Hide();
                            temp_form.Show();
                        }
                        else if (UserType == "Admin")
                        {
                            Form temp_form = new AdminMenu(this, id);
                            this.Hide();
                            temp_form.Show();
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }


                    //string userType = SelectUserType.SelectedItem.ToString();

                    
                }
                else
                {
                    MessageBox.Show("Please Fill in the Boxes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int checkUnique(string Username, string Password, string table)
        {
            connection.Open();
            string query = "select count(*) from " + table + " where Username='" + Username + "' AND Password='"+Password+"'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
