using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x2000821")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReloginTokenEvent : IMessage<ReloginTokenEvent>, IMessage, IEquatable<ReloginTokenEvent>, IDeepCloneable<ReloginTokenEvent>, IBufferMessage
{
	[Token(Token = "0x4001C13")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ReloginTokenEvent> _parser;

	[Token(Token = "0x4001C14")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C15")]
	public const int ValidTokenFieldNumber = 1;

	[Token(Token = "0x4001C16")]
	[FieldOffset(Offset = "0x18")]
	private bool validToken_;

	[Token(Token = "0x4001C17")]
	public const int TokenFieldNumber = 2;

	[Token(Token = "0x4001C18")]
	[FieldOffset(Offset = "0x20")]
	private string token_;

	[Token(Token = "0x17001262")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReloginTokenEvent> Parser
	{
		[Token(Token = "0x600565A")]
		[Address(RVA = "0xB101C0", Offset = "0xB0F5C0", VA = "0x180B101C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001263")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600565B")]
		[Address(RVA = "0xB10110", Offset = "0xB0F510", VA = "0x180B10110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001264")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600565C")]
		[Address(RVA = "0xB10380", Offset = "0xB0F780", VA = "0x180B10380", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001265")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool ValidToken
	{
		[Token(Token = "0x6005660")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005661")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001266")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Token
	{
		[Token(Token = "0x6005662")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005663")]
		[Address(RVA = "0xB10460", Offset = "0xB0F860", VA = "0x180B10460")]
		set
		{
		}
	}

	[Token(Token = "0x600565D")]
	[Address(RVA = "0xB100C0", Offset = "0xB0F4C0", VA = "0x180B100C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ReloginTokenEvent()
	{
	}

	[Token(Token = "0x600565E")]
	[Address(RVA = "0xB10010", Offset = "0xB0F410", VA = "0x180B10010")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ReloginTokenEvent(ReloginTokenEvent other)
	{
	}

	[Token(Token = "0x600565F")]
	[Address(RVA = "0xB0FB90", Offset = "0xB0EF90", VA = "0x180B0FB90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ReloginTokenEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005664")]
	[Address(RVA = "0xB0FC60", Offset = "0xB0F060", VA = "0x180B0FC60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005665")]
	[Address(RVA = "0xB0FD10", Offset = "0xB0F110", VA = "0x180B0FD10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ReloginTokenEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005666")]
	[Address(RVA = "0xB0FD80", Offset = "0xB0F180", VA = "0x180B0FD80", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005667")]
	[Address(RVA = "0xB0FEB0", Offset = "0xB0F2B0", VA = "0x180B0FEB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005668")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005669")]
	[Address(RVA = "0xB102F0", Offset = "0xB0F6F0", VA = "0x180B102F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600566A")]
	[Address(RVA = "0xB0FAF0", Offset = "0xB0EEF0", VA = "0x180B0FAF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600566B")]
	[Address(RVA = "0xB0FE40", Offset = "0xB0F240", VA = "0x180B0FE40", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ReloginTokenEvent other)
	{
	}

	[Token(Token = "0x600566C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600566D")]
	[Address(RVA = "0xB10210", Offset = "0xB0F610", VA = "0x180B10210", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
