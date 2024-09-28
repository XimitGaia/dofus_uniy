using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000933")]
public enum ShortcutBar
{
	[Token(Token = "0x4001FCD")]
	[OriginalName("GENERAL_SHORTCUT_BAR")]
	GeneralShortcutBar,
	[Token(Token = "0x4001FCE")]
	[OriginalName("SPELL_SHORTCUT_BAR")]
	SpellShortcutBar
}
