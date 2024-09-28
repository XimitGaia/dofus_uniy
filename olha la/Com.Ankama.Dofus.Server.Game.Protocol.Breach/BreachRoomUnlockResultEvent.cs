using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008FD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachRoomUnlockResultEvent : IMessage<BreachRoomUnlockResultEvent>, IMessage, IEquatable<BreachRoomUnlockResultEvent>, IDeepCloneable<BreachRoomUnlockResultEvent>, IBufferMessage
{
	[Token(Token = "0x20008FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20008FF")]
		public enum BreachRoomUnlockResult
		{
			[Token(Token = "0x4001ECC")]
			[OriginalName("SUCCESS")]
			Success,
			[Token(Token = "0x4001ECD")]
			[OriginalName("FAIL_NOT_ENOUGH_BUDGET")]
			FailNotEnoughBudget
		}
	}

	[Token(Token = "0x4001EC5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachRoomUnlockResultEvent> _parser;

	[Token(Token = "0x4001EC6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EC7")]
	public const int RoomIdFieldNumber = 1;

	[Token(Token = "0x4001EC8")]
	[FieldOffset(Offset = "0x18")]
	private int roomId_;

	[Token(Token = "0x4001EC9")]
	public const int ResultFieldNumber = 2;

	[Token(Token = "0x4001ECA")]
	[FieldOffset(Offset = "0x1C")]
	private Types.BreachRoomUnlockResult result_;

	[Token(Token = "0x17001421")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachRoomUnlockResultEvent> Parser
	{
		[Token(Token = "0x6005F1B")]
		[Address(RVA = "0xB568E0", Offset = "0xB55CE0", VA = "0x180B568E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001422")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005F1C")]
		[Address(RVA = "0xB56830", Offset = "0xB55C30", VA = "0x180B56830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001423")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005F1D")]
		[Address(RVA = "0xB56930", Offset = "0xB55D30", VA = "0x180B56930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001424")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RoomId
	{
		[Token(Token = "0x6005F21")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005F22")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001425")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.BreachRoomUnlockResult Result
	{
		[Token(Token = "0x6005F23")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.BreachRoomUnlockResult);
		}
		[Token(Token = "0x6005F24")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6005F1E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRoomUnlockResultEvent()
	{
	}

	[Token(Token = "0x6005F1F")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRoomUnlockResultEvent(BreachRoomUnlockResultEvent other)
	{
	}

	[Token(Token = "0x6005F20")]
	[Address(RVA = "0xB565B0", Offset = "0xB559B0", VA = "0x180B565B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRoomUnlockResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005F25")]
	[Address(RVA = "0xB56640", Offset = "0xB55A40", VA = "0x180B56640", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F26")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachRoomUnlockResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F27")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005F28")]
	[Address(RVA = "0xB566D0", Offset = "0xB55AD0", VA = "0x180B566D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005F29")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005F2A")]
	[Address(RVA = "0xA25CC0", Offset = "0xA250C0", VA = "0x180A25CC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005F2B")]
	[Address(RVA = "0xB564F0", Offset = "0xB558F0", VA = "0x180B564F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005F2C")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachRoomUnlockResultEvent other)
	{
	}

	[Token(Token = "0x6005F2D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005F2E")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
