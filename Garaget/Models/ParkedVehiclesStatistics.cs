using Garaget.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garaget.Models
{
    public class ParkedVehiclesStatistics
    {
        public int AmountVehicles { get; set; }
        public int AmountWheels { get; set; }
        public Dictionary<VehicleType, int> AmountVehiclePerType { get; set; }
        public int AmountMinutes { get; set; }

    }
}