using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x200002A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntLegendaryEvent : IMessage<TreasureHuntLegendaryEvent>, IMessage, IEquatable<TreasureHuntLegendaryEvent>, IDeepCloneable<TreasureHuntLegendaryEvent>, IBufferMessage
{
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntLegendaryEvent> _parser;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000083")]
	public const int AvailableLegendaryIdsFieldNumber = 1;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_availableLegendaryIds_codec;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> availableLegendaryIds_;

	[Token(Token = "0x17000045")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TreasureHuntLegendaryEvent> Parser
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x949B80", Offset = "0x948F80", VA = "0x180949B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000046")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x949AD0", Offset = "0x948ED0", VA = "0x180949AD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000047")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x949DA0", Offset = "0x9491A0", VA = "0x180949DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000048")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> AvailableLegendaryIds
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x9499C0", Offset = "0x948DC0", VA = "0x1809499C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntLegendaryEvent()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x949A40", Offset = "0x948E40", VA = "0x180949A40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntLegendaryEvent(TreasureHuntLegendaryEvent other)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x949580", Offset = "0x948980", VA = "0x180949580", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntLegendaryEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x9496D0", Offset = "0x948AD0", VA = "0x1809496D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x949640", Offset = "0x948A40", VA = "0x180949640", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureHuntLegendaryEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x949830", Offset = "0x948C30", VA = "0x180949830", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x949CF0", Offset = "0x9490F0", VA = "0x180949CF0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x9494E0", Offset = "0x9488E0", VA = "0x1809494E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x9497B0", Offset = "0x948BB0", VA = "0x1809497B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TreasureHuntLegendaryEvent other)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x949BD0", Offset = "0x948FD0", VA = "0x180949BD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
