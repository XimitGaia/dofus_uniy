using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000AC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorAttackedEvent : IMessage<TaxCollectorAttackedEvent>, IMessage, IEquatable<TaxCollectorAttackedEvent>, IDeepCloneable<TaxCollectorAttackedEvent>, IBufferMessage
{
	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorAttackedEvent> _parser;

	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400023F")]
	public const int FirstNameIdFieldNumber = 1;

	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x18")]
	private int firstNameId_;

	[Token(Token = "0x4000241")]
	public const int LastNameIdFieldNumber = 2;

	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x1C")]
	private int lastNameId_;

	[Token(Token = "0x4000243")]
	public const int CoordinatesFieldNumber = 3;

	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x20")]
	private MapExtendedCoordinates coordinates_;

	[Token(Token = "0x4000245")]
	public const int AllianceUidFieldNumber = 4;

	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x28")]
	private string allianceUid_;

	[Token(Token = "0x4000247")]
	public const int AllianceTagFieldNumber = 5;

	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x30")]
	private string allianceTag_;

	[Token(Token = "0x1700015F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorAttackedEvent> Parser
	{
		[Token(Token = "0x600067C")]
		[Address(RVA = "0xA64100", Offset = "0xA63500", VA = "0x180A64100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000160")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600067D")]
		[Address(RVA = "0xA64050", Offset = "0xA63450", VA = "0x180A64050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000161")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600067E")]
		[Address(RVA = "0xA64400", Offset = "0xA63800", VA = "0x180A64400", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000162")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstNameId
	{
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000163")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastNameId
	{
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000164")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapExtendedCoordinates Coordinates
	{
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17000165")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AllianceUid
	{
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000689")]
		[Address(RVA = "0xA64550", Offset = "0xA63950", VA = "0x180A64550")]
		set
		{
		}
	}

	[Token(Token = "0x17000166")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceTag
	{
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600068B")]
		[Address(RVA = "0xA644E0", Offset = "0xA638E0", VA = "0x180A644E0")]
		set
		{
		}
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0xA63FE0", Offset = "0xA633E0", VA = "0x180A63FE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorAttackedEvent()
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0xA63ED0", Offset = "0xA632D0", VA = "0x180A63ED0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorAttackedEvent(TaxCollectorAttackedEvent other)
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0xA638A0", Offset = "0xA62CA0", VA = "0x180A638A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorAttackedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0xA63A80", Offset = "0xA62E80", VA = "0x180A63A80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0xA639E0", Offset = "0xA62DE0", VA = "0x180A639E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorAttackedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0xA63B70", Offset = "0xA62F70", VA = "0x180A63B70", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0xA63D70", Offset = "0xA63170", VA = "0x180A63D70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0xA64310", Offset = "0xA63710", VA = "0x180A64310", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0xA63760", Offset = "0xA62B60", VA = "0x180A63760", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0xA63C60", Offset = "0xA63060", VA = "0x180A63C60", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorAttackedEvent other)
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0xA64150", Offset = "0xA63550", VA = "0x180A64150", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
