using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x200004F")]
public static class TinselReflection
{
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x0")]
	private static FileDescriptor descriptor;

	[Token(Token = "0x1700008D")]
	public static FileDescriptor Descriptor
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x9426F0", Offset = "0x941AF0", VA = "0x1809426F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x941730", Offset = "0x940B30", VA = "0x180941730")]
	static TinselReflection()
	{
	}
}
