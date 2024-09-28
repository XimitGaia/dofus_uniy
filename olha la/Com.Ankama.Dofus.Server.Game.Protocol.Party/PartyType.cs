using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000259")]
public enum PartyType
{
	[Token(Token = "0x40007F1")]
	[OriginalName("UNDEFINED")]
	Undefined,
	[Token(Token = "0x40007F2")]
	[OriginalName("CLASSICAL")]
	Classical,
	[Token(Token = "0x40007F3")]
	[OriginalName("ARENA")]
	Arena
}
