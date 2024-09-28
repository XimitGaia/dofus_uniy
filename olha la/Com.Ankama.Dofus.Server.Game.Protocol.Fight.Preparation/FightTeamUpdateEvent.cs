using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000633")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamUpdateEvent : IMessage<FightTeamUpdateEvent>, IMessage, IEquatable<FightTeamUpdateEvent>, IDeepCloneable<FightTeamUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40015DB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamUpdateEvent> _parser;

	[Token(Token = "0x40015DC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015DD")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40015DE")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40015DF")]
	public const int TeamFieldNumber = 2;

	[Token(Token = "0x40015E0")]
	[FieldOffset(Offset = "0x20")]
	private FightTeamInformation team_;

	[Token(Token = "0x17000E46")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTeamUpdateEvent> Parser
	{
		[Token(Token = "0x600426C")]
		[Address(RVA = "0xA850E0", Offset = "0xA844E0", VA = "0x180A850E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E47")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600426D")]
		[Address(RVA = "0xA85030", Offset = "0xA84430", VA = "0x180A85030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E48")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600426E")]
		[Address(RVA = "0xA85250", Offset = "0xA84650", VA = "0x180A85250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E49")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x6004272")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004273")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E4A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamInformation Team
	{
		[Token(Token = "0x6004274")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600426F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamUpdateEvent()
	{
	}

	[Token(Token = "0x6004270")]
	[Address(RVA = "0xA84FC0", Offset = "0xA843C0", VA = "0x180A84FC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamUpdateEvent(FightTeamUpdateEvent other)
	{
	}

	[Token(Token = "0x6004271")]
	[Address(RVA = "0xA84C40", Offset = "0xA84040", VA = "0x180A84C40", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004276")]
	[Address(RVA = "0xA84CE0", Offset = "0xA840E0", VA = "0x180A84CE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004277")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTeamUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004278")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004279")]
	[Address(RVA = "0xA84E60", Offset = "0xA84260", VA = "0x180A84E60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600427A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600427B")]
	[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600427C")]
	[Address(RVA = "0xA84B80", Offset = "0xA83F80", VA = "0x180A84B80", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600427D")]
	[Address(RVA = "0xA84D90", Offset = "0xA84190", VA = "0x180A84D90", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTeamUpdateEvent other)
	{
	}

	[Token(Token = "0x600427E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600427F")]
	[Address(RVA = "0xA85130", Offset = "0xA84530", VA = "0x180A85130", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
