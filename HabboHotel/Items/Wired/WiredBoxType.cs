﻿namespace Cloud.HabboHotel.Items.Wired
{
    public enum WiredBoxType
    {
        None,
        TriggerRoomEnter,
        TriggerUserSays,
        TriggerRepeat,
        TriggerLongRepeat,
        TriggerStateChanges,
        TriggerWalkOnFurni,
        TriggerWalkOffFurni,
        TriggerGameStarts,
        TriggerGameEnds,
        TriggerUserFurniCollision,
        TriggerUserSaysCommand,

        EffectShowMessage,
        EffectTeleportToFurni,
        EffectToggleFurniState,
        EffectKickUser,
        EffectMatchPosition,
        EffectMoveAndRotate,
        EffectMoveFurniToNearestUser,
        EffectMoveFurniFromNearestUser,
        EffectMuteTriggerer,
        EffectGiveReward,
        EffectExecuteWiredStacks,
        EffectAddScore,

        EffectTeleportBotToFurniBox,
        EffectBotChangesClothesBox,
        EffectBotMovesToFurniBox,
        EffectBotCommunicatesToAllBox,
        EffectBotCommunicatesToUserBox,
        EffectBotFollowsUserBox,
        EffectBotGivesHanditemBox,

        EffectAddActorToTeam,
        EffectRemoveActorFromTeam,
        EffectSetRollerSpeed,
        EffectRegenerateMaps,
        EffectGiveUserBadge,

        EffectEnableUserBox,
        EffectDanceUserBox,
        EffectGiveUserCreditsBox,
        EffectGiveUserDucketsBox,
        EffectGiveUserDiamondsBox,
        EffectHandUserItemBox,
        EffectFreezeUserBox,
        EffectFixRoomBox,
        EffectFastWalkUserBox,

        ConditionFurniHasUsers,
        ConditionFurniHasFurni,
        ConditionTriggererOnFurni,
        ConditionIsGroupMember,
        ConditionIsNotGroupMember,
        ConditionTriggererNotOnFurni,
        ConditionFurniHasNoUsers,
        ConditionIsWearingBadge,
        ConditionIsWearingFX,
        ConditionIsNotWearingBadge,
        ConditionIsNotWearingFX,
        ConditionMatchStateAndPosition,
        ConditionDontMatchStateAndPosition,
        ConditionUserCountInRoom,
        ConditionUserCountDoesntInRoom,
        ConditionFurniTypeMatches,
        ConditionFurniTypeDoesntMatch,
        ConditionFurniHasNoFurni,
        ConditionActorHasHandItemBox,
        ConditionActorIsInTeamBox,
        AddonRandomEffect,
        HighscoreClassicAlltime
    }
}