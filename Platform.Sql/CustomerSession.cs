//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Platform.Sql
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerSession
    {
        public int SessionId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public System.DateTime SessionStartDtm { get; set; }
        public System.DateTime SessionEndDtm { get; set; }
        public Nullable<bool> IsLogout { get; set; }
    }
}
