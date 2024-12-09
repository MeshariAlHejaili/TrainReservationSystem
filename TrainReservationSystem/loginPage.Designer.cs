
namespace TrainReservationSystem
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            usernameField = new TextBox();
            passwordField = new TextBox();
            loginBtn = new Button();
            registerBtn = new Button();
            usernameLabel = new Label();
            passwordLabel = new Label();
            label1 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameField
            // 
            usernameField.Location = new Point(398, 214);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(322, 27);
            usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(398, 274);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(322, 27);
            passwordField.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 12F);
            loginBtn.Location = new Point(414, 325);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(110, 62);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += this.loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Segoe UI", 12F);
            registerBtn.Location = new Point(595, 325);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(110, 62);
            registerBtn.TabIndex = 3;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 11F);
            usernameLabel.Location = new Point(287, 216);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(101, 25);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 11F);
            passwordLabel.Location = new Point(293, 276);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(95, 25);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(250, 79);
            label1.Name = "label1";
            label1.Size = new Size(529, 69);
            label1.TabIndex = 6;
            label1.Text = "Welcome to EasyTrains";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "trainImage.jpeg");
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.train;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1037, 635);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 635);
            Controls.Add(label1);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(pictureBox1);
            Name = "LoginPage";
            Text = "EasyTrains";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox usernameField;
        private TextBox passwordField;
        private Button loginBtn;
        private Button registerBtn;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}
