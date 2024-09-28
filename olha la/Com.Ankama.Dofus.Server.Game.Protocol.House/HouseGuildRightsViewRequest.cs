using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x2000403")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseGuildRightsViewRequest : IMessage<HouseGuildRightsViewRequest>, IMessage, IEquatable<HouseGuildRightsViewRequest>, IDeepCloneable<HouseGuildRightsViewRequest>, IBufferMessage
{
	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseGuildRightsViewRequest> _parser;

	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DD6")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000DD8")]
	public const int InstanceIdFieldNumber = 2;

	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x17000900")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HouseGuildRightsViewRequest> Parser
	{
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x99C090", Offset = "0x99B490", VA = "0x18099C090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000901")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x99BFE0", Offset = "0x99B3E0", VA = "0x18099BFE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000902")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x99C0E0", Offset = "0x99B4E0", VA = "0x18099C0E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000903")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HouseId
	{
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000904")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InstanceId
	{
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6002A24")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildRightsViewRequest()
	{
	}

	[Token(Token = "0x6002A25")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildRightsViewRequest(HouseGuildRightsViewRequest other)
	{
	}

	[Token(Token = "0x6002A26")]
	[Address(RVA = "0x99BD60", Offset = "0x99B160", VA = "0x18099BD60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildRightsViewRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002A2B")]
	[Address(RVA = "0x99BDF0", Offset = "0x99B1F0", VA = "0x18099BDF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A2C")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseGuildRightsViewRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A2D")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002A2E")]
	[Address(RVA = "0x99BE80", Offset = "0x99B280", VA = "0x18099BE80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002A2F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002A30")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002A31")]
	[Address(RVA = "0x99BCA0", Offset = "0x99B0A0", VA = "0x18099BCA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002A32")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HouseGuildRightsViewRequest other)
	{
	}

	[Token(Token = "0x6002A33")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002A34")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
