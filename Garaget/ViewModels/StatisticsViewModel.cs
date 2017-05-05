using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Garaget.Models;
using System.ComponentModel;
using Garaget._Enum;

namespace Garaget.ViewModels
{
    public class StatisticsViewModel
    {
        public StatisticsViewModel()
        {
            int index = 0;
            foreach (var item in Vehicles)
            {
                double amountOfMinutes = ((DateTime.Now - item.TimeOfCheckIn).TotalHours);
                if (VehicleTypeAmount.ContainsKey(item.GetType().ToString()))
                {
                    TotalAmountOfMinutes = TotalAmountOfMinutes + (int)amountOfMinutes;
                }
                else
                {
                    VehicleTypeAmount.Add(item.GetType().ToString(), index++);
                }
                AmountOfWheels += item.NoWheels;
            }
        }

        public IEnumerable<ParkedVehicle> Vehicles { get; set; }

        [DisplayName("Type of Vehicle")]
        public Dictionary<string, int> VehicleTypeAmount { get; set; }
        [DisplayName("Type of Vehicle")]
        public int AmountOfWheels { get; set; }
        [DisplayName("Type of Vehicle")]
        public int TotalAmountOfMinutes { get; set; }

    }
}