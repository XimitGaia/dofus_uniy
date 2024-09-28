using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000125")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MoodUpdateEvent : IMessage<MoodUpdateEvent>, IMessage, IEquatable<MoodUpdateEvent>, IDeepCloneable<MoodUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MoodUpdateEvent> _parser;

	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003E2")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x18")]
	private long accountId_;

	[Token(Token = "0x40003E4")]
	public const int CharacterIdFieldNumber = 2;

	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x20")]
	private long characterId_;

	[Token(Token = "0x40003E6")]
	public const int SmileyIdFieldNumber = 3;

	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x28")]
	private int smileyId_;

	[Token(Token = "0x17000263")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MoodUpdateEvent> Parser
	{
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0xB68390", Offset = "0xB67790", VA = "0x180B68390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000264")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0xB682E0", Offset = "0xB676E0", VA = "0x180B682E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000265")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0xB68480", Offset = "0xB67880", VA = "0x180B68480", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000266")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000267")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000268")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SmileyId
	{
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MoodUpdateEvent()
	{
	}

	[Token(Token = "0x6000B40")]
	[Address(RVA = "0xAA8980", Offset = "0xAA7D80", VA = "0x180AA8980")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MoodUpdateEvent(MoodUpdateEvent other)
	{
	}

	[Token(Token = "0x6000B41")]
	[Address(RVA = "0xB68050", Offset = "0xB67450", VA = "0x180B68050", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MoodUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000B48")]
	[Address(RVA = "0xB680E0", Offset = "0xB674E0", VA = "0x180B680E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B49")]
	[Address(RVA = "0xAA86C0", Offset = "0xAA7AC0", VA = "0x180AA86C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MoodUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0xAA8700", Offset = "0xAA7B00", VA = "0x180AA8700", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0xB68180", Offset = "0xB67580", VA = "0x180B68180", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0xB683E0", Offset = "0xB677E0", VA = "0x180B683E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0xB67F60", Offset = "0xB67360", VA = "0x180B67F60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0xAA87B0", Offset = "0xAA7BB0", VA = "0x180AA87B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MoodUpdateEvent other)
	{
	}

	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000B51")]
	[Address(RVA = "0xAA8AE0", Offset = "0xAA7EE0", VA = "0x180AA8AE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
