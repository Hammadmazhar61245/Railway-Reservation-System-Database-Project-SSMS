using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class FeedbackForm : Form
    {
        private int _passengerId;

        public FeedbackForm(int passengerId)
        {
            InitializeComponent();
            _passengerId = passengerId;
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            // Load only this passenger's bookings into the ComboBox
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID FROM Bookings WHERE PassengerID = @passengerId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@passengerId", _passengerId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbBookingID.Items.Add(reader["BookingID"].ToString());
                }

                conn.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbBookingID.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            int bookingId = Convert.ToInt32(cmbBookingID.SelectedItem.ToString());
            string comments = txtComments.Text.Trim();
            int rating = (int)nudRating.Value;

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Feedback (BookingID, Rating, Comments)
                    VALUES (@bookingId, @rating, @comments)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bookingId", bookingId);
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@comments", comments);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thank you for your feedback!");

                // Optionally clear the form
                cmbBookingID.SelectedIndex = -1;
                txtComments.Clear();
                nudRating.Value = 1;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm("Passenger", _passengerId);
            dashboard.Show();
            this.Close();
        }
    }
}
