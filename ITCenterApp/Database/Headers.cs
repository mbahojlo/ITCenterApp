//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITCenterApp.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Headers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Headers()
        {
            this.Rows = new HashSet<Rows>();
        }
    
        public int Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public int CustomerNumber { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rows> Rows { get; set; }
    }
}