using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ParkingSystemGUI
{
    public partial class AddCarForm : Form
    {

        public AddCarForm()
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void vTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vehicleType = vTypeComboBox.SelectedItem?.ToString();
            brandComboBox.Text = "";
            brandComboBox.Items.Clear();

            if (vehicleType != null)
            {
                switch (vehicleType)
                {
                    case "SUV":
                        brandComboBox.Items.Add("Kia");
                        brandComboBox.Items.Add("Mazda");
                        brandComboBox.Items.Add("Hyundai");
                        brandComboBox.Items.Add("Toyota");
                        brandComboBox.Items.Add("Chevrolet");
                        break;

                    case "Motorbike":
                        brandComboBox.Items.Add("Rusi");
                        brandComboBox.Items.Add("Yamaha");
                        brandComboBox.Items.Add("Kawasaki");
                        brandComboBox.Items.Add("Honda");
                        brandComboBox.Items.Add("Suzuki");
                        break;

                    case "Van":
                        brandComboBox.Items.Add("Mercedez-Benz");
                        brandComboBox.Items.Add("Toyota");
                        brandComboBox.Items.Add("Ford");
                        brandComboBox.Items.Add("Foton");
                        brandComboBox.Items.Add("Hyundai");
                        break;

                    case "Sedan":
                        brandComboBox.Items.Add("Hyundai");
                        brandComboBox.Items.Add("BMW");
                        brandComboBox.Items.Add("Honda");
                        brandComboBox.Items.Add("Volkswagen");
                        brandComboBox.Items.Add("Chevrolet");
                        break;
                }
            }
        }

        private void plateNumberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCarButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
