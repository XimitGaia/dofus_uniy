using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000258")]
public enum PartyMemberInFightCause
{
	[Token(Token = "0x40007EB")]
	[OriginalName("UNKNOWN")]
	Unknown,
	[Token(Token = "0x40007EC")]
	[OriginalName("MONSTER_ATTACK")]
	MonsterAttack,
	[Token(Token = "0x40007ED")]
	[OriginalName("PLAYER_ATTACK")]
	PlayerAttack,
	[Token(Token = "0x40007EE")]
	[OriginalName("MEMBER_ATTACKED_PLAYERS")]
	MemberAttackedPlayers,
	[Token(Token = "0x40007EF")]
	[OriginalName("MEMBER_CHALLENGE")]
	MemberChallenge
}
