using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x2000847")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GlobalChoiceVoteEvent : IMessage<GlobalChoiceVoteEvent>, IMessage, IEquatable<GlobalChoiceVoteEvent>, IDeepCloneable<GlobalChoiceVoteEvent>, IBufferMessage
{
	[Token(Token = "0x4001C83")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GlobalChoiceVoteEvent> _parser;

	[Token(Token = "0x4001C84")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C85")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4001C86")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x4001C87")]
	public const int ChoicePositionFieldNumber = 2;

	[Token(Token = "0x4001C88")]
	[FieldOffset(Offset = "0x20")]
	private int choicePosition_;

	[Token(Token = "0x170012B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GlobalChoiceVoteEvent> Parser
	{
		[Token(Token = "0x60057F5")]
		[Address(RVA = "0xB0C8F0", Offset = "0xB0BCF0", VA = "0x180B0C8F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60057F6")]
		[Address(RVA = "0xB0C840", Offset = "0xB0BC40", VA = "0x180B0C840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60057F7")]
		[Address(RVA = "0xB0C940", Offset = "0xB0BD40", VA = "0x180B0C940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x60057FB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60057FC")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170012B8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ChoicePosition
	{
		[Token(Token = "0x60057FD")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60057FE")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60057F8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GlobalChoiceVoteEvent()
	{
	}

	[Token(Token = "0x60057F9")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GlobalChoiceVoteEvent(GlobalChoiceVoteEvent other)
	{
	}

	[Token(Token = "0x60057FA")]
	[Address(RVA = "0xB0C5B0", Offset = "0xB0B9B0", VA = "0x180B0C5B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GlobalChoiceVoteEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60057FF")]
	[Address(RVA = "0xB0C640", Offset = "0xB0BA40", VA = "0x180B0C640", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005800")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GlobalChoiceVoteEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005801")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005802")]
	[Address(RVA = "0xB0C6E0", Offset = "0xB0BAE0", VA = "0x180B0C6E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005803")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005804")]
	[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005805")]
	[Address(RVA = "0xB0C4F0", Offset = "0xB0B8F0", VA = "0x180B0C4F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005806")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GlobalChoiceVoteEvent other)
	{
	}

	[Token(Token = "0x6005807")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005808")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
