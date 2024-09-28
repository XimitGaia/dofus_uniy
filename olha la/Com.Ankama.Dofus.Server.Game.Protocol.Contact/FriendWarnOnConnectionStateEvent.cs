using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007D2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendWarnOnConnectionStateEvent : IMessage<FriendWarnOnConnectionStateEvent>, IMessage, IEquatable<FriendWarnOnConnectionStateEvent>, IDeepCloneable<FriendWarnOnConnectionStateEvent>, IBufferMessage
{
	[Token(Token = "0x4001B19")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendWarnOnConnectionStateEvent> _parser;

	[Token(Token = "0x4001B1A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B1B")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4001B1C")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x170011B6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendWarnOnConnectionStateEvent> Parser
	{
		[Token(Token = "0x600532A")]
		[Address(RVA = "0xAF22C0", Offset = "0xAF16C0", VA = "0x180AF22C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600532B")]
		[Address(RVA = "0xAF2210", Offset = "0xAF1610", VA = "0x180AF2210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600532C")]
		[Address(RVA = "0xAF2310", Offset = "0xAF1710", VA = "0x180AF2310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011B9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x6005330")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005331")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x600532D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendWarnOnConnectionStateEvent()
	{
	}

	[Token(Token = "0x600532E")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendWarnOnConnectionStateEvent(FriendWarnOnConnectionStateEvent other)
	{
	}

	[Token(Token = "0x600532F")]
	[Address(RVA = "0xAF1F00", Offset = "0xAF1300", VA = "0x180AF1F00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendWarnOnConnectionStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005332")]
	[Address(RVA = "0xAF1F80", Offset = "0xAF1380", VA = "0x180AF1F80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005333")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendWarnOnConnectionStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005334")]
	[Address(RVA = "0xAF2010", Offset = "0xAF1410", VA = "0x180AF2010", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005335")]
	[Address(RVA = "0xAF20B0", Offset = "0xAF14B0", VA = "0x180AF20B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005336")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005337")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005338")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005339")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendWarnOnConnectionStateEvent other)
	{
	}

	[Token(Token = "0x600533A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600533B")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
