using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ApplyProfessionalStyling();
        }

        private void ApplyProfessionalStyling()
        {
            // === Form Styling ===
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // === Label Styling ===
            Label[] labels = { lblUsername, lblPassword };
            foreach (var lbl in labels)
            {
                lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                lbl.ForeColor = Color.DimGray;
            }

            // === TextBox Styling ===
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;

            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.UseSystemPasswordChar = true;

            // === Button Styling ===
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;

            // === LinkLabel Styling ===
            linkRegister.LinkColor = Color.Teal;
            linkRegister.ActiveLinkColor = Color.DarkSlateGray;
            linkRegister.Font = new Font("Segoe UI", 9.5F, FontStyle.Underline);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT Role, PassengerID FROM UserAccount WHERE UserName = @username AND Password = @password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    int passengerId = reader["PassengerID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PassengerID"]);

                    if (passengerId == 0 && role == "Passenger")
                    {
                        MessageBox.Show("This user has no passenger profile linked. Please contact support.");
                        return;
                    }

                    MessageBox.Show("Login successful! Role: " + role);

                    DashboardForm dashboard = new DashboardForm(role, passengerId);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
