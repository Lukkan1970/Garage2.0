using Garaget.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garaget.ViewModels
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            NewVehicle = false;
        }
        public IEnumerable<ParkedVehicle> Vehicles { get; set; }
        public bool NewVehicle { get; set; }
    }
}