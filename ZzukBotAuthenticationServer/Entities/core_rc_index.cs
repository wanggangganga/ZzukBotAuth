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
    
    public partial class core_rc_index
    {
        public decimal id { get; set; }
        public string @class { get; set; }
        public decimal content_id { get; set; }
        public Nullable<decimal> perm_id { get; set; }
        public string status { get; set; }
        public long num_reports { get; set; }
        public long num_comments { get; set; }
        public decimal first_report_by { get; set; }
        public int first_report_date { get; set; }
        public Nullable<int> last_updated { get; set; }
        public decimal author { get; set; }
    }
}
