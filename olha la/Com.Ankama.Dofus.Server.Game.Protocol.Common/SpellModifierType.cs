using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000941")]
public enum SpellModifierType
{
	[Token(Token = "0x4002024")]
	[OriginalName("INVALID_MODIFICATION")]
	InvalidModification,
	[Token(Token = "0x4002025")]
	[OriginalName("RANGE")]
	Range,
	[Token(Token = "0x4002026")]
	[OriginalName("DAMAGE")]
	Damage,
	[Token(Token = "0x4002027")]
	[OriginalName("BASE_DAMAGE")]
	BaseDamage,
	[Token(Token = "0x4002028")]
	[OriginalName("HEAL_BONUS")]
	HealBonus,
	[Token(Token = "0x4002029")]
	[OriginalName("AP_COST")]
	ApCost,
	[Token(Token = "0x400202A")]
	[OriginalName("CAST_INTERVAL")]
	CastInterval,
	[Token(Token = "0x400202B")]
	[OriginalName("CRITICAL_HIT_BONUS")]
	CriticalHitBonus,
	[Token(Token = "0x400202C")]
	[OriginalName("CAST_LINE")]
	CastLine,
	[Token(Token = "0x400202D")]
	[OriginalName("LOS")]
	Los,
	[Token(Token = "0x400202E")]
	[OriginalName("MAX_CAST_PER_TURN")]
	MaxCastPerTurn,
	[Token(Token = "0x400202F")]
	[OriginalName("MAX_CAST_PER_TARGET")]
	MaxCastPerTarget,
	[Token(Token = "0x4002030")]
	[OriginalName("RANGE_MAX")]
	RangeMax,
	[Token(Token = "0x4002031")]
	[OriginalName("RANGE_MIN")]
	RangeMin,
	[Token(Token = "0x4002032")]
	[OriginalName("OCCUPIED_CELL")]
	OccupiedCell,
	[Token(Token = "0x4002033")]
	[OriginalName("FREE_CELL")]
	FreeCell,
	[Token(Token = "0x4002034")]
	[OriginalName("VISIBLE_TARGET")]
	VisibleTarget,
	[Token(Token = "0x4002035")]
	[OriginalName("PORTAL_FREE_CELL")]
	PortalFreeCell,
	[Token(Token = "0x4002036")]
	[OriginalName("PORTAL_PROJECTION")]
	PortalProjection
}
