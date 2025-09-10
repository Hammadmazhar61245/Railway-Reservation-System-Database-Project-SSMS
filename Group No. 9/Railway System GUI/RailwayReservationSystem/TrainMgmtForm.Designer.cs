namespace RailwayReservationSystem
{
    partial class TrainMgmtForm
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
            this.lblTrainName = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.dgvTrains = new System.Windows.Forms.DataGridView();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrains)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Location = new System.Drawing.Point(85, 49);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(78, 16);
            this.lblTrainName.TabIndex = 0;
            this.lblTrainName.Text = "Train Name";
            this.lblTrainName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(85, 97);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(94, 16);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source Station";
            // 
            // txtTrainName
            // 
            this.txtTrainName.Location = new System.Drawing.Point(225, 46);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(168, 22);
            this.txtTrainName.TabIndex = 2;
            // 
            // dgvTrains
            // 
            this.dgvTrains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrains.Location = new System.Drawing.Point(88, 236);
            this.dgvTrains.Name = "dgvTrains";
            this.dgvTrains.RowHeadersWidth = 51;
            this.dgvTrains.RowTemplate.Height = 24;
            this.dgvTrains.Size = new System.Drawing.Size(562, 150);
            this.dgvTrains.TabIndex = 3;
            this.dgvTrains.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrains_CellContentClick);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Location = new System.Drawing.Point(523, 46);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(127, 49);
            this.btnAddTrain.TabIndex = 4;
            this.btnAddTrain.Text = "Add Train";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(225, 145);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(168, 22);
            this.txtDestination.TabIndex = 5;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(225, 94);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(168, 22);
            this.txtSource.TabIndex = 6;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(85, 145);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(118, 16);
            this.lblDestination.TabIndex = 7;
            this.lblDestination.Text = "Destination Station";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(523, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 52);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(523, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 52);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TrainMgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 414);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnAddTrain);
            this.Controls.Add(this.dgvTrains);
            this.Controls.Add(this.txtTrainName);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblTrainName);
            this.Name = "TrainMgmtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainMgmtForm";
            this.Load += new System.EventHandler(this.TrainMgmtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrainName;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.DataGridView dgvTrains;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}