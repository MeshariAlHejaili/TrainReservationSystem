namespace TrainReservationSystem
{
    partial class trainDetailsForm
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
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            reservationsDataGrid = new DataGridView();
            btnAddReservation = new Button();
            btnCancelReservation = new Button();
            scheduleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)reservationsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // reservationsDataGrid
            // 
            reservationsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationsDataGrid.Dock = DockStyle.Bottom;
            reservationsDataGrid.Location = new Point(0, 127);
            reservationsDataGrid.MultiSelect = false;
            reservationsDataGrid.Name = "reservationsDataGrid";
            reservationsDataGrid.ReadOnly = true;
            reservationsDataGrid.RowHeadersWidth = 51;
            reservationsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationsDataGrid.Size = new Size(800, 323);
            reservationsDataGrid.TabIndex = 4;
            reservationsDataGrid.CellContentClick += passengerTrainDataGrid_CellContentClick;
            // 
            // btnAddReservation
            // 
            btnAddReservation.Location = new Point(0, 12);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(139, 23);
            btnAddReservation.TabIndex = 5;
            btnAddReservation.Text = "Add reservation";
            btnAddReservation.UseVisualStyleBackColor = true;
            btnAddReservation.Click += btnAddReservation_Click;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new Point(173, 12);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(135, 23);
            btnCancelReservation.TabIndex = 6;
            btnCancelReservation.Text = "Cancel reservation";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Location = new Point(7, 53);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(107, 15);
            scheduleLabel.TabIndex = 7;
            scheduleLabel.Text = "Train Schedule Info";
            // 
            // trainDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scheduleLabel);
            Controls.Add(btnCancelReservation);
            Controls.Add(btnAddReservation);
            Controls.Add(reservationsDataGrid);
            Name = "trainDetailsForm";
            Text = "trainDetailsForm";
            Load += trainDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)reservationsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private DataGridView reservationsDataGrid;
        private Button btnAddReservation;
        private Button btnCancelReservation;
        private Label scheduleLabel;
    }
}