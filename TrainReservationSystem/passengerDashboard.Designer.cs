namespace TrainReservationSystem
{
    partial class passengerDashboard
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
            passengerMenu = new MenuStrip();
            myResToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            passengerTrainTable = new TableLayoutPanel();
            passengerTrainDataGrid = new DataGridView();
            panel1 = new Panel();
            showAllBtn = new Button();
            btnSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            cmbDestinationStation = new ComboBox();
            cmbDepartureStation = new ComboBox();
            label1 = new Label();
            dtpTravelDate = new DateTimePicker();
            pageSetupDialog1 = new PageSetupDialog();
            passengerMenu.SuspendLayout();
            passengerTrainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passengerTrainDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passengerMenu
            // 
            passengerMenu.BackColor = SystemColors.ActiveCaption;
            passengerMenu.Font = new Font("Segoe UI", 12F);
            passengerMenu.ImageScalingSize = new Size(20, 20);
            passengerMenu.Items.AddRange(new ToolStripItem[] { myResToolStripMenuItem, logOutToolStripMenuItem });
            passengerMenu.Location = new Point(0, 0);
            passengerMenu.Name = "passengerMenu";
            passengerMenu.Size = new Size(1050, 29);
            passengerMenu.TabIndex = 0;
            passengerMenu.Text = "menuStrip1";
            // 
            // myResToolStripMenuItem
            // 
            myResToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            myResToolStripMenuItem.Name = "myResToolStripMenuItem";
            myResToolStripMenuItem.Size = new Size(137, 25);
            myResToolStripMenuItem.Text = "My Reservations";
            myResToolStripMenuItem.Click += myResToolStripMenuItem_Click;
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
            // passengerTrainTable
            // 
            passengerTrainTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passengerTrainTable.ColumnCount = 1;
            passengerTrainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            passengerTrainTable.Controls.Add(passengerTrainDataGrid, 0, 1);
            passengerTrainTable.Controls.Add(panel1, 0, 0);
            passengerTrainTable.Location = new Point(0, 36);
            passengerTrainTable.Name = "passengerTrainTable";
            passengerTrainTable.RowCount = 2;
            passengerTrainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            passengerTrainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            passengerTrainTable.Size = new Size(1050, 557);
            passengerTrainTable.TabIndex = 1;
            // 
            // passengerTrainDataGrid
            // 
            passengerTrainDataGrid.BackgroundColor = SystemColors.Control;
            passengerTrainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passengerTrainDataGrid.Dock = DockStyle.Top;
            passengerTrainDataGrid.Location = new Point(3, 95);
            passengerTrainDataGrid.MultiSelect = false;
            passengerTrainDataGrid.Name = "passengerTrainDataGrid";
            passengerTrainDataGrid.ReadOnly = true;
            passengerTrainDataGrid.RowHeadersWidth = 51;
            passengerTrainDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            passengerTrainDataGrid.Size = new Size(1044, 459);
            passengerTrainDataGrid.TabIndex = 0;
            passengerTrainDataGrid.CellContentDoubleClick += passengerTrainDataGrid_CellDoubleClick;
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
            panel1.Controls.Add(dtpTravelDate);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 86);
            panel1.TabIndex = 1;
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
            cmbDepartureStation.SelectedIndexChanged += cmbDepartureStation_SelectedIndexChanged;
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
            // dtpTravelDate
            // 
            dtpTravelDate.Location = new Point(574, 34);
            dtpTravelDate.Name = "dtpTravelDate";
            dtpTravelDate.Size = new Size(247, 23);
            dtpTravelDate.TabIndex = 0;
            // 
            // passengerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 593);
            Controls.Add(passengerTrainTable);
            Controls.Add(passengerMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = passengerMenu;
            Name = "passengerDashboard";
            Text = "Easy Trains-Passenger Dashboard";
            passengerMenu.ResumeLayout(false);
            passengerMenu.PerformLayout();
            passengerTrainTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)passengerTrainDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip passengerMenu;
        private ToolStripMenuItem myResToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private TableLayoutPanel passengerTrainTable;
        private DataGridView passengerTrainDataGrid;
        private Panel panel1;
        private Label label1;
        private DateTimePicker dtpTravelDate;
        private PageSetupDialog pageSetupDialog1;
        private ComboBox cmbDestinationStation;
        private ComboBox cmbDepartureStation;
        private Label label3;
        private Label label2;
        private Button btnSearch;
        private Button showAllBtn;
    }
}