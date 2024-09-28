using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x200001D")]
public enum TreasureHuntType
{
	[Token(Token = "0x400005C")]
	[OriginalName("CLASSIC")]
	Classic,
	[Token(Token = "0x400005D")]
	[OriginalName("PORTAL")]
	Portal,
	[Token(Token = "0x400005E")]
	[OriginalName("LEGENDARY")]
	Legendary
}
