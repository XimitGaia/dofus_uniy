using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000938")]
public enum SocialRecruitmentType
{
	[Token(Token = "0x4001FED")]
	[OriginalName("DISABLED")]
	Disabled,
	[Token(Token = "0x4001FEE")]
	[OriginalName("AUTOMATIC")]
	Automatic,
	[Token(Token = "0x4001FEF")]
	[OriginalName("MANUAL")]
	Manual
}
