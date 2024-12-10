namespace TrainReservationSystem
{
    partial class Admin
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
            btnAddReservation = new Button();
            btnCancelReservation = new Button();
            buttonbtnAssignStaff3 = new Button();
            passengerTrainDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)passengerTrainDataGrid).BeginInit();
            SuspendLayout();
            // 
            // btnAddReservation
            // 
            btnAddReservation.Location = new Point(12, 12);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(117, 23);
            btnAddReservation.TabIndex = 0;
            btnAddReservation.Text = "Add reservation";
            btnAddReservation.UseVisualStyleBackColor = true;
            btnAddReservation.Click += btnAddReservation_Click;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new Point(135, 12);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(137, 23);
            btnCancelReservation.TabIndex = 1;
            btnCancelReservation.Text = "Cancel reservation";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // buttonbtnAssignStaff3
            // 
            buttonbtnAssignStaff3.Location = new Point(278, 12);
            buttonbtnAssignStaff3.Name = "buttonbtnAssignStaff3";
            buttonbtnAssignStaff3.Size = new Size(145, 23);
            buttonbtnAssignStaff3.TabIndex = 2;
            buttonbtnAssignStaff3.Text = "Assign Staff";
            buttonbtnAssignStaff3.UseVisualStyleBackColor = true;
            buttonbtnAssignStaff3.Click += buttonbtnAssignStaff3_Click;
            // 
            // passengerTrainDataGrid
            // 
            passengerTrainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passengerTrainDataGrid.Location = new Point(0, 128);
            passengerTrainDataGrid.MultiSelect = false;
            passengerTrainDataGrid.Name = "passengerTrainDataGrid";
            passengerTrainDataGrid.ReadOnly = true;
            passengerTrainDataGrid.RowHeadersWidth = 51;
            passengerTrainDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            passengerTrainDataGrid.Size = new Size(800, 322);
            passengerTrainDataGrid.TabIndex = 3;
            passengerTrainDataGrid.CellContentClick += passengerTrainDataGrid_CellContentClick;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passengerTrainDataGrid);
            Controls.Add(buttonbtnAssignStaff3);
            Controls.Add(btnCancelReservation);
            Controls.Add(btnAddReservation);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)passengerTrainDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddReservation;
        private Button btnCancelReservation;
        private Button buttonbtnAssignStaff3;
        private DataGridView passengerTrainDataGrid;
    }
}