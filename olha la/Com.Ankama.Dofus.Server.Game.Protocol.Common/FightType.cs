using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200092D")]
public enum FightType
{
	[Token(Token = "0x4001FA6")]
	[OriginalName("FIGHT_TYPE_CHALLENGE")]
	Challenge,
	[Token(Token = "0x4001FA7")]
	[OriginalName("FIGHT_TYPE_AGGRESSION")]
	Aggression,
	[Token(Token = "0x4001FA8")]
	[OriginalName("FIGHT_TYPE_PvMA")]
	PvMa,
	[Token(Token = "0x4001FA9")]
	[OriginalName("FIGHT_TYPE_MXvM")]
	MxvM,
	[Token(Token = "0x4001FAA")]
	[OriginalName("FIGHT_TYPE_PvM")]
	PvM,
	[Token(Token = "0x4001FAB")]
	[OriginalName("FIGHT_TYPE_PvT")]
	PvT,
	[Token(Token = "0x4001FAC")]
	[OriginalName("FIGHT_TYPE_PvMU")]
	PvMu,
	[Token(Token = "0x4001FAD")]
	[OriginalName("FIGHT_TYPE_PVP_ARENA")]
	PvpArena,
	[Token(Token = "0x4001FAE")]
	[OriginalName("FIGHT_TYPE_KOH")]
	Koh,
	[Token(Token = "0x4001FAF")]
	[OriginalName("FIGHT_TYPE_PvPr")]
	PvPr,
	[Token(Token = "0x4001FB0")]
	[OriginalName("FIGHT_TYPE_BREACH")]
	Breach
}
