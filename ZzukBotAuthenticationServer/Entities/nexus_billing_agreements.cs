//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZzukBotAuthenticationServer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class nexus_billing_agreements
    {
        public decimal ba_id { get; set; }
        public string ba_gw_id { get; set; }
        public long ba_method { get; set; }
        public Nullable<decimal> ba_member { get; set; }
        public int ba_started { get; set; }
        public Nullable<int> ba_next_cycle { get; set; }
        public bool ba_canceled { get; set; }
    }
}
