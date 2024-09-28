using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000930")]
public enum FightOutcome
{
	[Token(Token = "0x4001FBE")]
	[OriginalName("RESULT_LOST")]
	ResultLost,
	[Token(Token = "0x4001FBF")]
	[OriginalName("RESULT_DRAW")]
	ResultDraw,
	[Token(Token = "0x4001FC0")]
	[OriginalName("RESULT_VICTORY")]
	ResultVictory,
	[Token(Token = "0x4001FC1")]
	[OriginalName("RESULT_TAX")]
	ResultTax,
	[Token(Token = "0x4001FC2")]
	[OriginalName("RESULT_DEFENDER_GROUP")]
	ResultDefenderGroup
}
