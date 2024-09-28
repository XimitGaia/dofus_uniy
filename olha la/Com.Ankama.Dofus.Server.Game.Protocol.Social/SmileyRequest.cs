using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000119")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SmileyRequest : IMessage<SmileyRequest>, IMessage, IEquatable<SmileyRequest>, IDeepCloneable<SmileyRequest>, IBufferMessage
{
	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SmileyRequest> _parser;

	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003B9")]
	public const int SmileyIdFieldNumber = 1;

	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x18")]
	private int smileyId_;

	[Token(Token = "0x17000249")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SmileyRequest> Parser
	{
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xB6EA80", Offset = "0xB6DE80", VA = "0x180B6EA80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0xB6E9D0", Offset = "0xB6DDD0", VA = "0x180B6E9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0xB6EAD0", Offset = "0xB6DED0", VA = "0x180B6EAD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SmileyId
	{
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SmileyRequest()
	{
	}

	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SmileyRequest(SmileyRequest other)
	{
	}

	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0xB6E760", Offset = "0xB6DB60", VA = "0x180B6E760", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SmileyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0xB6E7E0", Offset = "0xB6DBE0", VA = "0x180B6E7E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SmileyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0xB6E870", Offset = "0xB6DC70", VA = "0x180B6E870", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000ACF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0xB6E6D0", Offset = "0xB6DAD0", VA = "0x180B6E6D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000AD2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SmileyRequest other)
	{
	}

	[Token(Token = "0x6000AD3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
