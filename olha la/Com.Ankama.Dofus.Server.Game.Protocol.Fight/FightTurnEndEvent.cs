using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x2000604")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTurnEndEvent : IMessage<FightTurnEndEvent>, IMessage, IEquatable<FightTurnEndEvent>, IDeepCloneable<FightTurnEndEvent>, IBufferMessage
{
	[Token(Token = "0x4001516")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTurnEndEvent> _parser;

	[Token(Token = "0x4001517")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001518")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001519")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x17000DD1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTurnEndEvent> Parser
	{
		[Token(Token = "0x6004053")]
		[Address(RVA = "0xA4C710", Offset = "0xA4BB10", VA = "0x180A4C710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DD2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004054")]
		[Address(RVA = "0xA4C660", Offset = "0xA4BA60", VA = "0x180A4C660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DD3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004055")]
		[Address(RVA = "0xA4C760", Offset = "0xA4BB60", VA = "0x180A4C760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DD4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6004059")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600405A")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6004056")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTurnEndEvent()
	{
	}

	[Token(Token = "0x6004057")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTurnEndEvent(FightTurnEndEvent other)
	{
	}

	[Token(Token = "0x6004058")]
	[Address(RVA = "0xA4C3F0", Offset = "0xA4B7F0", VA = "0x180A4C3F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnEndEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600405B")]
	[Address(RVA = "0xA4C470", Offset = "0xA4B870", VA = "0x180A4C470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600405C")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTurnEndEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600405D")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600405E")]
	[Address(RVA = "0xA4C500", Offset = "0xA4B900", VA = "0x180A4C500", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600405F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004060")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004061")]
	[Address(RVA = "0xA4C360", Offset = "0xA4B760", VA = "0x180A4C360", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004062")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTurnEndEvent other)
	{
	}

	[Token(Token = "0x6004063")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004064")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
