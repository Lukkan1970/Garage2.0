using Garaget.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garaget.ViewModels
{
    public class CheckOutTicketViewModel : Models.ParkedVehicle
    {

        [DisplayName("Total Cost")]
        public string TotalCost
        {
            get
            {
                var cost = 5000; //cost per hour
                var dateNow = DateTime.Now;
                var totalCost = ((dateNow - this.TimeOfCheckIn).TotalHours) * cost;
                var totalCostToString = totalCost.ToString("C");
              

                return totalCostToString;
            }
        }

        public static CheckOutTicketViewModel map(Models.ParkedVehicle model)
        {
            var vm = new CheckOutTicketViewModel()
            {
                RegNo = model.RegNo,
                TimeOfCheckIn = model.TimeOfCheckIn,
                VehicleType = model.VehicleType

            };
            return vm;
        }
    }
    
}