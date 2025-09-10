namespace RailwayReservationSystem
{
    partial class FeedbackForm
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
            this.lblBookingID = new System.Windows.Forms.Label();
            this.cmbBookingID = new System.Windows.Forms.ComboBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.BackColor = System.Drawing.SystemColors.Control;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblBookingID.Location = new System.Drawing.Point(91, 75);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(98, 16);
            this.lblBookingID.TabIndex = 0;
            this.lblBookingID.Text = "Select Booking";
            // 
            // cmbBookingID
            // 
            this.cmbBookingID.FormattingEnabled = true;
            this.cmbBookingID.Location = new System.Drawing.Point(260, 75);
            this.cmbBookingID.Name = "cmbBookingID";
            this.cmbBookingID.Size = new System.Drawing.Size(161, 24);
            this.cmbBookingID.TabIndex = 1;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(260, 152);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(161, 22);
            this.txtComments.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(141, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Feedback";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.SystemColors.Control;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblComment.Location = new System.Drawing.Point(91, 152);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(100, 16);
            this.lblComment.TabIndex = 4;
            this.lblComment.Text = "Your Feedback";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.BackColor = System.Drawing.SystemColors.Control;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblRating.Location = new System.Drawing.Point(91, 227);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(76, 16);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating (1–5)";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Lime;
            this.btnBack.Location = new System.Drawing.Point(293, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 46);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // nudRating
            // 
            this.nudRating.Location = new System.Drawing.Point(260, 224);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(161, 22);
            this.nudRating.TabIndex = 8;
            this.nudRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 419);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.cmbBookingID);
            this.Controls.Add(this.lblBookingID);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.ComboBox cmbBookingID;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown nudRating;
    }
}