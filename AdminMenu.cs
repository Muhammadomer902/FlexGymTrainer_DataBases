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
    public partial class AdminMenu : Form
    {
        private Form prevForm;
        private int Admin_ID;


        public AdminMenu(Form prevForm, int admin_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            Admin_ID = admin_ID;
        }


        

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void Signout_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void Admin_RegisterationRequest_Click(object sender, EventArgs e)
        {
            Form temp_form = new Admin_GymApproval(this, Admin_ID);
            this.Hide();
            temp_form.Show();
        }

        private void A_revokeMembership_Click(object sender, EventArgs e)
        {
            Form temp_form = new Admin_RevokeMembership(this, Admin_ID);
            this.Hide();
            temp_form.Show();
        }

        private void Admin_gymPerformance_Click(object sender, EventArgs e)
        {
            Form temp_form = new Admin_GymPerformance(this, Admin_ID);
            this.Hide();
            temp_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form temp_form = new Admin_GymComparison(this, Admin_ID);
            this.Hide();
            temp_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form temp_form = new Admin_ExtraReport(this, Admin_ID);
            this.Hide();
            temp_form.Show();
        }
    }
}
