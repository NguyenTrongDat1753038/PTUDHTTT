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
    
    public partial class GIUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIUONG()
        {
            this.CHITIET_GIUONG = new HashSet<CHITIET_GIUONG>();
            this.CHITIET_LICHHEN = new HashSet<CHITIET_LICHHEN>();
        }
    
        public int ID_GIUONG { get; set; }
        public Nullable<int> ID_PHONG { get; set; }
        public string MOTA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_GIUONG> CHITIET_GIUONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_LICHHEN> CHITIET_LICHHEN { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}