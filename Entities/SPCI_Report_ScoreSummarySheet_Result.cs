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
    
    public partial class SPCI_Report_ScoreSummarySheet_Result
    {
        public string TIN { get; set; }
        public Nullable<int> CMS_Reporting_Year { get; set; }
        public string CMS_Submission_Status { get; set; }
        public Nullable<decimal> QM_Contribution_to_Final_Score { get; set; }
        public Nullable<decimal> QM_Unweighted_Score { get; set; }
        public Nullable<decimal> IA_Contribution_to_Final_Score { get; set; }
        public Nullable<decimal> IA_Unweighted_Score { get; set; }
        public Nullable<decimal> PI_Contribution_to_Final_Score { get; set; }
        public Nullable<decimal> PI_Unweighted_Score { get; set; }
        public Nullable<decimal> Total_Score { get; set; }
    }
}
