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

    public partial class AdminSignup : Form
    {
        private Form prevForm;

        public AdminSignup(Form prevForm)
        {
            InitializeComponent();
            this.prevForm = prevForm;
        }
        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        
        private void AdminSignup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void GoToSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text != "" && password.Text != "" && f_name.Text != "" && m_name.Text != "" && l_name.Text != "" && gender.SelectedIndex != -1 && cnic.Text != "" && contact.Text != "" && DoB.Text != "")
                {
                    int v = checkUnique(username.Text);
                    if (v < 1)
                    {
                        connection.Open();
                        string userType = "Admin";
                        string Query = $"insert into Users values('{username.Text}','{password.Text}','{userType}')";
                        SqlCommand cmd1 = new SqlCommand(Query, connection);
                        cmd1.ExecuteNonQuery();
                        connection.Close();

                        int Admin_ID = getUserID(username.Text);

                        connection.Open();
                        string Query1 = $"insert into AdminUser values ('{Admin_ID}','{f_name.Text}','{m_name.Text}','{l_name.Text}','{contact.Text}','{gender.Text}','{Convert.ToDateTime(DoB.Text)}','{cnic.Text}')";
                        SqlCommand cmd = new SqlCommand(Query1, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Registered Successfully!");

                        prevForm.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Username already Registered!");

                    }
                }
                else
                {
                    MessageBox.Show("Fill the empty boxes!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int checkUnique(string Username)
        {
            connection.Open();
            string query = "select count(*) from Users where Username='" + Username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }

        int getUserID(string Username)
        {
            connection.Open();
            string query = "select User_ID from Users where Username='" + Username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }
    }
}

