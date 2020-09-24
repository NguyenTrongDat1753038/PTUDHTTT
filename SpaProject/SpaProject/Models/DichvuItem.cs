using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SpaProject.Models
{
    class DichvuItem
    {
        public int ID_DICHVU { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public Nullable<int> Thoigiancho { get; set; }
        public Nullable<int> ThoiLuong { get; set; }
        public bool TinhTrang { get; set; }
    }
}