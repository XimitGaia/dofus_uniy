using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x2000841")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CurrentGlobalChoiceSelectionEvent : IMessage<CurrentGlobalChoiceSelectionEvent>, IMessage, IEquatable<CurrentGlobalChoiceSelectionEvent>, IDeepCloneable<CurrentGlobalChoiceSelectionEvent>, IBufferMessage
{
	[Token(Token = "0x4001C6E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CurrentGlobalChoiceSelectionEvent> _parser;

	[Token(Token = "0x4001C6F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C70")]
	public const int SelectionIdFieldNumber = 1;

	[Token(Token = "0x4001C71")]
	[FieldOffset(Offset = "0x18")]
	private int selectionId_;

	[Token(Token = "0x4001C72")]
	public const int ChoicesFieldNumber = 2;

	[Token(Token = "0x4001C73")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<VotedChoice> _repeated_choices_codec;

	[Token(Token = "0x4001C74")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<VotedChoice> choices_;

	[Token(Token = "0x170012A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CurrentGlobalChoiceSelectionEvent> Parser
	{
		[Token(Token = "0x60057B1")]
		[Address(RVA = "0xB0A200", Offset = "0xB09600", VA = "0x180B0A200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012A7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60057B2")]
		[Address(RVA = "0xB0A150", Offset = "0xB09550", VA = "0x180B0A150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012A8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60057B3")]
		[Address(RVA = "0xB0A450", Offset = "0xB09850", VA = "0x180B0A450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SelectionId
	{
		[Token(Token = "0x60057B7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60057B8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170012AA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<VotedChoice> Choices
	{
		[Token(Token = "0x60057B9")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60057B4")]
	[Address(RVA = "0xB0A040", Offset = "0xB09440", VA = "0x180B0A040")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurrentGlobalChoiceSelectionEvent()
	{
	}

	[Token(Token = "0x60057B5")]
	[Address(RVA = "0xB0A0C0", Offset = "0xB094C0", VA = "0x180B0A0C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CurrentGlobalChoiceSelectionEvent(CurrentGlobalChoiceSelectionEvent other)
	{
	}

	[Token(Token = "0x60057B6")]
	[Address(RVA = "0xB09B70", Offset = "0xB08F70", VA = "0x180B09B70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurrentGlobalChoiceSelectionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60057BA")]
	[Address(RVA = "0xB09C30", Offset = "0xB09030", VA = "0x180B09C30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60057BB")]
	[Address(RVA = "0xB09D10", Offset = "0xB09110", VA = "0x180B09D10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CurrentGlobalChoiceSelectionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60057BC")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60057BD")]
	[Address(RVA = "0xB09E40", Offset = "0xB09240", VA = "0x180B09E40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60057BE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60057BF")]
	[Address(RVA = "0xB0A380", Offset = "0xB09780", VA = "0x180B0A380", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60057C0")]
	[Address(RVA = "0xB09A90", Offset = "0xB08E90", VA = "0x180B09A90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60057C1")]
	[Address(RVA = "0xB09DB0", Offset = "0xB091B0", VA = "0x180B09DB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CurrentGlobalChoiceSelectionEvent other)
	{
	}

	[Token(Token = "0x60057C2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60057C3")]
	[Address(RVA = "0xB0A250", Offset = "0xB09650", VA = "0x180B0A250", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
