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
    
    public partial class BettorTickets
    {
        public Nullable<long> TicketNumber { get; set; }
        public int ToteId { get; set; }
        public string BettorType { get; set; }
        public Nullable<int> LocationId { get; set; }
        public int BettorId { get; set; }
        public string ETSN { get; set; }
        public Nullable<decimal> RealAmount { get; set; }
        public Nullable<decimal> ReportedAmount { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<System.DateTime> OpDate { get; set; }
        public int InstrumentoMonetario { get; set; }
        public string InstrumentoMonetarioDesc { get; set; }
        public string ChequeInstitucion { get; set; }
        public string ChequeNoCuenta { get; set; }
        public string ChequeNo { get; set; }
        public string SpeiClaveRastreo { get; set; }
        public string TeftFolio { get; set; }
        public System.DateTime RegisteredOn { get; set; }
        public Nullable<int> RegisteredBy { get; set; }
    
        public virtual Bettors Bettors { get; set; }
        public virtual Locations Locations { get; set; }
        public virtual Tickets Tickets { get; set; }
    }
}
