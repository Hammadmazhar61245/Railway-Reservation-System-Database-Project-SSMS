using System;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class BookingMgmtForm : Form
    {
        public BookingMgmtForm()
        {
            InitializeComponent();
            SetupFormUI();
        }

        private void BookingMgmtForm_Load(object sender, EventArgs e)
        {
            // You can load booking data into DataGridView here
        }

        private void SetupFormUI()
        {
            this.Text = "Booking Management";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTrain = new Label() { Text = "Train", Top = 20, Left = 30 };
            ComboBox cbTrain = new ComboBox() { Top = lblTrain.Top, Left = 120, Width = 200 };
            cbTrain.Items.AddRange(new string[] { "Express 101", "FastTrack 202", "Metro 303" });

            Label lblDate = new Label() { Text = "Date", Top = 60, Left = 30 };
            DateTimePicker dpDate = new DateTimePicker() { Top = lblDate.Top, Left = 120, Width = 200 };

            Label lblClass = new Label() { Text = "Class", Top = 100, Left = 30 };
            ComboBox cbClass = new ComboBox() { Top = lblClass.Top, Left = 120, Width = 200 };
            cbClass.Items.AddRange(new string[] { "Economy", "Business", "First Class" });

            Label lblSeats = new Label() { Text = "Seats", Top = 140, Left = 30 };
            NumericUpDown numSeats = new NumericUpDown() { Top = lblSeats.Top, Left = 120, Width = 200, Minimum = 1, Maximum = 10 };

            // Buttons
            Button btnAdd = new Button() { Text = "Add", Top = 180, Left = 30, Width = 80 };
            Button btnUpdate = new Button() { Text = "Update", Top = 180, Left = 120, Width = 80 };
            Button btnDelete = new Button() { Text = "Delete", Top = 180, Left = 210, Width = 80 };
            Button btnClear = new Button() { Text = "Clear", Top = 180, Left = 300, Width = 80 };

            // Data Grid
            DataGridView dgvBookings = new DataGridView()
            {
                Top = 230,
                Left = 30,
                Width = 720,
                Height = 300,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Add controls to the form
            this.Controls.Add(lblTrain);
            this.Controls.Add(cbTrain);
            this.Controls.Add(lblDate);
            this.Controls.Add(dpDate);
            this.Controls.Add(lblClass);
            this.Controls.Add(cbClass);
            this.Controls.Add(lblSeats);
            this.Controls.Add(numSeats);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);
            this.Controls.Add(dgvBookings);
        }
    }
}
