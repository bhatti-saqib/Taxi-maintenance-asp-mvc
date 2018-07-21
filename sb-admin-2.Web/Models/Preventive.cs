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
        public string MT_SiteName { get; set; }


        [Required]
        public string MT_TaxiType { get; set; }

        [Required(ErrorMessage = "Please enter Plate Number")]
        //[DataType(DataType.PhoneNumber)]
        public string MT_PlateNumber { get; set; }


        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Must be a number")]
        [Required(ErrorMessage = "Please enter MDVR Number")]
        public string MT_MdvrNo { get; set; }


        [Required(ErrorMessage = "Please enter Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd-mm-yyyy}")]
        public DateTime MT_Date { get; set; }

        [Required]
        public string MT_Region { get; set; }

        [Required]
        public string MT_ExistingMDVR { get; set; }

        //public string MT_MDVRSerialNo { get; set; }


        [Required]
        public string MT_Cameras { get; set; }

        //public string NT_CameraSerialNo { get; set; }

        [Required]
        public string MT_Ups { get; set; }

        //public string NT_UpsSerialNo { get; set; }

        [Required]
        public string MT_Hdds { get; set; }

        //public string NT_HDDSerialNo { get; set; }

        [Required]
        public string MT_Sims { get; set; }

        [Required]
        public string MT_Emmis { get; set; }

        [Required]
        public string MT_CameraFovs { get; set; }

        [Required]
        public string MT_PowerConnections { get; set; }

        [Required]
        public string MT_PowerCables { get; set; }

        [Required]
        public string MT_CameraCables { get; set; }

        [Required]
        public string MT_FourG_cables { get; set; }

        [Required]
        public string MT_Gps_cables { get; set; }

        [Required]
        public string MT_WifiCables { get; set; }

        [Required]
        public string MT_Labeling { get; set; }

        [Required]
        public string MT_CableDressing { get; set; }

        [Required]
        public string MT_CameraConnector { get; set; }

        [Required]
        public string MT_DiskSize { get; set; }

        [Required]
        public string MT_BroncoMdvrs { get; set; }

        [Required]
        public string MT_Gps { get; set; }

        [Required]
        public string MT_Four_g { get; set; }


        [Required]
        public string MT_Wifi { get; set; }


        [Required]
        public string MT_VoltageTest { get; set; }



        [Required]
        public string MT_Channel { get; set; }



        [Required]
        public string MT_TaxiHandover { get; set; }


        [Required]
        public string MT_NoExistingAlarms { get; set; }


        [Required]
        public string MT_TaxiCabin { get; set; }


        [Required]
        public string MT_ItemsLeftInside { get; set; }


        [Required(ErrorMessage = "Please enter Depot Representative Name.")]
        public string MT_DepotRepresentative { get; set; }


        [Required(ErrorMessage = "Please enter SecureTech Representative Name.")]
        public string MT_SecureTechRepresentative { get; set; }


        [Required(ErrorMessage = "Please enter MCC Representative Name.")]
        public string MT_MccRepresentative { get; set; }
    }


    
        

    public enum Equipment
    {
        [Display(Name = "Equipment 1")]
        Equipment1,
        [Display(Name = "Equipment 2")]
        Equipment2,
        [Display(Name = "Equipment 3")]
        Equipment3,
        [Display(Name = "Equipment 4")]
        Equipment4
    }

    public enum Measures
    {
        [Display(Name = "Measure 1")]
        Measure1,
        [Display(Name = "Measure 2")]
        Measure2,
        [Display(Name = "Measure 3")]
        Measure3,
        [Display(Name = "Measure 4")]
        Measure4
    }
}