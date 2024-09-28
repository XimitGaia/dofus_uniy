using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x20003FF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HousesToSellFiltersRequest : IMessage<HousesToSellFiltersRequest>, IMessage, IEquatable<HousesToSellFiltersRequest>, IDeepCloneable<HousesToSellFiltersRequest>, IBufferMessage
{
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HousesToSellFiltersRequest> _parser;

	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DC0")]
	public const int AreaIdFieldNumber = 1;

	[Token(Token = "0x4000DC1")]
	[FieldOffset(Offset = "0x18")]
	private int areaId_;

	[Token(Token = "0x4000DC2")]
	public const int AtLeastRoomNumberFieldNumber = 2;

	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x1C")]
	private int atLeastRoomNumber_;

	[Token(Token = "0x4000DC4")]
	public const int AtLeastChestNumberFieldNumber = 3;

	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x20")]
	private int atLeastChestNumber_;

	[Token(Token = "0x4000DC6")]
	public const int SkillRequestedFieldNumber = 4;

	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x24")]
	private int skillRequested_;

	[Token(Token = "0x4000DC8")]
	public const int PriceMaxFieldNumber = 5;

	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x28")]
	private long priceMax_;

	[Token(Token = "0x4000DCA")]
	public const int OrderByFieldNumber = 6;

	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x30")]
	private RealEstateOrder orderBy_;

	[Token(Token = "0x170008F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HousesToSellFiltersRequest> Parser
	{
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x9A3900", Offset = "0x9A2D00", VA = "0x1809A3900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0x9A3850", Offset = "0x9A2C50", VA = "0x1809A3850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x9A3B80", Offset = "0x9A2F80", VA = "0x1809A3B80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AreaId
	{
		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170008F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AtLeastRoomNumber
	{
		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60029F2")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170008F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AtLeastChestNumber
	{
		[Token(Token = "0x60029F3")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170008F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillRequested
	{
		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x170008F9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PriceMax
	{
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x170008FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RealEstateOrder OrderBy
	{
		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(RealEstateOrder);
		}
		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x60029EC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HousesToSellFiltersRequest()
	{
	}

	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x9A37E0", Offset = "0x9A2BE0", VA = "0x1809A37E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HousesToSellFiltersRequest(HousesToSellFiltersRequest other)
	{
	}

	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x9A3330", Offset = "0x9A2730", VA = "0x1809A3330", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HousesToSellFiltersRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60029FB")]
	[Address(RVA = "0x9A33D0", Offset = "0x9A27D0", VA = "0x1809A33D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60029FC")]
	[Address(RVA = "0x9A3490", Offset = "0x9A2890", VA = "0x1809A3490", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HousesToSellFiltersRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60029FD")]
	[Address(RVA = "0x9A34F0", Offset = "0x9A28F0", VA = "0x1809A34F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60029FE")]
	[Address(RVA = "0x9A3680", Offset = "0x9A2A80", VA = "0x1809A3680", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60029FF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002A00")]
	[Address(RVA = "0x9A3A80", Offset = "0x9A2E80", VA = "0x1809A3A80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002A01")]
	[Address(RVA = "0x9A31D0", Offset = "0x9A25D0", VA = "0x1809A31D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002A02")]
	[Address(RVA = "0x9A35F0", Offset = "0x9A29F0", VA = "0x1809A35F0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HousesToSellFiltersRequest other)
	{
	}

	[Token(Token = "0x6002A03")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002A04")]
	[Address(RVA = "0x9A3950", Offset = "0x9A2D50", VA = "0x1809A3950", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
