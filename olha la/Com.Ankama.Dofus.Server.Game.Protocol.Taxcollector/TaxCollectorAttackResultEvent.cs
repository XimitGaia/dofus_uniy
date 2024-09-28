using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000AE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorAttackResultEvent : IMessage<TaxCollectorAttackResultEvent>, IMessage, IEquatable<TaxCollectorAttackResultEvent>, IDeepCloneable<TaxCollectorAttackResultEvent>, IBufferMessage
{
	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorAttackResultEvent> _parser;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400024C")]
	public const int DeadFieldNumber = 1;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x18")]
	private bool dead_;

	[Token(Token = "0x400024E")]
	public const int FirstNameIdFieldNumber = 2;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x1C")]
	private int firstNameId_;

	[Token(Token = "0x4000250")]
	public const int LastNameIdFieldNumber = 3;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x20")]
	private int lastNameId_;

	[Token(Token = "0x4000252")]
	public const int CoordinatesFieldNumber = 4;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x28")]
	private MapExtendedCoordinates coordinates_;

	[Token(Token = "0x4000254")]
	public const int AllianceUidFieldNumber = 5;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x30")]
	private string allianceUid_;

	[Token(Token = "0x4000256")]
	public const int AllianceTagFieldNumber = 6;

	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x38")]
	private string allianceTag_;

	[Token(Token = "0x17000167")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorAttackResultEvent> Parser
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0xA63260", Offset = "0xA62660", VA = "0x180A63260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000168")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600069B")]
		[Address(RVA = "0xA631B0", Offset = "0xA625B0", VA = "0x180A631B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000169")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600069C")]
		[Address(RVA = "0xA635A0", Offset = "0xA629A0", VA = "0x180A635A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700016A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Dead
	{
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x1700016B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FirstNameId
	{
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700016C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastNameId
	{
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700016D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapExtendedCoordinates Coordinates
	{
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x1700016E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceUid
	{
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xA636F0", Offset = "0xA62AF0", VA = "0x180A636F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700016F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceTag
	{
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xA63680", Offset = "0xA62A80", VA = "0x180A63680")]
		set
		{
		}
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0xA63030", Offset = "0xA62430", VA = "0x180A63030")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorAttackResultEvent()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0xA630A0", Offset = "0xA624A0", VA = "0x180A630A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorAttackResultEvent(TaxCollectorAttackResultEvent other)
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0xA62990", Offset = "0xA61D90", VA = "0x180A62990", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorAttackResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0xA62B80", Offset = "0xA61F80", VA = "0x180A62B80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0xA62AD0", Offset = "0xA61ED0", VA = "0x180A62AD0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorAttackResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0xA62C70", Offset = "0xA62070", VA = "0x180A62C70", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0xA62ED0", Offset = "0xA622D0", VA = "0x180A62ED0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0xA63480", Offset = "0xA62880", VA = "0x180A63480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0xA62840", Offset = "0xA61C40", VA = "0x180A62840", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0xA62DB0", Offset = "0xA621B0", VA = "0x180A62DB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorAttackResultEvent other)
	{
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0xA632B0", Offset = "0xA626B0", VA = "0x180A632B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
