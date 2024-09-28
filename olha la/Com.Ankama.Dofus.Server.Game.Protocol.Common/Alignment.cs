using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000926")]
public enum Alignment
{
	[Token(Token = "0x4001F49")]
	[OriginalName("UNKNOWN")]
	Unknown,
	[Token(Token = "0x4001F4A")]
	[OriginalName("WITHOUT")]
	Without,
	[Token(Token = "0x4001F4B")]
	[OriginalName("NEUTRAL")]
	Neutral,
	[Token(Token = "0x4001F4C")]
	[OriginalName("ANGEL")]
	Angel,
	[Token(Token = "0x4001F4D")]
	[OriginalName("EVIL")]
	Evil
}
