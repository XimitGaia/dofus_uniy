using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Ui;

[Token(Token = "0x2000017")]
public static class UiReflection
{
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x0")]
	private static FileDescriptor descriptor;

	[Token(Token = "0x17000023")]
	public static FileDescriptor Descriptor
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x9507A0", Offset = "0x94FBA0", VA = "0x1809507A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x950230", Offset = "0x94F630", VA = "0x180950230")]
	static UiReflection()
	{
	}
}
