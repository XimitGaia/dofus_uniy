using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200042F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagInvitationAnswerRequest : IMessage<HavenBagInvitationAnswerRequest>, IMessage, IEquatable<HavenBagInvitationAnswerRequest>, IDeepCloneable<HavenBagInvitationAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagInvitationAnswerRequest> _parser;

	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E85")]
	public const int AcceptedFieldNumber = 1;

	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x18")]
	private bool accepted_;

	[Token(Token = "0x17000975")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagInvitationAnswerRequest> Parser
	{
		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x9BCD90", Offset = "0x9BC190", VA = "0x1809BCD90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000976")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x9BCCE0", Offset = "0x9BC0E0", VA = "0x1809BCCE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000977")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x9BCDE0", Offset = "0x9BC1E0", VA = "0x1809BCDE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000978")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accepted
	{
		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C33")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6002C2F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationAnswerRequest()
	{
	}

	[Token(Token = "0x6002C30")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationAnswerRequest(HavenBagInvitationAnswerRequest other)
	{
	}

	[Token(Token = "0x6002C31")]
	[Address(RVA = "0x9BC9D0", Offset = "0x9BBDD0", VA = "0x1809BC9D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002C34")]
	[Address(RVA = "0x9BCA50", Offset = "0x9BBE50", VA = "0x1809BCA50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C35")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HavenBagInvitationAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C36")]
	[Address(RVA = "0x9BCAE0", Offset = "0x9BBEE0", VA = "0x1809BCAE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002C37")]
	[Address(RVA = "0x9BCB80", Offset = "0x9BBF80", VA = "0x1809BCB80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002C38")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002C39")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002C3A")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002C3B")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagInvitationAnswerRequest other)
	{
	}

	[Token(Token = "0x6002C3C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002C3D")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
