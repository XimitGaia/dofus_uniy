using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote;

[Token(Token = "0x200073F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EmotePlayEvent : IMessage<EmotePlayEvent>, IMessage, IEquatable<EmotePlayEvent>, IDeepCloneable<EmotePlayEvent>, IBufferMessage
{
	[Token(Token = "0x400197B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EmotePlayEvent> _parser;

	[Token(Token = "0x400197C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400197D")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x400197E")]
	[FieldOffset(Offset = "0x18")]
	private int emoteId_;

	[Token(Token = "0x400197F")]
	public const int EmoteStartTimeFieldNumber = 2;

	[Token(Token = "0x4001980")]
	[FieldOffset(Offset = "0x20")]
	private long emoteStartTime_;

	[Token(Token = "0x4001981")]
	public const int ActorIdFieldNumber = 3;

	[Token(Token = "0x4001982")]
	[FieldOffset(Offset = "0x28")]
	private long actorId_;

	[Token(Token = "0x4001983")]
	public const int AccountIdFieldNumber = 4;

	[Token(Token = "0x4001984")]
	[FieldOffset(Offset = "0x30")]
	private int accountId_;

	[Token(Token = "0x170010A5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EmotePlayEvent> Parser
	{
		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0xAB62E0", Offset = "0xAB56E0", VA = "0x180AB62E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0xAB6230", Offset = "0xAB5630", VA = "0x180AB6230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004DCB")]
		[Address(RVA = "0xAB64F0", Offset = "0xAB58F0", VA = "0x180AB64F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EmoteId
	{
		[Token(Token = "0x6004DCF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004DD0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170010A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long EmoteStartTime
	{
		[Token(Token = "0x6004DD1")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170010AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ActorId
	{
		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004DD4")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x170010AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AccountId
	{
		[Token(Token = "0x6004DD5")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x6004DCC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayEvent()
	{
	}

	[Token(Token = "0x6004DCD")]
	[Address(RVA = "0xAB61C0", Offset = "0xAB55C0", VA = "0x180AB61C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayEvent(EmotePlayEvent other)
	{
	}

	[Token(Token = "0x6004DCE")]
	[Address(RVA = "0xAB5D80", Offset = "0xAB5180", VA = "0x180AB5D80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004DD7")]
	[Address(RVA = "0xAB5E70", Offset = "0xAB5270", VA = "0x180AB5E70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DD8")]
	[Address(RVA = "0xAB5E20", Offset = "0xAB5220", VA = "0x180AB5E20", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EmotePlayEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DD9")]
	[Address(RVA = "0xAB5F20", Offset = "0xAB5320", VA = "0x180AB5F20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004DDA")]
	[Address(RVA = "0xAB6060", Offset = "0xAB5460", VA = "0x180AB6060", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004DDB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004DDC")]
	[Address(RVA = "0xAB6430", Offset = "0xAB5830", VA = "0x180AB6430", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004DDD")]
	[Address(RVA = "0xAB5C70", Offset = "0xAB5070", VA = "0x180AB5C70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004DDE")]
	[Address(RVA = "0xAB5FE0", Offset = "0xAB53E0", VA = "0x180AB5FE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EmotePlayEvent other)
	{
	}

	[Token(Token = "0x6004DDF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004DE0")]
	[Address(RVA = "0xAB6330", Offset = "0xAB5730", VA = "0x180AB6330", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
