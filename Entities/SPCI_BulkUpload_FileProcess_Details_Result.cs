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
    
    public partial class SPCI_BulkUpload_FileProcess_Details_Result
    {
        public string CmsStatusDetails { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CategoryName { get; set; }
        public string FileName { get; set; }
        public Nullable<int> InvalidExcelRecords { get; set; }
        public Nullable<int> TotalEditedExcelRecordsCount { get; set; }
        public Nullable<int> ValidExcelRecords { get; set; }
        public Nullable<int> TotalExcelRecords { get; set; }
        public int FileId { get; set; }
        public Nullable<int> CmsYear { get; set; }
        public string Category_Name { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
        public string Message { get; set; }
    }
}