using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class TrainMgmtForm : Form
    {
        private int selectedTrainId;
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";

        public TrainMgmtForm()
        {
            InitializeComponent();
        }

        private void TrainMgmtForm_Load(object sender, EventArgs e)
        {
            LoadTrains();
        }

        private void LoadTrains()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Train";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTrains.DataSource = dt;
            }
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            string name = txtTrainName.Text.Trim();
            string source = txtSource.Text.Trim();
            string destination = txtDestination.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Train (TrainName, Source, Destination) VALUES (@name, @source, @destination)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@destination", destination);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Train added successfully.");
            ClearFields();
            LoadTrains();
        }

        private void dgvTrains_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedTrainId = Convert.ToInt32(dgvTrains.Rows[e.RowIndex].Cells["TrainID"].Value);
                txtTrainName.Text = dgvTrains.Rows[e.RowIndex].Cells["TrainName"].Value.ToString();
                txtSource.Text = dgvTrains.Rows[e.RowIndex].Cells["Source"].Value.ToString();
                txtDestination.Text = dgvTrains.Rows[e.RowIndex].Cells["Destination"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTrainId == 0)
            {
                MessageBox.Show("Please select a train to update.");
                return;
            }

            string name = txtTrainName.Text.Trim();
            string source = txtSource.Text.Trim();
            string destination = txtDestination.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Train SET TrainName = @name, Source = @source, Destination = @destination WHERE TrainID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@destination", destination);
                cmd.Parameters.AddWithValue("@id", selectedTrainId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Train updated successfully.");
            ClearFields();
            LoadTrains();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTrainId == 0)
            {
                MessageBox.Show("Please select a train to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure to delete this train?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Train WHERE TrainID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedTrainId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Train deleted.");
                ClearFields();
                LoadTrains();
            }
        }

        private void ClearFields()
        {
            txtTrainName.Text = "";
            txtSource.Text = "";
            txtDestination.Text = "";
            selectedTrainId = 0;
        }

        // Optional: Ignore or delete unused label click handler
        private void label1_Click(object sender, EventArgs e)
        {
            // Can be removed if unused
        }
    }
}
