//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Entities
{
    using System;
    
    public partial class SPCI_BulkUpload_HistoryDetails_Result
    {
        public string CreatedBy { get; set; }
        public string FileName { get; set; }
        public string STATUS { get; set; }
        public string CategoryId { get; set; }
        public Nullable<short> NoofFailureSubmissions { get; set; }
        public Nullable<short> NoofSuccessSubmissions { get; set; }
        public Nullable<short> NoofSubmissions { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
    }
}