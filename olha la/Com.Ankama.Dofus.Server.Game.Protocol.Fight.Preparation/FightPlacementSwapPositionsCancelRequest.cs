using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000619")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPlacementSwapPositionsCancelRequest : IMessage<FightPlacementSwapPositionsCancelRequest>, IMessage, IEquatable<FightPlacementSwapPositionsCancelRequest>, IDeepCloneable<FightPlacementSwapPositionsCancelRequest>, IBufferMessage
{
	[Token(Token = "0x4001571")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPlacementSwapPositionsCancelRequest> _parser;

	[Token(Token = "0x4001572")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001573")]
	public const int RequestIdFieldNumber = 1;

	[Token(Token = "0x4001574")]
	[FieldOffset(Offset = "0x18")]
	private int requestId_;

	[Token(Token = "0x17000DFF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightPlacementSwapPositionsCancelRequest> Parser
	{
		[Token(Token = "0x600412B")]
		[Address(RVA = "0xA7FCB0", Offset = "0xA7F0B0", VA = "0x180A7FCB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600412C")]
		[Address(RVA = "0xA7FC00", Offset = "0xA7F000", VA = "0x180A7FC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E01")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600412D")]
		[Address(RVA = "0xA7FD00", Offset = "0xA7F100", VA = "0x180A7FD00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E02")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RequestId
	{
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600412E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsCancelRequest()
	{
	}

	[Token(Token = "0x600412F")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsCancelRequest(FightPlacementSwapPositionsCancelRequest other)
	{
	}

	[Token(Token = "0x6004130")]
	[Address(RVA = "0xA7F990", Offset = "0xA7ED90", VA = "0x180A7F990", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsCancelRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004133")]
	[Address(RVA = "0xA7FA10", Offset = "0xA7EE10", VA = "0x180A7FA10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004134")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightPlacementSwapPositionsCancelRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004135")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004136")]
	[Address(RVA = "0xA7FAA0", Offset = "0xA7EEA0", VA = "0x180A7FAA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004137")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004138")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004139")]
	[Address(RVA = "0xA7F900", Offset = "0xA7ED00", VA = "0x180A7F900", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600413A")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightPlacementSwapPositionsCancelRequest other)
	{
	}

	[Token(Token = "0x600413B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600413C")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
