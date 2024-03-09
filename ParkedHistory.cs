using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemGUI
{
    public class ParkedHistory
    {
        List<ParkedHistory> parkedHistories = new List<ParkedHistory>();

        private String plateNumber;
        double parkingFee;
        private DateTime parkIn;
        private DateTime parkOut;
        public ParkedHistory(String platenumber, DateTime parkin, DateTime parkOut, double parkingFee) 
        {
            this.plateNumber = platenumber;
            this.parkIn = parkin;
            this.parkOut = parkOut;
            this.parkingFee = parkingFee;   
        }

        public ParkedHistory()
        {

        }

        public String ParkingFee()
        {
            return this.parkingFee.ToString();
        }

        public String PlateNumber()
        {
            return this.plateNumber;
        }

        public DateTime ParkIn()
        {
            return this.parkIn;
        }

        public DateTime ParkOut()
        {
            return this.parkOut;
        }

        public List<ParkedHistory> GetParkedHistories()
        {
            return this.parkedHistories;
        }
    }
}
