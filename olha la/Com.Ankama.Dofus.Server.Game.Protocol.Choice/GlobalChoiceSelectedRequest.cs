using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x2000845")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GlobalChoiceSelectedRequest : IMessage<GlobalChoiceSelectedRequest>, IMessage, IEquatable<GlobalChoiceSelectedRequest>, IDeepCloneable<GlobalChoiceSelectedRequest>, IBufferMessage
{
	[Token(Token = "0x4001C7E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GlobalChoiceSelectedRequest> _parser;

	[Token(Token = "0x4001C7F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C80")]
	public const int PositionFieldNumber = 1;

	[Token(Token = "0x4001C81")]
	[FieldOffset(Offset = "0x18")]
	private int position_;

	[Token(Token = "0x170012B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GlobalChoiceSelectedRequest> Parser
	{
		[Token(Token = "0x60057DF")]
		[Address(RVA = "0xB0B920", Offset = "0xB0AD20", VA = "0x180B0B920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60057E0")]
		[Address(RVA = "0xB0B870", Offset = "0xB0AC70", VA = "0x180B0B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60057E1")]
		[Address(RVA = "0xB0B970", Offset = "0xB0AD70", VA = "0x180B0B970", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x60057E5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60057E6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60057E2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GlobalChoiceSelectedRequest()
	{
	}

	[Token(Token = "0x60057E3")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GlobalChoiceSelectedRequest(GlobalChoiceSelectedRequest other)
	{
	}

	[Token(Token = "0x60057E4")]
	[Address(RVA = "0xB0B600", Offset = "0xB0AA00", VA = "0x180B0B600", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GlobalChoiceSelectedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60057E7")]
	[Address(RVA = "0xB0B680", Offset = "0xB0AA80", VA = "0x180B0B680", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60057E8")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GlobalChoiceSelectedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60057E9")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60057EA")]
	[Address(RVA = "0xB0B710", Offset = "0xB0AB10", VA = "0x180B0B710", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60057EB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60057EC")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60057ED")]
	[Address(RVA = "0xB0B570", Offset = "0xB0A970", VA = "0x180B0B570", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60057EE")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GlobalChoiceSelectedRequest other)
	{
	}

	[Token(Token = "0x60057EF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60057F0")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
