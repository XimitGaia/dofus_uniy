using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000921")]
public enum DelayedActionType
{
	[Token(Token = "0x4001F31")]
	[OriginalName("DISCONNECT")]
	Disconnect,
	[Token(Token = "0x4001F32")]
	[OriginalName("OBJECT_USE")]
	ObjectUse,
	[Token(Token = "0x4001F33")]
	[OriginalName("JOIN_CHARACTER")]
	JoinCharacter,
	[Token(Token = "0x4001F34")]
	[OriginalName("AGGRESSION_IMMUNE")]
	AggressionImmune
}
