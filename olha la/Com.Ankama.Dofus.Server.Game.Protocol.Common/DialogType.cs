using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200092B")]
public enum DialogType
{
	[Token(Token = "0x4001F76")]
	[OriginalName("DIALOG_BOOK")]
	DialogBook,
	[Token(Token = "0x4001F77")]
	[OriginalName("DIALOG_DIALOG")]
	DialogDialog,
	[Token(Token = "0x4001F78")]
	[OriginalName("DIALOG_LOCKABLE")]
	DialogLockable,
	[Token(Token = "0x4001F79")]
	[OriginalName("DIALOG_PURCHASABLE")]
	DialogPurchasable,
	[Token(Token = "0x4001F7A")]
	[OriginalName("DIALOG_GUILD_INVITATION")]
	DialogGuildInvitation,
	[Token(Token = "0x4001F7B")]
	[OriginalName("DIALOG_GUILD_CREATE")]
	DialogGuildCreate,
	[Token(Token = "0x4001F7C")]
	[OriginalName("DIALOG_GUILD_RENAME")]
	DialogGuildRename,
	[Token(Token = "0x4001F7D")]
	[OriginalName("DIALOG_MARRIAGE")]
	DialogMarriage,
	[Token(Token = "0x4001F7E")]
	[OriginalName("DIALOG_DUNGEON_MEETING")]
	DialogDungeonMeeting,
	[Token(Token = "0x4001F7F")]
	[OriginalName("DIALOG_SPELL_FORGET")]
	DialogSpellForget,
	[Token(Token = "0x4001F80")]
	[OriginalName("DIALOG_TELEPORTER")]
	DialogTeleporter,
	[Token(Token = "0x4001F81")]
	[OriginalName("DIALOG_EXCHANGE")]
	DialogExchange,
	[Token(Token = "0x4001F82")]
	[OriginalName("DIALOG_ALLIANCE_INVITATION")]
	DialogAllianceInvitation,
	[Token(Token = "0x4001F83")]
	[OriginalName("DIALOG_ALLIANCE_CREATE")]
	DialogAllianceCreate,
	[Token(Token = "0x4001F84")]
	[OriginalName("DIALOG_ALLIANCE_RENAME")]
	DialogAllianceRename,
	[Token(Token = "0x4001F85")]
	[OriginalName("DIALOG_HAVENBAG_MEETING")]
	DialogHavenbagMeeting
}
