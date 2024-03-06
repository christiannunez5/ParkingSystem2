using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemGUI
{
    public class ParkingSystem
    {
        public List <ParkingSystem> parkedCars = new List<ParkingSystem>();

        private string plateNumber;
        private string vehicleType;
        private string brand;
        private double flagDown;
        private DateTime parkIn;
        private DateTime parkOut;
        private double parkingFee;
        private double addPerHour;
        private TimeSpan duration;

        public ParkingSystem(string plateNumber, string vehicleType, string brand)
        {
            this.plateNumber = plateNumber;
            this.brand = brand;
            this.vehicleType = vehicleType;
            parkIn = DateTime.Now;
            switch (this.vehicleType)
            {
                case "Motorbike":
                    this.FlagDown = 20.0;
                    addPerHour = 5.0;
                    break;

                case "SUV":
                case "Van":
                    this.FlagDown = 40.0;
                    addPerHour = 20.0;
                    break;

                case "Sedan":
                    this.FlagDown = 30.0;
                    addPerHour = 15.0;
                    break;
            }
        }

        public ParkingSystem()
        {

        }
        public void AddCar(ParkingSystem car)
        {
            parkedCars.Add(car);
        }

        public List<ParkingSystem> GetParkedCars()
        {
            return parkedCars;
        }

        public string PlateNumber
        {
            get { return plateNumber; }
            set { plateNumber = value; }
        }


        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double FlagDown
        {
            get { return flagDown; }
            set { flagDown = value; }
        }

        public DateTime ParkOut
        {
            get { return parkOut; }
            set { parkOut = value; }
        }

        public DateTime ParkIn
        {
            get { return parkIn; }
            set { parkIn = value; }
        }


        public void parkInDetails()
        {

            Console.WriteLine("\n==============PARKIN==============");
            Console.WriteLine("\nPlate Number: " + PlateNumber);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Park in: " + parkIn);
            Console.WriteLine("Flag down: " + flagDown);
            Console.WriteLine("\n==================================");

        }

        public void parkOutDetails()
        {
            calculateParkingFee();
            Console.WriteLine("\n==============PARKOUT==============");
            Console.WriteLine("\nPlate Number: " + PlateNumber);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Flag down: " + flagDown);
            Console.WriteLine("Park in: " + parkIn);
            Console.WriteLine("Parkout: " + parkOut);
            Console.WriteLine("Parking Time: {0} days, {1} hour/s, {2} minute/s, and {3} seconds", duration.Days, duration.Hours, duration.Minutes, duration.Seconds);
            Console.WriteLine("Parking Fee: " + parkingFee);
            Console.WriteLine("\n==================================");
        }

        public void calculateParkingFee()
        {
            int years = parkOut.Year - ParkIn.Year;
            int months = parkOut.Month - parkIn.Month;
            int days = parkOut.Day - parkIn.Day;
            int hours = parkOut.Hour - parkIn.Hour;
            int minutes = parkOut.Minute - parkIn.Minute;
            int seconds = parkOut.Second - parkIn.Second;

            Console.WriteLine(years);

            if (parkOut.Year >= parkIn.Year)
            {
                if (months < 0)
                {
                    years--;
                    days += DateTime.IsLeapYear(parkOut.Year) ? 366 : 365 + 30 * months; // Adjust for leap years
                }
                else
                {

                }
            }

            if (hours < 0)
            {
                hours += 24;
                days--;
            }

            if (minutes < 0)
            {
                minutes += 60;
                hours--;
            }

            if (seconds < 0)
            {
                seconds += 60;
                minutes--;
            }

            parkingFee = flagDown + ((days * 24 + hours) * addPerHour);
            duration = new TimeSpan(days, hours, minutes, seconds);
        }

    }
}