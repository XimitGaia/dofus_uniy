using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002EF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayEmoteOnNpcEvent : IMessage<PlayEmoteOnNpcEvent>, IMessage, IEquatable<PlayEmoteOnNpcEvent>, IDeepCloneable<PlayEmoteOnNpcEvent>, IBufferMessage
{
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayEmoteOnNpcEvent> _parser;

	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A5A")]
	public const int NpcIdFieldNumber = 1;

	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0x18")]
	private int npcId_;

	[Token(Token = "0x4000A5C")]
	public const int EmoteIdFieldNumber = 2;

	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x1C")]
	private int emoteId_;

	[Token(Token = "0x17000697")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayEmoteOnNpcEvent> Parser
	{
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0xD2CD90", Offset = "0xD2C190", VA = "0x180D2CD90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000698")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0xD2CCE0", Offset = "0xD2C0E0", VA = "0x180D2CCE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000699")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0xD2CDE0", Offset = "0xD2C1E0", VA = "0x180D2CDE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NpcId
	{
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700069B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EmoteId
	{
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayEmoteOnNpcEvent()
	{
	}

	[Token(Token = "0x6001E80")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayEmoteOnNpcEvent(PlayEmoteOnNpcEvent other)
	{
	}

	[Token(Token = "0x6001E81")]
	[Address(RVA = "0xD2CA60", Offset = "0xD2BE60", VA = "0x180D2CA60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayEmoteOnNpcEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001E86")]
	[Address(RVA = "0xD2CAF0", Offset = "0xD2BEF0", VA = "0x180D2CAF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayEmoteOnNpcEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E88")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E89")]
	[Address(RVA = "0xD2CB80", Offset = "0xD2BF80", VA = "0x180D2CB80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0xD2C9A0", Offset = "0xD2BDA0", VA = "0x180D2C9A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PlayEmoteOnNpcEvent other)
	{
	}

	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001E8F")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
