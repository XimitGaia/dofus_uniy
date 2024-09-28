using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x200006D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportToBuddyAnswerRequest : IMessage<TeleportToBuddyAnswerRequest>, IMessage, IEquatable<TeleportToBuddyAnswerRequest>, IDeepCloneable<TeleportToBuddyAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportToBuddyAnswerRequest> _parser;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400015D")]
	public const int AcceptFieldNumber = 1;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x18")]
	private bool accept_;

	[Token(Token = "0x170000C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TeleportToBuddyAnswerRequest> Parser
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x962FA0", Offset = "0x9623A0", VA = "0x180962FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x962EF0", Offset = "0x9622F0", VA = "0x180962EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x962FF0", Offset = "0x9623F0", VA = "0x180962FF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Accept
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportToBuddyAnswerRequest()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportToBuddyAnswerRequest(TeleportToBuddyAnswerRequest other)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x962BE0", Offset = "0x961FE0", VA = "0x180962BE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportToBuddyAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x962C60", Offset = "0x962060", VA = "0x180962C60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TeleportToBuddyAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x962CF0", Offset = "0x9620F0", VA = "0x180962CF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x962D90", Offset = "0x962190", VA = "0x180962D90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TeleportToBuddyAnswerRequest other)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
