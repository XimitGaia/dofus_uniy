using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Area;

[Token(Token = "0x2000BDA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubareaRewardRateEvent : IMessage<SubareaRewardRateEvent>, IMessage, IEquatable<SubareaRewardRateEvent>, IDeepCloneable<SubareaRewardRateEvent>, IBufferMessage
{
	[Token(Token = "0x4002C07")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SubareaRewardRateEvent> _parser;

	[Token(Token = "0x4002C08")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C09")]
	public const int SubareaRateFieldNumber = 1;

	[Token(Token = "0x4002C0A")]
	[FieldOffset(Offset = "0x18")]
	private int subareaRate_;

	[Token(Token = "0x17001B61")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SubareaRewardRateEvent> Parser
	{
		[Token(Token = "0x6007C90")]
		[Address(RVA = "0xC37E20", Offset = "0xC37220", VA = "0x180C37E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B62")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007C91")]
		[Address(RVA = "0xC37D70", Offset = "0xC37170", VA = "0x180C37D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B63")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007C92")]
		[Address(RVA = "0xC37E70", Offset = "0xC37270", VA = "0x180C37E70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B64")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubareaRate
	{
		[Token(Token = "0x6007C96")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007C97")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007C93")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubareaRewardRateEvent()
	{
	}

	[Token(Token = "0x6007C94")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubareaRewardRateEvent(SubareaRewardRateEvent other)
	{
	}

	[Token(Token = "0x6007C95")]
	[Address(RVA = "0xC37B00", Offset = "0xC36F00", VA = "0x180C37B00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubareaRewardRateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007C98")]
	[Address(RVA = "0xC37B80", Offset = "0xC36F80", VA = "0x180C37B80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C99")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SubareaRewardRateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C9A")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007C9B")]
	[Address(RVA = "0xC37C10", Offset = "0xC37010", VA = "0x180C37C10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007C9C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007C9D")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007C9E")]
	[Address(RVA = "0xC37A70", Offset = "0xC36E70", VA = "0x180C37A70", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007C9F")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubareaRewardRateEvent other)
	{
	}

	[Token(Token = "0x6007CA0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007CA1")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
