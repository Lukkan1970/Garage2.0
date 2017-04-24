using Garaget.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garaget.DataAccessLayer
{
    public class GarageContext: DbContext
    {
        public GarageContext()
        {
        }
        public DbSet<ParkedVehicle> ParkedVehicles { get; set; }
    }
}