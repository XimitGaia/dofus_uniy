using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x2000813")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReloginRequest : IMessage<ReloginRequest>, IMessage, IEquatable<ReloginRequest>, IDeepCloneable<ReloginRequest>, IBufferMessage
{
	[Token(Token = "0x4001BF1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ReloginRequest> _parser;

	[Token(Token = "0x4001BF2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001247")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReloginRequest> Parser
	{
		[Token(Token = "0x60055C3")]
		[Address(RVA = "0xB0F9C0", Offset = "0xB0EDC0", VA = "0x180B0F9C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001248")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60055C4")]
		[Address(RVA = "0xB0F910", Offset = "0xB0ED10", VA = "0x180B0F910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001249")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60055C5")]
		[Address(RVA = "0xB0FA10", Offset = "0xB0EE10", VA = "0x180B0FA10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60055C6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReloginRequest()
	{
	}

	[Token(Token = "0x60055C7")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ReloginRequest(ReloginRequest other)
	{
	}

	[Token(Token = "0x60055C8")]
	[Address(RVA = "0xB0F6B0", Offset = "0xB0EAB0", VA = "0x180B0F6B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReloginRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60055C9")]
	[Address(RVA = "0xB0F730", Offset = "0xB0EB30", VA = "0x180B0F730", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60055CA")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ReloginRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60055CB")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60055CC")]
	[Address(RVA = "0xB0F7B0", Offset = "0xB0EBB0", VA = "0x180B0F7B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60055CD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60055CE")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60055CF")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60055D0")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ReloginRequest other)
	{
	}

	[Token(Token = "0x60055D1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60055D2")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
