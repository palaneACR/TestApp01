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
    
    public partial class spNPIRelatedmeasureData_Result
    {
        public string Measure_num { get; set; }
        public Nullable<int> TotalExamsCount { get; set; }
        public Nullable<bool> SelectedForCMSSubmission { get; set; }
        public int TotalCasesReviewed { get; set; }
        public string Tin { get; set; }
        public Nullable<int> CMSYear { get; set; }
        public Nullable<bool> is90days { get; set; }
        public Nullable<System.DateTime> Last_Mod_Date { get; set; }
        public Nullable<bool> isSavedPreviously { get; set; }
        public Nullable<bool> HundredPercentSubmit { get; set; }
        public Nullable<bool> PhysGroupMeasure { get; set; }
        public Nullable<decimal> Performance_rate { get; set; }
        public string Decile_Val { get; set; }
        public Nullable<decimal> Reporting_Rate { get; set; }
    }
}
