using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x200083D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChoiceSelectedEvent : IMessage<ChoiceSelectedEvent>, IMessage, IEquatable<ChoiceSelectedEvent>, IDeepCloneable<ChoiceSelectedEvent>, IBufferMessage
{
	[Token(Token = "0x4001C64")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChoiceSelectedEvent> _parser;

	[Token(Token = "0x4001C65")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C66")]
	public const int PositionFieldNumber = 1;

	[Token(Token = "0x4001C67")]
	[FieldOffset(Offset = "0x18")]
	private int position_;

	[Token(Token = "0x1700129E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChoiceSelectedEvent> Parser
	{
		[Token(Token = "0x6005785")]
		[Address(RVA = "0xB06380", Offset = "0xB05780", VA = "0x180B06380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700129F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005786")]
		[Address(RVA = "0xB062D0", Offset = "0xB056D0", VA = "0x180B062D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005787")]
		[Address(RVA = "0xB063D0", Offset = "0xB057D0", VA = "0x180B063D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x600578B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600578C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005788")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChoiceSelectedEvent()
	{
	}

	[Token(Token = "0x6005789")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChoiceSelectedEvent(ChoiceSelectedEvent other)
	{
	}

	[Token(Token = "0x600578A")]
	[Address(RVA = "0xB06060", Offset = "0xB05460", VA = "0x180B06060", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChoiceSelectedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600578D")]
	[Address(RVA = "0xB060E0", Offset = "0xB054E0", VA = "0x180B060E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600578E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ChoiceSelectedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600578F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005790")]
	[Address(RVA = "0xB06170", Offset = "0xB05570", VA = "0x180B06170", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005791")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005792")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005793")]
	[Address(RVA = "0xB05FD0", Offset = "0xB053D0", VA = "0x180B05FD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005794")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChoiceSelectedEvent other)
	{
	}

	[Token(Token = "0x6005795")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005796")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
