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
    
    public partial class SPGetActivitieslistIA_Facility_Result
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string NPI { get; set; }
        public string Tin { get; set; }
        public string SelectedActivites { get; set; }
        public Nullable<bool> isGpro { get; set; }
        public string emailid { get; set; }
        public Nullable<bool> isFinalize { get; set; }
        public Nullable<System.DateTime> finalizeAgreeDate { get; set; }
        public Nullable<System.DateTime> finalizeDisAgreeDate { get; set; }
        public int isSubmitToCI { get; set; }
        public string LastSubmittedDateTime { get; set; }
        public Nullable<int> CMSYear { get; set; }
    }
}
