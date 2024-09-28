using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200093F")]
public enum MountCharacteristic
{
	[Token(Token = "0x4002015")]
	[OriginalName("ENERGY")]
	Energy,
	[Token(Token = "0x4002016")]
	[OriginalName("SERENITY")]
	Serenity,
	[Token(Token = "0x4002017")]
	[OriginalName("STAMINA")]
	Stamina,
	[Token(Token = "0x4002018")]
	[OriginalName("LOVE")]
	Love,
	[Token(Token = "0x4002019")]
	[OriginalName("MATURITY")]
	Maturity,
	[Token(Token = "0x400201A")]
	[OriginalName("TIREDNESS")]
	Tiredness,
	[Token(Token = "0x400201B")]
	[OriginalName("CARRIER")]
	Carrier,
	[Token(Token = "0x400201C")]
	[OriginalName("FERTILE")]
	Fertile,
	[Token(Token = "0x400201D")]
	[OriginalName("PREGNANT")]
	Pregnant
}
