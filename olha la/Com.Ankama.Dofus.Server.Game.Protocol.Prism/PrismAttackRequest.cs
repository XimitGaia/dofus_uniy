using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001B5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismAttackRequest : IMessage<PrismAttackRequest>, IMessage, IEquatable<PrismAttackRequest>, IDeepCloneable<PrismAttackRequest>, IBufferMessage
{
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismAttackRequest> _parser;

	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170003B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PrismAttackRequest> Parser
	{
		[Token(Token = "0x600114C")]
		[Address(RVA = "0xCCE760", Offset = "0xCCDB60", VA = "0x180CCE760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600114D")]
		[Address(RVA = "0xCCE6B0", Offset = "0xCCDAB0", VA = "0x180CCE6B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600114E")]
		[Address(RVA = "0xCCE7B0", Offset = "0xCCDBB0", VA = "0x180CCE7B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600114F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismAttackRequest()
	{
	}

	[Token(Token = "0x6001150")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismAttackRequest(PrismAttackRequest other)
	{
	}

	[Token(Token = "0x6001151")]
	[Address(RVA = "0xCCE450", Offset = "0xCCD850", VA = "0x180CCE450", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismAttackRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001152")]
	[Address(RVA = "0xCCE4D0", Offset = "0xCCD8D0", VA = "0x180CCE4D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001153")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PrismAttackRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001154")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001155")]
	[Address(RVA = "0xCCE550", Offset = "0xCCD950", VA = "0x180CCE550", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001156")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001157")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001158")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001159")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PrismAttackRequest other)
	{
	}

	[Token(Token = "0x600115A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600115B")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
