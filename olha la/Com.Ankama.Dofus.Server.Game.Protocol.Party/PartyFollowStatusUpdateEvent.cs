using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000290")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyFollowStatusUpdateEvent : IMessage<PartyFollowStatusUpdateEvent>, IMessage, IEquatable<PartyFollowStatusUpdateEvent>, IDeepCloneable<PartyFollowStatusUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyFollowStatusUpdateEvent> _parser;

	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008E6")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x40008E8")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x1C")]
	private bool success_;

	[Token(Token = "0x40008EA")]
	public const int IsFollowedFieldNumber = 3;

	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x1D")]
	private bool isFollowed_;

	[Token(Token = "0x40008EC")]
	public const int FollowedIdFieldNumber = 4;

	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x20")]
	private long followedId_;

	[Token(Token = "0x170005AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyFollowStatusUpdateEvent> Parser
	{
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0xD0F680", Offset = "0xD0EA80", VA = "0x180D0F680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0xD0F5C0", Offset = "0xD0E9C0", VA = "0x180D0F5C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0xD0F890", Offset = "0xD0EC90", VA = "0x180D0F890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x170005B1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsFollowed
	{
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0xD0F670", Offset = "0xD0EA70", VA = "0x180D0F670")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0xD0F970", Offset = "0xD0ED70", VA = "0x180D0F970")]
		set
		{
		}
	}

	[Token(Token = "0x170005B2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long FollowedId
	{
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001A77")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyFollowStatusUpdateEvent()
	{
	}

	[Token(Token = "0x6001A78")]
	[Address(RVA = "0xD0F550", Offset = "0xD0E950", VA = "0x180D0F550")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyFollowStatusUpdateEvent(PartyFollowStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6001A79")]
	[Address(RVA = "0xD0F0D0", Offset = "0xD0E4D0", VA = "0x180D0F0D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyFollowStatusUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001A82")]
	[Address(RVA = "0xD0F170", Offset = "0xD0E570", VA = "0x180D0F170", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A83")]
	[Address(RVA = "0xD0F220", Offset = "0xD0E620", VA = "0x180D0F220", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyFollowStatusUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A84")]
	[Address(RVA = "0xD0F270", Offset = "0xD0E670", VA = "0x180D0F270", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001A85")]
	[Address(RVA = "0xD0F3F0", Offset = "0xD0E7F0", VA = "0x180D0F3F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001A86")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001A87")]
	[Address(RVA = "0xD0F7D0", Offset = "0xD0EBD0", VA = "0x180D0F7D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001A88")]
	[Address(RVA = "0xD0F000", Offset = "0xD0E400", VA = "0x180D0F000", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001A89")]
	[Address(RVA = "0xD0F380", Offset = "0xD0E780", VA = "0x180D0F380", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyFollowStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0xD0F6D0", Offset = "0xD0EAD0", VA = "0x180D0F6D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
