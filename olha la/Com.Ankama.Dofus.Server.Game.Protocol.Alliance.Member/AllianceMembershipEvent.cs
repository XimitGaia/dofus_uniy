using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C96")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMembershipEvent : IMessage<AllianceMembershipEvent>, IMessage, IEquatable<AllianceMembershipEvent>, IDeepCloneable<AllianceMembershipEvent>, IBufferMessage
{
	[Token(Token = "0x4002E6D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMembershipEvent> _parser;

	[Token(Token = "0x4002E6E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E6F")]
	public const int AllianceInformationFieldNumber = 1;

	[Token(Token = "0x4002E70")]
	[FieldOffset(Offset = "0x18")]
	private AllianceInformation allianceInformation_;

	[Token(Token = "0x4002E71")]
	public const int RankIdFieldNumber = 2;

	[Token(Token = "0x4002E72")]
	[FieldOffset(Offset = "0x20")]
	private int rankId_;

	[Token(Token = "0x17001D02")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceMembershipEvent> Parser
	{
		[Token(Token = "0x6008487")]
		[Address(RVA = "0xC98830", Offset = "0xC97C30", VA = "0x180C98830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D03")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008488")]
		[Address(RVA = "0xC98780", Offset = "0xC97B80", VA = "0x180C98780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D04")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008489")]
		[Address(RVA = "0xC989A0", Offset = "0xC97DA0", VA = "0x180C989A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D05")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation AllianceInformation
	{
		[Token(Token = "0x600848D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600848E")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D06")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankId
	{
		[Token(Token = "0x600848F")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008490")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600848A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMembershipEvent()
	{
	}

	[Token(Token = "0x600848B")]
	[Address(RVA = "0xB77FE0", Offset = "0xB773E0", VA = "0x180B77FE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMembershipEvent(AllianceMembershipEvent other)
	{
	}

	[Token(Token = "0x600848C")]
	[Address(RVA = "0xC983F0", Offset = "0xC977F0", VA = "0x180C983F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMembershipEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008491")]
	[Address(RVA = "0xC984A0", Offset = "0xC978A0", VA = "0x180C984A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008492")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceMembershipEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008493")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008494")]
	[Address(RVA = "0xC98620", Offset = "0xC97A20", VA = "0x180C98620", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008495")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008496")]
	[Address(RVA = "0x9D2390", Offset = "0x9D1790", VA = "0x1809D2390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008497")]
	[Address(RVA = "0xC98330", Offset = "0xC97730", VA = "0x180C98330", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008498")]
	[Address(RVA = "0xC98550", Offset = "0xC97950", VA = "0x180C98550", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceMembershipEvent other)
	{
	}

	[Token(Token = "0x6008499")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600849A")]
	[Address(RVA = "0xC98880", Offset = "0xC97C80", VA = "0x180C98880", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
