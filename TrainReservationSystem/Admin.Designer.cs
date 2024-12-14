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
            btnViewAssignedStaff = new Button();
            btnReservation = new Button();
            passengerMenu = new MenuStrip();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            btnGenerateReports = new Button();
            btnAssignStaff = new Button();
            panel1 = new Panel();
            showAllBtn = new Button();
            btnSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            cmbDestinationStation = new ComboBox();
            cmbDepartureStation = new ComboBox();
            label1 = new Label();
            dtpSearchDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)passengerTrainDataGrid).BeginInit();
            passengerMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passengerTrainDataGrid
            // 
            passengerTrainDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            passengerTrainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passengerTrainDataGrid.Dock = DockStyle.Bottom;
            passengerTrainDataGrid.Location = new Point(0, 153);
            passengerTrainDataGrid.Name = "passengerTrainDataGrid";
            passengerTrainDataGrid.Size = new Size(1043, 427);
            passengerTrainDataGrid.TabIndex = 5;
            // 
            // btnViewAssignedStaff
            // 
            btnViewAssignedStaff.Location = new Point(420, 32);
            btnViewAssignedStaff.Name = "btnViewAssignedStaff";
            btnViewAssignedStaff.Size = new Size(136, 23);
            btnViewAssignedStaff.TabIndex = 10;
            btnViewAssignedStaff.Text = "View Assigned Staff";
            btnViewAssignedStaff.UseVisualStyleBackColor = true;
            btnViewAssignedStaff.Click += btnViewAssignedStaff_Click;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(625, 32);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(136, 23);
            btnReservation.TabIndex = 11;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // passengerMenu
            // 
            passengerMenu.BackColor = SystemColors.ActiveCaption;
            passengerMenu.Font = new Font("Segoe UI", 12F);
            passengerMenu.ImageScalingSize = new Size(20, 20);
            passengerMenu.Items.AddRange(new ToolStripItem[] { logOutToolStripMenuItem });
            passengerMenu.Location = new Point(0, 0);
            passengerMenu.Name = "passengerMenu";
            passengerMenu.Size = new Size(1043, 29);
            passengerMenu.TabIndex = 15;
            passengerMenu.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logOutToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(74, 25);
            logOutToolStripMenuItem.Text = "LogOut";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // btnGenerateReports
            // 
            btnGenerateReports.Location = new Point(210, 32);
            btnGenerateReports.Name = "btnGenerateReports";
            btnGenerateReports.Size = new Size(139, 23);
            btnGenerateReports.TabIndex = 12;
            btnGenerateReports.Text = "Generate Reports";
            btnGenerateReports.UseVisualStyleBackColor = true;
            btnGenerateReports.Click += btnGenerateReports_Click;
            // 
            // btnAssignStaff
            // 
            btnAssignStaff.Location = new Point(12, 32);
            btnAssignStaff.Name = "btnAssignStaff";
            btnAssignStaff.Size = new Size(139, 23);
            btnAssignStaff.TabIndex = 4;
            btnAssignStaff.Text = "Assign Staff";
            btnAssignStaff.UseVisualStyleBackColor = true;
            btnAssignStaff.Click += btnAssignStaff_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(showAllBtn);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbDestinationStation);
            panel1.Controls.Add(cmbDepartureStation);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpSearchDate);
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 86);
            panel1.TabIndex = 6;
            // 
            // showAllBtn
            // 
            showAllBtn.Location = new Point(946, 35);
            showAllBtn.Name = "showAllBtn";
            showAllBtn.Size = new Size(82, 29);
            showAllBtn.TabIndex = 7;
            showAllBtn.Text = "Show All";
            showAllBtn.UseVisualStyleBackColor = true;
            showAllBtn.Click += showAllBtn_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(846, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 33);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Destination:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 34);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Departure:";
            // 
            // cmbDestinationStation
            // 
            cmbDestinationStation.FormattingEnabled = true;
            cmbDestinationStation.Location = new Point(345, 31);
            cmbDestinationStation.Name = "cmbDestinationStation";
            cmbDestinationStation.Size = new Size(151, 23);
            cmbDestinationStation.TabIndex = 3;
            // 
            // cmbDepartureStation
            // 
            cmbDepartureStation.FormattingEnabled = true;
            cmbDepartureStation.Location = new Point(94, 30);
            cmbDepartureStation.Name = "cmbDepartureStation";
            cmbDepartureStation.Size = new Size(151, 23);
            cmbDepartureStation.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(511, 31);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 1;
            label1.Text = "Date:";
            // 
            // dtpSearchDate
            // 
            dtpSearchDate.Location = new Point(574, 34);
            dtpSearchDate.Name = "dtpSearchDate";
            dtpSearchDate.Size = new Size(247, 23);
            dtpSearchDate.TabIndex = 0;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 580);
            Controls.Add(panel1);
            Controls.Add(btnReservation);
            Controls.Add(btnGenerateReports);
            Controls.Add(btnViewAssignedStaff);
            Controls.Add(btnAssignStaff);
            Controls.Add(passengerMenu);
            Controls.Add(passengerTrainDataGrid);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)passengerTrainDataGrid).EndInit();
            passengerMenu.ResumeLayout(false);
            passengerMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView passengerTrainDataGrid;
        private Button btnViewAssignedStaff;
        private Button btnReservation;
        private MenuStrip passengerMenu;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Button btnGenerateReports;
        private Button btnAssignStaff;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button showAllBtn;
        private Button btnSearch;
        private Label label3;
        private Label label2;
        private ComboBox cmbDestinationStation;
        private ComboBox cmbDepartureStation;
        private Label label1;
        private DateTimePicker dtpSearchDate;
    }
}