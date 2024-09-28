using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006EF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BidItem : IMessage<BidItem>, IMessage, IEquatable<BidItem>, IDeepCloneable<BidItem>, IBufferMessage
{
	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BidItem> _parser;

	[Token(Token = "0x4001862")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001863")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x18")]
	private int uid_;

	[Token(Token = "0x4001865")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x4001867")]
	public const int GidFieldNumber = 3;

	[Token(Token = "0x4001868")]
	[FieldOffset(Offset = "0x20")]
	private long gid_;

	[Token(Token = "0x4001869")]
	public const int EffectsFieldNumber = 4;

	[Token(Token = "0x400186A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x400186B")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x17000FEE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BidItem> Parser
	{
		[Token(Token = "0x6004A77")]
		[Address(RVA = "0xA9D510", Offset = "0xA9C910", VA = "0x180A9D510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FEF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0xA9D460", Offset = "0xA9C860", VA = "0x180A9D460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004A79")]
		[Address(RVA = "0xA9D7F0", Offset = "0xA9CBF0", VA = "0x180A9D7F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FF1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Uid
	{
		[Token(Token = "0x6004A7D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A7E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000FF2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x6004A7F")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004A80")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000FF3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Gid
	{
		[Token(Token = "0x6004A81")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004A82")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000FF4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004A7A")]
	[Address(RVA = "0xA9D340", Offset = "0xA9C740", VA = "0x180A9D340")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidItem()
	{
	}

	[Token(Token = "0x6004A7B")]
	[Address(RVA = "0xA9D3C0", Offset = "0xA9C7C0", VA = "0x180A9D3C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BidItem(BidItem other)
	{
	}

	[Token(Token = "0x6004A7C")]
	[Address(RVA = "0xA9CD70", Offset = "0xA9C170", VA = "0x180A9CD70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BidItem Clone()
	{
		return null;
	}

	[Token(Token = "0x6004A84")]
	[Address(RVA = "0xA9CE40", Offset = "0xA9C240", VA = "0x180A9CE40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A85")]
	[Address(RVA = "0xA9CF30", Offset = "0xA9C330", VA = "0x180A9CF30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BidItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A86")]
	[Address(RVA = "0xA9CFE0", Offset = "0xA9C3E0", VA = "0x180A9CFE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004A87")]
	[Address(RVA = "0xA9D140", Offset = "0xA9C540", VA = "0x180A9D140", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004A88")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004A89")]
	[Address(RVA = "0xA9D6D0", Offset = "0xA9CAD0", VA = "0x180A9D6D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004A8A")]
	[Address(RVA = "0xA9CC30", Offset = "0xA9C030", VA = "0x180A9CC30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004A8B")]
	[Address(RVA = "0xA9D0A0", Offset = "0xA9C4A0", VA = "0x180A9D0A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BidItem other)
	{
	}

	[Token(Token = "0x6004A8C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004A8D")]
	[Address(RVA = "0xA9D560", Offset = "0xA9C960", VA = "0x180A9D560", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
