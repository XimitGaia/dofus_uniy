using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x20000FD")]
public static class SpellReflection
{
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x0")]
	private static FileDescriptor descriptor;

	[Token(Token = "0x17000212")]
	public static FileDescriptor Descriptor
	{
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xA5CA30", Offset = "0xA5BE30", VA = "0x180A5CA30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0xA5B320", Offset = "0xA5A720", VA = "0x180A5B320")]
	static SpellReflection()
	{
	}
}
