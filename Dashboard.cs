using System.Collections;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            logOutBox.MouseEnter += logoutBox_MouseEnter;
            logOutBox.MouseLeave += logoutBox_MouseLeave;
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dashboardUserControl1.Visible = true;
            parkedHistoryUserControl1.Visible = false;
            parkUserControl1.Visible = false;
        }

        private void ParkUserControl_Load(object sender, EventArgs e)
        {

        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parkedHistoryUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void logoutBox_MouseEnter(object sender, EventArgs e)
        {
            logOutBox.BackColor = Color.FromArgb(102, 0, 0);
        }

        private void logoutBox_MouseLeave(object sender, EventArgs e)
        {
            // Revert the changes when mouse leaves
            logOutBox.BackColor = Color.FromArgb(32, 32, 64);
        }
    }
}
