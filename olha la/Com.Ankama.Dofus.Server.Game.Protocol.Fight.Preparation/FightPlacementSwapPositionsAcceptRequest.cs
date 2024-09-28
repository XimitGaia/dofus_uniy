using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x200061B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPlacementSwapPositionsAcceptRequest : IMessage<FightPlacementSwapPositionsAcceptRequest>, IMessage, IEquatable<FightPlacementSwapPositionsAcceptRequest>, IDeepCloneable<FightPlacementSwapPositionsAcceptRequest>, IBufferMessage
{
	[Token(Token = "0x4001576")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPlacementSwapPositionsAcceptRequest> _parser;

	[Token(Token = "0x4001577")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001578")]
	public const int RequestIdFieldNumber = 1;

	[Token(Token = "0x4001579")]
	[FieldOffset(Offset = "0x18")]
	private int requestId_;

	[Token(Token = "0x17000E03")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightPlacementSwapPositionsAcceptRequest> Parser
	{
		[Token(Token = "0x6004141")]
		[Address(RVA = "0xA7F7D0", Offset = "0xA7EBD0", VA = "0x180A7F7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E04")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004142")]
		[Address(RVA = "0xA7F720", Offset = "0xA7EB20", VA = "0x180A7F720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E05")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004143")]
		[Address(RVA = "0xA7F820", Offset = "0xA7EC20", VA = "0x180A7F820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E06")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RequestId
	{
		[Token(Token = "0x6004147")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004148")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004144")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPlacementSwapPositionsAcceptRequest()
	{
	}

	[Token(Token = "0x6004145")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsAcceptRequest(FightPlacementSwapPositionsAcceptRequest other)
	{
	}

	[Token(Token = "0x6004146")]
	[Address(RVA = "0xA7F4B0", Offset = "0xA7E8B0", VA = "0x180A7F4B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsAcceptRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004149")]
	[Address(RVA = "0xA7F530", Offset = "0xA7E930", VA = "0x180A7F530", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600414A")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightPlacementSwapPositionsAcceptRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600414B")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600414C")]
	[Address(RVA = "0xA7F5C0", Offset = "0xA7E9C0", VA = "0x180A7F5C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600414D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600414E")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600414F")]
	[Address(RVA = "0xA7F420", Offset = "0xA7E820", VA = "0x180A7F420", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004150")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightPlacementSwapPositionsAcceptRequest other)
	{
	}

	[Token(Token = "0x6004151")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004152")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
