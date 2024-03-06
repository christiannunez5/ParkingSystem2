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
        private AddCarForm addCarForm;
        private Button addCarButton;
        private ParkingSystem parkedCars = new ParkingSystem();

        Color hover = Color.FromArgb(240, 237, 251);
        Color primary = Color.FromArgb(32, 32, 66);
        public ParkUserControl()
        {

            InitializeComponent();
            addCarForm = new AddCarForm();
            addCarButton = addCarForm.GetAddCarButton();
            addCarButton.Click += AddCarButton_Click;

        }

        private Label CreateLabel(ParkingSystem car)
        {
            Label label = new Label();
            label.Text = "Plate Number: " + car.PlateNumber;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Cascadia Mono Light", 12, FontStyle.Regular);
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Width = parkedListPanel.Width;
            label.Height = 50;
            label.Cursor = Cursors.Hand;
            label.AutoSize = false;

            label.MouseEnter += (sender, e) =>
            {
                Label hoverLabel = (Label)sender;
                hoverLabel.BackColor = Color.LightGray; // Set hover color
            };

            label.MouseLeave += (sender, e) =>
            {
                Label leaveLabel = (Label)sender;
                leaveLabel.BackColor = Color.White; // Reset background color
            };

            label.Click += (sender, e) =>
            {
         
                viewDetails(car);
            };

            return label;
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


        //ADDCARFORM REFERENCE
        private void addParkButton_Click(object sender, EventArgs e)
        {
            addCarForm.Visible = true;
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            string plateNumber = addCarForm.GetPlateNumber().Text;
            string vehicleType = addCarForm.GetVehicleType()?.SelectedItem?.ToString();
            string brand = addCarForm.GetBrand()?.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(plateNumber) || string.IsNullOrEmpty(vehicleType) || string.IsNullOrEmpty(brand))
            {
                MessageBox.Show("All fields must be filled.");
            }
            else
            {
                ParkingSystem car = new ParkingSystem(plateNumber, vehicleType, brand);
                parkedCars.AddCar(car);
                renderComponents(parkedCars.GetParkedCars());
                addCarForm.GetPlateNumber().Text = "";
                addCarForm.GetPlateNumber().PlaceholderText = "Plate Number...";
                addCarForm.GetVehicleType().Text = "Select Vehicle";
                addCarForm.GetBrand().Text = "Select Brand";
                addCarForm.Visible = false;


            }

        }

        public void renderComponents(List<ParkingSystem> listOfCars)
        {
            parkedListPanel.Controls.Clear();

            foreach (ParkingSystem car in listOfCars)
            {
                /*
                Label label = new Label();
                label.Text = "Plate Number: " + car.PlateNumber;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Cascadia Mono Light", 12, FontStyle.Regular);
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Width = parkedListPanel.Width;
                label.Height = 50;
                label.Cursor = Cursors.Hand;
                label.AutoSize = false;

                label.Click += (sender, e) =>
                {
                    Label clickedLabel = (Label)sender;
                    clickedLabel.BackColor = hover; // Set the clicked label's background color to gray

                    // Set the background color to white for other labels
                    foreach (Control control in parkedListPanel.Controls)
                    {
                        if (control is Label && control != clickedLabel)
                        {
                            ((Label)control).BackColor = Color.White;
                        }
                    }

                    viewDetails(car);
                    
                };
                */
                Label label = CreateLabel(car);
                parkedListPanel.Controls.Add(label);
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
            if (parkedListPanel.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              parkedListPanel.ClientSize.Width - thickness,
                                                              parkedListPanel.ClientSize.Height - thickness));
                }
            }
        }

        private void searchPlateButton_Click(object sender, EventArgs e)
        {

        }

        private void viewDetails(ParkingSystem car)
        {
            parkInDetailPanel.Controls.Clear();

            Label label1 = new Label();
            label1.Text = "PARK IN DETAILS";
            label1.Location = new Point(3,0);
            label1.Size = new Size(773, 146);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.ForeColor = Color.Black;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cascadia Mono Light", 36, FontStyle.Regular);

            Label plateLabel = new Label();
            plateLabel.Text = "Plate Number";
            plateLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            plateLabel.Size = new Size(217, 44);
            plateLabel.TextAlign = ContentAlignment.MiddleCenter;
            plateLabel.Location = new Point(32, 250);
            plateLabel.ForeColor = Color.White;
            plateLabel.BackColor = primary;

            Label typeLabel = new Label();
            typeLabel.Text = "Vehicle Type";
            typeLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            typeLabel.Size = new Size(217, 44);
            typeLabel.TextAlign = ContentAlignment.MiddleCenter;
            typeLabel.Location = new Point(32, 320);
            typeLabel.ForeColor = Color.White;
            typeLabel.BackColor = primary;

            Label brandLabel = new Label();
            brandLabel.Text = "Brand";
            brandLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            brandLabel.Size = new Size(217, 44);
            brandLabel.TextAlign = ContentAlignment.MiddleCenter;
            brandLabel.Location = new Point(32, 390);
            brandLabel.ForeColor = Color.White;
            brandLabel.BackColor = primary;

            Label parkInLabel = new Label();
            parkInLabel.Text = "Park in";
            parkInLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            parkInLabel.Size = new Size(217, 44);
            parkInLabel.TextAlign = ContentAlignment.MiddleCenter;
            parkInLabel.Location = new Point(32, 460);
            parkInLabel.ForeColor = Color.White;
            parkInLabel.BackColor = primary;

            Label plateDataLabel = new Label();
            plateDataLabel.Text = car.PlateNumber.ToString();
            plateDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            plateDataLabel.Size = new Size(461, 44);
            plateDataLabel.TextAlign = ContentAlignment.MiddleCenter;
            plateDataLabel.Location = new Point(269, 250);
            plateDataLabel.ForeColor = Color.White;
            plateDataLabel.BackColor = primary;

            Label vTypeDataLabel = new Label();
            vTypeDataLabel.Text = car.VehicleType.ToString();
            vTypeDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            vTypeDataLabel.Size = new Size(461, 44);
            vTypeDataLabel.TextAlign = ContentAlignment.MiddleCenter;
            vTypeDataLabel.Location = new Point(269, 320);
            vTypeDataLabel.ForeColor = Color.White;
            vTypeDataLabel.BackColor = primary;

            Label brandDataLabel = new Label();
            brandDataLabel.Text = car.Brand.ToString();
            brandDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            brandDataLabel.Size = new Size(461, 44);
            brandDataLabel.TextAlign = ContentAlignment.MiddleCenter;
            brandDataLabel.Location = new Point(269, 390);
            brandDataLabel.ForeColor = Color.White;
            brandDataLabel.BackColor = primary;

            Label parkInDataLabel = new Label();
            parkInDataLabel.Text = car.ParkIn.ToString();
            parkInDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            parkInDataLabel.Size = new Size(461, 44);
            parkInDataLabel.TextAlign = ContentAlignment.MiddleCenter;
            parkInDataLabel.Location = new Point(269, 460);
            parkInDataLabel.ForeColor = Color.White;
            parkInDataLabel.BackColor = primary;

            Button parkOutbutton = new Button();
            parkOutbutton.Text = "Park Out";
            parkOutbutton.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
            parkOutbutton.Size = new Size(251, 57);
            parkOutbutton.TextAlign = ContentAlignment.MiddleCenter;
            parkOutbutton.Location = new Point(475, 530);
            parkOutbutton.ForeColor = Color.White;
            parkOutbutton.Cursor = Cursors.Hand;
            parkOutbutton.BackColor = Color.FromArgb(102, 0, 0);

            parkInDetailPanel.Controls.Add(label1);
            parkInDetailPanel.Controls.Add(plateLabel);
            parkInDetailPanel.Controls.Add(typeLabel);
            parkInDetailPanel.Controls.Add(brandLabel);
            parkInDetailPanel.Controls.Add(parkInLabel);

            parkInDetailPanel.Controls.Add(plateDataLabel);
            parkInDetailPanel.Controls.Add(vTypeDataLabel);
            parkInDetailPanel.Controls.Add(brandDataLabel);
            parkInDetailPanel.Controls.Add(parkInDataLabel);

            parkInDetailPanel.Controls.Add(parkOutbutton);

            parkOutbutton.Click += (sender, e) =>
            {
                foreach (ParkingSystem c in parkedCars.GetParkedCars())
                {
                    parkedCars.GetParkedCars().Remove(car);
                    renderComponents(parkedCars.GetParkedCars());
                    parkInDetailPanel.Controls.Clear();
                    break;
                }
            };

        }

        private void parkInDetailPanel_Paint(object sender, PaintEventArgs e)
        {
            if (parkInDetailPanel.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              parkInDetailPanel.ClientSize.Width - thickness,
                                                              parkInDetailPanel.ClientSize.Height - thickness));
                }
            }
        }
    }
}
