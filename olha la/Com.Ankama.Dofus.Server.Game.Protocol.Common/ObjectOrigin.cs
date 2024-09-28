using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000937")]
public enum ObjectOrigin
{
	[Token(Token = "0x4001FEA")]
	[OriginalName("ORIGIN_UNDEFINED")]
	OriginUndefined,
	[Token(Token = "0x4001FEB")]
	[OriginalName("ORIGIN_QUEST")]
	OriginQuest
}
