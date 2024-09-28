using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000B0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorHarvestedEvent : IMessage<TaxCollectorHarvestedEvent>, IMessage, IEquatable<TaxCollectorHarvestedEvent>, IDeepCloneable<TaxCollectorHarvestedEvent>, IBufferMessage
{
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorHarvestedEvent> _parser;

	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400025B")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x400025D")]
	public const int HarvesterIdFieldNumber = 2;

	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x20")]
	private long harvesterId_;

	[Token(Token = "0x400025F")]
	public const int HarvesterNameFieldNumber = 3;

	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x28")]
	private string harvesterName_;

	[Token(Token = "0x17000170")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorHarvestedEvent> Parser
	{
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xA665B0", Offset = "0xA659B0", VA = "0x180A665B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000171")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xA66500", Offset = "0xA65900", VA = "0x180A66500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000172")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xA667D0", Offset = "0xA65BD0", VA = "0x180A667D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000173")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TaxCollectorUid
	{
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xA66920", Offset = "0xA65D20", VA = "0x180A66920")]
		set
		{
		}
	}

	[Token(Token = "0x17000174")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long HarvesterId
	{
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000175")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HarvesterName
	{
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xA668B0", Offset = "0xA65CB0", VA = "0x180A668B0")]
		set
		{
		}
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0xA663B0", Offset = "0xA657B0", VA = "0x180A663B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorHarvestedEvent()
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0xA66420", Offset = "0xA65820", VA = "0x180A66420")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorHarvestedEvent(TaxCollectorHarvestedEvent other)
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0xA65EA0", Offset = "0xA652A0", VA = "0x180A65EA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorHarvestedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xA66030", Offset = "0xA65430", VA = "0x180A66030", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xA65FB0", Offset = "0xA653B0", VA = "0x180A65FB0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorHarvestedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0xA66100", Offset = "0xA65500", VA = "0x180A66100", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0xA66250", Offset = "0xA65650", VA = "0x180A66250", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0xA66710", Offset = "0xA65B10", VA = "0x180A66710", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0xA65DB0", Offset = "0xA651B0", VA = "0x180A65DB0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0xA661C0", Offset = "0xA655C0", VA = "0x180A661C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorHarvestedEvent other)
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0xA66600", Offset = "0xA65A00", VA = "0x180A66600", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
