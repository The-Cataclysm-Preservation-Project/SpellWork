using System;
using System.Linq;
using DBFilesClient.NET;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellEffectEntry
    {
        public uint ID;
        public uint Effect;
        public float EffectAmplitude;
        public uint EffectAura;
        public uint EffectAuraPeriod;
        public int EffectBasePoints;
        public float EffectBonusCoefficient;
        public float EffectChainAmplitude;
        public uint EffectChainTargets;
        public int EffectDieSides;
        public uint EffectItemType;
        public uint EffectMechanic;
        public int EffectMiscValue;
        public int EffectMiscValueB;
        public float EffectPointsPerResource;
        public uint EffectRadiusIndex;
        public uint EffectRadiusMaxIndex;
        public float EffectRealPointsPerLevel;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        public uint[] EffectSpellClassMask;
        public uint EffectTriggerSpell;
        public uint EffectImplicitTargetA;
        public uint EffectImplicitTargetB;
        public uint SpellID;
        public uint EffectIndex;
        public uint EffectAttributes;

        [StoragePresence(StoragePresenceOption.Exclude)]
        public float ScalingMultiplier;
        [StoragePresence(StoragePresenceOption.Exclude)]
        public float RandomPointsScalingMultiplier;
        [StoragePresence(StoragePresenceOption.Exclude)]
        public float ComboPointsScalingMultiplier;

        public string MaxRadius
        {
            get
            {
                if (EffectRadiusMaxIndex == 0 || !DBC.SpellRadius.ContainsKey(EffectRadiusMaxIndex))
                    return String.Empty;

                return String.Format("Max Radius (Id {0}) {1:F}", EffectRadiusMaxIndex, DBC.SpellRadius[EffectRadiusMaxIndex].Radius);
            }
        }

        public string Radius
        {
            get
            {
                if (EffectRadiusIndex == 0 || !DBC.SpellRadius.ContainsKey(EffectRadiusIndex))
                    return String.Empty;

                return String.Format("Radius (Id {0}) {1:F}", EffectRadiusIndex, DBC.SpellRadius[EffectRadiusIndex].Radius);
            }
        }
    }
}
