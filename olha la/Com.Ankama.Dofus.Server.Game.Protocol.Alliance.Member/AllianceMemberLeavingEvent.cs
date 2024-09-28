using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C9A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMemberLeavingEvent : IMessage<AllianceMemberLeavingEvent>, IMessage, IEquatable<AllianceMemberLeavingEvent>, IDeepCloneable<AllianceMemberLeavingEvent>, IBufferMessage
{
	[Token(Token = "0x4002E7B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMemberLeavingEvent> _parser;

	[Token(Token = "0x4002E7C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E7D")]
	public const int KickedFieldNumber = 1;

	[Token(Token = "0x4002E7E")]
	[FieldOffset(Offset = "0x18")]
	private bool kicked_;

	[Token(Token = "0x4002E7F")]
	public const int MemberIdFieldNumber = 2;

	[Token(Token = "0x4002E80")]
	[FieldOffset(Offset = "0x20")]
	private long memberId_;

	[Token(Token = "0x17001D0C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceMemberLeavingEvent> Parser
	{
		[Token(Token = "0x60084B7")]
		[Address(RVA = "0xC97220", Offset = "0xC96620", VA = "0x180C97220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D0D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60084B8")]
		[Address(RVA = "0xC97170", Offset = "0xC96570", VA = "0x180C97170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D0E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60084B9")]
		[Address(RVA = "0xC97270", Offset = "0xC96670", VA = "0x180C97270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Kicked
	{
		[Token(Token = "0x60084BD")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60084BE")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001D10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MemberId
	{
		[Token(Token = "0x60084BF")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60084C0")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60084BA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMemberLeavingEvent()
	{
	}

	[Token(Token = "0x60084BB")]
	[Address(RVA = "0x9D42F0", Offset = "0x9D36F0", VA = "0x1809D42F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMemberLeavingEvent(AllianceMemberLeavingEvent other)
	{
	}

	[Token(Token = "0x60084BC")]
	[Address(RVA = "0xC96E10", Offset = "0xC96210", VA = "0x180C96E10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMemberLeavingEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60084C1")]
	[Address(RVA = "0xC96EA0", Offset = "0xC962A0", VA = "0x180C96EA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60084C2")]
	[Address(RVA = "0x9D3F80", Offset = "0x9D3380", VA = "0x1809D3F80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceMemberLeavingEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60084C3")]
	[Address(RVA = "0xC96F40", Offset = "0xC96340", VA = "0x180C96F40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60084C4")]
	[Address(RVA = "0xC97010", Offset = "0xC96410", VA = "0x180C97010", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60084C5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60084C6")]
	[Address(RVA = "0x9D4510", Offset = "0x9D3910", VA = "0x1809D4510", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60084C7")]
	[Address(RVA = "0xC96D70", Offset = "0xC96170", VA = "0x180C96D70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60084C8")]
	[Address(RVA = "0x9D4130", Offset = "0x9D3530", VA = "0x1809D4130", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceMemberLeavingEvent other)
	{
	}

	[Token(Token = "0x60084C9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60084CA")]
	[Address(RVA = "0x9D4450", Offset = "0x9D3850", VA = "0x1809D4450", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
