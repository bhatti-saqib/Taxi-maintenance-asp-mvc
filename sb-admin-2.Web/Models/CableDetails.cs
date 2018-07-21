using System;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class CableDetails
    {
        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_PowerConnections { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_PowerCables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_CameraCables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_FourG_cables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_Gps_cables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_WifiCables { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_Labeling { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_CableDressing { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_CameraConnector { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string NT_DiskSize { get; set; }
    }
}