using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A9E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseInstance : IMessage<HouseInstance>, IMessage, IEquatable<HouseInstance>, IDeepCloneable<HouseInstance>, IBufferMessage
{
	[Token(Token = "0x40026B0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseInstance> _parser;

	[Token(Token = "0x40026B1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40026B2")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40026B3")]
	public const int InstanceIdFieldNumber = 1;

	[Token(Token = "0x40026B4")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x40026B5")]
	public const int SecondHandFieldNumber = 2;

	[Token(Token = "0x40026B6")]
	[FieldOffset(Offset = "0x20")]
	private bool secondHand_;

	[Token(Token = "0x40026B7")]
	public const int IsLockedFieldNumber = 3;

	[Token(Token = "0x40026B8")]
	[FieldOffset(Offset = "0x21")]
	private bool isLocked_;

	[Token(Token = "0x40026B9")]
	public const int AccountTagFieldNumber = 4;

	[Token(Token = "0x40026BA")]
	[FieldOffset(Offset = "0x28")]
	private AccountTag accountTag_;

	[Token(Token = "0x40026BB")]
	public const int HasOwnerFieldNumber = 5;

	[Token(Token = "0x40026BC")]
	[FieldOffset(Offset = "0x30")]
	private bool hasOwner_;

	[Token(Token = "0x40026BD")]
	public const int PriceFieldNumber = 6;

	[Token(Token = "0x40026BE")]
	[FieldOffset(Offset = "0x8")]
	private static readonly long PriceDefaultValue;

	[Token(Token = "0x40026BF")]
	[FieldOffset(Offset = "0x38")]
	private long price_;

	[Token(Token = "0x40026C0")]
	public const int IsSaleLockedFieldNumber = 7;

	[Token(Token = "0x40026C1")]
	[FieldOffset(Offset = "0x40")]
	private bool isSaleLocked_;

	[Token(Token = "0x40026C2")]
	public const int IsAdminLockedFieldNumber = 8;

	[Token(Token = "0x40026C3")]
	[FieldOffset(Offset = "0x41")]
	private bool isAdminLocked_;

	[Token(Token = "0x40026C4")]
	public const int GuildInformationFieldNumber = 9;

	[Token(Token = "0x40026C5")]
	[FieldOffset(Offset = "0x48")]
	private GuildInformation guildInformation_;

	[Token(Token = "0x40026C6")]
	public const int RoomsCountFieldNumber = 10;

	[Token(Token = "0x40026C7")]
	[FieldOffset(Offset = "0x50")]
	private int roomsCount_;

	[Token(Token = "0x40026C8")]
	public const int ChestsCountFieldNumber = 11;

	[Token(Token = "0x40026C9")]
	[FieldOffset(Offset = "0x54")]
	private int chestsCount_;

	[Token(Token = "0x40026CA")]
	public const int SkillsIdFieldNumber = 12;

	[Token(Token = "0x40026CB")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_skillsId_codec;

	[Token(Token = "0x40026CC")]
	[FieldOffset(Offset = "0x58")]
	private readonly RepeatedField<int> skillsId_;

	[Token(Token = "0x17001826")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HouseInstance> Parser
	{
		[Token(Token = "0x6006EF8")]
		[Address(RVA = "0xBDDD60", Offset = "0xBDD160", VA = "0x180BDDD60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001827")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006EF9")]
		[Address(RVA = "0xBDDCA0", Offset = "0xBDD0A0", VA = "0x180BDDCA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001828")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006EFA")]
		[Address(RVA = "0xBDE3A0", Offset = "0xBDD7A0", VA = "0x180BDE3A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001829")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int InstanceId
	{
		[Token(Token = "0x6006EFE")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006EFF")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700182A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool SecondHand
	{
		[Token(Token = "0x6006F00")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006F01")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x1700182B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsLocked
	{
		[Token(Token = "0x6006F02")]
		[Address(RVA = "0x911F20", Offset = "0x911320", VA = "0x180911F20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006F03")]
		[Address(RVA = "0x99BC90", Offset = "0x99B090", VA = "0x18099BC90")]
		set
		{
		}
	}

	[Token(Token = "0x1700182C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AccountTag AccountTag
	{
		[Token(Token = "0x6006F04")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F05")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x1700182D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasOwner
	{
		[Token(Token = "0x6006F06")]
		[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006F07")]
		[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700182E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Price
	{
		[Token(Token = "0x6006F08")]
		[Address(RVA = "0xBDDDB0", Offset = "0xBDD1B0", VA = "0x180BDDDB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006F09")]
		[Address(RVA = "0xAEFA30", Offset = "0xAEEE30", VA = "0x180AEFA30")]
		set
		{
		}
	}

	[Token(Token = "0x1700182F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPrice
	{
		[Token(Token = "0x6006F0A")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSaleLocked
	{
		[Token(Token = "0x6006F0C")]
		[Address(RVA = "0x871BC0", Offset = "0x870FC0", VA = "0x180871BC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006F0D")]
		[Address(RVA = "0x96EC00", Offset = "0x96E000", VA = "0x18096EC00")]
		set
		{
		}
	}

	[Token(Token = "0x17001831")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsAdminLocked
	{
		[Token(Token = "0x6006F0E")]
		[Address(RVA = "0xBDDD50", Offset = "0xBDD150", VA = "0x180BDDD50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006F0F")]
		[Address(RVA = "0xBDE480", Offset = "0xBDD880", VA = "0x180BDE480")]
		set
		{
		}
	}

	[Token(Token = "0x17001832")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformation GuildInformation
	{
		[Token(Token = "0x6006F10")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F11")]
		[Address(RVA = "0x92EFD0", Offset = "0x92E3D0", VA = "0x18092EFD0")]
		set
		{
		}
	}

	[Token(Token = "0x17001833")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RoomsCount
	{
		[Token(Token = "0x6006F12")]
		[Address(RVA = "0x874EA0", Offset = "0x8742A0", VA = "0x180874EA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006F13")]
		[Address(RVA = "0x874F70", Offset = "0x874370", VA = "0x180874F70")]
		set
		{
		}
	}

	[Token(Token = "0x17001834")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ChestsCount
	{
		[Token(Token = "0x6006F14")]
		[Address(RVA = "0x873250", Offset = "0x872650", VA = "0x180873250")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006F15")]
		[Address(RVA = "0x8732B0", Offset = "0x8726B0", VA = "0x1808732B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001835")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SkillsId
	{
		[Token(Token = "0x6006F16")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006EFB")]
	[Address(RVA = "0xBDDAF0", Offset = "0xBDCEF0", VA = "0x180BDDAF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseInstance()
	{
	}

	[Token(Token = "0x6006EFC")]
	[Address(RVA = "0xBDDB70", Offset = "0xBDCF70", VA = "0x180BDDB70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseInstance(HouseInstance other)
	{
	}

	[Token(Token = "0x6006EFD")]
	[Address(RVA = "0xBDD110", Offset = "0xBDC510", VA = "0x180BDD110", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseInstance Clone()
	{
		return null;
	}

	[Token(Token = "0x6006F0B")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearPrice()
	{
	}

	[Token(Token = "0x6006F17")]
	[Address(RVA = "0xBDD260", Offset = "0xBDC660", VA = "0x180BDD260", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006F18")]
	[Address(RVA = "0xBDD3E0", Offset = "0xBDC7E0", VA = "0x180BDD3E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HouseInstance other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006F19")]
	[Address(RVA = "0xBDD520", Offset = "0xBDC920", VA = "0x180BDD520", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006F1A")]
	[Address(RVA = "0xBDD950", Offset = "0xBDCD50", VA = "0x180BDD950", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006F1B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006F1C")]
	[Address(RVA = "0xBDE130", Offset = "0xBDD530", VA = "0x180BDE130", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006F1D")]
	[Address(RVA = "0xBDCED0", Offset = "0xBDC2D0", VA = "0x180BDCED0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006F1E")]
	[Address(RVA = "0xBDD790", Offset = "0xBDCB90", VA = "0x180BDD790", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HouseInstance other)
	{
	}

	[Token(Token = "0x6006F1F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006F20")]
	[Address(RVA = "0xBDDE20", Offset = "0xBDD220", VA = "0x180BDDE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
