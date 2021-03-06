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
    
    public partial class DanhMuc : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMuc()
        {
            this.KhoHangs = new HashSet<KhoHang>();
            this.ThuChis = new HashSet<ThuChi>();
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
    
        private string _loai;
    	public string Loai 
    	{ 
    		get { return _loai; } 
    		set
    		{
    			if (value != _loai) {
    				_loai = value;
    				 OnPropertyChanged("Loai");
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
    
    
        public virtual UserAccount UserAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoHang> KhoHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuChi> ThuChis { get; set; }
    }
}
