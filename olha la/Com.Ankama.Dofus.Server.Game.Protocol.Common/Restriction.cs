using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200092A")]
public enum Restriction
{
	[Token(Token = "0x4001F62")]
	[OriginalName("CANNOT_BE_ATTACKED")]
	CannotBeAttacked,
	[Token(Token = "0x4001F63")]
	[OriginalName("CANNOT_BE_CHALLENGED")]
	CannotBeChallenged,
	[Token(Token = "0x4001F64")]
	[OriginalName("CANNOT_TRADE")]
	CannotTrade,
	[Token(Token = "0x4001F65")]
	[OriginalName("CANNOT_BE_ATTACKED_BY_MUTANT")]
	CannotBeAttackedByMutant,
	[Token(Token = "0x4001F66")]
	[OriginalName("CANNOT_RUN")]
	CannotRun,
	[Token(Token = "0x4001F67")]
	[OriginalName("FORCE_SLOW_WALK")]
	ForceSlowWalk,
	[Token(Token = "0x4001F68")]
	[OriginalName("CANNOT_MINIMIZE")]
	CannotMinimize,
	[Token(Token = "0x4001F69")]
	[OriginalName("CANNOT_MOVE")]
	CannotMove,
	[Token(Token = "0x4001F6A")]
	[OriginalName("CANNOT_ATTACK")]
	CannotAttack,
	[Token(Token = "0x4001F6B")]
	[OriginalName("CANNOT_CHALLENGE")]
	CannotChallenge,
	[Token(Token = "0x4001F6C")]
	[OriginalName("CANNOT_EXCHANGE")]
	CannotExchange,
	[Token(Token = "0x4001F6D")]
	[OriginalName("CANNOT_ATTACK_AS_MUTANT")]
	CannotAttackAsMutant,
	[Token(Token = "0x4001F6E")]
	[OriginalName("CANNOT_CHAT")]
	CannotChat,
	[Token(Token = "0x4001F6F")]
	[OriginalName("CANNOT_USE_OBJECT")]
	CannotUseObject,
	[Token(Token = "0x4001F70")]
	[OriginalName("CANNOT_USE_TAX_COLLECTOR")]
	CannotUseTaxCollector,
	[Token(Token = "0x4001F71")]
	[OriginalName("CANNOT_USE_INTERACTIVE")]
	CannotUseInteractive,
	[Token(Token = "0x4001F72")]
	[OriginalName("CANNOT_SPEAK_TO_NPC")]
	CannotSpeakToNpc,
	[Token(Token = "0x4001F73")]
	[OriginalName("CANNOT_CHANGE_ZONE")]
	CannotChangeZone,
	[Token(Token = "0x4001F74")]
	[OriginalName("CANNOT_ATTACK_MONSTER")]
	CannotAttackMonster
}
