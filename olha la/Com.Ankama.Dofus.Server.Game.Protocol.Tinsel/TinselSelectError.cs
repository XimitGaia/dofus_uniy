using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x2000050")]
public enum TinselSelectError
{
	[Token(Token = "0x400010C")]
	[OriginalName("UNDEFINED")]
	Undefined,
	[Token(Token = "0x400010D")]
	[OriginalName("INVALID")]
	Invalid,
	[Token(Token = "0x400010E")]
	[OriginalName("ALREADY")]
	Already
}
