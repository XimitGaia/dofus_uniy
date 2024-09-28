using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B3E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SequenceNumberRequest : IMessage<SequenceNumberRequest>, IMessage, IEquatable<SequenceNumberRequest>, IDeepCloneable<SequenceNumberRequest>, IBufferMessage
{
	[Token(Token = "0x40029FD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SequenceNumberRequest> _parser;

	[Token(Token = "0x40029FE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40029FF")]
	public const int NumberFieldNumber = 1;

	[Token(Token = "0x4002A00")]
	[FieldOffset(Offset = "0x18")]
	private int number_;

	[Token(Token = "0x17001A1C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SequenceNumberRequest> Parser
	{
		[Token(Token = "0x6007680")]
		[Address(RVA = "0xC257D0", Offset = "0xC24BD0", VA = "0x180C257D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A1D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007681")]
		[Address(RVA = "0xC25720", Offset = "0xC24B20", VA = "0x180C25720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007682")]
		[Address(RVA = "0xC25820", Offset = "0xC24C20", VA = "0x180C25820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A1F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Number
	{
		[Token(Token = "0x6007686")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007687")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007683")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceNumberRequest()
	{
	}

	[Token(Token = "0x6007684")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceNumberRequest(SequenceNumberRequest other)
	{
	}

	[Token(Token = "0x6007685")]
	[Address(RVA = "0xC254B0", Offset = "0xC248B0", VA = "0x180C254B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceNumberRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007688")]
	[Address(RVA = "0xC25530", Offset = "0xC24930", VA = "0x180C25530", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007689")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SequenceNumberRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600768A")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600768B")]
	[Address(RVA = "0xC255C0", Offset = "0xC249C0", VA = "0x180C255C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600768C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600768D")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600768E")]
	[Address(RVA = "0xC25420", Offset = "0xC24820", VA = "0x180C25420", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600768F")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SequenceNumberRequest other)
	{
	}

	[Token(Token = "0x6007690")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007691")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
