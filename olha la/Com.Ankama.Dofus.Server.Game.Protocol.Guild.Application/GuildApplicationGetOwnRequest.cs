using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x20004FC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationGetOwnRequest : IMessage<GuildApplicationGetOwnRequest>, IMessage, IEquatable<GuildApplicationGetOwnRequest>, IDeepCloneable<GuildApplicationGetOwnRequest>, IBufferMessage
{
	[Token(Token = "0x4001100")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationGetOwnRequest> _parser;

	[Token(Token = "0x4001101")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000B31")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildApplicationGetOwnRequest> Parser
	{
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x9E3BB0", Offset = "0x9E2FB0", VA = "0x1809E3BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B32")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x9E3B00", Offset = "0x9E2F00", VA = "0x1809E3B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B33")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x9E3C00", Offset = "0x9E3000", VA = "0x1809E3C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60034BA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationGetOwnRequest()
	{
	}

	[Token(Token = "0x60034BB")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationGetOwnRequest(GuildApplicationGetOwnRequest other)
	{
	}

	[Token(Token = "0x60034BC")]
	[Address(RVA = "0x9E38A0", Offset = "0x9E2CA0", VA = "0x1809E38A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildApplicationGetOwnRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60034BD")]
	[Address(RVA = "0x9E3920", Offset = "0x9E2D20", VA = "0x1809E3920", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60034BE")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationGetOwnRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60034BF")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60034C0")]
	[Address(RVA = "0x9E39A0", Offset = "0x9E2DA0", VA = "0x1809E39A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60034C1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60034C2")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60034C3")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60034C4")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationGetOwnRequest other)
	{
	}

	[Token(Token = "0x60034C5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60034C6")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
