
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
            emailFiled = new TextBox();
            passwordFiled = new TextBox();
            loginBtn = new Button();
            emailLabel = new Label();
            passwordLabel = new Label();
            loginPageLabel = new Label();
            imageList1 = new ImageList(components);
            loginPageImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginPageImage).BeginInit();
            SuspendLayout();
            // 
            // emailFiled
            // 
            emailFiled.Location = new Point(398, 243);
            emailFiled.Name = "emailFiled";
            emailFiled.Size = new Size(322, 27);
            emailFiled.TabIndex = 0;
            // 
            // passwordFiled
            // 
            passwordFiled.Location = new Point(398, 301);
            passwordFiled.Name = "passwordFiled";
            passwordFiled.PasswordChar = '*';
            passwordFiled.Size = new Size(322, 27);
            passwordFiled.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 12F);
            loginBtn.Location = new Point(498, 365);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(110, 61);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            emailLabel.Location = new Point(328, 245);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(64, 25);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            passwordLabel.Location = new Point(294, 304);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(102, 25);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // loginPageLabel
            // 
            loginPageLabel.AutoSize = true;
            loginPageLabel.BackColor = Color.Transparent;
            loginPageLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            loginPageLabel.Location = new Point(249, 116);
            loginPageLabel.Name = "loginPageLabel";
            loginPageLabel.Size = new Size(566, 67);
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
            loginPageImage.Name = "loginPageImage";
            loginPageImage.Size = new Size(1037, 635);
            loginPageImage.SizeMode = PictureBoxSizeMode.CenterImage;
            loginPageImage.TabIndex = 8;
            loginPageImage.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 635);
            Controls.Add(loginPageLabel);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(loginBtn);
            Controls.Add(passwordFiled);
            Controls.Add(emailFiled);
            Controls.Add(loginPageImage);
            Name = "LoginPage";
            Text = "EasyTrains-Login";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)loginPageImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox emailFiled;
        private TextBox passwordFiled;
        private Button loginBtn;
        private Label emailLabel;
        private Label passwordLabel;
        private Label loginPageLabel;
        private ImageList imageList1;
        private PictureBox loginPageImage;
    }
}
