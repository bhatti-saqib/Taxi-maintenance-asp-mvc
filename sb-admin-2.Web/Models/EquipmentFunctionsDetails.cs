using System;
using System.ComponentModel.DataAnnotations;


namespace sb_admin_2.Web.Models
{
    public class EquipmentFunctionsDetails
    {
        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_BroncoMdvrs { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_Gps { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_Four_g { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_Wifi { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_VoltageTest { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_Channel { get; set; }
    }
}