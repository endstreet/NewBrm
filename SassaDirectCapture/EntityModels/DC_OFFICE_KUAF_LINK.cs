//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SASSADirectCapture.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_OFFICE_KUAF_LINK
    {
        public string OFFICE_ID { get; set; }
        public decimal KUAF_ID { get; set; }
        public string SUPERVISOR { get; set; }
        public string USERNAME { get; set; }
        public decimal PK { get; set; }
    
        public virtual DC_LOCAL_OFFICE DC_LOCAL_OFFICE { get; set; }
    }
}
