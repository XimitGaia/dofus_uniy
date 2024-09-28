using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Server;

[Token(Token = "0x200014C")]
public static class ServerReflection
{
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x0")]
	private static FileDescriptor descriptor;

	[Token(Token = "0x170002C0")]
	public static FileDescriptor Descriptor
	{
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0xB6BA30", Offset = "0xB6AE30", VA = "0x180B6BA30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0xB6AFC0", Offset = "0xB6A3C0", VA = "0x180B6AFC0")]
	static ServerReflection()
	{
	}
}
