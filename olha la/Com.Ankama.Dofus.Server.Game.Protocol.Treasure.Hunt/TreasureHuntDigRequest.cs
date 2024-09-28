using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x2000020")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntDigRequest : IMessage<TreasureHuntDigRequest>, IMessage, IEquatable<TreasureHuntDigRequest>, IDeepCloneable<TreasureHuntDigRequest>, IBufferMessage
{
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntDigRequest> _parser;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000066")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x18")]
	private TreasureHuntType questType_;

	[Token(Token = "0x1700002F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TreasureHuntDigRequest> Parser
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x945E70", Offset = "0x945270", VA = "0x180945E70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x945DC0", Offset = "0x9451C0", VA = "0x180945DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000031")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x945EC0", Offset = "0x9452C0", VA = "0x180945EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000032")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntDigRequest()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntDigRequest(TreasureHuntDigRequest other)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x945B50", Offset = "0x944F50", VA = "0x180945B50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntDigRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x945BD0", Offset = "0x944FD0", VA = "0x180945BD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureHuntDigRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x945C60", Offset = "0x945060", VA = "0x180945C60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x945AC0", Offset = "0x944EC0", VA = "0x180945AC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TreasureHuntDigRequest other)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
