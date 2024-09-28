using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200028C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyMemberRemoveEvent : IMessage<PartyMemberRemoveEvent>, IMessage, IEquatable<PartyMemberRemoveEvent>, IDeepCloneable<PartyMemberRemoveEvent>, IBufferMessage
{
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyMemberRemoveEvent> _parser;

	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40008D5")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x1C")]
	private int partyId_;

	[Token(Token = "0x40008D7")]
	public const int LeavingPlayerIdFieldNumber = 2;

	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x20")]
	private long leavingPlayerId_;

	[Token(Token = "0x40008D9")]
	public const int KickerIdFieldNumber = 3;

	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x8")]
	private static readonly long KickerIdDefaultValue;

	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x28")]
	private long kickerId_;

	[Token(Token = "0x170005A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyMemberRemoveEvent> Parser
	{
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0xD14630", Offset = "0xD13A30", VA = "0x180D14630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0xD14510", Offset = "0xD13910", VA = "0x180D14510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0xD14770", Offset = "0xD13B70", VA = "0x180D14770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170005A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LeavingPlayerId
	{
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170005A5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long KickerId
	{
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0xD145C0", Offset = "0xD139C0", VA = "0x180D145C0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x960DE0", Offset = "0x9601E0", VA = "0x180960DE0")]
		set
		{
		}
	}

	[Token(Token = "0x170005A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasKickerId
	{
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberRemoveEvent()
	{
	}

	[Token(Token = "0x6001A44")]
	[Address(RVA = "0xA3BF60", Offset = "0xA3B360", VA = "0x180A3BF60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberRemoveEvent(PartyMemberRemoveEvent other)
	{
	}

	[Token(Token = "0x6001A45")]
	[Address(RVA = "0xD14030", Offset = "0xD13430", VA = "0x180D14030", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyMemberRemoveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearKickerId()
	{
	}

	[Token(Token = "0x6001A4E")]
	[Address(RVA = "0xD140D0", Offset = "0xD134D0", VA = "0x180D140D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0xD141A0", Offset = "0xD135A0", VA = "0x180D141A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyMemberRemoveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A50")]
	[Address(RVA = "0xD14230", Offset = "0xD13630", VA = "0x180D14230", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001A51")]
	[Address(RVA = "0xD143A0", Offset = "0xD137A0", VA = "0x180D143A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001A53")]
	[Address(RVA = "0xD14680", Offset = "0xD13A80", VA = "0x180D14680", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001A54")]
	[Address(RVA = "0xD13EF0", Offset = "0xD132F0", VA = "0x180D13EF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001A55")]
	[Address(RVA = "0xD14330", Offset = "0xD13730", VA = "0x180D14330", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyMemberRemoveEvent other)
	{
	}

	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001A57")]
	[Address(RVA = "0xCBB8F0", Offset = "0xCBACF0", VA = "0x180CBB8F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
