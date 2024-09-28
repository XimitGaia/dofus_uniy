using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x2000558")]
public enum SequenceType
{
	[Token(Token = "0x4001252")]
	[OriginalName("SPELL")]
	Spell,
	[Token(Token = "0x4001253")]
	[OriginalName("WEAPON")]
	Weapon,
	[Token(Token = "0x4001254")]
	[OriginalName("GLYPH_TRAP")]
	GlyphTrap,
	[Token(Token = "0x4001255")]
	[OriginalName("TRIGGERED")]
	Triggered,
	[Token(Token = "0x4001256")]
	[OriginalName("MOVE")]
	Move,
	[Token(Token = "0x4001257")]
	[OriginalName("CHARACTER_DEATH")]
	CharacterDeath,
	[Token(Token = "0x4001258")]
	[OriginalName("TURN_START")]
	TurnStart,
	[Token(Token = "0x4001259")]
	[OriginalName("TURN_END")]
	TurnEnd,
	[Token(Token = "0x400125A")]
	[OriginalName("FIGHT_START")]
	FightStart
}
