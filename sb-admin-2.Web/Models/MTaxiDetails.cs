
using System;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class MTaxiDetails
    {
        public int Id { get; set; }
        

        [StringLength(1)]
        public string typeOfMaintenance { get; set; }

        

        //[Required(ErrorMessage = "Please enter Plate Number")]
        
        //public string MT_PlateNumber { get; set; }


        
        [Required(ErrorMessage = "Please enter Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd-mm-yyyy}")]
        public DateTime MT_Date { get; set; }


        private string _MT_PlateNumber;
        private string _Number;

        public string Number
        {
            get
            {
                return _Number;
            }
            set
            {
                _MT_PlateNumber = value;
                _Number = value;
            }
        }


        public string MT_PlateNumber
        {
            get
            {
                return _MT_PlateNumber;
            }
        //    //set { this._whomToMeet = this.Name; }
        }
    }
}