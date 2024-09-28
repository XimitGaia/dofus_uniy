using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x2000187")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestStepInformationRequest : IMessage<QuestStepInformationRequest>, IMessage, IEquatable<QuestStepInformationRequest>, IDeepCloneable<QuestStepInformationRequest>, IBufferMessage
{
	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestStepInformationRequest> _parser;

	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000535")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x4000536")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x1700034B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestStepInformationRequest> Parser
	{
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0xC4DBB0", Offset = "0xC4CFB0", VA = "0x180C4DBB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0xC4DB00", Offset = "0xC4CF00", VA = "0x180C4DB00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0xC4DC00", Offset = "0xC4D000", VA = "0x180C4DC00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestId
	{
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStepInformationRequest()
	{
	}

	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStepInformationRequest(QuestStepInformationRequest other)
	{
	}

	[Token(Token = "0x6000F68")]
	[Address(RVA = "0xC4D890", Offset = "0xC4CC90", VA = "0x180C4D890", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStepInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0xC4D910", Offset = "0xC4CD10", VA = "0x180C4D910", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestStepInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0xC4D9A0", Offset = "0xC4CDA0", VA = "0x180C4D9A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000F71")]
	[Address(RVA = "0xC4D800", Offset = "0xC4CC00", VA = "0x180C4D800", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestStepInformationRequest other)
	{
	}

	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
