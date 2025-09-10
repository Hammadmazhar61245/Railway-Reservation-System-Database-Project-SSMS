using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            ApplyProfessionalStyling();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            if (cmbGender.Items.Count == 0)
            {
                cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
                cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void ApplyProfessionalStyling()
        {
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10F);

            foreach (Control c in this.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.ForeColor = Color.SteelBlue;
                    lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
                else if (c is TextBox txt)
                {
                    txt.Font = new Font("Segoe UI", 10F);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (c is ComboBox cmb)
                {
                    cmb.Font = new Font("Segoe UI", 10F);
                    cmb.FlatStyle = FlatStyle.Flat;
                }
                else if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.MediumSeaGreen;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCNIC.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) || cmbGender.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid number for Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text.Trim();
            string cnic = txtCNIC.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string gender = cmbGender.Text;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string passengerInsert = @"
                        INSERT INTO Passenger (Name, CNIC, Age, Email, PhoneNumber, Gender) 
                        VALUES (@Name, @CNIC, @Age, @Email, @Phone, @Gender); 
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd1 = new SqlCommand(passengerInsert, connection);
                    cmd1.Parameters.AddWithValue("@Name", name);
                    cmd1.Parameters.AddWithValue("@CNIC", cnic);
                    cmd1.Parameters.AddWithValue("@Age", age);
                    cmd1.Parameters.AddWithValue("@Email", email);
                    cmd1.Parameters.AddWithValue("@Phone", phone);
                    cmd1.Parameters.AddWithValue("@Gender", gender);

                    int passengerID = Convert.ToInt32(cmd1.ExecuteScalar());

                    string userInsert = @"
                        INSERT INTO UserAccount (UserName, Password, Role, Email, PassengerID) 
                        VALUES (@Username, @Password, 'Passenger', @Email, @PassengerID)";

                    SqlCommand cmd2 = new SqlCommand(userInsert, connection);
                    cmd2.Parameters.AddWithValue("@Username", username);
                    cmd2.Parameters.AddWithValue("@Password", password);
                    cmd2.Parameters.AddWithValue("@Email", email);
                    cmd2.Parameters.AddWithValue("@PassengerID", passengerID);

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Added this method to fix the missing event handler error
        private void label5_Click(object sender, EventArgs e)
        {
            // You can leave this empty or add code here if needed
        }
    }
}
