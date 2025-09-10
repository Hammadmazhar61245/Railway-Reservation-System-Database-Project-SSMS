namespace RailwayReservationSystem
{
    partial class BookingMgmtForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(288, 66);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(164, 16);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "All Bookings Management";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(48, 115);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.Size = new System.Drawing.Size(674, 201);
            this.dgvBookings.TabIndex = 2;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(454, 361);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(128, 43);
            this.btnDeleteBooking.TabIndex = 3;
            this.btnDeleteBooking.Text = "Deleted Selected";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Location = new System.Drawing.Point(604, 361);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(118, 43);
            this.btnEditBooking.TabIndex = 4;
            this.btnEditBooking.Text = "Edit Selected";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            // 
            // BookingMgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 425);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.lblHeading);
            this.Name = "BookingMgmtForm";
            this.Text = "BookingMgmtForm";
            this.Load += new System.EventHandler(this.BookingMgmtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnEditBooking;
    }
}