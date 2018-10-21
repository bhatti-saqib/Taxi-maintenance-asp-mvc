using System;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class Preventive
    {
        public int Id { get; set; }
        //public Sites? NT_Sites { get; set; }

        [StringLength(1)]
        public string typeOfMaintenance { get; set; }

        
        [Required(ErrorMessage = "Please enter Plate Number")]
        
        public string MT_PlateNumber { get; set; }


        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Must be a number")]
        //[Required(ErrorMessage = "Please enter MDVR Number")]
        //public string MT_MdvrNo { get; set; }


        [Required(ErrorMessage = "Please enter Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd-mm-yyyy}")]
        public DateTime MT_Date { get; set; }

        

        //[Required]
        public string MT_ExistingMDVR { get; set; }


        //[Required(ErrorMessage = "Please enter MDVR Serial No.")]
        //[MaxLength(10, ErrorMessage="Cannot be greater than 10")]
        public string MT_MDVRSerialNo { get; set; }


        //[Required]
        public string MT_Cameras { get; set; }

        //[Required(ErrorMessage = "Please enter Camera Serial No.")]
        public string MT_CameraSerialNo { get; set; }

        //[Required]
        public string MT_Ups { get; set; }


        //[Required(ErrorMessage = "Please enter UPS Serial No.")]
        public string MT_UpsSerialNo { get; set; }

        //[Required]
        public string MT_Hdds { get; set; }


        //[Required(ErrorMessage = "Please enter HDD Serial No.")]
        public string MT_HDDSerialNo { get; set; }

        //[Required]
        public string MT_Sims { get; set; }

        //[Required]
        public string MT_Emmis { get; set; }

        //[Required]
        public string MT_CameraFovs { get; set; }

        //[Required]
        public string MT_PowerConnections { get; set; }

        //[Required]
        public string MT_PowerCables { get; set; }

        //[Required]
        public string MT_CameraCables { get; set; }

        //[Required]
        public string MT_FourG_cables { get; set; }

        //[Required]
        public string MT_Gps_cables { get; set; }

        //[Required]
        public string MT_WifiCables { get; set; }

        //[Required]
        public string MT_Labeling { get; set; }

        //[Required]
        public string MT_CableDressing { get; set; }

        
        //[Required]
        public string MT_BroncoMdvrs { get; set; }

        //[Required]
        public string MT_Gps { get; set; }

        //[Required]
        public string MT_Four_g { get; set; }


        //[Required]
        public string MT_Wifi { get; set; }


        //[Required]
        public string MT_VoltageTest { get; set; }



        //[Required]
        public string MT_TaxiHandover { get; set; }


        //[Required]
        public string MT_NoExistingAlarms { get; set; }


        //[Required]
        public string MT_OverallFeedback { get; set; }


        public string MT_Equ_For_Corr_Measure { get; set; }


        public string MT_Corr_Measure_Taken { get; set; }


        public string MT_Comment_Box_For_Technicians { get; set; }


        public string MT_Old_SerialNo_If_Replaced { get; set; }


        public string MT_Old_SerialNo_If_Replaced_Pic { get; set; }


        public string MT_New_SerialNo_If_Replaced { get; set; }


        public string MT_New_SerialNo_If_Replaced_Pic { get; set; }


        //[Required(ErrorMessage = "Please enter Depot Representative Name.")]
        public bool? Is_MT_DepotRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter SecureTech Representative Name.")]
        public bool? Is_MT_SecureTechRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter MCC Representative Name.")]
        public bool? Is_MT_MccRepApproved { get; set; }

        public string MT_PlateNumberPic { get; set; }

        public string MT_MdvrNoPic { get; set; }

        public string MT_MDVRSerialNoPic { get; set; }

        public string MT_CameraSerialNoPic { get; set; }

        public string MT_UpsSerialNoPic { get; set; }

        public string MT_HDDSerialNoPic { get; set; }

        public string MT_PowerConnectionsPic { get; set; }

        public string MT_PowerCablesPic { get; set; }

        public string MT_CameraCablesPic { get; set; }

        public string MT_FourG_cablesPic { get; set; }

        public string MT_Gps_cablesPic { get; set; }

        public string MT_WifiCablesPic { get; set; }

        public string MT_LabelingPic { get; set; }

        public string MT_CableDressingPic { get; set; }

        public NewTaxi NewTaxi { get; set; }

    }
}