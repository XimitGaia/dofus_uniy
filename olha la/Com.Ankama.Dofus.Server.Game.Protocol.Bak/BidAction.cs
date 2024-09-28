using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B5B")]
public enum BidAction
{
	[Token(Token = "0x4002A74")]
	[OriginalName("BID_INVALID_ACTION")]
	BidInvalidAction,
	[Token(Token = "0x4002A75")]
	[OriginalName("BID_CONSUME_BUFF")]
	BidConsumeBuff,
	[Token(Token = "0x4002A76")]
	[OriginalName("BID_CANCEL")]
	BidCancel,
	[Token(Token = "0x4002A77")]
	[OriginalName("BID_CREATE_KAMA")]
	BidCreateKama,
	[Token(Token = "0x4002A78")]
	[OriginalName("BID_CREATE_OGRINE")]
	BidCreateOgrine,
	[Token(Token = "0x4002A79")]
	[OriginalName("BID_BUY_KAMA")]
	BidBuyKama,
	[Token(Token = "0x4002A7A")]
	[OriginalName("BID_BUY_OGRINE")]
	BidBuyOgrine
}
