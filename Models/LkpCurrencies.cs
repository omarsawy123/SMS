using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpCurrencies
    {
        public LkpCurrencies()
        {
            LkpAccTreasuryCurrencies = new HashSet<LkpAccTreasuryCurrencies>();
            LkpBankAccounts = new HashSet<LkpBankAccounts>();
            LkpInvoiceTypeCurrencies = new HashSet<LkpInvoiceTypeCurrencies>();
            TblAccAccountBalances = new HashSet<TblAccAccountBalances>();
            TblAccAccountCurrencyLinks = new HashSet<TblAccAccountCurrencyLinks>();
            TblAccAccountPayables = new HashSet<TblAccAccountPayables>();
            TblAccAccounts = new HashSet<TblAccAccounts>();
            TblAccExchangeRatesFromCurrency = new HashSet<TblAccExchangeRates>();
            TblAccExchangeRatesToCurrency = new HashSet<TblAccExchangeRates>();
            TblAccJournals = new HashSet<TblAccJournals>();
            TblAccSupplierInvoices = new HashSet<TblAccSupplierInvoices>();
            TblBookingDetails = new HashSet<TblBookingDetails>();
            TblClientRateAgreementContainers = new HashSet<TblClientRateAgreementContainers>();
            TblClients = new HashSet<TblClients>();
            TblContractedLineCurrencies = new HashSet<TblContractedLineCurrencies>();
            TblDebitNotes = new HashSet<TblDebitNotes>();
            TblInvoicePayments = new HashSet<TblInvoicePayments>();
            TblInvoices = new HashSet<TblInvoices>();
            TblPricingListPricesCostCurrency = new HashSet<TblPricingListPrices>();
            TblPricingListPricesCurrency = new HashSet<TblPricingListPrices>();
            TblQuoteDetails = new HashSet<TblQuoteDetails>();
            TblQuoteServices = new HashSet<TblQuoteServices>();
            TblServicePricesCostCurrency = new HashSet<TblServicePrices>();
            TblServicePricesCurrency = new HashSet<TblServicePrices>();
            TblTransfers = new HashSet<TblTransfers>();
        }

        public int CurrencyId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string SmallUnitNameEn { get; set; }
        public string SmallUnitNameAr { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpAccTreasuryCurrencies> LkpAccTreasuryCurrencies { get; set; }
        public virtual ICollection<LkpBankAccounts> LkpBankAccounts { get; set; }
        public virtual ICollection<LkpInvoiceTypeCurrencies> LkpInvoiceTypeCurrencies { get; set; }
        public virtual ICollection<TblAccAccountBalances> TblAccAccountBalances { get; set; }
        public virtual ICollection<TblAccAccountCurrencyLinks> TblAccAccountCurrencyLinks { get; set; }
        public virtual ICollection<TblAccAccountPayables> TblAccAccountPayables { get; set; }
        public virtual ICollection<TblAccAccounts> TblAccAccounts { get; set; }
        public virtual ICollection<TblAccExchangeRates> TblAccExchangeRatesFromCurrency { get; set; }
        public virtual ICollection<TblAccExchangeRates> TblAccExchangeRatesToCurrency { get; set; }
        public virtual ICollection<TblAccJournals> TblAccJournals { get; set; }
        public virtual ICollection<TblAccSupplierInvoices> TblAccSupplierInvoices { get; set; }
        public virtual ICollection<TblBookingDetails> TblBookingDetails { get; set; }
        public virtual ICollection<TblClientRateAgreementContainers> TblClientRateAgreementContainers { get; set; }
        public virtual ICollection<TblClients> TblClients { get; set; }
        public virtual ICollection<TblContractedLineCurrencies> TblContractedLineCurrencies { get; set; }
        public virtual ICollection<TblDebitNotes> TblDebitNotes { get; set; }
        public virtual ICollection<TblInvoicePayments> TblInvoicePayments { get; set; }
        public virtual ICollection<TblInvoices> TblInvoices { get; set; }
        public virtual ICollection<TblPricingListPrices> TblPricingListPricesCostCurrency { get; set; }
        public virtual ICollection<TblPricingListPrices> TblPricingListPricesCurrency { get; set; }
        public virtual ICollection<TblQuoteDetails> TblQuoteDetails { get; set; }
        public virtual ICollection<TblQuoteServices> TblQuoteServices { get; set; }
        public virtual ICollection<TblServicePrices> TblServicePricesCostCurrency { get; set; }
        public virtual ICollection<TblServicePrices> TblServicePricesCurrency { get; set; }
        public virtual ICollection<TblTransfers> TblTransfers { get; set; }
    }
}
