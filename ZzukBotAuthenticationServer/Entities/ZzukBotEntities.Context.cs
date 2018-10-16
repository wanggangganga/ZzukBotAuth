﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class zzuk_ipbEntities : DbContext
    {
        public zzuk_ipbEntities()
            : base("name=zzuk_ipbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<convert_app_sessions> convert_app_sessions { get; set; }
        public virtual DbSet<convert_apps> convert_apps { get; set; }
        public virtual DbSet<convert_bbcode_mediatag> convert_bbcode_mediatag { get; set; }
        public virtual DbSet<convert_custom_bbcode> convert_custom_bbcode { get; set; }
        public virtual DbSet<convert_link> convert_link { get; set; }
        public virtual DbSet<convert_link_pms> convert_link_pms { get; set; }
        public virtual DbSet<convert_link_posts> convert_link_posts { get; set; }
        public virtual DbSet<convert_link_topics> convert_link_topics { get; set; }
        public virtual DbSet<convert_logs> convert_logs { get; set; }
        public virtual DbSet<core_acronyms> core_acronyms { get; set; }
        public virtual DbSet<core_admin_login_logs> core_admin_login_logs { get; set; }
        public virtual DbSet<core_admin_logs> core_admin_logs { get; set; }
        public virtual DbSet<core_admin_permission_rows> core_admin_permission_rows { get; set; }
        public virtual DbSet<core_advertisements> core_advertisements { get; set; }
        public virtual DbSet<core_announcements> core_announcements { get; set; }
        public virtual DbSet<core_api_keys> core_api_keys { get; set; }
        public virtual DbSet<core_api_logs> core_api_logs { get; set; }
        public virtual DbSet<core_applications> core_applications { get; set; }
        public virtual DbSet<core_attachments> core_attachments { get; set; }
        public virtual DbSet<core_banfilters> core_banfilters { get; set; }
        public virtual DbSet<core_bulk_mail> core_bulk_mail { get; set; }
        public virtual DbSet<core_dev> core_dev { get; set; }
        public virtual DbSet<core_dnames_change> core_dnames_change { get; set; }
        public virtual DbSet<core_edit_history> core_edit_history { get; set; }
        public virtual DbSet<core_email_templates> core_email_templates { get; set; }
        public virtual DbSet<core_emoticons> core_emoticons { get; set; }
        public virtual DbSet<core_error_logs> core_error_logs { get; set; }
        public virtual DbSet<core_file_logs> core_file_logs { get; set; }
        public virtual DbSet<core_file_storage> core_file_storage { get; set; }
        public virtual DbSet<core_files> core_files { get; set; }
        public virtual DbSet<core_files_temp> core_files_temp { get; set; }
        public virtual DbSet<core_follow> core_follow { get; set; }
        public virtual DbSet<core_geoip_cache> core_geoip_cache { get; set; }
        public virtual DbSet<core_groups> core_groups { get; set; }
        public virtual DbSet<core_hooks> core_hooks { get; set; }
        public virtual DbSet<core_ignored_users> core_ignored_users { get; set; }
        public virtual DbSet<core_image_proxy> core_image_proxy { get; set; }
        public virtual DbSet<core_incoming_emails> core_incoming_emails { get; set; }
        public virtual DbSet<core_ipsconnect_queue> core_ipsconnect_queue { get; set; }
        public virtual DbSet<core_ipsconnect_slaves> core_ipsconnect_slaves { get; set; }
        public virtual DbSet<core_javascript> core_javascript { get; set; }
        public virtual DbSet<core_leaders> core_leaders { get; set; }
        public virtual DbSet<core_leaders_groups> core_leaders_groups { get; set; }
        public virtual DbSet<core_log> core_log { get; set; }
        public virtual DbSet<core_login_handlers> core_login_handlers { get; set; }
        public virtual DbSet<core_mail_error_logs> core_mail_error_logs { get; set; }
        public virtual DbSet<core_member_ranks> core_member_ranks { get; set; }
        public virtual DbSet<core_member_status_replies> core_member_status_replies { get; set; }
        public virtual DbSet<core_member_status_updates> core_member_status_updates { get; set; }
        public virtual DbSet<core_members> core_members { get; set; }
        public virtual DbSet<core_members_warn_actions> core_members_warn_actions { get; set; }
        public virtual DbSet<core_members_warn_logs> core_members_warn_logs { get; set; }
        public virtual DbSet<core_members_warn_reasons> core_members_warn_reasons { get; set; }
        public virtual DbSet<core_menu> core_menu { get; set; }
        public virtual DbSet<core_message_posts> core_message_posts { get; set; }
        public virtual DbSet<core_message_topic_user_map> core_message_topic_user_map { get; set; }
        public virtual DbSet<core_message_topics> core_message_topics { get; set; }
        public virtual DbSet<core_moderator_logs> core_moderator_logs { get; set; }
        public virtual DbSet<core_moderators> core_moderators { get; set; }
        public virtual DbSet<core_modules> core_modules { get; set; }
        public virtual DbSet<core_notification_defaults> core_notification_defaults { get; set; }
        public virtual DbSet<core_notification_preferences> core_notification_preferences { get; set; }
        public virtual DbSet<core_notifications> core_notifications { get; set; }
        public virtual DbSet<core_permission_index> core_permission_index { get; set; }
        public virtual DbSet<core_pfields_content> core_pfields_content { get; set; }
        public virtual DbSet<core_pfields_data> core_pfields_data { get; set; }
        public virtual DbSet<core_pfields_groups> core_pfields_groups { get; set; }
        public virtual DbSet<core_plugins> core_plugins { get; set; }
        public virtual DbSet<core_polls> core_polls { get; set; }
        public virtual DbSet<core_profanity_filters> core_profanity_filters { get; set; }
        public virtual DbSet<core_question_and_answer> core_question_and_answer { get; set; }
        public virtual DbSet<core_queue> core_queue { get; set; }
        public virtual DbSet<core_ratings> core_ratings { get; set; }
        public virtual DbSet<core_rc_comments> core_rc_comments { get; set; }
        public virtual DbSet<core_rc_index> core_rc_index { get; set; }
        public virtual DbSet<core_rc_reports> core_rc_reports { get; set; }
        public virtual DbSet<core_reputation_index> core_reputation_index { get; set; }
        public virtual DbSet<core_reputation_levels> core_reputation_levels { get; set; }
        public virtual DbSet<core_rss_export> core_rss_export { get; set; }
        public virtual DbSet<core_search_index> core_search_index { get; set; }
        public virtual DbSet<core_security_questions> core_security_questions { get; set; }
        public virtual DbSet<core_seo_meta> core_seo_meta { get; set; }
        public virtual DbSet<core_sessions> core_sessions { get; set; }
        public virtual DbSet<core_share_links> core_share_links { get; set; }
        public virtual DbSet<core_sitemap> core_sitemap { get; set; }
        public virtual DbSet<core_soft_delete_log> core_soft_delete_log { get; set; }
        public virtual DbSet<core_spam_service_log> core_spam_service_log { get; set; }
        public virtual DbSet<core_store> core_store { get; set; }
        public virtual DbSet<core_streams> core_streams { get; set; }
        public virtual DbSet<core_sys_conf_settings> core_sys_conf_settings { get; set; }
        public virtual DbSet<core_sys_cp_sessions> core_sys_cp_sessions { get; set; }
        public virtual DbSet<core_sys_lang> core_sys_lang { get; set; }
        public virtual DbSet<core_sys_lang_words> core_sys_lang_words { get; set; }
        public virtual DbSet<core_sys_social_groups> core_sys_social_groups { get; set; }
        public virtual DbSet<core_tags> core_tags { get; set; }
        public virtual DbSet<core_tasks> core_tasks { get; set; }
        public virtual DbSet<core_theme_conflict> core_theme_conflict { get; set; }
        public virtual DbSet<core_theme_content_history> core_theme_content_history { get; set; }
        public virtual DbSet<core_theme_css> core_theme_css { get; set; }
        public virtual DbSet<core_theme_resources> core_theme_resources { get; set; }
        public virtual DbSet<core_theme_settings_fields> core_theme_settings_fields { get; set; }
        public virtual DbSet<core_theme_templates> core_theme_templates { get; set; }
        public virtual DbSet<core_themes> core_themes { get; set; }
        public virtual DbSet<core_upgrade_history> core_upgrade_history { get; set; }
        public virtual DbSet<core_validating> core_validating { get; set; }
        public virtual DbSet<core_voters> core_voters { get; set; }
        public virtual DbSet<core_widget_areas> core_widget_areas { get; set; }
        public virtual DbSet<core_widget_trash> core_widget_trash { get; set; }
        public virtual DbSet<core_widgets> core_widgets { get; set; }
        public virtual DbSet<forums_answer_ratings> forums_answer_ratings { get; set; }
        public virtual DbSet<forums_archive_posts> forums_archive_posts { get; set; }
        public virtual DbSet<forums_archive_rules> forums_archive_rules { get; set; }
        public virtual DbSet<forums_forums> forums_forums { get; set; }
        public virtual DbSet<forums_posts> forums_posts { get; set; }
        public virtual DbSet<forums_question_ratings> forums_question_ratings { get; set; }
        public virtual DbSet<forums_rss_import> forums_rss_import { get; set; }
        public virtual DbSet<forums_rss_imported> forums_rss_imported { get; set; }
        public virtual DbSet<forums_topic_mmod> forums_topic_mmod { get; set; }
        public virtual DbSet<forums_topics> forums_topics { get; set; }
        public virtual DbSet<nexus_alternate_contacts> nexus_alternate_contacts { get; set; }
        public virtual DbSet<nexus_billing_agreements> nexus_billing_agreements { get; set; }
        public virtual DbSet<nexus_cart_uploads> nexus_cart_uploads { get; set; }
        public virtual DbSet<nexus_coupons> nexus_coupons { get; set; }
        public virtual DbSet<nexus_customer_addresses> nexus_customer_addresses { get; set; }
        public virtual DbSet<nexus_customer_cards> nexus_customer_cards { get; set; }
        public virtual DbSet<nexus_customer_fields> nexus_customer_fields { get; set; }
        public virtual DbSet<nexus_customer_history> nexus_customer_history { get; set; }
        public virtual DbSet<nexus_customers> nexus_customers { get; set; }
        public virtual DbSet<nexus_donate_goals> nexus_donate_goals { get; set; }
        public virtual DbSet<nexus_donate_logs> nexus_donate_logs { get; set; }
        public virtual DbSet<nexus_eom> nexus_eom { get; set; }
        public virtual DbSet<nexus_fraud_rules> nexus_fraud_rules { get; set; }
        public virtual DbSet<nexus_hosting_accounts> nexus_hosting_accounts { get; set; }
        public virtual DbSet<nexus_hosting_errors> nexus_hosting_errors { get; set; }
        public virtual DbSet<nexus_hosting_queues> nexus_hosting_queues { get; set; }
        public virtual DbSet<nexus_hosting_servers> nexus_hosting_servers { get; set; }
        public virtual DbSet<nexus_invoices> nexus_invoices { get; set; }
        public virtual DbSet<nexus_licensekeys> nexus_licensekeys { get; set; }
        public virtual DbSet<nexus_notes> nexus_notes { get; set; }
        public virtual DbSet<nexus_package_base_prices> nexus_package_base_prices { get; set; }
        public virtual DbSet<nexus_package_fields> nexus_package_fields { get; set; }
        public virtual DbSet<nexus_package_groups> nexus_package_groups { get; set; }
        public virtual DbSet<nexus_package_images> nexus_package_images { get; set; }
        public virtual DbSet<nexus_packages> nexus_packages { get; set; }
        public virtual DbSet<nexus_packages_ads> nexus_packages_ads { get; set; }
        public virtual DbSet<nexus_packages_hosting> nexus_packages_hosting { get; set; }
        public virtual DbSet<nexus_packages_products> nexus_packages_products { get; set; }
        public virtual DbSet<nexus_paymethods> nexus_paymethods { get; set; }
        public virtual DbSet<nexus_payouts> nexus_payouts { get; set; }
        public virtual DbSet<nexus_product_options> nexus_product_options { get; set; }
        public virtual DbSet<nexus_purchases> nexus_purchases { get; set; }
        public virtual DbSet<nexus_referral_banners> nexus_referral_banners { get; set; }
        public virtual DbSet<nexus_referral_rules> nexus_referral_rules { get; set; }
        public virtual DbSet<nexus_referrals> nexus_referrals { get; set; }
        public virtual DbSet<nexus_reviews> nexus_reviews { get; set; }
        public virtual DbSet<nexus_ship_orders> nexus_ship_orders { get; set; }
        public virtual DbSet<nexus_shipping> nexus_shipping { get; set; }
        public virtual DbSet<nexus_support_departments> nexus_support_departments { get; set; }
        public virtual DbSet<nexus_support_fields> nexus_support_fields { get; set; }
        public virtual DbSet<nexus_support_notify> nexus_support_notify { get; set; }
        public virtual DbSet<nexus_support_ratings> nexus_support_ratings { get; set; }
        public virtual DbSet<nexus_support_replies> nexus_support_replies { get; set; }
        public virtual DbSet<nexus_support_request_log> nexus_support_request_log { get; set; }
        public virtual DbSet<nexus_support_requests> nexus_support_requests { get; set; }
        public virtual DbSet<nexus_support_severities> nexus_support_severities { get; set; }
        public virtual DbSet<nexus_support_staff_preferences> nexus_support_staff_preferences { get; set; }
        public virtual DbSet<nexus_support_statuses> nexus_support_statuses { get; set; }
        public virtual DbSet<nexus_support_stock_actions> nexus_support_stock_actions { get; set; }
        public virtual DbSet<nexus_support_streams> nexus_support_streams { get; set; }
        public virtual DbSet<nexus_support_tracker> nexus_support_tracker { get; set; }
        public virtual DbSet<nexus_support_views> nexus_support_views { get; set; }
        public virtual DbSet<nexus_tax> nexus_tax { get; set; }
        public virtual DbSet<nexus_transactions> nexus_transactions { get; set; }
        public virtual DbSet<zzukbot_migrated_users> zzukbot_migrated_users { get; set; }
        public virtual DbSet<zzukbot_v1_users> zzukbot_v1_users { get; set; }
        public virtual DbSet<core_acp_search_index> core_acp_search_index { get; set; }
        public virtual DbSet<core_acp_tab_order> core_acp_tab_order { get; set; }
        public virtual DbSet<core_attachments_map> core_attachments_map { get; set; }
        public virtual DbSet<core_cache> core_cache { get; set; }
        public virtual DbSet<core_googleauth_used_codes> core_googleauth_used_codes { get; set; }
        public virtual DbSet<core_item_markers> core_item_markers { get; set; }
        public virtual DbSet<core_reputation_leaderboard_history> core_reputation_leaderboard_history { get; set; }
        public virtual DbSet<core_search_index_item_map> core_search_index_item_map { get; set; }
        public virtual DbSet<core_search_index_tags> core_search_index_tags { get; set; }
        public virtual DbSet<core_security_answers> core_security_answers { get; set; }
        public virtual DbSet<core_sys_social_group_members> core_sys_social_group_members { get; set; }
        public virtual DbSet<core_tags_cache> core_tags_cache { get; set; }
        public virtual DbSet<core_tags_perms> core_tags_perms { get; set; }
        public virtual DbSet<core_tasks_log> core_tasks_log { get; set; }
        public virtual DbSet<core_theme_settings_values> core_theme_settings_values { get; set; }
        public virtual DbSet<core_view_updates> core_view_updates { get; set; }
        public virtual DbSet<nexus_support_staff_dpt_order> nexus_support_staff_dpt_order { get; set; }
        public virtual DbSet<zzukbot_versions> zzukbot_versions { get; set; }
    }
}
