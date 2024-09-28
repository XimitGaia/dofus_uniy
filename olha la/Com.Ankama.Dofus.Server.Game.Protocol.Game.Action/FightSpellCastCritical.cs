using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x2000557")]
public enum FightSpellCastCritical
{
	[Token(Token = "0x400124E")]
	[OriginalName("NORMAL")]
	Normal,
	[Token(Token = "0x400124F")]
	[OriginalName("CRITICAL_HIT")]
	CriticalHit,
	[Token(Token = "0x4001250")]
	[OriginalName("CRITICAL_FAIL")]
	CriticalFail
}
