using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000940")]
public enum SpellModifierActionType
{
	[Token(Token = "0x400201F")]
	[OriginalName("ACTION_INVALID")]
	ActionInvalid,
	[Token(Token = "0x4002020")]
	[OriginalName("ACTION_BOOST")]
	ActionBoost,
	[Token(Token = "0x4002021")]
	[OriginalName("ACTION_REMOVE_BOOST")]
	ActionRemoveBoost,
	[Token(Token = "0x4002022")]
	[OriginalName("ACTION_SET")]
	ActionSet
}
