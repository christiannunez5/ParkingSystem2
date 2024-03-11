using ParkingSystemGUI.Properties;
using System.Text.Json.Serialization;

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
            String adminUsername = "admin" ;
            String adminPassword = "admin" ;

            Color primary = Color.FromArgb(32, 32, 66);
            Color secondary = Color.FromArgb(58, 59, 89);

            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new LoginForm();
            Dashboard dashboard = new Dashboard();
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
                label.Width = parkUserControl.GetParkedListPanel().Width - 2;
                label.Height = 50;
                label.Cursor = Cursors.Hand;
                label.Margin = new Padding(0);
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
                label.Margin = new Padding(0);
                label.Padding = new Padding(0);
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
                        FlowLayoutPanel flowP = new FlowLayoutPanel();
                        flowP.Width = historypanel.Width;
                        flowP.Height = 51;
                        flowP.BackColor = Color.FromArgb(32, 32, 66);
                        flowP.Padding = new Padding(0);
                        flowP.Margin = new Padding(0);
                        flowP.BringToFront();


                        Label plateLabel = historyLabel(hist.PlateNumber());

                        Label parkInLabel = historyLabel(hist.ParkIn().ToString());

                        Label parkOutLabel = historyLabel(hist.ParkOut().ToString());

                        Label feeLabel = historyLabel(hist.ParkingFee());

                        plateLabel.MouseEnter += (sender, e) =>
                        {
                            flowP.BackColor = secondary;
                        };

                        plateLabel.MouseLeave += (sender, e) =>
                        {
                            flowP.BackColor = primary;
                        };


                        parkInLabel.MouseEnter += (sender, e) =>
                        {
                            flowP.BackColor = secondary;
                        };

                        parkInLabel.MouseLeave += (sender, e) =>
                        {
                            flowP.BackColor = primary;
                        };


                        parkOutLabel.MouseEnter += (sender, e) =>
                        {
                            flowP.BackColor = secondary;
                        };

                        parkOutLabel.MouseLeave += (sender, e) =>
                        {
                            flowP.BackColor = primary;
                        };


                        feeLabel.MouseEnter += (sender, e) =>
                        {
                            flowP.BackColor = secondary;
                        };

                        feeLabel.MouseLeave += (sender, e) =>
                        {
                            flowP.BackColor = primary;
                        };


                        flowP.Controls.Add(plateLabel);
                        flowP.Controls.Add(parkInLabel);
                        flowP.Controls.Add(parkOutLabel);
                        flowP.Controls.Add(feeLabel);

                        historypanel.Controls.Add(flowP);

                    }

                }

            }

            //LOGIN FORM CONTROLLER
            loginForm.GetLoginButton().Click += (sender, e) =>
            {
                String username = loginForm.GetUsernameInput().Text.ToString();
                String password = loginForm.GetPasswordInput().Text.ToString();

                if (username == null || password == null)
                {
                    MessageBox.Show("All inputs must be filled.");
                }

                else if (username == "" || password == "")
                {
                    MessageBox.Show("All inputs must be filled.");
                }

                else if(username == adminUsername && password == adminPassword)
                {
                    loginForm.GetUsernameInput().Text = "";
                    loginForm.GetPasswordInput().Text = "";
                    loginForm.Hide();
                    dashboard.Show();
                    loginForm.GetUsernameInput().PlaceholderText = "Enter username";
                    loginForm.GetPasswordInput().PlaceholderText = "Enter password";
                }

                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }

            };

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

            dashboard.GetLogOutBox().Click += (sender, e) =>
            {
                dashboard.GetHomePictureBox().BackColor = primary;
                dashboard.GetParkBoxPictureBox().BackColor = primary;
                dashboard.GetHistoryBox().BackColor = primary;
                dashboard.GetLogOutBox().BackColor = secondary;
                dashboard.Hide();
                loginForm.Show();
            };


            //PARKUSERCONTROL CONTROLLER
            parkUserControl.GetAddParkButton().Click += (sender, e) =>
            {
                AddCarForm addCarForm = new AddCarForm();
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
                        addCarForm.GetPlateNumber().PlaceholderText = "Enter plate number...";
                        addCarForm.GetVehicleType().Text = "Select Vehicle";
                        addCarForm.GetBrand().Text = "Select Brand";
                        addCarForm.Close();
                    }
                };

            };

            parkUserControl.GetSearchBox().Click += (sender, e) =>
            {
                ParkingSystem foundCar = new ParkingSystem();
                bool isFound = false;
                parkUserControl.GetEndSearchBox().Visible = true;
                TextBox plateNumber = parkUserControl.GetPlateNumberSearch();
                
                foreach(ParkingSystem car in cars.GetParkedCars())
                {
                    if (car.PlateNumber == plateNumber.Text.ToString())
                    {
                        isFound = true;
                        foundCar = car;
                        break;
                    }
                }

                if (isFound)
                {
                    renderSingleCar(foundCar);
                }

                else
                {
                    parkUserControl.GetMessageLabel().Text = "Plate number not found.";
                    parkUserControl.GetZeroParkPanel().Visible = true;
                    parkUserControl.GetParkedListPanel().Visible = false;
                }

                parkUserControl.GetEndSearchBox().Click += (sender, e) =>
                {
                    parkUserControl.GetEndSearchBox().Visible = false;
                    plateNumber.Text = "";
                    renderComponents(cars.GetParkedCars());
                };


            };

            parkUserControl.GetEndSearchBox().Click += (sender, e) =>
            {
                parkUserControl.GetParkInDetailPanel().Controls.Clear();
            };

            void renderSingleCar(ParkingSystem car)
            {
                parkUserControl.GetParkedListPanel().Controls.Clear();

                if (cars.GetParkedCars().Count == 0)
                {
                    parkUserControl.GetMessageLabel().Text = "0 cars parked.";
                    parkUserControl.GetZeroParkPanel().Visible = true;
                    parkUserControl.GetParkedListPanel().Visible = false;
                }

                else
                {
                    parkUserControl.GetZeroParkPanel().Visible = false;
                    parkUserControl.GetParkedListPanel().Visible = true;

                    Label label = CreateLabel(car);
                    parkUserControl.GetParkedListPanel().Controls.Add(label);
                }
            }
       
            void renderComponents(List <ParkingSystem> listOfCars)
            {
                parkUserControl.GetParkedListPanel().Controls.Clear();
                if (listOfCars.Count == 0)
                {
                    parkUserControl.GetMessageLabel().Text = "0 parked cars.";
                    parkUserControl.GetZeroParkPanel().Visible = true;
                    parkUserControl.GetParkedListPanel().Visible = false;
                }
                else
                {
                    parkUserControl.GetZeroParkPanel().Visible = false;
                    parkUserControl.GetParkedListPanel().Visible = true;

                    foreach (ParkingSystem car in listOfCars)
                    {
                        Label label = CreateLabel(car);
                        parkUserControl.GetParkedListPanel().Controls.Add(label);
                    }
                }
               
            }

            void viewDetails(ParkingSystem car)
            {
                parkUserControl.GetParkInDetailPanel().Controls.Clear();

                Label label1 = new Label();
                label1.Text = "PARK IN DETAILS";
                label1.Location = new Point(0, 4);
                label1.Size = new Size(787, 175);
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.ForeColor = Color.White;
                label1.BackColor = primary;
                label1.Font = new Font("Cascadia Mono Light", 35, FontStyle.Regular);

                Label plateLabel = new Label();
                plateLabel.Text = "Plate Number";
                plateLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                plateLabel.Size = new Size(245, 46);
                plateLabel.TextAlign = ContentAlignment.MiddleCenter;
                plateLabel.Location = new Point(38, 230);
                plateLabel.ForeColor = Color.White;
                plateLabel.BackColor = primary;

                Label typeLabel = new Label();
                typeLabel.Text = "Vehicle Type";
                typeLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                typeLabel.Size = new Size(245, 46);
                typeLabel.TextAlign = ContentAlignment.MiddleCenter;
                typeLabel.Location = new Point(38, 300);
                typeLabel.ForeColor = Color.White;
                typeLabel.BackColor = primary;

                Label brandLabel = new Label();
                brandLabel.Text = "Brand";
                brandLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                brandLabel.Size = new Size(245, 46);
                brandLabel.TextAlign = ContentAlignment.MiddleCenter;
                brandLabel.Location = new Point(38, 370);
                brandLabel.ForeColor = Color.White;
                brandLabel.BackColor = primary;

                Label parkInLabel = new Label();
                parkInLabel.Text = "Park in";
                parkInLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                parkInLabel.Size = new Size(245, 46);
                parkInLabel.TextAlign = ContentAlignment.MiddleCenter;
                parkInLabel.Location = new Point(38, 440);
                parkInLabel.ForeColor = Color.White;
                parkInLabel.BackColor = primary;

                Label flagdownLabel = new Label();
                flagdownLabel.Text = "Flagdown";
                flagdownLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                flagdownLabel.Size = new Size(245, 46);
                flagdownLabel.TextAlign = ContentAlignment.MiddleCenter;
                flagdownLabel.Location = new Point(38, 510);
                flagdownLabel.ForeColor = Color.White;
                flagdownLabel.BackColor = primary;

                Label plateDataLabel = new Label();
                plateDataLabel.Text = car.PlateNumber.ToString();
                plateDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                plateDataLabel.Size = new Size(435, 46);
                plateDataLabel.TextAlign = ContentAlignment.MiddleCenter;
                plateDataLabel.Location = new Point(299, 230);
                plateDataLabel.ForeColor = Color.White;
                plateDataLabel.BackColor = primary;

                Label vTypeDataLabel = new Label();
                vTypeDataLabel.Text = car.VehicleType.ToString();
                vTypeDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                vTypeDataLabel.Size = new Size(435, 46);
                vTypeDataLabel.TextAlign = ContentAlignment.MiddleCenter;
                vTypeDataLabel.Location = new Point(299, 300);
                vTypeDataLabel.ForeColor = Color.White;
                vTypeDataLabel.BackColor = primary;

                Label brandDataLabel = new Label();
                brandDataLabel.Text = car.Brand.ToString();
                brandDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                brandDataLabel.Size = new Size(435, 46);
                brandDataLabel.TextAlign = ContentAlignment.MiddleCenter;
                brandDataLabel.Location = new Point(299, 370);
                brandDataLabel.ForeColor = Color.White;
                brandDataLabel.BackColor = primary;

                Label parkInDataLabel = new Label();
                parkInDataLabel.Text = car.ParkIn.ToString();
                parkInDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                parkInDataLabel.Size = new Size(435, 46);
                parkInDataLabel.TextAlign = ContentAlignment.MiddleCenter;
                parkInDataLabel.Location = new Point(299, 440);
                parkInDataLabel.ForeColor = Color.White;
                parkInDataLabel.BackColor = primary;

                Label flagdownDataLabel = new Label();
                flagdownDataLabel.Text = car.FlagDown.ToString();
                flagdownDataLabel.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                flagdownDataLabel.Size = new Size(435, 46);
                flagdownDataLabel.TextAlign = ContentAlignment.MiddleCenter;
                flagdownDataLabel.Location = new Point(299, 510);
                flagdownDataLabel.ForeColor = Color.White;
                flagdownDataLabel.BackColor = primary;

                Button parkOutbutton = new Button();
                parkOutbutton.Text = "Park Out";
                parkOutbutton.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                parkOutbutton.Size = new Size(245, 46);
                parkOutbutton.TextAlign = ContentAlignment.MiddleCenter;
                parkOutbutton.Location = new Point(490, 580);
                parkOutbutton.ForeColor = Color.White;
                parkOutbutton.Cursor = Cursors.Hand;
                parkOutbutton.BackColor = Color.FromArgb(102, 0, 0);

                Button exitButton = new Button();
                exitButton.Text = "Close";
                exitButton.Font = new Font("Cascadia Mono Light", 13, FontStyle.Regular);
                exitButton.Size = new Size(270, 46);
                exitButton.TextAlign = ContentAlignment.MiddleCenter;
                exitButton.Location = new Point(210, 580);
                exitButton.ForeColor = Color.White;
                exitButton.Cursor = Cursors.Hand;
                exitButton.BackColor = Color.FromArgb(102, 0, 0);

                parkUserControl.GetParkInDetailPanel().Controls.Add(label1);
                parkUserControl.GetParkInDetailPanel().Controls.Add(plateLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(typeLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(brandLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(parkInLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(flagdownLabel);

                parkUserControl.GetParkInDetailPanel().Controls.Add(plateDataLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(vTypeDataLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(brandDataLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(parkInDataLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(flagdownDataLabel);
                parkUserControl.GetParkInDetailPanel().Controls.Add(parkOutbutton);
                parkUserControl.GetParkInDetailPanel().Controls.Add(exitButton);

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
                            parkUserControl.GetEndSearchBox().Visible = false;
                            parkUserControl.GetPlateNumberSearch().Text = "";
                        };
                        break;
                    }
                };

                exitButton.Click += (sender, e) =>
                {
                    parkUserControl.GetParkInDetailPanel().Controls.Clear();
                };

            }

           
            Application.Run(loginForm);
        }

    }
}
