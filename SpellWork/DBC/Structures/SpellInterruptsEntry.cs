using DBFilesClient.NET;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellInterruptsEntry
    {
        public uint ID;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] AuraInterruptFlags;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] ChannelInterruptFlags;
        public uint InterruptFlags;
    }
}
