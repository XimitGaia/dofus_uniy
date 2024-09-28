using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x200011B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SmileyEvent : IMessage<SmileyEvent>, IMessage, IEquatable<SmileyEvent>, IDeepCloneable<SmileyEvent>, IBufferMessage
{
	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SmileyEvent> _parser;

	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40003BF")]
	public const int EntityIdFieldNumber = 1;

	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x20")]
	private long entityId_;

	[Token(Token = "0x40003C1")]
	public const int SmileyIdFieldNumber = 2;

	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x28")]
	private int smileyId_;

	[Token(Token = "0x40003C3")]
	public const int AccountIdFieldNumber = 3;

	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly long AccountIdDefaultValue;

	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x30")]
	private long accountId_;

	[Token(Token = "0x40003C6")]
	public const int CellIdFieldNumber = 4;

	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int CellIdDefaultValue;

	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x38")]
	private int cellId_;

	[Token(Token = "0x1700024D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SmileyEvent> Parser
	{
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0xB6E330", Offset = "0xB6D730", VA = "0x180B6E330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xB6E280", Offset = "0xB6D680", VA = "0x180B6E280")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xB6E5E0", Offset = "0xB6D9E0", VA = "0x180B6E5E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000250")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long EntityId
	{
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000251")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SmileyId
	{
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000252")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0xB6E1A0", Offset = "0xB6D5A0", VA = "0x180B6E1A0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0xAD5D40", Offset = "0xAD5140", VA = "0x180AD5D40")]
		set
		{
		}
	}

	[Token(Token = "0x17000253")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAccountId
	{
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000254")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CellId
	{
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0xB6E210", Offset = "0xB6D610", VA = "0x180B6E210")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0xB6E6C0", Offset = "0xB6DAC0", VA = "0x180B6E6C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000255")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasCellId
	{
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0xAEF3E0", Offset = "0xAEE7E0", VA = "0x180AEF3E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SmileyEvent()
	{
	}

	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0xA816F0", Offset = "0xA80AF0", VA = "0x180A816F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SmileyEvent(SmileyEvent other)
	{
	}

	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0xB6DC00", Offset = "0xB6D000", VA = "0x180B6DC00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SmileyEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearAccountId()
	{
	}

	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0xAEE790", Offset = "0xAEDB90", VA = "0x180AEE790")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCellId()
	{
	}

	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0xB6DD50", Offset = "0xB6D150", VA = "0x180B6DD50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0xB6DCA0", Offset = "0xB6D0A0", VA = "0x180B6DCA0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SmileyEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AED")]
	[Address(RVA = "0xB6DE30", Offset = "0xB6D230", VA = "0x180B6DE30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0xB6E020", Offset = "0xB6D420", VA = "0x180B6E020", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0xB6E480", Offset = "0xB6D880", VA = "0x180B6E480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0xB6DA50", Offset = "0xB6CE50", VA = "0x180B6DA50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0xB6DF90", Offset = "0xB6D390", VA = "0x180B6DF90", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SmileyEvent other)
	{
	}

	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0xB6E380", Offset = "0xB6D780", VA = "0x180B6E380", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
