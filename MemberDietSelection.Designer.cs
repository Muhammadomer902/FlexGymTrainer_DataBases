namespace Database_Project
{
    partial class MemberDietSelection
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.WELCOME = new System.Windows.Forms.Label();
            this.Allergens = new System.Windows.Forms.ComboBox();
            this.purposebox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cal = new System.Windows.Forms.TextBox();
            this.Fbr = new System.Windows.Forms.TextBox();
            this.Pro = new System.Windows.Forms.TextBox();
            this.Carbs = new System.Windows.Forms.TextBox();
            this.Fat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Meal_Time = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dietID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(479, 758);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 184;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(373, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 37);
            this.label1.TabIndex = 394;
            this.label1.Text = "Diet Plan Selection";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(448, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 37);
            this.label13.TabIndex = 393;
            this.label13.Text = "MEMBER";
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.WELCOME.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WELCOME.Location = new System.Drawing.Point(319, 9);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(444, 58);
            this.WELCOME.TabIndex = 392;
            this.WELCOME.Text = "FLEX TRAINER";
            this.WELCOME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Allergens
            // 
            this.Allergens.FormattingEnabled = true;
            this.Allergens.Items.AddRange(new object[] {
            "MILK",
            "EGG",
            "FISH",
            "TREE NUTS",
            "PEANUTS",
            "WHEAT",
            "SOYBEANS"});
            this.Allergens.Location = new System.Drawing.Point(352, 241);
            this.Allergens.Name = "Allergens";
            this.Allergens.Size = new System.Drawing.Size(230, 28);
            this.Allergens.TabIndex = 395;
            // 
            // purposebox
            // 
            this.purposebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purposebox.FormattingEnabled = true;
            this.purposebox.Items.AddRange(new object[] {
            "Bulking",
            "Cutting",
            "Weight Loss"});
            this.purposebox.Location = new System.Drawing.Point(100, 241);
            this.purposebox.Name = "purposebox";
            this.purposebox.Size = new System.Drawing.Size(230, 28);
            this.purposebox.TabIndex = 419;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(459, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 37);
            this.label2.TabIndex = 418;
            this.label2.Text = "FILTER";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(166, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 417;
            this.label11.Text = "PURPOSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(405, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 420;
            this.label3.Text = "ALLERGENS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(762, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 30);
            this.label10.TabIndex = 437;
            this.label10.Text = "Calories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(619, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 30);
            this.label9.TabIndex = 436;
            this.label9.Text = "Fiber (g)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(461, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 30);
            this.label8.TabIndex = 435;
            this.label8.Text = "Protein (g)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(327, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 30);
            this.label7.TabIndex = 434;
            this.label7.Text = "Carbs (g)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(192, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 30);
            this.label5.TabIndex = 433;
            this.label5.Text = "Fat (g)";
            // 
            // Cal
            // 
            this.Cal.Location = new System.Drawing.Point(758, 330);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(127, 26);
            this.Cal.TabIndex = 432;
            // 
            // Fbr
            // 
            this.Fbr.Location = new System.Drawing.Point(614, 330);
            this.Fbr.Name = "Fbr";
            this.Fbr.Size = new System.Drawing.Size(127, 26);
            this.Fbr.TabIndex = 431;
            // 
            // Pro
            // 
            this.Pro.Location = new System.Drawing.Point(468, 330);
            this.Pro.Name = "Pro";
            this.Pro.Size = new System.Drawing.Size(127, 26);
            this.Pro.TabIndex = 430;
            // 
            // Carbs
            // 
            this.Carbs.Location = new System.Drawing.Point(323, 330);
            this.Carbs.Name = "Carbs";
            this.Carbs.Size = new System.Drawing.Size(127, 26);
            this.Carbs.TabIndex = 429;
            // 
            // Fat
            // 
            this.Fat.Location = new System.Drawing.Point(178, 330);
            this.Fat.Name = "Fat";
            this.Fat.Size = new System.Drawing.Size(127, 26);
            this.Fat.TabIndex = 428;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(878, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 37);
            this.button2.TabIndex = 438;
            this.button2.Text = "Apply Filter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(100, 431);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(907, 269);
            this.richTextBox1.TabIndex = 439;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(660, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 441;
            this.label4.Text = "MEAL TIME";
            // 
            // Meal_Time
            // 
            this.Meal_Time.FormattingEnabled = true;
            this.Meal_Time.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "All"});
            this.Meal_Time.Location = new System.Drawing.Point(604, 241);
            this.Meal_Time.Name = "Meal_Time";
            this.Meal_Time.Size = new System.Drawing.Size(230, 28);
            this.Meal_Time.TabIndex = 440;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(804, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 37);
            this.button3.TabIndex = 451;
            this.button3.Text = "FOLLOW";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(168, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 30);
            this.label6.TabIndex = 450;
            this.label6.Text = "Diet Plan You Want To Follow";
            // 
            // dietID
            // 
            this.dietID.Location = new System.Drawing.Point(614, 380);
            this.dietID.Name = "dietID";
            this.dietID.Size = new System.Drawing.Size(127, 26);
            this.dietID.TabIndex = 449;
            // 
            // MemberDietSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dietID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Meal_Time);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cal);
            this.Controls.Add(this.Fbr);
            this.Controls.Add(this.Pro);
            this.Controls.Add(this.Carbs);
            this.Controls.Add(this.Fat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purposebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Allergens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WELCOME);
            this.Controls.Add(this.button1);
            this.Name = "MemberDietSelection";
            this.Text = "MemberDietSelection";
            this.Load += new System.EventHandler(this.MemberDietSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.ComboBox Allergens;
        private System.Windows.Forms.ComboBox purposebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cal;
        private System.Windows.Forms.TextBox Fbr;
        private System.Windows.Forms.TextBox Pro;
        private System.Windows.Forms.TextBox Carbs;
        private System.Windows.Forms.TextBox Fat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Meal_Time;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dietID;
    }
}