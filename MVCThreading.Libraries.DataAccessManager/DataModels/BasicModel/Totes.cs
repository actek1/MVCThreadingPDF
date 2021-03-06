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
    
    public partial class Totes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Totes()
        {
            this.Locations = new HashSet<Locations>();
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int ToteId { get; set; }
        public string ToteName { get; set; }
        public bool DailyRecapReports { get; set; }
        public System.DateTime ReportingStartDate { get; set; }
        public bool PSADataExport { get; set; }
        public bool PreventMoneyLaundry { get; set; }
        public Nullable<bool> TicketRePrint { get; set; }
        public bool HasSports { get; set; }
        public bool HasRaces { get; set; }
        public bool HasSelfService { get; set; }
        public bool AdminLocations { get; set; }
        public bool LocalStored { get; set; }
        public string WinBase { get; set; }
        public int AuthorizationRoleId { get; set; }
        public int ETSNLength { get; set; }
        public bool IsETSNNumeric { get; set; }
        public bool IsTicketNumberSensible { get; set; }
        public Nullable<short> HourAdjustment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locations> Locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
