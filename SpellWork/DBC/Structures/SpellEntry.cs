using System.Linq;
using DBFilesClient.NET;
using System.Text;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellEntry
    {
        public uint Id;
        public uint Attributes;
        public uint AttributesEx;
        public uint AttributesEx2;
        public uint AttributesEx3;
        public uint AttributesEx4;
        public uint AttributesEx5;
        public uint AttributesEx6;
        public uint AttributesEx7;
        public uint AttributesEx8;
        public uint AttributesEx9;
        public uint AttributesEx10;
        public uint CastingTimeIndex;
        public uint DurationIndex;
        public uint PowerType;
        public uint RangeIndex;
        public float Speed;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] SpellVisualID;
        public uint SpellIconID;
        public uint ActiveIconID;
        public string Name;
        public string NameSubtext;
        public string Description;
        public string AuraDescription;
        public uint SchoolMask;
        public uint RuneCostID;
        public uint SpellMissileID;
        public uint SpellDescriptionVariableID;
        public uint Difficulty;
        public float SpellCoef;
        public uint ScalingID;
        public uint AuraOptionsID;
        public uint AuraRestrictionsID;
        public uint CastingRequirementsID;
        public uint CategoriesID;
        public uint ClassOptionsID;
        public uint CooldownsID;
        public uint Unknown4;
        public uint EquippedItemsID;
        public uint InterruptsID;
        public uint LevelsID;
        public uint PowerDisplayID;
        public uint ReagentsID;
        public uint ShapeshiftID;
        public uint TargetRestrictionsID;
        public uint TotemsID;
        public uint RequiredProjectID;

        public SpellAuraOptionsEntry AuraOptions
        {
            get { return AuraOptionsID != 0 && DBC.SpellAuraOptions.ContainsKey(AuraOptionsID) ? DBC.SpellAuraOptions[AuraOptionsID] : null; }
        }

        public SpellAuraRestrictionsEntry AuraRestrictions
        {
            get { return AuraRestrictionsID != 0 && DBC.SpellAuraRestrictions.ContainsKey(AuraRestrictionsID) ? DBC.SpellAuraRestrictions[AuraRestrictionsID] : null; }
        }

        public SpellCastingRequirementsEntry CastingRequirements
        {
            get { return CastingRequirementsID != 0 && DBC.SpellCastingRequirements.ContainsKey(CastingRequirementsID) ? DBC.SpellCastingRequirements[CastingRequirementsID] : null; }
        }

        public SpellCategoriesEntry Category
        {
            get { return CategoriesID != 0 && DBC.SpellCategories.ContainsKey(CategoriesID) ? DBC.SpellCategories[CategoriesID] : null; }
        }

        public SpellClassOptionsEntry ClassOptions
        {
            get { return ClassOptionsID != 0 && DBC.SpellClassOptions.ContainsKey(ClassOptionsID) ? DBC.SpellClassOptions[ClassOptionsID] : null; }
        }

        public SpellCooldownsEntry Cooldowns
        {
            get { return CooldownsID != 0 && DBC.SpellCooldowns.ContainsKey(CooldownsID) ? DBC.SpellCooldowns[CooldownsID] : null; }
        }

        public SpellEquippedItemsEntry EquippedItems
        {
            get { return EquippedItemsID != 0 && DBC.SpellEquippedItems.ContainsKey(EquippedItemsID) ? DBC.SpellEquippedItems[EquippedItemsID] : null; }
        }

        public SpellInterruptsEntry Interrupts
        {
            get { return InterruptsID != 0 && DBC.SpellInterrupts.ContainsKey(InterruptsID) ? DBC.SpellInterrupts[InterruptsID] : null; }
        }

        public SpellLevelsEntry Levels
        {
            get { return LevelsID != 0 && DBC.SpellLevels.ContainsKey(LevelsID) ? DBC.SpellLevels[LevelsID] : null; }
        }

        public SpellPowerEntry Power
        {
            get { return PowerDisplayID != 0 && DBC.SpellPower.ContainsKey(PowerDisplayID) ? DBC.SpellPower[PowerDisplayID] : null; }
        }

        public SpellReagentsEntry Reagents
        {
            get { return ReagentsID != 0 && DBC.SpellReagents.ContainsKey(ReagentsID) ? DBC.SpellReagents[ReagentsID] : null; }
        }

        public SpellScalingEntry Scaling
        {
            get { return ScalingID != 0 && DBC.SpellScaling.ContainsKey(ScalingID) ? DBC.SpellScaling[ScalingID] : null; }
        }

        public SpellShapeshiftEntry Shapeshift
        {
            get { return ShapeshiftID != 0 && DBC.SpellShapeshift.ContainsKey(ShapeshiftID) ? DBC.SpellShapeshift[ShapeshiftID] : null; }
        }

        public SpellTargetRestrictionsEntry TargetRestrictions
        {
            get { return TargetRestrictionsID != 0 && DBC.SpellTargetRestrictions.ContainsKey(TargetRestrictionsID) ? DBC.SpellTargetRestrictions[TargetRestrictionsID] : null; }
        }

        public SpellTotemsEntry Totems
        {
            get { return TotemsID != 0 && DBC.SpellTotems.ContainsKey(TotemsID) ? DBC.SpellTotems[TotemsID] : null; }
        }
    }
}
