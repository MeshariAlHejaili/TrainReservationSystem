namespace TrainReservationSystem
{
    partial class paymentForm
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
            numericUpDown1 = new NumericUpDown();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            passengerReserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            passengerReserMenu.Size = new Size(1025, 36);
            passengerReserMenu.TabIndex = 1;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(279, 24);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(172, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 68);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 3;
            label1.Text = "Number of Tickets";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 104);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1025, 331);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 135);
            panel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 74);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 7;
            label5.Text = "CVV:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(643, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(113, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 78);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 3;
            label3.Text = "Card Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 41);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Name on Card:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(643, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(863, 59);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 8;
            button1.Text = "Pay Now";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 37);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 5;
            label4.Text = "Exp Date:";
            // 
            // paymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 570);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(passengerReserMenu);
            Name = "paymentForm";
            Text = "Easy Train-Payment";
            passengerReserMenu.ResumeLayout(false);
            passengerReserMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip passengerReserMenu;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private NumericUpDown numericUpDown1;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
    }
}