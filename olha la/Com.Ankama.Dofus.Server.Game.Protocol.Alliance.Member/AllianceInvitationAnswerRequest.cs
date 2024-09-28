using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C8C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceInvitationAnswerRequest : IMessage<AllianceInvitationAnswerRequest>, IMessage, IEquatable<AllianceInvitationAnswerRequest>, IDeepCloneable<AllianceInvitationAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4002E50")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceInvitationAnswerRequest> _parser;

	[Token(Token = "0x4002E51")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E52")]
	public const int AcceptedFieldNumber = 1;

	[Token(Token = "0x4002E53")]
	[FieldOffset(Offset = "0x18")]
	private bool accepted_;

	[Token(Token = "0x17001CEC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceInvitationAnswerRequest> Parser
	{
		[Token(Token = "0x6008415")]
		[Address(RVA = "0xC94080", Offset = "0xC93480", VA = "0x180C94080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008416")]
		[Address(RVA = "0xC93FD0", Offset = "0xC933D0", VA = "0x180C93FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CEE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008417")]
		[Address(RVA = "0xC940D0", Offset = "0xC934D0", VA = "0x180C940D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CEF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accepted
	{
		[Token(Token = "0x600841B")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600841C")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6008418")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInvitationAnswerRequest()
	{
	}

	[Token(Token = "0x6008419")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInvitationAnswerRequest(AllianceInvitationAnswerRequest other)
	{
	}

	[Token(Token = "0x600841A")]
	[Address(RVA = "0xC93CC0", Offset = "0xC930C0", VA = "0x180C93CC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitationAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600841D")]
	[Address(RVA = "0xC93D40", Offset = "0xC93140", VA = "0x180C93D40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600841E")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceInvitationAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600841F")]
	[Address(RVA = "0xC93DD0", Offset = "0xC931D0", VA = "0x180C93DD0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008420")]
	[Address(RVA = "0xC93E70", Offset = "0xC93270", VA = "0x180C93E70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008421")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008422")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008423")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008424")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceInvitationAnswerRequest other)
	{
	}

	[Token(Token = "0x6008425")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008426")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
