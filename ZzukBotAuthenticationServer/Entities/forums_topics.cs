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
    
    public partial class forums_topics
    {
        public int tid { get; set; }
        public string title { get; set; }
        public string state { get; set; }
        public Nullable<int> posts { get; set; }
        public decimal starter_id { get; set; }
        public Nullable<int> start_date { get; set; }
        public decimal last_poster_id { get; set; }
        public int last_post { get; set; }
        public string starter_name { get; set; }
        public string last_poster_name { get; set; }
        public string poll_state { get; set; }
        public Nullable<int> last_vote { get; set; }
        public Nullable<int> views { get; set; }
        public short forum_id { get; set; }
        public bool approved { get; set; }
        public Nullable<bool> author_mode { get; set; }
        public Nullable<bool> pinned { get; set; }
        public string moved_to { get; set; }
        public int topic_firstpost { get; set; }
        public int topic_queuedposts { get; set; }
        public int topic_open_time { get; set; }
        public int topic_close_time { get; set; }
        public int topic_rating_total { get; set; }
        public int topic_rating_hits { get; set; }
        public string title_seo { get; set; }
        public int moved_on { get; set; }
        public int topic_archive_status { get; set; }
        public int last_real_post { get; set; }
        public int topic_answered_pid { get; set; }
        public Nullable<int> popular_time { get; set; }
        public Nullable<bool> featured { get; set; }
        public Nullable<int> question_rating { get; set; }
        public Nullable<long> topic_hiddenposts { get; set; }
    }
}
