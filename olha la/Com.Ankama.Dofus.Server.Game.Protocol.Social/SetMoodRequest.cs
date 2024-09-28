using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x200011F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetMoodRequest : IMessage<SetMoodRequest>, IMessage, IEquatable<SetMoodRequest>, IDeepCloneable<SetMoodRequest>, IBufferMessage
{
	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SetMoodRequest> _parser;

	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003D2")]
	public const int SmileyIdFieldNumber = 1;

	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x18")]
	private int smileyId_;

	[Token(Token = "0x1700025A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SetMoodRequest> Parser
	{
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0xB6D090", Offset = "0xB6C490", VA = "0x180B6D090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0xB6CFE0", Offset = "0xB6C3E0", VA = "0x180B6CFE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0xB6D0E0", Offset = "0xB6C4E0", VA = "0x180B6D0E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SmileyId
	{
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetMoodRequest()
	{
	}

	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SetMoodRequest(SetMoodRequest other)
	{
	}

	[Token(Token = "0x6000B13")]
	[Address(RVA = "0xB6CD70", Offset = "0xB6C170", VA = "0x180B6CD70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SetMoodRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000B16")]
	[Address(RVA = "0xB6CDF0", Offset = "0xB6C1F0", VA = "0x180B6CDF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SetMoodRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000B19")]
	[Address(RVA = "0xB6CE80", Offset = "0xB6C280", VA = "0x180B6CE80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0xB6CCE0", Offset = "0xB6C0E0", VA = "0x180B6CCE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetMoodRequest other)
	{
	}

	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
