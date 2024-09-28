using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007C8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContactLookErrorEvent : IMessage<ContactLookErrorEvent>, IMessage, IEquatable<ContactLookErrorEvent>, IDeepCloneable<ContactLookErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4001AFE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContactLookErrorEvent> _parser;

	[Token(Token = "0x4001AFF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B00")]
	public const int RequestIdFieldNumber = 1;

	[Token(Token = "0x4001B01")]
	[FieldOffset(Offset = "0x18")]
	private int requestId_;

	[Token(Token = "0x170011A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContactLookErrorEvent> Parser
	{
		[Token(Token = "0x60052BA")]
		[Address(RVA = "0xAEA700", Offset = "0xAE9B00", VA = "0x180AEA700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60052BB")]
		[Address(RVA = "0xAEA650", Offset = "0xAE9A50", VA = "0x180AEA650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011A3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60052BC")]
		[Address(RVA = "0xAEA750", Offset = "0xAE9B50", VA = "0x180AEA750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011A4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RequestId
	{
		[Token(Token = "0x60052C0")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60052C1")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60052BD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLookErrorEvent()
	{
	}

	[Token(Token = "0x60052BE")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLookErrorEvent(ContactLookErrorEvent other)
	{
	}

	[Token(Token = "0x60052BF")]
	[Address(RVA = "0xAEA3E0", Offset = "0xAE97E0", VA = "0x180AEA3E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContactLookErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60052C2")]
	[Address(RVA = "0xAEA460", Offset = "0xAE9860", VA = "0x180AEA460", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60052C3")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContactLookErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60052C4")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60052C5")]
	[Address(RVA = "0xAEA4F0", Offset = "0xAE98F0", VA = "0x180AEA4F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60052C6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60052C7")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60052C8")]
	[Address(RVA = "0xAEA350", Offset = "0xAE9750", VA = "0x180AEA350", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60052C9")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ContactLookErrorEvent other)
	{
	}

	[Token(Token = "0x60052CA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60052CB")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
