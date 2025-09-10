namespace RailwayReservationSystem
{
    partial class BookingForm
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
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.cmbTrain = new System.Windows.Forms.ComboBox();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.Location = new System.Drawing.Point(131, 88);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(38, 16);
            this.lblTrain.TabIndex = 0;
            this.lblTrain.Text = "Train";
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(131, 159);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(86, 16);
            this.lblSeatNumber.TabIndex = 1;
            this.lblSeatNumber.Text = "Seat Number";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(131, 217);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(99, 16);
            this.lblDepartureDate.TabIndex = 2;
            this.lblDepartureDate.Text = "Departure Date";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(131, 278);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(101, 16);
            this.lblDepartureTime.TabIndex = 3;
            this.lblDepartureTime.Text = "Departure Time";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(365, 153);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(229, 22);
            this.txtSeatNumber.TabIndex = 4;
            // 
            // cmbTrain
            // 
            this.cmbTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrain.FormattingEnabled = true;
            this.cmbTrain.Location = new System.Drawing.Point(365, 80);
            this.cmbTrain.Name = "cmbTrain";
            this.cmbTrain.Size = new System.Drawing.Size(229, 24);
            this.cmbTrain.TabIndex = 5;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(365, 217);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(229, 22);
            this.dtpDepartureDate.TabIndex = 6;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepartureTime.Location = new System.Drawing.Point(365, 278);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(229, 22);
            this.dtpDepartureTime.TabIndex = 7;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(253, 349);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(107, 43);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Book Now";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.cmbTrain);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.lblTrain);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.ComboBox cmbTrain;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.Button btnBook;
    }
}