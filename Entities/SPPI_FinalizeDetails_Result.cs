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
    
    public partial class SPPI_FinalizeDetails_Result
    {
        public string Tin { get; set; }
        public Nullable<bool> isGpro { get; set; }
        public string emailid { get; set; }
        public Nullable<bool> isFinalize { get; set; }
        public string finalizeAgreeDate { get; set; }
        public string finalizeDisAgreeDate { get; set; }
        public Nullable<bool> isSubmitToCI { get; set; }
        public string LastSubmittedDateTime { get; set; }
        public string LastSubmittedBy { get; set; }
        public Nullable<int> CMSYear { get; set; }
        public Nullable<bool> SubmittoCMS { get; set; }
        public string CehrtId { get; set; }
        public string OptInDate { get; set; }
        public Nullable<bool> isOptedIn { get; set; }
    }
}
