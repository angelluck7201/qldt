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
    
    public partial class ErrorLog : BaseModel
    {
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
    
        private string _createdDate;
    	public string CreatedDate 
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
    
        private string _appVersion;
    	public string AppVersion 
    	{ 
    		get { return _appVersion; } 
    		set
    		{
    			if (value != _appVersion) {
    				_appVersion = value;
    				 OnPropertyChanged("AppVersion");
    			}
    		} 
    	}
    
        private string _messagelog;
    	public string Messagelog 
    	{ 
    		get { return _messagelog; } 
    		set
    		{
    			if (value != _messagelog) {
    				_messagelog = value;
    				 OnPropertyChanged("Messagelog");
    			}
    		} 
    	}
    
    }
}
