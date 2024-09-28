using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200093B")]
public enum SocialGroupOperationResult
{
	[Token(Token = "0x4001FFC")]
	[OriginalName("SOCIAL_GROUP_OPERATION_OK")]
	SocialGroupOperationOk,
	[Token(Token = "0x4001FFD")]
	[OriginalName("SOCIAL_GROUP_ERROR_NAME_INVALID")]
	SocialGroupErrorNameInvalid,
	[Token(Token = "0x4001FFE")]
	[OriginalName("SOCIAL_GROUP_ERROR_ALREADY_IN_GROUP")]
	SocialGroupErrorAlreadyInGroup,
	[Token(Token = "0x4001FFF")]
	[OriginalName("SOCIAL_GROUP_ERROR_NAME_ALREADY_EXISTS")]
	SocialGroupErrorNameAlreadyExists,
	[Token(Token = "0x4002000")]
	[OriginalName("SOCIAL_GROUP_ERROR_LEAVE")]
	SocialGroupErrorLeave,
	[Token(Token = "0x4002001")]
	[OriginalName("SOCIAL_GROUP_ERROR_CANCEL")]
	SocialGroupErrorCancel,
	[Token(Token = "0x4002002")]
	[OriginalName("SOCIAL_GROUP_ERROR_REQUIREMENT_UNMET")]
	SocialGroupErrorRequirementUnmet,
	[Token(Token = "0x4002003")]
	[OriginalName("SOCIAL_GROUP_ERROR_EMBLEM_INVALID")]
	SocialGroupErrorEmblemInvalid,
	[Token(Token = "0x4002004")]
	[OriginalName("SOCIAL_GROUP_ERROR_TAG_INVALID")]
	SocialGroupErrorTagInvalid,
	[Token(Token = "0x4002005")]
	[OriginalName("SOCIAL_GROUP_ERROR_TAG_ALREADY_EXISTS")]
	SocialGroupErrorTagAlreadyExists,
	[Token(Token = "0x4002006")]
	[OriginalName("SOCIAL_GROUP_ERROR_UNKNOWN")]
	SocialGroupErrorUnknown
}
