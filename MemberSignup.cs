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
using static System.Resources.ResXFileRef;


namespace Database_Project
{
    public partial class MemberSignup : Form
    {
        private Form prevForm;
        public MemberSignup(Form temp)
        {
            InitializeComponent();
            this.prevForm=temp;
        }

        private void MemberSignup_Load(object sender, EventArgs e)
        {

        }


        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");
        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void GoToSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text != "" && password.Text != "" && f_name.Text != "" && m_name.Text != "" && l_name.Text != "" && gender.SelectedIndex != -1 && cnic.Text != "" && height.Text != "" && contact.Text != "" && weight.Text != "" && exp.SelectedIndex != -1 && purpose.SelectedIndex != -1 && DoB.Text != "")
                {
                    int v = checkUnique(username.Text);
                    if (v < 1)
                    {
                        connection.Open();
                        string userType = "Member";
                        string Query = $"insert into Users values('{username.Text}','{password.Text}','{userType}')";
                        SqlCommand cmd1=new SqlCommand(Query,connection);
                        cmd1.ExecuteNonQuery();
                        connection.Close();

                        int Member_ID=getUserID(username.Text);

                        connection.Open();
                        string Query1 = $"insert into MemberUser(Member_ID,FirstName,MiddleName,LastName,Contact,Gender,DoB,CNIC,Height,Weight,Experience,Purpose) values ('{Member_ID}','{f_name.Text}','{m_name.Text}','{l_name.Text}','{contact.Text}','{gender.Text}','{Convert.ToDateTime(DoB.Text)}','{cnic.Text}','{height.Text}','{weight.Text}','{exp.Text}','{purpose.Text}')";
                        SqlCommand cmd = new SqlCommand(Query1, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        connection.Open();
                        foreach (var checkedItem in Allergen.CheckedItems)
                        {
                            string insertQuery = $"INSERT INTO Member_Allergens VALUES ('{Member_ID}','{checkedItem}')";
                            using (SqlCommand command = new SqlCommand(insertQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
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
