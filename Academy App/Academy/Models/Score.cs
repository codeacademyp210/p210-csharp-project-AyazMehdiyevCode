//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public int ID_score { get; set; }
        public int TaskID { get; set; }
        public int StudentID { get; set; }
        public Nullable<decimal> Score1 { get; set; }
        public bool Status_score { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual Student Student { get; set; }
    }
}
