using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x20004F8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationDeleteRequest : IMessage<GuildApplicationDeleteRequest>, IMessage, IEquatable<GuildApplicationDeleteRequest>, IDeepCloneable<GuildApplicationDeleteRequest>, IBufferMessage
{
	[Token(Token = "0x40010F8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationDeleteRequest> _parser;

	[Token(Token = "0x40010F9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000B2A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildApplicationDeleteRequest> Parser
	{
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x9E3280", Offset = "0x9E2680", VA = "0x1809E3280")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B2B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600348E")]
		[Address(RVA = "0x9E31D0", Offset = "0x9E25D0", VA = "0x1809E31D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B2C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x9E32D0", Offset = "0x9E26D0", VA = "0x1809E32D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003490")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationDeleteRequest()
	{
	}

	[Token(Token = "0x6003491")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationDeleteRequest(GuildApplicationDeleteRequest other)
	{
	}

	[Token(Token = "0x6003492")]
	[Address(RVA = "0x9E2F70", Offset = "0x9E2370", VA = "0x1809E2F70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationDeleteRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003493")]
	[Address(RVA = "0x9E2FF0", Offset = "0x9E23F0", VA = "0x1809E2FF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003494")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationDeleteRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003495")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003496")]
	[Address(RVA = "0x9E3070", Offset = "0x9E2470", VA = "0x1809E3070", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003497")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003498")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003499")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600349A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildApplicationDeleteRequest other)
	{
	}

	[Token(Token = "0x600349B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600349C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
