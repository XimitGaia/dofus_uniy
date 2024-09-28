using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200092E")]
public enum TeamType
{
	[Token(Token = "0x4001FB2")]
	[OriginalName("TEAM_TYPE_PLAYER")]
	Player,
	[Token(Token = "0x4001FB3")]
	[OriginalName("TEAM_TYPE_MONSTER")]
	Monster,
	[Token(Token = "0x4001FB4")]
	[OriginalName("TEAM_TYPE_MUTANT")]
	Mutant,
	[Token(Token = "0x4001FB5")]
	[OriginalName("TEAM_TYPE_TAX_COLLECTOR")]
	TaxCollector,
	[Token(Token = "0x4001FB6")]
	[OriginalName("TEAM_TYPE_BAD_PLAYER")]
	BadPlayer,
	[Token(Token = "0x4001FB7")]
	[OriginalName("TEAM_TYPE_PRISM")]
	Prism
}
