namespace Database_Project
{
    partial class TrainerDietPlanning
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
            this.button3 = new System.Windows.Forms.Button();
            this.W_Dinner = new System.Windows.Forms.ComboBox();
            this.C_Dinner = new System.Windows.Forms.ComboBox();
            this.B_Dinner = new System.Windows.Forms.ComboBox();
            this.W_Lunch = new System.Windows.Forms.ComboBox();
            this.C_Lunch = new System.Windows.Forms.ComboBox();
            this.B_Lunch = new System.Windows.Forms.ComboBox();
            this.W_Breakfast = new System.Windows.Forms.ComboBox();
            this.C_Breakfast = new System.Windows.Forms.ComboBox();
            this.B_Breakfast = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Cal_D = new System.Windows.Forms.TextBox();
            this.Fbr_D = new System.Windows.Forms.TextBox();
            this.Pro_D = new System.Windows.Forms.TextBox();
            this.Carbs_D = new System.Windows.Forms.TextBox();
            this.Fat_D = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Cal_L = new System.Windows.Forms.TextBox();
            this.Fbr_L = new System.Windows.Forms.TextBox();
            this.Pro_L = new System.Windows.Forms.TextBox();
            this.Carbs_L = new System.Windows.Forms.TextBox();
            this.Fat_L = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cal_B = new System.Windows.Forms.TextBox();
            this.Fbr_B = new System.Windows.Forms.TextBox();
            this.Pro_B = new System.Windows.Forms.TextBox();
            this.Carbs_B = new System.Windows.Forms.TextBox();
            this.Fat_B = new System.Windows.Forms.TextBox();
            this.Purpose = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.WELCOME = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(472, 714);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 52);
            this.button3.TabIndex = 550;
            this.button3.Text = "FINISH";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // W_Dinner
            // 
            this.W_Dinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.W_Dinner.FormattingEnabled = true;
            this.W_Dinner.Items.AddRange(new object[] {
            "Grilled Salmon with Steamed Vegetables",
            "Quinoa and Black Bean Salad",
            "Chicken Stir-Fry with Mixed Vegetables",
            "Vegetable Soup with Lean Turkey",
            "Baked Tofu with Roasted Brussels Sprouts"});
            this.W_Dinner.Location = new System.Drawing.Point(32, 555);
            this.W_Dinner.Name = "W_Dinner";
            this.W_Dinner.Size = new System.Drawing.Size(320, 28);
            this.W_Dinner.TabIndex = 548;
            this.W_Dinner.SelectedIndexChanged += new System.EventHandler(this.W_Dinner_SelectedIndexChanged);
            // 
            // C_Dinner
            // 
            this.C_Dinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Dinner.FormattingEnabled = true;
            this.C_Dinner.Items.AddRange(new object[] {
            "Grilled Chicken Breast with Steamed Vegetables",
            "Baked Salmon with Quinoa and Asparagus",
            "Turkey and Black Bean Chili",
            "Grilled Tofu with Stir-Fried Vegetables",
            "Shrimp and Zucchini Noodles with Pesto Sauce"});
            this.C_Dinner.Location = new System.Drawing.Point(32, 555);
            this.C_Dinner.Name = "C_Dinner";
            this.C_Dinner.Size = new System.Drawing.Size(320, 28);
            this.C_Dinner.TabIndex = 547;
            this.C_Dinner.SelectedIndexChanged += new System.EventHandler(this.C_Dinner_SelectedIndexChanged);
            // 
            // B_Dinner
            // 
            this.B_Dinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.B_Dinner.FormattingEnabled = true;
            this.B_Dinner.Items.AddRange(new object[] {
            "Grilled Salmon with Quinoa and Steamed Broccoli",
            "Beef Stir-Fry with Brown Rice and Mixed Vegetables",
            "Chicken Breast with Sweet Potato and Green Beans",
            "Vegetarian Chili with Black Beans and Quinoa",
            "Lean Beef Burger with Whole Wheat Bun and Side Salad"});
            this.B_Dinner.Location = new System.Drawing.Point(32, 555);
            this.B_Dinner.Name = "B_Dinner";
            this.B_Dinner.Size = new System.Drawing.Size(320, 28);
            this.B_Dinner.TabIndex = 546;
            this.B_Dinner.SelectedIndexChanged += new System.EventHandler(this.B_Dinner_SelectedIndexChanged);
            // 
            // W_Lunch
            // 
            this.W_Lunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.W_Lunch.FormattingEnabled = true;
            this.W_Lunch.Items.AddRange(new object[] {
            "Grilled Chicken Salad",
            "Vegetable Stir-fry with Tofu",
            "Quinoa and Black Bean Salad",
            "Turkey and Hummus Wrap",
            "Grilled Fish with Steamed Vegetables"});
            this.W_Lunch.Location = new System.Drawing.Point(32, 425);
            this.W_Lunch.Name = "W_Lunch";
            this.W_Lunch.Size = new System.Drawing.Size(320, 28);
            this.W_Lunch.TabIndex = 545;
            this.W_Lunch.SelectedIndexChanged += new System.EventHandler(this.W_Lunch_SelectedIndexChanged);
            // 
            // C_Lunch
            // 
            this.C_Lunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Lunch.FormattingEnabled = true;
            this.C_Lunch.Items.AddRange(new object[] {
            "Grilled Chicken Salad with Balsamic Vinaigrette",
            "Tuna Salad Wrap with Lettuce and Tomato",
            "Turkey and Avocado Whole Grain Sandwich",
            "Salmon Quinoa Bowl with Steamed Vegetables",
            "Grilled Veggie Wrap with Hummus"});
            this.C_Lunch.Location = new System.Drawing.Point(32, 425);
            this.C_Lunch.Name = "C_Lunch";
            this.C_Lunch.Size = new System.Drawing.Size(320, 28);
            this.C_Lunch.TabIndex = 544;
            this.C_Lunch.SelectedIndexChanged += new System.EventHandler(this.C_Lunch_SelectedIndexChanged);
            // 
            // B_Lunch
            // 
            this.B_Lunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.B_Lunch.FormattingEnabled = true;
            this.B_Lunch.Items.AddRange(new object[] {
            "Grilled Chicken and Quinoa Salad",
            "Beef Stir-Fry with Brown Rice",
            "Salmon and Sweet Potato Mash",
            "Tuna Sandwich on Whole Grain Bread",
            "Vegetarian Chickpea Curry with Basmati Rice"});
            this.B_Lunch.Location = new System.Drawing.Point(32, 425);
            this.B_Lunch.Name = "B_Lunch";
            this.B_Lunch.Size = new System.Drawing.Size(320, 28);
            this.B_Lunch.TabIndex = 543;
            this.B_Lunch.SelectedIndexChanged += new System.EventHandler(this.B_Lunch_SelectedIndexChanged);
            // 
            // W_Breakfast
            // 
            this.W_Breakfast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.W_Breakfast.FormattingEnabled = true;
            this.W_Breakfast.Items.AddRange(new object[] {
            "Greek Yogurt Parfait with Berries and Almonds",
            "Spinach and Mushroom Egg White Omelette",
            "Oatmeal with Chia Seeds and Fruit",
            "Whole Grain Toast with Avocado and Poached Egg",
            "Smoothie with Spinach, Banana, and Almond Milk"});
            this.W_Breakfast.Location = new System.Drawing.Point(32, 307);
            this.W_Breakfast.Name = "W_Breakfast";
            this.W_Breakfast.Size = new System.Drawing.Size(320, 28);
            this.W_Breakfast.TabIndex = 542;
            this.W_Breakfast.SelectedIndexChanged += new System.EventHandler(this.W_Breakfast_SelectedIndexChanged);
            // 
            // C_Breakfast
            // 
            this.C_Breakfast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Breakfast.FormattingEnabled = true;
            this.C_Breakfast.Items.AddRange(new object[] {
            "Greek Yogurt Parfait",
            "Egg White Omelette with Vegetables",
            "Oatmeal with Berries",
            "Avocado Toast on Whole Grain Bread",
            "Protein Smoothie with Spinach and Berries"});
            this.C_Breakfast.Location = new System.Drawing.Point(32, 307);
            this.C_Breakfast.Name = "C_Breakfast";
            this.C_Breakfast.Size = new System.Drawing.Size(320, 28);
            this.C_Breakfast.TabIndex = 541;
            this.C_Breakfast.SelectedIndexChanged += new System.EventHandler(this.C_Breakfast_SelectedIndexChanged);
            // 
            // B_Breakfast
            // 
            this.B_Breakfast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.B_Breakfast.FormattingEnabled = true;
            this.B_Breakfast.Items.AddRange(new object[] {
            "Egg and Cheese Breakfast Sandwich",
            "Greek Yogurt Parfait with Granola and Berries",
            "Oatmeal with Almond Butter and Banana",
            "Protein Pancakes with Maple Syrup",
            "Avocado Toast with Poached Eggs"});
            this.B_Breakfast.Location = new System.Drawing.Point(32, 307);
            this.B_Breakfast.Name = "B_Breakfast";
            this.B_Breakfast.Size = new System.Drawing.Size(320, 28);
            this.B_Breakfast.TabIndex = 540;
            this.B_Breakfast.SelectedIndexChanged += new System.EventHandler(this.B_Breakfast_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.IndianRed;
            this.label17.Location = new System.Drawing.Point(953, 496);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 30);
            this.label17.TabIndex = 539;
            this.label17.Text = "Calories";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.IndianRed;
            this.label18.Location = new System.Drawing.Point(804, 496);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 30);
            this.label18.TabIndex = 538;
            this.label18.Text = "Fiber (g)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.IndianRed;
            this.label19.Location = new System.Drawing.Point(645, 496);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 30);
            this.label19.TabIndex = 537;
            this.label19.Text = "Protein (g)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.IndianRed;
            this.label20.Location = new System.Drawing.Point(513, 496);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 30);
            this.label20.TabIndex = 536;
            this.label20.Text = "Carbs (g)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.IndianRed;
            this.label21.Location = new System.Drawing.Point(380, 496);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 30);
            this.label21.TabIndex = 535;
            this.label21.Text = "Fat (g)";
            // 
            // Cal_D
            // 
            this.Cal_D.Location = new System.Drawing.Point(946, 557);
            this.Cal_D.Name = "Cal_D";
            this.Cal_D.Size = new System.Drawing.Size(127, 26);
            this.Cal_D.TabIndex = 534;
            // 
            // Fbr_D
            // 
            this.Fbr_D.Location = new System.Drawing.Point(802, 557);
            this.Fbr_D.Name = "Fbr_D";
            this.Fbr_D.Size = new System.Drawing.Size(127, 26);
            this.Fbr_D.TabIndex = 533;
            // 
            // Pro_D
            // 
            this.Pro_D.Location = new System.Drawing.Point(656, 557);
            this.Pro_D.Name = "Pro_D";
            this.Pro_D.Size = new System.Drawing.Size(127, 26);
            this.Pro_D.TabIndex = 532;
            // 
            // Carbs_D
            // 
            this.Carbs_D.Location = new System.Drawing.Point(511, 557);
            this.Carbs_D.Name = "Carbs_D";
            this.Carbs_D.Size = new System.Drawing.Size(127, 26);
            this.Carbs_D.TabIndex = 531;
            // 
            // Fat_D
            // 
            this.Fat_D.Location = new System.Drawing.Point(366, 557);
            this.Fat_D.Name = "Fat_D";
            this.Fat_D.Size = new System.Drawing.Size(127, 26);
            this.Fat_D.TabIndex = 530;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(953, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 30);
            this.label12.TabIndex = 529;
            this.label12.Text = "Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(804, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 528;
            this.label2.Text = "Fiber (g)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.IndianRed;
            this.label14.Location = new System.Drawing.Point(645, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 30);
            this.label14.TabIndex = 527;
            this.label14.Text = "Protein (g)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.IndianRed;
            this.label15.Location = new System.Drawing.Point(513, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 30);
            this.label15.TabIndex = 526;
            this.label15.Text = "Carbs (g)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.IndianRed;
            this.label16.Location = new System.Drawing.Point(380, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 30);
            this.label16.TabIndex = 525;
            this.label16.Text = "Fat (g)";
            // 
            // Cal_L
            // 
            this.Cal_L.Location = new System.Drawing.Point(946, 427);
            this.Cal_L.Name = "Cal_L";
            this.Cal_L.Size = new System.Drawing.Size(127, 26);
            this.Cal_L.TabIndex = 524;
            // 
            // Fbr_L
            // 
            this.Fbr_L.Location = new System.Drawing.Point(802, 427);
            this.Fbr_L.Name = "Fbr_L";
            this.Fbr_L.Size = new System.Drawing.Size(127, 26);
            this.Fbr_L.TabIndex = 523;
            // 
            // Pro_L
            // 
            this.Pro_L.Location = new System.Drawing.Point(656, 427);
            this.Pro_L.Name = "Pro_L";
            this.Pro_L.Size = new System.Drawing.Size(127, 26);
            this.Pro_L.TabIndex = 522;
            // 
            // Carbs_L
            // 
            this.Carbs_L.Location = new System.Drawing.Point(511, 427);
            this.Carbs_L.Name = "Carbs_L";
            this.Carbs_L.Size = new System.Drawing.Size(127, 26);
            this.Carbs_L.TabIndex = 521;
            // 
            // Fat_L
            // 
            this.Fat_L.Location = new System.Drawing.Point(366, 427);
            this.Fat_L.Name = "Fat_L";
            this.Fat_L.Size = new System.Drawing.Size(127, 26);
            this.Fat_L.TabIndex = 520;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(953, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 30);
            this.label10.TabIndex = 519;
            this.label10.Text = "Calories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(804, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 30);
            this.label9.TabIndex = 518;
            this.label9.Text = "Fiber (g)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(645, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 30);
            this.label8.TabIndex = 517;
            this.label8.Text = "Protein (g)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(513, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 30);
            this.label7.TabIndex = 516;
            this.label7.Text = "Carbs (g)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(380, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 30);
            this.label5.TabIndex = 515;
            this.label5.Text = "Fat (g)";
            // 
            // Cal_B
            // 
            this.Cal_B.Location = new System.Drawing.Point(946, 309);
            this.Cal_B.Name = "Cal_B";
            this.Cal_B.Size = new System.Drawing.Size(127, 26);
            this.Cal_B.TabIndex = 514;
            // 
            // Fbr_B
            // 
            this.Fbr_B.Location = new System.Drawing.Point(802, 309);
            this.Fbr_B.Name = "Fbr_B";
            this.Fbr_B.Size = new System.Drawing.Size(127, 26);
            this.Fbr_B.TabIndex = 513;
            // 
            // Pro_B
            // 
            this.Pro_B.Location = new System.Drawing.Point(656, 309);
            this.Pro_B.Name = "Pro_B";
            this.Pro_B.Size = new System.Drawing.Size(127, 26);
            this.Pro_B.TabIndex = 512;
            // 
            // Carbs_B
            // 
            this.Carbs_B.Location = new System.Drawing.Point(511, 309);
            this.Carbs_B.Name = "Carbs_B";
            this.Carbs_B.Size = new System.Drawing.Size(127, 26);
            this.Carbs_B.TabIndex = 511;
            // 
            // Fat_B
            // 
            this.Fat_B.Location = new System.Drawing.Point(366, 309);
            this.Fat_B.Name = "Fat_B";
            this.Fat_B.Size = new System.Drawing.Size(127, 26);
            this.Fat_B.TabIndex = 510;
            // 
            // Purpose
            // 
            this.Purpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Purpose.FormattingEnabled = true;
            this.Purpose.Items.AddRange(new object[] {
            "BULKING",
            "CUTTING",
            "WEIGHT LOSS"});
            this.Purpose.Location = new System.Drawing.Point(184, 181);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(193, 28);
            this.Purpose.TabIndex = 509;
            this.Purpose.SelectedIndexChanged += new System.EventHandler(this.Purpose_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(27, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 30);
            this.label11.TabIndex = 508;
            this.label11.Text = "PURPOSE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(27, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 507;
            this.label4.Text = "Dinner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(27, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 506;
            this.label3.Text = "Lunch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(27, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 30);
            this.label6.TabIndex = 505;
            this.label6.Text = "Breakfast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(431, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 504;
            this.label1.Text = "Diet Planning";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(457, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 37);
            this.label13.TabIndex = 503;
            this.label13.Text = "TRAINER";
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.WELCOME.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WELCOME.Location = new System.Drawing.Point(328, 25);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(444, 58);
            this.WELCOME.TabIndex = 502;
            this.WELCOME.Text = "FLEX TRAINER";
            this.WELCOME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(472, 774);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 501;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainerDietPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.W_Dinner);
            this.Controls.Add(this.C_Dinner);
            this.Controls.Add(this.B_Dinner);
            this.Controls.Add(this.W_Lunch);
            this.Controls.Add(this.C_Lunch);
            this.Controls.Add(this.B_Lunch);
            this.Controls.Add(this.W_Breakfast);
            this.Controls.Add(this.C_Breakfast);
            this.Controls.Add(this.B_Breakfast);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Cal_D);
            this.Controls.Add(this.Fbr_D);
            this.Controls.Add(this.Pro_D);
            this.Controls.Add(this.Carbs_D);
            this.Controls.Add(this.Fat_D);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Cal_L);
            this.Controls.Add(this.Fbr_L);
            this.Controls.Add(this.Pro_L);
            this.Controls.Add(this.Carbs_L);
            this.Controls.Add(this.Fat_L);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cal_B);
            this.Controls.Add(this.Fbr_B);
            this.Controls.Add(this.Pro_B);
            this.Controls.Add(this.Carbs_B);
            this.Controls.Add(this.Fat_B);
            this.Controls.Add(this.Purpose);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WELCOME);
            this.Controls.Add(this.button1);
            this.Name = "TrainerDietPlanning";
            this.Text = "TrainerDietPlanning";
            this.Load += new System.EventHandler(this.TrainerDietPlanning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox W_Dinner;
        private System.Windows.Forms.ComboBox C_Dinner;
        private System.Windows.Forms.ComboBox B_Dinner;
        private System.Windows.Forms.ComboBox W_Lunch;
        private System.Windows.Forms.ComboBox C_Lunch;
        private System.Windows.Forms.ComboBox B_Lunch;
        private System.Windows.Forms.ComboBox W_Breakfast;
        private System.Windows.Forms.ComboBox C_Breakfast;
        private System.Windows.Forms.ComboBox B_Breakfast;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Cal_D;
        private System.Windows.Forms.TextBox Fbr_D;
        private System.Windows.Forms.TextBox Pro_D;
        private System.Windows.Forms.TextBox Carbs_D;
        private System.Windows.Forms.TextBox Fat_D;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Cal_L;
        private System.Windows.Forms.TextBox Fbr_L;
        private System.Windows.Forms.TextBox Pro_L;
        private System.Windows.Forms.TextBox Carbs_L;
        private System.Windows.Forms.TextBox Fat_L;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cal_B;
        private System.Windows.Forms.TextBox Fbr_B;
        private System.Windows.Forms.TextBox Pro_B;
        private System.Windows.Forms.TextBox Carbs_B;
        private System.Windows.Forms.TextBox Fat_B;
        private System.Windows.Forms.ComboBox Purpose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Button button1;
    }
}