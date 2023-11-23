using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.ViewModel
{
    public class SearchBillingVo
    {
        public string BillId { get; set; }
        public string PatientId { get; set; }
        public string EncounterId { get; set; }
        public string PatientMrn { get; set; }
        public string Name { get; set; }
        public string OpId { get; set; }
        public decimal? Age { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string Occupation { get; set; }
        public string ReligionName { get; set; }
        public string DoctorName { get; set; }
       // public string ReferalDoctor { get; set; }
       // public string Corporate { get; set; }
        //public string AgeModeId { get; set; }
       // public string EncounterId { get; set; }
        public int? DoctorId { get; set; }
        //public int? RefPhysicianId { get; set; }
    }
}
