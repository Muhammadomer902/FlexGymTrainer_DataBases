namespace Database_Project
{
    partial class Member_getMembership
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
            this.MembershipType = new System.Windows.Forms.ComboBox();
            this.Book = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GymAvailable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(471, 762);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 188;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MembershipType
            // 
            this.MembershipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MembershipType.FormattingEnabled = true;
            this.MembershipType.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Diamond"});
            this.MembershipType.Location = new System.Drawing.Point(435, 370);
            this.MembershipType.Name = "MembershipType";
            this.MembershipType.Size = new System.Drawing.Size(451, 28);
            this.MembershipType.TabIndex = 198;
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.Color.LightGray;
            this.Book.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.Book.Location = new System.Drawing.Point(471, 534);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(157, 48);
            this.Book.TabIndex = 197;
            this.Book.Text = "BOOK";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(214, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 196;
            this.label5.Text = "Gym Available";
            // 
            // GymAvailable
            // 
            this.GymAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GymAvailable.FormattingEnabled = true;
            this.GymAvailable.Location = new System.Drawing.Point(435, 287);
            this.GymAvailable.Name = "GymAvailable";
            this.GymAvailable.Size = new System.Drawing.Size(451, 28);
            this.GymAvailable.TabIndex = 195;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(214, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 193;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 192;
            this.label2.Text = "Membership Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(344, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 37);
            this.label4.TabIndex = 391;
            this.label4.Text = "Get Your Gym Membership";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(469, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 37);
            this.label13.TabIndex = 390;
            this.label13.Text = "MEMBER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(340, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(444, 58);
            this.label7.TabIndex = 389;
            this.label7.Text = "FLEX TRAINER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Duration
            // 
            this.Duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Duration.FormattingEnabled = true;
            this.Duration.Items.AddRange(new object[] {
            "Week",
            "Month",
            "Six Month",
            "One Year"});
            this.Duration.Location = new System.Drawing.Point(435, 450);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(451, 28);
            this.Duration.TabIndex = 392;
            // 
            // Member_getMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MembershipType);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GymAvailable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Member_getMembership";
            this.Text = "Member_getMembership";
            this.Load += new System.EventHandler(this.Member_getMembership_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox MembershipType;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GymAvailable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Duration;
    }
}