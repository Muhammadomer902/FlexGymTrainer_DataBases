namespace Database_Project
{
    partial class AdminMenu
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
            this.Signout = new System.Windows.Forms.Button();
            this.A_revokeMembership = new System.Windows.Forms.Button();
            this.Admin_RegisterationRequest = new System.Windows.Forms.Button();
            this.Admin_gymPerformance = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.WELCOME = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.Signout.Location = new System.Drawing.Point(464, 759);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(179, 49);
            this.Signout.TabIndex = 135;
            this.Signout.Text = "SignOut";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // A_revokeMembership
            // 
            this.A_revokeMembership.BackColor = System.Drawing.Color.LightGray;
            this.A_revokeMembership.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.A_revokeMembership.Location = new System.Drawing.Point(361, 472);
            this.A_revokeMembership.Name = "A_revokeMembership";
            this.A_revokeMembership.Size = new System.Drawing.Size(387, 65);
            this.A_revokeMembership.TabIndex = 134;
            this.A_revokeMembership.Text = "Revoke Membership";
            this.A_revokeMembership.UseVisualStyleBackColor = false;
            this.A_revokeMembership.Click += new System.EventHandler(this.A_revokeMembership_Click);
            // 
            // Admin_RegisterationRequest
            // 
            this.Admin_RegisterationRequest.BackColor = System.Drawing.Color.LightGray;
            this.Admin_RegisterationRequest.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.Admin_RegisterationRequest.Location = new System.Drawing.Point(362, 371);
            this.Admin_RegisterationRequest.Name = "Admin_RegisterationRequest";
            this.Admin_RegisterationRequest.Size = new System.Drawing.Size(386, 65);
            this.Admin_RegisterationRequest.TabIndex = 133;
            this.Admin_RegisterationRequest.Text = "Registeration Request";
            this.Admin_RegisterationRequest.UseVisualStyleBackColor = false;
            this.Admin_RegisterationRequest.Click += new System.EventHandler(this.Admin_RegisterationRequest_Click);
            // 
            // Admin_gymPerformance
            // 
            this.Admin_gymPerformance.BackColor = System.Drawing.Color.LightGray;
            this.Admin_gymPerformance.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.Admin_gymPerformance.Location = new System.Drawing.Point(361, 270);
            this.Admin_gymPerformance.Name = "Admin_gymPerformance";
            this.Admin_gymPerformance.Size = new System.Drawing.Size(387, 65);
            this.Admin_gymPerformance.TabIndex = 132;
            this.Admin_gymPerformance.Text = "Gyms Performance";
            this.Admin_gymPerformance.UseVisualStyleBackColor = false;
            this.Admin_gymPerformance.Click += new System.EventHandler(this.Admin_gymPerformance_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(478, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 37);
            this.label13.TabIndex = 131;
            this.label13.Text = "ADMIN";
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.WELCOME.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WELCOME.Location = new System.Drawing.Point(328, 126);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(444, 58);
            this.WELCOME.TabIndex = 130;
            this.WELCOME.Text = "FLEX TRAINER";
            this.WELCOME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(361, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 65);
            this.button1.TabIndex = 136;
            this.button1.Text = "EXTRA REPORTS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(361, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(387, 65);
            this.button2.TabIndex = 137;
            this.button2.Text = "Gym Comparison";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.A_revokeMembership);
            this.Controls.Add(this.Admin_RegisterationRequest);
            this.Controls.Add(this.Admin_gymPerformance);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WELCOME);
            this.Name = "AdminMenu";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button A_revokeMembership;
        private System.Windows.Forms.Button Admin_RegisterationRequest;
        private System.Windows.Forms.Button Admin_gymPerformance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}