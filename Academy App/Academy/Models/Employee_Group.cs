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
    
    public partial class Employee_Group
    {
        public int ID_em_group { get; set; }
        public int EmpoleeID { get; set; }
        public int GroupID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Group Group { get; set; }
    }
}
