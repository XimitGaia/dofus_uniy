using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000922")]
public enum AllianceRelation
{
	[Token(Token = "0x4001F36")]
	[OriginalName("ALLIANCE_RELATION_NONE")]
	None,
	[Token(Token = "0x4001F37")]
	[OriginalName("ALLIANCE_RELATION_MINE")]
	Mine,
	[Token(Token = "0x4001F38")]
	[OriginalName("ALLIANCE_RELATION_DEF")]
	Def,
	[Token(Token = "0x4001F39")]
	[OriginalName("ALLIANCE_RELATION_ATT")]
	Att,
	[Token(Token = "0x4001F3A")]
	[OriginalName("ALLIANCE_RELATION_NEUTRAL")]
	Neutral,
	[Token(Token = "0x4001F3B")]
	[OriginalName("ALLIANCE_RELATION_ALLY")]
	Ally,
	[Token(Token = "0x4001F3C")]
	[OriginalName("ALLIANCE_RELATION_ENEMY")]
	Enemy
}
