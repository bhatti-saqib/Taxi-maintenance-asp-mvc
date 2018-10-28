using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sb_admin_2.Web.Models
{
    public class CorrectiveMeasure
    {
        public string MT_Equ_For_Corr_Measure { get; set; }

        public string MT_Corr_Measure_Taken { get; set; }

        public string MT_Comment_Box_For_Technicians { get; set; }

        public string MT_Old_SerialNo_If_Replaced { get; set; }
    }
}