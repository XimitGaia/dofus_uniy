using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200093E")]
public enum TaxCollectorState
{
	[Token(Token = "0x4002011")]
	[OriginalName("STATE_COLLECTING")]
	StateCollecting,
	[Token(Token = "0x4002012")]
	[OriginalName("STATE_WAITING_FOR_HELP")]
	StateWaitingForHelp,
	[Token(Token = "0x4002013")]
	[OriginalName("STATE_FIGHTING")]
	StateFighting
}
