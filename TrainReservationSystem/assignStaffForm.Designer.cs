namespace TrainReservationSystem
{
    partial class AssignStaffForm
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
            staffDataGrid = new DataGridView();
            btnAssignStaff = new Button();
            panel1 = new Panel();
            Dashbord = new Button();
            Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)staffDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // staffDataGrid
            // 
            staffDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            staffDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffDataGrid.Location = new Point(2, 131);
            staffDataGrid.MultiSelect = false;
            staffDataGrid.Name = "staffDataGrid";
            staffDataGrid.RowHeadersVisible = false;
            staffDataGrid.RowHeadersWidth = 51;
            staffDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGrid.Size = new Size(800, 323);
            staffDataGrid.TabIndex = 5;
            // 
            // btnAssignStaff
            // 
            btnAssignStaff.Location = new Point(307, 0);
            btnAssignStaff.Name = "btnAssignStaff";
            btnAssignStaff.Size = new Size(136, 34);
            btnAssignStaff.TabIndex = 6;
            btnAssignStaff.Text = "Assign Staff";
            btnAssignStaff.UseVisualStyleBackColor = true;
            btnAssignStaff.Click += btnAssignStaff_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Dashbord);
            panel1.Controls.Add(btnAssignStaff);
            panel1.Controls.Add(Logout);
            panel1.Location = new Point(2, 0);
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
            // AssignStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(staffDataGrid);
            Name = "AssignStaffForm";
            Text = "AssignStaffForm";
            ((System.ComponentModel.ISupportInitialize)staffDataGrid).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView staffDataGrid;
        private Button btnAssignStaff;
        private Panel panel1;
        private Button Dashbord;
        private Button Logout;
    }
}