using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x200062F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPlacementSwapPositionsEvent : IMessage<FightPlacementSwapPositionsEvent>, IMessage, IEquatable<FightPlacementSwapPositionsEvent>, IDeepCloneable<FightPlacementSwapPositionsEvent>, IBufferMessage
{
	[Token(Token = "0x40015CA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPlacementSwapPositionsEvent> _parser;

	[Token(Token = "0x40015CB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015CC")]
	public const int DispositionsFieldNumber = 1;

	[Token(Token = "0x40015CD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<EntityDisposition> _repeated_dispositions_codec;

	[Token(Token = "0x40015CE")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<EntityDisposition> dispositions_;

	[Token(Token = "0x17000E3B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightPlacementSwapPositionsEvent> Parser
	{
		[Token(Token = "0x600423B")]
		[Address(RVA = "0xA80E60", Offset = "0xA80260", VA = "0x180A80E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E3C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600423C")]
		[Address(RVA = "0xA80DB0", Offset = "0xA801B0", VA = "0x180A80DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E3D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600423D")]
		[Address(RVA = "0xA81070", Offset = "0xA80470", VA = "0x180A81070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E3E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EntityDisposition> Dispositions
	{
		[Token(Token = "0x6004241")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600423E")]
	[Address(RVA = "0xA80CA0", Offset = "0xA800A0", VA = "0x180A80CA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPlacementSwapPositionsEvent()
	{
	}

	[Token(Token = "0x600423F")]
	[Address(RVA = "0xA80D20", Offset = "0xA80120", VA = "0x180A80D20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsEvent(FightPlacementSwapPositionsEvent other)
	{
	}

	[Token(Token = "0x6004240")]
	[Address(RVA = "0xA807F0", Offset = "0xA7FBF0", VA = "0x180A807F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004242")]
	[Address(RVA = "0xA808B0", Offset = "0xA7FCB0", VA = "0x180A808B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004243")]
	[Address(RVA = "0xA80990", Offset = "0xA7FD90", VA = "0x180A80990", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightPlacementSwapPositionsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004244")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004245")]
	[Address(RVA = "0xA80AA0", Offset = "0xA7FEA0", VA = "0x180A80AA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004246")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004247")]
	[Address(RVA = "0xA80FC0", Offset = "0xA803C0", VA = "0x180A80FC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004248")]
	[Address(RVA = "0xA80750", Offset = "0xA7FB50", VA = "0x180A80750", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004249")]
	[Address(RVA = "0xA80A20", Offset = "0xA7FE20", VA = "0x180A80A20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightPlacementSwapPositionsEvent other)
	{
	}

	[Token(Token = "0x600424A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600424B")]
	[Address(RVA = "0xA80EB0", Offset = "0xA802B0", VA = "0x180A80EB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
