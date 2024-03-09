using System.Collections;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
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
    }
}
