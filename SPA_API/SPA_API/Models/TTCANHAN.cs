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
    
    public partial class TTCANHAN
    {
        public int ID_USER { get; set; }
        public string HOTEN { get; set; }
        public string NGHENGHIEP { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public string THOIQUEN { get; set; }
        public Nullable<double> CHIEUCAO { get; set; }
        public Nullable<double> TRONGLUONG { get; set; }
        public Nullable<double> MO { get; set; }
        public Nullable<double> MOBUNG { get; set; }
        public Nullable<int> BMI { get; set; }
    
        public virtual USER USER { get; set; }
    }
}