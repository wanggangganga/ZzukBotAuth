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
    
    public partial class core_incoming_emails
    {
        public int rule_id { get; set; }
        public string rule_criteria_field { get; set; }
        public string rule_criteria_type { get; set; }
        public string rule_criteria_value { get; set; }
        public string rule_app { get; set; }
        public decimal rule_added_by { get; set; }
        public int rule_added_date { get; set; }
    }
}
