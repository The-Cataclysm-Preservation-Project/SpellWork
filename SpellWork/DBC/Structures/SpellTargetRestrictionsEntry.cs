namespace SpellWork.DBC.Structures
{
    public sealed class SpellTargetRestrictionsEntry
    {
        public uint Id;
        public float ConeAngle;
        public uint MaxAffectedTargets;
        public uint MaxTargetLevel;
        public uint TargetCreatureType;
        public uint Targets;
    }
}
