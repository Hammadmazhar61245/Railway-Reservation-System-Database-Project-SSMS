namespace RailwayReservationSystem
{
    partial class PassengerMgmtForm
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
            this.btnDeletePassenger = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.btnEditPassenger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletePassenger
            // 
            this.btnDeletePassenger.Location = new System.Drawing.Point(456, 346);
            this.btnDeletePassenger.Name = "btnDeletePassenger";
            this.btnDeletePassenger.Size = new System.Drawing.Size(112, 48);
            this.btnDeletePassenger.TabIndex = 0;
            this.btnDeletePassenger.Text = "Delete Selected";
            this.btnDeletePassenger.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(326, 52);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(155, 16);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Passenger Management";
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(60, 125);
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.RowHeadersWidth = 51;
            this.dgvPassengers.RowTemplate.Height = 24;
            this.dgvPassengers.Size = new System.Drawing.Size(671, 173);
            this.dgvPassengers.TabIndex = 2;
            // 
            // btnEditPassenger
            // 
            this.btnEditPassenger.Location = new System.Drawing.Point(616, 346);
            this.btnEditPassenger.Name = "btnEditPassenger";
            this.btnEditPassenger.Size = new System.Drawing.Size(115, 48);
            this.btnEditPassenger.TabIndex = 3;
            this.btnEditPassenger.Text = "Edit Selected";
            this.btnEditPassenger.UseVisualStyleBackColor = true;
            // 
            // PassengerMgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 422);
            this.Controls.Add(this.btnEditPassenger);
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnDeletePassenger);
            this.Name = "PassengerMgmtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengerMgmtForm";
            this.Load += new System.EventHandler(this.PassengerMgmtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePassenger;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.Button btnEditPassenger;
    }
}