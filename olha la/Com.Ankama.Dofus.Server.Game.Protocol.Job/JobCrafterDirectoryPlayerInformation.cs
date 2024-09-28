using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000379")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectoryPlayerInformation : IMessage<JobCrafterDirectoryPlayerInformation>, IMessage, IEquatable<JobCrafterDirectoryPlayerInformation>, IDeepCloneable<JobCrafterDirectoryPlayerInformation>, IBufferMessage
{
	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectoryPlayerInformation> _parser;

	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000BED")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x4000BEF")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x4000BF1")]
	public const int AlignmentFieldNumber = 3;

	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x28")]
	private Alignment alignment_;

	[Token(Token = "0x4000BF3")]
	public const int BreedFieldNumber = 4;

	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0x2C")]
	private int breed_;

	[Token(Token = "0x4000BF5")]
	public const int GenderFieldNumber = 5;

	[Token(Token = "0x4000BF6")]
	[FieldOffset(Offset = "0x30")]
	private Gender gender_;

	[Token(Token = "0x4000BF7")]
	public const int IsInWorkshopFieldNumber = 6;

	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0x34")]
	private bool isInWorkshop_;

	[Token(Token = "0x4000BF9")]
	public const int CoordinatesFieldNumber = 7;

	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x38")]
	private MapExtendedCoordinates coordinates_;

	[Token(Token = "0x4000BFB")]
	public const int CanCraftLegendaryFieldNumber = 8;

	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x40")]
	private bool canCraftLegendary_;

	[Token(Token = "0x4000BFD")]
	public const int StatusFieldNumber = 9;

	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0x48")]
	private CharacterStatus status_;

	[Token(Token = "0x170007AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobCrafterDirectoryPlayerInformation> Parser
	{
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x96E6F0", Offset = "0x96DAF0", VA = "0x18096E6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x96E630", Offset = "0x96DA30", VA = "0x18096E630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x96EB20", Offset = "0x96DF20", VA = "0x18096EB20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170007B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x96EC20", Offset = "0x96E020", VA = "0x18096EC20")]
		set
		{
		}
	}

	[Token(Token = "0x170007B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Alignment Alignment
	{
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(Alignment);
		}
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170007B5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Breed
	{
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x170007B6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Gender Gender
	{
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(Gender);
		}
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x170007B7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsInWorkshop
	{
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x96E6E0", Offset = "0x96DAE0", VA = "0x18096E6E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x96EC10", Offset = "0x96E010", VA = "0x18096EC10")]
		set
		{
		}
	}

	[Token(Token = "0x170007B8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapExtendedCoordinates Coordinates
	{
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
		set
		{
		}
	}

	[Token(Token = "0x170007B9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool CanCraftLegendary
	{
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x871BC0", Offset = "0x870FC0", VA = "0x180871BC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x96EC00", Offset = "0x96E000", VA = "0x18096EC00")]
		set
		{
		}
	}

	[Token(Token = "0x170007BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterStatus Status
	{
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x92EFD0", Offset = "0x92E3D0", VA = "0x18092EFD0")]
		set
		{
		}
	}

	[Token(Token = "0x60023EB")]
	[Address(RVA = "0x96E5E0", Offset = "0x96D9E0", VA = "0x18096E5E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryPlayerInformation()
	{
	}

	[Token(Token = "0x60023EC")]
	[Address(RVA = "0x96E4D0", Offset = "0x96D8D0", VA = "0x18096E4D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryPlayerInformation(JobCrafterDirectoryPlayerInformation other)
	{
	}

	[Token(Token = "0x60023ED")]
	[Address(RVA = "0x96DD00", Offset = "0x96D100", VA = "0x18096DD00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryPlayerInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6002400")]
	[Address(RVA = "0x96DE40", Offset = "0x96D240", VA = "0x18096DE40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002401")]
	[Address(RVA = "0x96DF60", Offset = "0x96D360", VA = "0x18096DF60", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(JobCrafterDirectoryPlayerInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002402")]
	[Address(RVA = "0x96E030", Offset = "0x96D430", VA = "0x18096E030", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002403")]
	[Address(RVA = "0x96E370", Offset = "0x96D770", VA = "0x18096E370", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002404")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002405")]
	[Address(RVA = "0x96E9A0", Offset = "0x96DDA0", VA = "0x18096E9A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002406")]
	[Address(RVA = "0x96DB50", Offset = "0x96CF50", VA = "0x18096DB50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002407")]
	[Address(RVA = "0x96E1E0", Offset = "0x96D5E0", VA = "0x18096E1E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobCrafterDirectoryPlayerInformation other)
	{
	}

	[Token(Token = "0x6002408")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002409")]
	[Address(RVA = "0x96E740", Offset = "0x96DB40", VA = "0x18096E740", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
