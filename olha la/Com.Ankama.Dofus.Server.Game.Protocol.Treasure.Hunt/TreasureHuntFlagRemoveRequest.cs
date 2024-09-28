using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x2000024")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntFlagRemoveRequest : IMessage<TreasureHuntFlagRemoveRequest>, IMessage, IEquatable<TreasureHuntFlagRemoveRequest>, IDeepCloneable<TreasureHuntFlagRemoveRequest>, IBufferMessage
{
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntFlagRemoveRequest> _parser;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000072")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x18")]
	private TreasureHuntType questType_;

	[Token(Token = "0x4000074")]
	public const int IndexFieldNumber = 2;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x1C")]
	private int index_;

	[Token(Token = "0x17000038")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TreasureHuntFlagRemoveRequest> Parser
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x948220", Offset = "0x947620", VA = "0x180948220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000039")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x948170", Offset = "0x947570", VA = "0x180948170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Index
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntFlagRemoveRequest()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntFlagRemoveRequest(TreasureHuntFlagRemoveRequest other)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x947EF0", Offset = "0x9472F0", VA = "0x180947EF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntFlagRemoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x947F80", Offset = "0x947380", VA = "0x180947F80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TreasureHuntFlagRemoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x948010", Offset = "0x947410", VA = "0x180948010", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x947E30", Offset = "0x947230", VA = "0x180947E30", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TreasureHuntFlagRemoveRequest other)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
