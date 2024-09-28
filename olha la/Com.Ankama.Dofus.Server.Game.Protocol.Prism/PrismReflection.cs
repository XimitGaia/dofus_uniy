using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001B2")]
public static class PrismReflection
{
	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x0")]
	private static FileDescriptor descriptor;

	[Token(Token = "0x170003AC")]
	public static FileDescriptor Descriptor
	{
		[Token(Token = "0x6001136")]
		[Address(RVA = "0xCD1980", Offset = "0xCD0D80", VA = "0x180CD1980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001137")]
	[Address(RVA = "0xCD09D0", Offset = "0xCCFDD0", VA = "0x180CD09D0")]
	static PrismReflection()
	{
	}
}
