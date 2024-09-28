using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000713")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeItemAutoCraftStoppedEvent : IMessage<ExchangeItemAutoCraftStoppedEvent>, IMessage, IEquatable<ExchangeItemAutoCraftStoppedEvent>, IDeepCloneable<ExchangeItemAutoCraftStoppedEvent>, IBufferMessage
{
	[Token(Token = "0x2000714")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000715")]
		public enum ExchangeReplayStopReason
		{
			[Token(Token = "0x40018F6")]
			[OriginalName("OK")]
			Ok,
			[Token(Token = "0x40018F7")]
			[OriginalName("USER")]
			User,
			[Token(Token = "0x40018F8")]
			[OriginalName("MISSING_RESSOURCE")]
			MissingRessource,
			[Token(Token = "0x40018F9")]
			[OriginalName("IMPOSSIBLE_MODIFICATION")]
			ImpossibleModification
		}
	}

	[Token(Token = "0x40018F1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeItemAutoCraftStoppedEvent> _parser;

	[Token(Token = "0x40018F2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018F3")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x40018F4")]
	[FieldOffset(Offset = "0x18")]
	private Types.ExchangeReplayStopReason reason_;

	[Token(Token = "0x17001049")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeItemAutoCraftStoppedEvent> Parser
	{
		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0xABA0C0", Offset = "0xAB94C0", VA = "0x180ABA0C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700104A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0xABA010", Offset = "0xAB9410", VA = "0x180ABA010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700104B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004C10")]
		[Address(RVA = "0xABA110", Offset = "0xAB9510", VA = "0x180ABA110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700104C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ExchangeReplayStopReason Reason
	{
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.ExchangeReplayStopReason);
		}
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004C11")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeItemAutoCraftStoppedEvent()
	{
	}

	[Token(Token = "0x6004C12")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeItemAutoCraftStoppedEvent(ExchangeItemAutoCraftStoppedEvent other)
	{
	}

	[Token(Token = "0x6004C13")]
	[Address(RVA = "0xAB9DA0", Offset = "0xAB91A0", VA = "0x180AB9DA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeItemAutoCraftStoppedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004C16")]
	[Address(RVA = "0xAB9E20", Offset = "0xAB9220", VA = "0x180AB9E20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C17")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeItemAutoCraftStoppedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C18")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004C19")]
	[Address(RVA = "0xAB9EB0", Offset = "0xAB92B0", VA = "0x180AB9EB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004C1A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004C1B")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004C1C")]
	[Address(RVA = "0xAB9D10", Offset = "0xAB9110", VA = "0x180AB9D10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004C1D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeItemAutoCraftStoppedEvent other)
	{
	}

	[Token(Token = "0x6004C1E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004C1F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
