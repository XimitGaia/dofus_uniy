using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B42")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TimeEvent : IMessage<TimeEvent>, IMessage, IEquatable<TimeEvent>, IDeepCloneable<TimeEvent>, IBufferMessage
{
	[Token(Token = "0x4002A0B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TimeEvent> _parser;

	[Token(Token = "0x4002A0C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A0D")]
	public const int TimestampFieldNumber = 1;

	[Token(Token = "0x4002A0E")]
	[FieldOffset(Offset = "0x18")]
	private long timestamp_;

	[Token(Token = "0x4002A0F")]
	public const int TimezoneOffsetFieldNumber = 2;

	[Token(Token = "0x4002A10")]
	[FieldOffset(Offset = "0x20")]
	private int timezoneOffset_;

	[Token(Token = "0x17001A26")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TimeEvent> Parser
	{
		[Token(Token = "0x60076B0")]
		[Address(RVA = "0xC27400", Offset = "0xC26800", VA = "0x180C27400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A27")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60076B1")]
		[Address(RVA = "0xC27350", Offset = "0xC26750", VA = "0x180C27350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A28")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60076B2")]
		[Address(RVA = "0xC27450", Offset = "0xC26850", VA = "0x180C27450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A29")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Timestamp
	{
		[Token(Token = "0x60076B6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60076B7")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001A2A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TimezoneOffset
	{
		[Token(Token = "0x60076B8")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60076B9")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60076B3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TimeEvent()
	{
	}

	[Token(Token = "0x60076B4")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TimeEvent(TimeEvent other)
	{
	}

	[Token(Token = "0x60076B5")]
	[Address(RVA = "0xC270C0", Offset = "0xC264C0", VA = "0x180C270C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TimeEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60076BA")]
	[Address(RVA = "0xC27150", Offset = "0xC26550", VA = "0x180C27150", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60076BB")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TimeEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60076BC")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60076BD")]
	[Address(RVA = "0xC271F0", Offset = "0xC265F0", VA = "0x180C271F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60076BE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60076BF")]
	[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60076C0")]
	[Address(RVA = "0xC27000", Offset = "0xC26400", VA = "0x180C27000", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60076C1")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TimeEvent other)
	{
	}

	[Token(Token = "0x60076C2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60076C3")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
