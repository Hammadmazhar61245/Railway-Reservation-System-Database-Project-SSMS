using System;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class PassengerMgmtForm : Form
    {
        public PassengerMgmtForm()
        {
            InitializeComponent();
            SetupPassengerUI();
        }

        private void PassengerMgmtForm_Load(object sender, EventArgs e)
        {
            // Future: Load data from DB into DataGridView
        }

        private void SetupPassengerUI()
        {
            this.Text = "Passenger Management";
            this.Size = new System.Drawing.Size(850, 650);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Labels and Inputs
            Label lblName = new Label() { Text = "Name", Top = 20, Left = 30 };
            TextBox txtName = new TextBox() { Top = lblName.Top, Left = 150, Width = 250 };

            Label lblGender = new Label() { Text = "Gender", Top = 60, Left = 30 };
            ComboBox cbGender = new ComboBox() { Top = lblGender.Top, Left = 150, Width = 250 };
            cbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });

            Label lblAge = new Label() { Text = "Age", Top = 100, Left = 30 };
            NumericUpDown numAge = new NumericUpDown() { Top = lblAge.Top, Left = 150, Width = 250, Minimum = 1, Maximum = 120 };

            Label lblPhone = new Label() { Text = "Phone", Top = 140, Left = 30 };
            TextBox txtPhone = new TextBox() { Top = lblPhone.Top, Left = 150, Width = 250 };

            Label lblEmail = new Label() { Text = "Email", Top = 180, Left = 30 };
            TextBox txtEmail = new TextBox() { Top = lblEmail.Top, Left = 150, Width = 250 };

            Label lblAddress = new Label() { Text = "Address", Top = 220, Left = 30 };
            TextBox txtAddress = new TextBox() { Top = lblAddress.Top, Left = 150, Width = 250, Height = 60, Multiline = true };

            // Buttons
            Button btnAdd = new Button() { Text = "Add", Top = 300, Left = 30, Width = 80 };
            Button btnUpdate = new Button() { Text = "Update", Top = 300, Left = 120, Width = 80 };
            Button btnDelete = new Button() { Text = "Delete", Top = 300, Left = 210, Width = 80 };
            Button btnClear = new Button() { Text = "Clear", Top = 300, Left = 300, Width = 80 };

            // DataGridView
            DataGridView dgvPassengers = new DataGridView()
            {
                Top = 350,
                Left = 30,
                Width = 760,
                Height = 220,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Add controls to form
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblGender);
            this.Controls.Add(cbGender);
            this.Controls.Add(lblAge);
            this.Controls.Add(numAge);
            this.Controls.Add(lblPhone);
            this.Controls.Add(txtPhone);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblAddress);
            this.Controls.Add(txtAddress);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);
            this.Controls.Add(dgvPassengers);
        }
    }
}
