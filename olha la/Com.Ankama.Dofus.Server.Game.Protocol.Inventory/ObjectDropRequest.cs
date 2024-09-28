using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000388")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectDropRequest : IMessage<ObjectDropRequest>, IMessage, IEquatable<ObjectDropRequest>, IDeepCloneable<ObjectDropRequest>, IBufferMessage
{
	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectDropRequest> _parser;

	[Token(Token = "0x4000C36")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C37")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000C38")]
	[FieldOffset(Offset = "0x18")]
	private ObjectUidWithQuantity object_;

	[Token(Token = "0x170007DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectDropRequest> Parser
	{
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x98D2E0", Offset = "0x98C6E0", VA = "0x18098D2E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x98D230", Offset = "0x98C630", VA = "0x18098D230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x98D430", Offset = "0x98C830", VA = "0x18098D430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUidWithQuantity Object
	{
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60024AD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectDropRequest()
	{
	}

	[Token(Token = "0x60024AE")]
	[Address(RVA = "0x98C5F0", Offset = "0x98B9F0", VA = "0x18098C5F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectDropRequest(ObjectDropRequest other)
	{
	}

	[Token(Token = "0x60024AF")]
	[Address(RVA = "0x98CEB0", Offset = "0x98C2B0", VA = "0x18098CEB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectDropRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60024B2")]
	[Address(RVA = "0x98CF50", Offset = "0x98C350", VA = "0x18098CF50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectDropRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60024B5")]
	[Address(RVA = "0x98D0D0", Offset = "0x98C4D0", VA = "0x18098D0D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60024B6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60024B7")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x98CE20", Offset = "0x98C220", VA = "0x18098CE20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x98D000", Offset = "0x98C400", VA = "0x18098D000", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectDropRequest other)
	{
	}

	[Token(Token = "0x60024BA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60024BB")]
	[Address(RVA = "0x98D330", Offset = "0x98C730", VA = "0x18098D330", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
