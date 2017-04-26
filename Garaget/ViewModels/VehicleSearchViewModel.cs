using Garaget.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garaget.ViewModels
{
    public class VehicleSearchViewModel
    {
        public int Id { get; set; }

        [DisplayName("Type of Vehicle")]
        public VehicleType VehicleType { get; set; }

        [DisplayName("Registration Number")]
        public string RegNo { get; set; }

        [DisplayName("Make")]
        public string Make { get; set; }

        [DisplayName("Model")]
        public string Model { get; set; }
    }
}