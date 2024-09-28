using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x2000849")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GlobalChoiceSelectedEvent : IMessage<GlobalChoiceSelectedEvent>, IMessage, IEquatable<GlobalChoiceSelectedEvent>, IDeepCloneable<GlobalChoiceSelectedEvent>, IBufferMessage
{
	[Token(Token = "0x4001C8A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GlobalChoiceSelectedEvent> _parser;

	[Token(Token = "0x4001C8B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C8C")]
	public const int PositionFieldNumber = 1;

	[Token(Token = "0x4001C8D")]
	[FieldOffset(Offset = "0x18")]
	private int position_;

	[Token(Token = "0x170012B9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GlobalChoiceSelectedEvent> Parser
	{
		[Token(Token = "0x600580D")]
		[Address(RVA = "0xB0B440", Offset = "0xB0A840", VA = "0x180B0B440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600580E")]
		[Address(RVA = "0xB0B390", Offset = "0xB0A790", VA = "0x180B0B390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600580F")]
		[Address(RVA = "0xB0B490", Offset = "0xB0A890", VA = "0x180B0B490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Position
	{
		[Token(Token = "0x6005813")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005814")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005810")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GlobalChoiceSelectedEvent()
	{
	}

	[Token(Token = "0x6005811")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GlobalChoiceSelectedEvent(GlobalChoiceSelectedEvent other)
	{
	}

	[Token(Token = "0x6005812")]
	[Address(RVA = "0xB0B120", Offset = "0xB0A520", VA = "0x180B0B120", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GlobalChoiceSelectedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005815")]
	[Address(RVA = "0xB0B1A0", Offset = "0xB0A5A0", VA = "0x180B0B1A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005816")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GlobalChoiceSelectedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005817")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005818")]
	[Address(RVA = "0xB0B230", Offset = "0xB0A630", VA = "0x180B0B230", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005819")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600581A")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600581B")]
	[Address(RVA = "0xB0B090", Offset = "0xB0A490", VA = "0x180B0B090", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600581C")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GlobalChoiceSelectedEvent other)
	{
	}

	[Token(Token = "0x600581D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600581E")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
