using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007B4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class IgnoreRequest : IMessage<IgnoreRequest>, IMessage, IEquatable<IgnoreRequest>, IDeepCloneable<IgnoreRequest>, IBufferMessage
{
	[Token(Token = "0x4001ACC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<IgnoreRequest> _parser;

	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001ACE")]
	public const int PlayerSearchFieldNumber = 1;

	[Token(Token = "0x4001ACF")]
	[FieldOffset(Offset = "0x18")]
	private PlayerSearch playerSearch_;

	[Token(Token = "0x17001179")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IgnoreRequest> Parser
	{
		[Token(Token = "0x60051DE")]
		[Address(RVA = "0xADF2E0", Offset = "0xADE6E0", VA = "0x180ADF2E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700117A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0xADF230", Offset = "0xADE630", VA = "0x180ADF230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700117B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0xADF430", Offset = "0xADE830", VA = "0x180ADF430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700117C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSearch PlayerSearch
	{
		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60051E1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IgnoreRequest()
	{
	}

	[Token(Token = "0x60051E2")]
	[Address(RVA = "0xADD720", Offset = "0xADCB20", VA = "0x180ADD720")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IgnoreRequest(IgnoreRequest other)
	{
	}

	[Token(Token = "0x60051E3")]
	[Address(RVA = "0xADEEB0", Offset = "0xADE2B0", VA = "0x180ADEEB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IgnoreRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60051E6")]
	[Address(RVA = "0xADEF50", Offset = "0xADE350", VA = "0x180ADEF50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60051E7")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IgnoreRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60051E8")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60051E9")]
	[Address(RVA = "0xADF0D0", Offset = "0xADE4D0", VA = "0x180ADF0D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60051EA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60051EB")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60051EC")]
	[Address(RVA = "0xADEE20", Offset = "0xADE220", VA = "0x180ADEE20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60051ED")]
	[Address(RVA = "0xADF000", Offset = "0xADE400", VA = "0x180ADF000", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IgnoreRequest other)
	{
	}

	[Token(Token = "0x60051EE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60051EF")]
	[Address(RVA = "0xADF330", Offset = "0xADE730", VA = "0x180ADF330", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
