namespace ParkingSystemGUI
{
    partial class LoginForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            loginButton = new Button();
            panel3 = new Panel();
            passwordInput = new TextBox();
            panel2 = new Panel();
            usernameInput = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(470, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 392);
            panel1.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(32, 32, 66);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(63, 274);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(370, 64);
            loginButton.TabIndex = 2;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(passwordInput);
            panel3.Location = new Point(63, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 64);
            panel3.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.BackColor = Color.FromArgb(224, 224, 224);
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(15, 20);
            passwordInput.Name = "passwordInput";
            passwordInput.PlaceholderText = "password";
            passwordInput.Size = new Size(335, 22);
            passwordInput.TabIndex = 1;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(usernameInput);
            panel2.Location = new Point(63, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 64);
            panel2.TabIndex = 0;
            // 
            // usernameInput
            // 
            usernameInput.BackColor = Color.FromArgb(224, 224, 224);
            usernameInput.BorderStyle = BorderStyle.None;
            usernameInput.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameInput.Location = new Point(15, 20);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "username";
            usernameInput.Size = new Size(335, 22);
            usernameInput.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(102, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1190, 723);
            button1.Name = "button1";
            button1.Size = new Size(225, 57);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 66);
            ClientSize = new Size(1437, 807);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button loginButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        
        public Button GetLoginButton()
        {
            return loginButton;
        }

        public TextBox GetUsernameInput()
        {
            return usernameInput;
        }

        public TextBox GetPasswordInput()
        {
            return passwordInput;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private Button button1;
    }
}