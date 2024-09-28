using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007CE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendAddedEvent : IMessage<FriendAddedEvent>, IMessage, IEquatable<FriendAddedEvent>, IDeepCloneable<FriendAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4001B0D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendAddedEvent> _parser;

	[Token(Token = "0x4001B0E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B0F")]
	public const int FriendFieldNumber = 1;

	[Token(Token = "0x4001B10")]
	[FieldOffset(Offset = "0x18")]
	private FriendInformation friend_;

	[Token(Token = "0x170011AD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FriendAddedEvent> Parser
	{
		[Token(Token = "0x60052FC")]
		[Address(RVA = "0xAED9F0", Offset = "0xAECDF0", VA = "0x180AED9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60052FD")]
		[Address(RVA = "0xAED940", Offset = "0xAECD40", VA = "0x180AED940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011AF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60052FE")]
		[Address(RVA = "0xAEDB40", Offset = "0xAECF40", VA = "0x180AEDB40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendInformation Friend
	{
		[Token(Token = "0x6005302")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005303")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60052FF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddedEvent()
	{
	}

	[Token(Token = "0x6005300")]
	[Address(RVA = "0xAED880", Offset = "0xAECC80", VA = "0x180AED880")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddedEvent(FriendAddedEvent other)
	{
	}

	[Token(Token = "0x6005301")]
	[Address(RVA = "0xAED4B0", Offset = "0xAEC8B0", VA = "0x180AED4B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005304")]
	[Address(RVA = "0xAED5A0", Offset = "0xAEC9A0", VA = "0x180AED5A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005305")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FriendAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005306")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005307")]
	[Address(RVA = "0xAED720", Offset = "0xAECB20", VA = "0x180AED720", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005308")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005309")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600530A")]
	[Address(RVA = "0xAED420", Offset = "0xAEC820", VA = "0x180AED420", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600530B")]
	[Address(RVA = "0xAED650", Offset = "0xAECA50", VA = "0x180AED650", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendAddedEvent other)
	{
	}

	[Token(Token = "0x600530C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600530D")]
	[Address(RVA = "0xAEDA40", Offset = "0xAECE40", VA = "0x180AEDA40", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
