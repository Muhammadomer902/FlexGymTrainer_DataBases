namespace Database_Project
{
    partial class GetUserType
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
            this.exit = new System.Windows.Forms.Button();
            this.GoToLogin = new System.Windows.Forms.Button();
            this.GoToSignup = new System.Windows.Forms.Button();
            this.WELCOME = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectUserType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightGray;
            this.exit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(467, 626);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(157, 52);
            this.exit.TabIndex = 48;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // GoToLogin
            // 
            this.GoToLogin.BackColor = System.Drawing.Color.LightGray;
            this.GoToLogin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToLogin.ForeColor = System.Drawing.Color.Black;
            this.GoToLogin.Location = new System.Drawing.Point(569, 500);
            this.GoToLogin.Name = "GoToLogin";
            this.GoToLogin.Size = new System.Drawing.Size(157, 52);
            this.GoToLogin.TabIndex = 47;
            this.GoToLogin.Text = "Login";
            this.GoToLogin.UseVisualStyleBackColor = false;
            this.GoToLogin.Click += new System.EventHandler(this.GoToLogin_Click);
            // 
            // GoToSignup
            // 
            this.GoToSignup.BackColor = System.Drawing.Color.LightGray;
            this.GoToSignup.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToSignup.ForeColor = System.Drawing.Color.Black;
            this.GoToSignup.Location = new System.Drawing.Point(374, 500);
            this.GoToSignup.Name = "GoToSignup";
            this.GoToSignup.Size = new System.Drawing.Size(157, 52);
            this.GoToSignup.TabIndex = 46;
            this.GoToSignup.Text = "Signup";
            this.GoToSignup.UseVisualStyleBackColor = false;
            this.GoToSignup.Click += new System.EventHandler(this.GoToSignup_Click_1);
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.WELCOME.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WELCOME.Location = new System.Drawing.Point(137, 173);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(827, 58);
            this.WELCOME.TabIndex = 45;
            this.WELCOME.Text = "WELCOME TO FLEX TRAINER";
            this.WELCOME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(231, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "USER TYPE";
            // 
            // SelectUserType
            // 
            this.SelectUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectUserType.FormattingEnabled = true;
            this.SelectUserType.Items.AddRange(new object[] {
            "Member",
            "Trainer",
            "Gym Owner",
            "Admin"});
            this.SelectUserType.Location = new System.Drawing.Point(418, 389);
            this.SelectUserType.Name = "SelectUserType";
            this.SelectUserType.Size = new System.Drawing.Size(451, 28);
            this.SelectUserType.TabIndex = 43;
            this.SelectUserType.SelectedIndexChanged += new System.EventHandler(this.SelectUserType_SelectedIndexChanged);
            // 
            // GetUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.GoToLogin);
            this.Controls.Add(this.GoToSignup);
            this.Controls.Add(this.WELCOME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectUserType);
            this.Name = "GetUserType";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.GetUserType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button GoToLogin;
        private System.Windows.Forms.Button GoToSignup;
        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SelectUserType;
    }
}