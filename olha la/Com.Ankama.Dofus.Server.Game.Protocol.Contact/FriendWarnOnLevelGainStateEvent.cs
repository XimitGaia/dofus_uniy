using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007D6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendWarnOnLevelGainStateEvent : IMessage<FriendWarnOnLevelGainStateEvent>, IMessage, IEquatable<FriendWarnOnLevelGainStateEvent>, IDeepCloneable<FriendWarnOnLevelGainStateEvent>, IBufferMessage
{
	[Token(Token = "0x4001B23")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendWarnOnLevelGainStateEvent> _parser;

	[Token(Token = "0x4001B24")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B25")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4001B26")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x170011BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendWarnOnLevelGainStateEvent> Parser
	{
		[Token(Token = "0x6005356")]
		[Address(RVA = "0xAF27B0", Offset = "0xAF1BB0", VA = "0x180AF27B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005357")]
		[Address(RVA = "0xAF2700", Offset = "0xAF1B00", VA = "0x180AF2700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005358")]
		[Address(RVA = "0xAF2800", Offset = "0xAF1C00", VA = "0x180AF2800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x600535C")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600535D")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6005359")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendWarnOnLevelGainStateEvent()
	{
	}

	[Token(Token = "0x600535A")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendWarnOnLevelGainStateEvent(FriendWarnOnLevelGainStateEvent other)
	{
	}

	[Token(Token = "0x600535B")]
	[Address(RVA = "0xAF23F0", Offset = "0xAF17F0", VA = "0x180AF23F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendWarnOnLevelGainStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600535E")]
	[Address(RVA = "0xAF2470", Offset = "0xAF1870", VA = "0x180AF2470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600535F")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendWarnOnLevelGainStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005360")]
	[Address(RVA = "0xAF2500", Offset = "0xAF1900", VA = "0x180AF2500", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005361")]
	[Address(RVA = "0xAF25A0", Offset = "0xAF19A0", VA = "0x180AF25A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005362")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005363")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005364")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005365")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FriendWarnOnLevelGainStateEvent other)
	{
	}

	[Token(Token = "0x6005366")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005367")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
