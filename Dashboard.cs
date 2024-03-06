using System.Collections;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class Dashboard : Form
    {
        Color primary = Color.FromArgb(32, 32, 66);
        Color secondary = Color.FromArgb(58, 59, 89);
        private ArrayList communities = new ArrayList();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dashboardUserControl1.Visible = true;
            parkUserControl1.Visible = false;
        }
        

        /*
        public void RenderCommunities()
        {
            communitiesPanel.Controls.Clear();

            for (int i = 0; i < communities.Count; i++)
            {
                int communitiesPanelWidth = communitiesPanel.Size.Width;
                Label label = new Label();
                label.BackColor = Color.White;
                label.Width = communitiesPanel.Width;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Height = 20;
                label.Text = communities[i].ToString();
                communitiesPanel.Controls.Add(label);
            }
        }

        public void addCommunity(String community)
        {
            communities.Add(community);
            RenderCommunities();
        }
        */


        private void homeBox_Click(object sender, EventArgs e)
        {
            dashboardUserControl1.Visible = true;
            parkUserControl1.Visible = false;
            homeBox.BackColor = secondary;
            parkBox.BackColor = primary;
        }

        private void parkBox_Click(object sender, EventArgs e)
        {
            parkUserControl1.Visible = true;
            dashboardUserControl1.Visible = false;
            parkBox.BackColor = secondary;
            homeBox.BackColor = primary;
        }

    }
}
