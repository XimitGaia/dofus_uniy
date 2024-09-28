using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote;

[Token(Token = "0x200073B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EmoteAddedEvent : IMessage<EmoteAddedEvent>, IMessage, IEquatable<EmoteAddedEvent>, IDeepCloneable<EmoteAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4001971")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EmoteAddedEvent> _parser;

	[Token(Token = "0x4001972")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001973")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x4001974")]
	[FieldOffset(Offset = "0x18")]
	private int emoteId_;

	[Token(Token = "0x1700109D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EmoteAddedEvent> Parser
	{
		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0xAB4B70", Offset = "0xAB3F70", VA = "0x180AB4B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700109E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0xAB4AC0", Offset = "0xAB3EC0", VA = "0x180AB4AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700109F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004D9F")]
		[Address(RVA = "0xAB4BC0", Offset = "0xAB3FC0", VA = "0x180AB4BC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EmoteId
	{
		[Token(Token = "0x6004DA3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004DA4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004DA0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmoteAddedEvent()
	{
	}

	[Token(Token = "0x6004DA1")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmoteAddedEvent(EmoteAddedEvent other)
	{
	}

	[Token(Token = "0x6004DA2")]
	[Address(RVA = "0xAB4850", Offset = "0xAB3C50", VA = "0x180AB4850", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmoteAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004DA5")]
	[Address(RVA = "0xAB48D0", Offset = "0xAB3CD0", VA = "0x180AB48D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DA6")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EmoteAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DA7")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004DA8")]
	[Address(RVA = "0xAB4960", Offset = "0xAB3D60", VA = "0x180AB4960", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004DA9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004DAA")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004DAB")]
	[Address(RVA = "0xAB47C0", Offset = "0xAB3BC0", VA = "0x180AB47C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004DAC")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EmoteAddedEvent other)
	{
	}

	[Token(Token = "0x6004DAD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004DAE")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
