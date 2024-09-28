using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200093C")]
public enum SocialNoticeError
{
	[Token(Token = "0x4002008")]
	[OriginalName("SOCIAL_NOTICE_UNKNOWN_ERROR")]
	SocialNoticeUnknownError,
	[Token(Token = "0x4002009")]
	[OriginalName("SOCIAL_NOTICE_INVALID_RIGHTS")]
	SocialNoticeInvalidRights,
	[Token(Token = "0x400200A")]
	[OriginalName("SOCIAL_NOTICE_COOLDOWN")]
	SocialNoticeCooldown
}
