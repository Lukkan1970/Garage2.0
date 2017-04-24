using Garaget.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garaget.Models

{
    public class ParkedVehicle
    {
        public ParkedVehicle()
        {
            TimeOfCheckIn = DateTime.Now;
        }
        public int Id { get; set; }
        public  VehicleType VehicleType { get; set; }
        public string RegNo { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NoWheels { get; set; }

        public DateTime TimeOfCheckIn { get; set; }
    }
}