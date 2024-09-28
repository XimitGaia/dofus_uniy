using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x2000602")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightSynchronizeEvent : IMessage<FightSynchronizeEvent>, IMessage, IEquatable<FightSynchronizeEvent>, IDeepCloneable<FightSynchronizeEvent>, IBufferMessage
{
	[Token(Token = "0x4001510")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightSynchronizeEvent> _parser;

	[Token(Token = "0x4001511")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001512")]
	public const int FightersFieldNumber = 1;

	[Token(Token = "0x4001513")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ActorPositionInformation> _repeated_fighters_codec;

	[Token(Token = "0x4001514")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ActorPositionInformation> fighters_;

	[Token(Token = "0x17000DCD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightSynchronizeEvent> Parser
	{
		[Token(Token = "0x600403E")]
		[Address(RVA = "0xA4C070", Offset = "0xA4B470", VA = "0x180A4C070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DCE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600403F")]
		[Address(RVA = "0xA4BFC0", Offset = "0xA4B3C0", VA = "0x180A4BFC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DCF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004040")]
		[Address(RVA = "0xA4C280", Offset = "0xA4B680", VA = "0x180A4C280", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ActorPositionInformation> Fighters
	{
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004041")]
	[Address(RVA = "0xA4BF40", Offset = "0xA4B340", VA = "0x180A4BF40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSynchronizeEvent()
	{
	}

	[Token(Token = "0x6004042")]
	[Address(RVA = "0xA4BEB0", Offset = "0xA4B2B0", VA = "0x180A4BEB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSynchronizeEvent(FightSynchronizeEvent other)
	{
	}

	[Token(Token = "0x6004043")]
	[Address(RVA = "0xA4BA00", Offset = "0xA4AE00", VA = "0x180A4BA00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSynchronizeEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004045")]
	[Address(RVA = "0xA4BAC0", Offset = "0xA4AEC0", VA = "0x180A4BAC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004046")]
	[Address(RVA = "0xA4BBA0", Offset = "0xA4AFA0", VA = "0x180A4BBA0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightSynchronizeEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004047")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004048")]
	[Address(RVA = "0xA4BCB0", Offset = "0xA4B0B0", VA = "0x180A4BCB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004049")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600404A")]
	[Address(RVA = "0xA4C1D0", Offset = "0xA4B5D0", VA = "0x180A4C1D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600404B")]
	[Address(RVA = "0xA4B960", Offset = "0xA4AD60", VA = "0x180A4B960", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600404C")]
	[Address(RVA = "0xA4BC30", Offset = "0xA4B030", VA = "0x180A4BC30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightSynchronizeEvent other)
	{
	}

	[Token(Token = "0x600404D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600404E")]
	[Address(RVA = "0xA4C0C0", Offset = "0xA4B4C0", VA = "0x180A4C0C0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
