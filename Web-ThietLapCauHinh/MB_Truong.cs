//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_ThietLapCauHinh
{
    using System;
    using System.Collections.Generic;
    
    public partial class MB_Truong
    {
        public int Id { get; set; }
        public string MaTruong { get; set; }
        public string TenTruong { get; set; }
        public string TruocThuocBo { get; set; }
        public string DuongDanLogo { get; set; }
        public bool IsHienThi { get; set; }
        public bool IsSuDungRieng { get; set; }
        public string ThongTinRieng { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Loai { get; set; }
        public Nullable<int> NguoiTao { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<int> NguoiCapNhat { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
    }
}
