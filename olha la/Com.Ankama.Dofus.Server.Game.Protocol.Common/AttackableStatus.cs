using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000929")]
public enum AttackableStatus
{
	[Token(Token = "0x4001F5A")]
	[OriginalName("NON_ATTACKABLE")]
	NonAttackable,
	[Token(Token = "0x4001F5B")]
	[OriginalName("PVP_ENABLED_ATTACKABLE")]
	PvpEnabledAttackable,
	[Token(Token = "0x4001F5C")]
	[OriginalName("PVP_ENABLED_NON_ATTACKABLE")]
	PvpEnabledNonAttackable,
	[Token(Token = "0x4001F5D")]
	[OriginalName("AVA_ENABLED_ATTACKABLE")]
	AvaEnabledAttackable,
	[Token(Token = "0x4001F5E")]
	[OriginalName("AVA_ENABLED_NON_ATTACKABLE")]
	AvaEnabledNonAttackable,
	[Token(Token = "0x4001F5F")]
	[OriginalName("AVA_DISQUALIFIED")]
	AvaDisqualified,
	[Token(Token = "0x4001F60")]
	[OriginalName("AVA_PREQUALIFIED_ATTACKABLE")]
	AvaPrequalifiedAttackable
}
