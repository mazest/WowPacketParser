using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_1_0_16309
{
    public static class Opcodes_5_1_0
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_CAST_SPELL, 0x014C},
            {Opcode.CMSG_CREATURE_QUERY, 0x0285},
            {Opcode.CMSG_CHAR_ENUM, 0x05A5},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x0BE9},
            {Opcode.CMSG_LIST_INVENTORY, 0x0F8D},
            {Opcode.CMSG_LOG_DISCONNECT, 0x0D47},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x02E5},
            {Opcode.CMSG_QUESTGIVER_ACCEPT_QUEST, 0x0AAD},
            {Opcode.CMSG_QUESTGIVER_CHOOSE_REWARD, 0x0DA1},
            {Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST, 0x0144},
            {Opcode.CMSG_QUESTGIVER_HELLO, 0x96D},
            {Opcode.CMSG_QUESTGIVER_QUERY_QUEST, 0x0BE8},
            {Opcode.CMSG_QUESTGIVER_REQUEST_REWARD, 0x004C},
            {Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY, 0x0BA1},
            {Opcode.CMSG_QUESTGIVER_STATUS_QUERY, 0x0F69},
            {Opcode.CMSG_QUEST_CONFIRM_ACCEPT, 0x0941},
            {Opcode.CMSG_REALM_SPLIT, 0x0261},
            {Opcode.CMSG_SELL_ITEM, 0x02CC},
            {Opcode.CMSG_SPIRIT_HEALER_ACTIVATE, 0x03C4},
            {Opcode.CMSG_TRAINER_BUY_SPELL, 0x03EC},
            {Opcode.CMSG_TRAINER_LIST, 0x0CA0},
            {Opcode.MSG_MOVE_TELEPORT, 0x371},
            {Opcode.MSG_MOVE_TIME_SKIPPED, 0x338}, // could be MSG_MOVE_HEARTBEAT
            {Opcode.MSG_QUEST_PUSH_RESULT, 0x09A4},
            {Opcode.MSG_RANDOM_ROLL, 0xA5C},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0E48},
            {Opcode.SMSG_ACCOUNT_INFO_RESPONSE, 0x659},
            {Opcode.SMSG_ACCOUNT_RESTRICTED_WARNING, 0xCD8},
            {Opcode.SMSG_ACHIEVEMENT_EARNED, 0x719},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x618},
            {Opcode.SMSG_AREA_SPIRIT_HEALER_TIME, 0x0288},
            {Opcode.SMSG_AREA_TRIGGER_MESSAGE, 0x0F01},
            {Opcode.SMSG_AREA_TRIGGER_MOVEMENT_UPDATE, 0x898},
            {Opcode.SMSG_ARENA_TEAM_COMMAND_RESULT, 0x5B4},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x04E8},
            {Opcode.SMSG_ATTACKSTART, 0x0EA8},
            {Opcode.SMSG_ATTACKSTOP, 0x0DE4},
            {Opcode.SMSG_ATTACKSWING_BADFACING, 0x0C24},
            {Opcode.SMSG_ATTACKSWING_CANT_ATTACK, 0x0B45},
            {Opcode.SMSG_ATTACKSWING_DEADTARGET, 0x038D},
            {Opcode.SMSG_ATTACKSWING_NOTINRANGE, 0x0328},
            {Opcode.SMSG_AURA_POINTS_DEPLETED, 0x095},
            {Opcode.SMSG_AURA_UPDATE, 0x07AD},
            {Opcode.SMSG_AURA_UPDATE_ALL, 0x0484},
            {Opcode.SMSG_AUTH_CHALLENGE, 0xCAF},
            {Opcode.SMSG_AUTH_RESPONSE, 0xA15},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECTED, 0x7F1},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECT_PENDING, 0xE54},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTERED, 0xEB5},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTRY_INVITE, 0xC3D},
            {Opcode.SMSG_BATTLEFIELD_MGR_EXIT_REQUEST, 0xE78},
            {Opcode.SMSG_BATTLEFIELD_MGR_QUEUE_INVITE, 0xC1D},
            {Opcode.SMSG_BATTLEFIELD_MGR_QUEUE_REQUEST_RESPONSE, 0xF35},
            {Opcode.SMSG_BATTLEFIELD_MGR_STATE_CHANGE, 0xC75},
            {Opcode.SMSG_BATTLEFIELD_PORT_DENIED, 0x01D},
            {Opcode.SMSG_BATTLEFIELD_RATED_INFO, 0x1FC},
            {Opcode.SMSG_BATTLEFIELD_STATUS, 0x49C},
            {Opcode.SMSG_BATTLEFIELD_STATUS_ACTIVE, 0x23C},
            {Opcode.SMSG_BATTLEFIELD_STATUS_FAILED, 0x6B4},
            {Opcode.SMSG_BATTLEFIELD_STATUS_NEEDCONFIRMATION, 0xF51},
            {Opcode.SMSG_BATTLEFIELD_STATUS_WAITFORGROUPS, 0x2B0},
            {Opcode.SMSG_BATTLEGROUND_INFO_THROTTLED, 0x315},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_JOINED, 0x0DC},
            {Opcode.SMSG_BATTLEGROUND_PLAYER_LEFT, 0x1FD},
            {Opcode.SMSG_BREAK_TARGET, 0x0201},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x044D},
            {Opcode.SMSG_CHAR_ENUM, 0x033D},
            {Opcode.SMSG_CHAT_IGNORED_ACCOUNT_MUTED, 0x115},
            {Opcode.SMSG_CLEAR_BOSS_EMOTES, 0x259},
            {Opcode.SMSG_CLEAR_COOLDOWNS, 0x890},
            {Opcode.SMSG_CLEAR_TARGET, 0x0ECC},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x072D},
            {Opcode.SMSG_COMBAT_EVENT_FAILED, 0x0D24},
            {Opcode.SMSG_COMMENTATOR_PARTY_INFO, 0x871},
            {Opcode.SMSG_CONTACT_LIST, 0x0785},
            {Opcode.SMSG_CORPSE_MAP_POSITION_QUERY_RESPONSE, 0x084D},
            {Opcode.SMSG_CORPSE_NOT_IN_INSTANCE, 0x0824},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x0504},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x060D},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x0AA4},
            {Opcode.SMSG_CURRENCY_LOOT_REMOVED, 0xF1D},
            {Opcode.SMSG_CUSTOM_LOAD_SCREEN, 0x6F9},
            {Opcode.SMSG_DB_REPLY, 0x59C},
            {Opcode.SMSG_DEBUG_RUNE_REGEN, 0xCD0},
            {Opcode.SMSG_DIFFERENT_INSTANCE_FROM_PARTY, 0xD91},
            {Opcode.SMSG_DISENCHANT_CREDIT, 0x990},
            {Opcode.SMSG_DISPLAY_GAME_ERROR, 0xA11},
            {Opcode.SMSG_DONT_AUTO_PUSH_SPELLS_TO_ACTION_BAR, 0x318},
            {Opcode.SMSG_DROP_NEW_CONNECTION, 0xC2F},
            {Opcode.SMSG_DUMP_RIDE_TICKETS_RESPONSE, 0xAB5},
            {Opcode.SMSG_EMOTE, 0x0DC8},
            {Opcode.SMSG_ENVIRONMENTALDAMAGELOG, 0x0600},
            {Opcode.SMSG_FAILED_PLAYER_CONDITION, 0x77D},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x7F9},
            {Opcode.SMSG_FLOOD_DETECTED, 0xA2A},
            {Opcode.SMSG_FORGE_MASTER_SET, 0xB39},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x080D},
            {Opcode.SMSG_GAME_EVENT_DEBUG_LOG, 0x291},
            {Opcode.SMSG_GAME_OBJECT_ACTIVATE_ANIM_KIT, 0xB19},
            {Opcode.SMSG_GM_PLAYER_INFO, 0x00A4},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x088C},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_DELETED, 0x694},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_EARNED, 0x474},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_MEMBERS, 0xB71},
            {Opcode.SMSG_GUILD_BANK_LOG_QUERY_RESULTS, 0x774},
            {Opcode.SMSG_GUILD_BANK_QUERY_TEXT_RESULTS, 0x2F5},
            {Opcode.SMSG_GUILD_CHALLENGE_COMPLETED, 0x4F9},
            {Opcode.SMSG_GUILD_CHALLENGE_UPDATED, 0xF3D},
            {Opcode.SMSG_GUILD_CHANGE_NAME_RESULT, 0x4D9},
            {Opcode.SMSG_GUILD_COMMAND_RESULT, 0x9FC},
            {Opcode.SMSG_GUILD_CRITERIA_DELETED, 0x08D9},
            {Opcode.SMSG_GUILD_EVENT_LOG_QUERY, 0x8B4},
            {Opcode.SMSG_GUILD_FLAGGED_FOR_RENAME, 0x050},
            {Opcode.SMSG_GUILD_INVITE, 0xD30},
            {Opcode.SMSG_GUILD_MEMBERS_FOR_RECIPE, 0x411},
            {Opcode.SMSG_GUILD_MEMBER_DAILY_RESET, 0x554},
            {Opcode.SMSG_GUILD_MEMBER_RECIPES, 0x1B4},
            {Opcode.SMSG_GUILD_MEMBER_UPDATE_NOTE, 0xAB4},
            {Opcode.SMSG_GUILD_MOVE_COMPLETE, 0x8FC},
            {Opcode.SMSG_GUILD_MOVE_STARTING, 0x730},
            {Opcode.SMSG_GUILD_NEWS_DELETED, 0xF7C},
            {Opcode.SMSG_GUILD_RECIPES, 0x4FC},
            {Opcode.SMSG_GUILD_RENAMED, 0x851},
            {Opcode.SMSG_GUILD_REPUTATION_REACTION_CHANGED, 0xF59},
            {Opcode.SMSG_GUILD_REPUTATION_WEEKLY_CAP, 0x61C},
            {Opcode.SMSG_GUILD_RESET, 0x1F9},
            {Opcode.SMSG_GUILD_REWARDS_LIST, 0x55D},
            {Opcode.SMSG_GUILD_ROSTER, 0xA75},
            {Opcode.SMSG_GUILD_UPDATE_ROSTER, 0x270},
            {Opcode.SMSG_HOTFIX_NOTIFY, 0x5B0},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x010C},
            {Opcode.SMSG_INSPECT_HONOR_STATS, 0x5D0},
            {Opcode.SMSG_INSPECT_RATED_BG_STATS, 0x2B5},
            {Opcode.SMSG_INSPECT_RESULTS_UPDATE, 0x4DD},
            {Opcode.SMSG_INVALID_PROMOTION_CODE, 0x0965},
            {Opcode.SMSG_ITEM_ADD_PASSIVE, 0x7F0},
            {Opcode.SMSG_ITEM_EXPIRE_PURCHASE_REFUND, 0x795},
            {Opcode.SMSG_ITEM_PUSH_RESULT, 0xE51},
            {Opcode.SMSG_ITEM_REFUND_RESULT, 0x7B5},
            {Opcode.SMSG_ITEM_REMOVE_PASSIVE, 0x439},
            {Opcode.SMSG_ITEM_SEND_PASSIVE, 0x8DD},
            {Opcode.SMSG_LEARNED_DANCE_MOVES, 0x05E0},
            {Opcode.SMSG_LFG_JOIN_RESULT, 0xBF8},
            {Opcode.SMSG_LFG_PROPOSAL_UPDATE, 0xDD5},
            {Opcode.SMSG_LFG_QUEUE_STATUS, 0x950},
            {Opcode.SMSG_LFG_ROLE_CHECK_UPDATE, 0x0336},
            {Opcode.SMSG_LFG_SLOT_INVALID, 0x6D4},
            {Opcode.SMSG_LFG_TELEPORT_DENIED, 0x9BD},
            {Opcode.SMSG_LFG_UPDATE_SEARCH, 0x05C},
            {Opcode.SMSG_LFG_UPDATE_STATUS, 0x154},
            {Opcode.SMSG_LFG_UPDATE_STATUS_NONE, 0xABD},
            {Opcode.SMSG_LF_GUILD_APPLICANT_LIST_UPDATED, 0x335}, // OR 0x130? (LFGuildApplications)
            {Opcode.SMSG_LF_GUILD_APPLICATIONS_LIST_CHANGED, 0x2D5},
            {Opcode.SMSG_LF_GUILD_BROWSE_UPDATED, 0x19},
            {Opcode.SMSG_LF_GUILD_COMMAND_RESULT, 0x570},
            {Opcode.SMSG_LF_GUILD_POST_UPDATED, 0xE91},
            {Opcode.SMSG_LF_GUILD_RECRUIT_LIST_UPDATED, 0x45D},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0B6C},
            {Opcode.SMSG_LOOT_ALL_PASSED, 0x1BD},
            {Opcode.SMSG_LOOT_CONTENTS, 0xDB1},
            {Opcode.SMSG_LOOT_LIST, 0x3B9}, // MASTER LIST?
            {Opcode.SMSG_LOOT_MONEY_NOTIFY, 0xB38},
            {Opcode.SMSG_LOOT_REMOVED, 0x1F0},
            {Opcode.SMSG_LOOT_RESPONSE, 0xD98},
            {Opcode.SMSG_LOOT_ROLL, 0x77C},
            {Opcode.SMSG_LOOT_ROLL_WON, 0x53C},
            {Opcode.SMSG_LOOT_START_ROLL, 0x334},
            {Opcode.SMSG_MAP_OBJ_EVENTS, 0xA7C},
            {Opcode.SMSG_MESSAGE_BOX, 0x8D1},
            {Opcode.SMSG_MESSAGECHAT, 0x0009},
            {Opcode.SMSG_MONEY_NOTIFY, 0x99C},
            {Opcode.SMSG_MONSTER_MOVE, 0x02A5},
            {Opcode.SMSG_MONSTER_MOVE_TRANSPORT, 0x036C},
            {Opcode.SMSG_MOTD, 0x0849},
            {Opcode.SMSG_MOVE_COLLISION_DISABLE, 0xD54},
            {Opcode.SMSG_MOVE_COLLISION_ENABLE, 0x7D4},
            {Opcode.SMSG_MOVE_FEATHER_FALL, 0x9F4},
            {Opcode.SMSG_MOVE_GRAVITY_DISABLE, 0xDD0},
            {Opcode.SMSG_MOVE_GRAVITY_ENABLE, 0xC79},
            {Opcode.SMSG_MOVE_KNOCK_BACK, 0x194},
            {Opcode.SMSG_MOVE_LAND_WALK, 0xD94},
            {Opcode.SMSG_MOVE_NORMAL_FALL, 0xC9D},
            {Opcode.SMSG_MOVE_ROOT, 0x955},
            {Opcode.SMSG_MOVE_SET_ACTIVE_MOVER, 0x7DC},
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x419},
            {Opcode.SMSG_MOVE_SET_CAN_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x459},
            {Opcode.SMSG_MOVE_SET_COLLISION_HEIGHT, 0x99D},
            {Opcode.SMSG_MOVE_SET_COMPOUND_STATE, 0xC34},
            {Opcode.SMSG_MOVE_SET_FLIGHT_BACK_SPEED, 0x159},
            {Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x5FD},
            {Opcode.SMSG_MOVE_SET_HOVER, 0x251},
            {Opcode.SMSG_MOVE_SET_RUN_BACK_SPEED, 0x394},
            {Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x231},
            {Opcode.SMSG_MOVE_SET_SWIM_BACK_SPEED, 0x475},
            {Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x09D},
            {Opcode.SMSG_MOVE_SET_TURN_RATE, 0x234},
            {Opcode.SMSG_MOVE_SET_WALK_SPEED, 0xDD1},
            {Opcode.SMSG_MOVE_UNROOT, 0x15C},
            {Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x63D},
            {Opcode.SMSG_MOVE_UNSET_CAN_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x0D4},
            {Opcode.SMSG_MOVE_UNSET_HOVER, 0x3B1},
            {Opcode.SMSG_MOVE_UPDATE_COLLISION_HEIGHT, 0xDD8},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_BACK_SPEED, 0xB15},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_SPEED, 0x895},
            {Opcode.SMSG_MOVE_UPDATE_KNOCK_BACK, 0x175},
            {Opcode.SMSG_MOVE_UPDATE_PITCH_RATE, 0x1DB5},
            {Opcode.SMSG_MOVE_UPDATE_RUN_BACK_SPEED, 0x8B5},
            {Opcode.SMSG_MOVE_UPDATE_RUN_SPEED, 0x49D},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_BACK_SPEED, 0x7BC},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_SPEED, 0x6B8},
            {Opcode.SMSG_MOVE_UPDATE_TURN_RATE, 0xBB5},
            {Opcode.SMSG_MOVE_UPDATE_WALK_SPEED, 0x3B8},
            {Opcode.SMSG_MOVE_WATER_WALK, 0x21C},
            {Opcode.SMSG_NEW_WORLD, 0x81D},
            {Opcode.SMSG_NEW_WORLD_ABORT, 0x295},
            {Opcode.SMSG_OVERRIDE_LIGHT, 0x04C8},
            {Opcode.SMSG_PETITION_ALREADY_SIGNED, 0xC39},
            {Opcode.SMSG_PET_ADDED, 0x13C},
            {Opcode.SMSG_PET_SLOT_UPDATED, 0xA5D},
            {Opcode.SMSG_PET_SPELLS, 0x0EAC},
            {Opcode.SMSG_PLAY_MUSIC, 0x012D},
            {Opcode.SMSG_PLAY_OBJECT_SOUND, 0x0EC8},
            {Opcode.SMSG_PLAY_SOUND, 0x0C88},
            {Opcode.SMSG_PLAY_SPELL_VISUAL, 0xF55},
            {Opcode.SMSG_PLAY_SPELL_VISUAL_KIT, 0x230},
            {Opcode.SMSG_PONG, 0x8AE},
            {Opcode.SMSG_PROPOSE_LEVEL_GRANT, 0x0601},
            {Opcode.SMSG_PVP_CREDIT, 0x0D04},
            {Opcode.SMSG_PVP_LOG_DATA, 0xC5D},
            {Opcode.SMSG_PVP_OPTIONS_ENABLED, 0xA78},
            {Opcode.SMSG_QUESTGIVER_QUEST_COMPLETE, 0x0E35},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x08A0},
            {Opcode.SMSG_QUESTGIVER_QUEST_FAILED, 0x0105},
            {Opcode.SMSG_QUESTGIVER_QUEST_INVALID, 0x0CE1},
            {Opcode.SMSG_QUESTGIVER_QUEST_LIST, 0x0048},
            {Opcode.SMSG_QUESTGIVER_REQUEST_ITEMS, 0x0DC5},
            {Opcode.SMSG_QUESTGIVER_STATUS, 0x0888},
            {Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE, 0x0D8D},
            {Opcode.SMSG_QUESTLOG_FULL, 0x09C0},
            {Opcode.SMSG_QUESTUPDATE_COMPLETE, 0x00E4},
            {Opcode.SMSG_QUESTUPDATE_ADD_KILL, 0x0E61},
            {Opcode.SMSG_QUESTUPDATE_ADD_PVP_KILL, 0x0629},
            {Opcode.SMSG_QUESTUPDATE_FAILEDTIMER, 0x06A5},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x0741},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x0D40},
            {Opcode.SMSG_RAID_MARKERS_CHANGED, 0x930},
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0xB74}, // GenerateRandomCharacterNameResult
            {Opcode.SMSG_RATED_BG_RATING, 0x935},
            {Opcode.SMSG_RATED_BG_STATS, 0x418},
            {Opcode.SMSG_REALM_SPLIT, 0x05CC},
            {Opcode.SMSG_REFER_A_FRIEND_EXPIRED, 0x0F0D},
            {Opcode.SMSG_REFER_A_FRIEND_FAILURE, 0x0C64},
            {Opcode.SMSG_REFORGE_RESULT, 0x95D},
            {Opcode.SMSG_REQUEST_CEMETERY_LIST_RESPONSE, 0x075},
            {Opcode.SMSG_REQUEST_PVP_REWARDS_RESPONSE, 0x23D},
            {Opcode.SMSG_RESEARCH_COMPLETE, 0xF99},
            {Opcode.SMSG_RESEARCH_SETUP_HISTORY, 0xD7C},
            {Opcode.SMSG_RESET_COMPRESSION_CONTEXT, 0xE2F},
            {Opcode.SMSG_RESPOND_INSPECT_ACHIEVEMENTS, 0x7B8},
            {Opcode.SMSG_ROLE_POLL_BEGIN, 0xF15},
            {Opcode.SMSG_SERVER_FIRST_ACHIEVEMENT, 0xD78},
            {Opcode.SMSG_SERVER_INFO_RESPONSE, 0x0F4},
            {Opcode.SMSG_SERVER_PERF, 0xF79},
            {Opcode.SMSG_SET_DF_FAST_LAUNCH_RESULT, 0x9D0},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x5F4},
            {Opcode.SMSG_SET_PLAY_HOVER_ANIM, 0xF58},
            {Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0xDD9},
            {Opcode.SMSG_SPELL_GO, 0x0C8D},
            {Opcode.SMSG_SPELL_START, 0x09E4},
            {Opcode.SMSG_START_TIMER, 0x9B0},
            {Opcode.SMSG_SUPPRESS_NPC_GREETINGS, 0x2FC},
            {Opcode.SMSG_SUSPEND_COMMS, 0x82A},
            {Opcode.SMSG_TALENTS_INVOLUNTARILY_RESET, 0x0AA9},
            {Opcode.SMSG_TOTEM_CREATED, 0x0469},
            {Opcode.SMSG_TRADE_STATUS, 0x5B1},
            {Opcode.SMSG_TRAINER_BUY_FAILED, 0x0BC8},
            {Opcode.SMSG_TRAINER_LIST, 0x0DCD},
            {Opcode.SMSG_TRANSFER_PENDING, 0xEBC},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x06A8},
            {Opcode.SMSG_UPDATE_COMBO_POINTS, 0x03E0},
            {Opcode.SMSG_UPDATE_OBJECT, 0x0120},
            {Opcode.SMSG_UPDATE_SERVER_PLAYER_POSITION, 0x71C},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x0AAC},
            {Opcode.SMSG_VOID_ITEM_SWAP_RESPONSE, 0x995},
            {Opcode.SMSG_VOID_STORAGE_CONTENTS, 0xAB1},
            {Opcode.SMSG_VOID_STORAGE_FAILED, 0x83D},
            {Opcode.SMSG_VOID_STORAGE_TRANSFER_CHANGES, 0x8F0},
            {Opcode.SMSG_VOID_TRANSFER_RESULT, 0x6D8},
            {Opcode.SMSG_WAIT_QUEUE_FINISH, 0x1F8},
            {Opcode.SMSG_WAIT_QUEUE_UPDATE, 0xE7C},
            {Opcode.SMSG_WARDEN_DATA, 0x6BD},
            {Opcode.SMSG_WARGAME_REQUEST_SENT, 0x759},
            {Opcode.SMSG_WEATHER, 0x0860},
            {Opcode.SMSG_WEEKLY_RESET_CURRENCY, 0x911},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x3D5},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE_UPDATE, 0x658},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x0D9},
            {Opcode.SMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x004D},
            {Opcode.SMSG_XP_GAIN_ABORTED, 0x398},
        };
    }
}
