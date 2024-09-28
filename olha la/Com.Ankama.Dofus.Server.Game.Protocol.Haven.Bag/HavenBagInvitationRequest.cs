using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000431")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagInvitationRequest : IMessage<HavenBagInvitationRequest>, IMessage, IEquatable<HavenBagInvitationRequest>, IDeepCloneable<HavenBagInvitationRequest>, IBufferMessage
{
	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagInvitationRequest> _parser;

	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E8A")]
	public const int GuestIdFieldNumber = 1;

	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x18")]
	private long guestId_;

	[Token(Token = "0x17000979")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagInvitationRequest> Parser
	{
		[Token(Token = "0x6002C42")]
		[Address(RVA = "0x9BEB30", Offset = "0x9BDF30", VA = "0x1809BEB30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700097A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002C43")]
		[Address(RVA = "0x9BEA80", Offset = "0x9BDE80", VA = "0x1809BEA80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700097B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002C44")]
		[Address(RVA = "0x9BEB80", Offset = "0x9BDF80", VA = "0x1809BEB80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700097C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long GuestId
	{
		[Token(Token = "0x6002C48")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002C49")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6002C45")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagInvitationRequest()
	{
	}

	[Token(Token = "0x6002C46")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagInvitationRequest(HavenBagInvitationRequest other)
	{
	}

	[Token(Token = "0x6002C47")]
	[Address(RVA = "0x9BE810", Offset = "0x9BDC10", VA = "0x1809BE810", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagInvitationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002C4A")]
	[Address(RVA = "0x9BE890", Offset = "0x9BDC90", VA = "0x1809BE890", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C4B")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagInvitationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C4C")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002C4D")]
	[Address(RVA = "0x9BE920", Offset = "0x9BDD20", VA = "0x1809BE920", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002C4E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002C4F")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002C50")]
	[Address(RVA = "0x9BE780", Offset = "0x9BDB80", VA = "0x1809BE780", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002C51")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagInvitationRequest other)
	{
	}

	[Token(Token = "0x6002C52")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002C53")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
