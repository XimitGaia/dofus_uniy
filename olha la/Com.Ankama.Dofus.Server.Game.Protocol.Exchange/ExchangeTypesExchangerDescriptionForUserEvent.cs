using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006F8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeTypesExchangerDescriptionForUserEvent : IMessage<ExchangeTypesExchangerDescriptionForUserEvent>, IMessage, IEquatable<ExchangeTypesExchangerDescriptionForUserEvent>, IDeepCloneable<ExchangeTypesExchangerDescriptionForUserEvent>, IBufferMessage
{
	[Token(Token = "0x4001883")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeTypesExchangerDescriptionForUserEvent> _parser;

	[Token(Token = "0x4001884")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001885")]
	public const int ObjectTypeFieldNumber = 1;

	[Token(Token = "0x4001886")]
	[FieldOffset(Offset = "0x18")]
	private int objectType_;

	[Token(Token = "0x4001887")]
	public const int TypeDescriptionFieldNumber = 2;

	[Token(Token = "0x4001888")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_typeDescription_codec;

	[Token(Token = "0x4001889")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> typeDescription_;

	[Token(Token = "0x17001004")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeTypesExchangerDescriptionForUserEvent> Parser
	{
		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0xAAEDB0", Offset = "0xAAE1B0", VA = "0x180AAEDB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001005")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004ADA")]
		[Address(RVA = "0xAAED00", Offset = "0xAAE100", VA = "0x180AAED00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001006")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004ADB")]
		[Address(RVA = "0xAAF000", Offset = "0xAAE400", VA = "0x180AAF000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001007")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectType
	{
		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001008")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> TypeDescription
	{
		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004ADC")]
	[Address(RVA = "0xAAEBF0", Offset = "0xAADFF0", VA = "0x180AAEBF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeTypesExchangerDescriptionForUserEvent()
	{
	}

	[Token(Token = "0x6004ADD")]
	[Address(RVA = "0xAAEC70", Offset = "0xAAE070", VA = "0x180AAEC70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTypesExchangerDescriptionForUserEvent(ExchangeTypesExchangerDescriptionForUserEvent other)
	{
	}

	[Token(Token = "0x6004ADE")]
	[Address(RVA = "0xAAE790", Offset = "0xAADB90", VA = "0x180AAE790", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTypesExchangerDescriptionForUserEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004AE2")]
	[Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AE3")]
	[Address(RVA = "0xAAE850", Offset = "0xAADC50", VA = "0x180AAE850", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeTypesExchangerDescriptionForUserEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AE4")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004AE5")]
	[Address(RVA = "0xAAEA60", Offset = "0xAADE60", VA = "0x180AAEA60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004AE6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004AE7")]
	[Address(RVA = "0xAAEF30", Offset = "0xAAE330", VA = "0x180AAEF30", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004AE8")]
	[Address(RVA = "0xAAE6B0", Offset = "0xAADAB0", VA = "0x180AAE6B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004AE9")]
	[Address(RVA = "0xAAE9D0", Offset = "0xAADDD0", VA = "0x180AAE9D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeTypesExchangerDescriptionForUserEvent other)
	{
	}

	[Token(Token = "0x6004AEA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004AEB")]
	[Address(RVA = "0xAAEE00", Offset = "0xAAE200", VA = "0x180AAEE00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
