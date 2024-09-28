using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AF6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismLocalizedInformation : IMessage<PrismLocalizedInformation>, IMessage, IEquatable<PrismLocalizedInformation>, IDeepCloneable<PrismLocalizedInformation>, IBufferMessage
{
	[Token(Token = "0x4002874")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismLocalizedInformation> _parser;

	[Token(Token = "0x4002875")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002876")]
	public const int SubAreaIdFieldNumber = 1;

	[Token(Token = "0x4002877")]
	[FieldOffset(Offset = "0x18")]
	private int subAreaId_;

	[Token(Token = "0x4002878")]
	public const int AllianceUidFieldNumber = 2;

	[Token(Token = "0x4002879")]
	[FieldOffset(Offset = "0x20")]
	private string allianceUid_;

	[Token(Token = "0x400287A")]
	public const int MapCoordinatesFieldNumber = 3;

	[Token(Token = "0x400287B")]
	[FieldOffset(Offset = "0x28")]
	private MapCoordinates mapCoordinates_;

	[Token(Token = "0x400287C")]
	public const int MapIdFieldNumber = 4;

	[Token(Token = "0x400287D")]
	[FieldOffset(Offset = "0x30")]
	private long mapId_;

	[Token(Token = "0x400287E")]
	public const int PrismFieldNumber = 5;

	[Token(Token = "0x400287F")]
	[FieldOffset(Offset = "0x38")]
	private PrismInformation prism_;

	[Token(Token = "0x17001937")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PrismLocalizedInformation> Parser
	{
		[Token(Token = "0x6007320")]
		[Address(RVA = "0xBFE430", Offset = "0xBFD830", VA = "0x180BFE430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001938")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007321")]
		[Address(RVA = "0xBFE380", Offset = "0xBFD780", VA = "0x180BFE380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001939")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007322")]
		[Address(RVA = "0xBFE740", Offset = "0xBFDB40", VA = "0x180BFE740", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700193A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubAreaId
	{
		[Token(Token = "0x6007326")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007327")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700193B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceUid
	{
		[Token(Token = "0x6007328")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007329")]
		[Address(RVA = "0xBFE820", Offset = "0xBFDC20", VA = "0x180BFE820")]
		set
		{
		}
	}

	[Token(Token = "0x1700193C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapCoordinates MapCoordinates
	{
		[Token(Token = "0x600732A")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600732B")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x1700193D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x600732C")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600732D")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700193E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismInformation Prism
	{
		[Token(Token = "0x600732E")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600732F")]
		[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
		set
		{
		}
	}

	[Token(Token = "0x6007323")]
	[Address(RVA = "0xBFE200", Offset = "0xBFD600", VA = "0x180BFE200")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismLocalizedInformation()
	{
	}

	[Token(Token = "0x6007324")]
	[Address(RVA = "0xBFE250", Offset = "0xBFD650", VA = "0x180BFE250")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismLocalizedInformation(PrismLocalizedInformation other)
	{
	}

	[Token(Token = "0x6007325")]
	[Address(RVA = "0xBFDB60", Offset = "0xBFCF60", VA = "0x180BFDB60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismLocalizedInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6007330")]
	[Address(RVA = "0xBFDCC0", Offset = "0xBFD0C0", VA = "0x180BFDCC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007331")]
	[Address(RVA = "0xBFDDB0", Offset = "0xBFD1B0", VA = "0x180BFDDB0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PrismLocalizedInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007332")]
	[Address(RVA = "0xBFDE50", Offset = "0xBFD250", VA = "0x180BFDE50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007333")]
	[Address(RVA = "0xBFE0A0", Offset = "0xBFD4A0", VA = "0x180BFE0A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007334")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007335")]
	[Address(RVA = "0xBFE650", Offset = "0xBFDA50", VA = "0x180BFE650", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007336")]
	[Address(RVA = "0xBFDA20", Offset = "0xBFCE20", VA = "0x180BFDA20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007337")]
	[Address(RVA = "0xBFDF40", Offset = "0xBFD340", VA = "0x180BFDF40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PrismLocalizedInformation other)
	{
	}

	[Token(Token = "0x6007338")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007339")]
	[Address(RVA = "0xBFE480", Offset = "0xBFD880", VA = "0x180BFE480", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
