using System;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class HouseKeepingDetails
    {
        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_TaxiHandover { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_NoExistingAlarms { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_TaxiCabin { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_ItemsLeftInside { get; set; }
    }
}