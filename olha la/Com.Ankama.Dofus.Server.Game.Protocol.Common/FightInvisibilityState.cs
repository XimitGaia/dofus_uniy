using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000931")]
public enum FightInvisibilityState
{
	[Token(Token = "0x4001FC4")]
	[OriginalName("INVISIBLE")]
	Invisible,
	[Token(Token = "0x4001FC5")]
	[OriginalName("DETECTED")]
	Detected,
	[Token(Token = "0x4001FC6")]
	[OriginalName("VISIBLE")]
	Visible
}
