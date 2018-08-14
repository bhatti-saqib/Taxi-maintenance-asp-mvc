
using System;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class MTaxiDetails
    {
        public int Id { get; set; }
        //public Sites? NT_Sites { get; set; }

        [StringLength(1)]
        public string typeOfMaintenance { get; set; }

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
    }
}