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
    
    public partial class convert_apps
    {
        public int app_id { get; set; }
        public string sw { get; set; }
        public string app_key { get; set; }
        public string name { get; set; }
        public bool login { get; set; }
        public int parent { get; set; }
        public string db_driver { get; set; }
        public string db_host { get; set; }
        public string db_user { get; set; }
        public string db_pass { get; set; }
        public string db_db { get; set; }
        public string db_prefix { get; set; }
        public string db_charset { get; set; }
        public Nullable<bool> app_merge { get; set; }
        public int start_date { get; set; }
        public int db_port { get; set; }
    }
}
