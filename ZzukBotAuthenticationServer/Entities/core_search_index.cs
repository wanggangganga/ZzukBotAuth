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
    
    public partial class core_search_index
    {
        public decimal index_id { get; set; }
        public string index_class { get; set; }
        public long index_object_id { get; set; }
        public long index_item_id { get; set; }
        public long index_container_id { get; set; }
        public string index_content { get; set; }
        public string index_permissions { get; set; }
        public long index_date_created { get; set; }
        public long index_author { get; set; }
        public string index_title { get; set; }
        public Nullable<long> index_date_updated { get; set; }
        public bool index_hidden { get; set; }
        public Nullable<decimal> index_item_index_id { get; set; }
        public Nullable<decimal> index_item_author { get; set; }
        public bool index_is_last_comment { get; set; }
        public string index_class_type_id_hash { get; set; }
    }
}
