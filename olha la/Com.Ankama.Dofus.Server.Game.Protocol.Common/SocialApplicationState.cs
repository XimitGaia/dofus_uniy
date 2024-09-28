using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000939")]
public enum SocialApplicationState
{
	[Token(Token = "0x4001FF1")]
	[OriginalName("APPLICATION_ADDED")]
	ApplicationAdded,
	[Token(Token = "0x4001FF2")]
	[OriginalName("APPLICATION_DELETED")]
	ApplicationDeleted,
	[Token(Token = "0x4001FF3")]
	[OriginalName("APPLICATION_UPDATED")]
	ApplicationUpdated
}
