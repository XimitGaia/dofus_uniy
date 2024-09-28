using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200041B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagChangeRoomRequest : IMessage<HavenBagChangeRoomRequest>, IMessage, IEquatable<HavenBagChangeRoomRequest>, IDeepCloneable<HavenBagChangeRoomRequest>, IBufferMessage
{
	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagChangeRoomRequest> _parser;

	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E5C")]
	public const int RoomIdFieldNumber = 1;

	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x18")]
	private int roomId_;

	[Token(Token = "0x17000952")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagChangeRoomRequest> Parser
	{
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x9B8880", Offset = "0x9B7C80", VA = "0x1809B8880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000953")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x9B87D0", Offset = "0x9B7BD0", VA = "0x1809B87D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000954")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x9B88D0", Offset = "0x9B7CD0", VA = "0x1809B88D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000955")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RoomId
	{
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6002B5E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagChangeRoomRequest()
	{
	}

	[Token(Token = "0x6002B5F")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagChangeRoomRequest(HavenBagChangeRoomRequest other)
	{
	}

	[Token(Token = "0x6002B60")]
	[Address(RVA = "0x9B8560", Offset = "0x9B7960", VA = "0x1809B8560", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagChangeRoomRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002B63")]
	[Address(RVA = "0x9B85E0", Offset = "0x9B79E0", VA = "0x1809B85E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B64")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HavenBagChangeRoomRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B65")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002B66")]
	[Address(RVA = "0x9B8670", Offset = "0x9B7A70", VA = "0x1809B8670", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002B67")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002B68")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002B69")]
	[Address(RVA = "0x9B84D0", Offset = "0x9B78D0", VA = "0x1809B84D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002B6A")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagChangeRoomRequest other)
	{
	}

	[Token(Token = "0x6002B6B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002B6C")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
