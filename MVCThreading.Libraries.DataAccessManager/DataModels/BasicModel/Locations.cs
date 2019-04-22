//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCThreading.Libraries.DataAccessManager.DataModels.BasicModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Locations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Locations()
        {
            this.BettorTickets = new HashSet<BettorTickets>();
            this.Locations1 = new HashSet<Locations>();
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int LocationId { get; set; }
        public int ToteId { get; set; }
        public bool IsFormalLocation { get; set; }
        public Nullable<int> FormalLocationId { get; set; }
        public Nullable<int> FormalToteId { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public string LocationEmail { get; set; }
        public string LocationGroup { get; set; }
        public string LicenseeOperatorId { get; set; }
        public string LicenseeOperatorName { get; set; }
        public string LicenseeId { get; set; }
        public string LicenseeName { get; set; }
        public decimal InfraestructureUse { get; set; }
        public string LicenseeOperatorEmail { get; set; }
        public byte TicketValidity { get; set; }
        public byte VoucherValidity { get; set; }
        public string DefaultCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public Nullable<decimal> BetTaxRate { get; set; }
        public string RaceWinTaxBase { get; set; }
        public string SportWinTaxBase { get; set; }
        public decimal WinTaxRate { get; set; }
        public bool IsActive { get; set; }
        public string LocationZipCode { get; set; }
        public string RepresenterName { get; set; }
        public string RepresenterRfc { get; set; }
        public string RepresenterCurp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BettorTickets> BettorTickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locations> Locations1 { get; set; }
        public virtual Locations Locations2 { get; set; }
        public virtual Totes Totes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
