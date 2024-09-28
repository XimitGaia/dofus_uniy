using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x200083B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightChoiceSelectionEvent : IMessage<FightChoiceSelectionEvent>, IMessage, IEquatable<FightChoiceSelectionEvent>, IDeepCloneable<FightChoiceSelectionEvent>, IBufferMessage
{
	[Token(Token = "0x4001C5A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightChoiceSelectionEvent> _parser;

	[Token(Token = "0x4001C5B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C5C")]
	public const int SelectionIdFieldNumber = 1;

	[Token(Token = "0x4001C5D")]
	[FieldOffset(Offset = "0x18")]
	private int selectionId_;

	[Token(Token = "0x4001C5E")]
	public const int TargetProtocolIdFieldNumber = 2;

	[Token(Token = "0x4001C5F")]
	[FieldOffset(Offset = "0x20")]
	private long targetProtocolId_;

	[Token(Token = "0x4001C60")]
	public const int ChoicesFieldNumber = 3;

	[Token(Token = "0x4001C61")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Choice> _repeated_choices_codec;

	[Token(Token = "0x4001C62")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<Choice> choices_;

	[Token(Token = "0x17001298")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightChoiceSelectionEvent> Parser
	{
		[Token(Token = "0x600576C")]
		[Address(RVA = "0xB0AD10", Offset = "0xB0A110", VA = "0x180B0AD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001299")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600576D")]
		[Address(RVA = "0xB0AC60", Offset = "0xB0A060", VA = "0x180B0AC60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700129A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600576E")]
		[Address(RVA = "0xB0AFB0", Offset = "0xB0A3B0", VA = "0x180B0AFB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700129B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SelectionId
	{
		[Token(Token = "0x6005772")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005773")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700129C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TargetProtocolId
	{
		[Token(Token = "0x6005774")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005775")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700129D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Choice> Choices
	{
		[Token(Token = "0x6005776")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600576F")]
	[Address(RVA = "0xB0AB40", Offset = "0xB09F40", VA = "0x180B0AB40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightChoiceSelectionEvent()
	{
	}

	[Token(Token = "0x6005770")]
	[Address(RVA = "0xB0ABC0", Offset = "0xB09FC0", VA = "0x180B0ABC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightChoiceSelectionEvent(FightChoiceSelectionEvent other)
	{
	}

	[Token(Token = "0x6005771")]
	[Address(RVA = "0xB0A640", Offset = "0xB09A40", VA = "0x180B0A640", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightChoiceSelectionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005777")]
	[Address(RVA = "0xB0A7B0", Offset = "0xB09BB0", VA = "0x180B0A7B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005778")]
	[Address(RVA = "0xB0A710", Offset = "0xB09B10", VA = "0x180B0A710", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightChoiceSelectionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005779")]
	[Address(RVA = "0x95E760", Offset = "0x95DB60", VA = "0x18095E760", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600577A")]
	[Address(RVA = "0xB0A940", Offset = "0xB09D40", VA = "0x180B0A940", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600577B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600577C")]
	[Address(RVA = "0xB0AEB0", Offset = "0xB0A2B0", VA = "0x180B0AEB0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600577D")]
	[Address(RVA = "0xB0A530", Offset = "0xB09930", VA = "0x180B0A530", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600577E")]
	[Address(RVA = "0xB0A8A0", Offset = "0xB09CA0", VA = "0x180B0A8A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightChoiceSelectionEvent other)
	{
	}

	[Token(Token = "0x600577F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005780")]
	[Address(RVA = "0xB0AD60", Offset = "0xB0A160", VA = "0x180B0AD60", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
