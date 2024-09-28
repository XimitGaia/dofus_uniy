using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004A2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildBulletinSetRequest : IMessage<GuildBulletinSetRequest>, IMessage, IEquatable<GuildBulletinSetRequest>, IDeepCloneable<GuildBulletinSetRequest>, IBufferMessage
{
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildBulletinSetRequest> _parser;

	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FD9")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x17000A5F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildBulletinSetRequest> Parser
	{
		[Token(Token = "0x60030C2")]
		[Address(RVA = "0x9C99A0", Offset = "0x9C8DA0", VA = "0x1809C99A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60030C3")]
		[Address(RVA = "0x9C98F0", Offset = "0x9C8CF0", VA = "0x1809C98F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A61")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x9C9AB0", Offset = "0x9C8EB0", VA = "0x1809C9AB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A62")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Content
	{
		[Token(Token = "0x60030C8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60030C9")]
		[Address(RVA = "0x9C9B90", Offset = "0x9C8F90", VA = "0x1809C9B90")]
		set
		{
		}
	}

	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x9C98A0", Offset = "0x9C8CA0", VA = "0x1809C98A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildBulletinSetRequest()
	{
	}

	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x9C9800", Offset = "0x9C8C00", VA = "0x1809C9800")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBulletinSetRequest(GuildBulletinSetRequest other)
	{
	}

	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x9C94C0", Offset = "0x9C88C0", VA = "0x1809C94C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBulletinSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x9C9590", Offset = "0x9C8990", VA = "0x1809C9590", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030CB")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildBulletinSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x9C96A0", Offset = "0x9C8AA0", VA = "0x1809C96A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x9C9430", Offset = "0x9C8830", VA = "0x1809C9430", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60030D1")]
	[Address(RVA = "0x9C9640", Offset = "0x9C8A40", VA = "0x1809C9640", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildBulletinSetRequest other)
	{
	}

	[Token(Token = "0x60030D2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x9C99F0", Offset = "0x9C8DF0", VA = "0x1809C99F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
