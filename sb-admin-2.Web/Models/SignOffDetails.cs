using System;
using System.ComponentModel.DataAnnotations;


namespace sb_admin_2.Web.Models
{
    public class SignOffDetails
    {
        //[Required(ErrorMessage = "Please enter Depot Representative Name.")]
        public bool? Is_NT_DepotRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter SecureTech Representative Name.")]
        public bool? Is_NT_SecureTechRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter MCC Representative Name.")]
        public bool? Is_NT_MccRepApproved { get; set; }
    }
}