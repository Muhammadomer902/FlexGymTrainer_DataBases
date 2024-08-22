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
    public partial class GymOwnerMenu : Form
    {
        private Form prevForm;
        private int GymOwner_ID;
        public GymOwnerMenu(Form prevForm,int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.GymOwner_ID = gymOwner_ID;
        }
        
        

        private void GymOwnerMenu_Load(object sender, EventArgs e)
        {

        }

        private void Signout_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void O_addGym_Click(object sender, EventArgs e)
        {
            Form temp_form = new GymOwner_AddYourGym(this, GymOwner_ID);
            this.Hide();
            temp_form.Show();
        }

        private void O_NewTrainer_Click(object sender, EventArgs e)
        {
            Form temp_form = new GymOwner_AddNewTrainer(this, GymOwner_ID);
            this.Hide();
            temp_form.Show();
        }

        private void O_accManagement_Click(object sender, EventArgs e)
        {
            Form temp_form = new GymOwner_AccountManagement(this, GymOwner_ID);
            this.Hide();
            temp_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form temp_form = new GymOwner_TrainerRequest(this, GymOwner_ID);
            this.Hide();
            temp_form.Show();
        }

        private void O_memberReport_Click(object sender, EventArgs e)
        {
            Form temp_form = new GymOwner_MemberReport(this, GymOwner_ID);
            this.Hide();
            temp_form.Show();
        }

        private void O_trainerReport_Click(object sender, EventArgs e)
        {
            Form temp_form = new GymOwner_TrainerReport(this, GymOwner_ID);
            this.Hide();
            temp_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form temp_form = new GymOwner_ExtraReport(this, GymOwner_ID);
            this.Hide();
            temp_form.Show();
        }
    }
}
