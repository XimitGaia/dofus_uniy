using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007EA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BlockListEvent : IMessage<BlockListEvent>, IMessage, IEquatable<BlockListEvent>, IDeepCloneable<BlockListEvent>, IBufferMessage
{
	[Token(Token = "0x4001B55")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BlockListEvent> _parser;

	[Token(Token = "0x4001B56")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B57")]
	public const int BlockedFieldNumber = 1;

	[Token(Token = "0x4001B58")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ContactInformation> _repeated_blocked_codec;

	[Token(Token = "0x4001B59")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ContactInformation> blocked_;

	[Token(Token = "0x170011E1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BlockListEvent> Parser
	{
		[Token(Token = "0x600540C")]
		[Address(RVA = "0xAE7710", Offset = "0xAE6B10", VA = "0x180AE7710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600540D")]
		[Address(RVA = "0xAE7660", Offset = "0xAE6A60", VA = "0x180AE7660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600540E")]
		[Address(RVA = "0xAE7920", Offset = "0xAE6D20", VA = "0x180AE7920", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011E4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ContactInformation> Blocked
	{
		[Token(Token = "0x6005412")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600540F")]
	[Address(RVA = "0xAE7550", Offset = "0xAE6950", VA = "0x180AE7550")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockListEvent()
	{
	}

	[Token(Token = "0x6005410")]
	[Address(RVA = "0xAE75D0", Offset = "0xAE69D0", VA = "0x180AE75D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockListEvent(BlockListEvent other)
	{
	}

	[Token(Token = "0x6005411")]
	[Address(RVA = "0xAE70A0", Offset = "0xAE64A0", VA = "0x180AE70A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005413")]
	[Address(RVA = "0xAE7160", Offset = "0xAE6560", VA = "0x180AE7160", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005414")]
	[Address(RVA = "0xAE7240", Offset = "0xAE6640", VA = "0x180AE7240", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BlockListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005415")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005416")]
	[Address(RVA = "0xAE7350", Offset = "0xAE6750", VA = "0x180AE7350", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005417")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005418")]
	[Address(RVA = "0xAE7870", Offset = "0xAE6C70", VA = "0x180AE7870", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005419")]
	[Address(RVA = "0xAE7000", Offset = "0xAE6400", VA = "0x180AE7000", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600541A")]
	[Address(RVA = "0xAE72D0", Offset = "0xAE66D0", VA = "0x180AE72D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BlockListEvent other)
	{
	}

	[Token(Token = "0x600541B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600541C")]
	[Address(RVA = "0xAE7760", Offset = "0xAE6B60", VA = "0x180AE7760", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
