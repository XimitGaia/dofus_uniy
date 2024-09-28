using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000942")]
public enum RealEstateOrder
{
	[Token(Token = "0x4002038")]
	[OriginalName("PRICE_ASC")]
	PriceAsc,
	[Token(Token = "0x4002039")]
	[OriginalName("PRICE_DSC")]
	PriceDsc
}
