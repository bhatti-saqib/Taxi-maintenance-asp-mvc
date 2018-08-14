using System;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class MEquipmentDetails
    {
        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_ExistingMDVR { get; set; }


        [Required(ErrorMessage = "Please enter MDVR Serial No.")]
        public string MT_MDVRSerialNo { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Cameras { get; set; }


        [Required(ErrorMessage = "Please enter Camera Serial No.")]
        public string MT_CameraSerialNo { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Ups { get; set; }


        [Required(ErrorMessage = "Please enter UPS Serial No.")]
        public string MT_UpsSerialNo { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Hdds { get; set; }


        [Required(ErrorMessage = "Please enter HDD Serial No.")]
        public string MT_HDDSerialNo { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_Sims { get; set; }

        [Required(ErrorMessage = "Please enter Emmi No.")]
        public string MT_Emmis { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_CameraFovs { get; set; }
    }

}