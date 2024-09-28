using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x2000498")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildInvitationAnswerRequest : IMessage<GuildInvitationAnswerRequest>, IMessage, IEquatable<GuildInvitationAnswerRequest>, IDeepCloneable<GuildInvitationAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4000FBE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildInvitationAnswerRequest> _parser;

	[Token(Token = "0x4000FBF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FC0")]
	public const int AcceptedFieldNumber = 1;

	[Token(Token = "0x4000FC1")]
	[FieldOffset(Offset = "0x18")]
	private bool accepted_;

	[Token(Token = "0x17000A4B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildInvitationAnswerRequest> Parser
	{
		[Token(Token = "0x6003054")]
		[Address(RVA = "0x9CFB40", Offset = "0x9CEF40", VA = "0x1809CFB40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A4C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003055")]
		[Address(RVA = "0x9CFA90", Offset = "0x9CEE90", VA = "0x1809CFA90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A4D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003056")]
		[Address(RVA = "0x9CFB90", Offset = "0x9CEF90", VA = "0x1809CFB90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A4E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Accepted
	{
		[Token(Token = "0x600305A")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600305B")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6003057")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInvitationAnswerRequest()
	{
	}

	[Token(Token = "0x6003058")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInvitationAnswerRequest(GuildInvitationAnswerRequest other)
	{
	}

	[Token(Token = "0x6003059")]
	[Address(RVA = "0x9CF780", Offset = "0x9CEB80", VA = "0x1809CF780", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitationAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600305C")]
	[Address(RVA = "0x9CF800", Offset = "0x9CEC00", VA = "0x1809CF800", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600305D")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildInvitationAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600305E")]
	[Address(RVA = "0x9CF890", Offset = "0x9CEC90", VA = "0x1809CF890", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600305F")]
	[Address(RVA = "0x9CF930", Offset = "0x9CED30", VA = "0x1809CF930", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003060")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003061")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003062")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003063")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildInvitationAnswerRequest other)
	{
	}

	[Token(Token = "0x6003064")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003065")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
