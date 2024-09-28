using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000639")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightLeaveEvent : IMessage<FightLeaveEvent>, IMessage, IEquatable<FightLeaveEvent>, IDeepCloneable<FightLeaveEvent>, IBufferMessage
{
	[Token(Token = "0x40015F2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightLeaveEvent> _parser;

	[Token(Token = "0x40015F3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015F4")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x17000E56")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightLeaveEvent> Parser
	{
		[Token(Token = "0x60042B6")]
		[Address(RVA = "0xA7D370", Offset = "0xA7C770", VA = "0x180A7D370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E57")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60042B7")]
		[Address(RVA = "0xA7D2C0", Offset = "0xA7C6C0", VA = "0x180A7D2C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E58")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60042B8")]
		[Address(RVA = "0xA7D3C0", Offset = "0xA7C7C0", VA = "0x180A7D3C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E59")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x60042B9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightLeaveEvent()
	{
	}

	[Token(Token = "0x60042BA")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightLeaveEvent(FightLeaveEvent other)
	{
	}

	[Token(Token = "0x60042BB")]
	[Address(RVA = "0xA7D050", Offset = "0xA7C450", VA = "0x180A7D050", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightLeaveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60042BE")]
	[Address(RVA = "0xA7D0D0", Offset = "0xA7C4D0", VA = "0x180A7D0D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60042BF")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightLeaveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60042C0")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60042C1")]
	[Address(RVA = "0xA7D160", Offset = "0xA7C560", VA = "0x180A7D160", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60042C2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60042C3")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60042C4")]
	[Address(RVA = "0xA7CFC0", Offset = "0xA7C3C0", VA = "0x180A7CFC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60042C5")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightLeaveEvent other)
	{
	}

	[Token(Token = "0x60042C6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60042C7")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
