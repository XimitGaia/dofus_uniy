using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CE9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightFighterRemovedEvent : IMessage<AllianceFightFighterRemovedEvent>, IMessage, IEquatable<AllianceFightFighterRemovedEvent>, IDeepCloneable<AllianceFightFighterRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4002F81")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightFighterRemovedEvent> _parser;

	[Token(Token = "0x4002F82")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F83")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4002F84")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation fightInformation_;

	[Token(Token = "0x4002F85")]
	public const int FighterIdFieldNumber = 2;

	[Token(Token = "0x4002F86")]
	[FieldOffset(Offset = "0x20")]
	private long fighterId_;

	[Token(Token = "0x17001DBE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceFightFighterRemovedEvent> Parser
	{
		[Token(Token = "0x6008819")]
		[Address(RVA = "0xCAAB50", Offset = "0xCA9F50", VA = "0x180CAAB50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DBF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600881A")]
		[Address(RVA = "0xCAAAA0", Offset = "0xCA9EA0", VA = "0x180CAAAA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600881B")]
		[Address(RVA = "0xCAACC0", Offset = "0xCAA0C0", VA = "0x180CAACC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DC1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialFightInformation FightInformation
	{
		[Token(Token = "0x600881F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008820")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001DC2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FighterId
	{
		[Token(Token = "0x6008821")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008822")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600881C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightFighterRemovedEvent()
	{
	}

	[Token(Token = "0x600881D")]
	[Address(RVA = "0xCAAA20", Offset = "0xCA9E20", VA = "0x180CAAA20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightFighterRemovedEvent(AllianceFightFighterRemovedEvent other)
	{
	}

	[Token(Token = "0x600881E")]
	[Address(RVA = "0xCAA670", Offset = "0xCA9A70", VA = "0x180CAA670", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightFighterRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008823")]
	[Address(RVA = "0xCAA720", Offset = "0xCA9B20", VA = "0x180CAA720", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008824")]
	[Address(RVA = "0x9719A0", Offset = "0x970DA0", VA = "0x1809719A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceFightFighterRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008825")]
	[Address(RVA = "0x971AD0", Offset = "0x970ED0", VA = "0x180971AD0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008826")]
	[Address(RVA = "0xCAA8C0", Offset = "0xCA9CC0", VA = "0x180CAA8C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008827")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008828")]
	[Address(RVA = "0x972120", Offset = "0x971520", VA = "0x180972120", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008829")]
	[Address(RVA = "0xCAA5B0", Offset = "0xCA99B0", VA = "0x180CAA5B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600882A")]
	[Address(RVA = "0xCAA7E0", Offset = "0xCA9BE0", VA = "0x180CAA7E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFightFighterRemovedEvent other)
	{
	}

	[Token(Token = "0x600882B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600882C")]
	[Address(RVA = "0xCAABA0", Offset = "0xCA9FA0", VA = "0x180CAABA0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
