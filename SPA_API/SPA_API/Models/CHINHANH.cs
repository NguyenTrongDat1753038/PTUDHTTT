//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPA_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHINHANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHINHANH()
        {
            this.LICHHENs = new HashSet<LICHHEN>();
            this.PHONGs = new HashSet<PHONG>();
        }
    
        public int ID_CHINHANH { get; set; }
        public Nullable<int> ID_USER { get; set; }
        public string TEN { get; set; }
        public string DIACHI { get; set; }
        public Nullable<bool> TINHTRANG { get; set; }
    
        public virtual USER USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHHEN> LICHHENs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
