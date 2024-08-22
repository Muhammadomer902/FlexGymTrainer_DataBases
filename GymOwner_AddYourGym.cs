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
    public partial class GymOwner_AddYourGym : Form
    {
        private Form prevForm;
        private int GymOwner_ID;
        public GymOwner_AddYourGym(Form prevForm, int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.GymOwner_ID = gymOwner_ID;
        }
        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            if (GymName.Text != "" && Location.Text != "" && OpenTime.Value.TimeOfDay != TimeSpan.Zero && CloseTime.Value.TimeOfDay != TimeSpan.Zero) 
            {
                connection.Open();
                string query = $"Insert into Gym Values('{GymName.Text}','{Location.Text}','{OpenTime.Value.TimeOfDay}','{CloseTime.Value.TimeOfDay}',0,'{GymOwner_ID}',0)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Gym Registeration Request Sent To The Admin!");

                prevForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill In the Boxes!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void GymOwner_AddYourGym_Load(object sender, EventArgs e)
        {

        }
    }
}
