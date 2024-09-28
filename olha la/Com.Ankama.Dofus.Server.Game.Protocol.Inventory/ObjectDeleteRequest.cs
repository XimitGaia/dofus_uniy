using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x200038A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectDeleteRequest : IMessage<ObjectDeleteRequest>, IMessage, IEquatable<ObjectDeleteRequest>, IDeepCloneable<ObjectDeleteRequest>, IBufferMessage
{
	[Token(Token = "0x4000C3A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectDeleteRequest> _parser;

	[Token(Token = "0x4000C3B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C3C")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000C3D")]
	[FieldOffset(Offset = "0x18")]
	private ObjectUidWithQuantity object_;

	[Token(Token = "0x170007E3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectDeleteRequest> Parser
	{
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x98C710", Offset = "0x98BB10", VA = "0x18098C710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x98C660", Offset = "0x98BA60", VA = "0x18098C660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x98C860", Offset = "0x98BC60", VA = "0x18098C860", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUidWithQuantity Object
	{
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectDeleteRequest()
	{
	}

	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x98C5F0", Offset = "0x98B9F0", VA = "0x18098C5F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectDeleteRequest(ObjectDeleteRequest other)
	{
	}

	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x98C270", Offset = "0x98B670", VA = "0x18098C270", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectDeleteRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60024C8")]
	[Address(RVA = "0x98C310", Offset = "0x98B710", VA = "0x18098C310", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60024C9")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectDeleteRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60024CA")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60024CB")]
	[Address(RVA = "0x98C490", Offset = "0x98B890", VA = "0x18098C490", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60024CE")]
	[Address(RVA = "0x98C1E0", Offset = "0x98B5E0", VA = "0x18098C1E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60024CF")]
	[Address(RVA = "0x98C3C0", Offset = "0x98B7C0", VA = "0x18098C3C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectDeleteRequest other)
	{
	}

	[Token(Token = "0x60024D0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60024D1")]
	[Address(RVA = "0x98C760", Offset = "0x98BB60", VA = "0x18098C760", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
