using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x2000183")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestsRequest : IMessage<QuestsRequest>, IMessage, IEquatable<QuestsRequest>, IDeepCloneable<QuestsRequest>, IBufferMessage
{
	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestsRequest> _parser;

	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000344")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestsRequest> Parser
	{
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0xC50560", Offset = "0xC4F960", VA = "0x180C50560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000345")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0xC504B0", Offset = "0xC4F8B0", VA = "0x180C504B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000346")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0xC505B0", Offset = "0xC4F9B0", VA = "0x180C505B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestsRequest()
	{
	}

	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestsRequest(QuestsRequest other)
	{
	}

	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0xC50250", Offset = "0xC4F650", VA = "0x180C50250", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0xC502D0", Offset = "0xC4F6D0", VA = "0x180C502D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000F42")]
	[Address(RVA = "0xC50350", Offset = "0xC4F750", VA = "0x180C50350", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestsRequest other)
	{
	}

	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
