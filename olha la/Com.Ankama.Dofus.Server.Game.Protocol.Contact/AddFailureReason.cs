using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007A2")]
public enum AddFailureReason
{
	[Token(Token = "0x4001A90")]
	[OriginalName("UNKNOWN")]
	Unknown,
	[Token(Token = "0x4001A91")]
	[OriginalName("OVER_QUOTA")]
	OverQuota,
	[Token(Token = "0x4001A92")]
	[OriginalName("NOT_FOUND")]
	NotFound,
	[Token(Token = "0x4001A93")]
	[OriginalName("EGOCENTRIC")]
	Egocentric,
	[Token(Token = "0x4001A94")]
	[OriginalName("IS_DOUBLE")]
	IsDouble,
	[Token(Token = "0x4001A95")]
	[OriginalName("IS_CONFLICTING_DOUBLE")]
	IsConflictingDouble
}
