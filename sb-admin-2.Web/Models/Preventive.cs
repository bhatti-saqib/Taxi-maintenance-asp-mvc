using System;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class Preventive
    {
        public int Id { get; set; }
        //public Sites? NT_Sites { get; set; }

        [Required(ErrorMessage = "Please select Site.")]
        [StringLength(255)]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter only alphabets.")]
        public string SiteName { get; set; }


        [Required]
        public string TaxiType { get; set; }

        [Required(ErrorMessage = "Please enter Plate Number")]
        //[DataType(DataType.PhoneNumber)]
        public string PlateNumber { get; set; }


        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Must be a number")]
        [Required(ErrorMessage = "Please enter MDVR Number")]
        public string MdvrNo { get; set; }


        [Required(ErrorMessage = "Please enter Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd-mm-yyyy}")]
        public DateTime Date { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        public string ExistingMDVR { get; set; }


        [Required(ErrorMessage = "Please enter MDVR Serial No.")]
        //[MaxLength(10, ErrorMessage="Cannot be greater than 10")]
        public string MDVRSerialNo { get; set; }


        [Required]
        public string Cameras { get; set; }

        [Required(ErrorMessage = "Please enter Camera Serial No.")]
        public string CameraSerialNo { get; set; }

        [Required]
        public string Ups { get; set; }


        [Required(ErrorMessage = "Please enter UPS Serial No.")]
        public string UpsSerialNo { get; set; }

        [Required]
        public string Hdds { get; set; }


        [Required(ErrorMessage = "Please enter HDD Serial No.")]
        public string HDDSerialNo { get; set; }

        [Required]
        public string Sims { get; set; }

        [Required]
        public string Emmis { get; set; }

        [Required]
        public string CameraFovs { get; set; }

        [Required]
        public string PowerConnections { get; set; }

        [Required]
        public string PowerCables { get; set; }

        [Required]
        public string CameraCables { get; set; }

        [Required]
        public string FourG_cables { get; set; }

        [Required]
        public string Gps_cables { get; set; }

        [Required]
        public string WifiCables { get; set; }

        [Required]
        public string Labeling { get; set; }

        [Required]
        public string CableDressing { get; set; }

        
        [Required]
        public string BroncoMdvrs { get; set; }

        [Required]
        public string Gps { get; set; }

        [Required]
        public string Four_g { get; set; }


        [Required]
        public string Wifi { get; set; }


        [Required]
        public string VoltageTest { get; set; }



        [Required]
        public string TaxiHandover { get; set; }


        [Required]
        public string NoExistingAlarms { get; set; }


        [Required]
        public string OverallFeedback { get; set; }


        //[Required(ErrorMessage = "Please enter Depot Representative Name.")]
        public bool? Is_DepotRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter SecureTech Representative Name.")]
        public bool? Is_SecureTechRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter MCC Representative Name.")]
        public bool? Is_MccRepApproved { get; set; }

        public string PlateNumberPic { get; set; }

        public string MdvrNoPic { get; set; }

        public string MDVRSerialNoPic { get; set; }

        public string CameraSerialNoPic { get; set; }

        public string UpsSerialNoPic { get; set; }

        public string HDDSerialNoPic { get; set; }

        public string PowerConnectionsPic { get; set; }

        public string PowerCablesPic { get; set; }

        public string CameraCablesPic { get; set; }

        public string FourG_cablesPic { get; set; }

        public string Gps_cablesPic { get; set; }

        public string WifiCablesPic { get; set; }

        public string LabelingPic { get; set; }

        public string CableDressingPic { get; set; }

    }
}