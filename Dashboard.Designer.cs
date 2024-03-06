namespace ParkingSystemGUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            sidebarPanel = new Panel();
            pictureBox2 = new PictureBox();
            parkBox = new PictureBox();
            homeBox = new PictureBox();
            logoBox1 = new PictureBox();
            dashboardUserControl1 = new DashboardUserControl();
            parkUserControl1 = new ParkUserControl();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parkBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(32, 32, 66);
            sidebarPanel.Controls.Add(pictureBox2);
            sidebarPanel.Controls.Add(parkBox);
            sidebarPanel.Controls.Add(homeBox);
            sidebarPanel.Controls.Add(logoBox1);
            sidebarPanel.Location = new Point(-1, 0);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(78, 701);
            sidebarPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 621);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(25);
            pictureBox2.Size = new Size(79, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // parkBox
            // 
            parkBox.BorderStyle = BorderStyle.FixedSingle;
            parkBox.Cursor = Cursors.Hand;
            parkBox.Image = (Image)resources.GetObject("parkBox.Image");
            parkBox.Location = new Point(0, 155);
            parkBox.Margin = new Padding(3, 4, 3, 4);
            parkBox.Name = "parkBox";
            parkBox.Padding = new Padding(25);
            parkBox.Size = new Size(79, 80);
            parkBox.SizeMode = PictureBoxSizeMode.StretchImage;
            parkBox.TabIndex = 2;
            parkBox.TabStop = false;
            parkBox.Click += parkBox_Click;
            // 
            // homeBox
            // 
            homeBox.BackColor = Color.FromArgb(58, 59, 89);
            homeBox.BorderStyle = BorderStyle.FixedSingle;
            homeBox.Cursor = Cursors.Hand;
            homeBox.Image = (Image)resources.GetObject("homeBox.Image");
            homeBox.Location = new Point(0, 79);
            homeBox.Margin = new Padding(3, 4, 3, 4);
            homeBox.Name = "homeBox";
            homeBox.Padding = new Padding(25);
            homeBox.Size = new Size(79, 80);
            homeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            homeBox.TabIndex = 1;
            homeBox.TabStop = false;
            homeBox.Click += homeBox_Click;
            // 
            // logoBox1
            // 
            logoBox1.Image = (Image)resources.GetObject("logoBox1.Image");
            logoBox1.Location = new Point(3, -1);
            logoBox1.Margin = new Padding(3, 4, 3, 4);
            logoBox1.Name = "logoBox1";
            logoBox1.Padding = new Padding(25);
            logoBox1.Size = new Size(76, 81);
            logoBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox1.TabIndex = 0;
            logoBox1.TabStop = false;
            // 
            // dashboardUserControl1
            // 
            dashboardUserControl1.Location = new Point(77, -1);
            dashboardUserControl1.Name = "dashboardUserControl1";
            dashboardUserControl1.Size = new Size(1412, 876);
            dashboardUserControl1.TabIndex = 3;
            // 
            // parkUserControl1
            // 
            parkUserControl1.Location = new Point(77, 0);
            parkUserControl1.Name = "parkUserControl1";
            parkUserControl1.Size = new Size(1412, 876);
            parkUserControl1.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 699);
            Controls.Add(parkUserControl1);
            Controls.Add(dashboardUserControl1);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)parkBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private PictureBox parkBox;
        private PictureBox homeBox;
        private PictureBox logoBox1;
        private PictureBox pictureBox2;
        private DashboardUserControl dashboardUserControl1;

        public PictureBox GetHomePictureBox()
        {
            return homeBox;
        }

        public PictureBox GetParkBoxPictureBox()
        {
            return parkBox;
        }

        private ParkUserControl parkUserControl1;
    }
}
