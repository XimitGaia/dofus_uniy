using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x2000839")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChoiceSelectionEvent : IMessage<ChoiceSelectionEvent>, IMessage, IEquatable<ChoiceSelectionEvent>, IDeepCloneable<ChoiceSelectionEvent>, IBufferMessage
{
	[Token(Token = "0x4001C52")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChoiceSelectionEvent> _parser;

	[Token(Token = "0x4001C53")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C54")]
	public const int SelectionIdFieldNumber = 1;

	[Token(Token = "0x4001C55")]
	[FieldOffset(Offset = "0x18")]
	private int selectionId_;

	[Token(Token = "0x4001C56")]
	public const int ChoicesFieldNumber = 2;

	[Token(Token = "0x4001C57")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Choice> _repeated_choices_codec;

	[Token(Token = "0x4001C58")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Choice> choices_;

	[Token(Token = "0x17001293")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChoiceSelectionEvent> Parser
	{
		[Token(Token = "0x6005755")]
		[Address(RVA = "0xB07100", Offset = "0xB06500", VA = "0x180B07100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001294")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005756")]
		[Address(RVA = "0xB07050", Offset = "0xB06450", VA = "0x180B07050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001295")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005757")]
		[Address(RVA = "0xB07350", Offset = "0xB06750", VA = "0x180B07350", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001296")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SelectionId
	{
		[Token(Token = "0x600575B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600575C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001297")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Choice> Choices
	{
		[Token(Token = "0x600575D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005758")]
	[Address(RVA = "0xB06FD0", Offset = "0xB063D0", VA = "0x180B06FD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChoiceSelectionEvent()
	{
	}

	[Token(Token = "0x6005759")]
	[Address(RVA = "0xB06F40", Offset = "0xB06340", VA = "0x180B06F40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChoiceSelectionEvent(ChoiceSelectionEvent other)
	{
	}

	[Token(Token = "0x600575A")]
	[Address(RVA = "0xB06A70", Offset = "0xB05E70", VA = "0x180B06A70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChoiceSelectionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600575E")]
	[Address(RVA = "0xB06BD0", Offset = "0xB05FD0", VA = "0x180B06BD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600575F")]
	[Address(RVA = "0xB06B30", Offset = "0xB05F30", VA = "0x180B06B30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChoiceSelectionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005760")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005761")]
	[Address(RVA = "0xB06D40", Offset = "0xB06140", VA = "0x180B06D40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005762")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005763")]
	[Address(RVA = "0xB07280", Offset = "0xB06680", VA = "0x180B07280", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005764")]
	[Address(RVA = "0xB06990", Offset = "0xB05D90", VA = "0x180B06990", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005765")]
	[Address(RVA = "0xB06CB0", Offset = "0xB060B0", VA = "0x180B06CB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChoiceSelectionEvent other)
	{
	}

	[Token(Token = "0x6005766")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005767")]
	[Address(RVA = "0xB07150", Offset = "0xB06550", VA = "0x180B07150", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
