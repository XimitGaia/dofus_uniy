using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000932")]
public enum Team
{
	[Token(Token = "0x4001FC8")]
	[OriginalName("TEAM_CHALLENGER")]
	Challenger,
	[Token(Token = "0x4001FC9")]
	[OriginalName("TEAM_DEFENDER")]
	Defender,
	[Token(Token = "0x4001FCA")]
	[OriginalName("TEAM_SPECTATOR")]
	Spectator,
	[Token(Token = "0x4001FCB")]
	[OriginalName("TEAM_NEUTRAL")]
	Neutral
}
