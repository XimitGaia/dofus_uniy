using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200071F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeJobIndexStartedEvent : IMessage<ExchangeJobIndexStartedEvent>, IMessage, IEquatable<ExchangeJobIndexStartedEvent>, IDeepCloneable<ExchangeJobIndexStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4001913")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeJobIndexStartedEvent> _parser;

	[Token(Token = "0x4001914")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001915")]
	public const int JobsFieldNumber = 1;

	[Token(Token = "0x4001916")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_jobs_codec;

	[Token(Token = "0x4001917")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> jobs_;

	[Token(Token = "0x1700105F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeJobIndexStartedEvent> Parser
	{
		[Token(Token = "0x6004C80")]
		[Address(RVA = "0xABA890", Offset = "0xAB9C90", VA = "0x180ABA890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001060")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004C81")]
		[Address(RVA = "0xABA7E0", Offset = "0xAB9BE0", VA = "0x180ABA7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001061")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004C82")]
		[Address(RVA = "0xABAAB0", Offset = "0xAB9EB0", VA = "0x180ABAAB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001062")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Jobs
	{
		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004C83")]
	[Address(RVA = "0xABA760", Offset = "0xAB9B60", VA = "0x180ABA760")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeJobIndexStartedEvent()
	{
	}

	[Token(Token = "0x6004C84")]
	[Address(RVA = "0xABA6D0", Offset = "0xAB9AD0", VA = "0x180ABA6D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeJobIndexStartedEvent(ExchangeJobIndexStartedEvent other)
	{
	}

	[Token(Token = "0x6004C85")]
	[Address(RVA = "0xABA290", Offset = "0xAB9690", VA = "0x180ABA290", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeJobIndexStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004C87")]
	[Address(RVA = "0xABA3E0", Offset = "0xAB97E0", VA = "0x180ABA3E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C88")]
	[Address(RVA = "0xABA350", Offset = "0xAB9750", VA = "0x180ABA350", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeJobIndexStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C89")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004C8A")]
	[Address(RVA = "0xABA540", Offset = "0xAB9940", VA = "0x180ABA540", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004C8B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004C8C")]
	[Address(RVA = "0xABAA00", Offset = "0xAB9E00", VA = "0x180ABAA00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004C8D")]
	[Address(RVA = "0xABA1F0", Offset = "0xAB95F0", VA = "0x180ABA1F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004C8E")]
	[Address(RVA = "0xABA4C0", Offset = "0xAB98C0", VA = "0x180ABA4C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeJobIndexStartedEvent other)
	{
	}

	[Token(Token = "0x6004C8F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004C90")]
	[Address(RVA = "0xABA8E0", Offset = "0xAB9CE0", VA = "0x180ABA8E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
