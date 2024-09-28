using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000066")]
public enum Teleporter
{
	[Token(Token = "0x4000145")]
	[OriginalName("TELEPORTER_ZAAP")]
	Zaap,
	[Token(Token = "0x4000146")]
	[OriginalName("TELEPORTER_SUBWAY")]
	Subway,
	[Token(Token = "0x4000147")]
	[OriginalName("TELEPORTER_PRISM")]
	Prism,
	[Token(Token = "0x4000148")]
	[OriginalName("TELEPORTER_HAVEN_BAG")]
	HavenBag,
	[Token(Token = "0x4000149")]
	[OriginalName("TELEPORTER_ANOMALY")]
	Anomaly
}
