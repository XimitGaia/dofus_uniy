using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B3C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BasicLatencyStatsRequest : IMessage<BasicLatencyStatsRequest>, IMessage, IEquatable<BasicLatencyStatsRequest>, IDeepCloneable<BasicLatencyStatsRequest>, IBufferMessage
{
	[Token(Token = "0x40029F8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BasicLatencyStatsRequest> _parser;

	[Token(Token = "0x40029F9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40029FA")]
	public const int LatencyFieldNumber = 1;

	[Token(Token = "0x40029FB")]
	[FieldOffset(Offset = "0x18")]
	private int latency_;

	[Token(Token = "0x17001A18")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BasicLatencyStatsRequest> Parser
	{
		[Token(Token = "0x600766A")]
		[Address(RVA = "0xC216A0", Offset = "0xC20AA0", VA = "0x180C216A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A19")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600766B")]
		[Address(RVA = "0xC215F0", Offset = "0xC209F0", VA = "0x180C215F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A1A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600766C")]
		[Address(RVA = "0xC216F0", Offset = "0xC20AF0", VA = "0x180C216F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A1B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Latency
	{
		[Token(Token = "0x6007670")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007671")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600766D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BasicLatencyStatsRequest()
	{
	}

	[Token(Token = "0x600766E")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BasicLatencyStatsRequest(BasicLatencyStatsRequest other)
	{
	}

	[Token(Token = "0x600766F")]
	[Address(RVA = "0xC21380", Offset = "0xC20780", VA = "0x180C21380", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BasicLatencyStatsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007672")]
	[Address(RVA = "0xC21400", Offset = "0xC20800", VA = "0x180C21400", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007673")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BasicLatencyStatsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007674")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007675")]
	[Address(RVA = "0xC21490", Offset = "0xC20890", VA = "0x180C21490", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007676")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007677")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007678")]
	[Address(RVA = "0xC212F0", Offset = "0xC206F0", VA = "0x180C212F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007679")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BasicLatencyStatsRequest other)
	{
	}

	[Token(Token = "0x600767A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600767B")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
