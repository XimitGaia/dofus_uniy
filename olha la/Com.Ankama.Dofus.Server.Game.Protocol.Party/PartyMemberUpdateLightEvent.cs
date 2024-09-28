using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200028A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyMemberUpdateLightEvent : IMessage<PartyMemberUpdateLightEvent>, IMessage, IEquatable<PartyMemberUpdateLightEvent>, IDeepCloneable<PartyMemberUpdateLightEvent>, IBufferMessage
{
	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyMemberUpdateLightEvent> _parser;

	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40008C8")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x1C")]
	private int partyId_;

	[Token(Token = "0x40008CA")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x40008CC")]
	public const int CommonsInformationFieldNumber = 3;

	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x28")]
	private PartyUpdateCommonsInformation commonsInformation_;

	[Token(Token = "0x40008CE")]
	public const int IndexFieldNumber = 4;

	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int IndexDefaultValue;

	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x30")]
	private int index_;

	[Token(Token = "0x17000598")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyMemberUpdateLightEvent> Parser
	{
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0xD158D0", Offset = "0xD14CD0", VA = "0x180D158D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000599")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001A23")]
		[Address(RVA = "0xD157B0", Offset = "0xD14BB0", VA = "0x180D157B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0xD15B80", Offset = "0xD14F80", VA = "0x180D15B80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700059C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700059D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyUpdateCommonsInformation CommonsInformation
	{
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x1700059E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Index
	{
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0xD15860", Offset = "0xD14C60", VA = "0x180D15860")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0xA4D370", Offset = "0xA4C770", VA = "0x180A4D370")]
		set
		{
		}
	}

	[Token(Token = "0x1700059F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasIndex
	{
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001A25")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberUpdateLightEvent()
	{
	}

	[Token(Token = "0x6001A26")]
	[Address(RVA = "0xD15720", Offset = "0xD14B20", VA = "0x180D15720")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyMemberUpdateLightEvent(PartyMemberUpdateLightEvent other)
	{
	}

	[Token(Token = "0x6001A27")]
	[Address(RVA = "0xD15160", Offset = "0xD14560", VA = "0x180D15160", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyMemberUpdateLightEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001A31")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearIndex()
	{
	}

	[Token(Token = "0x6001A32")]
	[Address(RVA = "0xD15220", Offset = "0xD14620", VA = "0x180D15220", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A33")]
	[Address(RVA = "0xD15300", Offset = "0xD14700", VA = "0x180D15300", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyMemberUpdateLightEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A34")]
	[Address(RVA = "0xD153A0", Offset = "0xD147A0", VA = "0x180D153A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001A35")]
	[Address(RVA = "0xD155B0", Offset = "0xD149B0", VA = "0x180D155B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001A37")]
	[Address(RVA = "0xD15A70", Offset = "0xD14E70", VA = "0x180D15A70", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001A38")]
	[Address(RVA = "0xD15000", Offset = "0xD14400", VA = "0x180D15000", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001A39")]
	[Address(RVA = "0xD154B0", Offset = "0xD148B0", VA = "0x180D154B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyMemberUpdateLightEvent other)
	{
	}

	[Token(Token = "0x6001A3A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0xD15920", Offset = "0xD14D20", VA = "0x180D15920", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
