//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoteMarketPlace
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country_Details
    {
        public Country_Details()
        {
            this.Note_Details = new HashSet<Note_Details>();
        }
    
        public int Country_Id { get; set; }
        public string Country_Name { get; set; }
        public decimal Country_Code { get; set; }
        public int Added_By { get; set; }
        public System.DateTime Added_Date { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public bool IsActive { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<Note_Details> Note_Details { get; set; }
    }
}