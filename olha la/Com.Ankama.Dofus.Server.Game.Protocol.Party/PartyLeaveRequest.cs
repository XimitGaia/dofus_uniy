using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200026C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyLeaveRequest : IMessage<PartyLeaveRequest>, IMessage, IEquatable<PartyLeaveRequest>, IDeepCloneable<PartyLeaveRequest>, IBufferMessage
{
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyLeaveRequest> _parser;

	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000831")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x17000541")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyLeaveRequest> Parser
	{
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0xCFA280", Offset = "0xCF9680", VA = "0x180CFA280")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000542")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0xCFA1D0", Offset = "0xCF95D0", VA = "0x180CFA1D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000543")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0xCFA2D0", Offset = "0xCF96D0", VA = "0x180CFA2D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000544")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60018B7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyLeaveRequest()
	{
	}

	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyLeaveRequest(PartyLeaveRequest other)
	{
	}

	[Token(Token = "0x60018B9")]
	[Address(RVA = "0xCF9F60", Offset = "0xCF9360", VA = "0x180CF9F60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyLeaveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60018BC")]
	[Address(RVA = "0xCF9FE0", Offset = "0xCF93E0", VA = "0x180CF9FE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60018BD")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyLeaveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60018BF")]
	[Address(RVA = "0xCFA070", Offset = "0xCF9470", VA = "0x180CFA070", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60018C2")]
	[Address(RVA = "0xCF9ED0", Offset = "0xCF92D0", VA = "0x180CF9ED0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyLeaveRequest other)
	{
	}

	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
