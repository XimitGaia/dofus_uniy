using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000394")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectFeedRequest : IMessage<ObjectFeedRequest>, IMessage, IEquatable<ObjectFeedRequest>, IDeepCloneable<ObjectFeedRequest>, IBufferMessage
{
	[Token(Token = "0x4000C59")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectFeedRequest> _parser;

	[Token(Token = "0x4000C5A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C5B")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000C5C")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4000C5D")]
	public const int MealFieldNumber = 2;

	[Token(Token = "0x4000C5E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectUidWithQuantity> _repeated_meal_codec;

	[Token(Token = "0x4000C5F")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<ObjectUidWithQuantity> meal_;

	[Token(Token = "0x170007FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectFeedRequest> Parser
	{
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x98FD00", Offset = "0x98F100", VA = "0x18098FD00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007FB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x98FC50", Offset = "0x98F050", VA = "0x18098FC50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007FC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002536")]
		[Address(RVA = "0x98FF50", Offset = "0x98F350", VA = "0x18098FF50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007FD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectUid
	{
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectUidWithQuantity> Meal
	{
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002537")]
	[Address(RVA = "0x98FBD0", Offset = "0x98EFD0", VA = "0x18098FBD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectFeedRequest()
	{
	}

	[Token(Token = "0x6002538")]
	[Address(RVA = "0x98FB40", Offset = "0x98EF40", VA = "0x18098FB40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectFeedRequest(ObjectFeedRequest other)
	{
	}

	[Token(Token = "0x6002539")]
	[Address(RVA = "0x98F670", Offset = "0x98EA70", VA = "0x18098F670", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectFeedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600253D")]
	[Address(RVA = "0x98F730", Offset = "0x98EB30", VA = "0x18098F730", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600253E")]
	[Address(RVA = "0x98F810", Offset = "0x98EC10", VA = "0x18098F810", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectFeedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600253F")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002540")]
	[Address(RVA = "0x98F940", Offset = "0x98ED40", VA = "0x18098F940", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002541")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002542")]
	[Address(RVA = "0x98FE80", Offset = "0x98F280", VA = "0x18098FE80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002543")]
	[Address(RVA = "0x98F590", Offset = "0x98E990", VA = "0x18098F590", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002544")]
	[Address(RVA = "0x98F8B0", Offset = "0x98ECB0", VA = "0x18098F8B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectFeedRequest other)
	{
	}

	[Token(Token = "0x6002545")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002546")]
	[Address(RVA = "0x98FD50", Offset = "0x98F150", VA = "0x18098FD50", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
