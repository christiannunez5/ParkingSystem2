using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class Dashboard
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
            historyBox = new PictureBox();
            logOutBox = new PictureBox();
            parkBox = new PictureBox();
            homeBox = new PictureBox();
            logoBox1 = new PictureBox();
            dashboardUserControl1 = new DashboardUserControl();
            parkUserControl1 = new ParkUserControl();
            parkedHistoryUserControl1 = new ParkedHistoryUserControl();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logOutBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parkBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(32, 32, 66);
            sidebarPanel.Controls.Add(historyBox);
            sidebarPanel.Controls.Add(logOutBox);
            sidebarPanel.Controls.Add(parkBox);
            sidebarPanel.Controls.Add(homeBox);
            sidebarPanel.Controls.Add(logoBox1);
            sidebarPanel.Location = new Point(-1, 0);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(78, 701);
            sidebarPanel.TabIndex = 2;
            sidebarPanel.Paint += sidebarPanel_Paint;
            // 
            // historyBox
            // 
            historyBox.BorderStyle = BorderStyle.FixedSingle;
            historyBox.Cursor = Cursors.Hand;
            historyBox.Image = (Image)resources.GetObject("historyBox.Image");
            historyBox.Location = new Point(0, 233);
            historyBox.Margin = new Padding(3, 4, 3, 4);
            historyBox.Name = "historyBox";
            historyBox.Padding = new Padding(25);
            historyBox.Size = new Size(79, 80);
            historyBox.SizeMode = PictureBoxSizeMode.StretchImage;
            historyBox.TabIndex = 4;
            historyBox.TabStop = false;
            // 
            // logOutBox
            // 
            logOutBox.BorderStyle = BorderStyle.FixedSingle;
            logOutBox.Cursor = Cursors.Hand;
            logOutBox.Image = (Image)resources.GetObject("logOutBox.Image");
            logOutBox.Location = new Point(-1, 621);
            logOutBox.Margin = new Padding(3, 4, 3, 4);
            logOutBox.Name = "logOutBox";
            logOutBox.Padding = new Padding(25);
            logOutBox.Size = new Size(79, 80);
            logOutBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logOutBox.TabIndex = 3;
            logOutBox.TabStop = false;
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
            // 
            // logoBox1
            // 
            logoBox1.Image = (Image)resources.GetObject("logoBox1.Image");
            logoBox1.Location = new Point(3, -1);
            logoBox1.Margin = new Padding(3, 4, 3, 4);
            logoBox1.Name = "logoBox1";
            logoBox1.Size = new Size(76, 81);
            logoBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox1.TabIndex = 0;
            logoBox1.TabStop = false;
            // 
            // dashboardUserControl1
            // 
            dashboardUserControl1.BackColor = Color.White;
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
            parkUserControl1.Load += ParkUserControl_Load;
            // 
            // parkedHistoryUserControl1
            // 
            parkedHistoryUserControl1.BackColor = Color.White;
            parkedHistoryUserControl1.Location = new Point(76, 0);
            parkedHistoryUserControl1.Name = "parkedHistoryUserControl1";
            parkedHistoryUserControl1.Padding = new Padding(5);
            parkedHistoryUserControl1.Size = new Size(1412, 876);
            parkedHistoryUserControl1.TabIndex = 5;
            parkedHistoryUserControl1.Load += parkedHistoryUserControl1_Load;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 699);
            Controls.Add(parkedHistoryUserControl1);
            Controls.Add(parkUserControl1);
            Controls.Add(dashboardUserControl1);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)historyBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logOutBox).EndInit();
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
        private PictureBox logOutBox;
        private DashboardUserControl dashboardUserControl1;

        public PictureBox GetHomePictureBox()
        {
            return homeBox;
        }

        public PictureBox GetParkBoxPictureBox()
        {
            return parkBox;
        }

        public PictureBox GetHistoryBox()
        {
            return historyBox;
        }

        public ParkUserControl GetParkUserControl()
        {
            return parkUserControl1;
        }

        public DashboardUserControl GetDashboardUserControl()
        {
            return dashboardUserControl1;
        }

        public ParkedHistoryUserControl GetParkedHistoryUserControl()
        {
            return parkedHistoryUserControl1;
        }

        public PictureBox GetLogOutBox()
        {
            return logOutBox;
        }

        private ParkUserControl parkUserControl1;
        private PictureBox historyBox;
        private ParkedHistoryUserControl parkedHistoryUserControl1;
    }
}
