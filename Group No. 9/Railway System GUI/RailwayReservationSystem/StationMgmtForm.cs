using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class StationMgmtForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True;";
        int selectedStationID = -1;

        public StationMgmtForm()
        {
            InitializeComponent();
        }

        private void StationMgmtForm_Load(object sender, EventArgs e)
        {
            ApplyProfessionalStyling();
            LoadStations();
        }

        private void LoadStations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT StationID, StationName, City FROM Station";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Add Edit/Delete columns
                dgvStations.Columns.Clear();
                dgvStations.DataSource = dt;

                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.HeaderText = "Edit";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;
                dgvStations.Columns.Add(editBtn);

                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "Delete";
                deleteBtn.Text = "Delete";
                deleteBtn.UseColumnTextForButtonValue = true;
                dgvStations.Columns.Add(deleteBtn);
            }
        }

        private void ApplyProfessionalStyling()
        {
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (Controls.Find("lblHeader", true).FirstOrDefault() is Label lblHeader)
            {
                lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
                lblHeader.ForeColor = Color.DarkSlateGray;
            }

            if (Controls.Find("btnAddStation", true).FirstOrDefault() is Button btnAdd)
            {
                btnAdd.FlatStyle = FlatStyle.Flat;
                btnAdd.BackColor = Color.SeaGreen;
                btnAdd.ForeColor = Color.White;
                btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btnAdd.FlatAppearance.BorderSize = 0;
                btnAdd.Cursor = Cursors.Hand;
            }

            string[] textBoxNames = { "txtStationName", "txtCity" };
            foreach (string name in textBoxNames)
            {
                if (Controls.Find(name, true).FirstOrDefault() is TextBox txt)
                {
                    txt.Font = new Font("Segoe UI", 10F);
                    txt.BackColor = Color.White;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
            }

            if (Controls.Find("dgvStations", true).FirstOrDefault() is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.White;
                dgv.BorderStyle = BorderStyle.None;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                dgv.RowHeadersVisible = false;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.GridColor = Color.LightGray;
            }
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            string stationName = txtStationName.Text.Trim();
            string city = txtCity.Text.Trim();

            if (stationName == "" || city == "")
            {
                MessageBox.Show("Please enter both Station Name and City.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = selectedStationID == -1 ?
                    "INSERT INTO Station (StationName, City) VALUES (@name, @city)" :
                    "UPDATE Station SET StationName = @name, City = @city WHERE StationID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", stationName);
                cmd.Parameters.AddWithValue("@city", city);
                if (selectedStationID != -1)
                    cmd.Parameters.AddWithValue("@id", selectedStationID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(selectedStationID == -1 ? "Station added." : "Station updated.");
                LoadStations();
                txtStationName.Clear();
                txtCity.Clear();
                selectedStationID = -1;
            }
        }

        private void dgvStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int stationID = Convert.ToInt32(dgvStations.Rows[e.RowIndex].Cells["StationID"].Value);
            string stationName = dgvStations.Rows[e.RowIndex].Cells["StationName"].Value.ToString();
            string city = dgvStations.Rows[e.RowIndex].Cells["City"].Value.ToString();

            // Edit
            if (e.ColumnIndex == dgvStations.Columns["Edit"].Index)
            {
                txtStationName.Text = stationName;
                txtCity.Text = city;
                selectedStationID = stationID;
            }

            // Delete
            if (e.ColumnIndex == dgvStations.Columns["Delete"].Index)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this station?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string delQuery = "DELETE FROM Station WHERE StationID = @id";
                        SqlCommand cmd = new SqlCommand(delQuery, conn);
                        cmd.Parameters.AddWithValue("@id", stationID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Station deleted.");
                    LoadStations();
                }
            }
        }
    }
}
