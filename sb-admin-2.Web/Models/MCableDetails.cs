
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class MCableDetails
    {
        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_PowerConnections { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_PowerCables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_CameraCables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_FourG_cables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Gps_cables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_WifiCables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Labeling { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_CableDressing { get; set; }

        
    }
}