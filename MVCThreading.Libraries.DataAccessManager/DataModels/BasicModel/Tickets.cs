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
    
    public partial class Tickets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tickets()
        {
            this.BettorTickets = new HashSet<BettorTickets>();
            this.TicketProperties = new HashSet<TicketProperties>();
            this.TicketWager = new HashSet<TicketWager>();
        }
    
        public long TicketNumber { get; set; }
        public int ToteId { get; set; }
        public int LocationId { get; set; }
        public string ETSN { get; set; }
        public string TicketType { get; set; }
        public byte TicketStatus { get; set; }
        public System.DateTime SoldDate { get; set; }
        public decimal SoldValue { get; set; }
        public decimal WinValue { get; set; }
        public Nullable<decimal> CommissionValue { get; set; }
        public Nullable<decimal> BetTaxValue { get; set; }
        public Nullable<System.DateTime> SettledDate { get; set; }
        public Nullable<decimal> SettledValue { get; set; }
        public Nullable<decimal> RefundValue { get; set; }
        public Nullable<System.DateTime> CashedDate { get; set; }
        public Nullable<decimal> CashedValue { get; set; }
        public Nullable<decimal> WinTaxValue { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public System.DateTime LastEvent { get; set; }
        public Nullable<int> SoldTillSessionId { get; set; }
        public string SoldCashier { get; set; }
        public string SoldTerminal { get; set; }
        public Nullable<int> CashedTillSessionId { get; set; }
        public string CashedCashier { get; set; }
        public string CashedTerminal { get; set; }
        public Nullable<int> OriginalVoucherId { get; set; }
        public byte NumberOfDetails { get; set; }
        public string WagerType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BettorTickets> BettorTickets { get; set; }
        public virtual Locations Locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketProperties> TicketProperties { get; set; }
        public virtual Totes Totes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketWager> TicketWager { get; set; }
    }
}
