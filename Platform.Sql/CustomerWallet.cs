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
    
    public partial class CustomerWallet
    {
        public int WalletId { get; set; }
        public int CustomerId { get; set; }
        public decimal WalletBalance { get; set; }
        public System.DateTime AmountDueDate { get; set; }
    }
}