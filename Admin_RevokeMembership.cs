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
    public partial class Admin_RevokeMembership : Form
    {
        private Form prevForm;
        private int Admin_ID;
        
        public Admin_RevokeMembership(Form prevForm, int admin_ID)
        {
            InitializeComponent();  
            this.prevForm = prevForm;
            Admin_ID = admin_ID;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void Admin_RevokeMembership_Load(object sender, EventArgs e)
        {

        }
        int checkUnique(string Username, string table)
        {
            connection.Open();
            string query = "select count(*) from " + table + " where Username='" + Username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username.Text != "")
                {

                    int v = checkUnique(Username.Text, "Users");
                    if (v == 1)
                    {


                        connection.Open();
                        string query1 = $"UPDATE Users SET Username = NULL WHERE Username = '{Username.Text}';";
                        SqlCommand cmd1 = new SqlCommand(query1, connection);
                        cmd1.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Account Removed!");

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

        private void button2_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
