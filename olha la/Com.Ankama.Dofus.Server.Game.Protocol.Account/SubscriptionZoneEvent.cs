using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account;

[Token(Token = "0x2000D46")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubscriptionZoneEvent : IMessage<SubscriptionZoneEvent>, IMessage, IEquatable<SubscriptionZoneEvent>, IDeepCloneable<SubscriptionZoneEvent>, IBufferMessage
{
	[Token(Token = "0x400309C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SubscriptionZoneEvent> _parser;

	[Token(Token = "0x400309D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400309E")]
	public const int EffectiveFieldNumber = 1;

	[Token(Token = "0x400309F")]
	[FieldOffset(Offset = "0x18")]
	private bool effective_;

	[Token(Token = "0x17001E77")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SubscriptionZoneEvent> Parser
	{
		[Token(Token = "0x6008BA3")]
		[Address(RVA = "0xCBCDD0", Offset = "0xCBC1D0", VA = "0x180CBCDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E78")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008BA4")]
		[Address(RVA = "0xCBCD20", Offset = "0xCBC120", VA = "0x180CBCD20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E79")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008BA5")]
		[Address(RVA = "0xCBCE20", Offset = "0xCBC220", VA = "0x180CBCE20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E7A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Effective
	{
		[Token(Token = "0x6008BA9")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008BAA")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6008BA6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscriptionZoneEvent()
	{
	}

	[Token(Token = "0x6008BA7")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscriptionZoneEvent(SubscriptionZoneEvent other)
	{
	}

	[Token(Token = "0x6008BA8")]
	[Address(RVA = "0xCBCA10", Offset = "0xCBBE10", VA = "0x180CBCA10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscriptionZoneEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008BAB")]
	[Address(RVA = "0xCBCA90", Offset = "0xCBBE90", VA = "0x180CBCA90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008BAC")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SubscriptionZoneEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008BAD")]
	[Address(RVA = "0xCBCB20", Offset = "0xCBBF20", VA = "0x180CBCB20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008BAE")]
	[Address(RVA = "0xCBCBC0", Offset = "0xCBBFC0", VA = "0x180CBCBC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008BAF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008BB0")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008BB1")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008BB2")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubscriptionZoneEvent other)
	{
	}

	[Token(Token = "0x6008BB3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008BB4")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
