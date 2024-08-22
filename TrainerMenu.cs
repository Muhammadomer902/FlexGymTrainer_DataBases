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

    public partial class TrainerMenu : Form
    {
        private Form prevForm;
        private int Trainer_ID;


        public TrainerMenu(Form prevForm, int trainer_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            Trainer_ID = trainer_ID;
        }


        private void TrainerMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void Signout_Click_1(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void T_W_planning_Click(object sender, EventArgs e)
        {
            Form temp_form = new Trainer_WorkoutPlanning(this, Trainer_ID);
            this.Hide();
            temp_form.Show();
        }

        private void T_W_Report_Click(object sender, EventArgs e)
        {
            Form temp_form = new Trainer_WorkoutReport(this, Trainer_ID);
            this.Hide();
            temp_form.Show();
        }

        private void T_D_planning_Click(object sender, EventArgs e)
        {
            Form temp_form = new TrainerDietPlanning(this, Trainer_ID);
            this.Hide();
            temp_form.Show();
        }

        private void T_D_Report_Click(object sender, EventArgs e)
        {
            Form temp_form = new Trainer_DietPlanReport(this, Trainer_ID);
            this.Hide();
            temp_form.Show();
        }

        private void T_Appointment_Click(object sender, EventArgs e)
        {
            Form temp_form = new Trainer_SessionManagement(this, Trainer_ID);
            this.Hide();
            temp_form.Show();
        }

        private void T_feedback_Click(object sender, EventArgs e)
        {
            Form temp_form = new Training_Feedback(this, Trainer_ID);
            this.Hide();
            temp_form.Show();
        }

        private void T_RegisterToGym_Click(object sender, EventArgs e)
        {
            Form temp_form = new Trainer_RegisterToGym(this, Trainer_ID);
            this.Hide();
            temp_form.Show();
        }
    }
}
