using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x200040F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HousesToSellEvent : IMessage<HousesToSellEvent>, IMessage, IEquatable<HousesToSellEvent>, IDeepCloneable<HousesToSellEvent>, IBufferMessage
{
	[Token(Token = "0x2000410")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000411")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class HouseToSell : IMessage<HouseToSell>, IMessage, IEquatable<HouseToSell>, IDeepCloneable<HouseToSell>, IBufferMessage
		{
			[Token(Token = "0x4000E1B")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<HouseToSell> _parser;

			[Token(Token = "0x4000E1C")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000E1D")]
			public const int InstanceIdFieldNumber = 1;

			[Token(Token = "0x4000E1E")]
			[FieldOffset(Offset = "0x18")]
			private int instanceId_;

			[Token(Token = "0x4000E1F")]
			public const int SecondHandFieldNumber = 2;

			[Token(Token = "0x4000E20")]
			[FieldOffset(Offset = "0x1C")]
			private bool secondHand_;

			[Token(Token = "0x4000E21")]
			public const int ModelIdFieldNumber = 3;

			[Token(Token = "0x4000E22")]
			[FieldOffset(Offset = "0x20")]
			private int modelId_;

			[Token(Token = "0x4000E23")]
			public const int OwnerAccountNicknameFieldNumber = 4;

			[Token(Token = "0x4000E24")]
			[FieldOffset(Offset = "0x28")]
			private string ownerAccountNickname_;

			[Token(Token = "0x4000E25")]
			public const int OwnerAccountTagFieldNumber = 5;

			[Token(Token = "0x4000E26")]
			[FieldOffset(Offset = "0x30")]
			private string ownerAccountTag_;

			[Token(Token = "0x4000E27")]
			public const int HasOwnerFieldNumber = 6;

			[Token(Token = "0x4000E28")]
			[FieldOffset(Offset = "0x38")]
			private bool hasOwner_;

			[Token(Token = "0x4000E29")]
			public const int OwnerNameFieldNumber = 7;

			[Token(Token = "0x4000E2A")]
			[FieldOffset(Offset = "0x40")]
			private string ownerName_;

			[Token(Token = "0x4000E2B")]
			public const int CoordinatesFieldNumber = 8;

			[Token(Token = "0x4000E2C")]
			[FieldOffset(Offset = "0x48")]
			private MapCoordinates coordinates_;

			[Token(Token = "0x4000E2D")]
			public const int SubAreaIdFieldNumber = 9;

			[Token(Token = "0x4000E2E")]
			[FieldOffset(Offset = "0x50")]
			private int subAreaId_;

			[Token(Token = "0x4000E2F")]
			public const int RoomNumberFieldNumber = 10;

			[Token(Token = "0x4000E30")]
			[FieldOffset(Offset = "0x54")]
			private int roomNumber_;

			[Token(Token = "0x4000E31")]
			public const int ChestNumberFieldNumber = 11;

			[Token(Token = "0x4000E32")]
			[FieldOffset(Offset = "0x58")]
			private int chestNumber_;

			[Token(Token = "0x4000E33")]
			public const int SkillsIdFieldNumber = 12;

			[Token(Token = "0x4000E34")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<int> _repeated_skillsId_codec;

			[Token(Token = "0x4000E35")]
			[FieldOffset(Offset = "0x60")]
			private readonly RepeatedField<int> skillsId_;

			[Token(Token = "0x4000E36")]
			public const int IsLockedFieldNumber = 13;

			[Token(Token = "0x4000E37")]
			[FieldOffset(Offset = "0x68")]
			private bool isLocked_;

			[Token(Token = "0x4000E38")]
			public const int PriceFieldNumber = 14;

			[Token(Token = "0x4000E39")]
			[FieldOffset(Offset = "0x70")]
			private long price_;

			[Token(Token = "0x1700092D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<HouseToSell> Parser
			{
				[Token(Token = "0x6002AD7")]
				[Address(RVA = "0x9C6010", Offset = "0x9C5410", VA = "0x1809C6010")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700092E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6002AD8")]
				[Address(RVA = "0x9C5F70", Offset = "0x9C5370", VA = "0x1809C5F70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700092F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6002AD9")]
				[Address(RVA = "0x9C6670", Offset = "0x9C5A70", VA = "0x1809C6670", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000930")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int InstanceId
			{
				[Token(Token = "0x6002ADD")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002ADE")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000931")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool SecondHand
			{
				[Token(Token = "0x6002ADF")]
				[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002AE0")]
				[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
				set
				{
				}
			}

			[Token(Token = "0x17000932")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ModelId
			{
				[Token(Token = "0x6002AE1")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002AE2")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17000933")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string OwnerAccountNickname
			{
				[Token(Token = "0x6002AE3")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002AE4")]
				[Address(RVA = "0x9C6750", Offset = "0x9C5B50", VA = "0x1809C6750")]
				set
				{
				}
			}

			[Token(Token = "0x17000934")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string OwnerAccountTag
			{
				[Token(Token = "0x6002AE5")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002AE6")]
				[Address(RVA = "0x9C67C0", Offset = "0x9C5BC0", VA = "0x1809C67C0")]
				set
				{
				}
			}

			[Token(Token = "0x17000935")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasOwner
			{
				[Token(Token = "0x6002AE7")]
				[Address(RVA = "0x9C5FF0", Offset = "0x9C53F0", VA = "0x1809C5FF0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002AE8")]
				[Address(RVA = "0x9C6730", Offset = "0x9C5B30", VA = "0x1809C6730")]
				set
				{
				}
			}

			[Token(Token = "0x17000936")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string OwnerName
			{
				[Token(Token = "0x6002AE9")]
				[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002AEA")]
				[Address(RVA = "0x9C6830", Offset = "0x9C5C30", VA = "0x1809C6830")]
				set
				{
				}
			}

			[Token(Token = "0x17000937")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MapCoordinates Coordinates
			{
				[Token(Token = "0x6002AEB")]
				[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002AEC")]
				[Address(RVA = "0x92EFD0", Offset = "0x92E3D0", VA = "0x18092EFD0")]
				set
				{
				}
			}

			[Token(Token = "0x17000938")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SubAreaId
			{
				[Token(Token = "0x6002AED")]
				[Address(RVA = "0x874EA0", Offset = "0x8742A0", VA = "0x180874EA0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002AEE")]
				[Address(RVA = "0x874F70", Offset = "0x874370", VA = "0x180874F70")]
				set
				{
				}
			}

			[Token(Token = "0x17000939")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int RoomNumber
			{
				[Token(Token = "0x6002AEF")]
				[Address(RVA = "0x873250", Offset = "0x872650", VA = "0x180873250")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002AF0")]
				[Address(RVA = "0x8732B0", Offset = "0x8726B0", VA = "0x1808732B0")]
				set
				{
				}
			}

			[Token(Token = "0x1700093A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ChestNumber
			{
				[Token(Token = "0x6002AF1")]
				[Address(RVA = "0x9C5F60", Offset = "0x9C5360", VA = "0x1809C5F60")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002AF2")]
				[Address(RVA = "0x9C6720", Offset = "0x9C5B20", VA = "0x1809C6720")]
				set
				{
				}
			}

			[Token(Token = "0x1700093B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<int> SkillsId
			{
				[Token(Token = "0x6002AF3")]
				[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700093C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool IsLocked
			{
				[Token(Token = "0x6002AF4")]
				[Address(RVA = "0x9C6000", Offset = "0x9C5400", VA = "0x1809C6000")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002AF5")]
				[Address(RVA = "0x9C6740", Offset = "0x9C5B40", VA = "0x1809C6740")]
				set
				{
				}
			}

			[Token(Token = "0x1700093D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long Price
			{
				[Token(Token = "0x6002AF6")]
				[Address(RVA = "0x9C6060", Offset = "0x9C5460", VA = "0x1809C6060")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6002AF7")]
				[Address(RVA = "0x9C68A0", Offset = "0x9C5CA0", VA = "0x1809C68A0")]
				set
				{
				}
			}

			[Token(Token = "0x6002ADA")]
			[Address(RVA = "0x9C5E90", Offset = "0x9C5290", VA = "0x1809C5E90")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseToSell()
			{
			}

			[Token(Token = "0x6002ADB")]
			[Address(RVA = "0x9C5D70", Offset = "0x9C5170", VA = "0x1809C5D70")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseToSell(HouseToSell other)
			{
			}

			[Token(Token = "0x6002ADC")]
			[Address(RVA = "0x9C53A0", Offset = "0x9C47A0", VA = "0x1809C53A0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public HouseToSell Clone()
			{
				return null;
			}

			[Token(Token = "0x6002AF8")]
			[Address(RVA = "0x9C54F0", Offset = "0x9C48F0", VA = "0x1809C54F0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6002AF9")]
			[Address(RVA = "0x9C5690", Offset = "0x9C4A90", VA = "0x1809C5690", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(HouseToSell other)
			{
				return default(bool);
			}

			[Token(Token = "0x6002AFA")]
			[Address(RVA = "0x9C57E0", Offset = "0x9C4BE0", VA = "0x1809C57E0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6002AFB")]
			[Address(RVA = "0x9C5BE0", Offset = "0x9C4FE0", VA = "0x1809C5BE0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6002AFC")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6002AFD")]
			[Address(RVA = "0x9C63E0", Offset = "0x9C57E0", VA = "0x1809C63E0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6002AFE")]
			[Address(RVA = "0x9C5100", Offset = "0x9C4500", VA = "0x1809C5100", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6002AFF")]
			[Address(RVA = "0x9C5A30", Offset = "0x9C4E30", VA = "0x1809C5A30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(HouseToSell other)
			{
			}

			[Token(Token = "0x6002B00")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6002B01")]
			[Address(RVA = "0x9C6070", Offset = "0x9C5470", VA = "0x1809C6070", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HousesToSellEvent> _parser;

	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E14")]
	public const int PageIndexFieldNumber = 1;

	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x18")]
	private int pageIndex_;

	[Token(Token = "0x4000E16")]
	public const int TotalPageFieldNumber = 2;

	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x1C")]
	private int totalPage_;

	[Token(Token = "0x4000E18")]
	public const int HousesFieldNumber = 3;

	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.HouseToSell> _repeated_houses_codec;

	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.HouseToSell> houses_;

	[Token(Token = "0x17000927")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HousesToSellEvent> Parser
	{
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x9C7120", Offset = "0x9C6520", VA = "0x1809C7120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000928")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x9C7070", Offset = "0x9C6470", VA = "0x1809C7070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000929")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x9C73B0", Offset = "0x9C67B0", VA = "0x1809C73B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700092A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PageIndex
	{
		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700092B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalPage
	{
		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700092C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.HouseToSell> Houses
	{
		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002AC4")]
	[Address(RVA = "0x9C6FF0", Offset = "0x9C63F0", VA = "0x1809C6FF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HousesToSellEvent()
	{
	}

	[Token(Token = "0x6002AC5")]
	[Address(RVA = "0x9C6F50", Offset = "0x9C6350", VA = "0x1809C6F50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HousesToSellEvent(HousesToSellEvent other)
	{
	}

	[Token(Token = "0x6002AC6")]
	[Address(RVA = "0x9C69C0", Offset = "0x9C5DC0", VA = "0x1809C69C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HousesToSellEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002ACC")]
	[Address(RVA = "0x9C6B30", Offset = "0x9C5F30", VA = "0x1809C6B30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ACD")]
	[Address(RVA = "0x9C6A90", Offset = "0x9C5E90", VA = "0x1809C6A90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HousesToSellEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ACE")]
	[Address(RVA = "0x9C6C20", Offset = "0x9C6020", VA = "0x1809C6C20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002ACF")]
	[Address(RVA = "0x9C6D50", Offset = "0x9C6150", VA = "0x1809C6D50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002AD0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002AD1")]
	[Address(RVA = "0x9C72C0", Offset = "0x9C66C0", VA = "0x1809C72C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002AD2")]
	[Address(RVA = "0x9C68B0", Offset = "0x9C5CB0", VA = "0x1809C68B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002AD3")]
	[Address(RVA = "0x9C6CC0", Offset = "0x9C60C0", VA = "0x1809C6CC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HousesToSellEvent other)
	{
	}

	[Token(Token = "0x6002AD4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002AD5")]
	[Address(RVA = "0x9C7170", Offset = "0x9C6570", VA = "0x1809C7170", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
