using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class ViewSchedulesForm : Form
    {
        public ViewSchedulesForm()
        {
            InitializeComponent();
            // ...
            this.Text = "ViewSchedulesForm";
            this.Load += new System.EventHandler(this.ViewSchedulesForm_Load); // ✅ Add this

        }

        private void ViewSchedulesForm_Load(object sender, EventArgs e)
        {
            LoadSchedules();
        }

        private void LoadSchedules()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TrainName, Source, Destination FROM Train";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSchedules.DataSource = dt;

                // ✅ Optional styling
                dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSchedules.ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to Dashboard
            DashboardForm dashboard = new DashboardForm("Passenger", 0); // Replace 0 with actual passenger ID if needed
            dashboard.Show();
            this.Close();
        }
    }
}
