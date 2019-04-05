//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDT
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserAccount()
        {
            this.DanhMucs = new HashSet<DanhMuc>();
            this.KhoHangs = new HashSet<KhoHang>();
            this.ChiTietHangHoas = new HashSet<ChiTietHangHoa>();
            this.PhanQuyenNguoiDungs = new HashSet<PhanQuyenNguoiDung>();
            this.CongNoes = new HashSet<CongNo>();
            this.DonHangs = new HashSet<DonHang>();
            this.ThuChis = new HashSet<ThuChi>();
            this.KhachHangs = new HashSet<KhachHang>();
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            this.ThanhToanCongNoes = new HashSet<ThanhToanCongNo>();
        }
    
        public long Id { get; set; }
        public Nullable<long> CreatedDate { get; set; }
        public Nullable<long> ModifiedDate { get; set; }
        public bool IsActived { get; set; }
        public string TenNguoiDung { get; set; }
        public string MatKhau { get; set; }
        public string LoaiNguoiDung { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public string Dienthoai { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhMuc> DanhMucs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoHang> KhoHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHangHoa> ChiTietHangHoas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanQuyenNguoiDung> PhanQuyenNguoiDungs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongNo> CongNoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuChi> ThuChis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToanCongNo> ThanhToanCongNoes { get; set; }
    }
}
