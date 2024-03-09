namespace ParkingSystemGUI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Color primary = Color.FromArgb(32, 32, 66);
            Color secondary = Color.FromArgb(58, 59, 89);

            ApplicationConfiguration.Initialize();
            Dashboard dashboard = new Dashboard();
            AddCarForm addCarForm = new AddCarForm();
            ParkingSystem cars = new ParkingSystem();
            ParkedHistory history = new ParkedHistory();
            DashboardUserControl dashboardUserControl = new DashboardUserControl();
            ParkUserControl parkUserControl = dashboard.GetParkUserControl();
            dashboard.GetDashboardUserControl().GetLabel1().Text = $"{cars.ParkedCars().Count} vehicles currently parked.";

            //UTILITY FUNCTIONS
            Label CreateLabel(ParkingSystem car)
            {
                Label label = new Label();
                label.Text = "Plate Number: " + car.PlateNumber;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Cascadia Mono Light", 12, FontStyle.Regular);
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Width = parkUserControl.GetParkedListPanel().Width - 15;
                label.Height = 50;
                label.Cursor = Cursors.Hand;
                label.AutoSize = false;

                label.MouseEnter += (sender, e) =>
                {
                    Label hoverLabel = (Label)sender;
                    hoverLabel.BackColor = Color.LightGray;
                };

                label.MouseLeave += (sender, e) =>
                {
                    Label leaveLabel = (Label)sender;
                    leaveLabel.BackColor = Color.White;
                };

                label.Click += (sender, e) =>
                {
                    viewDetails(car);
                };

                return label;
            }

            bool IsPlateNumberUnique(String plateNumber)
            {
                foreach (ParkingSystem car in cars.GetParkedCars())
                {
                    if (car.PlateNumber == plateNumber)
                        return false;
                }

                return true;
            }

            Label historyLabel(String str)
            {
                Label label = new Label();
                label.Text = str;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Cascadia Mono Light", 11, FontStyle.Regular);
                label.Width = 269;
                label.Height = 51;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Cursor = Cursors.Hand;
                label.ForeColor = Color.White;
                label.AutoSize = false;

                label.MouseEnter += (sender, e) =>
                {
                    Label hoverLabel = (Label)sender;
                    hoverLabel.BackColor = secondary;
                };

                label.MouseLeave += (sender, e) =>
                {
                    Label leaveLabel = (Label)sender;
                    leaveLabel.BackColor = primary;
                };

                return label;
            }

            void renderHistoryComponents(List<ParkedHistory> histories)
            {
                Panel historypanel = dashboard.GetParkedHistoryUserControl().GetHistoryPanel();
                Panel transactionPanel = dashboard.GetParkedHistoryUserControl().GetTransactionPanel(); 
                if (histories.Count == 0)
                {
                    dashboard.GetParkedHistoryUserControl().GetErrorPanel().Visible = true;
                    transactionPanel.Visible = false;
                }

                else
                {
                    transactionPanel.Visible = true;
                    dashboard.GetParkedHistoryUserControl().GetErrorPanel().Visible = false;
                    historypanel.Controls.Clear();

                    foreach (ParkedHistory hist in histories)
                    {
                        int count = 0;
                        Label label = new Label();
                        label.Height = 51;
                        label.Width = historypanel.Width;
                        label.BackColor = Color.Black;
                        label.Text = $"wtf {count}";
                        count++;
                        FlowLayoutPanel flowP = new FlowLayoutPanel();
                        flowP.Width = historypanel.Width;
                        flowP.Height = 51;
                        flowP.BackColor = Color.FromArgb(32, 32, 66);
                        flowP.Padding = new Padding(0);

                        Label plateLabel = historyLabel(hist.PlateNumber());
                        plateLabel.Margin = new Padding(0);

                        Label parkInLabel = historyLabel(hist.ParkIn().ToString());
                        parkInLabel.Margin = new Padding(0);

                        Label parkOutLabel = historyLabel(hist.ParkOut().ToString());
                        parkOutLabel.Margin = new Padding(0);

                        Label feeLabel = historyLabel(hist.ParkingFee());
                        feeLabel.Margin = new Padding(0);

                        flowP.Controls.Add(plateLabel);
                        flowP.Controls.Add(parkInLabel);
                        flowP.Controls.Add(parkOutLabel);
                        flowP.Controls.Add(feeLabel);

                        historypanel.Controls.Add(flowP);

                    }

                }
                
               

            }

            //DASHBOARD CONTROLLER
            dashboard.GetHomePictureBox().Click += (sender, e) =>
            {
                dashboard.GetDashboardUserControl().Visible = true;
                dashboard.GetParkUserControl().Visible = false;
                dashboard.GetParkedHistoryUserControl().Visible = false;
                dashboard.GetDashboardUserControl().GetLabel1().Text = $"{cars.ParkedCars().Count} vehicles currently parked.";
                dashboard.GetHomePictureBox().BackColor = secondary;
                dashboard.GetParkBoxPictureBox().BackColor = primary;
                dashboard.GetHistoryBox().BackColor = primary;
            };

            dashboard.GetParkBoxPictureBox().Click += (sender, e) =>
            {
                dashboard.GetDashboardUserControl().Visible = false;
                dashboard.GetParkUserControl().Visible = true;
                dashboard.GetParkedHistoryUserControl().Visible = false;
                dashboard.GetHomePictureBox().BackColor = primary;
                dashboard.GetHistoryBox().BackColor = primary;
                dashboard.GetParkBoxPictureBox().BackColor = secondary;
            };

            dashboard.GetHistoryBox().Click += (sender, e) =>
            {
                dashboard.GetParkedHistoryUserControl().Visible = true;
                dashboard.GetDashboardUserControl().Visible = false;
                dashboard.GetParkUserControl().Visible = false;
                dashboard.GetHomePictureBox().BackColor = primary;
                dashboard.GetParkBoxPictureBox().BackColor = primary;
                dashboard.GetHistoryBox().BackColor = secondary;
            };

            //PARKUSERCONTROL CONTROLLER
            parkUserControl.GetAddParkButton().Click += (sender, e) =>
            {
                if (addCarForm == null || addCarForm.IsDisposed)
                {
                    addCarForm = new AddCarForm(); // Create a new instance if it's not created yet or disposed
                }

                addCarForm.Show();

                //ADD CAR FORM CONTROLLER

                addCarForm.GetAddCarButton().Click += (sender, e) =>
                {
                    string plateNumber = addCarForm.GetPlateNumber().Text;
                    string vehicleType = addCarForm.GetVehicleType()?.SelectedItem?.ToString();
                    string brand = addCarForm.GetBrand()?.SelectedItem?.ToString();

                    if (string.IsNullOrEmpty(plateNumber) || string.IsNullOrEmpty(vehicleType) || string.IsNullOrEmpty(brand))
                    {
                        MessageBox.Show("All fields must be filled.");
                    }

                    else if (vehicleType == "Select Vehicle" && brand == "Select Brand")
                    {
                        MessageBox.Show("All fields must be filled.");
                    }
                    else if (!IsPlateNumberUnique(plateNumber))
                    {
                        MessageBox.Show("This vehicle is already parked. Plate number: " + plateNumber);
                    }
                    else
                    {
                        ParkingSystem car = new ParkingSystem(plateNumber, vehicleType, brand);
                        cars.ParkedCars().Add(car);
                        renderComponents(cars.ParkedCars());
                        addCarForm.GetPlateNumber().Text = "";
                        addCarForm.GetPlateNumber().PlaceholderText = "Plate Number...";
                        addCarForm.GetVehicleType().Text = "Select Vehicle";
                        addCarForm.GetBrand().Text = "Select Brand";
                        addCarForm.Visible = false;
                    }
                };

            };
       

            void renderComponents(List <ParkingSystem> listOfCars)
            {
                parkUserControl.GetParkedListPanel().Controls.Clear();

                foreach (ParkingSystem car in listOfCars)
                {
                    Label label = CreateLabel(car);
                    parkUserControl.GetParkedListPanel().Controls.Add(label);
                }
            }

            void viewDetails(ParkingSystem car)
            {
                parkUserControl.GetParkInDetailPanel().Controls.Clear();
 
                Label label1 = new Label();
                label1.Text = "PARK IN DETAILS";
                label1.Location = new Point(3, 0);
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

                parkUserControl.GetParkInDetailPanel().Controls.Add(label1);
                parkUserControl.GetParkInDetailPanel().Controls.Add(plateLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(typeLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(brandLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(parkInLabel);

                parkUserControl.GetParkInDetailPanel().Controls.Add(plateDataLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(vTypeDataLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(brandDataLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(parkInDataLabel);

                parkUserControl.GetParkInDetailPanel().Controls.Add(parkOutbutton);

                parkOutbutton.Click += (sender, e) =>
                {
                    foreach (ParkingSystem c in cars.ParkedCars())
                    {
                        car.ParkOutNow();
                        Receipt receipt = new Receipt(car);
                        receipt.Show();
                        receipt.GetBackButton().Click += (sender, e) =>
                        {
                            ParkedHistory parked = new ParkedHistory(car.PlateNumber, car.ParkIn, car.ParkOut, car.ParkingFee);
                            history.GetParkedHistories().Add(parked);
                            receipt.Close();
                            cars.ParkedCars().Remove(car);
                            renderComponents(cars.ParkedCars());
                            renderHistoryComponents(history.GetParkedHistories());
                            parkUserControl.GetParkInDetailPanel().Controls.Clear();
                        };
                        break;
                    }
                };      

            }

            Application.Run(dashboard);
        }

    }
}
