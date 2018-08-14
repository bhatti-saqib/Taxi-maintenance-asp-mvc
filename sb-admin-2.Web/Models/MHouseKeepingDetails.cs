
using System;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class MHouseKeepingDetails
    {
        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_TaxiHandover { get; set; }


        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_NoExistingAlarms { get; set; }

        [Required(ErrorMessage = "-- Please Select --")]
        public string MT_OverallFeedback { get; set; }

    }
}