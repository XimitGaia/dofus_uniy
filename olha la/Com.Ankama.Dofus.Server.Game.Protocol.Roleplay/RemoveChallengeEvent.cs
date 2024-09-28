using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x200017A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RemoveChallengeEvent : IMessage<RemoveChallengeEvent>, IMessage, IEquatable<RemoveChallengeEvent>, IDeepCloneable<RemoveChallengeEvent>, IBufferMessage
{
	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RemoveChallengeEvent> _parser;

	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000506")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x1700032A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RemoveChallengeEvent> Parser
	{
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0xC50A40", Offset = "0xC4FE40", VA = "0x180C50A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700032B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0xC50990", Offset = "0xC4FD90", VA = "0x180C50990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700032C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0xC50A90", Offset = "0xC4FE90", VA = "0x180C50A90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700032D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FightId
	{
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveChallengeEvent()
	{
	}

	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveChallengeEvent(RemoveChallengeEvent other)
	{
	}

	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0xC50720", Offset = "0xC4FB20", VA = "0x180C50720", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveChallengeEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0xC507A0", Offset = "0xC4FBA0", VA = "0x180C507A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RemoveChallengeEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0xC50830", Offset = "0xC4FC30", VA = "0x180C50830", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0xC50690", Offset = "0xC4FA90", VA = "0x180C50690", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RemoveChallengeEvent other)
	{
	}

	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
