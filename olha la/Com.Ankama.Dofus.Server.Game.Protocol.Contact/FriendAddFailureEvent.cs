using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007CA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendAddFailureEvent : IMessage<FriendAddFailureEvent>, IMessage, IEquatable<FriendAddFailureEvent>, IDeepCloneable<FriendAddFailureEvent>, IBufferMessage
{
	[Token(Token = "0x4001B03")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendAddFailureEvent> _parser;

	[Token(Token = "0x4001B04")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B05")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4001B06")]
	[FieldOffset(Offset = "0x18")]
	private AddFailureReason reason_;

	[Token(Token = "0x170011A5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FriendAddFailureEvent> Parser
	{
		[Token(Token = "0x60052D0")]
		[Address(RVA = "0xAED2F0", Offset = "0xAEC6F0", VA = "0x180AED2F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60052D1")]
		[Address(RVA = "0xAED240", Offset = "0xAEC640", VA = "0x180AED240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011A7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60052D2")]
		[Address(RVA = "0xAED340", Offset = "0xAEC740", VA = "0x180AED340", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AddFailureReason Reason
	{
		[Token(Token = "0x60052D6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(AddFailureReason);
		}
		[Token(Token = "0x60052D7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60052D3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddFailureEvent()
	{
	}

	[Token(Token = "0x60052D4")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddFailureEvent(FriendAddFailureEvent other)
	{
	}

	[Token(Token = "0x60052D5")]
	[Address(RVA = "0xAECFD0", Offset = "0xAEC3D0", VA = "0x180AECFD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddFailureEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60052D8")]
	[Address(RVA = "0xAED050", Offset = "0xAEC450", VA = "0x180AED050", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60052D9")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendAddFailureEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60052DA")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60052DB")]
	[Address(RVA = "0xAED0E0", Offset = "0xAEC4E0", VA = "0x180AED0E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60052DC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60052DD")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60052DE")]
	[Address(RVA = "0xAECF40", Offset = "0xAEC340", VA = "0x180AECF40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60052DF")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendAddFailureEvent other)
	{
	}

	[Token(Token = "0x60052E0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60052E1")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
