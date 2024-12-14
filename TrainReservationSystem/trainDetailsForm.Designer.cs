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
            btnUpdateReservation = new Button();
            panel1 = new Panel();
            Dashbord = new Button();
            Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)reservationsDataGrid).BeginInit();
            panel1.SuspendLayout();
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
            reservationsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reservationsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationsDataGrid.Location = new Point(0, 127);
            reservationsDataGrid.MultiSelect = false;
            reservationsDataGrid.Name = "reservationsDataGrid";
            reservationsDataGrid.RowHeadersVisible = false;
            reservationsDataGrid.RowHeadersWidth = 51;
            reservationsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationsDataGrid.Size = new Size(800, 323);
            reservationsDataGrid.TabIndex = 4;
            reservationsDataGrid.CellContentClick += passengerTrainDataGrid_CellContentClick;
            // 
            // btnAddReservation
            // 
            btnAddReservation.Location = new Point(168, 0);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(139, 34);
            btnAddReservation.TabIndex = 5;
            btnAddReservation.Text = "Add reservation";
            btnAddReservation.UseVisualStyleBackColor = true;
            btnAddReservation.Click += btnAddReservation_Click;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new Point(325, 0);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(135, 34);
            btnCancelReservation.TabIndex = 6;
            btnCancelReservation.Text = "Cancel reservation";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // btnUpdateReservation
            // 
            btnUpdateReservation.Location = new Point(480, 0);
            btnUpdateReservation.Name = "btnUpdateReservation";
            btnUpdateReservation.Size = new Size(154, 34);
            btnUpdateReservation.TabIndex = 7;
            btnUpdateReservation.Text = "Update reservation";
            btnUpdateReservation.UseVisualStyleBackColor = true;
            btnUpdateReservation.Click += btnUpdateReservation_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Dashbord);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(btnUpdateReservation);
            panel1.Controls.Add(btnAddReservation);
            panel1.Controls.Add(btnCancelReservation);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 34);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
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
            // trainDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(reservationsDataGrid);
            Name = "trainDetailsForm";
            Text = "trainDetailsForm";
            Load += trainDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)reservationsDataGrid).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private DataGridView reservationsDataGrid;
        private Button btnAddReservation;
        private Button btnCancelReservation;
        private Button btnUpdateReservation;
        private Panel panel1;
        private Button Dashbord;
        private Button Logout;
    }
}