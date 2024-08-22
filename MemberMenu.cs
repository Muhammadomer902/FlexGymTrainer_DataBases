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
    public partial class MemberMenu : Form
    {
        private Form prevForm;
        private int Member_ID;
        public MemberMenu(Form prevForm, int member_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.Member_ID = member_ID;
        }

        private void MemberMenu_Load(object sender, EventArgs e)
        {

        }

        

        

        private void SignOut_Click_1(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void MemberWorkoutPlanning_Click(object sender, EventArgs e)
        {
            Form temp_form = new MemberWorkoutPlanning(this, Member_ID);
            this.Hide();
            temp_form.Show();
        }

        private void MemberWorkoutReport_Click(object sender, EventArgs e)
        {
            Form temp_form = new MemberWorkoutReport(this, Member_ID);
            this.Hide();
            temp_form.Show();
        }

        private void MemberDietPlanning_Click(object sender, EventArgs e)
        {
            Form temp_form = new MemberDietPlanning(this, Member_ID);
            this.Hide();
            temp_form.Show();
        }

        private void MemberDietPlanSelection_Click(object sender, EventArgs e)
        {
            Form temp_form = new MemberDietSelection(this, Member_ID);
            this.Hide();
            temp_form.Show();
        }

        private void MemberPersonalTraining_Click(object sender, EventArgs e)
        {
            Form temp_form = new MemberPersonalTraining(this, Member_ID);
            this.Hide();
            temp_form.Show();
        }

        private void MemberTrainerFeedback_Click(object sender, EventArgs e)
        {
            Form temp_form = new MemberTrainerFeedback(this, Member_ID);
            this.Hide();
            temp_form.Show();
        }

        private void GymMembership_Click(object sender, EventArgs e)
        {
            Form temp_form = new Member_getMembership(this, Member_ID);
            this.Hide();
            temp_form.Show();
        }
    }
}
