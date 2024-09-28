using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x200084C")]
public enum Channel
{
	[Token(Token = "0x4001C91")]
	[OriginalName("GLOBAL")]
	Global = 0,
	[Token(Token = "0x4001C92")]
	[OriginalName("TEAM")]
	Team = 1,
	[Token(Token = "0x4001C93")]
	[OriginalName("GUILD")]
	Guild = 2,
	[Token(Token = "0x4001C94")]
	[OriginalName("ALLIANCE")]
	Alliance = 3,
	[Token(Token = "0x4001C95")]
	[OriginalName("PARTY")]
	Party = 4,
	[Token(Token = "0x4001C96")]
	[OriginalName("SALES")]
	Sales = 5,
	[Token(Token = "0x4001C97")]
	[OriginalName("SEEK")]
	Seek = 6,
	[Token(Token = "0x4001C98")]
	[OriginalName("NOOB")]
	Noob = 7,
	[Token(Token = "0x4001C99")]
	[OriginalName("ADMIN")]
	Admin = 8,
	[Token(Token = "0x4001C9A")]
	[OriginalName("ARENA")]
	Arena = 9,
	[Token(Token = "0x4001C9B")]
	[OriginalName("PRIVATE")]
	Private = 10,
	[Token(Token = "0x4001C9C")]
	[OriginalName("INFO")]
	Info = 12,
	[Token(Token = "0x4001C9D")]
	[OriginalName("FIGHT_LOG")]
	FightLog = 13,
	[Token(Token = "0x4001C9E")]
	[OriginalName("ADS")]
	Ads = 14,
	[Token(Token = "0x4001C9F")]
	[OriginalName("EVENT")]
	Event = 15,
	[Token(Token = "0x4001CA0")]
	[OriginalName("EXCHANGE")]
	Exchange = 16
}
