using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SMS.Models
{
    public partial class DEV_SMS_ver2Context : DbContext
    {
        public DEV_SMS_ver2Context()
        {
        }

        public DEV_SMS_ver2Context(DbContextOptions<DEV_SMS_ver2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<LkpAbsenceReasons> LkpAbsenceReasons { get; set; }
        public virtual DbSet<LkpAcademicYearExams> LkpAcademicYearExams { get; set; }
        public virtual DbSet<LkpAcademicYears> LkpAcademicYears { get; set; }
        public virtual DbSet<LkpAccAccountCategories> LkpAccAccountCategories { get; set; }
        public virtual DbSet<LkpAccAccountClassificationTypes> LkpAccAccountClassificationTypes { get; set; }
        public virtual DbSet<LkpAccAccountPayableTypes> LkpAccAccountPayableTypes { get; set; }
        public virtual DbSet<LkpAccAccountPositionTypes> LkpAccAccountPositionTypes { get; set; }
        public virtual DbSet<LkpAccAccountSegments> LkpAccAccountSegments { get; set; }
        public virtual DbSet<LkpAccAccountTypes> LkpAccAccountTypes { get; set; }
        public virtual DbSet<LkpAccFixedAccounts> LkpAccFixedAccounts { get; set; }
        public virtual DbSet<LkpAccJournalGenerationTypes> LkpAccJournalGenerationTypes { get; set; }
        public virtual DbSet<LkpAccTreasuries> LkpAccTreasuries { get; set; }
        public virtual DbSet<LkpAccTreasuryCurrencies> LkpAccTreasuryCurrencies { get; set; }
        public virtual DbSet<LkpActivity> LkpActivity { get; set; }
        public virtual DbSet<LkpActivitySubjects> LkpActivitySubjects { get; set; }
        public virtual DbSet<LkpAdtActions> LkpAdtActions { get; set; }
        public virtual DbSet<LkpAdtDepartments> LkpAdtDepartments { get; set; }
        public virtual DbSet<LkpAdtFields> LkpAdtFields { get; set; }
        public virtual DbSet<LkpAdtModules> LkpAdtModules { get; set; }
        public virtual DbSet<LkpAdtSections> LkpAdtSections { get; set; }
        public virtual DbSet<LkpAdtSubModules> LkpAdtSubModules { get; set; }
        public virtual DbSet<LkpAreas> LkpAreas { get; set; }
        public virtual DbSet<LkpAstAssetActionTypes> LkpAstAssetActionTypes { get; set; }
        public virtual DbSet<LkpAstAssetCategories> LkpAstAssetCategories { get; set; }
        public virtual DbSet<LkpAstAssetItemTypes> LkpAstAssetItemTypes { get; set; }
        public virtual DbSet<LkpAstAssetStates> LkpAstAssetStates { get; set; }
        public virtual DbSet<LkpAstAssetTypes> LkpAstAssetTypes { get; set; }
        public virtual DbSet<LkpAstDepreciationCalculationTypes> LkpAstDepreciationCalculationTypes { get; set; }
        public virtual DbSet<LkpBankAccounts> LkpBankAccounts { get; set; }
        public virtual DbSet<LkpBanks> LkpBanks { get; set; }
        public virtual DbSet<LkpBookingFunctions> LkpBookingFunctions { get; set; }
        public virtual DbSet<LkpBookingStates> LkpBookingStates { get; set; }
        public virtual DbSet<LkpBookingTrackingStates> LkpBookingTrackingStates { get; set; }
        public virtual DbSet<LkpBookingTypes> LkpBookingTypes { get; set; }
        public virtual DbSet<LkpBranches> LkpBranches { get; set; }
        public virtual DbSet<LkpCargoCategories> LkpCargoCategories { get; set; }
        public virtual DbSet<LkpClasses> LkpClasses { get; set; }
        public virtual DbSet<LkpClientFunctions> LkpClientFunctions { get; set; }
        public virtual DbSet<LkpClientStatus> LkpClientStatus { get; set; }
        public virtual DbSet<LkpColorDegrees> LkpColorDegrees { get; set; }
        public virtual DbSet<LkpCommodities> LkpCommodities { get; set; }
        public virtual DbSet<LkpContactPersonTypes> LkpContactPersonTypes { get; set; }
        public virtual DbSet<LkpContactTypes> LkpContactTypes { get; set; }
        public virtual DbSet<LkpContainerLoadTypes> LkpContainerLoadTypes { get; set; }
        public virtual DbSet<LkpContainerSizes> LkpContainerSizes { get; set; }
        public virtual DbSet<LkpContainerTypes> LkpContainerTypes { get; set; }
        public virtual DbSet<LkpCountries> LkpCountries { get; set; }
        public virtual DbSet<LkpCurrencies> LkpCurrencies { get; set; }
        public virtual DbSet<LkpDateFormats> LkpDateFormats { get; set; }
        public virtual DbSet<LkpDebitTypes> LkpDebitTypes { get; set; }
        public virtual DbSet<LkpDeliveryTerms> LkpDeliveryTerms { get; set; }
        public virtual DbSet<LkpDepartments> LkpDepartments { get; set; }
        public virtual DbSet<LkpDiseaseTypes> LkpDiseaseTypes { get; set; }
        public virtual DbSet<LkpEmployeeFunctions> LkpEmployeeFunctions { get; set; }
        public virtual DbSet<LkpEmployeeJobCategories> LkpEmployeeJobCategories { get; set; }
        public virtual DbSet<LkpEmployeeJobs> LkpEmployeeJobs { get; set; }
        public virtual DbSet<LkpEmploymentTypes> LkpEmploymentTypes { get; set; }
        public virtual DbSet<LkpEndedSubjectGroups> LkpEndedSubjectGroups { get; set; }
        public virtual DbSet<LkpEventStates> LkpEventStates { get; set; }
        public virtual DbSet<LkpExams> LkpExams { get; set; }
        public virtual DbSet<LkpExpenseTypes> LkpExpenseTypes { get; set; }
        public virtual DbSet<LkpExpensesTypeActivities> LkpExpensesTypeActivities { get; set; }
        public virtual DbSet<LkpFinancialYears> LkpFinancialYears { get; set; }
        public virtual DbSet<LkpFreightTypes> LkpFreightTypes { get; set; }
        public virtual DbSet<LkpGenderTypes> LkpGenderTypes { get; set; }
        public virtual DbSet<LkpGeneralEvaluations> LkpGeneralEvaluations { get; set; }
        public virtual DbSet<LkpGovernerates> LkpGovernerates { get; set; }
        public virtual DbSet<LkpGrades> LkpGrades { get; set; }
        public virtual DbSet<LkpGradesParentNotifications> LkpGradesParentNotifications { get; set; }
        public virtual DbSet<LkpHouseConsolidationCodes> LkpHouseConsolidationCodes { get; set; }
        public virtual DbSet<LkpHrreportFunctions> LkpHrreportFunctions { get; set; }
        public virtual DbSet<LkpHrstages> LkpHrstages { get; set; }
        public virtual DbSet<LkpHrstatisticReportFunctions> LkpHrstatisticReportFunctions { get; set; }
        public virtual DbSet<LkpHscodes> LkpHscodes { get; set; }
        public virtual DbSet<LkpImoclasses> LkpImoclasses { get; set; }
        public virtual DbSet<LkpInvoicePaymentMethods> LkpInvoicePaymentMethods { get; set; }
        public virtual DbSet<LkpInvoicePaymentStates> LkpInvoicePaymentStates { get; set; }
        public virtual DbSet<LkpInvoiceTo> LkpInvoiceTo { get; set; }
        public virtual DbSet<LkpInvoiceTypeCurrencies> LkpInvoiceTypeCurrencies { get; set; }
        public virtual DbSet<LkpInvoiceTypes> LkpInvoiceTypes { get; set; }
        public virtual DbSet<LkpJobs> LkpJobs { get; set; }
        public virtual DbSet<LkpLanguages> LkpLanguages { get; set; }
        public virtual DbSet<LkpLocations> LkpLocations { get; set; }
        public virtual DbSet<LkpMaritalStates> LkpMaritalStates { get; set; }
        public virtual DbSet<LkpMilitaryStates> LkpMilitaryStates { get; set; }
        public virtual DbSet<LkpMonthDegreeFunctions> LkpMonthDegreeFunctions { get; set; }
        public virtual DbSet<LkpMonths> LkpMonths { get; set; }
        public virtual DbSet<LkpNationalities> LkpNationalities { get; set; }
        public virtual DbSet<LkpOverduePeriods> LkpOverduePeriods { get; set; }
        public virtual DbSet<LkpPackageTypes> LkpPackageTypes { get; set; }
        public virtual DbSet<LkpParentStates> LkpParentStates { get; set; }
        public virtual DbSet<LkpPaymentDiscountTypes> LkpPaymentDiscountTypes { get; set; }
        public virtual DbSet<LkpPaymentMethods> LkpPaymentMethods { get; set; }
        public virtual DbSet<LkpPaymentPortionTypes> LkpPaymentPortionTypes { get; set; }
        public virtual DbSet<LkpPaymentStates> LkpPaymentStates { get; set; }
        public virtual DbSet<LkpPermissions> LkpPermissions { get; set; }
        public virtual DbSet<LkpPorts> LkpPorts { get; set; }
        public virtual DbSet<LkpQualifications> LkpQualifications { get; set; }
        public virtual DbSet<LkpReceivingTerms> LkpReceivingTerms { get; set; }
        public virtual DbSet<LkpReligions> LkpReligions { get; set; }
        public virtual DbSet<LkpReportHeaders> LkpReportHeaders { get; set; }
        public virtual DbSet<LkpReportsDegreeFunctions> LkpReportsDegreeFunctions { get; set; }
        public virtual DbSet<LkpReportsHeaderSemesters> LkpReportsHeaderSemesters { get; set; }
        public virtual DbSet<LkpReportsSecretaryFunctions> LkpReportsSecretaryFunctions { get; set; }
        public virtual DbSet<LkpSalesRegions> LkpSalesRegions { get; set; }
        public virtual DbSet<LkpSalesTargetStates> LkpSalesTargetStates { get; set; }
        public virtual DbSet<LkpSalesTargetTypes> LkpSalesTargetTypes { get; set; }
        public virtual DbSet<LkpSeatReportsFunctions> LkpSeatReportsFunctions { get; set; }
        public virtual DbSet<LkpSections> LkpSections { get; set; }
        public virtual DbSet<LkpSemesters> LkpSemesters { get; set; }
        public virtual DbSet<LkpServiceTypes> LkpServiceTypes { get; set; }
        public virtual DbSet<LkpServices> LkpServices { get; set; }
        public virtual DbSet<LkpSettingTypes> LkpSettingTypes { get; set; }
        public virtual DbSet<LkpStages> LkpStages { get; set; }
        public virtual DbSet<LkpStudentFunctions> LkpStudentFunctions { get; set; }
        public virtual DbSet<LkpStudentResponsibleRelations> LkpStudentResponsibleRelations { get; set; }
        public virtual DbSet<LkpStudentStates> LkpStudentStates { get; set; }
        public virtual DbSet<LkpSubActivity> LkpSubActivity { get; set; }
        public virtual DbSet<LkpSubjects> LkpSubjects { get; set; }
        public virtual DbSet<LkpSupplierFunctions> LkpSupplierFunctions { get; set; }
        public virtual DbSet<LkpTafkitas> LkpTafkitas { get; set; }
        public virtual DbSet<LkpTeachingSubjects> LkpTeachingSubjects { get; set; }
        public virtual DbSet<LkpTermDegreeFunctions> LkpTermDegreeFunctions { get; set; }
        public virtual DbSet<LkpThemes> LkpThemes { get; set; }
        public virtual DbSet<LkpTimeZones> LkpTimeZones { get; set; }
        public virtual DbSet<LkpToWhomItMayConcerns> LkpToWhomItMayConcerns { get; set; }
        public virtual DbSet<LkpTransitTypes> LkpTransitTypes { get; set; }
        public virtual DbSet<LkpTransportTypes> LkpTransportTypes { get; set; }
        public virtual DbSet<LkpUnitTypes> LkpUnitTypes { get; set; }
        public virtual DbSet<LkpUnits> LkpUnits { get; set; }
        public virtual DbSet<LkpVacationCategories> LkpVacationCategories { get; set; }
        public virtual DbSet<LkpVacationStates> LkpVacationStates { get; set; }
        public virtual DbSet<LkpVacationTypes> LkpVacationTypes { get; set; }
        public virtual DbSet<LkpWaitingListReports> LkpWaitingListReports { get; set; }
        public virtual DbSet<LkpWaitingListStates> LkpWaitingListStates { get; set; }
        public virtual DbSet<LkpWithholdingTaxTypes> LkpWithholdingTaxTypes { get; set; }
        public virtual DbSet<TblAccAccountBalances> TblAccAccountBalances { get; set; }
        public virtual DbSet<TblAccAccountCurrencyLinks> TblAccAccountCurrencyLinks { get; set; }
        public virtual DbSet<TblAccAccountLinks> TblAccAccountLinks { get; set; }
        public virtual DbSet<TblAccAccountPayableDetails> TblAccAccountPayableDetails { get; set; }
        public virtual DbSet<TblAccAccountPayableJournals> TblAccAccountPayableJournals { get; set; }
        public virtual DbSet<TblAccAccountPayables> TblAccAccountPayables { get; set; }
        public virtual DbSet<TblAccAccounts> TblAccAccounts { get; set; }
        public virtual DbSet<TblAccExchangeRates> TblAccExchangeRates { get; set; }
        public virtual DbSet<TblAccJournalAttachments> TblAccJournalAttachments { get; set; }
        public virtual DbSet<TblAccJournalDetails> TblAccJournalDetails { get; set; }
        public virtual DbSet<TblAccJournals> TblAccJournals { get; set; }
        public virtual DbSet<TblAccSupplierInvoiceAttachments> TblAccSupplierInvoiceAttachments { get; set; }
        public virtual DbSet<TblAccSupplierInvoiceDetails> TblAccSupplierInvoiceDetails { get; set; }
        public virtual DbSet<TblAccSupplierInvoiceJournals> TblAccSupplierInvoiceJournals { get; set; }
        public virtual DbSet<TblAccSupplierInvoices> TblAccSupplierInvoices { get; set; }
        public virtual DbSet<TblAccountPayableSupplierInvoiceLinks> TblAccountPayableSupplierInvoiceLinks { get; set; }
        public virtual DbSet<TblAccountShareSettings> TblAccountShareSettings { get; set; }
        public virtual DbSet<TblAccountUserDefinedSharePercentages> TblAccountUserDefinedSharePercentages { get; set; }
        public virtual DbSet<TblAstAssetActionJournals> TblAstAssetActionJournals { get; set; }
        public virtual DbSet<TblAstAssetActions> TblAstAssetActions { get; set; }
        public virtual DbSet<TblAstAssetDepreciationPeriods> TblAstAssetDepreciationPeriods { get; set; }
        public virtual DbSet<TblAstAssetDepreciations> TblAstAssetDepreciations { get; set; }
        public virtual DbSet<TblAstAssets> TblAstAssets { get; set; }
        public virtual DbSet<TblAuditTrails> TblAuditTrails { get; set; }
        public virtual DbSet<TblBookingAttachments> TblBookingAttachments { get; set; }
        public virtual DbSet<TblBookingDetails> TblBookingDetails { get; set; }
        public virtual DbSet<TblBookingSharing> TblBookingSharing { get; set; }
        public virtual DbSet<TblBookingTracking> TblBookingTracking { get; set; }
        public virtual DbSet<TblBookingTrucking> TblBookingTrucking { get; set; }
        public virtual DbSet<TblBookings> TblBookings { get; set; }
        public virtual DbSet<TblClientContactPersons> TblClientContactPersons { get; set; }
        public virtual DbSet<TblClientRateAgreementContainers> TblClientRateAgreementContainers { get; set; }
        public virtual DbSet<TblClientRateAgreements> TblClientRateAgreements { get; set; }
        public virtual DbSet<TblClientSalesTargets> TblClientSalesTargets { get; set; }
        public virtual DbSet<TblClients> TblClients { get; set; }
        public virtual DbSet<TblCmPatches> TblCmPatches { get; set; }
        public virtual DbSet<TblCmVersions> TblCmVersions { get; set; }
        public virtual DbSet<TblContractedLineCurrencies> TblContractedLineCurrencies { get; set; }
        public virtual DbSet<TblContractedLines> TblContractedLines { get; set; }
        public virtual DbSet<TblCreditNoteInvoiceLinks> TblCreditNoteInvoiceLinks { get; set; }
        public virtual DbSet<TblDebitNoteDetails> TblDebitNoteDetails { get; set; }
        public virtual DbSet<TblDebitNoteJournals> TblDebitNoteJournals { get; set; }
        public virtual DbSet<TblDebitNotes> TblDebitNotes { get; set; }
        public virtual DbSet<TblEmployeeAttachments> TblEmployeeAttachments { get; set; }
        public virtual DbSet<TblEmployeeTeachingSubjects> TblEmployeeTeachingSubjects { get; set; }
        public virtual DbSet<TblEmployeeVacations> TblEmployeeVacations { get; set; }
        public virtual DbSet<TblEmployees> TblEmployees { get; set; }
        public virtual DbSet<TblExpenses> TblExpenses { get; set; }
        public virtual DbSet<TblGlobalSettings> TblGlobalSettings { get; set; }
        public virtual DbSet<TblInvoiceDetails> TblInvoiceDetails { get; set; }
        public virtual DbSet<TblInvoiceJournals> TblInvoiceJournals { get; set; }
        public virtual DbSet<TblInvoicePaymentDetails> TblInvoicePaymentDetails { get; set; }
        public virtual DbSet<TblInvoicePaymentJournals> TblInvoicePaymentJournals { get; set; }
        public virtual DbSet<TblInvoicePaymentLinks> TblInvoicePaymentLinks { get; set; }
        public virtual DbSet<TblInvoicePayments> TblInvoicePayments { get; set; }
        public virtual DbSet<TblInvoices> TblInvoices { get; set; }
        public virtual DbSet<TblMembers> TblMembers { get; set; }
        public virtual DbSet<TblMembersPayments> TblMembersPayments { get; set; }
        public virtual DbSet<TblPricingListPrices> TblPricingListPrices { get; set; }
        public virtual DbSet<TblPricingListTransitPorts> TblPricingListTransitPorts { get; set; }
        public virtual DbSet<TblPricingLists> TblPricingLists { get; set; }
        public virtual DbSet<TblQuoteDetails> TblQuoteDetails { get; set; }
        public virtual DbSet<TblQuoteServices> TblQuoteServices { get; set; }
        public virtual DbSet<TblQuotes> TblQuotes { get; set; }
        public virtual DbSet<TblReportSettings> TblReportSettings { get; set; }
        public virtual DbSet<TblRoleComponents> TblRoleComponents { get; set; }
        public virtual DbSet<TblRoleModules> TblRoleModules { get; set; }
        public virtual DbSet<TblRoleServices> TblRoleServices { get; set; }
        public virtual DbSet<TblRoleSystems> TblRoleSystems { get; set; }
        public virtual DbSet<TblRoles> TblRoles { get; set; }
        public virtual DbSet<TblRptDatasourceFields> TblRptDatasourceFields { get; set; }
        public virtual DbSet<TblRptDatasourceTypes> TblRptDatasourceTypes { get; set; }
        public virtual DbSet<TblRptDatasources> TblRptDatasources { get; set; }
        public virtual DbSet<TblRptLocalization> TblRptLocalization { get; set; }
        public virtual DbSet<TblRptReportDataSources> TblRptReportDataSources { get; set; }
        public virtual DbSet<TblRptReports> TblRptReports { get; set; }
        public virtual DbSet<TblRptSpparameters> TblRptSpparameters { get; set; }
        public virtual DbSet<TblSemesterAbsencePeriods> TblSemesterAbsencePeriods { get; set; }
        public virtual DbSet<TblSemesterSubjectSettings> TblSemesterSubjectSettings { get; set; }
        public virtual DbSet<TblServicePrices> TblServicePrices { get; set; }
        public virtual DbSet<TblServiceProviderAttachments> TblServiceProviderAttachments { get; set; }
        public virtual DbSet<TblServiceProviders> TblServiceProviders { get; set; }
        public virtual DbSet<TblSettings> TblSettings { get; set; }
        public virtual DbSet<TblShipOwnerTest> TblShipOwnerTest { get; set; }
        public virtual DbSet<TblShipTest> TblShipTest { get; set; }
        public virtual DbSet<TblShipTypeTest> TblShipTypeTest { get; set; }
        public virtual DbSet<TblStudentAbsences> TblStudentAbsences { get; set; }
        public virtual DbSet<TblStudentAcademicYears> TblStudentAcademicYears { get; set; }
        public virtual DbSet<TblStudentAttachments> TblStudentAttachments { get; set; }
        public virtual DbSet<TblStudentContacts> TblStudentContacts { get; set; }
        public virtual DbSet<TblStudentDegrees> TblStudentDegrees { get; set; }
        public virtual DbSet<TblStudentExams> TblStudentExams { get; set; }
        public virtual DbSet<TblStudentMedicalHistories> TblStudentMedicalHistories { get; set; }
        public virtual DbSet<TblStudentPaymentReceivables> TblStudentPaymentReceivables { get; set; }
        public virtual DbSet<TblStudentPayments> TblStudentPayments { get; set; }
        public virtual DbSet<TblStudentSemesters> TblStudentSemesters { get; set; }
        public virtual DbSet<TblStudentSisters> TblStudentSisters { get; set; }
        public virtual DbSet<TblStudentSubjects> TblStudentSubjects { get; set; }
        public virtual DbSet<TblStudentWaitingListSisters> TblStudentWaitingListSisters { get; set; }
        public virtual DbSet<TblStudentWaitingLists> TblStudentWaitingLists { get; set; }
        public virtual DbSet<TblStudents> TblStudents { get; set; }
        public virtual DbSet<TblSubActivitiesSharePercentageSettings> TblSubActivitiesSharePercentageSettings { get; set; }
        public virtual DbSet<TblSupplierContactPersons> TblSupplierContactPersons { get; set; }
        public virtual DbSet<TblTransferJournals> TblTransferJournals { get; set; }
        public virtual DbSet<TblTransfers> TblTransfers { get; set; }
        public virtual DbSet<TblUmComponents> TblUmComponents { get; set; }
        public virtual DbSet<TblUmModules> TblUmModules { get; set; }
        public virtual DbSet<TblUmServiceUrls> TblUmServiceUrls { get; set; }
        public virtual DbSet<TblUmServices> TblUmServices { get; set; }
        public virtual DbSet<TblUmSystems> TblUmSystems { get; set; }
        public virtual DbSet<TblUserAbsenceResonsibleGrades> TblUserAbsenceResonsibleGrades { get; set; }
        public virtual DbSet<TblUserClasses> TblUserClasses { get; set; }
        public virtual DbSet<TblUserEvents> TblUserEvents { get; set; }
        public virtual DbSet<TblUserRoles> TblUserRoles { get; set; }
        public virtual DbSet<TblUserSubjects> TblUserSubjects { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }
        public virtual DbSet<ViwLkpCurrencies> ViwLkpCurrencies { get; set; }
        public virtual DbSet<ViwLkpGrades> ViwLkpGrades { get; set; }
        public virtual DbSet<ViwTblAccAccounts> ViwTblAccAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=52.40.201.149,2050;Database=DEV_SMS_ver2;User Id=itspark;Password=itspark123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LkpAbsenceReasons>(entity =>
            {
                entity.HasKey(e => e.AbsentReasonId)
                    .HasName("PK_lkp_AbsenceReasons_AbsentReasonID");

                entity.ToTable("lkp_AbsenceReasons");

                entity.Property(e => e.AbsentReasonId).HasColumnName("AbsentReasonID");

                entity.Property(e => e.ConsideredAsAbsentDay)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAcademicYearExams>(entity =>
            {
                entity.HasKey(e => e.AcademicYearExamId)
                    .HasName("PK_lkp_AcademicYearExams_AcademicYearExamID");

                entity.ToTable("lkp_AcademicYearExams");

                entity.Property(e => e.AcademicYearExamId).HasColumnName("AcademicYearExamID");

                entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.LkpAcademicYearExams)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.LkpAcademicYearExams)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpAcademicYears>(entity =>
            {
                entity.HasKey(e => e.AcademicYearId)
                    .HasName("PK_lkp_AcademicYears_AcademicYearID");

                entity.ToTable("lkp_AcademicYears");

                entity.HasIndex(e => e.Year)
                    .HasName("UC_lkp_AcademicYears_Year")
                    .IsUnique();

                entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DateOfSummerExams)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAccAccountCategories>(entity =>
            {
                entity.HasKey(e => e.AccountCategoryId)
                    .HasName("PK_lkp_acc_AccountCategories_AccountCategoryID");

                entity.ToTable("lkp_acc_AccountCategories");

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.AccountPositionTypeId).HasColumnName("AccountPositionTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TotalTitleAr).HasMaxLength(100);

                entity.Property(e => e.TotalTitleEn).HasMaxLength(100);

                entity.Property(e => e.TshapeDisplayOrder).HasColumnName("TShapeDisplayOrder");
            });

            modelBuilder.Entity<LkpAccAccountClassificationTypes>(entity =>
            {
                entity.HasKey(e => e.AccountClassificationTypeId)
                    .HasName("PK_lkp_acc_AccountClassificationTypes_AccountClassificationTypeID");

                entity.ToTable("lkp_acc_AccountClassificationTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_acc_AccountClassificationTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.AccountClassificationTypeId)
                    .HasColumnName("AccountClassificationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAccAccountPayableTypes>(entity =>
            {
                entity.HasKey(e => e.AccountPayableTypeId)
                    .HasName("PK_lkp_acc_AccountPayableTypes_AccountPayableTypeID");

                entity.ToTable("lkp_acc_AccountPayableTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_acc_AccountPayableTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.AccountPayableTypeId)
                    .HasColumnName("AccountPayableTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ResetPayablePrefix)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAccAccountPositionTypes>(entity =>
            {
                entity.HasKey(e => e.AccountPositionTypeId)
                    .HasName("PK_lkp_acc_AccountPositionTypes_AccountPositionTypeID");

                entity.ToTable("lkp_acc_AccountPositionTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_acc_AccountPositionTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.AccountPositionTypeId)
                    .HasColumnName("AccountPositionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAccAccountSegments>(entity =>
            {
                entity.HasKey(e => e.AccountSegmentId)
                    .HasName("PK_lkp_acc_AccountSegments_AccountSegmentID");

                entity.ToTable("lkp_acc_AccountSegments");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_acc_AccountSegments_NameEn")
                    .IsUnique();

                entity.Property(e => e.AccountSegmentId)
                    .HasColumnName("AccountSegmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAccAccountTypes>(entity =>
            {
                entity.HasKey(e => e.AccountTypeId)
                    .HasName("PK_lkp_acc_AccountTypes_AccountTypeID");

                entity.ToTable("lkp_acc_AccountTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_acc_AccountTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.AccountClassificationTypeId).HasColumnName("AccountClassificationTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TshapeDisplayOrder).HasColumnName("TShapeDisplayOrder");

                entity.HasOne(d => d.AccountCategory)
                    .WithMany(p => p.LkpAccAccountTypes)
                    .HasForeignKey(d => d.AccountCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AccountClassificationType)
                    .WithMany(p => p.LkpAccAccountTypes)
                    .HasForeignKey(d => d.AccountClassificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpAccFixedAccounts>(entity =>
            {
                entity.HasKey(e => e.FixedAccountId)
                    .HasName("PK_lkp_acc_FixedAccounts_FixedAccountID");

                entity.ToTable("lkp_acc_FixedAccounts");

                entity.Property(e => e.FixedAccountId)
                    .HasColumnName("FixedAccountID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DiscountPercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAccJournalGenerationTypes>(entity =>
            {
                entity.HasKey(e => e.JournalGenerationTypeId)
                    .HasName("PK_lkp_acc_JournalGenerationTypes_JournalGenerationTypeID");

                entity.ToTable("lkp_acc_JournalGenerationTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_acc_JournalGenerationTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.JournalGenerationTypeId)
                    .HasColumnName("JournalGenerationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IsAp).HasColumnName("IsAP");

                entity.Property(e => e.IsAr).HasColumnName("IsAR");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReporDisplayNameEn).HasMaxLength(100);

                entity.Property(e => e.ReportDisplayNameAr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAccTreasuries>(entity =>
            {
                entity.HasKey(e => e.TreasuryId)
                    .HasName("PK_lkp_acc_Treasuries_TreasuryID");

                entity.ToTable("lkp_acc_Treasuries");

                entity.Property(e => e.TreasuryId).HasColumnName("TreasuryID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ResetPayablePrefix).HasMaxLength(200);

                entity.Property(e => e.ResetReceivablePrefix).HasMaxLength(200);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.LkpAccTreasuries)
                    .HasForeignKey(d => d.BranchId);
            });

            modelBuilder.Entity<LkpAccTreasuryCurrencies>(entity =>
            {
                entity.HasKey(e => e.TreasuryCurrencyId)
                    .HasName("PK_lkp_acc_TreasuryCurrencies_TreasuryCurrencyID");

                entity.ToTable("lkp_acc_TreasuryCurrencies");

                entity.HasIndex(e => new { e.TreasuryId, e.CurrencyId })
                    .HasName("UC_lkp_acc_TreasuryCurrencies_TreasuryIDCurrencyID")
                    .IsUnique();

                entity.Property(e => e.TreasuryCurrencyId).HasColumnName("TreasuryCurrencyID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.TreasuryId).HasColumnName("TreasuryID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.LkpAccTreasuryCurrencies)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.LkpAccTreasuryCurrencies)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Treasury)
                    .WithMany(p => p.LkpAccTreasuryCurrencies)
                    .HasForeignKey(d => d.TreasuryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK_lkp_Activity_ActivityID");

                entity.ToTable("lkp_Activity");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpActivitySubjects>(entity =>
            {
                entity.HasKey(e => e.ActivitySubjectId)
                    .HasName("PK_lkp_ActivitySubjects_ActivitySubjectID");

                entity.ToTable("lkp_ActivitySubjects");

                entity.Property(e => e.ActivitySubjectId).HasColumnName("ActivitySubjectID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Grades).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAdtActions>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK_lkp_adt_Actions_ActionID");

                entity.ToTable("lkp_adt_Actions");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .HasComment("رقم الحدث")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("اسم الحدث بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم الحدث بالانجليزية");
            });

            modelBuilder.Entity<LkpAdtDepartments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_lkp_adt_Departments_DepartmentID");

                entity.ToTable("lkp_adt_Departments");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasComment("رقم الإدارة")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("اسم القسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم القسم بالانجليزية");
            });

            modelBuilder.Entity<LkpAdtFields>(entity =>
            {
                entity.HasKey(e => e.FieldId)
                    .HasName("PK_lkp_adt_Fields_FieldID");

                entity.ToTable("lkp_adt_Fields");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FieldID")
                    .HasComment("رقم الحقل")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.SubModuleId)
                    .HasColumnName("SubModuleID")
                    .HasComment("رقم الوحدة");

                entity.HasOne(d => d.SubModule)
                    .WithMany(p => p.LkpAdtFields)
                    .HasForeignKey(d => d.SubModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpAdtModules>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_lkp_adt_Modules_ModuleID");

                entity.ToTable("lkp_adt_Modules");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasComment("رقم الشاشة")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.SectionId)
                    .HasColumnName("SectionID")
                    .HasComment("رقم الوحدة");
            });

            modelBuilder.Entity<LkpAdtSections>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("PK_lkp_adt_Sections_SectionID");

                entity.ToTable("lkp_adt_Sections");

                entity.Property(e => e.SectionId)
                    .HasColumnName("SectionID")
                    .HasComment("رقم القطاع")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasComment("رقم الإدارة");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.LkpAdtSections)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpAdtSubModules>(entity =>
            {
                entity.HasKey(e => e.SubModuleId)
                    .HasName("PK_lkp_adt_SubModules_SubModuleID");

                entity.ToTable("lkp_adt_SubModules");

                entity.Property(e => e.SubModuleId)
                    .HasColumnName("SubModuleID")
                    .HasComment("رقم الشاشة الفرعية")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasComment("رقم الشاشة");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.LkpAdtSubModules)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpAreas>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PK_lkp_Areas_AreaID");

                entity.ToTable("lkp_Areas");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.GovernerateId).HasColumnName("GovernerateID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.HasOne(d => d.Governerate)
                    .WithMany(p => p.LkpAreas)
                    .HasForeignKey(d => d.GovernerateId);
            });

            modelBuilder.Entity<LkpAstAssetActionTypes>(entity =>
            {
                entity.HasKey(e => e.AssetActionTypeId);

                entity.ToTable("lkp_ast_AssetActionTypes");

                entity.Property(e => e.AssetActionTypeId)
                    .HasColumnName("AssetActionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAstAssetCategories>(entity =>
            {
                entity.HasKey(e => e.AssetCategoryId);

                entity.ToTable("lkp_ast_AssetCategories");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.AssetAccountId).HasColumnName("AssetAccountID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DepreciationAccountId).HasColumnName("DepreciationAccountID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TotalDepreciationAccountId).HasColumnName("TotalDepreciationAccountID");
            });

            modelBuilder.Entity<LkpAstAssetItemTypes>(entity =>
            {
                entity.HasKey(e => e.AssetItemTypeId);

                entity.ToTable("lkp_ast_AssetItemTypes");

                entity.HasIndex(e => new { e.AssetTypeId, e.NameEn })
                    .HasName("UC_lkp_ast_AssetItemTypes_AssetTypeIDNameEn")
                    .IsUnique();

                entity.Property(e => e.AssetItemTypeId).HasColumnName("AssetItemTypeID");

                entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AssetType)
                    .WithMany(p => p.LkpAstAssetItemTypes)
                    .HasForeignKey(d => d.AssetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpAstAssetStates>(entity =>
            {
                entity.HasKey(e => e.AssetStatusId);

                entity.ToTable("lkp_ast_AssetStates");

                entity.Property(e => e.AssetStatusId).HasColumnName("AssetStatusID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpAstAssetTypes>(entity =>
            {
                entity.HasKey(e => e.AssetTypeId);

                entity.ToTable("lkp_ast_AssetTypes");

                entity.HasIndex(e => new { e.AssetCategoryId, e.NameEn })
                    .HasName("UC_lkp_ast_AssetTypes_AssetCategoryIDNameEn")
                    .IsUnique();

                entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");

                entity.Property(e => e.AssetCategoryId).HasColumnName("AssetCategoryID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DepreciationPercentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AssetCategory)
                    .WithMany(p => p.LkpAstAssetTypes)
                    .HasForeignKey(d => d.AssetCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpAstDepreciationCalculationTypes>(entity =>
            {
                entity.HasKey(e => e.DepreciationCalculationTypeId);

                entity.ToTable("lkp_ast_DepreciationCalculationTypes");

                entity.HasIndex(e => e.DepreciationCalculationTypeId)
                    .HasName("UQ__lkp_ast___2C06658CFAF83DDA")
                    .IsUnique();

                entity.Property(e => e.DepreciationCalculationTypeId)
                    .HasColumnName("DepreciationCalculationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpBankAccounts>(entity =>
            {
                entity.HasKey(e => e.BankAccountId)
                    .HasName("PK_lkp_BankAccounts_BankAccountID");

                entity.ToTable("lkp_BankAccounts");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_BankAccounts_NameEn")
                    .IsUnique();

                entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.LkpBankAccounts)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.LkpBankAccounts)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.LkpBankAccounts)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpBanks>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK_lkp_Banks_BankID");

                entity.ToTable("lkp_Banks");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_Banks_NameEn")
                    .IsUnique();

                entity.Property(e => e.BankId)
                    .HasColumnName("BankID")
                    .HasComment("رقم معرف البنك");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpBookingFunctions>(entity =>
            {
                entity.HasKey(e => e.BookingFunctionId)
                    .HasName("PK_lkp_BookingFunctions_BookingFunctionID");

                entity.ToTable("lkp_BookingFunctions");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_BookingFunctions_NameEn")
                    .IsUnique();

                entity.Property(e => e.BookingFunctionId).HasColumnName("BookingFunctionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");

                entity.HasOne(d => d.TransportType)
                    .WithMany(p => p.LkpBookingFunctions)
                    .HasForeignKey(d => d.TransportTypeId);
            });

            modelBuilder.Entity<LkpBookingStates>(entity =>
            {
                entity.HasKey(e => e.BookingStatusId)
                    .HasName("PK_lkp_BookingStates_BookingStatusID");

                entity.ToTable("lkp_BookingStates");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_BookingStates_NameEn")
                    .IsUnique();

                entity.Property(e => e.BookingStatusId)
                    .HasColumnName("BookingStatusID")
                    .HasComment("رقم حالة الحجز");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpBookingTrackingStates>(entity =>
            {
                entity.HasKey(e => e.BookingTrackingStatusId)
                    .HasName("PK_lkp_BookingTrackingStates_BookingTrackingStatusID");

                entity.ToTable("lkp_BookingTrackingStates");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_BookingTrackingStates_NameEn")
                    .IsUnique();

                entity.Property(e => e.BookingTrackingStatusId).HasColumnName("BookingTrackingStatusID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpBookingTypes>(entity =>
            {
                entity.HasKey(e => e.BookingTypeId)
                    .HasName("PK_lkp_BookingTypes_BookingTypeID");

                entity.ToTable("lkp_BookingTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_BookingTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.BookingTypeId)
                    .HasColumnName("BookingTypeID")
                    .HasComment("رقم نوع الحجز");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DefaultClaimTypeId).HasColumnName("DefaultClaimTypeID");

                entity.Property(e => e.DefaultInvoiceTypeId).HasColumnName("DefaultInvoiceTypeID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FreightName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.HousePrefix).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastHouseBl).HasColumnName("LastHouseBL");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.OperationNumberCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ResponsiblePersonNameAr).HasMaxLength(100);

                entity.Property(e => e.ResponsiblePersonNameEn).HasMaxLength(100);

                entity.Property(e => e.TeamName).HasMaxLength(100);

                entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");

                entity.HasOne(d => d.DefaultClaimType)
                    .WithMany(p => p.LkpBookingTypesDefaultClaimType)
                    .HasForeignKey(d => d.DefaultClaimTypeId);

                entity.HasOne(d => d.DefaultInvoiceType)
                    .WithMany(p => p.LkpBookingTypesDefaultInvoiceType)
                    .HasForeignKey(d => d.DefaultInvoiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TransportType)
                    .WithMany(p => p.LkpBookingTypes)
                    .HasForeignKey(d => d.TransportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpBranches>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("PK_lkp_Branches_BranchID");

                entity.ToTable("lkp_Branches");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_Branches_NameEn")
                    .IsUnique();

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasComment("رقم معرف الفرع");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpCargoCategories>(entity =>
            {
                entity.HasKey(e => e.CargoCategoryId)
                    .HasName("PK_lkp_CargoCategories_CargoCategoryID");

                entity.ToTable("lkp_CargoCategories");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_CargoCategories_Code")
                    .IsUnique();

                entity.Property(e => e.CargoCategoryId)
                    .HasColumnName("CargoCategoryID")
                    .HasComment("رقم فئة البضاعة")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpClasses>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK_lkp_Classes_ClassID");

                entity.ToTable("lkp_Classes");

                entity.HasIndex(e => new { e.GradeId, e.Code })
                    .HasName("UC_lkp_Classes_CodeGradeID")
                    .IsUnique();

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.LkpClasses)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpClientFunctions>(entity =>
            {
                entity.HasKey(e => e.ClientFunctionId)
                    .HasName("PK_lkp_ClientFunctions_ClientFunctionID");

                entity.ToTable("lkp_ClientFunctions");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_ClientFunctions_NameEn")
                    .IsUnique();

                entity.Property(e => e.ClientFunctionId)
                    .HasColumnName("ClientFunctionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpClientStatus>(entity =>
            {
                entity.HasKey(e => e.ClientStatusId)
                    .HasName("PK_lkp_ClientStatus_ClientStatusID");

                entity.ToTable("lkp_ClientStatus");

                entity.Property(e => e.ClientStatusId)
                    .HasColumnName("ClientStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpColorDegrees>(entity =>
            {
                entity.HasKey(e => e.ColorDegreeId);

                entity.ToTable("lkp_ColorDegrees");

                entity.Property(e => e.ColorDegreeId)
                    .HasColumnName("ColorDegreeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<LkpCommodities>(entity =>
            {
                entity.HasKey(e => e.CommodityId)
                    .HasName("PK_lkp_Commodities_CommodityID");

                entity.ToTable("lkp_Commodities");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Commodities_Code")
                    .IsUnique();

                entity.Property(e => e.CommodityId)
                    .HasColumnName("CommodityID")
                    .HasComment("رقم السلعة");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpContactPersonTypes>(entity =>
            {
                entity.HasKey(e => e.ContactPersonTypeId)
                    .HasName("PK_lkp_ContactPersonTypes_ContactPersonTypeID");

                entity.ToTable("lkp_ContactPersonTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_ContactPersonTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.ContactPersonTypeId).HasColumnName("ContactPersonTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpContactTypes>(entity =>
            {
                entity.HasKey(e => e.ContactTypeId)
                    .HasName("PK_lkp_ContactTypes_ContactAddresID");

                entity.ToTable("lkp_ContactTypes");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpContainerLoadTypes>(entity =>
            {
                entity.HasKey(e => e.ContainerLoadTypeId)
                    .HasName("PK_lkp_ContainerLoadTypes_ContainerLoadTypeID");

                entity.ToTable("lkp_ContainerLoadTypes");

                entity.Property(e => e.ContainerLoadTypeId).HasColumnName("ContainerLoadTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpContainerSizes>(entity =>
            {
                entity.HasKey(e => e.ContainerSizeId)
                    .HasName("PK_lkp_ContainerSizes_ContainerSizeID");

                entity.ToTable("lkp_ContainerSizes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_ContainerSizes_Code")
                    .IsUnique();

                entity.Property(e => e.ContainerSizeId)
                    .HasColumnName("ContainerSizeID")
                    .HasComment("رقم حجم الحاوية")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DefaultTareWeightInTon)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("الحجم الفارغ بالطن");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LengthInFt)
                    .HasColumnName("LengthInFT")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("الطول بالقدم");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<LkpContainerTypes>(entity =>
            {
                entity.HasKey(e => e.ContainerTypeId)
                    .HasName("PK_lkp_ContainerTypes_ContainerTypeID");

                entity.ToTable("lkp_ContainerTypes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_ContainerTypes_Code")
                    .IsUnique();

                entity.Property(e => e.ContainerTypeId)
                    .HasColumnName("ContainerTypeID")
                    .HasComment("رقم معرف نوع الحاوية");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IsOutOfGage).HasComment("حجم غير منتظم");

                entity.Property(e => e.IsSealable).HasComment("له رقم قفل");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_lkp_Countries_CountrtyID");

                entity.ToTable("lkp_Countries");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Countries_Code")
                    .IsUnique();

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasComment("رقم الدولة");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpCurrencies>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PK_lkp_Currencies_CurrencyID");

                entity.ToTable("lkp_Currencies");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Currencies_Code")
                    .IsUnique();

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasComment("رقم العملة");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IsDefault).HasComment("هل افتراضي");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.SmallUnitNameAr)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("وحدة صغيرة بالعربية");

                entity.Property(e => e.SmallUnitNameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("وحدة صغيرة بالانجليزية");
            });

            modelBuilder.Entity<LkpDateFormats>(entity =>
            {
                entity.HasKey(e => e.DateFormatId)
                    .HasName("PK_lkp_DateFormats_DateFormatID");

                entity.ToTable("lkp_DateFormats");

                entity.Property(e => e.DateFormatId).HasColumnName("DateFormatID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DateFormat)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<LkpDebitTypes>(entity =>
            {
                entity.HasKey(e => e.DebitTypeId)
                    .HasName("PK_lkp_DebitTypes_DebitTypeID");

                entity.ToTable("lkp_DebitTypes");

                entity.Property(e => e.DebitTypeId).HasColumnName("DebitTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpDeliveryTerms>(entity =>
            {
                entity.HasKey(e => e.DeliveryTermId)
                    .HasName("PK_lkp_DeliveryTerms_DeliveryTermID");

                entity.ToTable("lkp_DeliveryTerms");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_DeliveryTerms_NameEn")
                    .IsUnique();

                entity.Property(e => e.DeliveryTermId).HasColumnName("DeliveryTermID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpDepartments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_lkp_Departments_DepartmentID");

                entity.ToTable("lkp_Departments");

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_Departments_NameEn")
                    .IsUnique();

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpDiseaseTypes>(entity =>
            {
                entity.HasKey(e => e.DiseaseTypeId)
                    .HasName("PK_lkp_DiseaseTypes_DiseaseTypeID");

                entity.ToTable("lkp_DiseaseTypes");

                entity.Property(e => e.DiseaseTypeId).HasColumnName("DiseaseTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpEmployeeFunctions>(entity =>
            {
                entity.HasKey(e => e.EmployeeFunctionId)
                    .HasName("PK_lkp_EmployeeFunctions_EmployeeFunctionID");

                entity.ToTable("lkp_EmployeeFunctions");

                entity.Property(e => e.EmployeeFunctionId)
                    .HasColumnName("EmployeeFunctionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .IsRequired()
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpEmployeeJobCategories>(entity =>
            {
                entity.HasKey(e => e.EmployeeJobCategoryId)
                    .HasName("PK_lkp_EmployeeJobCategories_EmployeeJobCategoryID");

                entity.ToTable("lkp_EmployeeJobCategories");

                entity.Property(e => e.EmployeeJobCategoryId).HasColumnName("EmployeeJobCategoryID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpEmployeeJobs>(entity =>
            {
                entity.HasKey(e => e.EmployeeJobId)
                    .HasName("PK_lkp_EmployeeJobs_EmployeeJobID");

                entity.ToTable("lkp_EmployeeJobs");

                entity.Property(e => e.EmployeeJobId).HasColumnName("EmployeeJobID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.EmployeeJobCategoryId).HasColumnName("EmployeeJobCategoryID");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.HasOne(d => d.EmployeeJobCategory)
                    .WithMany(p => p.LkpEmployeeJobs)
                    .HasForeignKey(d => d.EmployeeJobCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpEmploymentTypes>(entity =>
            {
                entity.HasKey(e => e.EmploymentTypeId)
                    .HasName("PK_lkp_EmploymentTypes_EmploymentTypeID");

                entity.ToTable("lkp_EmploymentTypes");

                entity.Property(e => e.EmploymentTypeId).HasColumnName("EmploymentTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpEndedSubjectGroups>(entity =>
            {
                entity.HasKey(e => e.EndedSubjectGroupId)
                    .HasName("PK_lkp_EndedSubjectGroups_EndedSubjectGroupID");

                entity.ToTable("lkp_EndedSubjectGroups");

                entity.Property(e => e.EndedSubjectGroupId).HasColumnName("EndedSubjectGroupID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpEventStates>(entity =>
            {
                entity.HasKey(e => e.EventStatusId)
                    .HasName("PK_lkp_EventStates_EventStatusID");

                entity.ToTable("lkp_EventStates");

                entity.Property(e => e.EventStatusId)
                    .HasColumnName("EventStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpExams>(entity =>
            {
                entity.HasKey(e => e.ExamId)
                    .HasName("PK_lkp_Exams_ExamID");

                entity.ToTable("lkp_Exams");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DisplayNameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayNameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.LkpExams)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.LkpExams)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpExpenseTypes>(entity =>
            {
                entity.HasKey(e => e.ExpenseTypeId)
                    .HasName("PK_lkp_ExpenseTypes_ExpenseTypeID");

                entity.ToTable("lkp_ExpenseTypes");

                entity.HasIndex(e => e.DisplayOrder)
                    .HasName("UC_lkp_ExpenseTypes_DisplayOrder")
                    .IsUnique();

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_ExpenseTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpExpensesTypeActivities>(entity =>
            {
                entity.HasKey(e => e.ExpensesTypeActivityId)
                    .HasName("PK_lkp_ExpensesTypesActivities");

                entity.ToTable("lkp_ExpensesTypeActivities");

                entity.HasIndex(e => new { e.ExpensesAccountId, e.ActivityId, e.ExpenseTypeId })
                    .HasName("UC_lkp_ExpensesTypeActivities_ExpensesAccountIDActivityIDExpenseTypeID")
                    .IsUnique();

                entity.Property(e => e.ExpensesTypeActivityId).HasColumnName("ExpensesTypeActivityID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");

                entity.Property(e => e.ExpensesAccountId).HasColumnName("ExpensesAccountID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.LkpExpensesTypeActivities)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ExpenseType)
                    .WithMany(p => p.LkpExpensesTypeActivities)
                    .HasForeignKey(d => d.ExpenseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ExpensesAccount)
                    .WithMany(p => p.LkpExpensesTypeActivities)
                    .HasForeignKey(d => d.ExpensesAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpFinancialYears>(entity =>
            {
                entity.HasKey(e => e.FinancialYearId)
                    .HasName("PK_lkp_FinancialYears_FinancialYearID");

                entity.ToTable("lkp_FinancialYears");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_FinancialYears_NameEn")
                    .IsUnique();

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LkpFreightTypes>(entity =>
            {
                entity.HasKey(e => e.FreightTypeId)
                    .HasName("PK_lkp_FreightTypes_FreightTypeID");

                entity.ToTable("lkp_FreightTypes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_FreightTypes_Code")
                    .IsUnique();

                entity.Property(e => e.FreightTypeId)
                    .HasColumnName("FreightTypeID")
                    .HasComment("رقم نوع النولون");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IsHouseBill).HasComment("فاتورة الوكيل");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpGenderTypes>(entity =>
            {
                entity.HasKey(e => e.GenderTypeId)
                    .HasName("PK_lkp_GenderTypes_GenderTypeID");

                entity.ToTable("lkp_GenderTypes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_GenderTypes_Code")
                    .IsUnique();

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_GenderTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.GenderTypeId)
                    .HasColumnName("GenderTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpGeneralEvaluations>(entity =>
            {
                entity.HasKey(e => e.GeneralEvaluationId)
                    .HasName("PK_lkp_GeneralEvaluations_GeneralEvaluationID");

                entity.ToTable("lkp_GeneralEvaluations");

                entity.HasIndex(e => e.NameAr)
                    .HasName("IDX_lkp_GeneralEvaluations_NameAr");

                entity.HasIndex(e => e.NameFr)
                    .HasName("IDX_lkp_GeneralEvaluations_NameFr");

                entity.Property(e => e.GeneralEvaluationId)
                    .HasColumnName("GeneralEvaluationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.GreaterThan).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LessThan).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpGovernerates>(entity =>
            {
                entity.HasKey(e => e.GovernerateId)
                    .HasName("PK_lkp_Governerates_GovernerateID");

                entity.ToTable("lkp_Governerates");

                entity.HasIndex(e => e.NameAr)
                    .HasName("UC_lkp_Governerates_NameAr")
                    .IsUnique();

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_Governerates_NameFr")
                    .IsUnique();

                entity.Property(e => e.GovernerateId).HasColumnName("GovernerateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LkpGovernerates)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpGrades>(entity =>
            {
                entity.HasKey(e => e.GradeId)
                    .HasName("PK_lkp_Grades_GradeID");

                entity.ToTable("lkp_Grades");

                entity.HasIndex(e => e.DisplayNameAr)
                    .HasName("IDX_lkp_Grades_DisplayNameAr");

                entity.HasIndex(e => e.DisplayNameFr)
                    .HasName("IDX_lkp_Grades_DisplayNameFr");

                entity.HasIndex(e => e.StudyOrder)
                    .HasName("idx_lkp_Grades_StudyOrder");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.CanSelectHighLevelOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodeNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CodeSuffix)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DisplayGradeNumberAr).HasMaxLength(100);

                entity.Property(e => e.DisplayNameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayNameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayShortNameAr).HasMaxLength(100);

                entity.Property(e => e.FixedSecretNumberForAcademicYear).HasDefaultValueSql("((0))");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.IsMinistryExams).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPassAnyWay).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StageName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.LkpGrades)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpGradesParentNotifications>(entity =>
            {
                entity.HasKey(e => e.GradesParentNotificationId)
                    .HasName("PK_lkp_GradesParentNotifications_GradesParentNotificationID");

                entity.ToTable("lkp_GradesParentNotifications");

                entity.HasIndex(e => e.GradeId)
                    .HasName("UC_lkp_GradesParentNotifications_GradeID")
                    .IsUnique();

                entity.Property(e => e.GradesParentNotificationId).HasColumnName("GradesParentNotificationID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NotificationText).HasColumnType("ntext");

                entity.HasOne(d => d.Grade)
                    .WithOne(p => p.LkpGradesParentNotifications)
                    .HasForeignKey<LkpGradesParentNotifications>(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpHouseConsolidationCodes>(entity =>
            {
                entity.HasKey(e => e.HouseConsolidationCodeId)
                    .HasName("PK_lkp_HouseConsolidationCodes_HouseConsolidationCodeID");

                entity.ToTable("lkp_HouseConsolidationCodes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_HouseConsolidationCodes_Code")
                    .IsUnique();

                entity.Property(e => e.HouseConsolidationCodeId).HasColumnName("HouseConsolidationCodeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<LkpHrreportFunctions>(entity =>
            {
                entity.HasKey(e => e.HrreportFunctionId)
                    .HasName("PK_lkp_HRReportFunctions_HRReportFunctionID");

                entity.ToTable("lkp_HRReportFunctions");

                entity.Property(e => e.HrreportFunctionId)
                    .HasColumnName("HRReportFunctionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .IsRequired()
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpHrstages>(entity =>
            {
                entity.HasKey(e => e.HrstageId)
                    .HasName("PK_lkp_HRStages_StageID");

                entity.ToTable("lkp_HRStages");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_HRStages_Code")
                    .IsUnique();

                entity.Property(e => e.HrstageId).HasColumnName("HRStageID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.SecretaryNameAr).HasMaxLength(100);

                entity.Property(e => e.SecretaryNameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpHrstatisticReportFunctions>(entity =>
            {
                entity.HasKey(e => e.LkpHrstatisticReportFunctionId)
                    .HasName("PK_lkplkp_HRStatisticReportFunctionsHRReportFunctionID");

                entity.ToTable("lkp_HRStatisticReportFunctions");

                entity.Property(e => e.LkpHrstatisticReportFunctionId)
                    .HasColumnName("lkp_HRStatisticReportFunctionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .IsRequired()
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpHscodes>(entity =>
            {
                entity.HasKey(e => e.HscodeId)
                    .HasName("PK_lkp_HSCodes_HSCodeID");

                entity.ToTable("lkp_HSCodes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_HSCodes_Code")
                    .IsUnique();

                entity.Property(e => e.HscodeId)
                    .HasColumnName("HSCodeID")
                    .HasComment("رقم تكويد البضاعة");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Description)
                    .HasColumnType("ntext")
                    .HasComment("الوصف");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<LkpImoclasses>(entity =>
            {
                entity.HasKey(e => e.ImoclassId)
                    .HasName("PK_lkp_IMOClasses_IMOClassID");

                entity.ToTable("lkp_IMOClasses");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_IMOClasses_Code")
                    .IsUnique();

                entity.Property(e => e.ImoclassId)
                    .HasColumnName("IMOClassID")
                    .HasComment("رقم درجات الخطورة")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasComment("الوصف");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<LkpInvoicePaymentMethods>(entity =>
            {
                entity.HasKey(e => e.InvoicePaymentMethodId)
                    .HasName("PK_lkp_InvoicePaymentMethods_InvoicePaymentMethodID");

                entity.ToTable("lkp_InvoicePaymentMethods");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_InvoicePaymentMethods_Code")
                    .IsUnique();

                entity.Property(e => e.InvoicePaymentMethodId)
                    .HasColumnName("InvoicePaymentMethodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ResetReceivablePrefix)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpInvoicePaymentStates>(entity =>
            {
                entity.HasKey(e => e.InvoicePaymentStatusId)
                    .HasName("PK_lkp_InvoicePaymentStates_InvoicePaymentStatusID");

                entity.ToTable("lkp_InvoicePaymentStates");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_InvoicePaymentStates_NameEn")
                    .IsUnique();

                entity.Property(e => e.InvoicePaymentStatusId)
                    .HasColumnName("InvoicePaymentStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpInvoiceTo>(entity =>
            {
                entity.HasKey(e => e.InvoiceToId)
                    .HasName("PK_lkp_InvoiceTo_InvoiceToID");

                entity.ToTable("lkp_InvoiceTo");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_InvoiceTo_NameEn")
                    .IsUnique();

                entity.Property(e => e.InvoiceToId)
                    .HasColumnName("InvoiceToID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpInvoiceTypeCurrencies>(entity =>
            {
                entity.HasKey(e => e.InvoiceTypeCurrencyId)
                    .HasName("PK_lkp_InvoiceTypeCurrencies_InvoiceTypeCurrencyID");

                entity.ToTable("lkp_InvoiceTypeCurrencies");

                entity.HasIndex(e => new { e.InvoiceTypeId, e.CurrencyId })
                    .HasName("UC_lkp_InvoiceTypeCurrencies_InvoiceTypeIDCurrencyID")
                    .IsUnique();

                entity.Property(e => e.InvoiceTypeCurrencyId).HasColumnName("InvoiceTypeCurrencyID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.FreeTaxAccountId).HasColumnName("FreeTaxAccountID");

                entity.Property(e => e.InvoiceTypeId).HasColumnName("InvoiceTypeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.LkpInvoiceTypeCurrenciesAccount)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.LkpInvoiceTypeCurrencies)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FreeTaxAccount)
                    .WithMany(p => p.LkpInvoiceTypeCurrenciesFreeTaxAccount)
                    .HasForeignKey(d => d.FreeTaxAccountId);

                entity.HasOne(d => d.InvoiceType)
                    .WithMany(p => p.LkpInvoiceTypeCurrencies)
                    .HasForeignKey(d => d.InvoiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpInvoiceTypes>(entity =>
            {
                entity.HasKey(e => e.InvoiceTypeId)
                    .HasName("PK_lkp_InvoiceTypes_InvoiceTypeID");

                entity.ToTable("lkp_InvoiceTypes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_InvoiceTypes_Code")
                    .IsUnique();

                entity.Property(e => e.InvoiceTypeId).HasColumnName("InvoiceTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.InvoiceTypePrefix)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpJobs>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK_lkp_Jobs_JobID");

                entity.ToTable("lkp_Jobs");

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_Jobs_NameEn")
                    .IsUnique();

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpLanguages>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK_lkp_Languages_LanguageID");

                entity.ToTable("lkp_Languages");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Languages_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("UC_lkp_Languages_Name")
                    .IsUnique();

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasComment("رقم اللغة")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasComment("كود اللغة");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم اللغة");
            });

            modelBuilder.Entity<LkpLocations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK_lkp_Locations_LocationID");

                entity.ToTable("lkp_Locations");

                entity.HasIndex(e => e.NameAr)
                    .HasName("UC_lkp_Locations_NameAr")
                    .IsUnique();

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpMaritalStates>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId)
                    .HasName("PK_lkp_MaritalStates_MaritalStatusID");

                entity.ToTable("lkp_MaritalStates");

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnName("MaritalStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpMilitaryStates>(entity =>
            {
                entity.HasKey(e => e.MilitaryStatusId)
                    .HasName("PK_lkp_MilitaryStates_MilitaryStatusID");

                entity.ToTable("lkp_MilitaryStates");

                entity.Property(e => e.MilitaryStatusId).HasColumnName("MilitaryStatusID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpMonthDegreeFunctions>(entity =>
            {
                entity.HasKey(e => e.MonthDegreeFunctionId)
                    .HasName("PK_lkp_MonthDegreeFunctions_MonthDegreeFunctionID");

                entity.ToTable("lkp_MonthDegreeFunctions");

                entity.HasIndex(e => new { e.StageId, e.NameAr })
                    .HasName("UC_lkp_MonthDegreeFunctions_NameAr")
                    .IsUnique();

                entity.HasIndex(e => new { e.StageId, e.NameFr })
                    .HasName("UC_lkp_MonthDegreeFunctions_NameFr")
                    .IsUnique();

                entity.Property(e => e.MonthDegreeFunctionId).HasColumnName("MonthDegreeFunctionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.LkpMonthDegreeFunctions)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpMonths>(entity =>
            {
                entity.HasKey(e => e.MonthId)
                    .HasName("PK_lkp_Months_MonthID");

                entity.ToTable("lkp_Months");

                entity.Property(e => e.MonthId)
                    .HasColumnName("MonthID")
                    .HasComment("رقم الشهر")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم الشهر باللغه العربية");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(100)
                    .HasComment("اسم الشهر باللغه الانجليزيه");

                entity.Property(e => e.Remarks).HasColumnType("ntext");
            });

            modelBuilder.Entity<LkpNationalities>(entity =>
            {
                entity.HasKey(e => e.NationalityId)
                    .HasName("PK_lkp_Nationalities_NationalityID");

                entity.ToTable("lkp_Nationalities");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Nationalities_Code")
                    .IsUnique();

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_Nationalities_NameEn")
                    .IsUnique();

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpOverduePeriods>(entity =>
            {
                entity.HasKey(e => e.OverduePeriodId)
                    .HasName("PK_lkp_OverduePeriods_OverduePeriodID");

                entity.ToTable("lkp_OverduePeriods");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_OverduePeriods_NameEn")
                    .IsUnique();

                entity.Property(e => e.OverduePeriodId).HasColumnName("OverduePeriodID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpPackageTypes>(entity =>
            {
                entity.HasKey(e => e.PackageTypeId)
                    .HasName("PK_lkp_PackageTypes_PackageTypeID");

                entity.ToTable("lkp_PackageTypes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_PackageTypes_Code")
                    .IsUnique();

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_PackageTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.PackageTypeId)
                    .HasColumnName("PackageTypeID")
                    .HasComment("رقم نوع الطرد");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpParentStates>(entity =>
            {
                entity.HasKey(e => e.ParentStatusId)
                    .HasName("PK_lkp_ParentStates_ParentStatusID");

                entity.ToTable("lkp_ParentStates");

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_ParentStates_NameEn")
                    .IsUnique();

                entity.Property(e => e.ParentStatusId).HasColumnName("ParentStatusID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpPaymentDiscountTypes>(entity =>
            {
                entity.HasKey(e => e.PaymentDiscountTypeId)
                    .HasName("PK_lkp_PaymentDiscountTypes_PaymentDiscountTypeID");

                entity.ToTable("lkp_PaymentDiscountTypes");

                entity.Property(e => e.PaymentDiscountTypeId).HasColumnName("PaymentDiscountTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("text");
            });

            modelBuilder.Entity<LkpPaymentMethods>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodId)
                    .HasName("PK_lkp_PaymentMethods_PaymentMethodID");

                entity.ToTable("lkp_PaymentMethods");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpPaymentPortionTypes>(entity =>
            {
                entity.HasKey(e => e.PaymentPortionTypeId)
                    .HasName("PK_lkp_PaymentPortionTypes_PaymentPortionTypeID");

                entity.ToTable("lkp_PaymentPortionTypes");

                entity.HasIndex(e => e.DisplayOrder)
                    .HasName("UC_lkp_paymentPortionTypes_DisplayOrder")
                    .IsUnique();

                entity.Property(e => e.PaymentPortionTypeId).HasColumnName("PaymentPortionTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpPaymentStates>(entity =>
            {
                entity.HasKey(e => e.PaymentStatusId)
                    .HasName("PK_lkp_PaymentStates_PaymentStatusID");

                entity.ToTable("lkp_PaymentStates");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_PaymentStates_Code")
                    .IsUnique();

                entity.Property(e => e.PaymentStatusId)
                    .HasColumnName("PaymentStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpPermissions>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("PK_lkp_Permissions_PermissionID");

                entity.ToTable("lkp_Permissions");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("idx_lkp_Permissions_CreatorUserID");

                entity.HasIndex(e => e.ModifiedUserId)
                    .HasName("idx_lkp_Permissions_ModifiedUserID");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasComment("رقم الصلاحية")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("اسم الصلاحية بالانجليزية");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("اسم الصلاحية بالعربية");

                entity.Property(e => e.Value).HasComment("قيمة الصلاحية");
            });

            modelBuilder.Entity<LkpPorts>(entity =>
            {
                entity.HasKey(e => e.PortId)
                    .HasName("PK_lkp_Ports_PortID");

                entity.ToTable("lkp_Ports");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Ports_Code")
                    .IsUnique();

                entity.Property(e => e.PortId)
                    .HasColumnName("PortID")
                    .HasComment("رقم معرف الميناء");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasComment("الكود");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasComment("رقم الدولة");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.TransportTypeId)
                    .HasColumnName("TransportTypeID")
                    .HasDefaultValueSql("((1))")
                    .HasComment("رقم معرف نوع وسيلة النقل");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LkpPorts)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.TransportType)
                    .WithMany(p => p.LkpPorts)
                    .HasForeignKey(d => d.TransportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_lkp_Ports_lkp_TransportTypes_CountryID");
            });

            modelBuilder.Entity<LkpQualifications>(entity =>
            {
                entity.HasKey(e => e.QualificationId)
                    .HasName("PK_lkp_Qualifications_QualificationID");

                entity.ToTable("lkp_Qualifications");

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_Qualifications_NameEn")
                    .IsUnique();

                entity.Property(e => e.QualificationId).HasColumnName("QualificationID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpReceivingTerms>(entity =>
            {
                entity.HasKey(e => e.ReceivingTermId)
                    .HasName("PK_lkp_ReceivingTerms_ReceivingTermID");

                entity.ToTable("lkp_ReceivingTerms");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_ReceivingTerms_NameEn")
                    .IsUnique();

                entity.Property(e => e.ReceivingTermId).HasColumnName("ReceivingTermID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpReligions>(entity =>
            {
                entity.HasKey(e => e.ReligionId)
                    .HasName("PK_lkp_Religions_ReligionID");

                entity.ToTable("lkp_Religions");

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_Religions_NameEn")
                    .IsUnique();

                entity.Property(e => e.ReligionId)
                    .HasColumnName("ReligionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.PluralNameAr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpReportHeaders>(entity =>
            {
                entity.HasKey(e => e.ReportHeaderId)
                    .HasName("PK_lkp_ReportHeaders_ReportHeaderID");

                entity.ToTable("lkp_ReportHeaders");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_ReportHeaders_NameEn")
                    .IsUnique();

                entity.Property(e => e.ReportHeaderId)
                    .HasColumnName("ReportHeaderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Footer1).HasMaxLength(100);

                entity.Property(e => e.Footer1Ar).HasMaxLength(100);

                entity.Property(e => e.Footer1Fr).HasMaxLength(100);

                entity.Property(e => e.Footer2).HasMaxLength(100);

                entity.Property(e => e.Footer2Ar).HasMaxLength(100);

                entity.Property(e => e.Footer2Fr).HasMaxLength(100);

                entity.Property(e => e.FormNumber).HasMaxLength(100);

                entity.Property(e => e.Header1).HasMaxLength(100);

                entity.Property(e => e.Header1Ar).HasMaxLength(100);

                entity.Property(e => e.Header1Fr).HasMaxLength(100);

                entity.Property(e => e.Header2).HasMaxLength(100);

                entity.Property(e => e.Header2Ar).HasMaxLength(100);

                entity.Property(e => e.Header2Fr).HasMaxLength(100);

                entity.Property(e => e.Header3).HasMaxLength(100);

                entity.Property(e => e.Header3Ar).HasMaxLength(100);

                entity.Property(e => e.Header3Fr).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpReportsDegreeFunctions>(entity =>
            {
                entity.HasKey(e => e.ReportsDegreeFunctionId)
                    .HasName("PK_lkp_ReportsDegreeFunctions_ReportsDegreeFunctionID");

                entity.ToTable("lkp_ReportsDegreeFunctions");

                entity.Property(e => e.ReportsDegreeFunctionId).HasColumnName("ReportsDegreeFunctionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.Grades).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReportHeaderId).HasColumnName("ReportHeaderID");

                entity.Property(e => e.Semesters).HasMaxLength(100);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.HasOne(d => d.ReportHeader)
                    .WithMany(p => p.LkpReportsDegreeFunctions)
                    .HasForeignKey(d => d.ReportHeaderId);

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.LkpReportsDegreeFunctions)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpReportsHeaderSemesters>(entity =>
            {
                entity.HasKey(e => e.ReportsHeaderSemesterId)
                    .HasName("PK_lkp_ReportsHeaderSemesters_ReportsHeaderSemesterID");

                entity.ToTable("lkp_ReportsHeaderSemesters");

                entity.HasIndex(e => new { e.ReportHeaderId, e.SemesterId })
                    .HasName(@"UC_lkp_ReportsHeaderSemesters_ReportHeaderIDSemesterID

")
                    .IsUnique();

                entity.Property(e => e.ReportsHeaderSemesterId).HasColumnName("ReportsHeaderSemesterID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.ReportHeaderId).HasColumnName("ReportHeaderID");

                entity.Property(e => e.ReportTitle).HasMaxLength(100);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.HasOne(d => d.ReportHeader)
                    .WithMany(p => p.LkpReportsHeaderSemesters)
                    .HasForeignKey(d => d.ReportHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.LkpReportsHeaderSemesters)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpReportsSecretaryFunctions>(entity =>
            {
                entity.HasKey(e => e.ReportsSecretaryFunctionId)
                    .HasName("PK_lkp_ReportsSecretaryFunctions_ReportsSecretaryFunctionID");

                entity.ToTable("lkp_ReportsSecretaryFunctions");

                entity.HasIndex(e => e.NameAr)
                    .HasName("UC_lkp_ReportsSecretaryFunctions_NameAr")
                    .IsUnique();

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_ReportsSecretaryFunctions_NameFr")
                    .IsUnique();

                entity.Property(e => e.ReportsSecretaryFunctionId).HasColumnName("ReportsSecretaryFunctionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .IsRequired()
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.Grades).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReportHeaderId).HasColumnName("ReportHeaderID");

                entity.Property(e => e.Sections).HasMaxLength(100);

                entity.Property(e => e.Stages).HasMaxLength(100);

                entity.HasOne(d => d.ReportHeader)
                    .WithMany(p => p.LkpReportsSecretaryFunctions)
                    .HasForeignKey(d => d.ReportHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpSalesRegions>(entity =>
            {
                entity.HasKey(e => e.SalesRegionId)
                    .HasName("PK_lkp_SalesRegions_SalesRegionID");

                entity.ToTable("lkp_SalesRegions");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_SalesRegions_NameEn")
                    .IsUnique();

                entity.Property(e => e.SalesRegionId).HasColumnName("SalesRegionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");
            });

            modelBuilder.Entity<LkpSalesTargetStates>(entity =>
            {
                entity.HasKey(e => e.SalesTargetStatusId)
                    .HasName("PK_lkp_SalesTargetStates_SalesTargetStatusID");

                entity.ToTable("lkp_SalesTargetStates");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_SalesTargetStates_NameEn")
                    .IsUnique();

                entity.Property(e => e.SalesTargetStatusId)
                    .HasColumnName("SalesTargetStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpSalesTargetTypes>(entity =>
            {
                entity.HasKey(e => e.SalesTargetTypeId)
                    .HasName("PK_lkp_SalesTargetTypes_SalesTargetStatusID");

                entity.ToTable("lkp_SalesTargetTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_SalesTargetTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.SalesTargetTypeId)
                    .HasColumnName("SalesTargetTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpSeatReportsFunctions>(entity =>
            {
                entity.HasKey(e => e.SeatReportFunctionId)
                    .HasName("PK_lkp_SeatReportsFunctions_SeatReportFunctionID");

                entity.ToTable("lkp_SeatReportsFunctions");

                entity.Property(e => e.SeatReportFunctionId).HasColumnName("SeatReportFunctionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .IsRequired()
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Stages).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpSections>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("PK_lkp_Sections_SectionID");

                entity.ToTable("lkp_Sections");

                entity.HasIndex(e => new { e.Code, e.GradeId })
                    .HasName("UC_lkp_Sections_CodeGradeID")
                    .IsUnique();

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.LkpSections)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpSemesters>(entity =>
            {
                entity.HasKey(e => e.SemesterId)
                    .HasName("PK_lkp_Semesters_SemesterID");

                entity.ToTable("lkp_Semesters");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Semesters_Code")
                    .IsUnique();

                entity.Property(e => e.SemesterId)
                    .HasColumnName("SemesterID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DisplayNameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayNameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameArInMinistryReports).HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpServiceTypes>(entity =>
            {
                entity.HasKey(e => e.ServiceTypeId)
                    .HasName("PK_lkp_ServiceTypes_ServiceTypeID");

                entity.ToTable("lkp_ServiceTypes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_ServiceTypes_Code")
                    .IsUnique();

                entity.Property(e => e.ServiceTypeId)
                    .HasColumnName("ServiceTypeID")
                    .HasComment("رقم نوع الخدمة");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpServices>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_lkp_BookingFunctions_ServiceID");

                entity.ToTable("lkp_Services");

                entity.HasIndex(e => new { e.ServiceTypeId, e.NameEn })
                    .HasName("UC_lkp_Services_ServiceTypeIDNameEn")
                    .IsUnique();

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.LkpServices)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpSettingTypes>(entity =>
            {
                entity.HasKey(e => e.SettingTypeId)
                    .HasName("PK_lkp_SettingTypes_SettingTypeID");

                entity.ToTable("lkp_SettingTypes");

                entity.Property(e => e.SettingTypeId)
                    .HasColumnName("SettingTypeID")
                    .HasComment("رقم انواع الاعدادات")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم انواع الاعدادات");
            });

            modelBuilder.Entity<LkpStages>(entity =>
            {
                entity.HasKey(e => e.StageId)
                    .HasName("PK_lkp_Stages_StageID");

                entity.ToTable("lkp_Stages");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Stages_Code")
                    .IsUnique();

                entity.Property(e => e.StageId)
                    .HasColumnName("StageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.SecretaryNameAr).HasMaxLength(100);

                entity.Property(e => e.SecretaryNameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpStudentFunctions>(entity =>
            {
                entity.HasKey(e => e.StudentFunctionId)
                    .HasName("PK_lkp_StudentFunctions_StudentFunctionID");

                entity.ToTable("lkp_StudentFunctions");

                entity.HasIndex(e => e.NameFr)
                    .HasName("UC_lkp_StudentFunctions")
                    .IsUnique();

                entity.Property(e => e.StudentFunctionId).HasColumnName("StudentFunctionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NameEn)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpStudentResponsibleRelations>(entity =>
            {
                entity.HasKey(e => e.StudentResponsibleRelationId)
                    .HasName("PK_lkp_StudentResponsibleRelations_StudentResponsibleRelationID");

                entity.ToTable("lkp_StudentResponsibleRelations");

                entity.Property(e => e.StudentResponsibleRelationId).HasColumnName("StudentResponsibleRelationID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpStudentStates>(entity =>
            {
                entity.HasKey(e => e.StudentStatusId)
                    .HasName("PK_lkp_StudentStates_StudentStatusID");

                entity.ToTable("lkp_StudentStates");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_StudentStates_Code")
                    .IsUnique();

                entity.Property(e => e.StudentStatusId).HasColumnName("StudentStatusID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.PluralNameAr).HasMaxLength(150);
            });

            modelBuilder.Entity<LkpSubActivity>(entity =>
            {
                entity.HasKey(e => e.SubActivityId)
                    .HasName("PK_lkp_SubActivity_SubActivityID");

                entity.ToTable("lkp_SubActivity");

                entity.Property(e => e.SubActivityId).HasColumnName("SubActivityID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Factor).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.LkpSubActivity)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpSubjects>(entity =>
            {
                entity.HasKey(e => e.SubjectId)
                    .HasName("PK_lkp_Subjects_Subjects");

                entity.ToTable("lkp_Subjects");

                entity.HasIndex(e => e.DisplayOrder)
                    .HasName("IDX_lkp_Subjects_lkp_Subjects");

                entity.HasIndex(e => e.GradeId)
                    .HasName("IDX_lkp_Subjects_GradeID");

                entity.HasIndex(e => e.GroupSubjectId)
                    .HasName("IDX_lkp_Subjects_GroupSubjectID");

                entity.HasIndex(e => e.IsGroupSubject)
                    .HasName("IDX_lkp_Subjects_IsGroupSubject");

                entity.HasIndex(e => e.MaxTotalGrade)
                    .HasName("IDX_lkp_Subjects_MaxTotalGrade");

                entity.HasIndex(e => e.MinTermExam)
                    .HasName("IDX_lkp_Subjects_MinTermExam");

                entity.HasIndex(e => e.MinTotalGrade)
                    .HasName("IDX_lkp_Subjects_MinTotalGrade");

                entity.HasIndex(e => new { e.GradeId, e.NameAr })
                    .HasName("UC_lkp_Subjects_GradeIDNameAr")
                    .IsUnique();

                entity.HasIndex(e => new { e.GradeId, e.NameFr })
                    .HasName("UC_lkp_Subjects_GradeIDNameFr")
                    .IsUnique();

                entity.HasIndex(e => new { e.GradeId, e.SubjectId })
                    .HasName("IDX_lkp_Subjects_GradeIDSubjectID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DisplayNameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayNameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EndedSubjectGroupId).HasColumnName("EndedSubjectGroupID");

                entity.Property(e => e.EnterDegreeByName).HasDefaultValueSql("((0))");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GroupSubjectId).HasColumnName("GroupSubjectID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaxMonthExam).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MaxPracticalGrade).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MaxTermExam).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MaxTotalGrade).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinFinalExam).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinMonthExam).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinPracticalGrade).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinTermExam).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinTermWritten).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinTotalGrade).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SemesterActivityGrade).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SemesterAttendanceGrade).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SemesterBehaviorGrade).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SemesterOralGrade).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.EndedSubjectGroup)
                    .WithMany(p => p.LkpSubjects)
                    .HasForeignKey(d => d.EndedSubjectGroupId);

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.LkpSubjects)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.GroupSubject)
                    .WithMany(p => p.InverseGroupSubject)
                    .HasForeignKey(d => d.GroupSubjectId);
            });

            modelBuilder.Entity<LkpSupplierFunctions>(entity =>
            {
                entity.HasKey(e => e.SupplierFunctionId)
                    .HasName("PK_lkp_SupplierFunctions_SupplierFunctionID");

                entity.ToTable("lkp_SupplierFunctions");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_SupplierFunctions_NameEn")
                    .IsUnique();

                entity.Property(e => e.SupplierFunctionId)
                    .HasColumnName("SupplierFunctionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpTafkitas>(entity =>
            {
                entity.HasKey(e => new { e.Cod, e.Loc })
                    .HasName("lkp_Tafkitas_PK");

                entity.ToTable("lkp_Tafkitas");

                entity.Property(e => e.Cod)
                    .HasColumnName("COD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Loc)
                    .HasColumnName("LOC")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(10);

                entity.Property(e => e.NameE)
                    .HasColumnName("NAME_E")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LkpTeachingSubjects>(entity =>
            {
                entity.HasKey(e => e.TeachingSubjectId)
                    .HasName("PK_lkp_TeachingSubjects_TeachingSubjectID");

                entity.ToTable("lkp_TeachingSubjects");

                entity.Property(e => e.TeachingSubjectId).HasColumnName("TeachingSubjectID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IntegrationId).HasColumnName("IntegrationID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpTermDegreeFunctions>(entity =>
            {
                entity.HasKey(e => e.TermDegreeFunctionId)
                    .HasName("PK_lkp_TermDegreeFunctions_TermDegreeFunctionID");

                entity.ToTable("lkp_TermDegreeFunctions");

                entity.HasIndex(e => new { e.StageId, e.NameAr })
                    .HasName("UC_lkp_TermDegreeFunctions_NameAr")
                    .IsUnique();

                entity.HasIndex(e => new { e.StageId, e.NameFr })
                    .HasName("UC_lkp_TermDegreeFunctions_NameFr")
                    .IsUnique();

                entity.Property(e => e.TermDegreeFunctionId).HasColumnName("TermDegreeFunctionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FunctionUrl)
                    .HasColumnName("FunctionURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Semesters).HasMaxLength(100);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.LkpTermDegreeFunctions)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpThemes>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PK_lkp_Themes_ThemeID");

                entity.ToTable("lkp_Themes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_Themes_NameEn")
                    .IsUnique();

                entity.Property(e => e.ThemeId)
                    .HasColumnName("ThemeID")
                    .HasComment("رقم الثيم")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FilePath)
                    .HasColumnType("ntext")
                    .HasComment("مسار الملف");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasComment("ملحوظات");
            });

            modelBuilder.Entity<LkpTimeZones>(entity =>
            {
                entity.HasKey(e => e.TimeZoneId)
                    .HasName("PK_lkp_TimeZones_TimeZoneID");

                entity.ToTable("lkp_TimeZones");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<LkpToWhomItMayConcerns>(entity =>
            {
                entity.HasKey(e => e.ToWhomItMayConcernId)
                    .HasName("PK_lkp_ToWhomItMayConcerns_ToWhomItMayConcernID");

                entity.ToTable("lkp_ToWhomItMayConcerns");

                entity.Property(e => e.ToWhomItMayConcernId).HasColumnName("ToWhomItMayConcernID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<LkpTransitTypes>(entity =>
            {
                entity.HasKey(e => e.TransitTypeId)
                    .HasName("PK_lkp_TransitTypes_TransitTypeID");

                entity.ToTable("lkp_TransitTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_TransitTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.TransitTypeId).HasColumnName("TransitTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LkpTransportTypes>(entity =>
            {
                entity.HasKey(e => e.TransportTypeId)
                    .HasName("PK_lkp_TransportTypes_TransportTypeID");

                entity.ToTable("lkp_TransportTypes");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_TransportTypes_Code")
                    .IsUnique();

                entity.Property(e => e.TransportTypeId)
                    .HasColumnName("TransportTypeID")
                    .HasComment("رقم نوع وسيلة النقل")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasComment("الكود");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpUnitTypes>(entity =>
            {
                entity.HasKey(e => e.UnitTypeId)
                    .HasName("PK_lkp_UnitTypes_UnitTypeID");

                entity.ToTable("lkp_UnitTypes");

                entity.Property(e => e.UnitTypeId)
                    .HasColumnName("UnitTypeID")
                    .HasComment("رقم نوع الوحدة")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");
            });

            modelBuilder.Entity<LkpUnits>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("PK_lkp_Units_UnitID");

                entity.ToTable("lkp_Units");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_lkp_Units_Code")
                    .IsUnique();

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasComment("رقم الوحدة")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("الكود");

                entity.Property(e => e.ConvertionFactor)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("معامل التحويل");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.UnitTypeId)
                    .HasColumnName("UnitTypeID")
                    .HasComment("رقم نوع الوحدة");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.LkpUnits)
                    .HasForeignKey(d => d.UnitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpVacationCategories>(entity =>
            {
                entity.HasKey(e => e.VacationCategoryId)
                    .HasName("PK_lkp_VacationCategories_VacationCategoryID");

                entity.ToTable("lkp_VacationCategories");

                entity.Property(e => e.VacationCategoryId)
                    .HasColumnName("VacationCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpVacationStates>(entity =>
            {
                entity.HasKey(e => e.VacationStatusId)
                    .HasName("PK_lkp_VacationStates_VacationStatusID");

                entity.ToTable("lkp_VacationStates");

                entity.Property(e => e.VacationStatusId)
                    .HasColumnName("VacationStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpVacationTypes>(entity =>
            {
                entity.HasKey(e => e.VacationTypeId)
                    .HasName("PK_lkp_VacationTypes_VacationStatusID");

                entity.ToTable("lkp_VacationTypes");

                entity.Property(e => e.VacationTypeId).HasColumnName("VacationTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.VacationCategoryId).HasColumnName("VacationCategoryID");

                entity.HasOne(d => d.VacationCategory)
                    .WithMany(p => p.LkpVacationTypes)
                    .HasForeignKey(d => d.VacationCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LkpWaitingListReports>(entity =>
            {
                entity.HasKey(e => e.WaitingListReportId)
                    .HasName("PK_lkp_WaitingListReports_WaitingListReportID");

                entity.ToTable("lkp_WaitingListReports");

                entity.Property(e => e.WaitingListReportId)
                    .HasColumnName("WaitingListReportID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.OrderByExpression).HasMaxLength(500);

                entity.Property(e => e.ReportUrl)
                    .HasColumnName("ReportURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.SortTitle).HasMaxLength(100);

                entity.Property(e => e.WhereConditionExpression).HasMaxLength(500);
            });

            modelBuilder.Entity<LkpWaitingListStates>(entity =>
            {
                entity.HasKey(e => e.WaitingListStatusId)
                    .HasName("PK_lkp_WaitingListStates_WaitingListStatusID");

                entity.ToTable("lkp_WaitingListStates");

                entity.Property(e => e.WaitingListStatusId)
                    .HasColumnName("WaitingListStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);
            });

            modelBuilder.Entity<LkpWithholdingTaxTypes>(entity =>
            {
                entity.HasKey(e => e.WithholdingTaxId)
                    .HasName("PK_lkp_WithholdingTaxTypes_WithholdingTaxID");

                entity.ToTable("lkp_WithholdingTaxTypes");

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_lkp_WithholdingTaxTypes_NameEn")
                    .IsUnique();

                entity.Property(e => e.WithholdingTaxId).HasColumnName("WithholdingTaxID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PercentValue).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TblAccAccountBalances>(entity =>
            {
                entity.HasKey(e => e.AccountBalanceId)
                    .HasName("PK_tbl_acc_AccountBalances_AccountBalanceID");

                entity.ToTable("tbl_acc_AccountBalances");

                entity.HasIndex(e => new { e.AccountId, e.FinancialYearId, e.ClientId, e.SupplierId, e.CurrencyId })
                    .HasName("UC_tbl_acc_AccountBalances_AccountIDFinancialYearIDClientIDSupplierIDCurrencyID")
                    .IsUnique();

                entity.Property(e => e.AccountBalanceId).HasColumnName("AccountBalanceID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocalCurrencyAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TblAccAccountBalances)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblAccAccountBalances)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblAccAccountBalances)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblAccAccountBalances)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblAccAccountBalances)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_acc_AccountBalances_tbl_ServiceProviders_ServiceProviderID");
            });

            modelBuilder.Entity<TblAccAccountCurrencyLinks>(entity =>
            {
                entity.HasKey(e => new { e.FixedAccountId, e.CurrencyId })
                    .HasName("PK_tbl_acc_AccountCurrencyLinks_FixedAccountIDCurrencyID");

                entity.ToTable("tbl_acc_AccountCurrencyLinks");

                entity.Property(e => e.FixedAccountId).HasColumnName("FixedAccountID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TblAccAccountCurrencyLinks)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblAccAccountCurrencyLinks)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FixedAccount)
                    .WithMany(p => p.TblAccAccountCurrencyLinks)
                    .HasForeignKey(d => d.FixedAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAccAccountLinks>(entity =>
            {
                entity.HasKey(e => e.FixedAccountId)
                    .HasName("PK_tbl_acc_AccountLinks_FixedAccountID");

                entity.ToTable("tbl_acc_AccountLinks");

                entity.Property(e => e.FixedAccountId)
                    .HasColumnName("FixedAccountID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TblAccAccountLinks)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FixedAccount)
                    .WithOne(p => p.TblAccAccountLinks)
                    .HasForeignKey<TblAccAccountLinks>(d => d.FixedAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAccAccountPayableDetails>(entity =>
            {
                entity.HasKey(e => e.AccountPayableDetailId)
                    .HasName("PK_tbl_acc_AccountPayableDetails_JournalGenerationTypeID");

                entity.ToTable("tbl_acc_AccountPayableDetails");

                entity.HasIndex(e => new { e.AccountPayableId, e.AccountId, e.ServiceProviderId, e.ClientId })
                    .HasName("UC_AccountPayableIDAccountIDServiceProviderIDClientID")
                    .IsUnique();

                entity.Property(e => e.AccountPayableDetailId).HasColumnName("AccountPayableDetailID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountPayableId).HasColumnName("AccountPayableID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.ItemDescription).HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TblAccAccountPayableDetails)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.AccountPayable)
                    .WithMany(p => p.TblAccAccountPayableDetails)
                    .HasForeignKey(d => d.AccountPayableId);

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblAccAccountPayableDetails)
                    .HasForeignKey(d => d.BookingId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblAccAccountPayableDetails)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.TblAccAccountPayableDetails)
                    .HasForeignKey(d => d.ServiceProviderId);
            });

            modelBuilder.Entity<TblAccAccountPayableJournals>(entity =>
            {
                entity.HasKey(e => new { e.AccountPayableId, e.JournalId })
                    .HasName("PK_tbl_acc_AccountPayableJournals_AccountPayableIDJournalID");

                entity.ToTable("tbl_acc_AccountPayableJournals");

                entity.Property(e => e.AccountPayableId).HasColumnName("AccountPayableID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.AccountPayable)
                    .WithMany(p => p.TblAccAccountPayableJournals)
                    .HasForeignKey(d => d.AccountPayableId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblAccAccountPayableJournals)
                    .HasForeignKey(d => d.JournalId);
            });

            modelBuilder.Entity<TblAccAccountPayables>(entity =>
            {
                entity.HasKey(e => e.AccountPayableId)
                    .HasName("PK_tbl_acc_AccountPayables_AccountPayableID");

                entity.ToTable("tbl_acc_AccountPayables");

                entity.Property(e => e.AccountPayableId).HasColumnName("AccountPayableID");

                entity.Property(e => e.AccountPayableTypeId).HasColumnName("AccountPayableTypeID");

                entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChargedReason).HasColumnType("ntext");

                entity.Property(e => e.ChequeSettlementDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeSettlementExchangeRate)
                    .HasColumnType("numeric(18, 3)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DepositOrcheckOrtransferDate)
                    .HasColumnName("DepositORCheckORTransferDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositOrcheckOrtransferNumber)
                    .HasColumnName("DepositORCheckORTransferNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PayableDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");

                entity.Property(e => e.ToName).HasMaxLength(100);

                entity.Property(e => e.TotalExpense).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalJournalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TreasuryId).HasColumnName("TreasuryID");

                entity.Property(e => e.WithholdingTaxId).HasColumnName("WithholdingTaxID");

                entity.Property(e => e.WithholdingTaxValue).HasColumnType("numeric(18, 3)");

                entity.HasOne(d => d.AccountPayableType)
                    .WithMany(p => p.TblAccAccountPayables)
                    .HasForeignKey(d => d.AccountPayableTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.TblAccAccountPayables)
                    .HasForeignKey(d => d.BankAccountId);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblAccAccountPayables)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblAccAccountPayables)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblAccAccountPayables)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.TblAccAccountPayables)
                    .HasForeignKey(d => d.ServiceProviderId);

                entity.HasOne(d => d.Treasury)
                    .WithMany(p => p.TblAccAccountPayables)
                    .HasForeignKey(d => d.TreasuryId);

                entity.HasOne(d => d.WithholdingTax)
                    .WithMany(p => p.TblAccAccountPayables)
                    .HasForeignKey(d => d.WithholdingTaxId);
            });

            modelBuilder.Entity<TblAccAccounts>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK_tbl_acc_Accounts_AccountID");

                entity.ToTable("tbl_acc_Accounts");

                entity.HasIndex(e => e.AccountNumber)
                    .HasName("IDX_tbl_acc_Accounts_AccountNumber");

                entity.HasIndex(e => e.Code)
                    .HasName("IDX_tbl_acc_Accounts_Code");

                entity.HasIndex(e => e.NameAr)
                    .HasName("IDX_tbl_acc_Accounts_NameAr");

                entity.HasIndex(e => e.NameEn)
                    .HasName("IDX_tbl_acc_Accounts_NameEn");

                entity.HasIndex(e => e.ParentAccountId)
                    .HasName("IDX_tbl_acc_Accounts_ParentAccountID");

                entity.HasIndex(e => new { e.Code, e.AccountSegmentId, e.ParentAccountId })
                    .HasName("UC_tbl_acc_Accounts_CodeAccountSegmentIDParentAccountID")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.AccountSegmentId).HasColumnName("AccountSegmentID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ParentAccountId).HasColumnName("ParentAccountID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SubActivityId).HasColumnName("SubActivityID");

                entity.HasOne(d => d.AccountSegment)
                    .WithMany(p => p.TblAccAccounts)
                    .HasForeignKey(d => d.AccountSegmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.TblAccAccounts)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TblAccAccounts)
                    .HasForeignKey(d => d.ActivityId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblAccAccounts)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_acc_Accounts_lkp_Currencies_AccountSegmentID");

                entity.HasOne(d => d.ParentAccount)
                    .WithMany(p => p.InverseParentAccount)
                    .HasForeignKey(d => d.ParentAccountId);

                entity.HasOne(d => d.SubActivity)
                    .WithMany(p => p.TblAccAccounts)
                    .HasForeignKey(d => d.SubActivityId);
            });

            modelBuilder.Entity<TblAccExchangeRates>(entity =>
            {
                entity.HasKey(e => e.ExchangeRateId)
                    .HasName("PK_tbl_acc_ExchangeRates_ExchangeRateID");

                entity.ToTable("tbl_acc_ExchangeRates");

                entity.HasIndex(e => new { e.FromCurrencyId, e.ToCurrencyId, e.ValidFrom })
                    .HasName("UC_tbl_acc_ExchangeRates_FromCurrencyIDToCurrencyIDValidFrom")
                    .IsUnique();

                entity.Property(e => e.ExchangeRateId).HasColumnName("ExchangeRateID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.FromCurrencyId).HasColumnName("FromCurrencyID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ToCurrencyId).HasColumnName("ToCurrencyID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.HasOne(d => d.FromCurrency)
                    .WithMany(p => p.TblAccExchangeRatesFromCurrency)
                    .HasForeignKey(d => d.FromCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ToCurrency)
                    .WithMany(p => p.TblAccExchangeRatesToCurrency)
                    .HasForeignKey(d => d.ToCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAccJournalAttachments>(entity =>
            {
                entity.HasKey(e => e.JournalAttachmentId)
                    .HasName("PK_tbl_acc_JournalAttachments_JournalAttachmentID");

                entity.ToTable("tbl_acc_JournalAttachments");

                entity.Property(e => e.JournalAttachmentId).HasColumnName("JournalAttachmentID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName).HasColumnType("ntext");

                entity.Property(e => e.FormNumber).HasMaxLength(50);

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblAccJournalAttachments)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAccJournalDetails>(entity =>
            {
                entity.HasKey(e => e.JournalDetailId)
                    .HasName("PK_tbl_acc_JournalDetails_JournalDetailID");

                entity.ToTable("tbl_acc_JournalDetails");

                entity.HasIndex(e => e.JournalId)
                    .HasName("IDX_tbl_acc_JournalDetails_JournalID");

                entity.Property(e => e.JournalDetailId).HasColumnName("JournalDetailID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TblAccJournalDetails)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblAccJournalDetails)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblAccJournalDetails)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblAccJournalDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_acc_JournalDetails_tbl_ServiceProviders_ServiceProviderID");
            });

            modelBuilder.Entity<TblAccJournals>(entity =>
            {
                entity.HasKey(e => e.JournalId)
                    .HasName("PK_tbl_acc_Journals_JournalID");

                entity.ToTable("tbl_acc_Journals");

                entity.HasIndex(e => e.FinancialYearId)
                    .HasName("IDX_tbl_acc_Journals_FinancialYearID");

                entity.HasIndex(e => new { e.FinancialYearId, e.TransactionNum })
                    .HasName("UC_tbl_acc_Journals_FinancialYearIDTransactionNum")
                    .IsUnique();

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("numeric(18, 3)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.JournalGenerationTypeId).HasColumnName("JournalGenerationTypeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostUserId).HasColumnName("PostUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionName).HasMaxLength(200);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblAccJournals)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_acc_Journals_lkp_Currencies_AccountSegmentID");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblAccJournals)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.JournalGenerationType)
                    .WithMany(p => p.TblAccJournals)
                    .HasForeignKey(d => d.JournalGenerationTypeId)
                    .HasConstraintName("FK_tbl_Invoices_lkp_acc_JournalGenerationTypes_JournalGenerationTypeID");

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.TblAccJournals)
                    .HasForeignKey(d => d.MonthId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAccSupplierInvoiceAttachments>(entity =>
            {
                entity.HasKey(e => e.SupplierInvoiceAttachmentId)
                    .HasName("PK_tbl_acc_SupplierInvoiceAttachments_SupplierInvoiceAttachmentID");

                entity.ToTable("tbl_acc_SupplierInvoiceAttachments");

                entity.Property(e => e.SupplierInvoiceAttachmentId).HasColumnName("SupplierInvoiceAttachmentID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName).HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoiceID");

                entity.HasOne(d => d.SupplierInvoice)
                    .WithMany(p => p.TblAccSupplierInvoiceAttachments)
                    .HasForeignKey(d => d.SupplierInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_acc_SupplierInvoiceAttachments_tbl_acc_SupplierInvoices");
            });

            modelBuilder.Entity<TblAccSupplierInvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.SupplierInvoiceDetailId)
                    .HasName("PK_tbl_acc_SupplierInvoiceDetails_SupplierInvoiceDetailID");

                entity.ToTable("tbl_acc_SupplierInvoiceDetails");

                entity.HasIndex(e => new { e.SupplierInvoiceId, e.ServiceId })
                    .HasName("UC_tbl_acc_SupplierInvoiceDetails_SupplierInvoiceIDServiceID")
                    .IsUnique();

                entity.Property(e => e.SupplierInvoiceDetailId).HasColumnName("SupplierInvoiceDetailID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.ItemDescription).HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoiceID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblAccSupplierInvoiceDetails)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SupplierInvoice)
                    .WithMany(p => p.TblAccSupplierInvoiceDetails)
                    .HasForeignKey(d => d.SupplierInvoiceId);
            });

            modelBuilder.Entity<TblAccSupplierInvoiceJournals>(entity =>
            {
                entity.HasKey(e => new { e.SupplierInvoiceId, e.JournalId })
                    .HasName("PK_tbl_acc_SupplierInvoiceJournals_SupplierInvoiceIDJournalID");

                entity.ToTable("tbl_acc_SupplierInvoiceJournals");

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoiceID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblAccSupplierInvoiceJournals)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("FK_tbl_acc_SupplierInvoiceJournals_tbl_acc_Journals");

                entity.HasOne(d => d.SupplierInvoice)
                    .WithMany(p => p.TblAccSupplierInvoiceJournals)
                    .HasForeignKey(d => d.SupplierInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_acc_SupplierInvoiceJournals_tbl_acc_SupplierInvoices");
            });

            modelBuilder.Entity<TblAccSupplierInvoices>(entity =>
            {
                entity.HasKey(e => e.SupplierInvoiceId)
                    .HasName("PK_tbl_acc_SupplierInvoices_SupplierInvoiceID");

                entity.ToTable("tbl_acc_SupplierInvoices");

                entity.HasIndex(e => new { e.FinancialYearId, e.SerialNumber })
                    .HasName("UC_tbl_acc_SupplierInvoices_FinancialYearID_SerialNumber")
                    .IsUnique();

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoiceID");

                entity.Property(e => e.AccountingReviewDate).HasColumnType("datetime");

                entity.Property(e => e.AccountingReviewerUserId).HasColumnName("AccountingReviewerUserID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceSerial).HasMaxLength(200);

                entity.Property(e => e.IsWaitingJournalGeneration)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TaxValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalValue).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.AccountingReviewerUser)
                    .WithMany(p => p.TblAccSupplierInvoices)
                    .HasForeignKey(d => d.AccountingReviewerUserId);

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblAccSupplierInvoices)
                    .HasForeignKey(d => d.BookingId);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblAccSupplierInvoices)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblAccSupplierInvoices)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblAccSupplierInvoices)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblAccSupplierInvoices)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.TblAccSupplierInvoices)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAccountPayableSupplierInvoiceLinks>(entity =>
            {
                entity.HasKey(e => new { e.AccountPayableId, e.SupplierInvoiceId })
                    .HasName("PK_tbl_AccountPayableSupplierInvoiceLinks_AccountPayableIDSupplierInvoiceID");

                entity.ToTable("tbl_AccountPayableSupplierInvoiceLinks");

                entity.Property(e => e.AccountPayableId).HasColumnName("AccountPayableID");

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoiceID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PaidValue).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.AccountPayable)
                    .WithMany(p => p.TblAccountPayableSupplierInvoiceLinks)
                    .HasForeignKey(d => d.AccountPayableId);

                entity.HasOne(d => d.SupplierInvoice)
                    .WithMany(p => p.TblAccountPayableSupplierInvoiceLinks)
                    .HasForeignKey(d => d.SupplierInvoiceId);
            });

            modelBuilder.Entity<TblAccountShareSettings>(entity =>
            {
                entity.HasKey(e => e.AccountShareSettingId);

                entity.ToTable("tbl_AccountShareSettings");

                entity.HasIndex(e => e.AccountId)
                    .HasName("UC_tbl_AccountShareSettings_AccountID")
                    .IsUnique();

                entity.Property(e => e.AccountShareSettingId).HasColumnName("AccountShareSettingID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.TblAccountShareSettings)
                    .HasForeignKey<TblAccountShareSettings>(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAccountUserDefinedSharePercentages>(entity =>
            {
                entity.HasKey(e => e.AccountUserDefinedSharePercentageId);

                entity.ToTable("tbl_AccountUserDefinedSharePercentages");

                entity.Property(e => e.AccountUserDefinedSharePercentageId).HasColumnName("AccountUserDefinedSharePercentageID");

                entity.Property(e => e.AccountPayableDetailId).HasColumnName("AccountPayableDetailID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.InvoicePaymentDetailId).HasColumnName("InvoicePaymentDetailID");

                entity.Property(e => e.JournalDetailId).HasColumnName("JournalDetailID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SubActivityId).HasColumnName("SubActivityID");

                entity.HasOne(d => d.AccountPayableDetail)
                    .WithMany(p => p.TblAccountUserDefinedSharePercentages)
                    .HasForeignKey(d => d.AccountPayableDetailId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.InvoicePaymentDetail)
                    .WithMany(p => p.TblAccountUserDefinedSharePercentages)
                    .HasForeignKey(d => d.InvoicePaymentDetailId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.JournalDetail)
                    .WithMany(p => p.TblAccountUserDefinedSharePercentages)
                    .HasForeignKey(d => d.JournalDetailId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.SubActivity)
                    .WithMany(p => p.TblAccountUserDefinedSharePercentages)
                    .HasForeignKey(d => d.SubActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAstAssetActionJournals>(entity =>
            {
                entity.HasKey(e => new { e.AssetActionId, e.JournalId })
                    .HasName("PK_tbl_ast_AssetActionJournals_AssetActionIDJournalID");

                entity.ToTable("tbl_ast_AssetActionJournals");

                entity.Property(e => e.AssetActionId).HasColumnName("AssetActionID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.AssetAction)
                    .WithMany(p => p.TblAstAssetActionJournals)
                    .HasForeignKey(d => d.AssetActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblAstAssetActionJournals)
                    .HasForeignKey(d => d.JournalId);
            });

            modelBuilder.Entity<TblAstAssetActions>(entity =>
            {
                entity.HasKey(e => e.AssetActionId);

                entity.ToTable("tbl_ast_AssetActions");

                entity.Property(e => e.AssetActionId).HasColumnName("AssetActionID");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.AssetActionTypeId).HasColumnName("AssetActionTypeID");

                entity.Property(e => e.AssetProfitAccountId).HasColumnName("AssetProfitAccountID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.ExclusionReason).HasColumnType("ntext");

                entity.Property(e => e.FromAssetId).HasColumnName("FromAssetID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.ReceivableNumber).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SellingPrice).HasColumnType("numeric(18, 11)");

                entity.Property(e => e.SubActivityId).HasColumnName("SubActivityID");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TblAstAssetActions)
                    .HasForeignKey(d => d.ActivityId);

                entity.HasOne(d => d.AssetActionType)
                    .WithMany(p => p.TblAstAssetActions)
                    .HasForeignKey(d => d.AssetActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AssetProfitAccount)
                    .WithMany(p => p.TblAstAssetActions)
                    .HasForeignKey(d => d.AssetProfitAccountId);

                entity.HasOne(d => d.FromAsset)
                    .WithMany(p => p.TblAstAssetActions)
                    .HasForeignKey(d => d.FromAssetId);

                entity.HasOne(d => d.SubActivity)
                    .WithMany(p => p.TblAstAssetActions)
                    .HasForeignKey(d => d.SubActivityId);
            });

            modelBuilder.Entity<TblAstAssetDepreciationPeriods>(entity =>
            {
                entity.HasKey(e => e.AssetDepreciationPeriodId);

                entity.ToTable("tbl_ast_AssetDepreciationPeriods");

                entity.HasIndex(e => new { e.FinancialYearId, e.ToDate })
                    .HasName("UC_tbl_ast_AssetDepreciationPeriods_FinancialYearID_ToDate")
                    .IsUnique();

                entity.Property(e => e.AssetDepreciationPeriodId).HasColumnName("AssetDepreciationPeriodID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblAstAssetDepreciationPeriods)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblAstAssetDepreciations>(entity =>
            {
                entity.HasKey(e => e.AssetDepreciationId);

                entity.ToTable("tbl_ast_AssetDepreciations");

                entity.Property(e => e.AssetDepreciationId).HasColumnName("AssetDepreciationID");

                entity.Property(e => e.AssetAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AssetDepreciationPeriodId).HasColumnName("AssetDepreciationPeriodID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DepreciationAmount).HasColumnType("numeric(18, 11)");

                entity.Property(e => e.DepreciationPercentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.TotalDepreciationAmountAfter).HasColumnType("numeric(18, 11)");

                entity.HasOne(d => d.AssetDepreciationPeriod)
                    .WithMany(p => p.TblAstAssetDepreciations)
                    .HasForeignKey(d => d.AssetDepreciationPeriodId);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.TblAstAssetDepreciations)
                    .HasForeignKey(d => d.AssetId);
            });

            modelBuilder.Entity<TblAstAssets>(entity =>
            {
                entity.HasKey(e => e.AssetId)
                    .HasName("PK_tbl_ast_Assets_AssetID");

                entity.ToTable("tbl_ast_Assets");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.AssetAccountId).HasColumnName("AssetAccountID");

                entity.Property(e => e.AssetItemTypeId).HasColumnName("AssetItemTypeID");

                entity.Property(e => e.AssetSerialNumber).HasMaxLength(100);

                entity.Property(e => e.AssetStatusId).HasColumnName("AssetStatusID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CsvserialNumber).HasColumnName("CSVSerialNumber");

                entity.Property(e => e.DepreciationAccountId).HasColumnName("DepreciationAccountID");

                entity.Property(e => e.DepreciationCalculationTypeId).HasColumnName("DepreciationCalculationTypeID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.EndOfGuaranteeDate).HasColumnType("datetime");

                entity.Property(e => e.GuaranteeDetails).HasColumnType("ntext");

                entity.Property(e => e.InServiceDate).HasColumnType("datetime");

                entity.Property(e => e.IntialTotalDepreciationAmount).HasColumnType("numeric(18, 11)");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarkName).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.MovedAssetActionId).HasColumnName("MovedAssetActionID");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PageNumber).HasMaxLength(100);

                entity.Property(e => e.PayableReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ResponsibleEmployee).HasMaxLength(100);

                entity.Property(e => e.StartDepreciationDate).HasColumnType("datetime");

                entity.Property(e => e.SubActivityId).HasColumnName("SubActivityID");

                entity.Property(e => e.SupplierName).HasMaxLength(200);

                entity.Property(e => e.TotalDepreciationAccountId).HasColumnName("TotalDepreciationAccountID");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TblAstAssets)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AssetAccount)
                    .WithMany(p => p.TblAstAssetsAssetAccount)
                    .HasForeignKey(d => d.AssetAccountId);

                entity.HasOne(d => d.AssetItemType)
                    .WithMany(p => p.TblAstAssets)
                    .HasForeignKey(d => d.AssetItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AssetStatus)
                    .WithMany(p => p.TblAstAssets)
                    .HasForeignKey(d => d.AssetStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DepreciationAccount)
                    .WithMany(p => p.TblAstAssetsDepreciationAccount)
                    .HasForeignKey(d => d.DepreciationAccountId);

                entity.HasOne(d => d.DepreciationCalculationType)
                    .WithMany(p => p.TblAstAssets)
                    .HasForeignKey(d => d.DepreciationCalculationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MovedAssetAction)
                    .WithMany(p => p.TblAstAssets)
                    .HasForeignKey(d => d.MovedAssetActionId);

                entity.HasOne(d => d.SubActivity)
                    .WithMany(p => p.TblAstAssets)
                    .HasForeignKey(d => d.SubActivityId);

                entity.HasOne(d => d.TotalDepreciationAccount)
                    .WithMany(p => p.TblAstAssetsTotalDepreciationAccount)
                    .HasForeignKey(d => d.TotalDepreciationAccountId);
            });

            modelBuilder.Entity<TblAuditTrails>(entity =>
            {
                entity.HasKey(e => e.AuditTrailId)
                    .HasName("PK_tbl_AuditTrails_AuditTrailID");

                entity.ToTable("tbl_AuditTrails");

                entity.HasIndex(e => e.NewValue)
                    .HasName("idx_tbl_AuditTrails_NewValue");

                entity.HasIndex(e => e.OldValue)
                    .HasName("idx_tbl_AuditTrails_OldValue");

                entity.Property(e => e.AuditTrailId)
                    .HasColumnName("AuditTrailID")
                    .HasComment("رقم متابعة التعديلات");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .HasComment("رقم الحدث");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FieldID")
                    .HasComment("رقم الحقل");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NewName).HasMaxLength(500);

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("القيمة الحديثة");

                entity.Property(e => e.OldName).HasMaxLength(500);

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("القيمة القديمة");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasComment("ملاحظات");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.TblAuditTrails)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.TblAuditTrails)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblBookingAttachments>(entity =>
            {
                entity.HasKey(e => e.BookingAttachmentId)
                    .HasName("PK_tbl_BookingAttachments_BookingAttachmentID");

                entity.ToTable("tbl_BookingAttachments");

                entity.Property(e => e.BookingAttachmentId)
                    .HasColumnName("BookingAttachmentID")
                    .HasComment("رقم مرفق الحجز");

                entity.Property(e => e.BookingId)
                    .HasColumnName("BookingID")
                    .HasComment("رقم الحجز");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("رقم المستند");

                entity.Property(e => e.FileName)
                    .HasColumnType("ntext")
                    .HasComment("اسم الملف");

                entity.Property(e => e.FormNumber).HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasComment("ملحوظات");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblBookingAttachments)
                    .HasForeignKey(d => d.BookingId);
            });

            modelBuilder.Entity<TblBookingDetails>(entity =>
            {
                entity.HasKey(e => e.BookingDetailId)
                    .HasName("PK_tbl_BookingDetails_BookingDetailID");

                entity.ToTable("tbl_BookingDetails");

                entity.Property(e => e.BookingDetailId)
                    .HasColumnName("BookingDetailID")
                    .HasComment("رقم تفاصيل الحجز");

                entity.Property(e => e.BookingId)
                    .HasColumnName("BookingID")
                    .HasComment("رقم الحجز");

                entity.Property(e => e.CargoCategoryId)
                    .HasColumnName("CargoCategoryID")
                    .HasComment("رقم نوع البضاعة");

                entity.Property(e => e.ContainerCount)
                    .HasDefaultValueSql("((0))")
                    .HasComment("عدد الحاوية");

                entity.Property(e => e.ContainerLoadTypeId).HasColumnName("ContainerLoadTypeID");

                entity.Property(e => e.ContainerNumber)
                    .HasMaxLength(15)
                    .HasComment("رقم الحاوية");

                entity.Property(e => e.ContainerSizeId)
                    .HasColumnName("ContainerSizeID")
                    .HasComment("رقم حجم الحاوية");

                entity.Property(e => e.ContainerTypeId)
                    .HasColumnName("ContainerTypeID")
                    .HasComment("رقم نوع الحاوية");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.HscodeId).HasColumnName("HSCodeID");

                entity.Property(e => e.ImoclassId)
                    .HasColumnName("IMOClassID")
                    .HasComment("رقم مستوي الخطر");

                entity.Property(e => e.IsExplosives).HasComment("قابل للانفجار");

                entity.Property(e => e.IsImo)
                    .HasColumnName("IsIMO")
                    .HasComment("خطر");

                entity.Property(e => e.IsOog)
                    .HasColumnName("IsOOG")
                    .HasComment("مرتفع");

                entity.Property(e => e.ItemDescription)
                    .HasColumnType("ntext")
                    .HasComment("وصف الوحدة");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarksAndNumbers)
                    .HasColumnType("ntext")
                    .HasComment("العلامات والارقام");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NetWeight).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.PackageTypeId)
                    .HasColumnName("PackageTypeID")
                    .HasComment("رقم نوع العبوة");

                entity.Property(e => e.Quantity)
                    .HasDefaultValueSql("((1))")
                    .HasComment("الكمية");

                entity.Property(e => e.RatePerKilo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RatePerKiloCurrencyId).HasColumnName("RatePerKiloCurrencyID");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasComment("ملحوظات");

                entity.Property(e => e.SealNumber).HasMaxLength(50);

                entity.Property(e => e.Temperature)
                    .HasMaxLength(50)
                    .HasComment("الحرارة");

                entity.Property(e => e.Volume)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("الحجم");

                entity.Property(e => e.Weight)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("الوزن");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.BookingId);

                entity.HasOne(d => d.CargoCategory)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.CargoCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ContainerLoadType)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.ContainerLoadTypeId);

                entity.HasOne(d => d.ContainerSize)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.ContainerSizeId);

                entity.HasOne(d => d.ContainerType)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.ContainerTypeId);

                entity.HasOne(d => d.Hscode)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.HscodeId);

                entity.HasOne(d => d.Imoclass)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.ImoclassId);

                entity.HasOne(d => d.PackageType)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.PackageTypeId);

                entity.HasOne(d => d.RatePerKiloCurrency)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.RatePerKiloCurrencyId);
            });

            modelBuilder.Entity<TblBookingSharing>(entity =>
            {
                entity.HasKey(e => e.BookingSharingId)
                    .HasName("PK_tbl_BookingSharing_BookingSharingID");

                entity.ToTable("tbl_BookingSharing");

                entity.HasIndex(e => new { e.BookingId, e.UserId })
                    .HasName("UC_tbl_Bookings_BookingID_tbl_Users_UserID")
                    .IsUnique();

                entity.Property(e => e.BookingSharingId).HasColumnName("BookingSharingID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblBookingSharing)
                    .HasForeignKey(d => d.BookingId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblBookingSharing)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TblBookingTracking>(entity =>
            {
                entity.HasKey(e => e.BookingTrackingId)
                    .HasName("PK_tbl_BookingTracking_BookingTrackingID");

                entity.ToTable("tbl_BookingTracking");

                entity.Property(e => e.BookingTrackingId).HasColumnName("BookingTrackingID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.BookingTrackingStatusId).HasColumnName("BookingTrackingStatusID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PortId).HasColumnName("PortID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblBookingTracking)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK_tbl_BookingTracking_tbl_Bookings_BookingsID");

                entity.HasOne(d => d.BookingTrackingStatus)
                    .WithMany(p => p.TblBookingTracking)
                    .HasForeignKey(d => d.BookingTrackingStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Port)
                    .WithMany(p => p.TblBookingTracking)
                    .HasForeignKey(d => d.PortId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblBookingTrucking>(entity =>
            {
                entity.HasKey(e => e.BookingTruckingId)
                    .HasName("PK_BookingTruckingID_ClientStatusID");

                entity.ToTable("tbl_BookingTrucking");

                entity.Property(e => e.BookingTruckingId).HasColumnName("BookingTruckingID");

                entity.Property(e => e.ArrivedDate).HasColumnType("datetime");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(100);

                entity.Property(e => e.ContainerSizeId).HasColumnName("ContainerSizeID");

                entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DriverLicenseNumber).HasMaxLength(100);

                entity.Property(e => e.DriverMobile).HasMaxLength(100);

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FromLocation).HasMaxLength(100);

                entity.Property(e => e.HandOverDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LeavingDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.ToLocation).HasMaxLength(100);

                entity.Property(e => e.TruckerId).HasColumnName("TruckerID");

                entity.Property(e => e.TruckingNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblBookingTrucking)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK_BookingTruckingID_tbl_Bookings_BookingID");

                entity.HasOne(d => d.ContainerSize)
                    .WithMany(p => p.TblBookingTrucking)
                    .HasForeignKey(d => d.ContainerSizeId)
                    .HasConstraintName("FK_BookingTruckingID_lkp_ContainerSizes_ContainerSizeID");

                entity.HasOne(d => d.ContainerType)
                    .WithMany(p => p.TblBookingTrucking)
                    .HasForeignKey(d => d.ContainerTypeId)
                    .HasConstraintName("FK_BookingTruckingID_lkp_ContainerTypes_ContainerTypeID");

                entity.HasOne(d => d.Trucker)
                    .WithMany(p => p.TblBookingTrucking)
                    .HasForeignKey(d => d.TruckerId)
                    .HasConstraintName("FK_BookingTruckingID_tbl_ServiceProviders_TruckerID");
            });

            modelBuilder.Entity<TblBookings>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK_tbl_Bookings_BookingID");

                entity.ToTable("tbl_Bookings");

                entity.HasIndex(e => e.JobReference);

                entity.Property(e => e.BookingId)
                    .HasColumnName("BookingID")
                    .HasComment("رقم معرف الحجز");

                entity.Property(e => e.ActualArrival).HasColumnType("datetime");

                entity.Property(e => e.ActualDeparture).HasColumnType("datetime");

                entity.Property(e => e.AirFirstMasterBlnumber)
                    .HasColumnName("AirFirstMasterBLNumber")
                    .HasMaxLength(5);

                entity.Property(e => e.AirSecondMasterBlnumber)
                    .HasColumnName("AirSecondMasterBLNumber")
                    .HasMaxLength(5);

                entity.Property(e => e.AirThirdMasterBlnumber)
                    .HasColumnName("AirThirdMasterBLNumber")
                    .HasMaxLength(5);

                entity.Property(e => e.BlockingReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.BlockingReleaseRemarks).HasColumnType("ntext");

                entity.Property(e => e.BlockingReleaseUserId).HasColumnName("BlockingReleaseUserID");

                entity.Property(e => e.BolissueDate)
                    .HasColumnName("BOLIssueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookingConsolidationId).HasColumnName("BookingConsolidationID");

                entity.Property(e => e.BookingInvoiceUnApprovalUserId).HasColumnName("BookingInvoiceUnApprovalUserID");

                entity.Property(e => e.BookingIssueDate).HasColumnType("datetime");

                entity.Property(e => e.BookingRefrence).HasMaxLength(100);

                entity.Property(e => e.BookingStatusId)
                    .HasColumnName("BookingStatusID")
                    .HasComment("حالة الحجز");

                entity.Property(e => e.BookingTypeId)
                    .HasColumnName("BookingTypeID")
                    .HasComment("رقم نوع الحجز");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChargesAtDestination).HasMaxLength(100);

                entity.Property(e => e.ChargesDueAgent1).HasMaxLength(100);

                entity.Property(e => e.ChargesDueAgent2).HasMaxLength(100);

                entity.Property(e => e.ChargesDueCarrier1).HasMaxLength(100);

                entity.Property(e => e.ChargesDueCarrier2).HasMaxLength(100);

                entity.Property(e => e.ChargesInDestinationCurrency).HasMaxLength(100);

                entity.Property(e => e.ConsigneeAddress)
                    .HasColumnType("ntext")
                    .HasComment("عنوان المرسل اليه");

                entity.Property(e => e.ConsigneeContactPersonId).HasColumnName("ConsigneeContactPersonID");

                entity.Property(e => e.ConsigneeId).HasColumnName("ConsigneeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyConversionRates).HasMaxLength(100);

                entity.Property(e => e.CustomClearanceVendorAddress).HasColumnType("ntext");

                entity.Property(e => e.CustomClearanceVendorDurationPeriod).HasMaxLength(100);

                entity.Property(e => e.CustomClearanceVendorId).HasColumnName("CustomClearanceVendorID");

                entity.Property(e => e.CustomClearanceVendorNotes).HasColumnType("ntext");

                entity.Property(e => e.CustomsDealerId)
                    .HasColumnName("CustomsDealerID")
                    .HasComment("المستخلص الجمركي");

                entity.Property(e => e.CustomsDealerMobile).HasMaxLength(100);

                entity.Property(e => e.CutOffDateHandOverDate)
                    .HasColumnName("CutOffDate_HandOverDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryTermId).HasColumnName("DeliveryTermID");

                entity.Property(e => e.Description)
                    .HasColumnType("ntext")
                    .HasComment("الوصف");

                entity.Property(e => e.Docount).HasColumnName("DOCount");

                entity.Property(e => e.Donumber)
                    .HasColumnName("DONumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Edd)
                    .HasColumnName("EDD")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndorsementDate).HasColumnType("datetime");

                entity.Property(e => e.EndorsementNumber).HasMaxLength(100);

                entity.Property(e => e.EndorsementSubmittedToName).HasMaxLength(100);

                entity.Property(e => e.EndorsementToName).HasMaxLength(100);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinalDestinationPortId)
                    .HasColumnName("FinalDestinationPortID")
                    .HasComment("ميناء الوصول");

                entity.Property(e => e.FirstNotifierAddress).HasColumnType("ntext");

                entity.Property(e => e.FirstNotifierContactPersonId).HasColumnName("FirstNotifierContactPersonID");

                entity.Property(e => e.FirstNotifierId).HasColumnName("FirstNotifierID");

                entity.Property(e => e.FirstTransitPortId).HasColumnName("FirstTransitPortID");

                entity.Property(e => e.FwagentAddress)
                    .HasColumnName("FWAgentAddress")
                    .HasColumnType("ntext");

                entity.Property(e => e.FwagentId)
                    .HasColumnName("FWAgentID")
                    .HasComment("الوكيل");

                entity.Property(e => e.FwagentPersonId).HasColumnName("FWAgentPersonID");

                entity.Property(e => e.HouseBlcode)
                    .HasColumnName("HouseBLCode")
                    .HasMaxLength(100);

                entity.Property(e => e.HouseBlnumber)
                    .HasColumnName("HouseBLNumber")
                    .HasComment("رقم البوليصة الهووس");

                entity.Property(e => e.HouseConsolidationCodeId).HasColumnName("HouseConsolidationCodeID");

                entity.Property(e => e.IsFdpsameAsPod).HasColumnName("IsFDPSameAsPOD");

                entity.Property(e => e.JobReference)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineAttention).HasMaxLength(100);

                entity.Property(e => e.MasterBlnumber)
                    .HasColumnName("MasterBLNumber")
                    .HasMaxLength(20)
                    .HasComment("رقم البوليصة");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.OtherCharges).HasMaxLength(100);

                entity.Property(e => e.PortOfDischargeId)
                    .HasColumnName("PortOfDischargeID")
                    .HasComment("ميناء التفريغ");

                entity.Property(e => e.PortOfLoadId)
                    .HasColumnName("PortOfLoadID")
                    .HasComment("ميناء الشاحن");

                entity.Property(e => e.PreAlertDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasComment("ملاحظات");

                entity.Property(e => e.ResponsibleUserId).HasColumnName("ResponsibleUserID");

                entity.Property(e => e.SecondNotifierAddress).HasColumnType("ntext");

                entity.Property(e => e.SecondNotifierContactPersonId).HasColumnName("SecondNotifierContactPersonID");

                entity.Property(e => e.SecondNotifierId).HasColumnName("SecondNotifierID");

                entity.Property(e => e.SecondTransitPortId).HasColumnName("SecondTransitPortID");

                entity.Property(e => e.ShipperAddress).HasColumnType("ntext");

                entity.Property(e => e.ShipperContactPersonId).HasColumnName("ShipperContactPersonID");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.ShippingNotes).HasColumnType("ntext");

                entity.Property(e => e.ShowHblinEndorsementLetter).HasColumnName("ShowHBLInEndorsementLetter");

                entity.Property(e => e.SupplierAgentContactPersonsId).HasColumnName("SupplierAgentContactPersonsID");

                entity.Property(e => e.SupplierAgentId).HasColumnName("SupplierAgentID");

                entity.Property(e => e.TotalCollect).HasMaxLength(100);

                entity.Property(e => e.TotalCollectCharges).HasMaxLength(100);

                entity.Property(e => e.TotalPrepaid).HasMaxLength(100);

                entity.Property(e => e.TruckContractorId)
                    .HasColumnName("TruckContractorID")
                    .HasComment("مقاول الشحن");

                entity.Property(e => e.VesselName).HasMaxLength(100);

                entity.Property(e => e.VoyageNumber).HasMaxLength(20);

                entity.HasOne(d => d.BlockingReleaseUser)
                    .WithMany(p => p.TblBookingsBlockingReleaseUser)
                    .HasForeignKey(d => d.BlockingReleaseUserId);

                entity.HasOne(d => d.BookingConsolidation)
                    .WithMany(p => p.InverseBookingConsolidation)
                    .HasForeignKey(d => d.BookingConsolidationId)
                    .HasConstraintName("FK_tbl_Bookings_tbl_Booking_BookingConsolidationID");

                entity.HasOne(d => d.BookingStatus)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.BookingStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BookingType)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.BookingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ConsigneeContactPerson)
                    .WithMany(p => p.TblBookingsConsigneeContactPerson)
                    .HasForeignKey(d => d.ConsigneeContactPersonId);

                entity.HasOne(d => d.Consignee)
                    .WithMany(p => p.TblBookingsConsignee)
                    .HasForeignKey(d => d.ConsigneeId);

                entity.HasOne(d => d.CustomClearanceVendor)
                    .WithMany(p => p.TblBookingsCustomClearanceVendor)
                    .HasForeignKey(d => d.CustomClearanceVendorId);

                entity.HasOne(d => d.CustomsDealer)
                    .WithMany(p => p.TblBookingsCustomsDealer)
                    .HasForeignKey(d => d.CustomsDealerId);

                entity.HasOne(d => d.DeliveryTerm)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.DeliveryTermId);

                entity.HasOne(d => d.FinalDestinationPort)
                    .WithMany(p => p.TblBookingsFinalDestinationPort)
                    .HasForeignKey(d => d.FinalDestinationPortId);

                entity.HasOne(d => d.FirstNotifierContactPerson)
                    .WithMany(p => p.TblBookingsFirstNotifierContactPerson)
                    .HasForeignKey(d => d.FirstNotifierContactPersonId);

                entity.HasOne(d => d.FirstNotifier)
                    .WithMany(p => p.TblBookingsFirstNotifier)
                    .HasForeignKey(d => d.FirstNotifierId);

                entity.HasOne(d => d.FirstTransitPort)
                    .WithMany(p => p.TblBookingsFirstTransitPort)
                    .HasForeignKey(d => d.FirstTransitPortId);

                entity.HasOne(d => d.Fwagent)
                    .WithMany(p => p.TblBookingsFwagent)
                    .HasForeignKey(d => d.FwagentId);

                entity.HasOne(d => d.FwagentPerson)
                    .WithMany(p => p.TblBookingsFwagentPerson)
                    .HasForeignKey(d => d.FwagentPersonId);

                entity.HasOne(d => d.HouseConsolidationCode)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.HouseConsolidationCodeId);

                entity.HasOne(d => d.PortOfDischarge)
                    .WithMany(p => p.TblBookingsPortOfDischarge)
                    .HasForeignKey(d => d.PortOfDischargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PortOfLoad)
                    .WithMany(p => p.TblBookingsPortOfLoad)
                    .HasForeignKey(d => d.PortOfLoadId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.QuoteId);

                entity.HasOne(d => d.ResponsibleUser)
                    .WithMany(p => p.TblBookingsResponsibleUser)
                    .HasForeignKey(d => d.ResponsibleUserId);

                entity.HasOne(d => d.SecondNotifierContactPerson)
                    .WithMany(p => p.TblBookingsSecondNotifierContactPerson)
                    .HasForeignKey(d => d.SecondNotifierContactPersonId);

                entity.HasOne(d => d.SecondNotifier)
                    .WithMany(p => p.TblBookingsSecondNotifier)
                    .HasForeignKey(d => d.SecondNotifierId);

                entity.HasOne(d => d.SecondTransitPort)
                    .WithMany(p => p.TblBookingsSecondTransitPort)
                    .HasForeignKey(d => d.SecondTransitPortId);

                entity.HasOne(d => d.ShipperContactPerson)
                    .WithMany(p => p.TblBookingsShipperContactPerson)
                    .HasForeignKey(d => d.ShipperContactPersonId);

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.TblBookingsShipper)
                    .HasForeignKey(d => d.ShipperId);

                entity.HasOne(d => d.SupplierAgentContactPersons)
                    .WithMany(p => p.TblBookingsSupplierAgentContactPersons)
                    .HasForeignKey(d => d.SupplierAgentContactPersonsId);

                entity.HasOne(d => d.SupplierAgent)
                    .WithMany(p => p.TblBookingsSupplierAgent)
                    .HasForeignKey(d => d.SupplierAgentId)
                    .HasConstraintName("FK_tbl_Bookings_tbl_ServiceProviders_ServiceProviderID");

                entity.HasOne(d => d.TruckContractor)
                    .WithMany(p => p.TblBookingsTruckContractor)
                    .HasForeignKey(d => d.TruckContractorId);
            });

            modelBuilder.Entity<TblClientContactPersons>(entity =>
            {
                entity.HasKey(e => e.ClientContactPersonId)
                    .HasName("PK_tbl_ClientContactPersons_ClientContactPersonID");

                entity.ToTable("tbl_ClientContactPersons");

                entity.HasIndex(e => new { e.ClientId, e.NameEn })
                    .HasName("UC_tbl_ClientContactPersons_ClientID_NameEn")
                    .IsUnique();

                entity.Property(e => e.ClientContactPersonId).HasColumnName("ClientContactPersonID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactPersonTypeId).HasColumnName("ContactPersonTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DirectPhone).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblClientContactPersons)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ContactPersonType)
                    .WithMany(p => p.TblClientContactPersons)
                    .HasForeignKey(d => d.ContactPersonTypeId);
            });

            modelBuilder.Entity<TblClientRateAgreementContainers>(entity =>
            {
                entity.HasKey(e => e.ClientRateAgreementContainerId)
                    .HasName("PK_tbl_ClientRateAgreementContainers_ClientRateAgreementContainerID");

                entity.ToTable("tbl_ClientRateAgreementContainers");

                entity.HasIndex(e => new { e.ClientRateAgreementId, e.ContainerSizeId, e.ContainerTypeId })
                    .HasName("UC_tbl_ClientRateAgreementContainers_ClientRateAgreementID_ContainerSizeID_ContainerTypeID")
                    .IsUnique();

                entity.Property(e => e.ClientRateAgreementContainerId).HasColumnName("ClientRateAgreementContainerID");

                entity.Property(e => e.ClientRateAgreementId).HasColumnName("ClientRateAgreementID");

                entity.Property(e => e.ContainerSizeId).HasColumnName("ContainerSizeID");

                entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.HasOne(d => d.ClientRateAgreement)
                    .WithMany(p => p.TblClientRateAgreementContainers)
                    .HasForeignKey(d => d.ClientRateAgreementId);

                entity.HasOne(d => d.ContainerSize)
                    .WithMany(p => p.TblClientRateAgreementContainers)
                    .HasForeignKey(d => d.ContainerSizeId);

                entity.HasOne(d => d.ContainerType)
                    .WithMany(p => p.TblClientRateAgreementContainers)
                    .HasForeignKey(d => d.ContainerTypeId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblClientRateAgreementContainers)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblClientRateAgreements>(entity =>
            {
                entity.HasKey(e => e.ClientRateAgreementId)
                    .HasName("PK_tbl_ClientRateAgreements_ClientRateAgreementID");

                entity.ToTable("tbl_ClientRateAgreements");

                entity.HasIndex(e => e.ClientRanumber)
                    .HasName("UC_tbl_ClientRateAgreements_ClientRANumber")
                    .IsUnique();

                entity.HasIndex(e => new { e.ClientId, e.PortOfLoadId, e.PortOfDischargeId, e.CommodityId })
                    .HasName("UC_ltbl_ClientRateAgreements_ClientID_PortOfLoadID_PortOfDischargeID_CommodityID")
                    .IsUnique();

                entity.Property(e => e.ClientRateAgreementId).HasColumnName("ClientRateAgreementID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientRanumber)
                    .IsRequired()
                    .HasColumnName("ClientRANumber")
                    .HasMaxLength(100);

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PortOfDischargeId).HasColumnName("PortOfDischargeID");

                entity.Property(e => e.PortOfLoadId).HasColumnName("PortOfLoadID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblClientRateAgreements)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.TblClientRateAgreements)
                    .HasForeignKey(d => d.CommodityId);

                entity.HasOne(d => d.PortOfDischarge)
                    .WithMany(p => p.TblClientRateAgreementsPortOfDischarge)
                    .HasForeignKey(d => d.PortOfDischargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PortOfLoad)
                    .WithMany(p => p.TblClientRateAgreementsPortOfLoad)
                    .HasForeignKey(d => d.PortOfLoadId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblClientSalesTargets>(entity =>
            {
                entity.HasKey(e => e.ClientSalesTargetId)
                    .HasName("PK_tbl_ClientSalesTargets_ClientSalesTargetID");

                entity.ToTable("tbl_ClientSalesTargets");

                entity.HasIndex(e => new { e.ClientId, e.ServiceId, e.CommodityId, e.DestinationPortId })
                    .HasName("UC_tbl_ClientSalesTargets_ClientIDServiceIDCommodityIDDestinationPortID")
                    .IsUnique();

                entity.Property(e => e.ClientSalesTargetId).HasColumnName("ClientSalesTargetID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DestinationPortId).HasColumnName("DestinationPortID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SalesTargetStatusId)
                    .HasColumnName("SalesTargetStatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesTargetTypeId).HasColumnName("SalesTargetTypeID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblClientSalesTargets)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.TblClientSalesTargets)
                    .HasForeignKey(d => d.CommodityId);

                entity.HasOne(d => d.DestinationPort)
                    .WithMany(p => p.TblClientSalesTargets)
                    .HasForeignKey(d => d.DestinationPortId)
                    .HasConstraintName("FK_tbl_ClientSalesTargets_lkp_Ports_PortID");

                entity.HasOne(d => d.SalesTargetStatus)
                    .WithMany(p => p.TblClientSalesTargets)
                    .HasForeignKey(d => d.SalesTargetStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SalesTargetType)
                    .WithMany(p => p.TblClientSalesTargets)
                    .HasForeignKey(d => d.SalesTargetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblClientSalesTargets)
                    .HasForeignKey(d => d.ServiceId);
            });

            modelBuilder.Entity<TblClients>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PK_tbl_Clients_ClientID");

                entity.ToTable("tbl_Clients");

                entity.HasIndex(e => e.ClientNumber)
                    .HasName("UC_tbl_Clients_ClientNumber")
                    .IsUnique();

                entity.HasIndex(e => e.NameEn)
                    .HasName("UC_tbl_Clients_NameEn")
                    .IsUnique();

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasComment("رقم العميل");

                entity.Property(e => e.Address)
                    .HasColumnType("ntext")
                    .HasComment("العنوان");

                entity.Property(e => e.ClientStatusId).HasColumnName("ClientStatusID");

                entity.Property(e => e.CommercialRegistrationNumber)
                    .HasMaxLength(100)
                    .HasComment("رقم السجل التجارى");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CreditLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreditLimitCurrencyId).HasColumnName("CreditLimitCurrencyID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasComment("البريد الالكتروني");

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.GovernerateId).HasColumnName("GovernerateID");

                entity.Property(e => e.IsConsignee).HasComment("المرسل اليه");

                entity.Property(e => e.IsExport).HasComment("يصدر");

                entity.Property(e => e.IsImport).HasComment("يورد");

                entity.Property(e => e.IsNotifier).HasComment("المخطر");

                entity.Property(e => e.IsShipper).HasComment("ناقل");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MainContactPerson).HasMaxLength(200);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .HasComment("الهاتف المحمول");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.ParentClientId).HasColumnName("ParentClientID");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasComment("ملحوظات");

                entity.Property(e => e.SalesRegionId).HasColumnName("SalesRegionID");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(100)
                    .HasComment("رقم البطاقة الضريبية");

                entity.Property(e => e.Telephone1)
                    .HasMaxLength(100)
                    .HasComment("تلفيون 1");

                entity.Property(e => e.Telephone2)
                    .HasMaxLength(100)
                    .HasComment("تلفيون 2");

                entity.HasOne(d => d.ClientStatus)
                    .WithMany(p => p.TblClients)
                    .HasForeignKey(d => d.ClientStatusId);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblClients)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreditLimitCurrency)
                    .WithMany(p => p.TblClients)
                    .HasForeignKey(d => d.CreditLimitCurrencyId);

                entity.HasOne(d => d.Governerate)
                    .WithMany(p => p.TblClients)
                    .HasForeignKey(d => d.GovernerateId);

                entity.HasOne(d => d.SalesRegion)
                    .WithMany(p => p.TblClients)
                    .HasForeignKey(d => d.SalesRegionId);
            });

            modelBuilder.Entity<TblCmPatches>(entity =>
            {
                entity.HasKey(e => new { e.VersionNumber, e.PatchNumber })
                    .HasName("PK_tbl_cm_patches_VersionNumberPatchNumber");

                entity.ToTable("tbl_cm_patches");

                entity.Property(e => e.VersionNumber)
                    .HasMaxLength(15)
                    .HasComment("رقم الاصدار");

                entity.Property(e => e.PatchNumber)
                    .HasMaxLength(15)
                    .HasComment("رقم التحديث");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("تاريخ التنفيذ");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasComment("التعليقات");

                entity.Property(e => e.HasCodeChanges).HasComment("له تغيرات فى الكود");

                entity.Property(e => e.HasDbdata)
                    .HasColumnName("HasDBData")
                    .HasComment("له بيانات لقاعدة البيانات");

                entity.Property(e => e.HasDbstructure)
                    .HasColumnName("HasDBStructure")
                    .HasComment("له هيكل كامل لقاعدة البيانات");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasComment("تاريخ الارسال");
            });

            modelBuilder.Entity<TblCmVersions>(entity =>
            {
                entity.HasKey(e => e.VersionNumber);

                entity.ToTable("tbl_cm_versions");

                entity.Property(e => e.VersionNumber)
                    .HasMaxLength(15)
                    .HasComment("رقم الاصدار");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("تاريخ التنفيذ");

                entity.Property(e => e.BuildNumber)
                    .HasMaxLength(15)
                    .HasComment("رقم البناء");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasComment("التعليقات");

                entity.Property(e => e.CurrentVersion).HasComment("الاصدار الحالى");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NextVersionNumber)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.RevisionNumber).HasMaxLength(50);

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasComment("تاريخ الارسال");
            });

            modelBuilder.Entity<TblContractedLineCurrencies>(entity =>
            {
                entity.HasKey(e => e.ContractedLineCurrencyId)
                    .HasName("PK_tbl_ContractedLineCurrencies_ContractedLineCurrencyID");

                entity.ToTable("tbl_ContractedLineCurrencies");

                entity.HasIndex(e => new { e.CurrencyId, e.ContractedLineId })
                    .HasName("UC_tbl_ContractedLineCurrencies_CurrencyIDContractedLineID")
                    .IsUnique();

                entity.Property(e => e.ContractedLineCurrencyId).HasColumnName("ContractedLineCurrencyID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ContractedLineId).HasColumnName("ContractedLineID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TblContractedLineCurrencies)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.ContractedLine)
                    .WithMany(p => p.TblContractedLineCurrencies)
                    .HasForeignKey(d => d.ContractedLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblContractedLineCurrencies)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblContractedLines>(entity =>
            {
                entity.HasKey(e => e.ContractedLineId)
                    .HasName("PK_tbl_ContractedLines_ContractedLineID");

                entity.ToTable("tbl_ContractedLines");

                entity.Property(e => e.ContractedLineId).HasColumnName("ContractedLineID");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StateName).HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblContractedLines)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<TblCreditNoteInvoiceLinks>(entity =>
            {
                entity.HasKey(e => new { e.CreditNoteInvoiceId, e.InvoiceId })
                    .HasName("PK_tbl_CreditNoteInvoiceLinks_CreditNoteInvoiceIDInvoiceID");

                entity.ToTable("tbl_CreditNoteInvoiceLinks");

                entity.Property(e => e.CreditNoteInvoiceId).HasColumnName("CreditNoteInvoiceID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.CoveredAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.CreditNoteInvoice)
                    .WithMany(p => p.TblCreditNoteInvoiceLinksCreditNoteInvoice)
                    .HasForeignKey(d => d.CreditNoteInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TblCreditNoteInvoiceLinksInvoice)
                    .HasForeignKey(d => d.InvoiceId);
            });

            modelBuilder.Entity<TblDebitNoteDetails>(entity =>
            {
                entity.HasKey(e => e.DebitNoteDetailId)
                    .HasName("PK_tbl_DebitNoteDetails_DebitNoteDetailID");

                entity.ToTable("tbl_DebitNoteDetails");

                entity.Property(e => e.DebitNoteDetailId).HasColumnName("DebitNoteDetailID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DebitNoteId).HasColumnName("DebitNoteID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.DebitNote)
                    .WithMany(p => p.TblDebitNoteDetails)
                    .HasForeignKey(d => d.DebitNoteId);
            });

            modelBuilder.Entity<TblDebitNoteJournals>(entity =>
            {
                entity.HasKey(e => new { e.DebitNoteId, e.JournalId })
                    .HasName("PK_tbl_DebitNoteJournals_DebitNoteIDJournalID");

                entity.ToTable("tbl_DebitNoteJournals");

                entity.Property(e => e.DebitNoteId).HasColumnName("DebitNoteID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.DebitNote)
                    .WithMany(p => p.TblDebitNoteJournals)
                    .HasForeignKey(d => d.DebitNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblDebitNoteJournals)
                    .HasForeignKey(d => d.JournalId);
            });

            modelBuilder.Entity<TblDebitNotes>(entity =>
            {
                entity.HasKey(e => e.DebitNoteId)
                    .HasName("PK_tbl_DebitNotes_DebitNoteID");

                entity.ToTable("tbl_DebitNotes");

                entity.Property(e => e.DebitNoteId).HasColumnName("DebitNoteID");

                entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

                entity.Property(e => e.ContractedLineId).HasColumnName("ContractedLineID");

                entity.Property(e => e.ContractedLineName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DebitDate).HasColumnType("datetime");

                entity.Property(e => e.DebitNoteNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DebitTypeId).HasColumnName("DebitTypeID");

                entity.Property(e => e.Description1).HasColumnType("ntext");

                entity.Property(e => e.Description2).HasColumnType("ntext");

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.TreasuryId).HasColumnName("TreasuryID");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.TblDebitNotes)
                    .HasForeignKey(d => d.BankAccountId);

                entity.HasOne(d => d.ContractedLine)
                    .WithMany(p => p.TblDebitNotes)
                    .HasForeignKey(d => d.ContractedLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblDebitNotes)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DebitType)
                    .WithMany(p => p.TblDebitNotes)
                    .HasForeignKey(d => d.DebitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblDebitNotes)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Treasury)
                    .WithMany(p => p.TblDebitNotes)
                    .HasForeignKey(d => d.TreasuryId);
            });

            modelBuilder.Entity<TblEmployeeAttachments>(entity =>
            {
                entity.HasKey(e => e.EmployeeAttachemnetId)
                    .HasName("PK_tbl_EmployeeAttachments_EmployeeAttachemnetID");

                entity.ToTable("tbl_EmployeeAttachments");

                entity.Property(e => e.EmployeeAttachemnetId).HasColumnName("EmployeeAttachemnetID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FileName).HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TblEmployeeAttachments)
                    .HasForeignKey(d => d.EmployeeId);
            });

            modelBuilder.Entity<TblEmployeeTeachingSubjects>(entity =>
            {
                entity.HasKey(e => e.EmployeeTeachingSubjectId)
                    .HasName("PK_tbl_EmployeeTeachingSubjects_EmployeeTeachingSubjectID");

                entity.ToTable("tbl_EmployeeTeachingSubjects");

                entity.Property(e => e.EmployeeTeachingSubjectId).HasColumnName("EmployeeTeachingSubjectID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeJobId).HasColumnName("EmployeeJobID");

                entity.Property(e => e.HrstageId).HasColumnName("HRStageID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.TeachingSubjectId).HasColumnName("TeachingSubjectID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TblEmployeeTeachingSubjects)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.EmployeeJob)
                    .WithMany(p => p.TblEmployeeTeachingSubjects)
                    .HasForeignKey(d => d.EmployeeJobId);

                entity.HasOne(d => d.Hrstage)
                    .WithMany(p => p.TblEmployeeTeachingSubjects)
                    .HasForeignKey(d => d.HrstageId);

                entity.HasOne(d => d.TeachingSubject)
                    .WithMany(p => p.TblEmployeeTeachingSubjects)
                    .HasForeignKey(d => d.TeachingSubjectId);
            });

            modelBuilder.Entity<TblEmployeeVacations>(entity =>
            {
                entity.HasKey(e => e.EmployeeVacationId)
                    .HasName("PK_tbl_EmployeeVacations_EmployeeVacationID");

                entity.ToTable("tbl_EmployeeVacations");

                entity.Property(e => e.EmployeeVacationId).HasColumnName("EmployeeVacationID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.VacationDateFrom).HasColumnType("datetime");

                entity.Property(e => e.VacationDateTo).HasColumnType("datetime");

                entity.Property(e => e.VacationStatusId).HasColumnName("VacationStatusID");

                entity.Property(e => e.VacationTypeId).HasColumnName("VacationTypeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TblEmployeeVacations)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.VacationStatus)
                    .WithMany(p => p.TblEmployeeVacations)
                    .HasForeignKey(d => d.VacationStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VacationType)
                    .WithMany(p => p.TblEmployeeVacations)
                    .HasForeignKey(d => d.VacationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblEmployees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_tbl_Employees_EmployeeID");

                entity.ToTable("tbl_Employees");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_tbl_Employees_Code")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.AdditionalCourses).HasColumnType("ntext");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirthQualification).HasColumnType("datetime");

                entity.Property(e => e.DateOfEducationalQualification).HasColumnType("datetime");

                entity.Property(e => e.DateOfIcdl)
                    .HasColumnName("DateOfICDL")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DirectManagerEmployeeId).HasColumnName("DirectManagerEmployeeID");

                entity.Property(e => e.EducationalQualification).HasMaxLength(100);

                entity.Property(e => e.EmployeeJobId).HasColumnName("EmployeeJobID");

                entity.Property(e => e.EmploymentTypeId).HasColumnName("EmploymentTypeID");

                entity.Property(e => e.GenderTypeId).HasColumnName("GenderTypeID");

                entity.Property(e => e.GovernerateId).HasColumnName("GovernerateID");

                entity.Property(e => e.HasIcdl).HasColumnName("HasICDL");

                entity.Property(e => e.HealthInsuranceValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.InsuranceNumber).HasMaxLength(100);

                entity.Property(e => e.InsuranceValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationOfBirth).HasMaxLength(100);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MilitaryStatusId).HasColumnName("MilitaryStatusID");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.MotherName).HasMaxLength(100);

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NameFr).HasMaxLength(200);

                entity.Property(e => e.NationalIdnumber)
                    .HasColumnName("NationalIDNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalRegister).HasMaxLength(100);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.PersonalEmail).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhotoFileName).HasColumnType("ntext");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.PrivateNotes).HasColumnType("ntext");

                entity.Property(e => e.Qualification).HasMaxLength(250);

                entity.Property(e => e.QualificationsRemarks).HasColumnType("ntext");

                entity.Property(e => e.RecruitmentDate).HasColumnType("datetime");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ResignationDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryDueToRaiseValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SalaryTaxValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SalaryValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SchoolEmail).HasMaxLength(100);

                entity.Property(e => e.WorkJoinDate).HasColumnType("datetime");

                entity.Property(e => e.YearsOfFieldExperienceWhenJoined).HasColumnType("numeric(18, 1)");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.AreaId);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.DepartmentId);

                entity.HasOne(d => d.DirectManagerEmployee)
                    .WithMany(p => p.InverseDirectManagerEmployee)
                    .HasForeignKey(d => d.DirectManagerEmployeeId);

                entity.HasOne(d => d.EmployeeJob)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.EmployeeJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.EmploymentType)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.EmploymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.GenderType)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.GenderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Governerate)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.GovernerateId);

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.MaritalStatusId);

                entity.HasOne(d => d.MilitaryStatus)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.MilitaryStatusId);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.NationalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.ReligionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblExpenses>(entity =>
            {
                entity.HasKey(e => e.ExpenseId)
                    .HasName("PK_tbl_Expenses_ExpenseID");

                entity.ToTable("tbl_Expenses");

                entity.HasIndex(e => new { e.AcademicYearId, e.GradeId, e.ExpenseTypeId, e.PaymentPortionTypeId })
                    .HasName("UC_tbl_Expenses_AcademicYearIDGradeIDPaymentPortionTypeIDExpenseTypeID")
                    .IsUnique();

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PaymentPortionTypeId).HasColumnName("PaymentPortionTypeID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.TblExpenses)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ExpenseType)
                    .WithMany(p => p.TblExpenses)
                    .HasForeignKey(d => d.ExpenseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.TblExpenses)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PaymentPortionType)
                    .WithMany(p => p.TblExpenses)
                    .HasForeignKey(d => d.PaymentPortionTypeId);
            });

            modelBuilder.Entity<TblGlobalSettings>(entity =>
            {
                entity.HasKey(e => e.GlobalSettingsId)
                    .HasName("PK_tbl_GlobalSettings_GlobalSettingID");

                entity.ToTable("tbl_GlobalSettings");

                entity.Property(e => e.GlobalSettingsId)
                    .HasColumnName("GlobalSettingsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(400)
                    .HasComment("العنوان");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CustomerNameAr)
                    .HasMaxLength(35)
                    .HasComment("اسم العميل بالعربية");

                entity.Property(e => e.CustomerNameEn)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasComment("اسم العميل بالانجليزية");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .HasComment("الفاكس");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(9)
                    .HasComment("رقم ضريبى");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(100)
                    .HasComment("التليفون");
            });

            modelBuilder.Entity<TblInvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.InvoiceDetailId)
                    .HasName("PK_tbl_InvoiceDetails_InvoiceDetailID");

                entity.ToTable("tbl_InvoiceDetails");

                entity.HasIndex(e => new { e.InvoiceId, e.ServiceId })
                    .HasName("UC_tbl_InvoiceDetails_InvoiceIDServiceID")
                    .IsUnique();

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetailID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ItemValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TblInvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblInvoiceDetails)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblInvoiceJournals>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceId, e.JournalId })
                    .HasName("PK_tbl_InvoiceJournals_InvoiceIDJournalID");

                entity.ToTable("tbl_InvoiceJournals");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TblInvoiceJournals)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblInvoiceJournals)
                    .HasForeignKey(d => d.JournalId);
            });

            modelBuilder.Entity<TblInvoicePaymentDetails>(entity =>
            {
                entity.HasKey(e => e.InvoicePaymentDetailId)
                    .HasName("PK_tbl_InvoicePaymentDetails_InvoicePaymentDetailID");

                entity.ToTable("tbl_InvoicePaymentDetails");

                entity.Property(e => e.InvoicePaymentDetailId).HasColumnName("InvoicePaymentDetailID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.InvoicePaymentId).HasColumnName("InvoicePaymentID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TblInvoicePaymentDetails)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblInvoicePaymentDetails)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.InvoicePayment)
                    .WithMany(p => p.TblInvoicePaymentDetails)
                    .HasForeignKey(d => d.InvoicePaymentId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblInvoicePaymentDetails)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<TblInvoicePaymentJournals>(entity =>
            {
                entity.HasKey(e => new { e.InvoicePaymentId, e.JournalId })
                    .HasName("PK_tbl_InvoicePaymentJournals_InvoicePaymentIDJournalID");

                entity.ToTable("tbl_InvoicePaymentJournals");

                entity.Property(e => e.InvoicePaymentId).HasColumnName("InvoicePaymentID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.InvoicePayment)
                    .WithMany(p => p.TblInvoicePaymentJournals)
                    .HasForeignKey(d => d.InvoicePaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblInvoicePaymentJournals)
                    .HasForeignKey(d => d.JournalId);
            });

            modelBuilder.Entity<TblInvoicePaymentLinks>(entity =>
            {
                entity.HasKey(e => new { e.InvoicePaymentId, e.InvoiceId })
                    .HasName("PK_tbl_InvoicePaymentLinks_InvoicePaymentIDInvoiceID");

                entity.ToTable("tbl_InvoicePaymentLinks");

                entity.Property(e => e.InvoicePaymentId).HasColumnName("InvoicePaymentID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PaidValue).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TblInvoicePaymentLinks)
                    .HasForeignKey(d => d.InvoiceId);

                entity.HasOne(d => d.InvoicePayment)
                    .WithMany(p => p.TblInvoicePaymentLinks)
                    .HasForeignKey(d => d.InvoicePaymentId);
            });

            modelBuilder.Entity<TblInvoicePayments>(entity =>
            {
                entity.HasKey(e => e.InvoicePaymentId)
                    .HasName("PK_tbl_InvoicePayments_InvoicePaymentID");

                entity.ToTable("tbl_InvoicePayments");

                entity.Property(e => e.InvoicePaymentId).HasColumnName("InvoicePaymentID");

                entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

                entity.Property(e => e.BankFees).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankFrom).HasMaxLength(100);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChargedReason).HasColumnType("ntext");

                entity.Property(e => e.CollectDate).HasColumnType("datetime");

                entity.Property(e => e.CollectExchangeRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DepositOrcheckOrtransferDate)
                    .HasColumnName("DepositORCheckORTransferDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositOrcheckOrtransferNumber)
                    .HasColumnName("DepositORCheckORTransferNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.ExchangeRateToLocalCurrency)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.InvoicePaymentMethodId).HasColumnName("InvoicePaymentMethodID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ToAccountName).HasMaxLength(300);

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TreasuryId).HasColumnName("TreasuryID");

                entity.Property(e => e.WithholdingTaxId).HasColumnName("WithholdingTaxID");

                entity.Property(e => e.WithholdingTaxValue).HasColumnType("numeric(18, 3)");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.TblInvoicePayments)
                    .HasForeignKey(d => d.BankAccountId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblInvoicePayments)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblInvoicePayments)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.InvoicePaymentMethod)
                    .WithMany(p => p.TblInvoicePayments)
                    .HasForeignKey(d => d.InvoicePaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Treasury)
                    .WithMany(p => p.TblInvoicePayments)
                    .HasForeignKey(d => d.TreasuryId);

                entity.HasOne(d => d.WithholdingTax)
                    .WithMany(p => p.TblInvoicePayments)
                    .HasForeignKey(d => d.WithholdingTaxId);
            });

            modelBuilder.Entity<TblInvoices>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK_tbl_Invoices_InvoiceID");

                entity.ToTable("tbl_Invoices");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.AccountingReviewDate).HasColumnType("datetime");

                entity.Property(e => e.AccountingReviewerUserId).HasColumnName("AccountingReviewerUserID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DoLog).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceHeaderName).HasMaxLength(255);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(30);

                entity.Property(e => e.InvoiceToId).HasColumnName("InvoiceToID");

                entity.Property(e => e.InvoiceTypeId).HasColumnName("InvoiceTypeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PaymentDetails).HasColumnType("ntext");

                entity.Property(e => e.PaymentTerms).HasColumnType("ntext");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.TaxPercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalValue).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.AccountingReviewerUser)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.AccountingReviewerUserId);

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Invoices_tbl_Users_CurrencyID");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.FinancialYearId);

                entity.HasOne(d => d.InvoiceTo)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.InvoiceToId);

                entity.HasOne(d => d.InvoiceType)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.InvoiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblMembers>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK_tbl_Members_MemberID");

                entity.ToTable("tbl_Members");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.AccessId)
                    .HasColumnName("AccessID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemberAccountId).HasColumnName("MemberAccountID");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.HasOne(d => d.MemberAccount)
                    .WithMany(p => p.TblMembers)
                    .HasForeignKey(d => d.MemberAccountId);
            });

            modelBuilder.Entity<TblMembersPayments>(entity =>
            {
                entity.HasKey(e => e.MembersPaymentId)
                    .HasName("PK_tbl_MembersPayments_MembersPaymentID");

                entity.ToTable("tbl_MembersPayments");

                entity.Property(e => e.MembersPaymentId).HasColumnName("MembersPaymentID");

                entity.Property(e => e.AccessId)
                    .HasColumnName("AccessID")
                    .HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.InvoicePaymentId).HasColumnName("InvoicePaymentID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.RecievedDate).HasColumnType("datetime");

                entity.Property(e => e.RecievedUserId).HasColumnName("RecievedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.HasOne(d => d.InvoicePayment)
                    .WithMany(p => p.TblMembersPayments)
                    .HasForeignKey(d => d.InvoicePaymentId);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TblMembersPayments)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblPricingListPrices>(entity =>
            {
                entity.HasKey(e => e.PricingListPriceId)
                    .HasName("PK_tbl_PricingListPrices_PricingListPriceID")
                    .IsClustered(false);

                entity.ToTable("tbl_PricingListPrices");

                entity.Property(e => e.PricingListPriceId).HasColumnName("PricingListPriceID");

                entity.Property(e => e.CostCurrencyId).HasColumnName("CostCurrencyID");

                entity.Property(e => e.CostPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.FrequencyOfService).HasColumnType("ntext");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PricingListId).HasColumnName("PricingListID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SellPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");

                entity.Property(e => e.TransitTime).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransitTypeId).HasColumnName("TransitTypeID");

                entity.Property(e => e.VaildFrom).HasColumnType("datetime");

                entity.Property(e => e.VaildTo).HasColumnType("datetime");

                entity.HasOne(d => d.CostCurrency)
                    .WithMany(p => p.TblPricingListPricesCostCurrency)
                    .HasForeignKey(d => d.CostCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblPricingListPricesCurrency)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PricingList)
                    .WithMany(p => p.TblPricingListPrices)
                    .HasForeignKey(d => d.PricingListId);

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.TblPricingListPrices)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TransitType)
                    .WithMany(p => p.TblPricingListPrices)
                    .HasForeignKey(d => d.TransitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblPricingListTransitPorts>(entity =>
            {
                entity.HasKey(e => e.PricingListTransitPortId)
                    .HasName("PK_tbl_PricingListTransitPorts_PricingListTransitPortID");

                entity.ToTable("tbl_PricingListTransitPorts");

                entity.Property(e => e.PricingListTransitPortId)
                    .HasColumnName("PricingListTransitPortID")
                    .HasComment("رقم قائمة اسعار ميناء الترانزيت  ");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PricingListPriceId).HasColumnName("PricingListPriceID");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasComment("الملاحظات");

                entity.Property(e => e.TransitPeriodInHours)
                    .HasColumnType("numeric(18, 1)")
                    .HasComment("ساعات الترانزيت");

                entity.Property(e => e.TransitPortId)
                    .HasColumnName("TransitPortID")
                    .HasComment("رقم ميناء الترانزيت");

                entity.HasOne(d => d.PricingListPrice)
                    .WithMany(p => p.TblPricingListTransitPorts)
                    .HasForeignKey(d => d.PricingListPriceId);

                entity.HasOne(d => d.TransitPort)
                    .WithMany(p => p.TblPricingListTransitPorts)
                    .HasForeignKey(d => d.TransitPortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PricingListTransitPorts_lkp_Ports_PortID");
            });

            modelBuilder.Entity<TblPricingLists>(entity =>
            {
                entity.HasKey(e => e.PricingListId)
                    .HasName("PK_tbl_PricingLists_PricingListID");

                entity.ToTable("tbl_PricingLists");

                entity.HasIndex(e => new { e.PortOfLoadId, e.DestinationPortId, e.TransportTypeId, e.ContainerSizeId, e.ContainerTypeId })
                    .HasName("US_tbl_PricingLists_PortOfLoadID_DestinationPortID_TransportTypeID_ContainerSizeID_ContainerTypeID")
                    .IsUnique();

                entity.Property(e => e.PricingListId)
                    .HasColumnName("PricingListID")
                    .HasComment("رقم قائمة الاسعار");

                entity.Property(e => e.ContainerSizeId).HasColumnName("ContainerSizeID");

                entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DestinationPortId)
                    .HasColumnName("DestinationPortID")
                    .HasComment("رقم ميناء الوصول");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PortOfLoadId).HasColumnName("PortOfLoadID");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasComment("ملحظات");

                entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");

                entity.HasOne(d => d.ContainerSize)
                    .WithMany(p => p.TblPricingLists)
                    .HasForeignKey(d => d.ContainerSizeId);

                entity.HasOne(d => d.ContainerType)
                    .WithMany(p => p.TblPricingLists)
                    .HasForeignKey(d => d.ContainerTypeId);

                entity.HasOne(d => d.DestinationPort)
                    .WithMany(p => p.TblPricingListsDestinationPort)
                    .HasForeignKey(d => d.DestinationPortId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PortOfLoad)
                    .WithMany(p => p.TblPricingListsPortOfLoad)
                    .HasForeignKey(d => d.PortOfLoadId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TransportType)
                    .WithMany(p => p.TblPricingLists)
                    .HasForeignKey(d => d.TransportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblQuoteDetails>(entity =>
            {
                entity.HasKey(e => e.QuoteDetailId)
                    .HasName("PK_tbl_QuoteDetails_QuoteDetailID");

                entity.ToTable("tbl_QuoteDetails");

                entity.Property(e => e.QuoteDetailId).HasColumnName("QuoteDetailID");

                entity.Property(e => e.CargoCategoryId).HasColumnName("CargoCategoryID");

                entity.Property(e => e.ContainerCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContainerNumber).HasMaxLength(15);

                entity.Property(e => e.ContainerSizeId).HasColumnName("ContainerSizeID");

                entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.HscodeId).HasColumnName("HSCodeID");

                entity.Property(e => e.ImoclassId).HasColumnName("IMOClassID");

                entity.Property(e => e.IsImo).HasColumnName("IsIMO");

                entity.Property(e => e.IsOog).HasColumnName("IsOOG");

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarksAndNumbers).HasColumnType("ntext");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NetWeight).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.PackageTypeId).HasColumnName("PackageTypeID");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.RatePerKilo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RatePerKiloCurrencyId).HasColumnName("RatePerKiloCurrencyID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SealNumber).HasMaxLength(50);

                entity.Property(e => e.Temperature).HasMaxLength(50);

                entity.Property(e => e.Volume).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.VolumeUnitId).HasColumnName("VolumeUnitID");

                entity.Property(e => e.Weight).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.WeightUnitId).HasColumnName("WeightUnitID");

                entity.HasOne(d => d.CargoCategory)
                    .WithMany(p => p.TblQuoteDetails)
                    .HasForeignKey(d => d.CargoCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ContainerSize)
                    .WithMany(p => p.TblQuoteDetails)
                    .HasForeignKey(d => d.ContainerSizeId);

                entity.HasOne(d => d.ContainerType)
                    .WithMany(p => p.TblQuoteDetails)
                    .HasForeignKey(d => d.ContainerTypeId);

                entity.HasOne(d => d.Hscode)
                    .WithMany(p => p.TblQuoteDetails)
                    .HasForeignKey(d => d.HscodeId);

                entity.HasOne(d => d.Imoclass)
                    .WithMany(p => p.TblQuoteDetails)
                    .HasForeignKey(d => d.ImoclassId);

                entity.HasOne(d => d.PackageType)
                    .WithMany(p => p.TblQuoteDetails)
                    .HasForeignKey(d => d.PackageTypeId);

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.TblQuoteDetails)
                    .HasForeignKey(d => d.QuoteId);

                entity.HasOne(d => d.RatePerKiloCurrency)
                    .WithMany(p => p.TblQuoteDetails)
                    .HasForeignKey(d => d.RatePerKiloCurrencyId);

                entity.HasOne(d => d.VolumeUnit)
                    .WithMany(p => p.TblQuoteDetailsVolumeUnit)
                    .HasForeignKey(d => d.VolumeUnitId);

                entity.HasOne(d => d.WeightUnit)
                    .WithMany(p => p.TblQuoteDetailsWeightUnit)
                    .HasForeignKey(d => d.WeightUnitId);
            });

            modelBuilder.Entity<TblQuoteServices>(entity =>
            {
                entity.HasKey(e => e.QuoteServiceId)
                    .HasName("PK_tbl_QuoteServices_QuoteServiceID");

                entity.ToTable("tbl_QuoteServices");

                entity.HasIndex(e => new { e.QuoteId, e.ServiceId })
                    .HasName("UC_tbl_QuoteServices_QuoteIDServiceID")
                    .IsUnique();

                entity.Property(e => e.QuoteServiceId).HasColumnName("QuoteServiceID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.SellPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblQuoteServices)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.TblQuoteServices)
                    .HasForeignKey(d => d.QuoteId);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblQuoteServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.TblQuoteServices)
                    .HasForeignKey(d => d.ServiceProviderId);
            });

            modelBuilder.Entity<TblQuotes>(entity =>
            {
                entity.HasKey(e => e.QuoteId)
                    .HasName("PK_tbl_Quotes_QuoteID");

                entity.ToTable("tbl_Quotes");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.BookingStatusId).HasColumnName("BookingStatusID");

                entity.Property(e => e.BookingTypeId).HasColumnName("BookingTypeID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ConsigneeFax).HasMaxLength(100);

                entity.Property(e => e.ConsigneeTelephone).HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DeliveryTermId).HasColumnName("DeliveryTermID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Edd)
                    .HasColumnName("EDD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinalDestinationPortId).HasColumnName("FinalDestinationPortID");

                entity.Property(e => e.FirstTransitPortId).HasColumnName("FirstTransitPortID");

                entity.Property(e => e.HasTelexRelease).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFdpsameAsPod).HasColumnName("IsFDPSameAsPOD");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PortOfDischargeId).HasColumnName("PortOfDischargeID");

                entity.Property(e => e.PortOfLoadId).HasColumnName("PortOfLoadID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SalesUserId).HasColumnName("SalesUserID");

                entity.Property(e => e.SecondTransitPortId).HasColumnName("SecondTransitPortID");

                entity.Property(e => e.SupplierAgentId).HasColumnName("SupplierAgentID");

                entity.HasOne(d => d.BookingStatus)
                    .WithMany(p => p.TblQuotes)
                    .HasForeignKey(d => d.BookingStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BookingType)
                    .WithMany(p => p.TblQuotes)
                    .HasForeignKey(d => d.BookingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblQuotes)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblQuotes)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FinalDestinationPort)
                    .WithMany(p => p.TblQuotesFinalDestinationPort)
                    .HasForeignKey(d => d.FinalDestinationPortId);

                entity.HasOne(d => d.FirstTransitPort)
                    .WithMany(p => p.TblQuotesFirstTransitPort)
                    .HasForeignKey(d => d.FirstTransitPortId);

                entity.HasOne(d => d.PortOfDischarge)
                    .WithMany(p => p.TblQuotesPortOfDischarge)
                    .HasForeignKey(d => d.PortOfDischargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PortOfLoad)
                    .WithMany(p => p.TblQuotesPortOfLoad)
                    .HasForeignKey(d => d.PortOfLoadId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SalesUser)
                    .WithMany(p => p.TblQuotes)
                    .HasForeignKey(d => d.SalesUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SecondTransitPort)
                    .WithMany(p => p.TblQuotesSecondTransitPort)
                    .HasForeignKey(d => d.SecondTransitPortId);

                entity.HasOne(d => d.SupplierAgent)
                    .WithMany(p => p.TblQuotes)
                    .HasForeignKey(d => d.SupplierAgentId)
                    .HasConstraintName("FK_tbl_acc_SupplierInvoices_tbl_ServiceProviders_SupplierAgentID");
            });

            modelBuilder.Entity<TblReportSettings>(entity =>
            {
                entity.HasKey(e => e.ReportSettingId)
                    .HasName("PK_tbl_ReportSettings_ReportSettingID");

                entity.ToTable("tbl_ReportSettings");

                entity.Property(e => e.ReportSettingId)
                    .HasColumnName("ReportSettingID")
                    .HasComment("رقم اعدادات التقرير")
                    .ValueGeneratedNever();

                entity.Property(e => e.Body1)
                    .HasMaxLength(100)
                    .HasComment("جسم التقرير 1");

                entity.Property(e => e.Body2)
                    .HasMaxLength(100)
                    .HasComment("جسم التقرير 2");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Footer1)
                    .HasMaxLength(100)
                    .HasComment("تذييل الصفحة 1 بالانجليزية");

                entity.Property(e => e.Footer1Ar)
                    .HasMaxLength(100)
                    .HasComment("تذييل الصفحة 1 بالعربية");

                entity.Property(e => e.Footer2)
                    .HasMaxLength(100)
                    .HasComment("تذييل الصفحة 2 بالانجليزية");

                entity.Property(e => e.Footer2Ar)
                    .HasMaxLength(100)
                    .HasComment("تزييل الصفحة 2 بالعربية");

                entity.Property(e => e.Header1)
                    .HasMaxLength(100)
                    .HasComment("رأس الصفحة 1 بالانجليزية");

                entity.Property(e => e.Header1Ar)
                    .HasMaxLength(100)
                    .HasComment("رأس الصفحة 1 بالعربية");

                entity.Property(e => e.Header2)
                    .HasMaxLength(100)
                    .HasComment("رأس الصفحة 2 بالانجليزية");

                entity.Property(e => e.Header2Ar)
                    .HasMaxLength(100)
                    .HasComment("رأس الصفحة 2 بالعربية");

                entity.Property(e => e.Header3)
                    .HasMaxLength(100)
                    .HasComment("رأس الصفحة 3 بالانجليزية");

                entity.Property(e => e.Header3Ar)
                    .HasMaxLength(100)
                    .HasComment("رأس الصفحة 3 بالعربية");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogoPath)
                    .HasColumnType("ntext")
                    .HasComment("مسار صورة رمز الشركة");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<TblRoleComponents>(entity =>
            {
                entity.HasKey(e => e.RoleComponentsId)
                    .HasName("PK_RoleComponents_RoleComponentsID");

                entity.ToTable("tbl_RoleComponents");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("idx_tbl_RoleComponents_CreatorUserID");

                entity.HasIndex(e => e.ModifiedUserId)
                    .HasName("idx_tbl_RoleComponents_ModifiedUserID");

                entity.Property(e => e.RoleComponentsId)
                    .HasColumnName("RoleComponentsID")
                    .HasComment("رقم الدور و القائمة الفرعية");

                entity.Property(e => e.ComponentId)
                    .HasColumnName("ComponentID")
                    .HasComment("رقم القائمة الفرعية");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasComment("رقم التصريح");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("رقم الدور");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.TblRoleComponents)
                    .HasForeignKey(d => d.ComponentId);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.TblRoleComponents)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblRoleComponents)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblRoleModules>(entity =>
            {
                entity.HasKey(e => e.RoleModuleId)
                    .HasName("PK_RoleModules_RoleModuleID");

                entity.ToTable("tbl_RoleModules");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("idx_tbl_RoleModules_CreatorUserID");

                entity.HasIndex(e => e.ModifiedUserId)
                    .HasName("idx_tbl_RoleModules_ModifiedUserID");

                entity.Property(e => e.RoleModuleId)
                    .HasColumnName("RoleModuleID")
                    .HasComment("رقم الادوارو الوحدات");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasComment("رقم الوحدة");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasComment("رقم التصريح");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("رقم الدور");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.TblRoleModules)
                    .HasForeignKey(d => d.ModuleId);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.TblRoleModules)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblRoleModules)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblRoleServices>(entity =>
            {
                entity.HasKey(e => e.RoleServiceId)
                    .HasName("PK_RoleServices_RoleServiceID");

                entity.ToTable("tbl_RoleServices");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("idx_tbl_RoleServices_CreatorUserID");

                entity.HasIndex(e => e.ModifiedUserId)
                    .HasName("idx_tbl_RoleServices_ModifiedUserID");

                entity.Property(e => e.RoleServiceId)
                    .HasColumnName("RoleServiceID")
                    .HasComment("رقم الادوار و الخدمات");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasComment("رقم التصريح");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("رقم الدور");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("ServiceID")
                    .HasComment("رقم الخدمة");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.TblRoleServices)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblRoleServices)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblRoleServices)
                    .HasForeignKey(d => d.ServiceId);
            });

            modelBuilder.Entity<TblRoleSystems>(entity =>
            {
                entity.HasKey(e => e.RoleSystemId)
                    .HasName("PK_RoleSystems_RoleSystemID");

                entity.ToTable("tbl_RoleSystems");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("idx_tbl_RoleSystems_CreatorUserID");

                entity.HasIndex(e => e.ModifiedUserId)
                    .HasName("idx_tbl_RoleSystems_ModifiedUserID");

                entity.Property(e => e.RoleSystemId)
                    .HasColumnName("RoleSystemID")
                    .HasComment("رقم الادوار و الانظمة");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasComment("رقم التصريح");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("رقم الدور");

                entity.Property(e => e.SystemId)
                    .HasColumnName("SystemID")
                    .HasComment("رقم النظام");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.TblRoleSystems)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblRoleSystems)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.System)
                    .WithMany(p => p.TblRoleSystems)
                    .HasForeignKey(d => d.SystemId);
            });

            modelBuilder.Entity<TblRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_tbl_Roles_RoleID");

                entity.ToTable("tbl_Roles");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("idx_tbl_Roles_CreatorUserID");

                entity.HasIndex(e => e.ModifiedUserId)
                    .HasName("idx_tbl_Roles_ModifiedUserID");

                entity.HasIndex(e => e.Name)
                    .HasName("UC_tbl_Roles_Name")
                    .IsUnique();

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("رقم الدور");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم الدور");
            });

            modelBuilder.Entity<TblRptDatasourceFields>(entity =>
            {
                entity.HasKey(e => e.DatasourceFieldId)
                    .HasName("PK_tbl_rpt_DatasourceFields_DatasourceFieldID");

                entity.ToTable("tbl_rpt_DatasourceFields");

                entity.Property(e => e.DatasourceFieldId)
                    .HasColumnName("DatasourceFieldID")
                    .HasComment("رقم مجال مصدر البيانات")
                    .ValueGeneratedNever();

                entity.Property(e => e.BackgroundColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('White')")
                    .HasComment("لون الخلفية");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع البيان");

                entity.Property(e => e.DatasourceId)
                    .HasColumnName("DatasourceID")
                    .HasComment("رقم مصدر البيانات");

                entity.Property(e => e.FontColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Black')")
                    .HasComment("لون الخط");

                entity.Property(e => e.FontSize)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((12))")
                    .HasComment("حجم الخط");

                entity.Property(e => e.FontStyleIsBold)
                    .IsRequired()
                    .HasDefaultValueSql("('False')")
                    .HasComment("نمط خط غامق");

                entity.Property(e => e.FontStyleIsItalic)
                    .IsRequired()
                    .HasDefaultValueSql("('False')")
                    .HasComment("نمط خط مائل");

                entity.Property(e => e.GroupingFuntion)
                    .HasMaxLength(80)
                    .HasComment("نظام التجميع");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم مجال مصدر البيانات");

                entity.Property(e => e.ResourceKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("مفتاح الموارد");

                entity.Property(e => e.Sequence).HasComment("الترتيب");

                entity.Property(e => e.Width)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((20))")
                    .HasComment("العرض");

                entity.HasOne(d => d.Datasource)
                    .WithMany(p => p.TblRptDatasourceFields)
                    .HasForeignKey(d => d.DatasourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_rpt_DatasourceField_tbl_rpt_Datasources_DatasourceID");
            });

            modelBuilder.Entity<TblRptDatasourceTypes>(entity =>
            {
                entity.HasKey(e => e.DatasourceTypeId)
                    .HasName("PK_tbl_rpt_DatasourceTypes_DatasourceTypeID");

                entity.ToTable("tbl_rpt_DatasourceTypes");

                entity.Property(e => e.DatasourceTypeId)
                    .HasColumnName("DatasourceTypeID")
                    .HasComment("رقم نوع مصدر البيانات")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم نوع مصدر البيانات");
            });

            modelBuilder.Entity<TblRptDatasources>(entity =>
            {
                entity.HasKey(e => e.DatasourceId)
                    .HasName("PK_tbl_rpt_Datasources_DatasourceID");

                entity.ToTable("tbl_rpt_Datasources");

                entity.Property(e => e.DatasourceId)
                    .HasColumnName("DatasourceID")
                    .HasComment("رقم مصدر البيانات")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataSourceTypeId)
                    .HasColumnName("DataSourceTypeID")
                    .HasComment("رقم نوع مصدر البيانات");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم الظاهر لمصدر البيانات");

                entity.Property(e => e.GroupBy)
                    .HasMaxLength(250)
                    .HasComment("التجميع");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم مصدر البيانات");

                entity.Property(e => e.ResourceKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("مفتاح الموارد");

                entity.Property(e => e.RowHeight)
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("ارتفاع السطر");

                entity.HasOne(d => d.DataSourceType)
                    .WithMany(p => p.TblRptDatasources)
                    .HasForeignKey(d => d.DataSourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_DataSources_tbl_rpt_DatasourceTypes_DatasourceTypeID");
            });

            modelBuilder.Entity<TblRptLocalization>(entity =>
            {
                entity.HasKey(e => new { e.ResourceKey, e.LanguageId });

                entity.ToTable("tbl_rpt_Localization");

                entity.Property(e => e.ResourceKey)
                    .HasMaxLength(50)
                    .HasComment("مفتاح الموارد");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasComment("رقم اللغة");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnName("CreatorUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("ModifiedUserID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .HasComment("القيمة");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TblRptLocalization)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblRptReportDataSources>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.DataSourceId })
                    .HasName("PK_tbl_rpt_ReportDataSources_ReportIDDataSourceID");

                entity.ToTable("tbl_rpt_ReportDataSources");

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasComment("رقم التقرير");

                entity.Property(e => e.DataSourceId)
                    .HasColumnName("DataSourceID")
                    .HasComment("رقم مصدر البيانات");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SequenceOrder).HasComment("الترتيب");

                entity.HasOne(d => d.DataSource)
                    .WithMany(p => p.TblRptReportDataSources)
                    .HasForeignKey(d => d.DataSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_rpt_ReportDataSources_tbl_rpt_Datasources_DatasourceID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.TblRptReportDataSources)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_rpt_ReportDataSource_tbl_rpt_Reports_ReportID");
            });

            modelBuilder.Entity<TblRptReports>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_tbl_rpt_Reports_ReportID");

                entity.ToTable("tbl_rpt_Reports");

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasComment("رقم التقرير")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم التقرير");

                entity.Property(e => e.PageHeight).HasComment("ارتفاع الصفحة");

                entity.Property(e => e.Pagewidth).HasComment("عرض الصفحة");

                entity.Property(e => e.ResourceKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مفتاح الموارد");
            });

            modelBuilder.Entity<TblRptSpparameters>(entity =>
            {
                entity.HasKey(e => e.SpparameterId)
                    .HasName("PK_tbl_rpt_SPParameters_SPParameterID");

                entity.ToTable("tbl_rpt_SPParameters");

                entity.Property(e => e.SpparameterId)
                    .HasColumnName("SPParameterID")
                    .HasComment("رقم مدخل مصادر البيانات")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("نوع القيمة");

                entity.Property(e => e.DatasourceId)
                    .HasColumnName("DatasourceID")
                    .HasComment("رقم مصدر البيانات");

                entity.Property(e => e.IsMandatory).HasComment("مدخل إلزامى");

                entity.Property(e => e.IsMultipleSelection).HasComment("مدخل متعدد القيم");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LookupField)
                    .HasMaxLength(500)
                    .HasComment("مدخل بحثى");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم");

                entity.Property(e => e.ResourceKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("مفتاح الموارد");

                entity.HasOne(d => d.Datasource)
                    .WithMany(p => p.TblRptSpparameters)
                    .HasForeignKey(d => d.DatasourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_rpt_SPParameter_tbl_rpt_Datasources_DatasourceID");
            });

            modelBuilder.Entity<TblSemesterAbsencePeriods>(entity =>
            {
                entity.HasKey(e => e.SemesterAbsencePeriodId)
                    .HasName("PK_tbl_SemesterAbsencePeriods_SemesterAbsencePeriodID");

                entity.ToTable("tbl_SemesterAbsencePeriods");

                entity.HasIndex(e => new { e.AcademicYearId, e.GradeId, e.SemesterId })
                    .HasName("UC_tbl_SemesterAbsencePeriods_Year")
                    .IsUnique();

                entity.Property(e => e.SemesterAbsencePeriodId).HasColumnName("SemesterAbsencePeriodID");

                entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.TblSemesterAbsencePeriods)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.TblSemesterAbsencePeriods)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.TblSemesterAbsencePeriods)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblSemesterSubjectSettings>(entity =>
            {
                entity.HasKey(e => e.SemesterSubjectSettingId)
                    .HasName("PK_tbl_SemesterSubjectSettings_SemesterSubjectSettingID");

                entity.ToTable("tbl_SemesterSubjectSettings");

                entity.HasIndex(e => new { e.SemesterId, e.GradeId, e.ClassId, e.SectionId, e.SubjectId })
                    .HasName("UC_tbl_SemesterSubjectSettings_SemesterIDGradeIDClassIDSectionIDSubjectID")
                    .IsUnique();

                entity.Property(e => e.SemesterSubjectSettingId).HasColumnName("SemesterSubjectSettingID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TblSemesterSubjectSettings)
                    .HasForeignKey(d => d.ClassId);

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.TblSemesterSubjectSettings)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.TblSemesterSubjectSettings)
                    .HasForeignKey(d => d.SectionId);

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.TblSemesterSubjectSettings)
                    .HasForeignKey(d => d.SemesterId);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblSemesterSubjectSettings)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblServicePrices>(entity =>
            {
                entity.HasKey(e => e.ServicePriceId)
                    .HasName("PK_tbl_ServicePrices_ServicePriceID");

                entity.ToTable("tbl_ServicePrices");

                entity.Property(e => e.ServicePriceId).HasColumnName("ServicePriceID");

                entity.Property(e => e.BookingTypeId).HasColumnName("BookingTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.CostCurrencyId).HasColumnName("CostCurrencyID");

                entity.Property(e => e.CostPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PortId).HasColumnName("PortID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SellPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");

                entity.HasOne(d => d.BookingType)
                    .WithMany(p => p.TblServicePrices)
                    .HasForeignKey(d => d.BookingTypeId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblServicePrices)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.TblServicePrices)
                    .HasForeignKey(d => d.CommodityId);

                entity.HasOne(d => d.CostCurrency)
                    .WithMany(p => p.TblServicePricesCostCurrency)
                    .HasForeignKey(d => d.CostCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblServicePricesCurrency)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Port)
                    .WithMany(p => p.TblServicePrices)
                    .HasForeignKey(d => d.PortId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblServicePrices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.TblServicePrices)
                    .HasForeignKey(d => d.ServiceProviderId);
            });

            modelBuilder.Entity<TblServiceProviderAttachments>(entity =>
            {
                entity.HasKey(e => e.ServiceProviderAttachmentId)
                    .HasName("PK_tbl_ServiceProviderAttachments_ServiceProviderAttachmentID");

                entity.ToTable("tbl_ServiceProviderAttachments");

                entity.Property(e => e.ServiceProviderAttachmentId).HasColumnName("ServiceProviderAttachmentID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName).HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.TblServiceProviderAttachments)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ServiceProviderAttachments_tbl_ServiceProviders");
            });

            modelBuilder.Entity<TblServiceProviders>(entity =>
            {
                entity.HasKey(e => e.ServiceProviderId)
                    .HasName("PK_tbl_ServiceProviders_ServiceProviderID");

                entity.ToTable("tbl_ServiceProviders");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_tbl_ServiceProviders_Code")
                    .IsUnique();

                entity.Property(e => e.ServiceProviderId)
                    .HasColumnName("ServiceProviderID")
                    .HasComment("رقم مقدمي الخدمة");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.Code).HasComment("الكود");

                entity.Property(e => e.CommercialRegistrationNumber).HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.IsFwagent).HasColumnName("IsFWAgent");

                entity.Property(e => e.IsIata).HasColumnName("IsIATA");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineName).HasMaxLength(100);

                entity.Property(e => e.MainContactPerson).HasMaxLength(200);

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("الاسم بالعربية");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم بالانجليزية");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.TaxNumber).HasMaxLength(100);

                entity.Property(e => e.Telephone1).HasMaxLength(100);

                entity.Property(e => e.Telephone2).HasMaxLength(100);

                entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");

                entity.HasOne(d => d.TransportType)
                    .WithMany(p => p.TblServiceProviders)
                    .HasForeignKey(d => d.TransportTypeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TblSettings>(entity =>
            {
                entity.HasKey(e => e.ItemName)
                    .HasName("PK_tbl_Settings_ItemName");

                entity.ToTable("tbl_Settings");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .HasComment("اسم الاعداد");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .HasComment("نوع قيمة الاعداد");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(150)
                    .HasComment("الاسم الظاهر للاعداد");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ItemValue).HasComment("قيمة الاعداد");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.SettingTypeId)
                    .HasColumnName("SettingTypeID")
                    .HasComment("رقم نوع الاعداد");

                entity.HasOne(d => d.SettingType)
                    .WithMany(p => p.TblSettings)
                    .HasForeignKey(d => d.SettingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblShipOwnerTest>(entity =>
            {
                entity.HasKey(e => e.ShipOwnerId)
                    .HasName("PK_tbl_ShipOwnerTest_ShipOwnerID");

                entity.ToTable("tbl_ShipOwnerTest");

                entity.Property(e => e.ShipOwnerId).HasColumnName("ShipOwnerID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");
            });

            modelBuilder.Entity<TblShipTest>(entity =>
            {
                entity.HasKey(e => e.ShipId)
                    .HasName("PK_tbl_ShipTest_ShipID");

                entity.ToTable("tbl_ShipTest");

                entity.HasIndex(e => e.Name)
                    .HasName("UC_tbl_ShipTest_Name")
                    .IsUnique();

                entity.Property(e => e.ShipId).HasColumnName("ShipID");

                entity.Property(e => e.CallSign).HasMaxLength(15);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManufactureDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("اسم السفينة");

                entity.Property(e => e.ShipOwnerId).HasColumnName("ShipOwnerID");

                entity.Property(e => e.ShipTypeId).HasColumnName("ShipTypeID");

                entity.HasOne(d => d.ShipOwner)
                    .WithMany(p => p.TblShipTest)
                    .HasForeignKey(d => d.ShipOwnerId);

                entity.HasOne(d => d.ShipType)
                    .WithMany(p => p.TblShipTest)
                    .HasForeignKey(d => d.ShipTypeId);
            });

            modelBuilder.Entity<TblShipTypeTest>(entity =>
            {
                entity.HasKey(e => e.ShipTypeId)
                    .HasName("PK_tbl_ShipType_ShipTypeID");

                entity.ToTable("tbl_ShipTypeTest");

                entity.Property(e => e.ShipTypeId).HasColumnName("ShipTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.ShipTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblStudentAbsences>(entity =>
            {
                entity.HasKey(e => e.StudentAbsentId)
                    .HasName("PK_tbl_StudentAbsences_StudentAbsentID");

                entity.ToTable("tbl_StudentAbsences");

                entity.Property(e => e.StudentAbsentId).HasColumnName("StudentAbsentID");

                entity.Property(e => e.AbsentReasonId).HasColumnName("AbsentReasonID");

                entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.SchoolDayDate).HasColumnType("datetime");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.AbsentReason)
                    .WithMany(p => p.TblStudentAbsences)
                    .HasForeignKey(d => d.AbsentReasonId);

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.TblStudentAbsences)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentAbsences)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudentAcademicYears>(entity =>
            {
                entity.HasKey(e => e.StudentAcademicYearId)
                    .HasName("PK_tbl_StudentAcademicYears_StudentAcademicYearID");

                entity.ToTable("tbl_StudentAcademicYears");

                entity.HasIndex(e => e.AcademicYearId)
                    .HasName("IDX_tbl_StudentAcademicYears_AcademicYearID");

                entity.HasIndex(e => e.ClassId)
                    .HasName("IDX_tbl_StudentAcademicYears_ClassID");

                entity.HasIndex(e => e.GradeId)
                    .HasName("IDX_tbl_StudentAcademicYears_GradeID");

                entity.HasIndex(e => e.SeatNumber)
                    .HasName("IDX_tbl_StudentAcademicYears_SeatNumber");

                entity.HasIndex(e => e.StudentId)
                    .HasName("IDX_tbl_StudentAcademicYears_StudentID");

                entity.HasIndex(e => new { e.AcademicYearId, e.StudentId })
                    .HasName("UC_tbl_StudentAcademicYears_AcademicYearIDStudentID")
                    .IsUnique();

                entity.Property(e => e.StudentAcademicYearId).HasColumnName("StudentAcademicYearID");

                entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FirstPaymentStatusId).HasColumnName("FirstPaymentStatusID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.IsAbsent).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.OnlyPayPortionTypeId).HasColumnName("OnlyPayPortionTypeID");

                entity.Property(e => e.PaymentDiscountTypeId).HasColumnName("PaymentDiscountTypeID");

                entity.Property(e => e.PaymentDiscountValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PaymentRemarks).HasColumnType("ntext");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SecondPaymentStatusId).HasColumnName("SecondPaymentStatusID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentStatusId).HasColumnName("StudentStatusID");

                entity.Property(e => e.StudentStatusNote).HasMaxLength(300);

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.TblStudentAcademicYears)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TblStudentAcademicYears)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FirstPaymentStatus)
                    .WithMany(p => p.TblStudentAcademicYearsFirstPaymentStatus)
                    .HasForeignKey(d => d.FirstPaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.TblStudentAcademicYears)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.OnlyPayPortionType)
                    .WithMany(p => p.TblStudentAcademicYears)
                    .HasForeignKey(d => d.OnlyPayPortionTypeId)
                    .HasConstraintName("FK_tbl_StudentAcademicYears_lkp_PaymentPortionTypess_OnlyPayPortionTypeID");

                entity.HasOne(d => d.PaymentDiscountType)
                    .WithMany(p => p.TblStudentAcademicYears)
                    .HasForeignKey(d => d.PaymentDiscountTypeId)
                    .HasConstraintName("FK_tbl_StudentAcademicYears_lkp_DiscountTypes_PaymentDiscountTypeID");

                entity.HasOne(d => d.SecondPaymentStatus)
                    .WithMany(p => p.TblStudentAcademicYearsSecondPaymentStatus)
                    .HasForeignKey(d => d.SecondPaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.TblStudentAcademicYears)
                    .HasForeignKey(d => d.SectionId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentAcademicYears)
                    .HasForeignKey(d => d.StudentId);

                entity.HasOne(d => d.StudentStatus)
                    .WithMany(p => p.TblStudentAcademicYears)
                    .HasForeignKey(d => d.StudentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudentAttachments>(entity =>
            {
                entity.HasKey(e => e.StudentAttachmentId)
                    .HasName("PK_tbl_StudentAttachments_StudentAttachmentID");

                entity.ToTable("tbl_StudentAttachments");

                entity.Property(e => e.StudentAttachmentId).HasColumnName("StudentAttachmentID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName).HasColumnType("ntext");

                entity.Property(e => e.FormNumber).HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentAttachments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudentContacts>(entity =>
            {
                entity.HasKey(e => e.StudentContactId)
                    .HasName("PK_tbl_StudentContacts_StudentContactID");

                entity.ToTable("tbl_StudentContacts");

                entity.Property(e => e.StudentContactId).HasColumnName("StudentContactID");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NationalIdnumber)
                    .HasColumnName("NationalIDNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.PersonName).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Telephone).HasMaxLength(100);

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.TblStudentContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentContacts)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudentDegrees>(entity =>
            {
                entity.HasKey(e => e.StudentDegreeId)
                    .HasName("PK_tbl_StudentDegrees_StudentDegreeID");

                entity.ToTable("tbl_StudentDegrees");

                entity.HasIndex(e => new { e.SubjectId, e.StudentExamId })
                    .HasName("UC_tbl_StudentDegrees_SubjectIDStudentExamID")
                    .IsUnique();

                entity.Property(e => e.StudentDegreeId).HasColumnName("StudentDegreeID");

                entity.Property(e => e.ActivityGroupDegrees).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ActivityIndividualDegrees).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ActivityOralDegrees).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ActivtyGroup2Degrees).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ColorDegreeId).HasColumnName("ColorDegreeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.StudentExamId).HasColumnName("StudentExamID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.TotalDegree).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.WrittenDegree).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.ColorDegree)
                    .WithMany(p => p.TblStudentDegrees)
                    .HasForeignKey(d => d.ColorDegreeId);

                entity.HasOne(d => d.StudentExam)
                    .WithMany(p => p.TblStudentDegrees)
                    .HasForeignKey(d => d.StudentExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudentExams>(entity =>
            {
                entity.HasKey(e => e.StudentExamId)
                    .HasName("PK_tbl_StudentExams_StudentExamID");

                entity.ToTable("tbl_StudentExams");

                entity.HasIndex(e => new { e.StudentSemesterId, e.ExamId })
                    .HasName("UC_tbl_StudentExams_StudentSemesterIDExamID")
                    .IsUnique();

                entity.Property(e => e.StudentExamId).HasColumnName("StudentExamID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.StudentSemesterId).HasColumnName("StudentSemesterID");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.TblStudentExams)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StudentSemester)
                    .WithMany(p => p.TblStudentExams)
                    .HasForeignKey(d => d.StudentSemesterId);
            });

            modelBuilder.Entity<TblStudentMedicalHistories>(entity =>
            {
                entity.HasKey(e => e.StudentMedicalHistoriyId)
                    .HasName("PK_tbl_StudentMedicalHistories_StudentMedicalHistoriyID");

                entity.ToTable("tbl_StudentMedicalHistories");

                entity.Property(e => e.StudentMedicalHistoriyId).HasColumnName("StudentMedicalHistoriyID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DiseaseName).HasMaxLength(100);

                entity.Property(e => e.DiseaseTypeId).HasColumnName("DiseaseTypeID");

                entity.Property(e => e.EmergencyRemarks).HasColumnType("ntext");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.DiseaseType)
                    .WithMany(p => p.TblStudentMedicalHistories)
                    .HasForeignKey(d => d.DiseaseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentMedicalHistories)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudentPaymentReceivables>(entity =>
            {
                entity.HasKey(e => new { e.InvoicePaymentId, e.StudentPaymentId })
                    .HasName("PK_tbl_StudentPaymentReceivables_InvoicePaymentIDStudentPaymentID");

                entity.ToTable("tbl_StudentPaymentReceivables");

                entity.Property(e => e.InvoicePaymentId).HasColumnName("InvoicePaymentID");

                entity.Property(e => e.StudentPaymentId).HasColumnName("StudentPaymentID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PaidValue).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.InvoicePayment)
                    .WithMany(p => p.TblStudentPaymentReceivables)
                    .HasForeignKey(d => d.InvoicePaymentId);

                entity.HasOne(d => d.StudentPayment)
                    .WithMany(p => p.TblStudentPaymentReceivables)
                    .HasForeignKey(d => d.StudentPaymentId);
            });

            modelBuilder.Entity<TblStudentPayments>(entity =>
            {
                entity.HasKey(e => e.StudentPaymentId)
                    .HasName("PK_tbl_StudentPayments_StudentPaymentID");

                entity.ToTable("tbl_StudentPayments");

                entity.HasIndex(e => new { e.AcademicYearId, e.SerialNumber })
                    .HasName("UC_tbl_StudentPayments_AcademicYearIDSerialNumber")
                    .IsUnique();

                entity.Property(e => e.StudentPaymentId).HasColumnName("StudentPaymentID");

                entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

                entity.Property(e => e.BankReceiptNo).HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentPortionTypeId).HasColumnName("PaymentPortionTypeID");

                entity.Property(e => e.ReceiptNumber).HasMaxLength(100);

                entity.Property(e => e.ReceiptNumberOther).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.StudentAcademicYearId).HasColumnName("StudentAcademicYearID");

                entity.Property(e => e.TreasuryId).HasColumnName("TreasuryID");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.TblStudentPayments)
                    .HasForeignKey(d => d.BankAccountId);

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.TblStudentPayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PaymentPortionType)
                    .WithMany(p => p.TblStudentPayments)
                    .HasForeignKey(d => d.PaymentPortionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StudentAcademicYear)
                    .WithMany(p => p.TblStudentPayments)
                    .HasForeignKey(d => d.StudentAcademicYearId);

                entity.HasOne(d => d.Treasury)
                    .WithMany(p => p.TblStudentPayments)
                    .HasForeignKey(d => d.TreasuryId);
            });

            modelBuilder.Entity<TblStudentSemesters>(entity =>
            {
                entity.HasKey(e => e.StudentSemesterId)
                    .HasName("PK_tbl_StudentSemesters_StudentSemesterID");

                entity.ToTable("tbl_StudentSemesters");

                entity.HasIndex(e => e.StudentAcademicYearId)
                    .HasName("IDX_tbl_StudentSemesters_StudentAcademicYearID");

                entity.HasIndex(e => new { e.StudentAcademicYearId, e.SemesterId })
                    .HasName("IDX_tbl_StudentSemesters_StudentAcademicYearIDSemesterID");

                entity.Property(e => e.StudentSemesterId).HasColumnName("StudentSemesterID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.StudentAcademicYearId).HasColumnName("StudentAcademicYearID");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.TblStudentSemesters)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StudentAcademicYear)
                    .WithMany(p => p.TblStudentSemesters)
                    .HasForeignKey(d => d.StudentAcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudentSisters>(entity =>
            {
                entity.HasKey(e => e.StudentSisterId)
                    .HasName("PK_tbl_StudentSisters_StudentSisterID");

                entity.ToTable("tbl_StudentSisters");

                entity.HasIndex(e => new { e.StudentId, e.SisterId })
                    .HasName("UC_tbl_StudentSisters_StudentIDSisterID")
                    .IsUnique();

                entity.Property(e => e.StudentSisterId).HasColumnName("StudentSisterID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.SisterId).HasColumnName("SisterID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Sister)
                    .WithMany(p => p.TblStudentSistersSister)
                    .HasForeignKey(d => d.SisterId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentSistersStudent)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudentSubjects>(entity =>
            {
                entity.HasKey(e => e.StudentSubjectId)
                    .HasName("PK_tbl_StudentSubjects_StudentSubjectID");

                entity.ToTable("tbl_StudentSubjects");

                entity.HasIndex(e => e.StudentSemesterId)
                    .HasName("IDX_tbl_StudentSubjects_StudentSemesterID");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IDX_tbl_StudentSubjects_SubjectID");

                entity.HasIndex(e => new { e.StudentSemesterId, e.SubjectId })
                    .HasName("UC_tbl_StudentSubjects_StudentSemesterIDSubjectID")
                    .IsUnique();

                entity.Property(e => e.StudentSubjectId).HasColumnName("StudentSubjectID");

                entity.Property(e => e.ActivityDegree).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ActivitySubjectId).HasColumnName("ActivitySubjectID");

                entity.Property(e => e.AttendanceDegree).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BehaviorDegree).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.OralDegree).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PracticalDegree).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.StudentSemesterId).HasColumnName("StudentSemesterID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.WrittenDegree).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.ActivitySubject)
                    .WithMany(p => p.TblStudentSubjects)
                    .HasForeignKey(d => d.ActivitySubjectId);

                entity.HasOne(d => d.StudentSemester)
                    .WithMany(p => p.TblStudentSubjects)
                    .HasForeignKey(d => d.StudentSemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblStudentSubjects)
                    .HasForeignKey(d => d.SubjectId);
            });

            modelBuilder.Entity<TblStudentWaitingListSisters>(entity =>
            {
                entity.HasKey(e => e.StudentWaitingListSisterId)
                    .HasName("PK_tbl_StudentWaitingListSisters_StudentSisterID");

                entity.ToTable("tbl_StudentWaitingListSisters");

                entity.HasIndex(e => new { e.StudentWaitingListId, e.SisterId })
                    .HasName("UC_tbl_StudentWaitingListSisters_StudentWaitingListIDSisterID")
                    .IsUnique();

                entity.Property(e => e.StudentWaitingListSisterId).HasColumnName("StudentWaitingListSisterID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.SisterId).HasColumnName("SisterID");

                entity.Property(e => e.StudentWaitingListId).HasColumnName("StudentWaitingListID");

                entity.HasOne(d => d.Sister)
                    .WithMany(p => p.TblStudentWaitingListSisters)
                    .HasForeignKey(d => d.SisterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StudentWaitingList)
                    .WithMany(p => p.TblStudentWaitingListSisters)
                    .HasForeignKey(d => d.StudentWaitingListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_StudentSisters_tbl_StudentWaitingLists_StudentWaitingListID");
            });

            modelBuilder.Entity<TblStudentWaitingLists>(entity =>
            {
                entity.HasKey(e => e.StudentWaitingListId)
                    .HasName("PK_tbl_StudentWaitingLists_WaitingListStatusID");

                entity.ToTable("tbl_StudentWaitingLists");

                entity.HasIndex(e => e.FatherName)
                    .HasName("IDX_tbl_StudentWaitingLists_FatherName");

                entity.HasIndex(e => new { e.AcademicYearId, e.FileNumber })
                    .HasName("UC_tbl_StudentWaitingLists_AcademicYearIDFileNumber")
                    .IsUnique();

                entity.Property(e => e.StudentWaitingListId).HasColumnName("StudentWaitingListID");

                entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FatherEmail).HasMaxLength(100);

                entity.Property(e => e.FatherJob).HasMaxLength(200);

                entity.Property(e => e.FatherMobile).HasMaxLength(100);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FatherNationalIdnumber)
                    .HasColumnName("FatherNationalIDNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.FatherQualificationId).HasColumnName("FatherQualificationID");

                entity.Property(e => e.FatherWorkTelephone).HasMaxLength(100);

                entity.Property(e => e.FileNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstNameAr).HasMaxLength(300);

                entity.Property(e => e.GenderTypeId)
                    .HasColumnName("GenderTypeID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationOfBirth)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.MotherJob).HasMaxLength(200);

                entity.Property(e => e.MotherMobile).HasMaxLength(100);

                entity.Property(e => e.MotherName).HasMaxLength(100);

                entity.Property(e => e.MotherQualificationId).HasColumnName("MotherQualificationID");

                entity.Property(e => e.MotherWorkTelephone).HasMaxLength(100);

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.NationalIdnumber)
                    .HasColumnName("NationalIDNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.OfficialRegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.OfficialRegistrationNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ParentStatusId).HasColumnName("ParentStatusID");

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Telephone).HasMaxLength(100);

                entity.Property(e => e.WaitingListStatusId).HasColumnName("WaitingListStatusID");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FatherQualification)
                    .WithMany(p => p.TblStudentWaitingListsFatherQualification)
                    .HasForeignKey(d => d.FatherQualificationId);

                entity.HasOne(d => d.GenderType)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.GenderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MotherQualification)
                    .WithMany(p => p.TblStudentWaitingListsMotherQualification)
                    .HasForeignKey(d => d.MotherQualificationId);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.NationalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ParentStatus)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.ParentStatusId);

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.ReligionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.StudentId);

                entity.HasOne(d => d.WaitingListStatus)
                    .WithMany(p => p.TblStudentWaitingLists)
                    .HasForeignKey(d => d.WaitingListStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblStudents>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK_StudentID_StudentID");

                entity.ToTable("tbl_Students");

                entity.HasIndex(e => e.Code)
                    .HasName("UC_tbl_Students_Code")
                    .IsUnique();

                entity.HasIndex(e => e.FatherName)
                    .HasName("IDX_tbl_Students_FatherName");

                entity.HasIndex(e => e.MotherName)
                    .HasName("IDX_tbl_Students_MotherName");

                entity.HasIndex(e => e.NameAr)
                    .HasName("IDX_tbl_Students_NameAr");

                entity.HasIndex(e => e.NameFr)
                    .HasName("IDX_tbl_Students_NameFr");

                entity.HasIndex(e => e.StudentId)
                    .HasName("IDX_tbl_Students_StudentID");

                entity.HasIndex(e => e.Telephone)
                    .HasName("IDX_tbl_Students_Telephone");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FatherJob).HasMaxLength(200);

                entity.Property(e => e.FatherMobile).HasMaxLength(100);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FatherNationalIdnumber)
                    .HasColumnName("FatherNationalIDNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.FatherQualificationId).HasColumnName("FatherQualificationID");

                entity.Property(e => e.FatherWorkTelephone).HasMaxLength(100);

                entity.Property(e => e.FirstNameAr).HasMaxLength(100);

                entity.Property(e => e.GenderTypeId)
                    .HasColumnName("GenderTypeID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.IntegrationId)
                    .HasColumnName("IntegrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationOfBirth)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.MotherJob).HasMaxLength(200);

                entity.Property(e => e.MotherMobile).HasMaxLength(100);

                entity.Property(e => e.MotherName).HasMaxLength(100);

                entity.Property(e => e.MotherQualificationId).HasColumnName("MotherQualificationID");

                entity.Property(e => e.MotherWorkTelephone).HasMaxLength(100);

                entity.Property(e => e.NameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.NationalIdnumber)
                    .HasColumnName("NationalIDNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.OfficialRegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.OfficialRegistrationNumber).HasMaxLength(100);

                entity.Property(e => e.ParentStatusId).HasColumnName("ParentStatusID");

                entity.Property(e => e.PhotoFileName).HasColumnType("ntext");

                entity.Property(e => e.PrivateNotes).HasColumnType("ntext");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ResponsibleAddress).HasColumnType("ntext");

                entity.Property(e => e.ResponsibleMobile).HasMaxLength(100);

                entity.Property(e => e.ResponsibleName).HasMaxLength(100);

                entity.Property(e => e.ResponsibleTelephone).HasMaxLength(100);

                entity.Property(e => e.SchoolEmail).HasMaxLength(100);

                entity.Property(e => e.StudentResponsibleRelationId).HasColumnName("StudentResponsibleRelationID");

                entity.Property(e => e.Telephone).HasMaxLength(100);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.AreaId);

                entity.HasOne(d => d.FatherQualification)
                    .WithMany(p => p.TblStudentsFatherQualification)
                    .HasForeignKey(d => d.FatherQualificationId);

                entity.HasOne(d => d.GenderType)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.GenderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MotherQualification)
                    .WithMany(p => p.TblStudentsMotherQualification)
                    .HasForeignKey(d => d.MotherQualificationId);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.NationalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ParentStatus)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.ParentStatusId);

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.ReligionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StudentResponsibleRelation)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.StudentResponsibleRelationId);
            });

            modelBuilder.Entity<TblSubActivitiesSharePercentageSettings>(entity =>
            {
                entity.HasKey(e => e.SubActivitiesSharePercentageSettingId);

                entity.ToTable("tbl_SubActivitiesSharePercentageSettings");

                entity.HasIndex(e => new { e.AccountShareSettingId, e.SubActivityId, e.FromDate })
                    .HasName("UC_tbl_SubActivitiesSharePercentageSettings_AccountShareSettingIDSubActivityIDFromDate")
                    .IsUnique();

                entity.Property(e => e.SubActivitiesSharePercentageSettingId).HasColumnName("SubActivitiesSharePercentageSettingID");

                entity.Property(e => e.AccountShareSettingId).HasColumnName("AccountShareSettingID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Percentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SubActivityId).HasColumnName("SubActivityID");

                entity.HasOne(d => d.AccountShareSetting)
                    .WithMany(p => p.TblSubActivitiesSharePercentageSettings)
                    .HasForeignKey(d => d.AccountShareSettingId);

                entity.HasOne(d => d.SubActivity)
                    .WithMany(p => p.TblSubActivitiesSharePercentageSettings)
                    .HasForeignKey(d => d.SubActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblSupplierContactPersons>(entity =>
            {
                entity.HasKey(e => e.SupplierContactPersonId)
                    .HasName("PK_tbl_SupplierContactPersons_SupplierContactPersonID");

                entity.ToTable("tbl_SupplierContactPersons");

                entity.Property(e => e.SupplierContactPersonId).HasColumnName("SupplierContactPersonID");

                entity.Property(e => e.ContactPersonTypeId).HasColumnName("ContactPersonTypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DirectPhone).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Telephone).HasMaxLength(100);

                entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");

                entity.HasOne(d => d.ContactPersonType)
                    .WithMany(p => p.TblSupplierContactPersons)
                    .HasForeignKey(d => d.ContactPersonTypeId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSupplierContactPersons)
                    .HasForeignKey(d => d.SupplierId);

                entity.HasOne(d => d.TransportType)
                    .WithMany(p => p.TblSupplierContactPersons)
                    .HasForeignKey(d => d.TransportTypeId);
            });

            modelBuilder.Entity<TblTransferJournals>(entity =>
            {
                entity.HasKey(e => new { e.TransferId, e.JournalId })
                    .HasName("PK_tbl_TransferJournals_UserIDSubjectID");

                entity.ToTable("tbl_TransferJournals");

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.TblTransferJournals)
                    .HasForeignKey(d => d.JournalId);

                entity.HasOne(d => d.Transfer)
                    .WithMany(p => p.TblTransferJournals)
                    .HasForeignKey(d => d.TransferId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblTransfers>(entity =>
            {
                entity.HasKey(e => e.TransferId)
                    .HasName("PK_tbl_Transfers_TransferID");

                entity.ToTable("tbl_Transfers");

                entity.HasIndex(e => new { e.FinancialYearId, e.TransferSerial })
                    .HasName("UC_tbl_Transfers_FinancialYearIDTransferSerial")
                    .IsUnique();

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.FromBankAccountId).HasColumnName("FromBankAccountID");

                entity.Property(e => e.FromTreasuryId).HasColumnName("FromTreasuryID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.ToBankAccountId).HasColumnName("ToBankAccountID");

                entity.Property(e => e.ToTreasuryId).HasColumnName("ToTreasuryID");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferValue).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblTransfers)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TblTransfers)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_StudentPayments_lkp_AcademicYears_AcademicYearID");

                entity.HasOne(d => d.FromBankAccount)
                    .WithMany(p => p.TblTransfersFromBankAccount)
                    .HasForeignKey(d => d.FromBankAccountId);

                entity.HasOne(d => d.FromTreasury)
                    .WithMany(p => p.TblTransfersFromTreasury)
                    .HasForeignKey(d => d.FromTreasuryId);

                entity.HasOne(d => d.ToBankAccount)
                    .WithMany(p => p.TblTransfersToBankAccount)
                    .HasForeignKey(d => d.ToBankAccountId);

                entity.HasOne(d => d.ToTreasury)
                    .WithMany(p => p.TblTransfersToTreasury)
                    .HasForeignKey(d => d.ToTreasuryId);
            });

            modelBuilder.Entity<TblUmComponents>(entity =>
            {
                entity.HasKey(e => e.ComponentId)
                    .HasName("PK_UM_Components_ComponentID");

                entity.ToTable("tbl_UM_Components");

                entity.Property(e => e.ComponentId)
                    .HasColumnName("ComponentID")
                    .HasComment("رقم القائمة الفرعية")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم القائمة الفرعية بالانجليزية");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("اسم القائمة الفرعية بالعربية");

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.OrderBy).HasComment("ترتيم القائمة الفرعية");

                entity.Property(e => e.SystemId)
                    .HasColumnName("SystemID")
                    .HasComment("رقم النظام");

                entity.HasOne(d => d.System)
                    .WithMany(p => p.TblUmComponents)
                    .HasForeignKey(d => d.SystemId);
            });

            modelBuilder.Entity<TblUmModules>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_UM_Modules_ModuleID");

                entity.ToTable("tbl_UM_Modules");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasComment("رقم الوحدة")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComponentId)
                    .HasColumnName("ComponentID")
                    .HasComment("رقم القائمة الفرعية");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم الوحدة بالانجليزية");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("اسم الوحدة بالعربية");

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.OrderBy).HasComment("ترتيب الوحدة");

                entity.Property(e => e.StartupUrl)
                    .HasColumnName("StartupURL")
                    .HasMaxLength(400)
                    .HasComment("عنوان بداية الوحدة");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.TblUmModules)
                    .HasForeignKey(d => d.ComponentId);
            });

            modelBuilder.Entity<TblUmServiceUrls>(entity =>
            {
                entity.HasKey(e => e.ServiceUrlid)
                    .HasName("PK_UM_ServiceURLS_ServiceURLID");

                entity.ToTable("tbl_UM_ServiceURLS");

                entity.Property(e => e.ServiceUrlid)
                    .HasColumnName("ServiceURLID")
                    .HasComment("رقم عنوان الخدمة")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم عنوان الخدمة");

                entity.Property(e => e.OrderBy).HasComment("ترتيب عنوان الخدمة");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("ServiceID")
                    .HasComment("رقم الخدمة");

                entity.Property(e => e.ServiceUrl)
                    .HasColumnName("ServiceURL")
                    .HasColumnType("ntext")
                    .HasComment("عنوان الخدمة");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblUmServiceUrls)
                    .HasForeignKey(d => d.ServiceId);
            });

            modelBuilder.Entity<TblUmServices>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_UM_Services_ServiceID");

                entity.ToTable("tbl_UM_Services");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("ServiceID")
                    .HasComment("رقم الخدمة")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command)
                    .HasMaxLength(100)
                    .HasComment("الأمر");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasComment("رقم الوحدة");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم الخدمة بالانجليزية");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("اسم الخدمة بالعربية");

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.OrderBy).HasComment("ترتيب الخدمة");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.TblUmServices)
                    .HasForeignKey(d => d.ModuleId);
            });

            modelBuilder.Entity<TblUmSystems>(entity =>
            {
                entity.HasKey(e => e.SystemId)
                    .HasName("PK_UM_Systems_SystemID");

                entity.ToTable("tbl_UM_Systems");

                entity.Property(e => e.SystemId)
                    .HasColumnName("SystemID")
                    .HasComment("رقم النظام")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم النظام بالانجليزية");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(100)
                    .HasComment("اسم النظام بالعربية");

                entity.Property(e => e.NameFr).HasMaxLength(100);

                entity.Property(e => e.OrderBy).HasComment("ترتيب النظام");
            });

            modelBuilder.Entity<TblUserAbsenceResonsibleGrades>(entity =>
            {
                entity.HasKey(e => e.UserAbsenceResonsibleGradeId)
                    .HasName("PK_tbl_UserAbsenceResonsibleGrades_UserSubjectID");

                entity.ToTable("tbl_UserAbsenceResonsibleGrades");

                entity.Property(e => e.UserAbsenceResonsibleGradeId).HasColumnName("UserAbsenceResonsibleGradeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.TblUserAbsenceResonsibleGrades)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblUserAbsenceResonsibleGrades)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TblUserClasses>(entity =>
            {
                entity.HasKey(e => e.UserClassId)
                    .HasName("PK_tbl_UserClasses_UserClassID");

                entity.ToTable("tbl_UserClasses");

                entity.HasIndex(e => new { e.ClassId, e.UserSubjectId })
                    .HasName("UC_tbl_UserClasses_ClassIDUserSubjectID")
                    .IsUnique();

                entity.Property(e => e.UserClassId).HasColumnName("UserClassID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.UserSubjectId).HasColumnName("UserSubjectID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TblUserClasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_StudentPayments_lkp_Classes_ClassID");

                entity.HasOne(d => d.UserSubject)
                    .WithMany(p => p.TblUserClasses)
                    .HasForeignKey(d => d.UserSubjectId);
            });

            modelBuilder.Entity<TblUserEvents>(entity =>
            {
                entity.HasKey(e => e.UserEventId)
                    .HasName("PK_tbl_UserEvents_EventStatusID");

                entity.ToTable("tbl_UserEvents");

                entity.Property(e => e.UserEventId).HasColumnName("UserEventID");

                entity.Property(e => e.AccountPayableId).HasColumnName("AccountPayableID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.EventStatusId).HasColumnName("EventStatusID");

                entity.Property(e => e.InvoicePaymentId).HasColumnName("InvoicePaymentID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NotificationPeriod).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.AccountPayable)
                    .WithMany(p => p.TblUserEvents)
                    .HasForeignKey(d => d.AccountPayableId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.EventStatus)
                    .WithMany(p => p.TblUserEvents)
                    .HasForeignKey(d => d.EventStatusId);

                entity.HasOne(d => d.InvoicePayment)
                    .WithMany(p => p.TblUserEvents)
                    .HasForeignKey(d => d.InvoicePaymentId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblUserEvents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_tbl_UserRoles_UserIDRoleID");

                entity.ToTable("tbl_UserRoles");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("رقم المستخدم");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("رقم الدور");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TblUserSubjects>(entity =>
            {
                entity.HasKey(e => e.UserSubjectId)
                    .HasName("PK_tbl_UserSubjects_UserSubjectID");

                entity.ToTable("tbl_UserSubjects");

                entity.Property(e => e.UserSubjectId).HasColumnName("UserSubjectID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblUserSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblUserSubjects)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_tbl_Users_UserID");

                entity.ToTable("tbl_Users");

                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("idx_tbl_Users_CreatorUserID");

                entity.HasIndex(e => e.ModifiedUserId)
                    .HasName("idx_tbl_Users_ModifiedUserID");

                entity.HasIndex(e => e.Username)
                    .HasName("UC_tbl_Users_UserName")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("رقم المستخدم");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasComment("رقم معرف الفرع");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasComment("البريد الإلكترونى للمستخدم");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("الاسم الاول للمستخدم");

                entity.Property(e => e.IsSystemAccount).HasComment("حساب النظام");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .HasComment("الاسم الاخير للمستخدم");

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("كلمة سر المستخدم");

                entity.Property(e => e.SalesRegionId).HasColumnName("SalesRegionID");

                entity.Property(e => e.ServiceBitMap)
                    .HasColumnType("ntext")
                    .HasComment("خريطة صلاحيات الخدمات");

                entity.Property(e => e.ThemeId)
                    .HasColumnName("ThemeID")
                    .HasComment("رقم معرف الثيم");

                entity.Property(e => e.TransportTypeId).HasColumnName("TransportTypeID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasComment("اسم دخول المستخدم");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.DepartmentId);

                entity.HasOne(d => d.SalesRegion)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.SalesRegionId);

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.ThemeId);

                entity.HasOne(d => d.TransportType)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.TransportTypeId);
            });

            modelBuilder.Entity<ViwLkpCurrencies>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_lkp_Currencies");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CurrNameAr)
                    .IsRequired()
                    .HasMaxLength(121);

                entity.Property(e => e.CurrNameEn)
                    .IsRequired()
                    .HasMaxLength(121);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ViwLkpGrades>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_lkp_Grades");

                entity.Property(e => e.ArabicName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FrenchName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GradeId)
                    .HasColumnName("GradeID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViwTblAccAccounts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viw_tbl_acc_Accounts");

                entity.Property(e => e.AccNameAr)
                    .IsRequired()
                    .HasMaxLength(131);

                entity.Property(e => e.AccNameEn)
                    .IsRequired()
                    .HasMaxLength(131);

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
