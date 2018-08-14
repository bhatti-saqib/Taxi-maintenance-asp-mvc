
using System;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class MSignOffDetails
    {
        //[Required(ErrorMessage = "Please enter Depot Representative Name.")]
        public bool? Is_MT_DepotRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter SecureTech Representative Name.")]
        public bool? Is_MT_SecureTechRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter MCC Representative Name.")]
        public bool? Is_MT_MccRepApproved { get; set; }
    }
}