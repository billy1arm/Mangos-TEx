﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MangosData.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MangosEntities : DbContext
    {
        public MangosEntities()
            : this("name=MangosEntities")
        {
        }
    
        public MangosEntities(string connectionString)
            : base(connectionString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<achievement_criteria_requirement> achievement_criteria_requirement { get; set; }
        public DbSet<achievement_reward> achievement_reward { get; set; }
        public DbSet<areatrigger_involvedrelation> areatrigger_involvedrelation { get; set; }
        public DbSet<areatrigger_tavern> areatrigger_tavern { get; set; }
        public DbSet<areatrigger_teleport> areatrigger_teleport { get; set; }
        public DbSet<battleground_events> battleground_events { get; set; }
        public DbSet<battleground_template> battleground_template { get; set; }
        public DbSet<battlemaster_entry> battlemaster_entry { get; set; }
        public DbSet<command> command { get; set; }
        public DbSet<conditions> conditions { get; set; }
        public DbSet<creature> creature { get; set; }
        public DbSet<creature_addon> creature_addon { get; set; }
        public DbSet<creature_ai_scripts> creature_ai_scripts { get; set; }
        public DbSet<creature_ai_summons> creature_ai_summons { get; set; }
        public DbSet<creature_ai_texts> creature_ai_texts { get; set; }
        public DbSet<creature_battleground> creature_battleground { get; set; }
        public DbSet<creature_equip_template> creature_equip_template { get; set; }
        public DbSet<creature_involvedrelation> creature_involvedrelation { get; set; }
        public DbSet<creature_linking> creature_linking { get; set; }
        public DbSet<creature_linking_template> creature_linking_template { get; set; }
        public DbSet<creature_loot_template> creature_loot_template { get; set; }
        public DbSet<creature_model_info> creature_model_info { get; set; }
        public DbSet<creature_model_race> creature_model_race { get; set; }
        public DbSet<creature_movement> creature_movement { get; set; }
        public DbSet<creature_movement_template> creature_movement_template { get; set; }
        public DbSet<creature_onkill_reputation> creature_onkill_reputation { get; set; }
        public DbSet<creature_questrelation> creature_questrelation { get; set; }
        public DbSet<creature_template> creature_template { get; set; }
        public DbSet<creature_template_addon> creature_template_addon { get; set; }
        public DbSet<creature_template_spells> creature_template_spells { get; set; }
        public DbSet<db_script_string> db_script_string { get; set; }
        public DbSet<dbscripts_on_creature_death> dbscripts_on_creature_death { get; set; }
        public DbSet<dbscripts_on_creature_movement> dbscripts_on_creature_movement { get; set; }
        public DbSet<dbscripts_on_event> dbscripts_on_event { get; set; }
        public DbSet<dbscripts_on_go_template_use> dbscripts_on_go_template_use { get; set; }
        public DbSet<dbscripts_on_go_use> dbscripts_on_go_use { get; set; }
        public DbSet<dbscripts_on_gossip> dbscripts_on_gossip { get; set; }
        public DbSet<dbscripts_on_quest_end> dbscripts_on_quest_end { get; set; }
        public DbSet<dbscripts_on_quest_start> dbscripts_on_quest_start { get; set; }
        public DbSet<dbscripts_on_spell> dbscripts_on_spell { get; set; }
        public DbSet<disenchant_loot_template> disenchant_loot_template { get; set; }
        public DbSet<exploration_basexp> exploration_basexp { get; set; }
        public DbSet<fishing_loot_template> fishing_loot_template { get; set; }
        public DbSet<game_event> game_event { get; set; }
        public DbSet<game_event_creature> game_event_creature { get; set; }
        public DbSet<game_event_creature_data> game_event_creature_data { get; set; }
        public DbSet<game_event_gameobject> game_event_gameobject { get; set; }
        public DbSet<game_event_mail> game_event_mail { get; set; }
        public DbSet<game_event_quest> game_event_quest { get; set; }
        public DbSet<game_graveyard_zone> game_graveyard_zone { get; set; }
        public DbSet<game_tele> game_tele { get; set; }
        public DbSet<game_weather> game_weather { get; set; }
        public DbSet<gameobject> gameobject { get; set; }
        public DbSet<gameobject_addon> gameobject_addon { get; set; }
        public DbSet<gameobject_battleground> gameobject_battleground { get; set; }
        public DbSet<gameobject_involvedrelation> gameobject_involvedrelation { get; set; }
        public DbSet<gameobject_loot_template> gameobject_loot_template { get; set; }
        public DbSet<gameobject_questrelation> gameobject_questrelation { get; set; }
        public DbSet<gameobject_template> gameobject_template { get; set; }
        public DbSet<gossip_menu> gossip_menu { get; set; }
        public DbSet<gossip_menu_option> gossip_menu_option { get; set; }
        public DbSet<instance_encounters> instance_encounters { get; set; }
        public DbSet<instance_template> instance_template { get; set; }
        public DbSet<item_convert> item_convert { get; set; }
        public DbSet<item_enchantment_template> item_enchantment_template { get; set; }
        public DbSet<item_expire_convert> item_expire_convert { get; set; }
        public DbSet<item_loot_template> item_loot_template { get; set; }
        public DbSet<item_required_target> item_required_target { get; set; }
        public DbSet<item_template> item_template { get; set; }
        public DbSet<locales_achievement_reward> locales_achievement_reward { get; set; }
        public DbSet<locales_creature> locales_creature { get; set; }
        public DbSet<locales_gameobject> locales_gameobject { get; set; }
        public DbSet<locales_gossip_menu_option> locales_gossip_menu_option { get; set; }
        public DbSet<locales_item> locales_item { get; set; }
        public DbSet<locales_npc_text> locales_npc_text { get; set; }
        public DbSet<locales_page_text> locales_page_text { get; set; }
        public DbSet<locales_points_of_interest> locales_points_of_interest { get; set; }
        public DbSet<locales_quest> locales_quest { get; set; }
        public DbSet<mail_level_reward> mail_level_reward { get; set; }
        public DbSet<mail_loot_template> mail_loot_template { get; set; }
        public DbSet<mangos_string> mangos_string { get; set; }
        public DbSet<milling_loot_template> milling_loot_template { get; set; }
        public DbSet<npc_gossip> npc_gossip { get; set; }
        public DbSet<npc_spellclick_spells> npc_spellclick_spells { get; set; }
        public DbSet<npc_text> npc_text { get; set; }
        public DbSet<npc_trainer> npc_trainer { get; set; }
        public DbSet<npc_trainer_template> npc_trainer_template { get; set; }
        public DbSet<npc_vendor> npc_vendor { get; set; }
        public DbSet<npc_vendor_template> npc_vendor_template { get; set; }
        public DbSet<page_text> page_text { get; set; }
        public DbSet<pet_levelstats> pet_levelstats { get; set; }
        public DbSet<pet_name_generation> pet_name_generation { get; set; }
        public DbSet<pickpocketing_loot_template> pickpocketing_loot_template { get; set; }
        public DbSet<player_classlevelstats> player_classlevelstats { get; set; }
        public DbSet<player_levelstats> player_levelstats { get; set; }
        public DbSet<player_xp_for_level> player_xp_for_level { get; set; }
        public DbSet<playercreateinfo> playercreateinfo { get; set; }
        public DbSet<playercreateinfo_action> playercreateinfo_action { get; set; }
        public DbSet<playercreateinfo_item> playercreateinfo_item { get; set; }
        public DbSet<playercreateinfo_spell> playercreateinfo_spell { get; set; }
        public DbSet<points_of_interest> points_of_interest { get; set; }
        public DbSet<pool_creature> pool_creature { get; set; }
        public DbSet<pool_creature_template> pool_creature_template { get; set; }
        public DbSet<pool_gameobject> pool_gameobject { get; set; }
        public DbSet<pool_gameobject_template> pool_gameobject_template { get; set; }
        public DbSet<pool_pool> pool_pool { get; set; }
        public DbSet<pool_template> pool_template { get; set; }
        public DbSet<prospecting_loot_template> prospecting_loot_template { get; set; }
        public DbSet<quest_poi> quest_poi { get; set; }
        public DbSet<quest_poi_points> quest_poi_points { get; set; }
        public DbSet<quest_template> quest_template { get; set; }
        public DbSet<reference_loot_template> reference_loot_template { get; set; }
        public DbSet<reputation_reward_rate> reputation_reward_rate { get; set; }
        public DbSet<reputation_spillover_template> reputation_spillover_template { get; set; }
        public DbSet<reserved_name> reserved_name { get; set; }
        public DbSet<scripted_areatrigger> scripted_areatrigger { get; set; }
        public DbSet<scripted_event_id> scripted_event_id { get; set; }
        public DbSet<skill_discovery_template> skill_discovery_template { get; set; }
        public DbSet<skill_extra_item_template> skill_extra_item_template { get; set; }
        public DbSet<skill_fishing_base_level> skill_fishing_base_level { get; set; }
        public DbSet<skinning_loot_template> skinning_loot_template { get; set; }
        public DbSet<spell_area> spell_area { get; set; }
        public DbSet<spell_bonus_data> spell_bonus_data { get; set; }
        public DbSet<spell_chain> spell_chain { get; set; }
        public DbSet<spell_elixir> spell_elixir { get; set; }
        public DbSet<spell_learn_spell> spell_learn_spell { get; set; }
        public DbSet<spell_loot_template> spell_loot_template { get; set; }
        public DbSet<spell_pet_auras> spell_pet_auras { get; set; }
        public DbSet<spell_proc_event> spell_proc_event { get; set; }
        public DbSet<spell_proc_item_enchant> spell_proc_item_enchant { get; set; }
        public DbSet<spell_script_target> spell_script_target { get; set; }
        public DbSet<spell_target_position> spell_target_position { get; set; }
        public DbSet<spell_template> spell_template { get; set; }
        public DbSet<spell_threat> spell_threat { get; set; }
        public DbSet<transports> transports { get; set; }
        public DbSet<vehicle_accessory> vehicle_accessory { get; set; }
        public DbSet<world_template> world_template { get; set; }
    }
}
