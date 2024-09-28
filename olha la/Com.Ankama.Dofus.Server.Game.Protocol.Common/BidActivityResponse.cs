using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200091A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BidActivityResponse : IMessage<BidActivityResponse>, IMessage, IEquatable<BidActivityResponse>, IDeepCloneable<BidActivityResponse>, IBufferMessage
{
	[Token(Token = "0x4001F18")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BidActivityResponse> _parser;

	[Token(Token = "0x4001F19")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001F1A")]
	public const int BidActivitiesFieldNumber = 1;

	[Token(Token = "0x4001F1B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<BidActivity> _repeated_bidActivities_codec;

	[Token(Token = "0x4001F1C")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<BidActivity> bidActivities_;

	[Token(Token = "0x1700145B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BidActivityResponse> Parser
	{
		[Token(Token = "0x6006041")]
		[Address(RVA = "0xB4C570", Offset = "0xB4B970", VA = "0x180B4C570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700145C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006042")]
		[Address(RVA = "0xB4C4C0", Offset = "0xB4B8C0", VA = "0x180B4C4C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700145D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006043")]
		[Address(RVA = "0xB4C780", Offset = "0xB4BB80", VA = "0x180B4C780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700145E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BidActivity> BidActivities
	{
		[Token(Token = "0x6006047")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006044")]
	[Address(RVA = "0xB4C3B0", Offset = "0xB4B7B0", VA = "0x180B4C3B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidActivityResponse()
	{
	}

	[Token(Token = "0x6006045")]
	[Address(RVA = "0xB4C430", Offset = "0xB4B830", VA = "0x180B4C430")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidActivityResponse(BidActivityResponse other)
	{
	}

	[Token(Token = "0x6006046")]
	[Address(RVA = "0xB4BF00", Offset = "0xB4B300", VA = "0x180B4BF00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidActivityResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6006048")]
	[Address(RVA = "0xB4BFC0", Offset = "0xB4B3C0", VA = "0x180B4BFC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006049")]
	[Address(RVA = "0xB4C0A0", Offset = "0xB4B4A0", VA = "0x180B4C0A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BidActivityResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600604A")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600604B")]
	[Address(RVA = "0xB4C1B0", Offset = "0xB4B5B0", VA = "0x180B4C1B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600604C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600604D")]
	[Address(RVA = "0xB4C6D0", Offset = "0xB4BAD0", VA = "0x180B4C6D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600604E")]
	[Address(RVA = "0xB4BE60", Offset = "0xB4B260", VA = "0x180B4BE60", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600604F")]
	[Address(RVA = "0xB4C130", Offset = "0xB4B530", VA = "0x180B4C130", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BidActivityResponse other)
	{
	}

	[Token(Token = "0x6006050")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006051")]
	[Address(RVA = "0xB4C5C0", Offset = "0xB4B9C0", VA = "0x180B4C5C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
