using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class GetUserType : Form
    {
        public GetUserType()
        {
            InitializeComponent();
        }

        private void GoToSignup_Click_1(object sender, EventArgs e)
        {
            if (SelectUserType.SelectedIndex != -1)
            {
                string userType = SelectUserType.SelectedItem.ToString();

                if (userType == "Member")
                {
                    Form temp_form = new MemberSignup(this);
                    this.Hide();
                    temp_form.Show();

                }
                else if (userType == "Trainer")
                {
                    Form temp_form = new TrainerSignup(this);
                    this.Hide();
                    temp_form.Show();

                }
                else if (userType == "Admin")
                {
                    Form temp_form = new AdminSignup(this);
                    this.Hide();
                    temp_form.Show();

                }
                else if (userType == "Gym Owner")
                {
                    Form temp_form = new GymOwner_Signup(this);
                    this.Hide();
                    temp_form.Show();

                }
            }
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            Form temp_form = new Login(this);
            this.Hide();
            temp_form.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetUserType_Load(object sender, EventArgs e)
        {

        }
    }
}
