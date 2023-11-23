using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hims_Billing_API.Management.OP_Payments_Management;
using Microsoft.AspNetCore.Authorization;
using Hims_WebAPI.ViewModel;
using Hims_Billing_API.Repository;
using Hims_Billing_API.ViewModel;

namespace Hims_Billing_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IRepository _repository;
        public PaymentsController(IRepository repository)
        {
            _repository = repository;
        }

        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<SearchPatientVo>> GetPatientDetailsById(string PatientId)
        {
            var response = await _repository.GetPatientDetailsById(PatientId);
            return response;

        }
        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<ChargeItemVo>> GetAllChargeItemDetails(int OrganizationId, int FacilityId)
        {
            var response = await _repository.GetAllChargeItemDetails(OrganizationId, FacilityId);
            return response;

        }

        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<DoctorChargeItemsVo>> GetDoctorChargeItemDetails(int DoctorId, int ChargeItemId, int OrganizationId, int FacilityId)
        {
            var response = await _repository.GetDoctorChargeItemDetails(DoctorId, ChargeItemId, OrganizationId, FacilityId);
            return response;

        }
        [EnableCors("AllowAllHeaders")]
        [HttpPost]
        [Route("[action]")]
        public string saveBillingPayments(BillingVo objbill)
        {

            var response = _repository.SaveBillPayments(objbill);
            return response;


        }
        [EnableCors("AllowAllHeaders")]
        [HttpPost]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<SearchBillingVo>> SearchBillingDetails(BillingSearchInput Pinput)
        {

            var response = await _repository.SearchBillingDetails(Pinput);
            return response;


        }

        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<SearchBillingVo>> GetSearchBillingToday(int OrganizationId, int FacilityId)
        {
            var response = await _repository.GetSearchBillingToday(OrganizationId, FacilityId);
            return response;

        }

        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<BillingDetailsVo>> GetAllBillEntryDetails(int BillId, int EncounterId)
        {
            var response = await _repository.GetBillingDetailsById(BillId, EncounterId);
            return response;

        }
        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<BillingPriceDetailsVo>> GetBillEntryPriceDetails(int BillId)
        {
            var response = await _repository.GetBillEntryPriceDetailsById(BillId);
            return response;

        }
        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<BillSummaryDetailsVo>> GetBillSummaryDetails(int BillId)
        {
            var response = await _repository.GetBillSummaryDetailsById(BillId);
            return response;

        }
        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<BillSummaryDetailsVo>> GetBillingDetailsByEncounterId(int encounterId)
        {
            var response = await _repository.GetBillingDetailsByEncounterId(encounterId);
            return response;

        }
        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        //[Authorize]
        public async Task<List<SearchBillingVo>> GetBillinDetails(int EncounterId)
        {
            var response = await _repository.GetBillingDetails(EncounterId);
            return response;

        }

        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        public int DeleteBillServiceDetails(int BillId, int chargeItemId)
        {

            var response = _repository.DeleteBillChargeItemDetailsById(BillId, chargeItemId);
            return response;


        }
        [EnableCors("AllowAllHeaders")]
        [HttpPost]
        [Route("[action]")]
        public void SavePayments(PaymentVo[] objpatinput)
        {
            OpPayments obj = new OpPayments();
            obj.SavePayments(objpatinput);
        }
    }
}
