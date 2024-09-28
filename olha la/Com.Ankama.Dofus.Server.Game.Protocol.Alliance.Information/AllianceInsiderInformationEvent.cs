using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CBE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceInsiderInformationEvent : IMessage<AllianceInsiderInformationEvent>, IMessage, IEquatable<AllianceInsiderInformationEvent>, IDeepCloneable<AllianceInsiderInformationEvent>, IBufferMessage
{
	[Token(Token = "0x4002EF6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceInsiderInformationEvent> _parser;

	[Token(Token = "0x4002EF7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002EF8")]
	public const int InformationFieldNumber = 1;

	[Token(Token = "0x4002EF9")]
	[FieldOffset(Offset = "0x18")]
	private AllianceInformation information_;

	[Token(Token = "0x4002EFA")]
	public const int MembersFieldNumber = 2;

	[Token(Token = "0x4002EFB")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<AllianceMemberInformation> _repeated_members_codec;

	[Token(Token = "0x4002EFC")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<AllianceMemberInformation> members_;

	[Token(Token = "0x4002EFD")]
	public const int PrismsFieldNumber = 3;

	[Token(Token = "0x4002EFE")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<PrismLocalizedInformation> _repeated_prisms_codec;

	[Token(Token = "0x4002EFF")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<PrismLocalizedInformation> prisms_;

	[Token(Token = "0x4002F00")]
	public const int TaxCollectorsFieldNumber = 4;

	[Token(Token = "0x4002F01")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<TaxCollectorInformation> _repeated_taxCollectors_codec;

	[Token(Token = "0x4002F02")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<TaxCollectorInformation> taxCollectors_;

	[Token(Token = "0x17001D5C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceInsiderInformationEvent> Parser
	{
		[Token(Token = "0x6008636")]
		[Address(RVA = "0xC933D0", Offset = "0xC927D0", VA = "0x180C933D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D5D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008637")]
		[Address(RVA = "0xC93320", Offset = "0xC92720", VA = "0x180C93320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D5E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008638")]
		[Address(RVA = "0xC937A0", Offset = "0xC92BA0", VA = "0x180C937A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D5F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation Information
	{
		[Token(Token = "0x600863C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600863D")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<AllianceMemberInformation> Members
	{
		[Token(Token = "0x600863E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D61")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PrismLocalizedInformation> Prisms
	{
		[Token(Token = "0x600863F")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D62")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TaxCollectorInformation> TaxCollectors
	{
		[Token(Token = "0x6008640")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008639")]
	[Address(RVA = "0xC93220", Offset = "0xC92620", VA = "0x180C93220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInsiderInformationEvent()
	{
	}

	[Token(Token = "0x600863A")]
	[Address(RVA = "0xC93100", Offset = "0xC92500", VA = "0x180C93100")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInsiderInformationEvent(AllianceInsiderInformationEvent other)
	{
	}

	[Token(Token = "0x600863B")]
	[Address(RVA = "0xC927D0", Offset = "0xC91BD0", VA = "0x180C927D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInsiderInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008641")]
	[Address(RVA = "0xC92A30", Offset = "0xC91E30", VA = "0x180C92A30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008642")]
	[Address(RVA = "0xC92920", Offset = "0xC91D20", VA = "0x180C92920", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceInsiderInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008643")]
	[Address(RVA = "0xC92B80", Offset = "0xC91F80", VA = "0x180C92B80", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008644")]
	[Address(RVA = "0xC92DA0", Offset = "0xC921A0", VA = "0x180C92DA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008645")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008646")]
	[Address(RVA = "0xC93660", Offset = "0xC92A60", VA = "0x180C93660", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008647")]
	[Address(RVA = "0xC92670", Offset = "0xC91A70", VA = "0x180C92670", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008648")]
	[Address(RVA = "0xC92C60", Offset = "0xC92060", VA = "0x180C92C60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceInsiderInformationEvent other)
	{
	}

	[Token(Token = "0x6008649")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600864A")]
	[Address(RVA = "0xC93420", Offset = "0xC92820", VA = "0x180C93420", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
