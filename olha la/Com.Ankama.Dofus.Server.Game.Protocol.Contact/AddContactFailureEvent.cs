using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007FC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddContactFailureEvent : IMessage<AddContactFailureEvent>, IMessage, IEquatable<AddContactFailureEvent>, IDeepCloneable<AddContactFailureEvent>, IBufferMessage
{
	[Token(Token = "0x4001B83")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AddContactFailureEvent> _parser;

	[Token(Token = "0x4001B84")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B85")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4001B86")]
	[FieldOffset(Offset = "0x18")]
	private AddFailureReason reason_;

	[Token(Token = "0x17001200")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AddContactFailureEvent> Parser
	{
		[Token(Token = "0x60054AB")]
		[Address(RVA = "0xAE5E90", Offset = "0xAE5290", VA = "0x180AE5E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001201")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60054AC")]
		[Address(RVA = "0xAE5DE0", Offset = "0xAE51E0", VA = "0x180AE5DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001202")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60054AD")]
		[Address(RVA = "0xAE5EE0", Offset = "0xAE52E0", VA = "0x180AE5EE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001203")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AddFailureReason Reason
	{
		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(AddFailureReason);
		}
		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60054AE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddContactFailureEvent()
	{
	}

	[Token(Token = "0x60054AF")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddContactFailureEvent(AddContactFailureEvent other)
	{
	}

	[Token(Token = "0x60054B0")]
	[Address(RVA = "0xAE5B70", Offset = "0xAE4F70", VA = "0x180AE5B70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AddContactFailureEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60054B3")]
	[Address(RVA = "0xAE5BF0", Offset = "0xAE4FF0", VA = "0x180AE5BF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60054B4")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AddContactFailureEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60054B5")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60054B6")]
	[Address(RVA = "0xAE5C80", Offset = "0xAE5080", VA = "0x180AE5C80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60054B7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60054B8")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60054B9")]
	[Address(RVA = "0xAE5AE0", Offset = "0xAE4EE0", VA = "0x180AE5AE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60054BA")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AddContactFailureEvent other)
	{
	}

	[Token(Token = "0x60054BB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60054BC")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
