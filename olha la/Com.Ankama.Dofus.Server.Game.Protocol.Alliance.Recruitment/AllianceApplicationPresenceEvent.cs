using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C76")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationPresenceEvent : IMessage<AllianceApplicationPresenceEvent>, IMessage, IEquatable<AllianceApplicationPresenceEvent>, IDeepCloneable<AllianceApplicationPresenceEvent>, IBufferMessage
{
	[Token(Token = "0x4002E11")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationPresenceEvent> _parser;

	[Token(Token = "0x4002E12")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E13")]
	public const int PresenceFieldNumber = 1;

	[Token(Token = "0x4002E14")]
	[FieldOffset(Offset = "0x18")]
	private bool presence_;

	[Token(Token = "0x17001CBE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationPresenceEvent> Parser
	{
		[Token(Token = "0x6008330")]
		[Address(RVA = "0xC726E0", Offset = "0xC71AE0", VA = "0x180C726E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CBF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008331")]
		[Address(RVA = "0xC72630", Offset = "0xC71A30", VA = "0x180C72630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008332")]
		[Address(RVA = "0xC72730", Offset = "0xC71B30", VA = "0x180C72730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CC1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Presence
	{
		[Token(Token = "0x6008336")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008337")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6008333")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationPresenceEvent()
	{
	}

	[Token(Token = "0x6008334")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationPresenceEvent(AllianceApplicationPresenceEvent other)
	{
	}

	[Token(Token = "0x6008335")]
	[Address(RVA = "0xC72320", Offset = "0xC71720", VA = "0x180C72320", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationPresenceEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008338")]
	[Address(RVA = "0xC723A0", Offset = "0xC717A0", VA = "0x180C723A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008339")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationPresenceEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600833A")]
	[Address(RVA = "0xC72430", Offset = "0xC71830", VA = "0x180C72430", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600833B")]
	[Address(RVA = "0xC724D0", Offset = "0xC718D0", VA = "0x180C724D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600833C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600833D")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600833E")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600833F")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceApplicationPresenceEvent other)
	{
	}

	[Token(Token = "0x6008340")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008341")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
