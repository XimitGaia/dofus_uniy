using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A05")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NamedPartyTeam : IMessage<NamedPartyTeam>, IMessage, IEquatable<NamedPartyTeam>, IDeepCloneable<NamedPartyTeam>, IBufferMessage
{
	[Token(Token = "0x40023DD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NamedPartyTeam> _parser;

	[Token(Token = "0x40023DE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40023DF")]
	public const int TeamFieldNumber = 1;

	[Token(Token = "0x40023E0")]
	[FieldOffset(Offset = "0x18")]
	private Team team_;

	[Token(Token = "0x40023E1")]
	public const int PartyNameFieldNumber = 2;

	[Token(Token = "0x40023E2")]
	[FieldOffset(Offset = "0x20")]
	private string partyName_;

	[Token(Token = "0x17001685")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NamedPartyTeam> Parser
	{
		[Token(Token = "0x600689A")]
		[Address(RVA = "0xBAC910", Offset = "0xBABD10", VA = "0x180BAC910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001686")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600689B")]
		[Address(RVA = "0xBAC860", Offset = "0xBABC60", VA = "0x180BAC860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001687")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600689C")]
		[Address(RVA = "0xBACA30", Offset = "0xBABE30", VA = "0x180BACA30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001688")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Team Team
	{
		[Token(Token = "0x60068A0")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x60068A1")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001689")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PartyName
	{
		[Token(Token = "0x60068A2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60068A3")]
		[Address(RVA = "0xBACB10", Offset = "0xBABF10", VA = "0x180BACB10")]
		set
		{
		}
	}

	[Token(Token = "0x600689D")]
	[Address(RVA = "0xBAC760", Offset = "0xBABB60", VA = "0x180BAC760")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NamedPartyTeam()
	{
	}

	[Token(Token = "0x600689E")]
	[Address(RVA = "0xBAC7B0", Offset = "0xBABBB0", VA = "0x180BAC7B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NamedPartyTeam(NamedPartyTeam other)
	{
	}

	[Token(Token = "0x600689F")]
	[Address(RVA = "0xBAC410", Offset = "0xBAB810", VA = "0x180BAC410", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NamedPartyTeam Clone()
	{
		return null;
	}

	[Token(Token = "0x60068A4")]
	[Address(RVA = "0xBAC4E0", Offset = "0xBAB8E0", VA = "0x180BAC4E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60068A5")]
	[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(NamedPartyTeam other)
	{
		return default(bool);
	}

	[Token(Token = "0x60068A6")]
	[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60068A7")]
	[Address(RVA = "0xBAC600", Offset = "0xBABA00", VA = "0x180BAC600", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60068A8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60068A9")]
	[Address(RVA = "0xAD91E0", Offset = "0xAD85E0", VA = "0x180AD91E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60068AA")]
	[Address(RVA = "0xBAC350", Offset = "0xBAB750", VA = "0x180BAC350", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60068AB")]
	[Address(RVA = "0xBAC590", Offset = "0xBAB990", VA = "0x180BAC590", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NamedPartyTeam other)
	{
	}

	[Token(Token = "0x60068AC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60068AD")]
	[Address(RVA = "0xBAC960", Offset = "0xBABD60", VA = "0x180BAC960", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
