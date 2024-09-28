using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008ED")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachExitRequest : IMessage<BreachExitRequest>, IMessage, IEquatable<BreachExitRequest>, IDeepCloneable<BreachExitRequest>, IBufferMessage
{
	[Token(Token = "0x4001EA0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachExitRequest> _parser;

	[Token(Token = "0x4001EA1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001403")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachExitRequest> Parser
	{
		[Token(Token = "0x6005E70")]
		[Address(RVA = "0xB4FD50", Offset = "0xB4F150", VA = "0x180B4FD50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001404")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005E71")]
		[Address(RVA = "0xB4FCA0", Offset = "0xB4F0A0", VA = "0x180B4FCA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001405")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005E72")]
		[Address(RVA = "0xB4FDA0", Offset = "0xB4F1A0", VA = "0x180B4FDA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005E73")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachExitRequest()
	{
	}

	[Token(Token = "0x6005E74")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachExitRequest(BreachExitRequest other)
	{
	}

	[Token(Token = "0x6005E75")]
	[Address(RVA = "0xB4FA40", Offset = "0xB4EE40", VA = "0x180B4FA40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachExitRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005E76")]
	[Address(RVA = "0xB4FAC0", Offset = "0xB4EEC0", VA = "0x180B4FAC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E77")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BreachExitRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E78")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005E79")]
	[Address(RVA = "0xB4FB40", Offset = "0xB4EF40", VA = "0x180B4FB40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005E7A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005E7B")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005E7C")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005E7D")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachExitRequest other)
	{
	}

	[Token(Token = "0x6005E7E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005E7F")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
