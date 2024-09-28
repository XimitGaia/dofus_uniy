using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x20002A2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyNameSetErrorEvent : IMessage<PartyNameSetErrorEvent>, IMessage, IEquatable<PartyNameSetErrorEvent>, IDeepCloneable<PartyNameSetErrorEvent>, IBufferMessage
{
	[Token(Token = "0x20002A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20002A4")]
		public enum PartyNameError
		{
			[Token(Token = "0x4000944")]
			[OriginalName("UNDEFINED_ERROR")]
			UndefinedError,
			[Token(Token = "0x4000945")]
			[OriginalName("INVALID")]
			Invalid,
			[Token(Token = "0x4000946")]
			[OriginalName("ALREADY_USED")]
			AlreadyUsed,
			[Token(Token = "0x4000947")]
			[OriginalName("UNALLOWED_RIGHTS")]
			UnallowedRights,
			[Token(Token = "0x4000948")]
			[OriginalName("UNALLOWED_NOW")]
			UnallowedNow
		}
	}

	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyNameSetErrorEvent> _parser;

	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400093F")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000941")]
	public const int ResultFieldNumber = 2;

	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x1C")]
	private Types.PartyNameError result_;

	[Token(Token = "0x170005E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyNameSetErrorEvent> Parser
	{
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0xD16050", Offset = "0xD15450", VA = "0x180D16050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0xD15FA0", Offset = "0xD153A0", VA = "0x180D15FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0xD160A0", Offset = "0xD154A0", VA = "0x180D160A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.PartyNameError Result
	{
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.PartyNameError);
		}
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6001B69")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyNameSetErrorEvent()
	{
	}

	[Token(Token = "0x6001B6A")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyNameSetErrorEvent(PartyNameSetErrorEvent other)
	{
	}

	[Token(Token = "0x6001B6B")]
	[Address(RVA = "0xD15D20", Offset = "0xD15120", VA = "0x180D15D20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyNameSetErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001B70")]
	[Address(RVA = "0xD15DB0", Offset = "0xD151B0", VA = "0x180D15DB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B71")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyNameSetErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001B73")]
	[Address(RVA = "0xD15E40", Offset = "0xD15240", VA = "0x180D15E40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001B74")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001B75")]
	[Address(RVA = "0xA25CC0", Offset = "0xA250C0", VA = "0x180A25CC0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001B76")]
	[Address(RVA = "0xD15C60", Offset = "0xD15060", VA = "0x180D15C60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001B77")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyNameSetErrorEvent other)
	{
	}

	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
