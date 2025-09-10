using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class BookingForm : Form
    {
        private int _passengerId;

        public BookingForm(int passengerId)
        {
            InitializeComponent();
            _passengerId = passengerId;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadTrains();
            ApplyProfessionalStyling();
        }

        private void LoadTrains()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TrainID, TrainName FROM Train";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable trainTable = new DataTable();
                adapter.Fill(trainTable);

                cmbTrain.DisplayMember = "TrainName";
                cmbTrain.ValueMember = "TrainID";
                cmbTrain.DataSource = trainTable;
            }
        }

        private void ApplyProfessionalStyling()
        {
            // === Form Styling ===
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // === Label Styling ===
            Label[] labels = { lblTrain, lblSeatNumber, lblDepartureDate, lblDepartureTime };
            foreach (var label in labels)
            {
                label.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                label.ForeColor = Color.DimGray;
            }

            // === Input Control Styling ===
            txtSeatNumber.Font = new Font("Segoe UI", 10F);
            txtSeatNumber.BorderStyle = BorderStyle.FixedSingle;
            txtSeatNumber.BackColor = Color.White;

            cmbTrain.Font = new Font("Segoe UI", 10F);
            cmbTrain.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpDepartureDate.CalendarMonthBackground = Color.White;
            dtpDepartureDate.Font = new Font("Segoe UI", 10F);

            dtpDepartureTime.CalendarMonthBackground = Color.White;
            dtpDepartureTime.Font = new Font("Segoe UI", 10F);

            // === Button Styling ===
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.BackColor = Color.MediumSeaGreen;
            btnBook.ForeColor = Color.White;
            btnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.Cursor = Cursors.Hand;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSeatNumber.Text))
            {
                MessageBox.Show("Please enter a seat number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTrain.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a train.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int trainId = Convert.ToInt32(cmbTrain.SelectedValue);
            string seatNumber = txtSeatNumber.Text.Trim();
            DateTime departureDate = dtpDepartureDate.Value.Date;
            TimeSpan departureTime = dtpDepartureTime.Value.TimeOfDay;

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Bookings (SeatNumber, DateOfDeparture, TimeOfDeparture, PassengerID, TrainID)
                                 VALUES (@seat, @date, @time, @passengerId, @trainId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@seat", seatNumber);
                command.Parameters.AddWithValue("@date", departureDate);
                command.Parameters.AddWithValue("@time", departureTime);
                command.Parameters.AddWithValue("@passengerId", _passengerId);
                command.Parameters.AddWithValue("@trainId", trainId);

                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Booking successful! Redirecting to your bookings...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ViewBookingsForm viewForm = new ViewBookingsForm(_passengerId);
                    viewForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Booking failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ClearFormFields()
        {
            txtSeatNumber.Clear();
            cmbTrain.SelectedIndex = 0;
            dtpDepartureDate.Value = DateTime.Now;
            dtpDepartureTime.Value = DateTime.Now;
        }
    }
}
