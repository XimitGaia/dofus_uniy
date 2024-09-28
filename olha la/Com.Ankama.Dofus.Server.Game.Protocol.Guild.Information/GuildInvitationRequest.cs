using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x2000496")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildInvitationRequest : IMessage<GuildInvitationRequest>, IMessage, IEquatable<GuildInvitationRequest>, IDeepCloneable<GuildInvitationRequest>, IBufferMessage
{
	[Token(Token = "0x4000FB9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildInvitationRequest> _parser;

	[Token(Token = "0x4000FBA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FBB")]
	public const int TargetIdFieldNumber = 1;

	[Token(Token = "0x4000FBC")]
	[FieldOffset(Offset = "0x18")]
	private long targetId_;

	[Token(Token = "0x17000A47")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildInvitationRequest> Parser
	{
		[Token(Token = "0x600303E")]
		[Address(RVA = "0x9D0020", Offset = "0x9CF420", VA = "0x1809D0020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A48")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x9CFF70", Offset = "0x9CF370", VA = "0x1809CFF70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A49")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003040")]
		[Address(RVA = "0x9D0070", Offset = "0x9CF470", VA = "0x1809D0070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A4A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetId
	{
		[Token(Token = "0x6003044")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003045")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6003041")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInvitationRequest()
	{
	}

	[Token(Token = "0x6003042")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitationRequest(GuildInvitationRequest other)
	{
	}

	[Token(Token = "0x6003043")]
	[Address(RVA = "0x9CFD00", Offset = "0x9CF100", VA = "0x1809CFD00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003046")]
	[Address(RVA = "0x9CFD80", Offset = "0x9CF180", VA = "0x1809CFD80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003047")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildInvitationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003048")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003049")]
	[Address(RVA = "0x9CFE10", Offset = "0x9CF210", VA = "0x1809CFE10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600304A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600304B")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600304C")]
	[Address(RVA = "0x9CFC70", Offset = "0x9CF070", VA = "0x1809CFC70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600304D")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildInvitationRequest other)
	{
	}

	[Token(Token = "0x600304E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600304F")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
