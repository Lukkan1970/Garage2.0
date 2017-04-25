namespace Garaget.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garaget.DataAccessLayer.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(Garaget.DataAccessLayer.GarageContext context)
        {
            DateTime date = DateTime.Now;
            context.ParkedVehicles.AddOrUpdate(
                v => v.RegNo,
                new ParkedVehicle { VehicleType = Garaget.Enum.VehicleType.Car, Color = "Blue", Model = "Audi", Make = "A4", NoWheels = 4, RegNo = "ANY719", TimeOfCheckIn = date.AddHours(2) },
                new ParkedVehicle { VehicleType = Garaget.Enum.VehicleType.Bus, Color = "Red", Model = "Scania", Make = "OmniCity", NoWheels = 10, RegNo = "BUS007", TimeOfCheckIn = date.AddHours(4) },
                new ParkedVehicle { VehicleType = Garaget.Enum.VehicleType.Moped, Color = "Brown", Model = "Suzuki", Make = "KS50", NoWheels = 2, RegNo = "REG538", TimeOfCheckIn = date.AddHours(6) },
                new ParkedVehicle { VehicleType = Garaget.Enum.VehicleType.Shoppingcart, Color = "Chrome", Model="CartMaker", Make="UltraShopper", NoWheels = 4, RegNo = "SHO357" }
            );
        }
    }
}
