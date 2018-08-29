
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class MEquipmentFunctionsDetails
    {
        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_BroncoMdvrs { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Gps { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Four_g { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Wifi { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_VoltageTest { get; set; }
    }

}