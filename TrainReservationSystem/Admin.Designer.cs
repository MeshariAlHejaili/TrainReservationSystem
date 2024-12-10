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
            passengerTrainDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)passengerTrainDataGrid).BeginInit();
            SuspendLayout();
            // 
            // passengerTrainDataGrid
            // 
            passengerTrainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passengerTrainDataGrid.Dock = DockStyle.Fill;
            passengerTrainDataGrid.Location = new Point(0, 0);
            passengerTrainDataGrid.MultiSelect = false;
            passengerTrainDataGrid.Name = "passengerTrainDataGrid";
            passengerTrainDataGrid.ReadOnly = true;
            passengerTrainDataGrid.RowHeadersWidth = 51;
            passengerTrainDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            passengerTrainDataGrid.Size = new Size(800, 450);
            passengerTrainDataGrid.TabIndex = 3;
            passengerTrainDataGrid.CellContentClick += passengerTrainDataGrid_CellContentClick;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passengerTrainDataGrid);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)passengerTrainDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView passengerTrainDataGrid;
    }
}