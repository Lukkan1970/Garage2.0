using Garaget._Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        //[NotAnyVehicle]
        [Range(1, (int)VehicleTypeWithoutAny.Shoppingcart, ErrorMessage = "Vehicle Type is required.")]
        public VehicleTypeWithoutAny VehicleType { get; set; }
        
        [DisplayName("Registration Number")]
        [RegularExpression(pattern: "^[A-Z]{3}[0-9]{3}", ErrorMessage = "Only swedish registration numbers allowed like: AAA999.")]
        [Required]
        [StringLength(6)]
        public string RegNo { get; set; }

        [DisplayName("Color")]
        [Required]
        public string Color { get; set; }

        [DisplayName("Make")]
        [Required]
        public string Make { get; set; }

        [DisplayName("Model")]
        [Required]
        public string Model { get; set; }

        [DisplayName("Number of Wheels")]
        [Range(2, 10)]
        [Required]
        public int NoWheels { get; set; }


        [DisplayName("Check In Time")]
        //[DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime TimeOfCheckIn { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    string typeOfVehicle = VehicleType.GetType().ToString();
        //    if (typeOfVehicle == "Any")
        //    {
        //        yield return new ValidationResult(
        //            "Any is not a valid Vehicle.");
        //    }
        //}
    }
}