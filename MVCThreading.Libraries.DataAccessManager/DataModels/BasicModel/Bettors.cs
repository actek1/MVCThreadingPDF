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
    
    public partial class Bettors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bettors()
        {
            this.BettorROVReportBreaks = new HashSet<BettorROVReportBreaks>();
            this.BettorTickets = new HashSet<BettorTickets>();
        }
    
        public int BettorId { get; set; }
        public string BettorName { get; set; }
        public string BettorLastName { get; set; }
        public string BettorMotherMaidenName { get; set; }
        public System.DateTime BettorBirthDate { get; set; }
        public string BettorNativeCountry { get; set; }
        public string BettorNativeCountryDesc { get; set; }
        public string BettorNationality { get; set; }
        public string BettorNationalityDesc { get; set; }
        public string BettorGender { get; set; }
        public string BettorRFC { get; set; }
        public string BettorCURP { get; set; }
        public string BettorEmail { get; set; }
        public string BettorPhoneCode { get; set; }
        public string BettorPhoneNumber { get; set; }
        public string BettorActivity { get; set; }
        public string BettorActivityDesc { get; set; }
        public bool IsVIP { get; set; }
        public bool IsPersonaFisica { get; set; }
        public bool IsForeigner { get; set; }
        public bool IsActive { get; set; }
        public string IdNumber { get; set; }
        public int IdType { get; set; }
        public string IdTypeDesc { get; set; }
        public string IdIssuingAuthority { get; set; }
        public string IdAddress { get; set; }
        public string IdAddressNumber { get; set; }
        public string IdAddressInternalNumber { get; set; }
        public string IdColonia { get; set; }
        public string IdAddressCity { get; set; }
        public string IdAddressState { get; set; }
        public string IdAddressZipCode { get; set; }
        public string IdAddressResidenceCountry { get; set; }
        public string IdAddressResidenceCountryDesc { get; set; }
        public string IdOther { get; set; }
        public System.DateTime IdValidUntil { get; set; }
        public System.DateTime RegisteredOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> BettorIdBeneficiario { get; set; }
        public string AlertaClave { get; set; }
        public string AlertaDescripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BettorROVReportBreaks> BettorROVReportBreaks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BettorTickets> BettorTickets { get; set; }
    }
}
