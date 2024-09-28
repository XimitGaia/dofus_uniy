using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000132")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JoinSpouseRequest : IMessage<JoinSpouseRequest>, IMessage, IEquatable<JoinSpouseRequest>, IDeepCloneable<JoinSpouseRequest>, IBufferMessage
{
	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JoinSpouseRequest> _parser;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700028A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JoinSpouseRequest> Parser
	{
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0xB67E30", Offset = "0xB67230", VA = "0x180B67E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0xB67D80", Offset = "0xB67180", VA = "0x180B67D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0xB67E80", Offset = "0xB67280", VA = "0x180B67E80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JoinSpouseRequest()
	{
	}

	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JoinSpouseRequest(JoinSpouseRequest other)
	{
	}

	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0xB67B20", Offset = "0xB66F20", VA = "0x180B67B20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JoinSpouseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0xB67BA0", Offset = "0xB66FA0", VA = "0x180B67BA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(JoinSpouseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0xB67C20", Offset = "0xB67020", VA = "0x180B67C20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JoinSpouseRequest other)
	{
	}

	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
