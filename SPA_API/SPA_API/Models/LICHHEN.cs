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
    
    public partial class LICHHEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LICHHEN()
        {
            this.CHITIET_LICHHEN = new HashSet<CHITIET_LICHHEN>();
        }
    
        public int ID_LH { get; set; }
        public int ID_KH { get; set; }
        public int ID_CHINHANH { get; set; }
        public Nullable<System.TimeSpan> GIOHEN { get; set; }
        public Nullable<System.DateTime> NGAYHEN { get; set; }
        public Nullable<int> TINHTRANG { get; set; }
        public string BINHLUAN { get; set; }
        public Nullable<int> DANHGIA { get; set; }
    
        public virtual CHINHANH CHINHANH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_LICHHEN> CHITIET_LICHHEN { get; set; }
        public virtual USER USER { get; set; }
    }
}