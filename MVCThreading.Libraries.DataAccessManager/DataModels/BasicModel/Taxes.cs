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
    
    public partial class Taxes
    {
        public int TaxId { get; set; }
        public string TaxName { get; set; }
        public string TaxType { get; set; }
        public string AppliesTo { get; set; }
        public string BaseField { get; set; }
        public decimal TaxRate { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime InsertedOn { get; set; }
    }
}
