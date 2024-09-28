using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Atlas;

[Token(Token = "0x2000B7D")]
public enum CompassType
{
	[Token(Token = "0x4002AE3")]
	[OriginalName("SIMPLE")]
	Simple,
	[Token(Token = "0x4002AE4")]
	[OriginalName("SPOUSE")]
	Spouse,
	[Token(Token = "0x4002AE5")]
	[OriginalName("PARTY")]
	Party,
	[Token(Token = "0x4002AE6")]
	[OriginalName("PVP_SEEK")]
	PvpSeek,
	[Token(Token = "0x4002AE7")]
	[OriginalName("QUEST")]
	Quest
}
