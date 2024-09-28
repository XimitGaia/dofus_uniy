using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005FE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightRefreshCharacterStatsEvent : IMessage<FightRefreshCharacterStatsEvent>, IMessage, IEquatable<FightRefreshCharacterStatsEvent>, IDeepCloneable<FightRefreshCharacterStatsEvent>, IBufferMessage
{
	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightRefreshCharacterStatsEvent> _parser;

	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001506")]
	public const int FighterIdFieldNumber = 1;

	[Token(Token = "0x4001507")]
	[FieldOffset(Offset = "0x18")]
	private long fighterId_;

	[Token(Token = "0x4001508")]
	public const int StatsFieldNumber = 2;

	[Token(Token = "0x4001509")]
	[FieldOffset(Offset = "0x20")]
	private FightCharacteristics stats_;

	[Token(Token = "0x17000DC4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightRefreshCharacterStatsEvent> Parser
	{
		[Token(Token = "0x6004010")]
		[Address(RVA = "0xA47CE0", Offset = "0xA470E0", VA = "0x180A47CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DC5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004011")]
		[Address(RVA = "0xA47C30", Offset = "0xA47030", VA = "0x180A47C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DC6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004012")]
		[Address(RVA = "0xA47E50", Offset = "0xA47250", VA = "0x180A47E50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DC7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long FighterId
	{
		[Token(Token = "0x6004016")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004017")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000DC8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightCharacteristics Stats
	{
		[Token(Token = "0x6004018")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004019")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6004013")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightRefreshCharacterStatsEvent()
	{
	}

	[Token(Token = "0x6004014")]
	[Address(RVA = "0xA47BB0", Offset = "0xA46FB0", VA = "0x180A47BB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightRefreshCharacterStatsEvent(FightRefreshCharacterStatsEvent other)
	{
	}

	[Token(Token = "0x6004015")]
	[Address(RVA = "0xA47810", Offset = "0xA46C10", VA = "0x180A47810", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightRefreshCharacterStatsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600401A")]
	[Address(RVA = "0xA478B0", Offset = "0xA46CB0", VA = "0x180A478B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600401B")]
	[Address(RVA = "0x953270", Offset = "0x952670", VA = "0x180953270", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightRefreshCharacterStatsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600401C")]
	[Address(RVA = "0x9533A0", Offset = "0x9527A0", VA = "0x1809533A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600401D")]
	[Address(RVA = "0xA47A50", Offset = "0xA46E50", VA = "0x180A47A50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600401E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600401F")]
	[Address(RVA = "0x953910", Offset = "0x952D10", VA = "0x180953910", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004020")]
	[Address(RVA = "0xA47750", Offset = "0xA46B50", VA = "0x180A47750", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004021")]
	[Address(RVA = "0xA47970", Offset = "0xA46D70", VA = "0x180A47970", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightRefreshCharacterStatsEvent other)
	{
	}

	[Token(Token = "0x6004022")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004023")]
	[Address(RVA = "0xA47D30", Offset = "0xA47130", VA = "0x180A47D30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
