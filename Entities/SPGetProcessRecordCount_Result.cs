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
    
    public partial class SPGetProcessRecordCount_Result
    {
        public int Id { get; set; }
        public Nullable<int> ReqId { get; set; }
        public int FileId { get; set; }
        public Nullable<int> ProcessedRecords { get; set; }
        public Nullable<System.DateTime> CountUpdateOn { get; set; }
        public Nullable<int> Status_CnstID { get; set; }
        public Nullable<bool> isValidationState { get; set; }
        public Nullable<System.DateTime> Validation_StartDate { get; set; }
        public Nullable<System.DateTime> Validation_UpdateDate { get; set; }
    }
}