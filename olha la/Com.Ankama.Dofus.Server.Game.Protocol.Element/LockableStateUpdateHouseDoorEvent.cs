using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element;

[Token(Token = "0x2000756")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LockableStateUpdateHouseDoorEvent : IMessage<LockableStateUpdateHouseDoorEvent>, IMessage, IEquatable<LockableStateUpdateHouseDoorEvent>, IDeepCloneable<LockableStateUpdateHouseDoorEvent>, IBufferMessage
{
	[Token(Token = "0x40019C3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LockableStateUpdateHouseDoorEvent> _parser;

	[Token(Token = "0x40019C4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019C5")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x40019C6")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x40019C7")]
	public const int HouseInstanceIdFieldNumber = 2;

	[Token(Token = "0x40019C8")]
	[FieldOffset(Offset = "0x1C")]
	private int houseInstanceId_;

	[Token(Token = "0x40019C9")]
	public const int SecondHandFieldNumber = 3;

	[Token(Token = "0x40019CA")]
	[FieldOffset(Offset = "0x20")]
	private bool secondHand_;

	[Token(Token = "0x40019CB")]
	public const int LockedFieldNumber = 4;

	[Token(Token = "0x40019CC")]
	[FieldOffset(Offset = "0x21")]
	private bool locked_;

	[Token(Token = "0x170010D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LockableStateUpdateHouseDoorEvent> Parser
	{
		[Token(Token = "0x6004E8E")]
		[Address(RVA = "0xAC2D60", Offset = "0xAC2160", VA = "0x180AC2D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010D1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004E8F")]
		[Address(RVA = "0xAC2CB0", Offset = "0xAC20B0", VA = "0x180AC2CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010D2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004E90")]
		[Address(RVA = "0xAC2F70", Offset = "0xAC2370", VA = "0x180AC2F70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseId
	{
		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170010D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseInstanceId
	{
		[Token(Token = "0x6004E96")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004E97")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170010D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool SecondHand
	{
		[Token(Token = "0x6004E98")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004E99")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x170010D6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Locked
	{
		[Token(Token = "0x6004E9A")]
		[Address(RVA = "0x911F20", Offset = "0x911320", VA = "0x180911F20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004E9B")]
		[Address(RVA = "0x99BC90", Offset = "0x99B090", VA = "0x18099BC90")]
		set
		{
		}
	}

	[Token(Token = "0x6004E91")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LockableStateUpdateHouseDoorEvent()
	{
	}

	[Token(Token = "0x6004E92")]
	[Address(RVA = "0xAC2C50", Offset = "0xAC2050", VA = "0x180AC2C50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableStateUpdateHouseDoorEvent(LockableStateUpdateHouseDoorEvent other)
	{
	}

	[Token(Token = "0x6004E93")]
	[Address(RVA = "0xAC27E0", Offset = "0xAC1BE0", VA = "0x180AC27E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LockableStateUpdateHouseDoorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004E9C")]
	[Address(RVA = "0xAC2870", Offset = "0xAC1C70", VA = "0x180AC2870", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E9D")]
	[Address(RVA = "0xAC2920", Offset = "0xAC1D20", VA = "0x180AC2920", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LockableStateUpdateHouseDoorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E9E")]
	[Address(RVA = "0xAC2970", Offset = "0xAC1D70", VA = "0x180AC2970", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004E9F")]
	[Address(RVA = "0xAC2AF0", Offset = "0xAC1EF0", VA = "0x180AC2AF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004EA0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004EA1")]
	[Address(RVA = "0xAC2EB0", Offset = "0xAC22B0", VA = "0x180AC2EB0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004EA2")]
	[Address(RVA = "0xAC2710", Offset = "0xAC1B10", VA = "0x180AC2710", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004EA3")]
	[Address(RVA = "0xAC2A80", Offset = "0xAC1E80", VA = "0x180AC2A80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LockableStateUpdateHouseDoorEvent other)
	{
	}

	[Token(Token = "0x6004EA4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004EA5")]
	[Address(RVA = "0xAC2DB0", Offset = "0xAC21B0", VA = "0x180AC2DB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
