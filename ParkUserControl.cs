using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class ParkUserControl : UserControl
    {
        public ParkUserControl()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (panel1.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel1.ClientSize.Width - thickness,
                                                              panel1.ClientSize.Height - thickness));
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parkedListPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void searchPlateButton_Click(object sender, EventArgs e)
        {

        }


        private void parkInDetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchPlateNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void zeroParkPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void closeViewDetail_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void addParkButton_Click(object sender, EventArgs e)
        {

        }
    }
}
