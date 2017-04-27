using Garaget.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garaget.ViewModels
{
    public class CheckOutTicketViewModel
    {

        public int Id { get; set; }

        [DisplayName("Type of Vehicle")]
        public VehicleType VehicleType { get; set; }

        [DisplayName("Registration Number")]
        public string RegNo { get; set; }

        [DisplayName("Check In Time")]
        public DateTime TimeOfCheckIn { get; set; }

        [DisplayName("Total Cost")]
        public string TotalCost { get; set; }

        
    }
}