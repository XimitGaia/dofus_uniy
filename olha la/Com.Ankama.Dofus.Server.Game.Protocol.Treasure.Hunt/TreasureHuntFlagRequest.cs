using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x2000022")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntFlagRequest : IMessage<TreasureHuntFlagRequest>, IMessage, IEquatable<TreasureHuntFlagRequest>, IDeepCloneable<TreasureHuntFlagRequest>, IBufferMessage
{
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntFlagRequest> _parser;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400006B")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x18")]
	private TreasureHuntType questType_;

	[Token(Token = "0x400006D")]
	public const int IndexFieldNumber = 2;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x1C")]
	private int index_;

	[Token(Token = "0x17000033")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TreasureHuntFlagRequest> Parser
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x948740", Offset = "0x947B40", VA = "0x180948740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000034")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x948690", Offset = "0x947A90", VA = "0x180948690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000035")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x948790", Offset = "0x947B90", VA = "0x180948790", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000036")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Index
	{
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntFlagRequest()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntFlagRequest(TreasureHuntFlagRequest other)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x948410", Offset = "0x947810", VA = "0x180948410", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntFlagRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x9484A0", Offset = "0x9478A0", VA = "0x1809484A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureHuntFlagRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x948530", Offset = "0x947930", VA = "0x180948530", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x948350", Offset = "0x947750", VA = "0x180948350", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TreasureHuntFlagRequest other)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
