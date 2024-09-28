using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x200001E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntLegendaryRequest : IMessage<TreasureHuntLegendaryRequest>, IMessage, IEquatable<TreasureHuntLegendaryRequest>, IDeepCloneable<TreasureHuntLegendaryRequest>, IBufferMessage
{
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntLegendaryRequest> _parser;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000061")]
	public const int LegendaryIdFieldNumber = 1;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x18")]
	private int legendaryId_;

	[Token(Token = "0x1700002B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TreasureHuntLegendaryRequest> Parser
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x94A230", Offset = "0x949630", VA = "0x18094A230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x94A180", Offset = "0x949580", VA = "0x18094A180")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x94A280", Offset = "0x949680", VA = "0x18094A280", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LegendaryId
	{
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntLegendaryRequest()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntLegendaryRequest(TreasureHuntLegendaryRequest other)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x949F10", Offset = "0x949310", VA = "0x180949F10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntLegendaryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x949F90", Offset = "0x949390", VA = "0x180949F90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureHuntLegendaryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x94A020", Offset = "0x949420", VA = "0x18094A020", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x949E80", Offset = "0x949280", VA = "0x180949E80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TreasureHuntLegendaryRequest other)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
