using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x200083F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChoiceSelectedRequest : IMessage<ChoiceSelectedRequest>, IMessage, IEquatable<ChoiceSelectedRequest>, IDeepCloneable<ChoiceSelectedRequest>, IBufferMessage
{
	[Token(Token = "0x4001C69")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChoiceSelectedRequest> _parser;

	[Token(Token = "0x4001C6A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C6B")]
	public const int PositionFieldNumber = 1;

	[Token(Token = "0x4001C6C")]
	[FieldOffset(Offset = "0x18")]
	private int position_;

	[Token(Token = "0x170012A2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChoiceSelectedRequest> Parser
	{
		[Token(Token = "0x600579B")]
		[Address(RVA = "0xB06860", Offset = "0xB05C60", VA = "0x180B06860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600579C")]
		[Address(RVA = "0xB067B0", Offset = "0xB05BB0", VA = "0x180B067B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012A4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600579D")]
		[Address(RVA = "0xB068B0", Offset = "0xB05CB0", VA = "0x180B068B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012A5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x60057A1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60057A2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600579E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChoiceSelectedRequest()
	{
	}

	[Token(Token = "0x600579F")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChoiceSelectedRequest(ChoiceSelectedRequest other)
	{
	}

	[Token(Token = "0x60057A0")]
	[Address(RVA = "0xB06540", Offset = "0xB05940", VA = "0x180B06540", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChoiceSelectedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60057A3")]
	[Address(RVA = "0xB065C0", Offset = "0xB059C0", VA = "0x180B065C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60057A4")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ChoiceSelectedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60057A5")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60057A6")]
	[Address(RVA = "0xB06650", Offset = "0xB05A50", VA = "0x180B06650", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60057A7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60057A8")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60057A9")]
	[Address(RVA = "0xB064B0", Offset = "0xB058B0", VA = "0x180B064B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60057AA")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChoiceSelectedRequest other)
	{
	}

	[Token(Token = "0x60057AB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60057AC")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
