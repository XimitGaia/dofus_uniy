using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000928")]
public enum Hierarchy
{
	[Token(Token = "0x4001F52")]
	[OriginalName("ROLE_UNAVAILABLE")]
	RoleUnavailable,
	[Token(Token = "0x4001F53")]
	[OriginalName("ROLE_PLAYER")]
	RolePlayer,
	[Token(Token = "0x4001F54")]
	[OriginalName("ROLE_MODERATOR")]
	RoleModerator,
	[Token(Token = "0x4001F55")]
	[OriginalName("ROLE_GAME_MASTER_PADAWAN")]
	RoleGameMasterPadawan,
	[Token(Token = "0x4001F56")]
	[OriginalName("ROLE_GAME_MASTER")]
	RoleGameMaster,
	[Token(Token = "0x4001F57")]
	[OriginalName("ROLE_ADMIN")]
	RoleAdmin,
	[Token(Token = "0x4001F58")]
	[OriginalName("ROLE_UNKNOWN_SPECIAL_USER")]
	RoleUnknownSpecialUser
}
