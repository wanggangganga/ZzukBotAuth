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
    
    public partial class nexus_coupons
    {
        public int c_id { get; set; }
        public string c_code { get; set; }
        public string c_discount { get; set; }
        public string c_unit { get; set; }
        public string c_products { get; set; }
        public bool c_limit_discount { get; set; }
        public string c_groups { get; set; }
        public int c_uses { get; set; }
        public int c_member_uses { get; set; }
        public int c_start { get; set; }
        public int c_end { get; set; }
        public string c_used_by { get; set; }
        public bool c_combine { get; set; }
        public bool c_renewals { get; set; }
    }
}
