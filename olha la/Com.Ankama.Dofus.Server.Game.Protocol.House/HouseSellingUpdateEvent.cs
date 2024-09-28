using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x200040D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseSellingUpdateEvent : IMessage<HouseSellingUpdateEvent>, IMessage, IEquatable<HouseSellingUpdateEvent>, IDeepCloneable<HouseSellingUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseSellingUpdateEvent> _parser;

	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E05")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000E07")]
	public const int InstanceIdFieldNumber = 2;

	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x4000E09")]
	public const int SecondHandFieldNumber = 3;

	[Token(Token = "0x4000E0A")]
	[FieldOffset(Offset = "0x20")]
	private bool secondHand_;

	[Token(Token = "0x4000E0B")]
	public const int PriceFieldNumber = 4;

	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x28")]
	private long price_;

	[Token(Token = "0x4000E0D")]
	public const int BuyerAccountNicknameFieldNumber = 5;

	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x30")]
	private string buyerAccountNickname_;

	[Token(Token = "0x4000E0F")]
	public const int BuyerAccountTagFieldNumber = 6;

	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x38")]
	private string buyerAccountTag_;

	[Token(Token = "0x1700091E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HouseSellingUpdateEvent> Parser
	{
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x9A2800", Offset = "0x9A1C00", VA = "0x1809A2800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700091F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x9A2750", Offset = "0x9A1B50", VA = "0x1809A2750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000920")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x9A2AF0", Offset = "0x9A1EF0", VA = "0x1809A2AF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000921")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HouseId
	{
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000922")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InstanceId
	{
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000923")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool SecondHand
	{
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x17000924")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Price
	{
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000925")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BuyerAccountNickname
	{
		[Token(Token = "0x6002AAF")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002AB0")]
		[Address(RVA = "0x9A2BD0", Offset = "0x9A1FD0", VA = "0x1809A2BD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000926")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BuyerAccountTag
	{
		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x9A2C40", Offset = "0x9A2040", VA = "0x1809A2C40")]
		set
		{
		}
	}

	[Token(Token = "0x6002AA4")]
	[Address(RVA = "0x9A25F0", Offset = "0x9A19F0", VA = "0x1809A25F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseSellingUpdateEvent()
	{
	}

	[Token(Token = "0x6002AA5")]
	[Address(RVA = "0x9A2660", Offset = "0x9A1A60", VA = "0x1809A2660")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseSellingUpdateEvent(HouseSellingUpdateEvent other)
	{
	}

	[Token(Token = "0x6002AA6")]
	[Address(RVA = "0x9A1FF0", Offset = "0x9A13F0", VA = "0x1809A1FF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseSellingUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002AB3")]
	[Address(RVA = "0x9A2110", Offset = "0x9A1510", VA = "0x1809A2110", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB4")]
	[Address(RVA = "0x9A2200", Offset = "0x9A1600", VA = "0x1809A2200", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseSellingUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB5")]
	[Address(RVA = "0x9A22A0", Offset = "0x9A16A0", VA = "0x1809A22A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002AB6")]
	[Address(RVA = "0x9A2490", Offset = "0x9A1890", VA = "0x1809A2490", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002AB7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002AB8")]
	[Address(RVA = "0x9A29D0", Offset = "0x9A1DD0", VA = "0x1809A29D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002AB9")]
	[Address(RVA = "0x9A1EA0", Offset = "0x9A12A0", VA = "0x1809A1EA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002ABA")]
	[Address(RVA = "0x9A23E0", Offset = "0x9A17E0", VA = "0x1809A23E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HouseSellingUpdateEvent other)
	{
	}

	[Token(Token = "0x6002ABB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002ABC")]
	[Address(RVA = "0x9A2850", Offset = "0x9A1C50", VA = "0x1809A2850", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
