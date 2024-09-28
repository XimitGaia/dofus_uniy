using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000934")]
public enum PresetType
{
	[Token(Token = "0x4001FD0")]
	[OriginalName("CHARACTER")]
	Character,
	[Token(Token = "0x4001FD1")]
	[OriginalName("FORGETTABLE_SPELL")]
	ForgettableSpell
}
