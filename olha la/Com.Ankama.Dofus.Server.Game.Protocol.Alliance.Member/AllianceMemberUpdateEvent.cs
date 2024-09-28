using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C9E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMemberUpdateEvent : IMessage<AllianceMemberUpdateEvent>, IMessage, IEquatable<AllianceMemberUpdateEvent>, IDeepCloneable<AllianceMemberUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4002E85")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMemberUpdateEvent> _parser;

	[Token(Token = "0x4002E86")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E87")]
	public const int MemberFieldNumber = 1;

	[Token(Token = "0x4002E88")]
	[FieldOffset(Offset = "0x18")]
	private AllianceMemberInformation member_;

	[Token(Token = "0x17001D14")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceMemberUpdateEvent> Parser
	{
		[Token(Token = "0x60084E3")]
		[Address(RVA = "0xC98100", Offset = "0xC97500", VA = "0x180C98100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D15")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60084E4")]
		[Address(RVA = "0xC98050", Offset = "0xC97450", VA = "0x180C98050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D16")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60084E5")]
		[Address(RVA = "0xC98250", Offset = "0xC97650", VA = "0x180C98250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D17")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberInformation Member
	{
		[Token(Token = "0x60084E9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084EA")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60084E6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberUpdateEvent()
	{
	}

	[Token(Token = "0x60084E7")]
	[Address(RVA = "0xC97FE0", Offset = "0xC973E0", VA = "0x180C97FE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMemberUpdateEvent(AllianceMemberUpdateEvent other)
	{
	}

	[Token(Token = "0x60084E8")]
	[Address(RVA = "0xC97C60", Offset = "0xC97060", VA = "0x180C97C60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60084EB")]
	[Address(RVA = "0xC97D00", Offset = "0xC97100", VA = "0x180C97D00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60084EC")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceMemberUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60084ED")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60084EE")]
	[Address(RVA = "0xC97E80", Offset = "0xC97280", VA = "0x180C97E80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60084EF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60084F0")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60084F1")]
	[Address(RVA = "0xC97BD0", Offset = "0xC96FD0", VA = "0x180C97BD0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60084F2")]
	[Address(RVA = "0xC97DB0", Offset = "0xC971B0", VA = "0x180C97DB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceMemberUpdateEvent other)
	{
	}

	[Token(Token = "0x60084F3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60084F4")]
	[Address(RVA = "0xC98150", Offset = "0xC97550", VA = "0x180C98150", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
