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
    
    public partial class zzukbot_v1_users
    {
        public int user_id { get; set; }
        public sbyte user_type { get; set; }
        public int group_id { get; set; }
        public string user_permissions { get; set; }
        public int user_perm_from { get; set; }
        public string user_ip { get; set; }
        public long user_regdate { get; set; }
        public string username { get; set; }
        public string username_clean { get; set; }
        public string user_password { get; set; }
        public long user_passchg { get; set; }
        public string user_email { get; set; }
        public long user_email_hash { get; set; }
        public string user_birthday { get; set; }
        public long user_lastvisit { get; set; }
        public long user_lastmark { get; set; }
        public long user_lastpost_time { get; set; }
        public string user_lastpage { get; set; }
        public string user_last_confirm_key { get; set; }
        public long user_last_search { get; set; }
        public sbyte user_warnings { get; set; }
        public long user_last_warning { get; set; }
        public sbyte user_login_attempts { get; set; }
        public sbyte user_inactive_reason { get; set; }
        public long user_inactive_time { get; set; }
        public int user_posts { get; set; }
        public string user_lang { get; set; }
        public string user_timezone { get; set; }
        public string user_dateformat { get; set; }
        public int user_style { get; set; }
        public int user_rank { get; set; }
        public string user_colour { get; set; }
        public int user_new_privmsg { get; set; }
        public int user_unread_privmsg { get; set; }
        public long user_last_privmsg { get; set; }
        public bool user_message_rules { get; set; }
        public int user_full_folder { get; set; }
        public long user_emailtime { get; set; }
        public int user_topic_show_days { get; set; }
        public string user_topic_sortby_type { get; set; }
        public string user_topic_sortby_dir { get; set; }
        public int user_post_show_days { get; set; }
        public string user_post_sortby_type { get; set; }
        public string user_post_sortby_dir { get; set; }
        public bool user_notify { get; set; }
        public bool user_notify_pm { get; set; }
        public sbyte user_notify_type { get; set; }
        public bool user_allow_pm { get; set; }
        public bool user_allow_viewonline { get; set; }
        public bool user_allow_viewemail { get; set; }
        public bool user_allow_massemail { get; set; }
        public long user_options { get; set; }
        public string user_avatar { get; set; }
        public string user_avatar_type { get; set; }
        public int user_avatar_width { get; set; }
        public int user_avatar_height { get; set; }
        public string user_sig { get; set; }
        public string user_sig_bbcode_uid { get; set; }
        public string user_sig_bbcode_bitfield { get; set; }
        public string user_jabber { get; set; }
        public string user_actkey { get; set; }
        public string user_newpasswd { get; set; }
        public string user_form_salt { get; set; }
        public bool user_new { get; set; }
        public sbyte user_reminded { get; set; }
        public long user_reminded_time { get; set; }
        public Nullable<System.DateTime> key_expiration { get; set; }
        public Nullable<System.DateTime> key_expiration2 { get; set; }
        public Nullable<System.DateTime> key_expiration3 { get; set; }
        public Nullable<System.DateTime> key_expiration4 { get; set; }
        public Nullable<System.DateTime> key_expiration5 { get; set; }
        public Nullable<System.DateTime> key_expiration6 { get; set; }
        public bool is_migrated { get; set; }
    }
}
