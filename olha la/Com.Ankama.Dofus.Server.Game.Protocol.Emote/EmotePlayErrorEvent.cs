using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote;

[Token(Token = "0x2000743")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EmotePlayErrorEvent : IMessage<EmotePlayErrorEvent>, IMessage, IEquatable<EmotePlayErrorEvent>, IDeepCloneable<EmotePlayErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4001990")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EmotePlayErrorEvent> _parser;

	[Token(Token = "0x4001991")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001992")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x4001993")]
	[FieldOffset(Offset = "0x18")]
	private int emoteId_;

	[Token(Token = "0x170010B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EmotePlayErrorEvent> Parser
	{
		[Token(Token = "0x6004DFE")]
		[Address(RVA = "0xAB5B40", Offset = "0xAB4F40", VA = "0x180AB5B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004DFF")]
		[Address(RVA = "0xAB5A90", Offset = "0xAB4E90", VA = "0x180AB5A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004E00")]
		[Address(RVA = "0xAB5B90", Offset = "0xAB4F90", VA = "0x180AB5B90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010B5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EmoteId
	{
		[Token(Token = "0x6004E04")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004E05")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004E01")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayErrorEvent()
	{
	}

	[Token(Token = "0x6004E02")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayErrorEvent(EmotePlayErrorEvent other)
	{
	}

	[Token(Token = "0x6004E03")]
	[Address(RVA = "0xAB5820", Offset = "0xAB4C20", VA = "0x180AB5820", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004E06")]
	[Address(RVA = "0xAB58A0", Offset = "0xAB4CA0", VA = "0x180AB58A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E07")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EmotePlayErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E08")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004E09")]
	[Address(RVA = "0xAB5930", Offset = "0xAB4D30", VA = "0x180AB5930", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004E0A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004E0B")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004E0C")]
	[Address(RVA = "0xAB5790", Offset = "0xAB4B90", VA = "0x180AB5790", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004E0D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EmotePlayErrorEvent other)
	{
	}

	[Token(Token = "0x6004E0E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004E0F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
