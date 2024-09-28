using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200093A")]
public enum ServerType
{
	[Token(Token = "0x4001FF5")]
	[OriginalName("UNDEFINED")]
	Undefined,
	[Token(Token = "0x4001FF6")]
	[OriginalName("CLASSICAL")]
	Classical,
	[Token(Token = "0x4001FF7")]
	[OriginalName("KOLIZEUM")]
	Kolizeum,
	[Token(Token = "0x4001FF8")]
	[OriginalName("TOURNAMENT")]
	Tournament,
	[Token(Token = "0x4001FF9")]
	[OriginalName("EPIC")]
	Epic,
	[Token(Token = "0x4001FFA")]
	[OriginalName("TEMPORIS")]
	Temporis
}
