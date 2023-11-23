using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hims_Billing_API.BHISHAK_APP_DB;
using Hims_Billing_API.ViewModel;
using Newtonsoft.Json;

namespace Hims_Billing_API.Repository.OP_Payments_Repository
{
    public class Op_Payments:IOpPayments
    {
        public void SavePayments(PaymentVo[] objpatinput)
        {
           // PaymentVo input = new PaymentVo();
            using (var context = new bhishak_app_dbContext())
            {
                TblEncounterBilling tblEncounterBilling = new TblEncounterBilling();
                
                    tblEncounterBilling.PatientId = (long)objpatinput[0].PatienTId;
                    tblEncounterBilling.PatientMrn = (from x in context.TblPatients where x.PatienTId == (long)objpatinput[0].PatienTId select x.PatienTMrn).First();
                    tblEncounterBilling.EncounterId = objpatinput[0].encounterId;
                    tblEncounterBilling.TotalBilledAmount = objpatinput[0].ChargeAmount - 50;
                    tblEncounterBilling.TotalDiscountAmount = 0;
                    tblEncounterBilling.TotalPaidAmount = objpatinput[0].PaymentAmount - 50;
                    tblEncounterBilling.TotalRefundAmount = 0;
                    tblEncounterBilling.ReferenceNumber = objpatinput[0].ReferenceNo;
                    tblEncounterBilling.TotalDue = (objpatinput[0].ChargeAmount - objpatinput[0].PaymentAmount);
                    tblEncounterBilling.CreatedBy = objpatinput[0].createdBy;
                    tblEncounterBilling.CreatedDateTime = DateTime.Now;
                    tblEncounterBilling.UpdatedDate = DateTime.Now;
                    tblEncounterBilling.UpdatedBy = objpatinput[0].createdBy;
                    tblEncounterBilling.PaymentModeId = objpatinput[0].PaymentModeId;
                    tblEncounterBilling.CategoryType = "Consultation";
                    context.TblEncounterBillings.Add(tblEncounterBilling);
                    context.SaveChanges();
                //}
                //else
                //{
                //    TblEncounterBilling tblEncounterBilling2 = new TblEncounterBilling();
                //    tblEncounterBilling2 = context.TblEncounterBillings.Where(x => x.EncounterId == objpatinput[0].encounterId).FirstOrDefault();
                //    var TotalBilledAmountsum = context.TblEncounterBillingEntries.Where(x => x.EncounterId == objpatinput[0].encounterId).Sum(x => x.ChargeAmount);
                //    var TotalPaidAmountsum = context.TblEncounterBillingEntries.Where(x => x.EncounterId == objpatinput[0].encounterId).Sum(x => x.PaymentAmount);

                //    tblEncounterBilling.PatientId = (long)objpatinput[0].PatienTId;
                //    tblEncounterBilling.PatientMrn = (from x in context.TblPatients where x.PatienTId == (long)objpatinput[0].PatienTId select x.PatienTMrn).First();
                //    tblEncounterBilling.EncounterId = objpatinput[0].encounterId;
                //    tblEncounterBilling.TotalBilledAmount = objpatinput[0].ChargeAmount - 50;
                //    tblEncounterBilling.TotalDiscountAmount = 0;
                //    tblEncounterBilling.TotalPaidAmount = objpatinput[0].PaymentAmount - 50;
                //    tblEncounterBilling.TotalRefundAmount = 0;
                //    tblEncounterBilling.TotalDue = (objpatinput[0].ChargeAmount - objpatinput[0].PaymentAmount);
                //    tblEncounterBilling.CreatedBy = objpatinput[0].createdBy;
                //    tblEncounterBilling.CreatedDateTime = DateTime.Now;
                //    tblEncounterBilling.UpdatedDate = DateTime.Now;
                //    tblEncounterBilling.UpdatedBy = objpatinput[0].createdBy;
                //    tblEncounterBilling.PaymentModeId = objpatinput[0].PaymentModeId;
                //    context.TblEncounterBillings.Update(tblEncounterBilling2);
                //    context.SaveChanges();
                //}

                TblEncounterBillingEntry objTblAdmEntryForPayment = new TblEncounterBillingEntry();

                // objTblAdmEntryForPayment.FacilityId ="Hyderabad";
                objTblAdmEntryForPayment.EncounterEntryId = Guid.NewGuid().ToString();
                objTblAdmEntryForPayment.EncounterId =(long)(objpatinput[0].encounterId);
                //objTblAdmEntryForPayment.IsAuthorisedPayment = true;
                objTblAdmEntryForPayment.ChargeItemId = 725;
                if (objpatinput[0].Comments != null && objpatinput[0].Comments != "")
                {
                    objTblAdmEntryForPayment.Comments = objpatinput[0].Comments;
                }


                //   objTblAdmEntryForPayment.CHARGE_GROUP_ID = (from m in context.TBL_ADM_CHARGE_ITEMs.Where(x => x.CHARGE_ITEM_ID == objTblAdmEntryForPayment.CHARGE_ITEM_ID) select m.CHARGE_GROUP_ID).FirstOrDefault();
                objTblAdmEntryForPayment.CreatedBy = objpatinput[0].createdBy;
                objTblAdmEntryForPayment.CreationDate = System.DateTime.Now;
                objTblAdmEntryForPayment.DateOfService = DateTime.Now;
                objTblAdmEntryForPayment.NoOfUnits = 0;
                // objTblAdmEntryForPayment.PAYMENT_MODE_ID = 1;
                if(objpatinput[0].PaymentModeId!=0 && objpatinput[0].PaymentModeId!=null)
                {
                    objTblAdmEntryForPayment.PaymentModeId = objpatinput[0].PaymentModeId;
                }

                if (objpatinput[0].PaymentCategoryId != 0)
                {
                    objTblAdmEntryForPayment.PaymentCategoryId = objpatinput[0].PaymentCategoryId;
                }

                objTblAdmEntryForPayment.ChargeAmount= objpatinput[0].ChargeAmount;

                objTblAdmEntryForPayment.BillNo = tblEncounterBilling.FinalBillingId;

                objTblAdmEntryForPayment.PaymentAmount = Convert.ToDecimal(objpatinput[0].PaymentAmount);


                objTblAdmEntryForPayment.PatientId = (long)objpatinput[0].PatienTId;
                objTblAdmEntryForPayment.ProviderId = Convert.ToInt32(objpatinput[0].DoctorId);
                if (objpatinput[0].RefDoctorId != null)
                {
                    objTblAdmEntryForPayment.ReferringPhysicianId = objpatinput[0].RefDoctorId;

                }

               
                {
                    context.TblEncounterBillingEntries.Add(objTblAdmEntryForPayment);
                    context.SaveChanges();
                }
               
                string PaymentEntryId = objTblAdmEntryForPayment.EncounterEntryId;
                //if (objAdmissionVo.IsFreeConsultation != true)
                {
                    //  objEncEntryVo.EncounterEntryId = PaymentEntryId;
                    //  List<TBL_ENCOUNTER_BILLING_PAYMENTS_AGAINST_CAHRGE_ITEM_LINK> list_tbl_payment_against_link = new List<TBL_ENCOUNTER_BILLING_PAYMENTS_AGAINST_CAHRGE_ITEM_LINK>();
                    TblEncounterBillingPaymentsAgainstCahrgeItemLink tbl_payment_against_link = new TblEncounterBillingPaymentsAgainstCahrgeItemLink();
                    tbl_payment_against_link.PaymentBillingEntryId = PaymentEntryId;
                    tbl_payment_against_link.PaymentAgainstBillingEntryId = Guid.NewGuid().ToString();
                    tbl_payment_against_link.ChargeItemId = 1;//context.TBL_ENCOUNTER_BILLING_ENTRies.Where(x => x.ENCOUNTER_ENTRY_ID == tbl_payment_against_link.PAYMENT_AGAINST_BILLING_ENTRY_ID).FirstOrDefault().CHARGE_ITEM_ID;
                    tbl_payment_against_link.EncounterId = (long)objpatinput[0].encounterId;
                    if (objpatinput[0].PaymentAmount != null)
                    {
                        tbl_payment_against_link.PaidAmount = objpatinput[0].PaymentAmount;
                    }
                    else
                    {
                        tbl_payment_against_link.PaidAmount = 0;
                    }

                    context.TblEncounterBillingPaymentsAgainstCahrgeItemLinks.Add(tbl_payment_against_link);
                    context.SaveChanges();

                }

                
            }
           


        }

       

    }

}

