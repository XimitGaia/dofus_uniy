using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C64")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationAnswerRequest : IMessage<AllianceApplicationAnswerRequest>, IMessage, IEquatable<AllianceApplicationAnswerRequest>, IDeepCloneable<AllianceApplicationAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4002DD5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationAnswerRequest> _parser;

	[Token(Token = "0x4002DD6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DD7")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4002DD8")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x4002DD9")]
	public const int AcceptedFieldNumber = 2;

	[Token(Token = "0x4002DDA")]
	[FieldOffset(Offset = "0x20")]
	private bool accepted_;

	[Token(Token = "0x17001C93")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceApplicationAnswerRequest> Parser
	{
		[Token(Token = "0x600825D")]
		[Address(RVA = "0xC6EDF0", Offset = "0xC6E1F0", VA = "0x180C6EDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C94")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600825E")]
		[Address(RVA = "0xC6ED40", Offset = "0xC6E140", VA = "0x180C6ED40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C95")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600825F")]
		[Address(RVA = "0xC6EE40", Offset = "0xC6E240", VA = "0x180C6EE40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C96")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x6008263")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008264")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001C97")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accepted
	{
		[Token(Token = "0x6008265")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008266")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6008260")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationAnswerRequest()
	{
	}

	[Token(Token = "0x6008261")]
	[Address(RVA = "0x9D4B00", Offset = "0x9D3F00", VA = "0x1809D4B00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationAnswerRequest(AllianceApplicationAnswerRequest other)
	{
	}

	[Token(Token = "0x6008262")]
	[Address(RVA = "0xC6E9E0", Offset = "0xC6DDE0", VA = "0x180C6E9E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008267")]
	[Address(RVA = "0xC6EA70", Offset = "0xC6DE70", VA = "0x180C6EA70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008268")]
	[Address(RVA = "0x9D4790", Offset = "0x9D3B90", VA = "0x1809D4790", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008269")]
	[Address(RVA = "0xC6EB10", Offset = "0xC6DF10", VA = "0x180C6EB10", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600826A")]
	[Address(RVA = "0xC6EBE0", Offset = "0xC6DFE0", VA = "0x180C6EBE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600826B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600826C")]
	[Address(RVA = "0x9D4D20", Offset = "0x9D4120", VA = "0x1809D4D20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600826D")]
	[Address(RVA = "0xC6E950", Offset = "0xC6DD50", VA = "0x180C6E950", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600826E")]
	[Address(RVA = "0x9D4940", Offset = "0x9D3D40", VA = "0x1809D4940", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceApplicationAnswerRequest other)
	{
	}

	[Token(Token = "0x600826F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008270")]
	[Address(RVA = "0x9D4C60", Offset = "0x9D4060", VA = "0x1809D4C60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
