
using System;
using System.ComponentModel.DataAnnotations;


namespace sb_admin_2.Web.Models
{
    public class EquipmentDetails
    {
        //[Required(ErrorMessage = "-- Please Select --")]
        //public string NT_ExistingMDVR { get; set; }


        //[Required(ErrorMessage = "Please enter MDVR Serial No.")]
        //public string NT_MDVRSerialNo { get; set; }


        //[Required(ErrorMessage = "-- Please Select --")]
        //public string NT_Cameras { get; set; }


        [Required(ErrorMessage = "Please enter Camera Serial No.")]
        public string NT_CameraSerialNo { get; set; }


        //[Required(ErrorMessage = "-- Please Select --")]
        //public string NT_Ups { get; set; }


        [Required(ErrorMessage = "Please enter UPS Serial No.")]
        public string NT_UpsSerialNo { get; set; }


        //[Required(ErrorMessage = "-- Please Select --")]
        //public string NT_Hdds { get; set; }


        [Required(ErrorMessage = "Please enter HDD Serial No.")]
        public string NT_HDDSerialNo { get; set; }


        //[Required(ErrorMessage = "-- Please Select --")]
        //public string NT_Sims { get; set; }

        [Required(ErrorMessage = "Please enter Emmi No.")]
        public string NT_Emmis { get; set; }

        //[Required(ErrorMessage = "-- Please Select --")]
        //public string NT_CameraFovs { get; set; }
    }
}