using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientPetNameInvalid
    {
        public PetRenameData RenameData;
        public byte Result;
    }
}