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
    
    public partial class DC_DOCUMENT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DC_DOCUMENT_TYPE()
        {
            this.DC_GRANT_DOC_LINK = new HashSet<DC_GRANT_DOC_LINK>();
        }
    
        public decimal TYPE_ID { get; set; }
        public string TYPE_NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DC_GRANT_DOC_LINK> DC_GRANT_DOC_LINK { get; set; }
    }
}
