using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C90")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceInvitedEvent : IMessage<AllianceInvitedEvent>, IMessage, IEquatable<AllianceInvitedEvent>, IDeepCloneable<AllianceInvitedEvent>, IBufferMessage
{
	[Token(Token = "0x4002E5A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceInvitedEvent> _parser;

	[Token(Token = "0x4002E5B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E5C")]
	public const int RecruiterNameFieldNumber = 1;

	[Token(Token = "0x4002E5D")]
	[FieldOffset(Offset = "0x18")]
	private string recruiterName_;

	[Token(Token = "0x4002E5E")]
	public const int AllianceInformationFieldNumber = 2;

	[Token(Token = "0x4002E5F")]
	[FieldOffset(Offset = "0x20")]
	private AllianceInformation allianceInformation_;

	[Token(Token = "0x17001CF4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceInvitedEvent> Parser
	{
		[Token(Token = "0x6008441")]
		[Address(RVA = "0xC95A20", Offset = "0xC94E20", VA = "0x180C95A20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CF5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008442")]
		[Address(RVA = "0xC95970", Offset = "0xC94D70", VA = "0x180C95970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CF6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008443")]
		[Address(RVA = "0xC95BB0", Offset = "0xC94FB0", VA = "0x180C95BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CF7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RecruiterName
	{
		[Token(Token = "0x6008447")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008448")]
		[Address(RVA = "0xC95C90", Offset = "0xC95090", VA = "0x180C95C90")]
		set
		{
		}
	}

	[Token(Token = "0x17001CF8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation AllianceInformation
	{
		[Token(Token = "0x6008449")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600844A")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6008444")]
	[Address(RVA = "0xC95860", Offset = "0xC94C60", VA = "0x180C95860")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitedEvent()
	{
	}

	[Token(Token = "0x6008445")]
	[Address(RVA = "0xC958B0", Offset = "0xC94CB0", VA = "0x180C958B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitedEvent(AllianceInvitedEvent other)
	{
	}

	[Token(Token = "0x6008446")]
	[Address(RVA = "0xC95460", Offset = "0xC94860", VA = "0x180C95460", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600844B")]
	[Address(RVA = "0xC95550", Offset = "0xC94950", VA = "0x180C95550", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600844C")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceInvitedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600844D")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600844E")]
	[Address(RVA = "0xC95700", Offset = "0xC94B00", VA = "0x180C95700", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600844F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008450")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008451")]
	[Address(RVA = "0xC953A0", Offset = "0xC947A0", VA = "0x180C953A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008452")]
	[Address(RVA = "0xC95610", Offset = "0xC94A10", VA = "0x180C95610", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceInvitedEvent other)
	{
	}

	[Token(Token = "0x6008453")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008454")]
	[Address(RVA = "0xC95A70", Offset = "0xC94E70", VA = "0x180C95A70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
