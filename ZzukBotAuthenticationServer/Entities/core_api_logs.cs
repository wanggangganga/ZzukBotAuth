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
    
    public partial class core_api_logs
    {
        public decimal id { get; set; }
        public string endpoint { get; set; }
        public string method { get; set; }
        public string api_key { get; set; }
        public string ip_address { get; set; }
        public string request_data { get; set; }
        public string response_code { get; set; }
        public string response_output { get; set; }
        public int date { get; set; }
        public bool is_bad_key { get; set; }
    }
}
