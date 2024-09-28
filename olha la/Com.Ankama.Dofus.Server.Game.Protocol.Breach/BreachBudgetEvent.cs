using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x2000909")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachBudgetEvent : IMessage<BreachBudgetEvent>, IMessage, IEquatable<BreachBudgetEvent>, IDeepCloneable<BreachBudgetEvent>, IBufferMessage
{
	[Token(Token = "0x4001EEB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachBudgetEvent> _parser;

	[Token(Token = "0x4001EEC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EED")]
	public const int BudgetFieldNumber = 1;

	[Token(Token = "0x4001EEE")]
	[FieldOffset(Offset = "0x18")]
	private int budget_;

	[Token(Token = "0x17001439")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachBudgetEvent> Parser
	{
		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0xB4EA90", Offset = "0xB4DE90", VA = "0x180B4EA90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005F90")]
		[Address(RVA = "0xB4E9E0", Offset = "0xB4DDE0", VA = "0x180B4E9E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005F91")]
		[Address(RVA = "0xB4EAE0", Offset = "0xB4DEE0", VA = "0x180B4EAE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Budget
	{
		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005F92")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBudgetEvent()
	{
	}

	[Token(Token = "0x6005F93")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBudgetEvent(BreachBudgetEvent other)
	{
	}

	[Token(Token = "0x6005F94")]
	[Address(RVA = "0xB4E770", Offset = "0xB4DB70", VA = "0x180B4E770", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachBudgetEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005F97")]
	[Address(RVA = "0xB4E7F0", Offset = "0xB4DBF0", VA = "0x180B4E7F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F98")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachBudgetEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F99")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005F9A")]
	[Address(RVA = "0xB4E880", Offset = "0xB4DC80", VA = "0x180B4E880", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005F9B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005F9C")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005F9D")]
	[Address(RVA = "0xB4E6E0", Offset = "0xB4DAE0", VA = "0x180B4E6E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005F9E")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachBudgetEvent other)
	{
	}

	[Token(Token = "0x6005F9F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005FA0")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
