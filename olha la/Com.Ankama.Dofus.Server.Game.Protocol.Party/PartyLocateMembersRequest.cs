using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200026A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyLocateMembersRequest : IMessage<PartyLocateMembersRequest>, IMessage, IEquatable<PartyLocateMembersRequest>, IDeepCloneable<PartyLocateMembersRequest>, IBufferMessage
{
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyLocateMembersRequest> _parser;

	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400082C")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x1700053D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyLocateMembersRequest> Parser
	{
		[Token(Token = "0x600189E")]
		[Address(RVA = "0xCFA760", Offset = "0xCF9B60", VA = "0x180CFA760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600189F")]
		[Address(RVA = "0xCFA6B0", Offset = "0xCF9AB0", VA = "0x180CFA6B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0xCFA7B0", Offset = "0xCF9BB0", VA = "0x180CFA7B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000540")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyLocateMembersRequest()
	{
	}

	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyLocateMembersRequest(PartyLocateMembersRequest other)
	{
	}

	[Token(Token = "0x60018A3")]
	[Address(RVA = "0xCFA440", Offset = "0xCF9840", VA = "0x180CFA440", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyLocateMembersRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60018A6")]
	[Address(RVA = "0xCFA4C0", Offset = "0xCF98C0", VA = "0x180CFA4C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyLocateMembersRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60018A9")]
	[Address(RVA = "0xCFA550", Offset = "0xCF9950", VA = "0x180CFA550", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60018AB")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60018AC")]
	[Address(RVA = "0xCFA3B0", Offset = "0xCF97B0", VA = "0x180CFA3B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyLocateMembersRequest other)
	{
	}

	[Token(Token = "0x60018AE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
