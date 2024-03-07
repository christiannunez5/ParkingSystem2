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
    public partial class Receipt : Form
    {
        public Receipt(ParkingSystem car)
        {
            InitializeComponent();
            plateNumberData.Text = car.PlateNumber;
            vTypeData.Text = car.VehicleType;
            brandData.Text = car.Brand;
            flagdownData.Text = car.FlagDown.ToString();
            parkinData.Text = car.ParkIn.ToString();
            parkoutData.Text = car.ParkOut.ToString();
            durationData.Text = $"{car.Duration.Hours} hour/s, {car.Duration.Minutes} min/s, and {car.Duration.Seconds} sec/s";
            feeData.Text = car.ParkingFee.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
