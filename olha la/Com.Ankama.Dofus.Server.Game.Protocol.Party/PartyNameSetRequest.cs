using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000272")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyNameSetRequest : IMessage<PartyNameSetRequest>, IMessage, IEquatable<PartyNameSetRequest>, IDeepCloneable<PartyNameSetRequest>, IBufferMessage
{
	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyNameSetRequest> _parser;

	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000844")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000846")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x1700054F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyNameSetRequest> Parser
	{
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0xCFAE50", Offset = "0xCFA250", VA = "0x180CFAE50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000550")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0xCFADA0", Offset = "0xCFA1A0", VA = "0x180CFADA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000551")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0xCFAF70", Offset = "0xCFA370", VA = "0x180CFAF70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000552")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000553")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6001902")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001903")]
		[Address(RVA = "0xCFB050", Offset = "0xCFA450", VA = "0x180CFB050")]
		set
		{
		}
	}

	[Token(Token = "0x60018FD")]
	[Address(RVA = "0xCFAD50", Offset = "0xCFA150", VA = "0x180CFAD50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyNameSetRequest()
	{
	}

	[Token(Token = "0x60018FE")]
	[Address(RVA = "0xCFACA0", Offset = "0xCFA0A0", VA = "0x180CFACA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyNameSetRequest(PartyNameSetRequest other)
	{
	}

	[Token(Token = "0x60018FF")]
	[Address(RVA = "0xCFA950", Offset = "0xCF9D50", VA = "0x180CFA950", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyNameSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001904")]
	[Address(RVA = "0xCFAA20", Offset = "0xCF9E20", VA = "0x180CFAA20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001905")]
	[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyNameSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001906")]
	[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001907")]
	[Address(RVA = "0xCFAB40", Offset = "0xCF9F40", VA = "0x180CFAB40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001908")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001909")]
	[Address(RVA = "0xB789B0", Offset = "0xB77DB0", VA = "0x180B789B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600190A")]
	[Address(RVA = "0xCFA890", Offset = "0xCF9C90", VA = "0x180CFA890", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600190B")]
	[Address(RVA = "0xCFAAD0", Offset = "0xCF9ED0", VA = "0x180CFAAD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyNameSetRequest other)
	{
	}

	[Token(Token = "0x600190C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600190D")]
	[Address(RVA = "0xCFAEA0", Offset = "0xCFA2A0", VA = "0x180CFAEA0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
