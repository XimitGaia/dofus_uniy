using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008EB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachRoomUnlockRequest : IMessage<BreachRoomUnlockRequest>, IMessage, IEquatable<BreachRoomUnlockRequest>, IDeepCloneable<BreachRoomUnlockRequest>, IBufferMessage
{
	[Token(Token = "0x4001E9B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachRoomUnlockRequest> _parser;

	[Token(Token = "0x4001E9C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E9D")]
	public const int RoomIdFieldNumber = 1;

	[Token(Token = "0x4001E9E")]
	[FieldOffset(Offset = "0x18")]
	private int roomId_;

	[Token(Token = "0x170013FF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachRoomUnlockRequest> Parser
	{
		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0xB563C0", Offset = "0xB557C0", VA = "0x180B563C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001400")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005E5B")]
		[Address(RVA = "0xB56310", Offset = "0xB55710", VA = "0x180B56310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001401")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005E5C")]
		[Address(RVA = "0xB56410", Offset = "0xB55810", VA = "0x180B56410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001402")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RoomId
	{
		[Token(Token = "0x6005E60")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005E61")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005E5D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachRoomUnlockRequest()
	{
	}

	[Token(Token = "0x6005E5E")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRoomUnlockRequest(BreachRoomUnlockRequest other)
	{
	}

	[Token(Token = "0x6005E5F")]
	[Address(RVA = "0xB560A0", Offset = "0xB554A0", VA = "0x180B560A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachRoomUnlockRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005E62")]
	[Address(RVA = "0xB56120", Offset = "0xB55520", VA = "0x180B56120", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E63")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BreachRoomUnlockRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E64")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005E65")]
	[Address(RVA = "0xB561B0", Offset = "0xB555B0", VA = "0x180B561B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005E66")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005E67")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005E68")]
	[Address(RVA = "0xB56010", Offset = "0xB55410", VA = "0x180B56010", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005E69")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachRoomUnlockRequest other)
	{
	}

	[Token(Token = "0x6005E6A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005E6B")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
