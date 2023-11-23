using Hims_Billing_API.ViewModel;
using Hims_WebAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.Repository
{
    public interface IRepository
    {
        public Task<List<SearchPatientVo>> GetPatientDetailsById(string PatientId);
        public Task<List<ChargeItemVo>> GetAllChargeItemDetails(int OrganizationId, int FacilityId);

        public Task<List<DoctorChargeItemsVo>> GetDoctorChargeItemDetails(int DoctorId,int ChargeItemId, int OrganizationId, int FacilityId);
        public string SaveBillPayments(BillingVo objbill);

        public Task<List<SearchBillingVo>> GetSearchBillingToday(int OrganizationId, int FacilityId);
        public Task<List<SearchBillingVo>> SearchBillingDetails(BillingSearchInput Pinput);

        public Task<List<BillingDetailsVo>> GetBillingDetailsById(int BillId,int EncounterId);
        public Task<List<BillingPriceDetailsVo>> GetBillEntryPriceDetailsById(int BillId);
        public Task<List<BillSummaryDetailsVo>> GetBillSummaryDetailsById(int BillId);

        public Task<List<BillSummaryDetailsVo>> GetBillingDetailsByEncounterId(int EncounterId);

        public Task<List<SearchBillingVo>> GetBillingDetails(int EncounterId);
        public int DeleteBillChargeItemDetailsById(int BillId, int chargeItemId);
    }
}
