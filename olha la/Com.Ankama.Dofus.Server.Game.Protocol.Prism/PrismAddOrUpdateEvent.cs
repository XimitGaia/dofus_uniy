using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001BD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismAddOrUpdateEvent : IMessage<PrismAddOrUpdateEvent>, IMessage, IEquatable<PrismAddOrUpdateEvent>, IDeepCloneable<PrismAddOrUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismAddOrUpdateEvent> _parser;

	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40005D5")]
	public const int PrismLocalizedInformationFieldNumber = 1;

	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x18")]
	private PrismLocalizedInformation prismLocalizedInformation_;

	[Token(Token = "0x170003BD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PrismAddOrUpdateEvent> Parser
	{
		[Token(Token = "0x600119D")]
		[Address(RVA = "0xCCE220", Offset = "0xCCD620", VA = "0x180CCE220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600119E")]
		[Address(RVA = "0xCCE170", Offset = "0xCCD570", VA = "0x180CCE170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600119F")]
		[Address(RVA = "0xCCE370", Offset = "0xCCD770", VA = "0x180CCE370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismLocalizedInformation PrismLocalizedInformation
	{
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismAddOrUpdateEvent()
	{
	}

	[Token(Token = "0x60011A1")]
	[Address(RVA = "0xCCE100", Offset = "0xCCD500", VA = "0x180CCE100")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismAddOrUpdateEvent(PrismAddOrUpdateEvent other)
	{
	}

	[Token(Token = "0x60011A2")]
	[Address(RVA = "0xCCDD80", Offset = "0xCCD180", VA = "0x180CCDD80", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismAddOrUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60011A5")]
	[Address(RVA = "0xCCDE20", Offset = "0xCCD220", VA = "0x180CCDE20", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PrismAddOrUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60011A8")]
	[Address(RVA = "0xCCDFA0", Offset = "0xCCD3A0", VA = "0x180CCDFA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60011AB")]
	[Address(RVA = "0xCCDCF0", Offset = "0xCCD0F0", VA = "0x180CCDCF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60011AC")]
	[Address(RVA = "0xCCDED0", Offset = "0xCCD2D0", VA = "0x180CCDED0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PrismAddOrUpdateEvent other)
	{
	}

	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60011AE")]
	[Address(RVA = "0xCCE270", Offset = "0xCCD670", VA = "0x180CCE270", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
