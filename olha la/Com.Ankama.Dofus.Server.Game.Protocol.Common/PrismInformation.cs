using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AF2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismInformation : IMessage<PrismInformation>, IMessage, IEquatable<PrismInformation>, IDeepCloneable<PrismInformation>, IBufferMessage
{
	[Token(Token = "0x2000AF3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000AF4")]
		public enum PrismState
		{
			[Token(Token = "0x400286E")]
			[OriginalName("NORMAL")]
			Normal,
			[Token(Token = "0x400286F")]
			[OriginalName("WEAKENED")]
			Weakened,
			[Token(Token = "0x4002870")]
			[OriginalName("VULNERABLE")]
			Vulnerable,
			[Token(Token = "0x4002871")]
			[OriginalName("PROTECTED")]
			Protected,
			[Token(Token = "0x4002872")]
			[OriginalName("INHIBITED")]
			Inhibited
		}
	}

	[Token(Token = "0x4002857")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismInformation> _parser;

	[Token(Token = "0x4002858")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002859")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x400285A")]
	public const int StateFieldNumber = 1;

	[Token(Token = "0x400285B")]
	[FieldOffset(Offset = "0x1C")]
	private Types.PrismState state_;

	[Token(Token = "0x400285C")]
	public const int PlacementDateFieldNumber = 2;

	[Token(Token = "0x400285D")]
	[FieldOffset(Offset = "0x20")]
	private long placementDate_;

	[Token(Token = "0x400285E")]
	public const int NuggetsCountFieldNumber = 3;

	[Token(Token = "0x400285F")]
	[FieldOffset(Offset = "0x28")]
	private long nuggetsCount_;

	[Token(Token = "0x4002860")]
	public const int DurabilityFieldNumber = 4;

	[Token(Token = "0x4002861")]
	[FieldOffset(Offset = "0x30")]
	private int durability_;

	[Token(Token = "0x4002862")]
	public const int NextEvolutionDateFieldNumber = 5;

	[Token(Token = "0x4002863")]
	[FieldOffset(Offset = "0x38")]
	private long nextEvolutionDate_;

	[Token(Token = "0x4002864")]
	public const int AllianceInformationFieldNumber = 6;

	[Token(Token = "0x4002865")]
	[FieldOffset(Offset = "0x40")]
	private AllianceInformation allianceInformation_;

	[Token(Token = "0x4002866")]
	public const int ModuleFieldNumber = 7;

	[Token(Token = "0x4002867")]
	[FieldOffset(Offset = "0x48")]
	private PrismModule module_;

	[Token(Token = "0x4002868")]
	public const int CristalFieldNumber = 8;

	[Token(Token = "0x4002869")]
	[FieldOffset(Offset = "0x50")]
	private PrismCristal cristal_;

	[Token(Token = "0x400286A")]
	public const int CristalNumberLeftFieldNumber = 9;

	[Token(Token = "0x400286B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int CristalNumberLeftDefaultValue;

	[Token(Token = "0x400286C")]
	[FieldOffset(Offset = "0x58")]
	private int cristalNumberLeft_;

	[Token(Token = "0x1700192A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PrismInformation> Parser
	{
		[Token(Token = "0x60072F8")]
		[Address(RVA = "0xBFD4B0", Offset = "0xBFC8B0", VA = "0x180BFD4B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60072F9")]
		[Address(RVA = "0xBFD400", Offset = "0xBFC800", VA = "0x180BFD400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60072FA")]
		[Address(RVA = "0xBFD930", Offset = "0xBFCD30", VA = "0x180BFD930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PrismState State
	{
		[Token(Token = "0x60072FE")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.PrismState);
		}
		[Token(Token = "0x60072FF")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700192E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlacementDate
	{
		[Token(Token = "0x6007300")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007301")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700192F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long NuggetsCount
	{
		[Token(Token = "0x6007302")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007303")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17001930")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Durability
	{
		[Token(Token = "0x6007304")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007305")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17001931")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NextEvolutionDate
	{
		[Token(Token = "0x6007306")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007307")]
		[Address(RVA = "0x9EFE00", Offset = "0x9EF200", VA = "0x1809EFE00")]
		set
		{
		}
	}

	[Token(Token = "0x17001932")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation AllianceInformation
	{
		[Token(Token = "0x6007308")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007309")]
		[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
		set
		{
		}
	}

	[Token(Token = "0x17001933")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismModule Module
	{
		[Token(Token = "0x600730A")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x600730B")]
		[Address(RVA = "0x92EFD0", Offset = "0x92E3D0", VA = "0x18092EFD0")]
		set
		{
		}
	}

	[Token(Token = "0x17001934")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismCristal Cristal
	{
		[Token(Token = "0x600730C")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600730D")]
		[Address(RVA = "0x912500", Offset = "0x911900", VA = "0x180912500")]
		set
		{
		}
	}

	[Token(Token = "0x17001935")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CristalNumberLeft
	{
		[Token(Token = "0x600730E")]
		[Address(RVA = "0xBFD390", Offset = "0xBFC790", VA = "0x180BFD390")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600730F")]
		[Address(RVA = "0xBFDA10", Offset = "0xBFCE10", VA = "0x180BFDA10")]
		set
		{
		}
	}

	[Token(Token = "0x17001936")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCristalNumberLeft
	{
		[Token(Token = "0x6007310")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60072FB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismInformation()
	{
	}

	[Token(Token = "0x60072FC")]
	[Address(RVA = "0xBFD190", Offset = "0xBFC590", VA = "0x180BFD190")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismInformation(PrismInformation other)
	{
	}

	[Token(Token = "0x60072FD")]
	[Address(RVA = "0xBFC8B0", Offset = "0xBFBCB0", VA = "0x180BFC8B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6007311")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearCristalNumberLeft()
	{
	}

	[Token(Token = "0x6007312")]
	[Address(RVA = "0xBFCA10", Offset = "0xBFBE10", VA = "0x180BFCA10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007313")]
	[Address(RVA = "0xBFC910", Offset = "0xBFBD10", VA = "0x180BFC910", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PrismInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007314")]
	[Address(RVA = "0xBFCB50", Offset = "0xBFBF50", VA = "0x180BFCB50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007315")]
	[Address(RVA = "0xBFD020", Offset = "0xBFC420", VA = "0x180BFD020", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007316")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007317")]
	[Address(RVA = "0xBFD770", Offset = "0xBFCB70", VA = "0x180BFD770", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007318")]
	[Address(RVA = "0xBFC670", Offset = "0xBFBA70", VA = "0x180BFC670", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007319")]
	[Address(RVA = "0xBFCD00", Offset = "0xBFC100", VA = "0x180BFCD00", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PrismInformation other)
	{
	}

	[Token(Token = "0x600731A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600731B")]
	[Address(RVA = "0xBFD500", Offset = "0xBFC900", VA = "0x180BFD500", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
