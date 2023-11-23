using Hims_Billing_API.BHISHAK_APP_DB;
using Hims_Billing_API.StoreProcedures;
using Hims_Billing_API.ViewModel;
using Hims_WebAPI.ViewModel;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.Repository
{ 
    public class Repositories:IRepository
    {
    private readonly StoreProceduresContext _SPcontext;
    //search patients Details by PatientId
    public Repositories(StoreProceduresContext context)
        {
        _SPcontext = context;
        }
        
        public async Task<List<SearchPatientVo>> GetPatientDetailsById(string PatientId)
        {
            var PatientMrn = new MySqlParameter
                    ("PatientId", PatientId);
            var objList = await _SPcontext.SP_GetPatientDetailsById
               .FromSqlRaw("call SP_GetPatientDetailsById(@PatientId)", PatientMrn).ToListAsync();
            return objList;
        }

        public async Task<List<ChargeItemVo>> GetAllChargeItemDetails(int OrganizationId, int FacilityId)
        {
            var Organization = new MySqlParameter("OrganizationId", OrganizationId);
            var Facility = new MySqlParameter("FacilityId", FacilityId);

            var objchargeItemList = await _SPcontext.SP_GetChargeItemDetails
               .FromSqlRaw("call SP_GetChargeItemDetails(@OrganizationId,@FacilityId)", Organization, Facility).ToListAsync();
            return objchargeItemList.OrderBy(x => x.ChargeItemId).ToList();
        }
        public async Task<List<DoctorChargeItemsVo>> GetDoctorChargeItemDetails(int DoctorId,int ChargeItemId, int OrganizationId, int FacilityId)
        {
            var Doctor = new MySqlParameter("DoctorId", DoctorId);
            var ChargeItem = new MySqlParameter("ChargeItemId", ChargeItemId);
            var Organization = new MySqlParameter("OrganizationId", OrganizationId);
            var Facility = new MySqlParameter("FacilityId", FacilityId);

            var objchargeItemList = await _SPcontext.Sp_GetDotorChargeItemPriceDetails
               .FromSqlRaw("call Sp_GetDotorChargeItemPriceDetails(@DoctorId,@ChargeItemId,@OrganizationId,@FacilityId)",Doctor, ChargeItem, Organization, Facility).ToListAsync();
            return objchargeItemList;
        }
        public string SaveBillPayments(BillingVo objbill)
        {
            int facilitybillCount = 0;
            using (var context = new bhishak_app_dbContext())
            {

                //Saving TblEncounterBilling //vijay

                var finalBillDetails = (from m in context.TblEncounterBillingPayments.Where(x => x.FinalBillingId == Convert.ToInt32(objbill.BillId)) select m).FirstOrDefault();

                TblEncounterBilling objTblEncounter = new TblEncounterBilling();
                
                var tblbilling= (from m in context.TblEncounterBillings.Where(x => x.FinalBillingId == Convert.ToInt32(objbill.BillId)) select m).FirstOrDefault();
                if (tblbilling != null)
                {
                    objTblEncounter.FinalBillingId = (int)finalBillDetails.FinalBillingId;
                    tblbilling.FinalBillingId = (int)finalBillDetails.FinalBillingId;
                    tblbilling.TotalBilledAmount = objbill.TotalAmount;
                    //tblbilling.TotalDiscountAmount = objbill.TotalDiscAmount;
                    tblbilling.TotalDiscountAmount = Convert.ToDecimal(tblbilling.TotalDiscountAmount) + Convert.ToDecimal(objbill.TotalDiscAmount);
                    tblbilling.TotalPaidAmount = Convert.ToDecimal(tblbilling.TotalPaidAmount) + Convert.ToDecimal(objbill.TotalPaidAmount);
                    tblbilling.TotalRefundAmount = objbill.TotalRefundAmount;
                    tblbilling.TotalDue = objbill.TotalDueAmount;
                    tblbilling.PaymentModeId = Convert.ToInt32(objbill.PaymentMode);
                    tblbilling.UpdatedBy = objbill.CreatedBy;
                    tblbilling.UpdatedDate = DateTime.Now;
                    //tblbilling.CreatedBy = objbill.CreatedBy;
                    //tblbilling.CreatedDateTime = DateTime.Now;
                    //context.TblEncounterBillings.Update(objTblEncounter);
                    context.SaveChanges();

                }
                else
                {

                    objTblEncounter.EncounterId = Convert.ToInt64(objbill.EncounterId);
                    objTblEncounter.PatientId = Convert.ToInt64(objbill.PatientId);
                    objTblEncounter.PatientMrn = objbill.PatientMrn;
                    objTblEncounter.TotalBilledAmount = objbill.TotalAmount;
                    objTblEncounter.TotalDiscountAmount = objbill.TotalDiscAmount;
                    objTblEncounter.TotalPaidAmount = objbill.TotalPaidAmount;
                    objTblEncounter.TotalRefundAmount = objbill.TotalRefundAmount;
                    objTblEncounter.TotalDue = objbill.TotalDueAmount;
                    objTblEncounter.OrganizationId = objbill.OrganizationId;
                    objTblEncounter.FacilityId = objbill.FacilityId;
                    objTblEncounter.CreatedBy = objbill.CreatedBy;
                    objTblEncounter.CreatedDateTime = DateTime.Now;
                    objTblEncounter.PaymentModeId = Convert.ToInt32(objbill.PaymentMode);
                    objTblEncounter.CategoryType = "Billing";

                    context.TblEncounterBillings.Add(objTblEncounter);
                    context.SaveChanges();
                }

                //Saving TblEncounterBill //vijay
                 facilitybillCount = (from BillingId in context.TblEncounterBillingPayments.Where(x=>x.OrganizationId == objbill.OrganizationId && x.FacilityId == objbill.FacilityId) select BillingId).Count();
                facilitybillCount = facilitybillCount + 1;
                TblEncounterBillingPayment objTblEncounterBill = new TblEncounterBillingPayment();
                objTblEncounterBill.FinalBillingId = objTblEncounter.FinalBillingId;
                objTblEncounterBill.EncounterId = Convert.ToInt64(objbill.EncounterId);
                objTblEncounterBill.PatientId = Convert.ToInt64(objbill.PatientId);
                objTblEncounterBill.PatientMrn = objbill.PatientMrn;
                objTblEncounterBill.TotalBilledAmount = objbill.TotalAmount;
                objTblEncounterBill.TotalDiscountAmount = objbill.TotalDiscAmount;
                objTblEncounterBill.TotalPaidAmount = objbill.TotalPaidAmount;
                objTblEncounterBill.TotalRefundAmount = objbill.TotalRefundAmount;
                objTblEncounterBill.TotalDue = objbill.TotalDueAmount;
                objTblEncounterBill.PaymentModeId = Convert.ToInt32(objbill.PaymentMode);
                objTblEncounterBill.PaymentRefCode = objbill.RefNo;
                objTblEncounterBill.OrganizationId = objbill.OrganizationId;
                objTblEncounterBill.FacilityId = objbill.FacilityId;
                objTblEncounterBill.RecieptNo = facilitybillCount.ToString();
                objTblEncounterBill.CreatedBy = objbill.CreatedBy;
                objTblEncounterBill.CreatedDateTime = DateTime.Now;
                context.TblEncounterBillingPayments.Add(objTblEncounterBill);
                context.SaveChanges();
                objbill.BillId = objTblEncounterBill.BillingId.ToString();
                TblEncounterBillingEntry objTblAdmEntryForPayment = new TblEncounterBillingEntry();
                if (objbill.BillingDetails!=null)
                {
                    foreach (var item in objbill.BillingDetails)
                    {
                        objTblAdmEntryForPayment.EncounterEntryId = Guid.NewGuid().ToString();
                        objTblAdmEntryForPayment.EncounterId = Convert.ToInt64(objbill.EncounterId);
                        objTblAdmEntryForPayment.PatientId = Convert.ToInt64(objbill.PatientId);
                        objTblAdmEntryForPayment.ChargeItemId = item.ChargeItemId;
                        objTblAdmEntryForPayment.DateOfService = DateTime.Now;
                        objTblAdmEntryForPayment.ProviderId = item.ProviderId;
                        objTblAdmEntryForPayment.NoOfUnits = item.NoOfUnits;
                        objTblAdmEntryForPayment.ChargeAmount = item.UnitPrice;
                        objTblAdmEntryForPayment.ChargeGroupId = (from m in context.TblAdmChargeItems.Where(x => x.ChargeItemId == objTblAdmEntryForPayment.ChargeItemId) select m.ChargeGroupId).FirstOrDefault();
                        objTblAdmEntryForPayment.PaymentModeId = Convert.ToInt32(objbill.PaymentMode);
                        objTblAdmEntryForPayment.PaymentRefCode = objbill.RefNo;
                        objTblAdmEntryForPayment.BillNo = objTblEncounterBill.BillingId;
                        objTblAdmEntryForPayment.PaidAmount = item.PayingAmount;
                        objTblAdmEntryForPayment.Discount = item.DiscountAmount;
                        objTblAdmEntryForPayment.DiscountPercentage = item.DiscountPerc;
                        objTblAdmEntryForPayment.DueAmount = item.UnitPrice-(item.PayingAmount)-(item.DiscountAmount);
                        objTblAdmEntryForPayment.PricePercentage = item.AmountPerc;
                        objTblAdmEntryForPayment.FacilityId = objbill.FacilityId;
                        objTblAdmEntryForPayment.CreatedBy = objbill.CreatedBy;
                        objTblAdmEntryForPayment.CreationDate = DateTime.Now;
                        context.TblEncounterBillingEntries.Add(objTblAdmEntryForPayment);
                        context.SaveChanges();
                    }
                }
               
            }

            //return objbill.BillId;
            return facilitybillCount.ToString();
        }
        //search patients present date
        public async Task<List<SearchBillingVo>> GetSearchBillingToday(int OrganizationId, int FacilityId)
        {
            var organizationId = new MySqlParameter("OrganizationId", OrganizationId);
            var facilityId = new MySqlParameter("FacilityId", FacilityId);
            var objList = await _SPcontext.SP_SearchBillingsbytoday
               .FromSqlRaw("call SP_SearchBillingsbytoday(@OrganizationId,@FacilityId)", organizationId, facilityId).ToListAsync();
            return objList.OrderBy(x => x.OpId).ToList();
        }

        //search patient with filters
        public async Task<List<SearchBillingVo>> SearchBillingDetails(BillingSearchInput Pinput)
        {
            string fromDate = Pinput.FromDate.ToString("yyyy/MM/dd HH:mm:ss");
            string toDate = Pinput.ToDate.ToString("yyyy/MM/dd HH:mm:ss");
            var FromDate = new MySqlParameter("FromDate", fromDate);
            var ToDate = new MySqlParameter("ToDate", toDate);
            var Mobile = new MySqlParameter("MobileNumber", Pinput.MobileNumber);
            var FirstName = new MySqlParameter("FirstName", Pinput.FirstName);
            var OrganizationId = new MySqlParameter("OrganizationId", Pinput.OrganizationId);
            var FacilityId = new MySqlParameter("FacilityId", Pinput.FacilityId);
            var objList = await _SPcontext.SP_SearchBillingDetails
                .FromSqlRaw("call SP_SearchBillingDetails(@FromDate,@ToDate,@MobileNumber,@FirstName,@OrganizationId,@FacilityId)", FromDate, ToDate, Mobile, FirstName,OrganizationId, FacilityId).ToListAsync();
            return objList.OrderBy(x => x.OpId).ToList();

        }

        public async Task<List<BillingDetailsVo>> GetBillingDetailsById(int BillId,int EncounterId)
        {
            var PatientMrn = new MySqlParameter
                    ("BillId", BillId);
            var _EncounterId = new MySqlParameter
                    ("EncounterId", EncounterId);
            var objList = await _SPcontext.SP_GetBillDetailsById
               .FromSqlRaw("call SP_GetBillDetailsById(@EncounterId,@BillId)", _EncounterId,PatientMrn).ToListAsync();
            return objList;
        }
        public async Task<List<BillingPriceDetailsVo>> GetBillEntryPriceDetailsById(int BillId)
        {
            var PatientMrn = new MySqlParameter
                    ("BillId", BillId);
            var objList = await _SPcontext.SP_GetBillPriceDetailsById
               .FromSqlRaw("call SP_GetBillPriceDetailsById(@BillId)", PatientMrn).ToListAsync();
            return objList;
        }

        public async Task<List<BillSummaryDetailsVo>> GetBillSummaryDetailsById(int BillId)
        {
            var PatientMrn = new MySqlParameter
                    ("BillId", BillId);
            var objList = await _SPcontext.SP_GetBillingSummaryDetails
               .FromSqlRaw("call SP_GetBillingSummaryDetails(@BillId)", PatientMrn).ToListAsync();
            return objList;
        }
        public async Task<List<BillSummaryDetailsVo>> GetBillingDetailsByEncounterId(int EncounterId)
        {
            var PatientMrn = new MySqlParameter
                    ("EncounterId", EncounterId);
            var objList = await _SPcontext.GetBillingDetailsByEncounterId
               .FromSqlRaw("call GetBillingDetailsByEncounterId(@EncounterId)", PatientMrn).ToListAsync();
            return objList;
        }
        public async Task<List<SearchBillingVo>> GetBillingDetails(int EncounterId)
        {
            var PatientMrn = new MySqlParameter
                    ("EncounterId", EncounterId);
            var objList = await _SPcontext.SP_GetBillingDetails
               .FromSqlRaw("call SP_GetBillingDetails(@EncounterId)", PatientMrn).ToListAsync();
            return objList;
        }
        public int DeleteBillChargeItemDetailsById(int BillId, int chargeItemId)
        {
            int i = 0;
            using (var context = new bhishak_app_dbContext())
            {
                var tblbilling = (from m in context.TblEncounterBillingPayments.Where(x => x.FinalBillingId == Convert.ToInt32(BillId)) select m).ToList();
                if (tblbilling != null)
                {
                    foreach (var item in tblbilling)
                    {
                        var tblbillingEntries = (from m in context.TblEncounterBillingEntries.Where(x => x.BillNo == Convert.ToInt32(item.BillingId)) select m).ToList();

                        if (tblbillingEntries!=null)
                        {
                            foreach (var chargeItem in tblbillingEntries)
                            {
                               
                                if (chargeItem.ChargeItemId==chargeItemId)
                                {
                                    TblEncounterBillingEntry objTblEncounter = new TblEncounterBillingEntry();
                                    //tblbillingChargeEntries.EncounterEntryId= objTblEncounter.EncounterEntryId ;
                                    chargeItem.IsChargeItemDeleted = true;
                                   // context.TblEncounterBillingEntries.Update(objTblEncounter);
                                    context.SaveChanges();
                                }
                            }
                            
                        }
                    }
                   

                }
            }
            return i;
        }
    }
}
