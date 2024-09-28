using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000723")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SellingConditions : IMessage<SellingConditions>, IMessage, IEquatable<SellingConditions>, IDeepCloneable<SellingConditions>, IBufferMessage
{
	[Token(Token = "0x400191E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SellingConditions> _parser;

	[Token(Token = "0x400191F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001920")]
	public const int QuantitiesFieldNumber = 1;

	[Token(Token = "0x4001921")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_quantities_codec;

	[Token(Token = "0x4001922")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> quantities_;

	[Token(Token = "0x4001923")]
	public const int Types_FieldNumber = 2;

	[Token(Token = "0x4001924")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_types_codec;

	[Token(Token = "0x4001925")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> types_;

	[Token(Token = "0x4001926")]
	public const int TaxPercentageFieldNumber = 3;

	[Token(Token = "0x4001927")]
	[FieldOffset(Offset = "0x28")]
	private float taxPercentage_;

	[Token(Token = "0x4001928")]
	public const int TaxModificationPercentageFieldNumber = 4;

	[Token(Token = "0x4001929")]
	[FieldOffset(Offset = "0x2C")]
	private float taxModificationPercentage_;

	[Token(Token = "0x400192A")]
	public const int MaxItemLevelFieldNumber = 5;

	[Token(Token = "0x400192B")]
	[FieldOffset(Offset = "0x30")]
	private int maxItemLevel_;

	[Token(Token = "0x400192C")]
	public const int MaxItemPerAccountFieldNumber = 6;

	[Token(Token = "0x400192D")]
	[FieldOffset(Offset = "0x34")]
	private int maxItemPerAccount_;

	[Token(Token = "0x400192E")]
	public const int NpcContextualIdFieldNumber = 7;

	[Token(Token = "0x400192F")]
	[FieldOffset(Offset = "0x38")]
	private int npcContextualId_;

	[Token(Token = "0x4001930")]
	public const int UnsoldDelayFieldNumber = 8;

	[Token(Token = "0x4001931")]
	[FieldOffset(Offset = "0x3C")]
	private int unsoldDelay_;

	[Token(Token = "0x17001067")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SellingConditions> Parser
	{
		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0xAC6BC0", Offset = "0xAC5FC0", VA = "0x180AC6BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001068")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004CAC")]
		[Address(RVA = "0xAC6B10", Offset = "0xAC5F10", VA = "0x180AC6B10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001069")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004CAD")]
		[Address(RVA = "0xAC7010", Offset = "0xAC6410", VA = "0x180AC7010", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700106A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Quantities
	{
		[Token(Token = "0x6004CB1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700106B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Types_
	{
		[Token(Token = "0x6004CB2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700106C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float TaxPercentage
	{
		[Token(Token = "0x6004CB3")]
		[Address(RVA = "0xAC6C10", Offset = "0xAC6010", VA = "0x180AC6C10")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004CB4")]
		[Address(RVA = "0xAC70F0", Offset = "0xAC64F0", VA = "0x180AC70F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700106D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float TaxModificationPercentage
	{
		[Token(Token = "0x6004CB5")]
		[Address(RVA = "0xAA6BD0", Offset = "0xAA5FD0", VA = "0x180AA6BD0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004CB6")]
		[Address(RVA = "0xAA6F80", Offset = "0xAA6380", VA = "0x180AA6F80")]
		set
		{
		}
	}

	[Token(Token = "0x1700106E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxItemLevel
	{
		[Token(Token = "0x6004CB7")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004CB8")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x1700106F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxItemPerAccount
	{
		[Token(Token = "0x6004CB9")]
		[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004CBA")]
		[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
		set
		{
		}
	}

	[Token(Token = "0x17001070")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NpcContextualId
	{
		[Token(Token = "0x6004CBB")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004CBC")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x17001071")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UnsoldDelay
	{
		[Token(Token = "0x6004CBD")]
		[Address(RVA = "0x946B90", Offset = "0x945F90", VA = "0x180946B90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004CBE")]
		[Address(RVA = "0x9470F0", Offset = "0x9464F0", VA = "0x1809470F0")]
		set
		{
		}
	}

	[Token(Token = "0x6004CAE")]
	[Address(RVA = "0xAC6980", Offset = "0xAC5D80", VA = "0x180AC6980")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SellingConditions()
	{
	}

	[Token(Token = "0x6004CAF")]
	[Address(RVA = "0xAC6A30", Offset = "0xAC5E30", VA = "0x180AC6A30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SellingConditions(SellingConditions other)
	{
	}

	[Token(Token = "0x6004CB0")]
	[Address(RVA = "0xAC6030", Offset = "0xAC5430", VA = "0x180AC6030", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SellingConditions Clone()
	{
		return null;
	}

	[Token(Token = "0x6004CBF")]
	[Address(RVA = "0xAC62C0", Offset = "0xAC56C0", VA = "0x180AC62C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CC0")]
	[Address(RVA = "0xAC6140", Offset = "0xAC5540", VA = "0x180AC6140", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SellingConditions other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CC1")]
	[Address(RVA = "0xAC6490", Offset = "0xAC5890", VA = "0x180AC6490", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004CC2")]
	[Address(RVA = "0xAC67C0", Offset = "0xAC5BC0", VA = "0x180AC67C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004CC3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004CC4")]
	[Address(RVA = "0xAC6E40", Offset = "0xAC6240", VA = "0x180AC6E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004CC5")]
	[Address(RVA = "0xAC5E80", Offset = "0xAC5280", VA = "0x180AC5E80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004CC6")]
	[Address(RVA = "0xAC66D0", Offset = "0xAC5AD0", VA = "0x180AC66D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SellingConditions other)
	{
	}

	[Token(Token = "0x6004CC7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004CC8")]
	[Address(RVA = "0xAC6C20", Offset = "0xAC6020", VA = "0x180AC6C20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
