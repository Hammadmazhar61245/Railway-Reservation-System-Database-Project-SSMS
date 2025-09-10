using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class DashboardForm : Form
    {
        private string currentRole;
        private int currentPassengerId;

        public DashboardForm(string role, int passengerId)
        {
            InitializeComponent();
            currentRole = role;
            currentPassengerId = passengerId;

            ApplyStyling();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblRole.Text = "Role: " + currentRole;
            lblWelcome.Text = "Welcome!";

            // Show/hide buttons based on role
            if (currentRole == "Admin")
            {
                btnTrainMgmt.Visible = true;
                btnStationMgmt.Visible = true;
                btnBooking.Visible = false;
                btnFeedback.Visible = false;
                btnViewSchedules.Visible = false;
            }
            else if (currentRole == "Passenger")
            {
                btnTrainMgmt.Visible = false;
                btnStationMgmt.Visible = false;
                btnBooking.Visible = true;
                btnFeedback.Visible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm(currentPassengerId);
            bookingForm.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedbackForm = new FeedbackForm(currentPassengerId);
            feedbackForm.Show();
            this.Hide(); // Optional: keeps one form open at a time// Will add later when FeedbackForm is created
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            // Optional: Add custom logic for welcome label click
        }

        private void ApplyStyling()
        {
            // === Form ===
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // === Label Styling ===
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblRole.ForeColor = Color.DimGray;

            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.SteelBlue;

            // === Button Styling Helper ===
            StyleButton(btnTrainMgmt);
            StyleButton(btnStationMgmt);
            StyleButton(btnBooking);
            StyleButton(btnFeedback);
            StyleButton(btnLogout);
        }

        private void StyleButton(Button btn)
        {
            btn.BackColor = Color.MediumSlateBlue;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        private void btnTrainMgmt_Click(object sender, EventArgs e)
        {
            TrainMgmtForm trainForm = new TrainMgmtForm();
            trainForm.Show();
            this.Hide(); // optional
        }

        private void btnStationMgmt_Click(object sender, EventArgs e)
        {
            StationMgmtForm stationForm = new StationMgmtForm();
            stationForm.ShowDialog();
        }

        private void btnViewSchedules_Click(object sender, EventArgs e)
        {
            ViewSchedulesForm schedulesForm = new ViewSchedulesForm();
            schedulesForm.Show();
        }
    }
}
