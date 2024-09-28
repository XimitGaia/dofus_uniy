using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000127")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpouseStatusEvent : IMessage<SpouseStatusEvent>, IMessage, IEquatable<SpouseStatusEvent>, IDeepCloneable<SpouseStatusEvent>, IBufferMessage
{
	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpouseStatusEvent> _parser;

	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003EB")]
	public const int HasSpouseFieldNumber = 1;

	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x18")]
	private bool hasSpouse_;

	[Token(Token = "0x17000269")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpouseStatusEvent> Parser
	{
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xB74DD0", Offset = "0xB741D0", VA = "0x180B74DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0xB74D20", Offset = "0xB74120", VA = "0x180B74D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xB74E20", Offset = "0xB74220", VA = "0x180B74E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasSpouse
	{
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpouseStatusEvent()
	{
	}

	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpouseStatusEvent(SpouseStatusEvent other)
	{
	}

	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0xB74A10", Offset = "0xB73E10", VA = "0x180B74A10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpouseStatusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0xB74A90", Offset = "0xB73E90", VA = "0x180B74A90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpouseStatusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B60")]
	[Address(RVA = "0xB74B20", Offset = "0xB73F20", VA = "0x180B74B20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000B61")]
	[Address(RVA = "0xB74BC0", Offset = "0xB73FC0", VA = "0x180B74BC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpouseStatusEvent other)
	{
	}

	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
