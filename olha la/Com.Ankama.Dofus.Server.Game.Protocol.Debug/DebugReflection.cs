using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug;

[Token(Token = "0x200076A")]
public static class DebugReflection
{
	[Token(Token = "0x40019F3")]
	[FieldOffset(Offset = "0x0")]
	private static FileDescriptor descriptor;

	[Token(Token = "0x170010F3")]
	public static FileDescriptor Descriptor
	{
		[Token(Token = "0x6004F44")]
		[Address(RVA = "0xAD9D50", Offset = "0xAD9150", VA = "0x180AD9D50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F45")]
	[Address(RVA = "0xAD93C0", Offset = "0xAD87C0", VA = "0x180AD93C0")]
	static DebugReflection()
	{
	}
}
