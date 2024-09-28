using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000863")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ResetCharacterCharacteristicsRequest : IMessage<ResetCharacterCharacteristicsRequest>, IMessage, IEquatable<ResetCharacterCharacteristicsRequest>, IDeepCloneable<ResetCharacterCharacteristicsRequest>, IBufferMessage
{
	[Token(Token = "0x4001D13")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ResetCharacterCharacteristicsRequest> _parser;

	[Token(Token = "0x4001D14")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170012FB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ResetCharacterCharacteristicsRequest> Parser
	{
		[Token(Token = "0x600591D")]
		[Address(RVA = "0xB29160", Offset = "0xB28560", VA = "0x180B29160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600591E")]
		[Address(RVA = "0xB290B0", Offset = "0xB284B0", VA = "0x180B290B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012FD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600591F")]
		[Address(RVA = "0xB291B0", Offset = "0xB285B0", VA = "0x180B291B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005920")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetCharacterCharacteristicsRequest()
	{
	}

	[Token(Token = "0x6005921")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetCharacterCharacteristicsRequest(ResetCharacterCharacteristicsRequest other)
	{
	}

	[Token(Token = "0x6005922")]
	[Address(RVA = "0xB28E50", Offset = "0xB28250", VA = "0x180B28E50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetCharacterCharacteristicsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005923")]
	[Address(RVA = "0xB28ED0", Offset = "0xB282D0", VA = "0x180B28ED0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005924")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ResetCharacterCharacteristicsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005925")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005926")]
	[Address(RVA = "0xB28F50", Offset = "0xB28350", VA = "0x180B28F50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005927")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005928")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005929")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600592A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ResetCharacterCharacteristicsRequest other)
	{
	}

	[Token(Token = "0x600592B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600592C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
