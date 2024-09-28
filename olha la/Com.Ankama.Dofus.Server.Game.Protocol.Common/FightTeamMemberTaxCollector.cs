using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A38")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamMemberTaxCollector : IMessage<FightTeamMemberTaxCollector>, IMessage, IEquatable<FightTeamMemberTaxCollector>, IDeepCloneable<FightTeamMemberTaxCollector>, IBufferMessage
{
	[Token(Token = "0x40024CC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamMemberTaxCollector> _parser;

	[Token(Token = "0x40024CD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40024CE")]
	public const int FirstNameIdFieldNumber = 1;

	[Token(Token = "0x40024CF")]
	[FieldOffset(Offset = "0x18")]
	private int firstNameId_;

	[Token(Token = "0x40024D0")]
	public const int LastNameIdFieldNumber = 2;

	[Token(Token = "0x40024D1")]
	[FieldOffset(Offset = "0x1C")]
	private int lastNameId_;

	[Token(Token = "0x40024D2")]
	public const int GroupIdFieldNumber = 3;

	[Token(Token = "0x40024D3")]
	[FieldOffset(Offset = "0x20")]
	private int groupId_;

	[Token(Token = "0x40024D4")]
	public const int TaxCollectorUidFieldNumber = 4;

	[Token(Token = "0x40024D5")]
	[FieldOffset(Offset = "0x28")]
	private string taxCollectorUid_;

	[Token(Token = "0x17001712")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTeamMemberTaxCollector> Parser
	{
		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0xBBF570", Offset = "0xBBE970", VA = "0x180BBF570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001713")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0xBBF4C0", Offset = "0xBBE8C0", VA = "0x180BBF4C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001714")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0xBBF7B0", Offset = "0xBBEBB0", VA = "0x180BBF7B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001715")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FirstNameId
	{
		[Token(Token = "0x6006AD9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006ADA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001716")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastNameId
	{
		[Token(Token = "0x6006ADB")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006ADC")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001717")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		[Token(Token = "0x6006ADD")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006ADE")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001718")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TaxCollectorUid
	{
		[Token(Token = "0x6006ADF")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006AE0")]
		[Address(RVA = "0xBBF890", Offset = "0xBBEC90", VA = "0x180BBF890")]
		set
		{
		}
	}

	[Token(Token = "0x6006AD6")]
	[Address(RVA = "0xBBF470", Offset = "0xBBE870", VA = "0x180BBF470")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberTaxCollector()
	{
	}

	[Token(Token = "0x6006AD7")]
	[Address(RVA = "0xBBF3C0", Offset = "0xBBE7C0", VA = "0x180BBF3C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberTaxCollector(FightTeamMemberTaxCollector other)
	{
	}

	[Token(Token = "0x6006AD8")]
	[Address(RVA = "0xBBEF00", Offset = "0xBBE300", VA = "0x180BBEF00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberTaxCollector Clone()
	{
		return null;
	}

	[Token(Token = "0x6006AE1")]
	[Address(RVA = "0xBBEFE0", Offset = "0xBBE3E0", VA = "0x180BBEFE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AE2")]
	[Address(RVA = "0xBBF0A0", Offset = "0xBBE4A0", VA = "0x180BBF0A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTeamMemberTaxCollector other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AE3")]
	[Address(RVA = "0xBBF120", Offset = "0xBBE520", VA = "0x180BBF120", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006AE4")]
	[Address(RVA = "0xBBF260", Offset = "0xBBE660", VA = "0x180BBF260", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006AE5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006AE6")]
	[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006AE7")]
	[Address(RVA = "0xBBEDF0", Offset = "0xBBE1F0", VA = "0x180BBEDF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006AE8")]
	[Address(RVA = "0xBBF1E0", Offset = "0xBBE5E0", VA = "0x180BBF1E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTeamMemberTaxCollector other)
	{
	}

	[Token(Token = "0x6006AE9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006AEA")]
	[Address(RVA = "0xBBF5C0", Offset = "0xBBE9C0", VA = "0x180BBF5C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
