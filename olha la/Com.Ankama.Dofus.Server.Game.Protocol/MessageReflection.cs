using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol;

[Token(Token = "0x200000D")]
public static class MessageReflection
{
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x0")]
	private static FileDescriptor descriptor;

	[Token(Token = "0x1700000D")]
	public static FileDescriptor Descriptor
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x93C2D0", Offset = "0x93B6D0", VA = "0x18093C2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x93B980", Offset = "0x93AD80", VA = "0x18093B980")]
	static MessageReflection()
	{
	}
}
