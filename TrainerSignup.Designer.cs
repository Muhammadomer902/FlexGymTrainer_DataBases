namespace Database_Project
{
    partial class TrainerSignup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoB = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.GoToSignup = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cnic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.TextBox();
            this.m_name = new System.Windows.Forms.TextBox();
            this.previousGym = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.f_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WELCOME = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Speciality = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // DoB
            // 
            this.DoB.Location = new System.Drawing.Point(652, 492);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(299, 26);
            this.DoB.TabIndex = 142;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(394, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 141;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoToSignup
            // 
            this.GoToSignup.BackColor = System.Drawing.Color.LightGray;
            this.GoToSignup.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToSignup.ForeColor = System.Drawing.Color.Black;
            this.GoToSignup.Location = new System.Drawing.Point(562, 737);
            this.GoToSignup.Name = "GoToSignup";
            this.GoToSignup.Size = new System.Drawing.Size(157, 52);
            this.GoToSignup.TabIndex = 140;
            this.GoToSignup.Text = "Finish";
            this.GoToSignup.UseVisualStyleBackColor = false;
            this.GoToSignup.Click += new System.EventHandler(this.GoToSignup_Click);
            // 
            // exp
            // 
            this.exp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exp.FormattingEnabled = true;
            this.exp.Items.AddRange(new object[] {
            "Novice",
            "Intermediate",
            "Expert"});
            this.exp.Location = new System.Drawing.Point(314, 441);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(193, 28);
            this.exp.TabIndex = 139;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(390, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(333, 37);
            this.label13.TabIndex = 138;
            this.label13.Text = "TRAINER SIGNUP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(149, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 137;
            this.label4.Text = "USERNAME";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(313, 231);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(194, 26);
            this.username.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(543, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 135;
            this.label6.Text = "PASSWORD";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(699, 231);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(252, 26);
            this.password.TabIndex = 134;
            this.password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(704, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 133;
            this.label3.Text = "DATE OF BIRTH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(149, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 21);
            this.label10.TabIndex = 132;
            this.label10.Text = "EXPERIENCE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(149, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 21);
            this.label8.TabIndex = 131;
            this.label8.Text = "PREVIOUS GYM";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(652, 388);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(299, 26);
            this.contact.TabIndex = 130;
            this.contact.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(543, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 129;
            this.label7.Text = "CONTACT";
            // 
            // cnic
            // 
            this.cnic.Location = new System.Drawing.Point(652, 335);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(299, 26);
            this.cnic.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 127;
            this.label1.Text = "CINIC";
            // 
            // l_name
            // 
            this.l_name.Location = new System.Drawing.Point(746, 280);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(205, 26);
            this.l_name.TabIndex = 126;
            this.l_name.Text = "Last Name";
            this.l_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_name
            // 
            this.m_name.Location = new System.Drawing.Point(527, 280);
            this.m_name.Name = "m_name";
            this.m_name.Size = new System.Drawing.Size(203, 26);
            this.m_name.TabIndex = 125;
            this.m_name.Text = "Middle Name";
            this.m_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // previousGym
            // 
            this.previousGym.Location = new System.Drawing.Point(313, 391);
            this.previousGym.Name = "previousGym";
            this.previousGym.Size = new System.Drawing.Size(194, 26);
            this.previousGym.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(149, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 123;
            this.label5.Text = "GENDER";
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.gender.Location = new System.Drawing.Point(314, 335);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(193, 28);
            this.gender.TabIndex = 122;
            // 
            // f_name
            // 
            this.f_name.AccessibleName = "";
            this.f_name.Location = new System.Drawing.Point(313, 280);
            this.f_name.Name = "f_name";
            this.f_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f_name.Size = new System.Drawing.Size(194, 26);
            this.f_name.TabIndex = 121;
            this.f_name.Text = "First Name";
            this.f_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 120;
            this.label2.Text = "NAME";
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.WELCOME.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WELCOME.Location = new System.Drawing.Point(334, 61);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(444, 58);
            this.WELCOME.TabIndex = 119;
            this.WELCOME.Text = "FLEX TRAINER";
            this.WELCOME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(149, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 21);
            this.label12.TabIndex = 144;
            this.label12.Text = "SPECIALITY";
            // 
            // Speciality
            // 
            this.Speciality.BackColor = System.Drawing.Color.LightGray;
            this.Speciality.FormattingEnabled = true;
            this.Speciality.Items.AddRange(new object[] {
            "Strength Training Specialist",
            "Functional Fitness Coach",
            "Nutrition and Weight Management Consultant",
            "Sports-Specific Trainer",
            "Group Fitness Instructor"});
            this.Speciality.Location = new System.Drawing.Point(314, 533);
            this.Speciality.Name = "Speciality";
            this.Speciality.Size = new System.Drawing.Size(392, 73);
            this.Speciality.TabIndex = 143;
            // 
            // TrainerSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Speciality);
            this.Controls.Add(this.DoB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoToSignup);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.m_name);
            this.Controls.Add(this.previousGym);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WELCOME);
            this.Name = "TrainerSignup";
            this.Text = "TrainerSignup";
            this.Load += new System.EventHandler(this.TrainerSignup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DoB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GoToSignup;
        private System.Windows.Forms.ComboBox exp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox l_name;
        private System.Windows.Forms.TextBox m_name;
        private System.Windows.Forms.TextBox previousGym;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox Speciality;
    }
}