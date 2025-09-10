namespace RailwayReservationSystem
{
    partial class DashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnViewSchedules = new System.Windows.Forms.Button();
            this.btnTrainMgmt = new System.Windows.Forms.Button();
            this.btnStationMgmt = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(228, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(65, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(181, 67);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(158, 16);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role: [Admin/Passenger]";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(89, 122);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(179, 47);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Book Ticket";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(274, 198);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(179, 47);
            this.btnFeedback.TabIndex = 3;
            this.btnFeedback.Text = "Submit Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnViewSchedules
            // 
            this.btnViewSchedules.Location = new System.Drawing.Point(89, 198);
            this.btnViewSchedules.Name = "btnViewSchedules";
            this.btnViewSchedules.Size = new System.Drawing.Size(179, 47);
            this.btnViewSchedules.TabIndex = 4;
            this.btnViewSchedules.Text = "View Train Schedule";
            this.btnViewSchedules.UseVisualStyleBackColor = true;
            this.btnViewSchedules.Click += new System.EventHandler(this.btnViewSchedules_Click);
            // 
            // btnTrainMgmt
            // 
            this.btnTrainMgmt.Location = new System.Drawing.Point(274, 122);
            this.btnTrainMgmt.Name = "btnTrainMgmt";
            this.btnTrainMgmt.Size = new System.Drawing.Size(179, 47);
            this.btnTrainMgmt.TabIndex = 5;
            this.btnTrainMgmt.Text = "Manage Trains";
            this.btnTrainMgmt.UseVisualStyleBackColor = true;
            this.btnTrainMgmt.Click += new System.EventHandler(this.btnTrainMgmt_Click);
            // 
            // btnStationMgmt
            // 
            this.btnStationMgmt.Location = new System.Drawing.Point(89, 272);
            this.btnStationMgmt.Name = "btnStationMgmt";
            this.btnStationMgmt.Size = new System.Drawing.Size(179, 43);
            this.btnStationMgmt.TabIndex = 6;
            this.btnStationMgmt.Text = "Manage Stations";
            this.btnStationMgmt.UseVisualStyleBackColor = true;
            this.btnStationMgmt.Click += new System.EventHandler(this.btnStationMgmt_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(274, 270);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 47);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 379);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStationMgmt);
            this.Controls.Add(this.btnTrainMgmt);
            this.Controls.Add(this.btnViewSchedules);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnViewSchedules;
        private System.Windows.Forms.Button btnTrainMgmt;
        private System.Windows.Forms.Button btnStationMgmt;
        private System.Windows.Forms.Button btnLogout;
    }
}