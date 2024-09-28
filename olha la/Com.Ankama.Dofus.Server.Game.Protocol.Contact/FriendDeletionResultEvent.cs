using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007D0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendDeletionResultEvent : IMessage<FriendDeletionResultEvent>, IMessage, IEquatable<FriendDeletionResultEvent>, IDeepCloneable<FriendDeletionResultEvent>, IBufferMessage
{
	[Token(Token = "0x4001B12")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendDeletionResultEvent> _parser;

	[Token(Token = "0x4001B13")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B14")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4001B15")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x4001B16")]
	public const int AccountTagFieldNumber = 2;

	[Token(Token = "0x4001B17")]
	[FieldOffset(Offset = "0x20")]
	private AccountTag accountTag_;

	[Token(Token = "0x170011B1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendDeletionResultEvent> Parser
	{
		[Token(Token = "0x6005312")]
		[Address(RVA = "0xAEE230", Offset = "0xAED630", VA = "0x180AEE230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005313")]
		[Address(RVA = "0xAEE180", Offset = "0xAED580", VA = "0x180AEE180")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005314")]
		[Address(RVA = "0xAEE3B0", Offset = "0xAED7B0", VA = "0x180AEE3B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011B4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6005318")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005319")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x170011B5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AccountTag AccountTag
	{
		[Token(Token = "0x600531A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600531B")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6005315")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendDeletionResultEvent()
	{
	}

	[Token(Token = "0x6005316")]
	[Address(RVA = "0xAEE110", Offset = "0xAED510", VA = "0x180AEE110")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendDeletionResultEvent(FriendDeletionResultEvent other)
	{
	}

	[Token(Token = "0x6005317")]
	[Address(RVA = "0xAEDCC0", Offset = "0xAED0C0", VA = "0x180AEDCC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendDeletionResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600531C")]
	[Address(RVA = "0xAEDD60", Offset = "0xAED160", VA = "0x180AEDD60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600531D")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendDeletionResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600531E")]
	[Address(RVA = "0xAEDE10", Offset = "0xAED210", VA = "0x180AEDE10", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600531F")]
	[Address(RVA = "0xAEDFB0", Offset = "0xAED3B0", VA = "0x180AEDFB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005320")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005321")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005322")]
	[Address(RVA = "0xAEDC20", Offset = "0xAED020", VA = "0x180AEDC20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005323")]
	[Address(RVA = "0xAEDED0", Offset = "0xAED2D0", VA = "0x180AEDED0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendDeletionResultEvent other)
	{
	}

	[Token(Token = "0x6005324")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005325")]
	[Address(RVA = "0xAEE280", Offset = "0xAED680", VA = "0x180AEE280", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
