using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x20003F1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseInformationRequest : IMessage<HouseInformationRequest>, IMessage, IEquatable<HouseInformationRequest>, IDeepCloneable<HouseInformationRequest>, IBufferMessage
{
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseInformationRequest> _parser;

	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D95")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000D97")]
	public const int HouseInstanceIdFieldNumber = 2;

	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0x20")]
	private long houseInstanceId_;

	[Token(Token = "0x170008D2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HouseInformationRequest> Parser
	{
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x99CC10", Offset = "0x99C010", VA = "0x18099CC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x99CB60", Offset = "0x99BF60", VA = "0x18099CB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x99CC60", Offset = "0x99C060", VA = "0x18099CC60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseId
	{
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170008D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long HouseInstanceId
	{
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002950")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600294A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseInformationRequest()
	{
	}

	[Token(Token = "0x600294B")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseInformationRequest(HouseInformationRequest other)
	{
	}

	[Token(Token = "0x600294C")]
	[Address(RVA = "0x99C8D0", Offset = "0x99BCD0", VA = "0x18099C8D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002951")]
	[Address(RVA = "0x99C960", Offset = "0x99BD60", VA = "0x18099C960", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002952")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002953")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002954")]
	[Address(RVA = "0x99CA00", Offset = "0x99BE00", VA = "0x18099CA00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002955")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002956")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002957")]
	[Address(RVA = "0x99C810", Offset = "0x99BC10", VA = "0x18099C810", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002958")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HouseInformationRequest other)
	{
	}

	[Token(Token = "0x6002959")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600295A")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
