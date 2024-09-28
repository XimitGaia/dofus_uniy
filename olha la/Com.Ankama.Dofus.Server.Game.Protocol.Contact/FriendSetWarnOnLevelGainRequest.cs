using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007B0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendSetWarnOnLevelGainRequest : IMessage<FriendSetWarnOnLevelGainRequest>, IMessage, IEquatable<FriendSetWarnOnLevelGainRequest>, IDeepCloneable<FriendSetWarnOnLevelGainRequest>, IBufferMessage
{
	[Token(Token = "0x4001AC2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendSetWarnOnLevelGainRequest> _parser;

	[Token(Token = "0x4001AC3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001AC4")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4001AC5")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x17001171")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FriendSetWarnOnLevelGainRequest> Parser
	{
		[Token(Token = "0x60051B2")]
		[Address(RVA = "0xADECF0", Offset = "0xADE0F0", VA = "0x180ADECF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001172")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60051B3")]
		[Address(RVA = "0xADEC40", Offset = "0xADE040", VA = "0x180ADEC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001173")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60051B4")]
		[Address(RVA = "0xADED40", Offset = "0xADE140", VA = "0x180ADED40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001174")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x60051B8")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60051B9")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60051B5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendSetWarnOnLevelGainRequest()
	{
	}

	[Token(Token = "0x60051B6")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSetWarnOnLevelGainRequest(FriendSetWarnOnLevelGainRequest other)
	{
	}

	[Token(Token = "0x60051B7")]
	[Address(RVA = "0xADE930", Offset = "0xADDD30", VA = "0x180ADE930", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSetWarnOnLevelGainRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60051BA")]
	[Address(RVA = "0xADE9B0", Offset = "0xADDDB0", VA = "0x180ADE9B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60051BB")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendSetWarnOnLevelGainRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60051BC")]
	[Address(RVA = "0xADEA40", Offset = "0xADDE40", VA = "0x180ADEA40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60051BD")]
	[Address(RVA = "0xADEAE0", Offset = "0xADDEE0", VA = "0x180ADEAE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60051BE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60051BF")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60051C0")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60051C1")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendSetWarnOnLevelGainRequest other)
	{
	}

	[Token(Token = "0x60051C2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60051C3")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
