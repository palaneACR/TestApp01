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
    
    public partial class spFileProcessHistoryDetails_Result
    {
        public int ReqId { get; set; }
        public Nullable<int> RequestsCount { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Uname { get; set; }
        public Nullable<int> Successfull_files { get; set; }
        public Nullable<int> Pending_files { get; set; }
        public Nullable<int> Rejected_files { get; set; }
        public Nullable<int> Processing_files { get; set; }
        public Nullable<int> TotalFiles { get; set; }
        public string ProcessType { get; set; }
        public string Status { get; set; }
    }
}