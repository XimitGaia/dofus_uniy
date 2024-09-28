using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x2000843")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GlobalChoiceSelectionEvent : IMessage<GlobalChoiceSelectionEvent>, IMessage, IEquatable<GlobalChoiceSelectionEvent>, IDeepCloneable<GlobalChoiceSelectionEvent>, IBufferMessage
{
	[Token(Token = "0x4001C76")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GlobalChoiceSelectionEvent> _parser;

	[Token(Token = "0x4001C77")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C78")]
	public const int SelectionIdFieldNumber = 1;

	[Token(Token = "0x4001C79")]
	[FieldOffset(Offset = "0x18")]
	private int selectionId_;

	[Token(Token = "0x4001C7A")]
	public const int ChoicesFieldNumber = 2;

	[Token(Token = "0x4001C7B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Choice> _repeated_choices_codec;

	[Token(Token = "0x4001C7C")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Choice> choices_;

	[Token(Token = "0x170012AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GlobalChoiceSelectionEvent> Parser
	{
		[Token(Token = "0x60057C8")]
		[Address(RVA = "0xB0C1C0", Offset = "0xB0B5C0", VA = "0x180B0C1C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60057C9")]
		[Address(RVA = "0xB0C110", Offset = "0xB0B510", VA = "0x180B0C110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60057CA")]
		[Address(RVA = "0xB0C410", Offset = "0xB0B810", VA = "0x180B0C410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SelectionId
	{
		[Token(Token = "0x60057CE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60057CF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170012AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Choice> Choices
	{
		[Token(Token = "0x60057D0")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60057CB")]
	[Address(RVA = "0xB0C000", Offset = "0xB0B400", VA = "0x180B0C000")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GlobalChoiceSelectionEvent()
	{
	}

	[Token(Token = "0x60057CC")]
	[Address(RVA = "0xB0C080", Offset = "0xB0B480", VA = "0x180B0C080")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GlobalChoiceSelectionEvent(GlobalChoiceSelectionEvent other)
	{
	}

	[Token(Token = "0x60057CD")]
	[Address(RVA = "0xB0BB30", Offset = "0xB0AF30", VA = "0x180B0BB30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GlobalChoiceSelectionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60057D1")]
	[Address(RVA = "0xB0BBF0", Offset = "0xB0AFF0", VA = "0x180B0BBF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60057D2")]
	[Address(RVA = "0xB0BCD0", Offset = "0xB0B0D0", VA = "0x180B0BCD0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GlobalChoiceSelectionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60057D3")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60057D4")]
	[Address(RVA = "0xB0BE00", Offset = "0xB0B200", VA = "0x180B0BE00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60057D5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60057D6")]
	[Address(RVA = "0xB0C340", Offset = "0xB0B740", VA = "0x180B0C340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60057D7")]
	[Address(RVA = "0xB0BA50", Offset = "0xB0AE50", VA = "0x180B0BA50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60057D8")]
	[Address(RVA = "0xB0BD70", Offset = "0xB0B170", VA = "0x180B0BD70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GlobalChoiceSelectionEvent other)
	{
	}

	[Token(Token = "0x60057D9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60057DA")]
	[Address(RVA = "0xB0C210", Offset = "0xB0B610", VA = "0x180B0C210", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
