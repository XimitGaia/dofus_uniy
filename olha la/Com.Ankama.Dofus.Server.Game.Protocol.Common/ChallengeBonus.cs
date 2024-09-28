using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000924")]
public enum ChallengeBonus
{
	[Token(Token = "0x4001F41")]
	[OriginalName("CHALLENGE_EXPERIENCE_BONUS")]
	ChallengeExperienceBonus,
	[Token(Token = "0x4001F42")]
	[OriginalName("CHALLENGE_DROP_BONUS")]
	ChallengeDropBonus
}
