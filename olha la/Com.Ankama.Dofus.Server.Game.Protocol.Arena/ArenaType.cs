using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000B89")]
public enum ArenaType
{
	[Token(Token = "0x4002B0C")]
	[OriginalName("ONE_VS_ONE")]
	OneVsOne,
	[Token(Token = "0x4002B0D")]
	[OriginalName("TWO_VS_TWO")]
	TwoVsTwo,
	[Token(Token = "0x4002B0E")]
	[OriginalName("THREE_VS_THREE")]
	ThreeVsThree
}
