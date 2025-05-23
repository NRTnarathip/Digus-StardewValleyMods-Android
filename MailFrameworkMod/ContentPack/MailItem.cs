﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewValley.Menus;

namespace MailFrameworkMod.ContentPack
{
    public class MailItem
    {
        [JsonIgnore] 
        public IContentPack ContentPack;
        public string Id;
        public string GroupId;
        public string Title;
        public string Text;
        public string Recipe;
        public List<Attachment> Attachments;
        public int? RandomlyChooseAttachment;
        public Dictionary<string, int> RandomlyChooseAttachmentPerGroup = new Dictionary<string, int>();
        public List<string> AttachmentGroupWithReplacement = new List<string>();
        public List<string> AdditionalMailReceived;
        public List<string> MailReceivedToRemove;
        public string LetterBG;
        public int WhichBG;
        public int? TextColor;
        public string CustomTextColorName;
        internal Color? CustomTextColor;
        public string UpperRightCloseButton;
        public ReplyConfig ReplyConfig;
        public bool Repeatable;
        public string Date;
        public List<int> Days;
        public List<string> Seasons;
        public string Weather;
        public int? HouseUpgradeLevel;
        public int? DeepestMineLevel;
        public int? CurrentMoney;
        public uint? TotalMoneyEarned;
        public List<FriendshipCondition> FriendshipConditions;
        public List<SkillCondition> SkillConditions;
        public List<StatsCondition> StatsConditions;
        public List<CollectionCondition> CollectionConditions;
        public SpecialDateCondition SpecialDateCondition;
        public string ExpandedPrecondition;
        public string[] ExpandedPreconditions;
        public string GameStateQuery;
        public double? RandomChance;
        public List<string> Buildings;
        public bool RequireAllBuildings;
        public List<string> MailReceived;
        public bool RequireAllMailReceived;
        public List<string> MailNotReceived;
        public List<string> EventsSeen;
        public bool RequireAllEventsSeen;
        public List<string> EventsNotSeen;
        public List<string> RecipeKnown;
        public bool RequireAllRecipeKnown;
        public List<string> RecipeNotKnown;
        public List<string> HasMods;
        public bool RequireAllMods;
        public bool AutoOpen;
        public bool KeepValid;
    }
}
