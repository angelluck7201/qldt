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
    
    public partial class KhachHang : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.CongNoes = new HashSet<CongNo>();
            this.DonHangs = new HashSet<DonHang>();
            this.ThanhToanCongNoes = new HashSet<ThanhToanCongNo>();
        }
    
        private long _id;
    	public long Id 
    	{ 
    		get { return _id; } 
    		set
    		{
    			if (value != _id) {
    				_id = value;
    				 OnPropertyChanged("Id");
    			}
    		} 
    	}
    
        private long _authorId;
    	public long AuthorId 
    	{ 
    		get { return _authorId; } 
    		set
    		{
    			if (value != _authorId) {
    				_authorId = value;
    				 OnPropertyChanged("AuthorId");
    			}
    		} 
    	}
    
        private Nullable<long> _createdDate;
    	public Nullable<long> CreatedDate 
    	{ 
    		get { return _createdDate; } 
    		set
    		{
    			if (value != _createdDate) {
    				_createdDate = value;
    				 OnPropertyChanged("CreatedDate");
    			}
    		} 
    	}
    
        private Nullable<long> _modifiedDate;
    	public Nullable<long> ModifiedDate 
    	{ 
    		get { return _modifiedDate; } 
    		set
    		{
    			if (value != _modifiedDate) {
    				_modifiedDate = value;
    				 OnPropertyChanged("ModifiedDate");
    			}
    		} 
    	}
    
        private bool _isActived;
    	public bool IsActived 
    	{ 
    		get { return _isActived; } 
    		set
    		{
    			if (value != _isActived) {
    				_isActived = value;
    				 OnPropertyChanged("IsActived");
    			}
    		} 
    	}
    
        private string _maKH;
    	public string MaKH 
    	{ 
    		get { return _maKH; } 
    		set
    		{
    			if (value != _maKH) {
    				_maKH = value;
    				 OnPropertyChanged("MaKH");
    			}
    		} 
    	}
    
        private string _ten;
    	public string Ten 
    	{ 
    		get { return _ten; } 
    		set
    		{
    			if (value != _ten) {
    				_ten = value;
    				 OnPropertyChanged("Ten");
    			}
    		} 
    	}
    
        private string _loaiKhachHang;
    	public string LoaiKhachHang 
    	{ 
    		get { return _loaiKhachHang; } 
    		set
    		{
    			if (value != _loaiKhachHang) {
    				_loaiKhachHang = value;
    				 OnPropertyChanged("LoaiKhachHang");
    			}
    		} 
    	}
    
        private string _diaChi;
    	public string DiaChi 
    	{ 
    		get { return _diaChi; } 
    		set
    		{
    			if (value != _diaChi) {
    				_diaChi = value;
    				 OnPropertyChanged("DiaChi");
    			}
    		} 
    	}
    
        private string _cMND;
    	public string CMND 
    	{ 
    		get { return _cMND; } 
    		set
    		{
    			if (value != _cMND) {
    				_cMND = value;
    				 OnPropertyChanged("CMND");
    			}
    		} 
    	}
    
        private string _dienthoai;
    	public string Dienthoai 
    	{ 
    		get { return _dienthoai; } 
    		set
    		{
    			if (value != _dienthoai) {
    				_dienthoai = value;
    				 OnPropertyChanged("Dienthoai");
    			}
    		} 
    	}
    
        private string _fax;
    	public string Fax 
    	{ 
    		get { return _fax; } 
    		set
    		{
    			if (value != _fax) {
    				_fax = value;
    				 OnPropertyChanged("Fax");
    			}
    		} 
    	}
    
        private string _email;
    	public string Email 
    	{ 
    		get { return _email; } 
    		set
    		{
    			if (value != _email) {
    				_email = value;
    				 OnPropertyChanged("Email");
    			}
    		} 
    	}
    
        private string _maSoThue;
    	public string MaSoThue 
    	{ 
    		get { return _maSoThue; } 
    		set
    		{
    			if (value != _maSoThue) {
    				_maSoThue = value;
    				 OnPropertyChanged("MaSoThue");
    			}
    		} 
    	}
    
        private string _sTK;
    	public string STK 
    	{ 
    		get { return _sTK; } 
    		set
    		{
    			if (value != _sTK) {
    				_sTK = value;
    				 OnPropertyChanged("STK");
    			}
    		} 
    	}
    
        private string _nganHang;
    	public string NganHang 
    	{ 
    		get { return _nganHang; } 
    		set
    		{
    			if (value != _nganHang) {
    				_nganHang = value;
    				 OnPropertyChanged("NganHang");
    			}
    		} 
    	}
    
        private string _ghiChu;
    	public string GhiChu 
    	{ 
    		get { return _ghiChu; } 
    		set
    		{
    			if (value != _ghiChu) {
    				_ghiChu = value;
    				 OnPropertyChanged("GhiChu");
    			}
    		} 
    	}
    
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongNo> CongNoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual UserAccount UserAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToanCongNo> ThanhToanCongNoes { get; set; }
    }
}
