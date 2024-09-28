using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C98")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceJoinedEvent : IMessage<AllianceJoinedEvent>, IMessage, IEquatable<AllianceJoinedEvent>, IDeepCloneable<AllianceJoinedEvent>, IBufferMessage
{
	[Token(Token = "0x4002E74")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceJoinedEvent> _parser;

	[Token(Token = "0x4002E75")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E76")]
	public const int AllianceInformationFieldNumber = 1;

	[Token(Token = "0x4002E77")]
	[FieldOffset(Offset = "0x18")]
	private AllianceInformation allianceInformation_;

	[Token(Token = "0x4002E78")]
	public const int RankIdFieldNumber = 2;

	[Token(Token = "0x4002E79")]
	[FieldOffset(Offset = "0x20")]
	private int rankId_;

	[Token(Token = "0x17001D07")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceJoinedEvent> Parser
	{
		[Token(Token = "0x600849F")]
		[Address(RVA = "0xC96200", Offset = "0xC95600", VA = "0x180C96200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60084A0")]
		[Address(RVA = "0xC96150", Offset = "0xC95550", VA = "0x180C96150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D09")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60084A1")]
		[Address(RVA = "0xC96370", Offset = "0xC95770", VA = "0x180C96370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D0A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation AllianceInformation
	{
		[Token(Token = "0x60084A5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084A6")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D0B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RankId
	{
		[Token(Token = "0x60084A7")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60084A8")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60084A2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceJoinedEvent()
	{
	}

	[Token(Token = "0x60084A3")]
	[Address(RVA = "0xB77FE0", Offset = "0xB773E0", VA = "0x180B77FE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceJoinedEvent(AllianceJoinedEvent other)
	{
	}

	[Token(Token = "0x60084A4")]
	[Address(RVA = "0xC95DC0", Offset = "0xC951C0", VA = "0x180C95DC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceJoinedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60084A9")]
	[Address(RVA = "0xC95E70", Offset = "0xC95270", VA = "0x180C95E70", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60084AA")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceJoinedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60084AB")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60084AC")]
	[Address(RVA = "0xC95FF0", Offset = "0xC953F0", VA = "0x180C95FF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60084AD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60084AE")]
	[Address(RVA = "0x9D2390", Offset = "0x9D1790", VA = "0x1809D2390", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60084AF")]
	[Address(RVA = "0xC95D00", Offset = "0xC95100", VA = "0x180C95D00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60084B0")]
	[Address(RVA = "0xC95F20", Offset = "0xC95320", VA = "0x180C95F20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceJoinedEvent other)
	{
	}

	[Token(Token = "0x60084B1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60084B2")]
	[Address(RVA = "0xC96250", Offset = "0xC95650", VA = "0x180C96250", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
