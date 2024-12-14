namespace TrainReservationSystem
{
    partial class ReportsForm
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
            groupBoxActiveTrains = new GroupBox();
            dataGridViewActiveTrains = new DataGridView();
            lblActiveTrainsTitle = new Label();
            groupBoxStations = new GroupBox();
            dataGridViewStations = new DataGridView();
            lblStationsTitle = new Label();
            groupBoxLoadFactor = new GroupBox();
            dataGridViewLoadFactor = new DataGridView();
            lblLoadFactorTitle = new Label();
            panel1 = new Panel();
            Dashbord = new Button();
            Logout = new Button();
            groupBoxActiveTrains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveTrains).BeginInit();
            groupBoxStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStations).BeginInit();
            groupBoxLoadFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadFactor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxActiveTrains
            // 
            groupBoxActiveTrains.BackColor = SystemColors.ActiveCaption;
            groupBoxActiveTrains.Controls.Add(dataGridViewActiveTrains);
            groupBoxActiveTrains.Controls.Add(lblActiveTrainsTitle);
            groupBoxActiveTrains.Font = new Font("Lucida Sans", 9F, FontStyle.Bold);
            groupBoxActiveTrains.Location = new Point(3, 356);
            groupBoxActiveTrains.Name = "groupBoxActiveTrains";
            groupBoxActiveTrains.Size = new Size(799, 108);
            groupBoxActiveTrains.TabIndex = 7;
            groupBoxActiveTrains.TabStop = false;
            groupBoxActiveTrains.Text = "Active Trains";
            groupBoxActiveTrains.Enter += groupBoxActiveTrains_Enter;
            // 
            // dataGridViewActiveTrains
            // 
            dataGridViewActiveTrains.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewActiveTrains.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewActiveTrains.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActiveTrains.Dock = DockStyle.Fill;
            dataGridViewActiveTrains.Location = new Point(3, 18);
            dataGridViewActiveTrains.Name = "dataGridViewActiveTrains";
            dataGridViewActiveTrains.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewActiveTrains.Size = new Size(793, 87);
            dataGridViewActiveTrains.TabIndex = 10;
            // 
            // lblActiveTrainsTitle
            // 
            lblActiveTrainsTitle.AutoSize = true;
            lblActiveTrainsTitle.Location = new Point(9, 2);
            lblActiveTrainsTitle.Name = "lblActiveTrainsTitle";
            lblActiveTrainsTitle.Size = new Size(157, 13);
            lblActiveTrainsTitle.TabIndex = 9;
            lblActiveTrainsTitle.Text = "Currently Active Trains";
            // 
            // groupBoxStations
            // 
            groupBoxStations.BackColor = SystemColors.ActiveCaption;
            groupBoxStations.Controls.Add(dataGridViewStations);
            groupBoxStations.Controls.Add(lblStationsTitle);
            groupBoxStations.Font = new Font("Lucida Sans", 9F, FontStyle.Bold);
            groupBoxStations.Location = new Point(0, 53);
            groupBoxStations.Name = "groupBoxStations";
            groupBoxStations.Size = new Size(799, 151);
            groupBoxStations.TabIndex = 8;
            groupBoxStations.TabStop = false;
            groupBoxStations.Text = "Stations";
            // 
            // dataGridViewStations
            // 
            dataGridViewStations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStations.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewStations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStations.Dock = DockStyle.Fill;
            dataGridViewStations.Location = new Point(3, 18);
            dataGridViewStations.Name = "dataGridViewStations";
            dataGridViewStations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStations.Size = new Size(793, 130);
            dataGridViewStations.TabIndex = 11;
            // 
            // lblStationsTitle
            // 
            lblStationsTitle.AutoSize = true;
            lblStationsTitle.Location = new Point(0, 0);
            lblStationsTitle.Name = "lblStationsTitle";
            lblStationsTitle.Size = new Size(212, 13);
            lblStationsTitle.TabIndex = 10;
            lblStationsTitle.Text = "Stations for the Selected Train";
            // 
            // groupBoxLoadFactor
            // 
            groupBoxLoadFactor.BackColor = SystemColors.ActiveCaption;
            groupBoxLoadFactor.Controls.Add(dataGridViewLoadFactor);
            groupBoxLoadFactor.Controls.Add(lblLoadFactorTitle);
            groupBoxLoadFactor.Font = new Font("Lucida Sans", 9F, FontStyle.Bold);
            groupBoxLoadFactor.Location = new Point(3, 210);
            groupBoxLoadFactor.Name = "groupBoxLoadFactor";
            groupBoxLoadFactor.Size = new Size(796, 140);
            groupBoxLoadFactor.TabIndex = 8;
            groupBoxLoadFactor.TabStop = false;
            groupBoxLoadFactor.Text = "Load Factor";
            // 
            // dataGridViewLoadFactor
            // 
            dataGridViewLoadFactor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadFactor.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewLoadFactor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadFactor.Dock = DockStyle.Fill;
            dataGridViewLoadFactor.Location = new Point(3, 18);
            dataGridViewLoadFactor.Name = "dataGridViewLoadFactor";
            dataGridViewLoadFactor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLoadFactor.Size = new Size(790, 119);
            dataGridViewLoadFactor.TabIndex = 12;
            // 
            // lblLoadFactorTitle
            // 
            lblLoadFactorTitle.AutoSize = true;
            lblLoadFactorTitle.Location = new Point(6, -1);
            lblLoadFactorTitle.Name = "lblLoadFactorTitle";
            lblLoadFactorTitle.Size = new Size(169, 13);
            lblLoadFactorTitle.TabIndex = 11;
            lblLoadFactorTitle.Text = "Train Load Factor Report";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Dashbord);
            panel1.Controls.Add(Logout);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 34);
            panel1.TabIndex = 18;
            // 
            // Dashbord
            // 
            Dashbord.Location = new Point(0, 0);
            Dashbord.Name = "Dashbord";
            Dashbord.Size = new Size(103, 34);
            Dashbord.TabIndex = 9;
            Dashbord.Text = "Dash bord";
            Dashbord.UseVisualStyleBackColor = true;
            Dashbord.Click += Dashbord_Click;
            // 
            // Logout
            // 
            Logout.Location = new Point(697, 0);
            Logout.Name = "Logout";
            Logout.Size = new Size(103, 34);
            Logout.TabIndex = 8;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(panel1);
            Controls.Add(groupBoxStations);
            Controls.Add(groupBoxLoadFactor);
            Controls.Add(groupBoxActiveTrains);
            Name = "ReportsForm";
            Text = "Train Reservation System - Reports";
            groupBoxActiveTrains.ResumeLayout(false);
            groupBoxActiveTrains.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveTrains).EndInit();
            groupBoxStations.ResumeLayout(false);
            groupBoxStations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStations).EndInit();
            groupBoxLoadFactor.ResumeLayout(false);
            groupBoxLoadFactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadFactor).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxActiveTrains;
        private GroupBox groupBoxStations;
        private GroupBox groupBoxLoadFactor;
        private Label lblActiveTrainsTitle;
        private Label lblStationsTitle;
        private Label lblLoadFactorTitle;
        private DataGridView dataGridViewActiveTrains;
        private DataGridView dataGridViewStations;
        private DataGridView dataGridViewLoadFactor;
        private Panel panel1;
        private Button Dashbord;
        private Button Logout;
    }
}