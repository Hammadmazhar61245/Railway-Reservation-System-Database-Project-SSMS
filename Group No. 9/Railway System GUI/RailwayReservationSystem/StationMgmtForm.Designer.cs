namespace RailwayReservationSystem
{
    partial class StationMgmtForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStationName = new System.Windows.Forms.Label();
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Location = new System.Drawing.Point(81, 63);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(88, 16);
            this.lblStationName.TabIndex = 0;
            this.lblStationName.Text = "Station Name";
            // 
            // dgvStations
            // 
            this.dgvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvStations.Location = new System.Drawing.Point(84, 191);
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.RowHeadersWidth = 51;
            this.dgvStations.RowTemplate.Height = 24;
            this.dgvStations.Size = new System.Drawing.Size(480, 150);
            this.dgvStations.TabIndex = 1;
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(189, 63);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(151, 22);
            this.txtStationName.TabIndex = 2;
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(466, 63);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(98, 48);
            this.btnAddStation.TabIndex = 3;
            this.btnAddStation.Text = "Add Station";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(189, 106);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(151, 22);
            this.txtCity.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(81, 109);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // StationMgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 366);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnAddStation);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.dgvStations);
            this.Controls.Add(this.lblStationName);
            this.Name = "StationMgmtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StationMgmtForm";
            this.Load += new System.EventHandler(this.StationMgmtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.DataGridView dgvStations;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
    }
}