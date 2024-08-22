namespace Database_Project
{
    partial class MemberSignup
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
            this.label12 = new System.Windows.Forms.Label();
            this.Allergen = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.purpose = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cnic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.TextBox();
            this.m_name = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.f_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WELCOME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoB
            // 
            this.DoB.Location = new System.Drawing.Point(648, 484);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(299, 26);
            this.DoB.TabIndex = 119;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(394, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 118;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GoToSignup
            // 
            this.GoToSignup.BackColor = System.Drawing.Color.LightGray;
            this.GoToSignup.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToSignup.ForeColor = System.Drawing.Color.Black;
            this.GoToSignup.Location = new System.Drawing.Point(562, 737);
            this.GoToSignup.Name = "GoToSignup";
            this.GoToSignup.Size = new System.Drawing.Size(157, 52);
            this.GoToSignup.TabIndex = 117;
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
            this.exp.Location = new System.Drawing.Point(310, 441);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(193, 28);
            this.exp.TabIndex = 116;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(390, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(333, 37);
            this.label13.TabIndex = 115;
            this.label13.Text = "MEMBER SIGNUP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 114;
            this.label4.Text = "USERNAME";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(309, 231);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(194, 26);
            this.username.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(539, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 112;
            this.label6.Text = "PASSWORD";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(695, 231);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(252, 26);
            this.password.TabIndex = 111;
            this.password.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(153, 620);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 21);
            this.label12.TabIndex = 110;
            this.label12.Text = "ALLERGENS";
            // 
            // Allergen
            // 
            this.Allergen.BackColor = System.Drawing.Color.LightGray;
            this.Allergen.FormattingEnabled = true;
            this.Allergen.Items.AddRange(new object[] {
            "MILK",
            "EGG",
            "FISH",
            "TREE NUTS",
            "PEANUTS",
            "WHEAT",
            "SOYBEANS"});
            this.Allergen.Location = new System.Drawing.Point(309, 620);
            this.Allergen.Name = "Allergen";
            this.Allergen.Size = new System.Drawing.Size(194, 73);
            this.Allergen.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(700, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 108;
            this.label3.Text = "DATE OF BIRTH";
            // 
            // purpose
            // 
            this.purpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purpose.FormattingEnabled = true;
            this.purpose.Items.AddRange(new object[] {
            "BULKING",
            "CUTTING",
            "WEIGHT LOSS"});
            this.purpose.Location = new System.Drawing.Point(310, 558);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(193, 28);
            this.purpose.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(153, 560);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 106;
            this.label11.Text = "PURPOSE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(153, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 21);
            this.label10.TabIndex = 105;
            this.label10.Text = "EXPERIENCE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(153, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 104;
            this.label9.Text = "WEIGHT";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(309, 503);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(194, 26);
            this.weight.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(153, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 102;
            this.label8.Text = "HEIGHT";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(648, 388);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(299, 26);
            this.contact.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(539, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 100;
            this.label7.Text = "CONTACT";
            // 
            // cnic
            // 
            this.cnic.Location = new System.Drawing.Point(648, 335);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(299, 26);
            this.cnic.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(539, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 98;
            this.label1.Text = "CINIC";
            // 
            // l_name
            // 
            this.l_name.Location = new System.Drawing.Point(742, 280);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(205, 26);
            this.l_name.TabIndex = 97;
            this.l_name.Text = "Last Name";
            this.l_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_name
            // 
            this.m_name.Location = new System.Drawing.Point(523, 280);
            this.m_name.Name = "m_name";
            this.m_name.Size = new System.Drawing.Size(203, 26);
            this.m_name.TabIndex = 96;
            this.m_name.Text = "Middle Name";
            this.m_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(309, 391);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(194, 26);
            this.height.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(153, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 94;
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
            this.gender.Location = new System.Drawing.Point(310, 335);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(193, 28);
            this.gender.TabIndex = 93;
            // 
            // f_name
            // 
            this.f_name.AccessibleName = "";
            this.f_name.Location = new System.Drawing.Point(309, 280);
            this.f_name.Name = "f_name";
            this.f_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f_name.Size = new System.Drawing.Size(194, 26);
            this.f_name.TabIndex = 92;
            this.f_name.Text = "First Name";
            this.f_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 91;
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
            this.WELCOME.TabIndex = 90;
            this.WELCOME.Text = "FLEX TRAINER";
            this.WELCOME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MemberSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.DoB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoToSignup);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Allergen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purpose);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.m_name);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WELCOME);
            this.Name = "MemberSignup";
            this.Text = "MemberSignup";
            this.Load += new System.EventHandler(this.MemberSignup_Load);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox Allergen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox purpose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox l_name;
        private System.Windows.Forms.TextBox m_name;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WELCOME;
    }
}