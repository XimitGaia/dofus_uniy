using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x2000907")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachBonusEvent : IMessage<BreachBonusEvent>, IMessage, IEquatable<BreachBonusEvent>, IDeepCloneable<BreachBonusEvent>, IBufferMessage
{
	[Token(Token = "0x4001EE6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachBonusEvent> _parser;

	[Token(Token = "0x4001EE7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EE8")]
	public const int BonusFieldNumber = 1;

	[Token(Token = "0x4001EE9")]
	[FieldOffset(Offset = "0x18")]
	private ObjectEffect bonus_;

	[Token(Token = "0x17001435")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachBonusEvent> Parser
	{
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0xB4DAB0", Offset = "0xB4CEB0", VA = "0x180B4DAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001436")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0xB4DA00", Offset = "0xB4CE00", VA = "0x180B4DA00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001437")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0xB4DC00", Offset = "0xB4D000", VA = "0x180B4DC00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001438")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectEffect Bonus
	{
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6005F7C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachBonusEvent()
	{
	}

	[Token(Token = "0x6005F7D")]
	[Address(RVA = "0xB4D990", Offset = "0xB4CD90", VA = "0x180B4D990")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachBonusEvent(BreachBonusEvent other)
	{
	}

	[Token(Token = "0x6005F7E")]
	[Address(RVA = "0xB4D610", Offset = "0xB4CA10", VA = "0x180B4D610", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBonusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005F81")]
	[Address(RVA = "0xB4D6B0", Offset = "0xB4CAB0", VA = "0x180B4D6B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F82")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BreachBonusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F83")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005F84")]
	[Address(RVA = "0xB4D830", Offset = "0xB4CC30", VA = "0x180B4D830", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005F85")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005F86")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005F87")]
	[Address(RVA = "0xB4D580", Offset = "0xB4C980", VA = "0x180B4D580", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005F88")]
	[Address(RVA = "0xB4D760", Offset = "0xB4CB60", VA = "0x180B4D760", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachBonusEvent other)
	{
	}

	[Token(Token = "0x6005F89")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005F8A")]
	[Address(RVA = "0xB4DB00", Offset = "0xB4CF00", VA = "0x180B4DB00", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
