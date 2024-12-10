namespace TrainReservationSystem
{
    partial class passengerReser
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
            passengerReserMenu = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            showReserBtn = new Button();
            dataGridView1 = new DataGridView();
            passengerReserMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // passengerReserMenu
            // 
            passengerReserMenu.BackColor = Color.FromArgb(0, 192, 192);
            passengerReserMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passengerReserMenu.ImageScalingSize = new Size(20, 20);
            passengerReserMenu.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, toolStripMenuItem1 });
            passengerReserMenu.Location = new Point(0, 0);
            passengerReserMenu.Name = "passengerReserMenu";
            passengerReserMenu.Size = new Size(1008, 36);
            passengerReserMenu.TabIndex = 0;
            passengerReserMenu.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(122, 32);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem1.BackColor = SystemColors.ButtonShadow;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(92, 32);
            toolStripMenuItem1.Text = "LogOut";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(showReserBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 70);
            panel1.TabIndex = 1;
            // 
            // showReserBtn
            // 
            showReserBtn.Dock = DockStyle.Left;
            showReserBtn.Location = new Point(0, 0);
            showReserBtn.Name = "showReserBtn";
            showReserBtn.Size = new Size(163, 70);
            showReserBtn.TabIndex = 0;
            showReserBtn.Text = "Refrech";
            showReserBtn.UseVisualStyleBackColor = true;
            showReserBtn.Click += showReserBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1008, 459);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // passengerReser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 565);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(passengerReserMenu);
            MainMenuStrip = passengerReserMenu;
            Name = "passengerReser";
            Text = "EasyTrains-My Reservations";
            passengerReserMenu.ResumeLayout(false);
            passengerReserMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip passengerReserMenu;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel1;
        private Button showReserBtn;
        private DataGridView dataGridView1;
    }
}