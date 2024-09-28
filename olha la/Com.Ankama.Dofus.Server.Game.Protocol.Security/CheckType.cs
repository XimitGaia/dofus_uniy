using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Security;

[Token(Token = "0x2000157")]
public enum CheckType
{
	[Token(Token = "0x4000492")]
	[OriginalName("LENGTH")]
	Length,
	[Token(Token = "0x4000493")]
	[OriginalName("HASH_SUM")]
	HashSum
}
