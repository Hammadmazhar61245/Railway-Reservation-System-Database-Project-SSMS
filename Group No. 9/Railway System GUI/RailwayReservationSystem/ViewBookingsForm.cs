using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class ViewBookingsForm : Form
    {
        private int _passengerId;

        public ViewBookingsForm(int passengerId)
        {
            InitializeComponent();
            _passengerId = passengerId;
        }

        private void ViewBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();

            dgvBookings.ReadOnly = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadBookings()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT b.BookingID, t.TrainName, b.SeatNumber, b.DateOfDeparture, b.TimeOfDeparture
                    FROM Bookings b
                    INNER JOIN Train t ON b.TrainID = t.TrainID
                    WHERE b.PassengerID = @passengerId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@passengerId", _passengerId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBookings.DataSource = dt;

                // Add buttons only once
                if (!dgvBookings.Columns.Contains("Delete") && !dgvBookings.Columns.Contains("Save"))
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                    deleteButton.Name = "Delete";
                    deleteButton.Text = "Delete";
                    deleteButton.UseColumnTextForButtonValue = true;
                    dgvBookings.Columns.Add(deleteButton);

                    DataGridViewButtonColumn saveButton = new DataGridViewButtonColumn();
                    saveButton.Name = "Save";
                    saveButton.Text = "Save";
                    saveButton.UseColumnTextForButtonValue = true;
                    dgvBookings.Columns.Add(saveButton);
                }

                dgvBookings.Columns["BookingID"].ReadOnly = true;
                dgvBookings.Columns["TrainName"].ReadOnly = true;
            }
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string action = dgvBookings.Columns[e.ColumnIndex].Name;
                int bookingId = Convert.ToInt32(dgvBookings.Rows[e.RowIndex].Cells["BookingID"].Value);

                if (action == "Delete")
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        DeleteBooking(bookingId);
                        LoadBookings();
                    }
                }
                else if (action == "Save")
                {
                    try
                    {
                        string seatNumber = dgvBookings.Rows[e.RowIndex].Cells["SeatNumber"].Value.ToString();
                        DateTime departureDate = Convert.ToDateTime(dgvBookings.Rows[e.RowIndex].Cells["DateOfDeparture"].Value);
                        TimeSpan departureTime = TimeSpan.Parse(dgvBookings.Rows[e.RowIndex].Cells["TimeOfDeparture"].Value.ToString());

                        UpdateBooking(bookingId, seatNumber, departureDate, departureTime);
                        MessageBox.Show("Booking updated successfully!");
                        LoadBookings();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating booking: " + ex.Message);
                    }
                }
            }
        }

        private void DeleteBooking(int bookingId)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Bookings WHERE BookingID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", bookingId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateBooking(int bookingId, string seatNumber, DateTime date, TimeSpan time)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Bookings SET SeatNumber = @seat, DateOfDeparture = @date, TimeOfDeparture = @time WHERE BookingID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@seat", seatNumber);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@id", bookingId);

                conn.Open();
                cmd.ExecuteNonQuery();
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
