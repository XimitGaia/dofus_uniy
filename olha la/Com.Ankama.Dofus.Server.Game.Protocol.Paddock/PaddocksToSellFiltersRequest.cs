using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002B3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddocksToSellFiltersRequest : IMessage<PaddocksToSellFiltersRequest>, IMessage, IEquatable<PaddocksToSellFiltersRequest>, IDeepCloneable<PaddocksToSellFiltersRequest>, IBufferMessage
{
	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddocksToSellFiltersRequest> _parser;

	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400097E")]
	public const int AreaIdFieldNumber = 1;

	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x18")]
	private int areaId_;

	[Token(Token = "0x4000980")]
	public const int AtLeastMountNumberFieldNumber = 2;

	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x1C")]
	private int atLeastMountNumber_;

	[Token(Token = "0x4000982")]
	public const int AtLeastMachineNumberFieldNumber = 3;

	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x20")]
	private int atLeastMachineNumber_;

	[Token(Token = "0x4000984")]
	public const int PriceMaxFieldNumber = 4;

	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x28")]
	private long priceMax_;

	[Token(Token = "0x4000986")]
	public const int OrderByFieldNumber = 5;

	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x30")]
	private RealEstateOrder orderBy_;

	[Token(Token = "0x1700060D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddocksToSellFiltersRequest> Parser
	{
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0xD0E320", Offset = "0xD0D720", VA = "0x180D0E320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0xD0E270", Offset = "0xD0D670", VA = "0x180D0E270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0xD0E560", Offset = "0xD0D960", VA = "0x180D0E560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000610")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AreaId
	{
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000611")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AtLeastMountNumber
	{
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000612")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AtLeastMachineNumber
	{
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000613")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PriceMax
	{
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000614")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RealEstateOrder OrderBy
	{
		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(RealEstateOrder);
		}
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddocksToSellFiltersRequest()
	{
	}

	[Token(Token = "0x6001C19")]
	[Address(RVA = "0xD0E200", Offset = "0xD0D600", VA = "0x180D0E200")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddocksToSellFiltersRequest(PaddocksToSellFiltersRequest other)
	{
	}

	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0xD0DDA0", Offset = "0xD0D1A0", VA = "0x180D0DDA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddocksToSellFiltersRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001C25")]
	[Address(RVA = "0xD0DE90", Offset = "0xD0D290", VA = "0x180D0DE90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C26")]
	[Address(RVA = "0xD0DE40", Offset = "0xD0D240", VA = "0x180D0DE40", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddocksToSellFiltersRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C27")]
	[Address(RVA = "0xD0DF40", Offset = "0xD0D340", VA = "0x180D0DF40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001C28")]
	[Address(RVA = "0xD0E0A0", Offset = "0xD0D4A0", VA = "0x180D0E0A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001C29")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001C2A")]
	[Address(RVA = "0xD0E480", Offset = "0xD0D880", VA = "0x180D0E480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0xD0DC60", Offset = "0xD0D060", VA = "0x180D0DC60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001C2C")]
	[Address(RVA = "0xD0E020", Offset = "0xD0D420", VA = "0x180D0E020", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PaddocksToSellFiltersRequest other)
	{
	}

	[Token(Token = "0x6001C2D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001C2E")]
	[Address(RVA = "0xD0E370", Offset = "0xD0D770", VA = "0x180D0E370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
