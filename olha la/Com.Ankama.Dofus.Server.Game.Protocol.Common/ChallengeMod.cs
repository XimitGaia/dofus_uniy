using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000923")]
public enum ChallengeMod
{
	[Token(Token = "0x4001F3E")]
	[OriginalName("CHALLENGE_CHOICE")]
	ChallengeChoice,
	[Token(Token = "0x4001F3F")]
	[OriginalName("CHALLENGE_RANDOM")]
	ChallengeRandom
}
