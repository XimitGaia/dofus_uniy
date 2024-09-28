using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x200040B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseBuyResultEvent : IMessage<HouseBuyResultEvent>, IMessage, IEquatable<HouseBuyResultEvent>, IDeepCloneable<HouseBuyResultEvent>, IBufferMessage
{
	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseBuyResultEvent> _parser;

	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DF8")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000DFA")]
	public const int InstanceIdFieldNumber = 2;

	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x4000DFC")]
	public const int SecondHandFieldNumber = 3;

	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x20")]
	private bool secondHand_;

	[Token(Token = "0x4000DFE")]
	public const int BoughtFieldNumber = 4;

	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x21")]
	private bool bought_;

	[Token(Token = "0x4000E00")]
	public const int PriceFieldNumber = 5;

	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x28")]
	private long price_;

	[Token(Token = "0x17000916")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HouseBuyResultEvent> Parser
	{
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x99B960", Offset = "0x99AD60", VA = "0x18099B960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000917")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x99B8B0", Offset = "0x99ACB0", VA = "0x18099B8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000918")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002A85")]
		[Address(RVA = "0x99BBB0", Offset = "0x99AFB0", VA = "0x18099BBB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000919")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseId
	{
		[Token(Token = "0x6002A89")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700091A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InstanceId
	{
		[Token(Token = "0x6002A8B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700091B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool SecondHand
	{
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x1700091C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Bought
	{
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x911F20", Offset = "0x911320", VA = "0x180911F20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x99BC90", Offset = "0x99B090", VA = "0x18099BC90")]
		set
		{
		}
	}

	[Token(Token = "0x1700091D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Price
	{
		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6002A86")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseBuyResultEvent()
	{
	}

	[Token(Token = "0x6002A87")]
	[Address(RVA = "0x99B840", Offset = "0x99AC40", VA = "0x18099B840")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseBuyResultEvent(HouseBuyResultEvent other)
	{
	}

	[Token(Token = "0x6002A88")]
	[Address(RVA = "0x99B390", Offset = "0x99A790", VA = "0x18099B390", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseBuyResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002A93")]
	[Address(RVA = "0x99B430", Offset = "0x99A830", VA = "0x18099B430", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A94")]
	[Address(RVA = "0x99B4E0", Offset = "0x99A8E0", VA = "0x18099B4E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HouseBuyResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A95")]
	[Address(RVA = "0x99B530", Offset = "0x99A930", VA = "0x18099B530", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002A96")]
	[Address(RVA = "0x99B6E0", Offset = "0x99AAE0", VA = "0x18099B6E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002A97")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002A98")]
	[Address(RVA = "0x99BAD0", Offset = "0x99AED0", VA = "0x18099BAD0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002A99")]
	[Address(RVA = "0x99B290", Offset = "0x99A690", VA = "0x18099B290", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002A9A")]
	[Address(RVA = "0x99B660", Offset = "0x99AA60", VA = "0x18099B660", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HouseBuyResultEvent other)
	{
	}

	[Token(Token = "0x6002A9B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002A9C")]
	[Address(RVA = "0x99B9B0", Offset = "0x99ADB0", VA = "0x18099B9B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
