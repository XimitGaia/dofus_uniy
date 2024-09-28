using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x2000185")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestStartRequest : IMessage<QuestStartRequest>, IMessage, IEquatable<QuestStartRequest>, IDeepCloneable<QuestStartRequest>, IBufferMessage
{
	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestStartRequest> _parser;

	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000530")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x17000347")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestStartRequest> Parser
	{
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0xC4D1F0", Offset = "0xC4C5F0", VA = "0x180C4D1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000348")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0xC4D140", Offset = "0xC4C540", VA = "0x180C4D140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000349")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0xC4D240", Offset = "0xC4C640", VA = "0x180C4D240", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestId
	{
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000F50")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStartRequest()
	{
	}

	[Token(Token = "0x6000F51")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestStartRequest(QuestStartRequest other)
	{
	}

	[Token(Token = "0x6000F52")]
	[Address(RVA = "0xC4CED0", Offset = "0xC4C2D0", VA = "0x180C4CED0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStartRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000F55")]
	[Address(RVA = "0xC4CF50", Offset = "0xC4C350", VA = "0x180C4CF50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F56")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestStartRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000F58")]
	[Address(RVA = "0xC4CFE0", Offset = "0xC4C3E0", VA = "0x180C4CFE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0xC4CE40", Offset = "0xC4C240", VA = "0x180C4CE40", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestStartRequest other)
	{
	}

	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
