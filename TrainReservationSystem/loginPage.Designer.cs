
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
            loginPageLabel = new Label();
            imageList1 = new ImageList(components);
            loginPageImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginPageImage).BeginInit();
            SuspendLayout();
            // 
            // usernameField
            // 
            usernameField.Location = new Point(348, 182);
            usernameField.Margin = new Padding(3, 2, 3, 2);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(282, 23);
            usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(348, 226);
            passwordField.Margin = new Padding(3, 2, 3, 2);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(282, 23);
            passwordField.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 12F);
            loginBtn.Location = new Point(359, 274);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(96, 46);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Segoe UI", 12F);
            registerBtn.Location = new Point(517, 274);
            registerBtn.Margin = new Padding(3, 2, 3, 2);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(96, 46);
            registerBtn.TabIndex = 3;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            usernameLabel.Location = new Point(254, 183);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(84, 20);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            passwordLabel.Location = new Point(257, 228);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 20);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // loginPageLabel
            // 
            loginPageLabel.AutoSize = true;
            loginPageLabel.BackColor = Color.Transparent;
            loginPageLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            loginPageLabel.Location = new Point(219, 59);
            loginPageLabel.Name = "loginPageLabel";
            loginPageLabel.Size = new Size(453, 54);
            loginPageLabel.TabIndex = 6;
            loginPageLabel.Text = "Welcome to EasyTrains";
            loginPageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "trainImage.jpeg");
            // 
            // loginPageImage
            // 
            loginPageImage.Dock = DockStyle.Fill;
            loginPageImage.Image = Properties.Resources.train;
            loginPageImage.Location = new Point(0, 0);
            loginPageImage.Margin = new Padding(3, 2, 3, 2);
            loginPageImage.Name = "loginPageImage";
            loginPageImage.Size = new Size(907, 476);
            loginPageImage.SizeMode = PictureBoxSizeMode.CenterImage;
            loginPageImage.TabIndex = 8;
            loginPageImage.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 476);
            Controls.Add(loginPageLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(loginPageImage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginPage";
            Text = "EasyTrains-Login";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)loginPageImage).EndInit();
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
        private Label loginPageLabel;
        private ImageList imageList1;
        private PictureBox loginPageImage;
    }
}
