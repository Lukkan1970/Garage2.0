using Garaget.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Garaget.Models

{
    public class ParkedVehicle
    {
        public ParkedVehicle()
        {
            TimeOfCheckIn = DateTime.Now;
        }
        public int Id { get; set; }
        [DisplayName("Type of Vehicle")]
        public VehicleType VehicleType { get; set; }
        [DisplayName("Registration Number")]
        public string RegNo { get; set; }
        [DisplayName("Color")]
        public string Color { get; set; }
        [DisplayName("Make")]
        public string Make { get; set; }
        [DisplayName("Model")]
        public string Model { get; set; }
        [DisplayName("Number of Wheels")]
        public int NoWheels { get; set; }

        [DisplayName("Check In Time")]
        public DateTime TimeOfCheckIn { get; set; }
    }
}