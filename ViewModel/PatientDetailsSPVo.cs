using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_WebAPI.ViewModel
{
    public class PatientDetailsSPVo
    {
        public long PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public decimal? Age { get; set; }
        public string patientMrn { get; set; }
        public string Gender { get; set; }
      
    }
}
