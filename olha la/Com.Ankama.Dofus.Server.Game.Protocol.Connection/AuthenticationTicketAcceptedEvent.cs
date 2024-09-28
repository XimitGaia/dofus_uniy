using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x2000819")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AuthenticationTicketAcceptedEvent : IMessage<AuthenticationTicketAcceptedEvent>, IMessage, IEquatable<AuthenticationTicketAcceptedEvent>, IDeepCloneable<AuthenticationTicketAcceptedEvent>, IBufferMessage
{
	[Token(Token = "0x4001BFE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AuthenticationTicketAcceptedEvent> _parser;

	[Token(Token = "0x4001BFF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001252")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AuthenticationTicketAcceptedEvent> Parser
	{
		[Token(Token = "0x6005603")]
		[Address(RVA = "0xAFAFF0", Offset = "0xAFA3F0", VA = "0x180AFAFF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001253")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005604")]
		[Address(RVA = "0xAFAF40", Offset = "0xAFA340", VA = "0x180AFAF40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001254")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005605")]
		[Address(RVA = "0xAFB040", Offset = "0xAFA440", VA = "0x180AFB040", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005606")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AuthenticationTicketAcceptedEvent()
	{
	}

	[Token(Token = "0x6005607")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AuthenticationTicketAcceptedEvent(AuthenticationTicketAcceptedEvent other)
	{
	}

	[Token(Token = "0x6005608")]
	[Address(RVA = "0xAFACE0", Offset = "0xAFA0E0", VA = "0x180AFACE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AuthenticationTicketAcceptedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005609")]
	[Address(RVA = "0xAFAD60", Offset = "0xAFA160", VA = "0x180AFAD60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600560A")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AuthenticationTicketAcceptedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600560B")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600560C")]
	[Address(RVA = "0xAFADE0", Offset = "0xAFA1E0", VA = "0x180AFADE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600560D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600560E")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600560F")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005610")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AuthenticationTicketAcceptedEvent other)
	{
	}

	[Token(Token = "0x6005611")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005612")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
