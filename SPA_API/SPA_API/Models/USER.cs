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
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.CHINHANHs = new HashSet<CHINHANH>();
            this.CHITIET_LICHHEN = new HashSet<CHITIET_LICHHEN>();
            this.DATTRUOCs = new HashSet<DATTRUOC>();
            this.GIOHANGs = new HashSet<GIOHANG>();
            this.LICHHENs = new HashSet<LICHHEN>();
        }
    
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORDS { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
        public Nullable<int> VaiTro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHINHANH> CHINHANHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_LICHHEN> CHITIET_LICHHEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATTRUOC> DATTRUOCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHHEN> LICHHENs { get; set; }
        public virtual TTCANHAN TTCANHAN { get; set; }
    }
}