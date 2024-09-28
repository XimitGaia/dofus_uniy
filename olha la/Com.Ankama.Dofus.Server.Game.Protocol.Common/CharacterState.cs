using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000925")]
public enum CharacterState
{
	[Token(Token = "0x4001F44")]
	[OriginalName("NOT_CONNECTED")]
	NotConnected,
	[Token(Token = "0x4001F45")]
	[OriginalName("IN_ROLE_PLAY")]
	InRolePlay,
	[Token(Token = "0x4001F46")]
	[OriginalName("IN_FIGHT")]
	InFight,
	[Token(Token = "0x4001F47")]
	[OriginalName("UNKNOWN_STATE")]
	UnknownState
}
