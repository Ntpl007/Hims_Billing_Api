using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//using Hims_Billing_API.View_Model;
using Hims_WebAPI.ViewModel;
using Hims_Billing_API.ViewModel;

#nullable disable

namespace Hims_Billing_API.StoreProcedures
{
    public partial class StoreProceduresContext : DbContext
    {
        public StoreProceduresContext()
        {
        }
        public virtual DbSet<DoctorChargeItemsVo> Sp_GetDotorChargeItemPriceDetails { get; set; }
        public virtual DbSet<SearchPatientVo> SP_GetPatientDetailsById { get; set; }

        public virtual DbSet<ChargeItemVo> SP_GetChargeItemDetails { get; set; }

        public virtual DbSet<PatientDetailsSPVo> GetPatientDetails { get; set; }
        public virtual DbSet<SearchBillingVo> SP_SearchBillingDetails { get; set; }
        public virtual DbSet<SearchBillingVo> SP_SearchBillingsbytoday { get; set; }

        public virtual DbSet<BillingDetailsVo> SP_GetBillDetailsById { get; set; }

        public virtual DbSet<BillingPriceDetailsVo> SP_GetBillPriceDetailsById { get; set; }
        public virtual DbSet<BillSummaryDetailsVo> SP_GetBillingSummaryDetails { get; set; }
        public virtual DbSet<BillSummaryDetailsVo> GetBillingDetailsByEncounterId { get; set; }

        public virtual DbSet<SearchBillingVo> SP_GetBillingDetails { get; set; }
        public StoreProceduresContext(DbContextOptions<StoreProceduresContext> options)
            : base(options)
        {
        }

      
       
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySQL("Server=10.10.20.25;Database=bhishak_app_db; User=root;Password=root@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<SearchPatientVo>(entity =>
            {
                entity.HasNoKey();
            });
            modelBuilder.Entity<ChargeItemVo>(entity =>
            {
                entity.HasNoKey();
            });
            modelBuilder.Entity<PatientDetailsSPVo>(entity =>
            {
                entity.HasNoKey();
            });
            modelBuilder.Entity<SearchBillingVo>(entity =>
            {
                entity.HasNoKey();
            });
            modelBuilder.Entity<BillingDetailsVo>(entity =>
            {
                entity.HasNoKey();
            });
            modelBuilder.Entity<BillingPriceDetailsVo>(entity =>
            {
                entity.HasNoKey();
            });
            modelBuilder.Entity<BillSummaryDetailsVo>(entity =>
            {
                entity.HasNoKey();
            });
            modelBuilder.Entity<DoctorChargeItemsVo>(entity =>
            {
                entity.HasNoKey();
            });
            


            OnModelCreatingPartial(modelBuilder);
            
        }
      

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

       
    }
}
