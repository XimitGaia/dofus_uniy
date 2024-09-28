using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200093D")]
public enum SocialGroupInvitationState
{
	[Token(Token = "0x400200C")]
	[OriginalName("SOCIAL_GROUP_INVITATION_FAILED")]
	SocialGroupInvitationFailed,
	[Token(Token = "0x400200D")]
	[OriginalName("SOCIAL_GROUP_INVITATION_SENT")]
	SocialGroupInvitationSent,
	[Token(Token = "0x400200E")]
	[OriginalName("SOCIAL_GROUP_INVITATION_CANCELED")]
	SocialGroupInvitationCanceled,
	[Token(Token = "0x400200F")]
	[OriginalName("SOCIAL_GROUP_INVITATION_OK")]
	SocialGroupInvitationOk
}
