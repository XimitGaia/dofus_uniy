using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200092F")]
public enum FightOption
{
	[Token(Token = "0x4001FB9")]
	[OriginalName("FIGHT_OPTION_SET_SECRET")]
	SetSecret,
	[Token(Token = "0x4001FBA")]
	[OriginalName("FIGHT_OPTION_SET_TO_PARTY_ONLY")]
	SetToPartyOnly,
	[Token(Token = "0x4001FBB")]
	[OriginalName("FIGHT_OPTION_SET_CLOSED")]
	SetClosed,
	[Token(Token = "0x4001FBC")]
	[OriginalName("FIGHT_OPTION_ASK_FOR_HELP")]
	AskForHelp
}
